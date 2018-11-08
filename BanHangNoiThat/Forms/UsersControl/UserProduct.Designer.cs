namespace BanHangNoiThat.Forms.UsersControl
{
    partial class UserProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProduct));
            this.CbSapxep = new System.Windows.Forms.ComboBox();
            this.imageSanPham = new System.Windows.Forms.ImageList(this.components);
            this.listViewSanpham = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // CbSapxep
            // 
            this.CbSapxep.FormattingEnabled = true;
            this.CbSapxep.Location = new System.Drawing.Point(25, 8);
            this.CbSapxep.Name = "CbSapxep";
            this.CbSapxep.Size = new System.Drawing.Size(121, 21);
            this.CbSapxep.TabIndex = 1;
            // 
            // imageSanPham
            // 
            this.imageSanPham.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageSanPham.ImageStream")));
            this.imageSanPham.TransparentColor = System.Drawing.Color.Transparent;
            this.imageSanPham.Images.SetKeyName(0, "imagehome.jpg");
            // 
            // listViewSanpham
            // 
            this.listViewSanpham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewSanpham.Location = new System.Drawing.Point(0, 35);
            this.listViewSanpham.Name = "listViewSanpham";
            this.listViewSanpham.Size = new System.Drawing.Size(817, 426);
            this.listViewSanpham.TabIndex = 0;
            this.listViewSanpham.UseCompatibleStateImageBehavior = false;
            this.listViewSanpham.ItemActivate += new System.EventHandler(this.listViewSanpham_ItemActivate);
            // 
            // UserProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CbSapxep);
            this.Controls.Add(this.listViewSanpham);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Name = "UserProduct";
            this.Size = new System.Drawing.Size(817, 461);
            this.Load += new System.EventHandler(this.UserProduct_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox CbSapxep;
        private System.Windows.Forms.ImageList imageSanPham;
        public System.Windows.Forms.ListView listViewSanpham;
    }
}
