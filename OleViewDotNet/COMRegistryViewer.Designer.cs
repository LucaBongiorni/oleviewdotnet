﻿namespace OleViewDotNet
{
    partial class COMRegistryViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label labelFilter;
            System.Windows.Forms.Label labelMode;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COMRegistryViewer));
            this.treeComRegistry = new System.Windows.Forms.TreeView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyGUIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyGUIDCStructureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyGUIDHexStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyObjectTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createInstanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshInterfacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTypeLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeImageList = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            labelFilter = new System.Windows.Forms.Label();
            labelMode = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new System.Drawing.Point(3, 9);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new System.Drawing.Size(32, 13);
            labelFilter.TabIndex = 1;
            labelFilter.Text = "Filter:";
            // 
            // labelMode
            // 
            labelMode.AutoSize = true;
            labelMode.Location = new System.Drawing.Point(417, 9);
            labelMode.Name = "labelMode";
            labelMode.Size = new System.Drawing.Size(37, 13);
            labelMode.TabIndex = 5;
            labelMode.Text = "Mode:";
            // 
            // treeComRegistry
            // 
            this.treeComRegistry.ContextMenuStrip = this.contextMenuStrip;
            this.treeComRegistry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeComRegistry.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeComRegistry.ImageIndex = 0;
            this.treeComRegistry.ImageList = this.treeImageList;
            this.treeComRegistry.Location = new System.Drawing.Point(0, 0);
            this.treeComRegistry.Name = "treeComRegistry";
            this.treeComRegistry.SelectedImageIndex = 0;
            this.treeComRegistry.ShowNodeToolTips = true;
            this.treeComRegistry.Size = new System.Drawing.Size(699, 383);
            this.treeComRegistry.TabIndex = 0;
            this.treeComRegistry.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeComRegistry_BeforeExpand);
            this.treeComRegistry.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeComRegistry_MouseDown);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyGUIDToolStripMenuItem,
            this.copyGUIDCStructureToolStripMenuItem,
            this.copyGUIDHexStringToolStripMenuItem,
            this.copyObjectTagToolStripMenuItem,
            this.createInstanceToolStripMenuItem,
            this.refreshInterfacesToolStripMenuItem,
            this.viewTypeLibraryToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(195, 158);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // copyGUIDToolStripMenuItem
            // 
            this.copyGUIDToolStripMenuItem.Name = "copyGUIDToolStripMenuItem";
            this.copyGUIDToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.copyGUIDToolStripMenuItem.Text = "Copy GUID";
            this.copyGUIDToolStripMenuItem.Click += new System.EventHandler(this.copyGUIDToolStripMenuItem_Click);
            // 
            // copyGUIDCStructureToolStripMenuItem
            // 
            this.copyGUIDCStructureToolStripMenuItem.Name = "copyGUIDCStructureToolStripMenuItem";
            this.copyGUIDCStructureToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.copyGUIDCStructureToolStripMenuItem.Text = "Copy GUID C Structure";
            this.copyGUIDCStructureToolStripMenuItem.Click += new System.EventHandler(this.copyGUIDCStructureToolStripMenuItem_Click);
            // 
            // copyGUIDHexStringToolStripMenuItem
            // 
            this.copyGUIDHexStringToolStripMenuItem.Name = "copyGUIDHexStringToolStripMenuItem";
            this.copyGUIDHexStringToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.copyGUIDHexStringToolStripMenuItem.Text = "Copy GUID Hex String";
            this.copyGUIDHexStringToolStripMenuItem.Click += new System.EventHandler(this.copyGUIDHexStringToolStripMenuItem_Click);
            // 
            // copyObjectTagToolStripMenuItem
            // 
            this.copyObjectTagToolStripMenuItem.Name = "copyObjectTagToolStripMenuItem";
            this.copyObjectTagToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.copyObjectTagToolStripMenuItem.Text = "Copy Object Tag";
            this.copyObjectTagToolStripMenuItem.Click += new System.EventHandler(this.copyObjectTagToolStripMenuItem_Click);
            // 
            // createInstanceToolStripMenuItem
            // 
            this.createInstanceToolStripMenuItem.Name = "createInstanceToolStripMenuItem";
            this.createInstanceToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.createInstanceToolStripMenuItem.Text = "Create Instance";
            this.createInstanceToolStripMenuItem.Click += new System.EventHandler(this.createInstanceToolStripMenuItem_Click);
            // 
            // refreshInterfacesToolStripMenuItem
            // 
            this.refreshInterfacesToolStripMenuItem.Name = "refreshInterfacesToolStripMenuItem";
            this.refreshInterfacesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.refreshInterfacesToolStripMenuItem.Text = "Refresh Interfaces";
            this.refreshInterfacesToolStripMenuItem.Click += new System.EventHandler(this.refreshInterfacesToolStripMenuItem_Click);
            // 
            // viewTypeLibraryToolStripMenuItem
            // 
            this.viewTypeLibraryToolStripMenuItem.Name = "viewTypeLibraryToolStripMenuItem";
            this.viewTypeLibraryToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.viewTypeLibraryToolStripMenuItem.Text = "View Type Library";
            this.viewTypeLibraryToolStripMenuItem.Click += new System.EventHandler(this.viewTypeLibraryToolStripMenuItem_Click);
            // 
            // treeImageList
            // 
            this.treeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeImageList.ImageStream")));
            this.treeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.treeImageList.Images.SetKeyName(0, "folder.ico");
            this.treeImageList.Images.SetKeyName(1, "interface.ico");
            this.treeImageList.Images.SetKeyName(2, "class.ico");
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(labelMode);
            this.splitContainer.Panel1.Controls.Add(this.comboBoxMode);
            this.splitContainer.Panel1.Controls.Add(this.btnApply);
            this.splitContainer.Panel1.Controls.Add(labelFilter);
            this.splitContainer.Panel1.Controls.Add(this.textBoxFilter);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.treeComRegistry);
            this.splitContainer.Size = new System.Drawing.Size(699, 416);
            this.splitContainer.SplitterDistance = 29;
            this.splitContainer.TabIndex = 2;
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "Contains",
            "Begins With",
            "Ends With",
            "Equals",
            "Glob",
            "Regex",
            "Python"});
            this.comboBoxMode.Location = new System.Drawing.Point(458, 5);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMode.TabIndex = 4;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(585, 3);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(41, 6);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(367, 20);
            this.textBoxFilter.TabIndex = 0;
            this.textBoxFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFilter_KeyDown);
            // 
            // COMRegistryViewer
            // 
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "COMRegistryViewer";
            this.Size = new System.Drawing.Size(699, 416);
            this.contextMenuStrip.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeComRegistry;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyGUIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyGUIDCStructureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyGUIDHexStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyObjectTagToolStripMenuItem;
        private System.Windows.Forms.ImageList treeImageList;
        private System.Windows.Forms.ToolStripMenuItem createInstanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshInterfacesToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.ToolStripMenuItem viewTypeLibraryToolStripMenuItem;
    }
}