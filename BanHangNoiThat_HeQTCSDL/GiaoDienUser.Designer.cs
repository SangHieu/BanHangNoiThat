namespace BanHangNoiThat_HeQTCSDL
{
    partial class GiaoDienUser
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
            BunifuAnimatorNS.Animation animation7 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienUser));
            BunifuAnimatorNS.Animation animation9 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation8 = new BunifuAnimatorNS.Animation();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnContainer = new System.Windows.Forms.Panel();
            this.addCart1 = new BanHangNoiThat_HeQTCSDL.Forms.UsersControl.AddCart();
            this.useInformation1 = new BanHangNoiThat_HeQTCSDL.Forms.UsersControl.UseInformation();
            this.userContact1 = new BanHangNoiThat_HeQTCSDL.Forms.UsersControl.UserContact();
            this.userProduct1 = new BanHangNoiThat_HeQTCSDL.Forms.UsersControl.UserProduct();
            this.userHome1 = new BanHangNoiThat_HeQTCSDL.Forms.UsersControl.UserHome();
            this.btnDangXuat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmail = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCart = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnFB = new Bunifu.Framework.UI.BunifuImageButton();
            this.header = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.bunifuContact = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuLogo = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuPanel = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFB)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation7;
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.addCart1);
            this.pnContainer.Controls.Add(this.useInformation1);
            this.pnContainer.Controls.Add(this.userContact1);
            this.pnContainer.Controls.Add(this.userProduct1);
            this.pnContainer.Controls.Add(this.userHome1);
            this.bunifuTransition1.SetDecoration(this.pnContainer, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.pnContainer, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this.pnContainer, BunifuAnimatorNS.DecorationType.None);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 29);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1059, 502);
            this.pnContainer.TabIndex = 7;
            // 
            // addCart1
            // 
            this.bunifuPanel.SetDecoration(this.addCart1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.addCart1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.addCart1, BunifuAnimatorNS.DecorationType.None);
            this.addCart1.Location = new System.Drawing.Point(241, 40);
            this.addCart1.Name = "addCart1";
            this.addCart1.Size = new System.Drawing.Size(817, 461);
            this.addCart1.TabIndex = 4;
            // 
            // useInformation1
            // 
            this.useInformation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuPanel.SetDecoration(this.useInformation1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.useInformation1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.useInformation1, BunifuAnimatorNS.DecorationType.None);
            this.useInformation1.ForeColor = System.Drawing.Color.Purple;
            this.useInformation1.Location = new System.Drawing.Point(242, 41);
            this.useInformation1.Name = "useInformation1";
            this.useInformation1.Size = new System.Drawing.Size(817, 461);
            this.useInformation1.TabIndex = 3;
            // 
            // userContact1
            // 
            this.userContact1.BackColor = System.Drawing.Color.White;
            this.bunifuPanel.SetDecoration(this.userContact1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.userContact1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.userContact1, BunifuAnimatorNS.DecorationType.None);
            this.userContact1.Location = new System.Drawing.Point(242, 40);
            this.userContact1.Name = "userContact1";
            this.userContact1.Size = new System.Drawing.Size(817, 461);
            this.userContact1.TabIndex = 2;
            // 
            // userProduct1
            // 
            this.bunifuPanel.SetDecoration(this.userProduct1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.userProduct1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.userProduct1, BunifuAnimatorNS.DecorationType.None);
            this.userProduct1.ForeColor = System.Drawing.Color.Cornsilk;
            this.userProduct1.Location = new System.Drawing.Point(242, 41);
            this.userProduct1.Name = "userProduct1";
            this.userProduct1.Size = new System.Drawing.Size(817, 461);
            this.userProduct1.TabIndex = 1;
            // 
            // userHome1
            // 
            this.userHome1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userHome1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel.SetDecoration(this.userHome1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.userHome1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.userHome1, BunifuAnimatorNS.DecorationType.None);
            this.userHome1.Location = new System.Drawing.Point(242, 41);
            this.userHome1.Name = "userHome1";
            this.userHome1.Size = new System.Drawing.Size(819, 461);
            this.userHome1.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.AutoSize = true;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuPanel.SetDecoration(this.btnDangXuat, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.btnDangXuat, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnDangXuat, BunifuAnimatorNS.DecorationType.None);
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(746, 13);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(68, 15);
            this.btnDangXuat.TabIndex = 26;
            this.btnDangXuat.Text = "Đăng nhập";
            this.btnDangXuat.Click += new System.EventHandler(this.bntDangXuat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnEmail);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnCart);
            this.panel1.Controls.Add(this.btnFB);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(242, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 41);
            this.panel1.TabIndex = 6;
            // 
            // btnEmail
            // 
            this.btnEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bunifuTransition1.SetDecoration(this.btnEmail, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.btnEmail, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this.btnEmail, BunifuAnimatorNS.DecorationType.None);
            this.btnEmail.ErrorImage = null;
            this.btnEmail.Image = global::BanHangNoiThat_HeQTCSDL.Properties.Resources.Gmail_48px;
            this.btnEmail.ImageActive = null;
            this.btnEmail.Location = new System.Drawing.Point(535, 4);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(30, 30);
            this.btnEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEmail.TabIndex = 25;
            this.btnEmail.TabStop = false;
            this.btnEmail.Zoom = 10;
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bunifuTransition1.SetDecoration(this.btnUser, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.btnUser, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this.btnUser, BunifuAnimatorNS.DecorationType.None);
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageActive = null;
            this.btnUser.Location = new System.Drawing.Point(708, 4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(32, 32);
            this.btnUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUser.TabIndex = 22;
            this.btnUser.TabStop = false;
            this.btnUser.Zoom = 10;
            this.btnUser.Click += new System.EventHandler(this.bunifuUserInf_Click);
            // 
            // btnCart
            // 
            this.btnCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bunifuTransition1.SetDecoration(this.btnCart, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.btnCart, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this.btnCart, BunifuAnimatorNS.DecorationType.None);
            this.btnCart.Image = global::BanHangNoiThat_HeQTCSDL.Properties.Resources.Shopping_Cart_48px;
            this.btnCart.ImageActive = null;
            this.btnCart.Location = new System.Drawing.Point(633, 4);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(30, 30);
            this.btnCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCart.TabIndex = 21;
            this.btnCart.TabStop = false;
            this.btnCart.Zoom = 10;
            this.btnCart.Click += new System.EventHandler(this.bunifuAddCart_Click);
            // 
            // btnFB
            // 
            this.btnFB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bunifuTransition1.SetDecoration(this.btnFB, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.btnFB, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this.btnFB, BunifuAnimatorNS.DecorationType.None);
            this.btnFB.Image = global::BanHangNoiThat_HeQTCSDL.Properties.Resources.Facebook_48px;
            this.btnFB.ImageActive = null;
            this.btnFB.Location = new System.Drawing.Point(585, 4);
            this.btnFB.Name = "btnFB";
            this.btnFB.Size = new System.Drawing.Size(30, 30);
            this.btnFB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFB.TabIndex = 21;
            this.btnFB.TabStop = false;
            this.btnFB.Zoom = 10;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(191)))), ((int)(((byte)(184)))));
            this.header.Controls.Add(this.btnExit);
            this.bunifuTransition1.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1059, 29);
            this.header.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(191)))), ((int)(((byte)(184)))));
            this.bunifuTransition1.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(1029, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 20;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.SideMenu.Controls.Add(this.bunifuContact);
            this.SideMenu.Controls.Add(this.bunifuProduct);
            this.SideMenu.Controls.Add(this.bunifuHome);
            this.SideMenu.Controls.Add(this.btnMenu);
            this.bunifuTransition1.SetDecoration(this.SideMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.SideMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this.SideMenu, BunifuAnimatorNS.DecorationType.None);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 29);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(242, 502);
            this.SideMenu.TabIndex = 4;
            // 
            // bunifuContact
            // 
            this.bunifuContact.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.bunifuContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuContact.BorderRadius = 0;
            this.bunifuContact.ButtonText = "            Liên hệ";
            this.bunifuContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuPanel.SetDecoration(this.bunifuContact, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.bunifuContact, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuContact, BunifuAnimatorNS.DecorationType.None);
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
            this.bunifuContact.Location = new System.Drawing.Point(1, 163);
            this.bunifuContact.Name = "bunifuContact";
            this.bunifuContact.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.bunifuContact.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.bunifuContact.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuContact.selected = false;
            this.bunifuContact.Size = new System.Drawing.Size(239, 48);
            this.bunifuContact.TabIndex = 19;
            this.bunifuContact.Text = "            Liên hệ";
            this.bunifuContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuContact.Textcolor = System.Drawing.Color.Silver;
            this.bunifuContact.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuContact.Click += new System.EventHandler(this.bunifuContact_Click);
            // 
            // bunifuProduct
            // 
            this.bunifuProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.bunifuProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuProduct.BorderRadius = 0;
            this.bunifuProduct.ButtonText = "             Sản phẩm";
            this.bunifuProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuPanel.SetDecoration(this.bunifuProduct, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.bunifuProduct, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuProduct, BunifuAnimatorNS.DecorationType.None);
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
            this.bunifuProduct.Size = new System.Drawing.Size(239, 48);
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
            this.bunifuPanel.SetDecoration(this.bunifuHome, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.bunifuHome, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuHome, BunifuAnimatorNS.DecorationType.None);
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
            this.bunifuHome.Size = new System.Drawing.Size(239, 48);
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
            this.bunifuTransition1.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLogo.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(210, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(20, 20);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 14;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.bunifuMenu_Click);
            // 
            // bunifuLogo
            // 
            this.bunifuLogo.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuLogo.Cursor = null;
            animation9.AnimateOnlyDifferences = true;
            animation9.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.BlindCoeff")));
            animation9.LeafCoeff = 0F;
            animation9.MaxTime = 1F;
            animation9.MinTime = 0F;
            animation9.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicCoeff")));
            animation9.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicShift")));
            animation9.MosaicSize = 0;
            animation9.Padding = new System.Windows.Forms.Padding(0);
            animation9.RotateCoeff = 0F;
            animation9.RotateLimit = 0F;
            animation9.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.ScaleCoeff")));
            animation9.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.SlideCoeff")));
            animation9.TimeCoeff = 0F;
            animation9.TransparencyCoeff = 0F;
            this.bunifuLogo.DefaultAnimation = animation9;
            // 
            // bunifuPanel
            // 
            this.bunifuPanel.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.bunifuPanel.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(0);
            animation8.RotateCoeff = 0F;
            animation8.RotateLimit = 0F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 0F;
            this.bunifuPanel.DefaultAnimation = animation8;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // GiaoDienUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SideMenu);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.header);
            this.bunifuLogo.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPanel.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiaoDienUser";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GiaodienUser_Load);
            this.pnContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFB)).EndInit();
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.SideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel pnContainer;
        private BunifuAnimatorNS.BunifuTransition bunifuLogo;
        private BunifuAnimatorNS.BunifuTransition bunifuPanel;
        private System.Windows.Forms.Label btnDangXuat;
        private Bunifu.Framework.UI.BunifuImageButton btnEmail;
        private Bunifu.Framework.UI.BunifuImageButton btnUser;
        private Bunifu.Framework.UI.BunifuImageButton btnCart;
        private Bunifu.Framework.UI.BunifuImageButton btnFB;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuContact;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuProduct;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuHome;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel SideMenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private BanHangNoiThat_HeQTCSDL.Forms.UsersControl.AddCart addCart1;
        private BanHangNoiThat_HeQTCSDL.Forms.UsersControl.UseInformation useInformation1;
        private BanHangNoiThat_HeQTCSDL.Forms.UsersControl.UserContact userContact1;
        private BanHangNoiThat_HeQTCSDL.Forms.UsersControl.UserProduct userProduct1;
        private BanHangNoiThat_HeQTCSDL.Forms.UsersControl.UserHome userHome1;
    }
}

