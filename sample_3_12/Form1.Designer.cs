namespace sample_3_12 {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      DevExpress.XtraEditors.TileItemFrame tileItemFrame1 = new DevExpress.XtraEditors.TileItemFrame();
      DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraEditors.TileItemFrame tileItemFrame2 = new DevExpress.XtraEditors.TileItemFrame();
      DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
      this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
      this.windowsUIView1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
      this.tileContainer1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
      this.RichEditUserControlTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
      this.richEditUserControlDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
      this.GridUserControlTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
      this.gridUserControlDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
      this.page1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
      this.page2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
      this.pageGroup1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(this.components);
      this.tabbedGroup1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup(this.components);
      this.tile1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
      this.tile2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.RichEditUserControlTile)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.richEditUserControlDocument)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GridUserControlTile)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridUserControlDocument)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.page1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.page2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pageGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabbedGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tile1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tile2)).BeginInit();
      this.SuspendLayout();
      // 
      // documentManager1
      // 
      this.documentManager1.ContainerControl = this;
      this.documentManager1.View = this.windowsUIView1;
      this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView1});
      // 
      // windowsUIView1
      // 
      this.windowsUIView1.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.tileContainer1,
            this.page1,
            this.page2,
            this.pageGroup1,
            this.tabbedGroup1});
      this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.richEditUserControlDocument,
            this.gridUserControlDocument});
      this.windowsUIView1.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.RichEditUserControlTile,
            this.GridUserControlTile,
            this.tile1,
            this.tile2});
      // 
      // tileContainer1
      // 
      this.tileContainer1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.RichEditUserControlTile,
            this.GridUserControlTile,
            this.tile1,
            this.tile2});
      this.tileContainer1.Name = "tileContainer1";
      // 
      // RichEditUserControlTile
      // 
      this.RichEditUserControlTile.ActivationTarget = this.page1;
      tileItemElement1.Text = "Rich";
      tileItemElement2.Text = "Edit";
      tileItemElement3.Text = "User";
      tileItemElement4.Text = "Control";
      tileItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
      tileItemElement5.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
      tileItemElement5.ImageOptions.ImageToTextIndent = 0;
      tileItemElement5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
      tileItemElement5.ImageOptions.SvgImageSize = new System.Drawing.Size(64, 64);
      tileItemElement5.Text = "Rich Edit User Control";
      this.RichEditUserControlTile.Elements.Add(tileItemElement1);
      this.RichEditUserControlTile.Elements.Add(tileItemElement2);
      this.RichEditUserControlTile.Elements.Add(tileItemElement3);
      this.RichEditUserControlTile.Elements.Add(tileItemElement4);
      this.RichEditUserControlTile.Elements.Add(tileItemElement5);
      this.RichEditUserControlTile.Name = "RichEditUserControlTile";
      // 
      // richEditUserControlDocument
      // 
      this.richEditUserControlDocument.Caption = "RichEditUserControl";
      this.richEditUserControlDocument.ControlName = "RichEditUserControl";
      this.richEditUserControlDocument.ControlTypeName = "sample_3_12.RichEditUserControl";
      // 
      // GridUserControlTile
      // 
      this.GridUserControlTile.ActivationTarget = this.page2;
      tileItemElement6.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 32F, System.Drawing.FontStyle.Bold);
      tileItemElement6.Appearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold;
      tileItemElement6.Appearance.Normal.Options.UseFont = true;
      tileItemElement6.Appearance.Normal.Options.UseTextOptions = true;
      tileItemElement6.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      tileItemElement6.Text = "Grid User Control";
      tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
      tileItemFrame1.Elements.Add(tileItemElement6);
      tileItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
      tileItemElement7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
      tileItemElement7.ImageOptions.SvgImageSize = new System.Drawing.Size(150, 150);
      tileItemElement7.Text = "";
      tileItemFrame2.Elements.Add(tileItemElement7);
      this.GridUserControlTile.Frames.Add(tileItemFrame1);
      this.GridUserControlTile.Frames.Add(tileItemFrame2);
      this.tileContainer1.SetID(this.GridUserControlTile, 1);
      this.GridUserControlTile.Name = "GridUserControlTile";
      this.GridUserControlTile.Properties.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollLeft;
      this.GridUserControlTile.Properties.FrameAnimationInterval = 500;
      // 
      // gridUserControlDocument
      // 
      this.gridUserControlDocument.Caption = "GridUserControl";
      this.gridUserControlDocument.ControlName = "GridUserControl";
      this.gridUserControlDocument.ControlTypeName = "sample_3_12.GridUserControl";
      // 
      // page1
      // 
      this.page1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Button", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", -1, true, null, true, false, true, null, -1, false)});
      this.page1.Document = this.richEditUserControlDocument;
      this.page1.Name = "page1";
      this.page1.Parent = this.tileContainer1;
      // 
      // page2
      // 
      this.page2.Document = this.gridUserControlDocument;
      this.page2.Name = "page2";
      this.page2.Parent = this.tileContainer1;
      // 
      // pageGroup1
      // 
      this.pageGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.richEditUserControlDocument,
            this.gridUserControlDocument});
      this.pageGroup1.Name = "pageGroup1";
      this.pageGroup1.Parent = this.tileContainer1;
      // 
      // tabbedGroup1
      // 
      this.tabbedGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.richEditUserControlDocument,
            this.gridUserControlDocument});
      this.tabbedGroup1.Name = "tabbedGroup1";
      this.tabbedGroup1.Parent = this.tileContainer1;
      // 
      // tile1
      // 
      this.tile1.ActivationTarget = this.pageGroup1;
      this.tileContainer1.SetID(this.tile1, 2);
      this.tile1.Name = "tile1";
      // 
      // tile2
      // 
      this.tile2.ActivationTarget = this.tabbedGroup1;
      this.tileContainer1.SetID(this.tile2, 3);
      this.tile2.Name = "tile2";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(853, 543);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Form1";
      this.Text = "Form1";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.RichEditUserControlTile)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.richEditUserControlDocument)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GridUserControlTile)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridUserControlDocument)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.page1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.page2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pageGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabbedGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tile1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tile2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
    private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
    private DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer1;
    private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile RichEditUserControlTile;
    private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document richEditUserControlDocument;
    private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile GridUserControlTile;
    private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document gridUserControlDocument;
    private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page page1;
    private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page page2;
    private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile1;
    private DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup pageGroup1;
    private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile2;
    private DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup tabbedGroup1;
  }
}

