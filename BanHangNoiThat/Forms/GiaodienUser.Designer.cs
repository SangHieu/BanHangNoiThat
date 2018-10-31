namespace BanHangNoiThat.Forms
{
    partial class GiaodienUser
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaodienUser));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuPanel = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.SideMenu = new System.Windows.Forms.Panel();
            this.bunifuContact = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSale = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userContact1 = new BanHangNoiThat.Forms.UsersControl.UserContact();
            this.userSale1 = new BanHangNoiThat.Forms.UsersControl.UserSale();
            this.userProduct1 = new BanHangNoiThat.Forms.UsersControl.UserProduct();
            this.userHome1 = new BanHangNoiThat.Forms.UsersControl.UserHome();
            this.bunifuLogo = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(191)))), ((int)(((byte)(184)))));
            this.header.Controls.Add(this.bunifuImageButton2);
            this.bunifuPanel.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1036, 29);
            this.header.TabIndex = 1;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(191)))), ((int)(((byte)(184)))));
            this.bunifuPanel.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1004, 3);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 20;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuPanel
            // 
            this.bunifuPanel.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.bunifuPanel.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuPanel.DefaultAnimation = animation1;
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.SideMenu.Controls.Add(this.bunifuContact);
            this.SideMenu.Controls.Add(this.bunifuSale);
            this.SideMenu.Controls.Add(this.bunifuProduct);
            this.SideMenu.Controls.Add(this.bunifuHome);
            this.SideMenu.Controls.Add(this.btnMenu);
            this.bunifuPanel.SetDecoration(this.SideMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.SideMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.SideMenu, BunifuAnimatorNS.DecorationType.None);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 29);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(215, 502);
            this.SideMenu.TabIndex = 0;
            // 
            // bunifuContact
            // 
            this.bunifuContact.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.bunifuContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuContact.BorderRadius = 0;
            this.bunifuContact.ButtonText = "            Liên hệ";
            this.bunifuContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuContact, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.bunifuContact, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this.bunifuContact, BunifuAnimatorNS.DecorationType.None);
            this.bunifuContact.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuContact.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuContact.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuContact.Iconimage")));
            this.bunifuContact.Iconimage_right = null;
            this.bunifuContact.Iconimage_right_Selected = null;
            this.bunifuContact.Iconimage_Selected = null;
            this.bunifuContact.IconMarginLeft = 0;
            this.bunifuContact.IconMarginRight = 0;
            this.bunifuContact.IconRightVisible = true;
            this.bunifuContact.IconRightZoom = 0D;
            this.bunifuContact.IconVisible = true;
            this.bunifuContact.IconZoom = 48D;
            this.bunifuContact.IsTab = false;
            this.bunifuContact.Location = new System.Drawing.Point(0, 222);
            this.bunifuContact.Name = "bunifuContact";
            this.bunifuContact.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.bunifuContact.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.bunifuContact.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuContact.selected = false;
            this.bunifuContact.Size = new System.Drawing.Size(213, 48);
            this.bunifuContact.TabIndex = 19;
            this.bunifuContact.Text = "            Liên hệ";
            this.bunifuContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuContact.Textcolor = System.Drawing.Color.Silver;
            this.bunifuContact.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuContact.Click += new System.EventHandler(this.bunifuContact_Click);
            // 
            // bunifuSale
            // 
            this.bunifuSale.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.bunifuSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSale.BorderRadius = 0;
            this.bunifuSale.ButtonText = "            Khuyến mãi";
            this.bunifuSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuSale, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.bunifuSale, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this.bunifuSale, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSale.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuSale.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuSale.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuSale.Iconimage")));
            this.bunifuSale.Iconimage_right = null;
            this.bunifuSale.Iconimage_right_Selected = null;
            this.bunifuSale.Iconimage_Selected = null;
            this.bunifuSale.IconMarginLeft = 0;
            this.bunifuSale.IconMarginRight = 0;
            this.bunifuSale.IconRightVisible = true;
            this.bunifuSale.IconRightZoom = 0D;
            this.bunifuSale.IconVisible = true;
            this.bunifuSale.IconZoom = 48D;
            this.bunifuSale.IsTab = false;
            this.bunifuSale.Location = new System.Drawing.Point(0, 168);
            this.bunifuSale.Name = "bunifuSale";
            this.bunifuSale.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.bunifuSale.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.bunifuSale.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuSale.selected = false;
            this.bunifuSale.Size = new System.Drawing.Size(213, 48);
            this.bunifuSale.TabIndex = 18;
            this.bunifuSale.Text = "            Khuyến mãi";
            this.bunifuSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuSale.Textcolor = System.Drawing.Color.Silver;
            this.bunifuSale.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSale.Click += new System.EventHandler(this.bunifuSale_Click);
            // 
            // bunifuProduct
            // 
            this.bunifuProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.bunifuProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuProduct.BorderRadius = 0;
            this.bunifuProduct.ButtonText = "             Sản phẩm";
            this.bunifuProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuProduct, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.bunifuProduct, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this.bunifuProduct, BunifuAnimatorNS.DecorationType.None);
            this.bunifuProduct.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuProduct.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuProduct.Iconimage")));
            this.bunifuProduct.Iconimage_right = null;
            this.bunifuProduct.Iconimage_right_Selected = null;
            this.bunifuProduct.Iconimage_Selected = null;
            this.bunifuProduct.IconMarginLeft = 0;
            this.bunifuProduct.IconMarginRight = 0;
            this.bunifuProduct.IconRightVisible = true;
            this.bunifuProduct.IconRightZoom = 0D;
            this.bunifuProduct.IconVisible = true;
            this.bunifuProduct.IconZoom = 48D;
            this.bunifuProduct.IsTab = false;
            this.bunifuProduct.Location = new System.Drawing.Point(-1, 109);
            this.bunifuProduct.Name = "bunifuProduct";
            this.bunifuProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.bunifuProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.bunifuProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuProduct.selected = false;
            this.bunifuProduct.Size = new System.Drawing.Size(213, 48);
            this.bunifuProduct.TabIndex = 16;
            this.bunifuProduct.Text = "             Sản phẩm";
            this.bunifuProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuProduct.Textcolor = System.Drawing.Color.Silver;
            this.bunifuProduct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuProduct.Click += new System.EventHandler(this.bunifuProduct_Click);
            // 
            // bunifuHome
            // 
            this.bunifuHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.bunifuHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuHome.BorderRadius = 0;
            this.bunifuHome.ButtonText = "           Trang chủ";
            this.bunifuHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuHome, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.bunifuHome, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this.bunifuHome, BunifuAnimatorNS.DecorationType.None);
            this.bunifuHome.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuHome.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuHome.Iconimage")));
            this.bunifuHome.Iconimage_right = null;
            this.bunifuHome.Iconimage_right_Selected = null;
            this.bunifuHome.Iconimage_Selected = null;
            this.bunifuHome.IconMarginLeft = 0;
            this.bunifuHome.IconMarginRight = 0;
            this.bunifuHome.IconRightVisible = true;
            this.bunifuHome.IconRightZoom = 0D;
            this.bunifuHome.IconVisible = true;
            this.bunifuHome.IconZoom = 48D;
            this.bunifuHome.IsTab = false;
            this.bunifuHome.Location = new System.Drawing.Point(0, 50);
            this.bunifuHome.Name = "bunifuHome";
            this.bunifuHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.bunifuHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.bunifuHome.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuHome.selected = false;
            this.bunifuHome.Size = new System.Drawing.Size(213, 48);
            this.bunifuHome.TabIndex = 14;
            this.bunifuHome.Text = "           Trang chủ";
            this.bunifuHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuHome.Textcolor = System.Drawing.Color.Silver;
            this.bunifuHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuHome.Click += new System.EventHandler(this.bunifuHome_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.bunifuPanel.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(183, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(20, 20);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 14;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.bunifuImageButton6);
            this.panel1.Controls.Add(this.bunifuImageButton4);
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuPanel.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(215, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 41);
            this.panel1.TabIndex = 2;
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bunifuPanel.SetDecoration(this.bunifuImageButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.bunifuImageButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton6.Image = global::BanHangNoiThat.Properties.Resources.Gmail_48px;
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(608, 4);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 25;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bunifuPanel.SetDecoration(this.bunifuImageButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.bunifuImageButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(782, 4);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(32, 32);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 22;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bunifuPanel.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton3.Image = global::BanHangNoiThat.Properties.Resources.Shopping_Cart_48px;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(706, 4);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 21;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bunifuPanel.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = global::BanHangNoiThat.Properties.Resources.Facebook_48px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(658, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 21;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userContact1);
            this.panel2.Controls.Add(this.userSale1);
            this.panel2.Controls.Add(this.userProduct1);
            this.panel2.Controls.Add(this.userHome1);
            this.bunifuPanel.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(215, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 461);
            this.panel2.TabIndex = 3;
            // 
            // userContact1
            // 
            this.userContact1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.userContact1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.userContact1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this.userContact1, BunifuAnimatorNS.DecorationType.None);
            this.userContact1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userContact1.Location = new System.Drawing.Point(0, 0);
            this.userContact1.Name = "userContact1";
            this.userContact1.Size = new System.Drawing.Size(821, 461);
            this.userContact1.TabIndex = 3;
            // 
            // userSale1
            // 
            this.userSale1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.userSale1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.userSale1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this.userSale1, BunifuAnimatorNS.DecorationType.None);
            this.userSale1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userSale1.Location = new System.Drawing.Point(0, 0);
            this.userSale1.Name = "userSale1";
            this.userSale1.Size = new System.Drawing.Size(821, 461);
            this.userSale1.TabIndex = 2;
            this.userSale1.Load += new System.EventHandler(this.userSale1_Load);
            // 
            // userProduct1
            // 
            this.bunifuTransition1.SetDecoration(this.userProduct1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.userProduct1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this.userProduct1, BunifuAnimatorNS.DecorationType.None);
            this.userProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userProduct1.ForeColor = System.Drawing.Color.Cornsilk;
            this.userProduct1.Location = new System.Drawing.Point(0, 0);
            this.userProduct1.Name = "userProduct1";
            this.userProduct1.Size = new System.Drawing.Size(821, 461);
            this.userProduct1.TabIndex = 1;
            // 
            // userHome1
            // 
            this.userHome1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.userHome1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.userHome1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this.userHome1, BunifuAnimatorNS.DecorationType.None);
            this.userHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userHome1.Location = new System.Drawing.Point(0, 0);
            this.userHome1.Name = "userHome1";
            this.userHome1.Size = new System.Drawing.Size(821, 461);
            this.userHome1.TabIndex = 0;
            // 
            // bunifuLogo
            // 
            this.bunifuLogo.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuLogo.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuLogo.DefaultAnimation = animation2;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation3;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // GiaodienUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1036, 531);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SideMenu);
            this.Controls.Add(this.header);
            this.bunifuLogo.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiaodienUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiaodienUser";
            this.Load += new System.EventHandler(this.GiaodienUser_Load);
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.SideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition bunifuPanel;
        private BunifuAnimatorNS.BunifuTransition bunifuLogo;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuHome;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuProduct;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuSale;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuContact;
        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private UsersControl.UserHome userHome1;
        private UsersControl.UserContact userContact1;
        private UsersControl.UserSale userSale1;
        private UsersControl.UserProduct userProduct1;
    }
}