namespace BanHangNoiThat.Forms.UsersControl
{
    partial class AddCart
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("tên sản phẩm", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Sản phẩm 2", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCart));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dathang = new Bunifu.Framework.UI.BunifuThinButton2();
            this.listviewsp = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.giasp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(97)))), ((int)(((byte)(30)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(97)))), ((int)(((byte)(30)))));
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Sửa";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(114)))), ((int)(((byte)(36)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(114)))), ((int)(((byte)(36)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(477, 401);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(98, 51);
            this.bunifuThinButton21.TabIndex = 15;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dathang
            // 
            this.dathang.ActiveBorderThickness = 1;
            this.dathang.ActiveCornerRadius = 20;
            this.dathang.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(156)))), ((int)(((byte)(17)))));
            this.dathang.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.dathang.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(156)))), ((int)(((byte)(17)))));
            this.dathang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dathang.BackColor = System.Drawing.SystemColors.Control;
            this.dathang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dathang.BackgroundImage")));
            this.dathang.ButtonText = "Thanh toán";
            this.dathang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dathang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dathang.ForeColor = System.Drawing.Color.SeaGreen;
            this.dathang.IdleBorderThickness = 1;
            this.dathang.IdleCornerRadius = 20;
            this.dathang.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(0)))), ((int)(((byte)(12)))));
            this.dathang.IdleForecolor = System.Drawing.Color.White;
            this.dathang.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(0)))), ((int)(((byte)(12)))));
            this.dathang.Location = new System.Drawing.Point(591, 401);
            this.dathang.Margin = new System.Windows.Forms.Padding(5);
            this.dathang.Name = "dathang";
            this.dathang.Size = new System.Drawing.Size(208, 51);
            this.dathang.TabIndex = 14;
            this.dathang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listviewsp
            // 
            this.listviewsp.Dock = System.Windows.Forms.DockStyle.Top;
            this.listviewsp.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listviewsp.LargeImageList = this.imageList1;
            this.listviewsp.Location = new System.Drawing.Point(0, 0);
            this.listviewsp.Name = "listviewsp";
            this.listviewsp.Size = new System.Drawing.Size(817, 387);
            this.listviewsp.SmallImageList = this.imageList1;
            this.listviewsp.TabIndex = 27;
            this.listviewsp.UseCompatibleStateImageBehavior = false;
            this.listviewsp.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1_62924.jpg");
            // 
            // giasp
            // 
            this.giasp.AutoSize = true;
            this.giasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giasp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(114)))), ((int)(((byte)(36)))));
            this.giasp.Location = new System.Drawing.Point(19, 412);
            this.giasp.Name = "giasp";
            this.giasp.Size = new System.Drawing.Size(114, 25);
            this.giasp.TabIndex = 17;
            this.giasp.Text = "Tổng tiền :";
            // 
            // AddCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listviewsp);
            this.Controls.Add(this.giasp);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.dathang);
            this.Name = "AddCart";
            this.Size = new System.Drawing.Size(817, 461);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 dathang;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ListView listviewsp;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label giasp;
    }
}
