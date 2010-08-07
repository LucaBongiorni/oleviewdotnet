﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace OleViewDotNet
{
    public partial class ROTViewer : DockContent
    {
        private COMRegistry m_reg;

        struct MonikerInfo
        {
            public string strDisplayName;
            public Guid clsid;
            public IMoniker moniker;

            public MonikerInfo(string name, Guid guid, IMoniker mon)
            {
                strDisplayName = name;
                clsid = guid;
                moniker = mon;
            }
        }

        public ROTViewer(COMRegistry reg)
        {
            m_reg = reg;
            InitializeComponent();
        }

        void LoadROT()
        {
            IBindCtx bindCtx;

            listViewROT.Items.Clear();
            try
            {
                bindCtx = COMUtilities.CreateBindCtx(0);                
                IRunningObjectTable rot;
                IEnumMoniker enumMoniker;
                IMoniker[] moniker = new IMoniker[1];                    

                bindCtx.GetRunningObjectTable(out rot);
                rot.EnumRunning(out enumMoniker);
                while (enumMoniker.Next(1, moniker, IntPtr.Zero) == 0)
                {
                    string strDisplayName;
                    Guid clsid;

                    moniker[0].GetDisplayName(bindCtx, null, out strDisplayName);
                    moniker[0].GetClassID(out clsid);
                    ListViewItem item = listViewROT.Items.Add(strDisplayName);
                    item.Tag = new MonikerInfo(strDisplayName, clsid, moniker[0]);
                    
                    if (m_reg.Clsids.ContainsKey(clsid))
                    {
                        item.SubItems.Add(m_reg.Clsids[clsid].Name);
                    }
                    else
                    {
                        item.SubItems.Add(clsid.ToString("B"));
                    }
                }                
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }

            listViewROT.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void ROTViewer_Load(object sender, EventArgs e)
        {
            listViewROT.Columns.Add("Display Name");
            listViewROT.Columns.Add("CLSID");
            LoadROT();
            TabText = "ROT";
        }

        private void menuROT_Click(object sender, EventArgs e)
        {

        }

        private void menuROTRefresh_Click(object sender, EventArgs e)
        {
            LoadROT();
        }

        private void menuROTBindToObject_Click(object sender, EventArgs e)
        {
            if (listViewROT.SelectedItems.Count != 0)
            {
                MonikerInfo info = (MonikerInfo)(listViewROT.SelectedItems[0].Tag);

                Dictionary<string, string> props = new Dictionary<string, string>();
                props.Add("Display Name", info.strDisplayName);
                props.Add("CLSID", info.clsid.ToString("B"));

                try
                {
                    IBindCtx bindCtx = COMUtilities.CreateBindCtx(0);                                        
                    Guid unk = COMInterfaceEntry.IID_IUnknown;
                    object comObj;
                    Type dispType;

                    info.moniker.BindToObject(bindCtx, null, ref unk, out comObj);
                    dispType = COMUtilities.GetDispatchTypeInfo(comObj);
                    ObjectInformation view = new ObjectInformation(info.strDisplayName, comObj, props, m_reg.GetInterfacesForObject(comObj));
                    view.ShowHint = DockState.Document;
                    view.Show(this.DockPanel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}