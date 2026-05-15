namespace RTC3D.UserControl.Setup
{
    partial class uc_list_tool
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            treeList1 = new DevExpress.XtraTreeList.TreeList();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)treeList1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)simpleLabelItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)simpleLabelItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)simpleSeparator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)simpleSeparator2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(simpleButton1);
            layoutControl1.Controls.Add(treeList1);
            layoutControl1.Controls.Add(textEdit1);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(980, 155, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(735, 447);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new Point(642, 29);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(79, 22);
            simpleButton1.StyleController = layoutControl1;
            simpleButton1.TabIndex = 6;
            simpleButton1.Text = "Add Tools";
            // 
            // treeList1
            // 
            treeList1.Location = new Point(12, 55);
            treeList1.Name = "treeList1";
            treeList1.Size = new Size(711, 380);
            treeList1.TabIndex = 5;
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(96, 29);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(542, 20);
            textEdit1.StyleController = layoutControl1;
            textEdit1.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { simpleLabelItem1, simpleLabelItem2, simpleSeparator1, simpleSeparator2, layoutControlItem1, layoutControlItem2, layoutControlItem3 });
            Root.Name = "Root";
            Root.Size = new Size(735, 447);
            Root.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            simpleLabelItem1.Location = new Point(0, 0);
            simpleLabelItem1.Name = "simpleLabelItem1";
            simpleLabelItem1.Size = new Size(715, 17);
            simpleLabelItem1.Text = "Application Tools";
            simpleLabelItem1.TextSize = new Size(80, 13);
            // 
            // simpleLabelItem2
            // 
            simpleLabelItem2.Location = new Point(0, 17);
            simpleLabelItem2.Name = "simpleLabelItem2";
            simpleLabelItem2.Size = new Size(84, 26);
            simpleLabelItem2.Text = "Search";
            simpleLabelItem2.TextSize = new Size(80, 13);
            // 
            // simpleSeparator1
            // 
            simpleSeparator1.Location = new Point(714, 17);
            simpleSeparator1.Name = "simpleSeparator1";
            simpleSeparator1.Size = new Size(1, 26);
            // 
            // simpleSeparator2
            // 
            simpleSeparator2.Location = new Point(713, 17);
            simpleSeparator2.Name = "simpleSeparator2";
            simpleSeparator2.Size = new Size(1, 26);
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = textEdit1;
            layoutControlItem1.Location = new Point(84, 17);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(546, 26);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = treeList1;
            layoutControlItem2.Location = new Point(0, 43);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(715, 384);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = simpleButton1;
            layoutControlItem3.Location = new Point(630, 17);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(83, 26);
            layoutControlItem3.TextVisible = false;
            // 
            // uc_list_tool
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(layoutControl1);
            Name = "uc_list_tool";
            Size = new Size(735, 447);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)treeList1).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)simpleLabelItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)simpleLabelItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)simpleSeparator1).EndInit();
            ((System.ComponentModel.ISupportInitialize)simpleSeparator2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
