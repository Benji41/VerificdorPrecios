
namespace Verificador_Precios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lb_porfavor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_porfavor2 = new System.Windows.Forms.Label();
            this.lb_desc_nombre = new System.Windows.Forms.Label();
            this.lb_nombreP = new System.Windows.Forms.Label();
            this.lb_desc_precio = new System.Windows.Forms.Label();
            this.lb_precioP = new System.Windows.Forms.Label();
            this.lb_desc_stock = new System.Windows.Forms.Label();
            this.lb_stockP = new System.Windows.Forms.Label();
            this.lb_outcome = new System.Windows.Forms.Label();
            this.lb_descP = new System.Windows.Forms.Label();
            this.lb_porfavor3 = new System.Windows.Forms.Label();
            this.lb_desc_desc = new System.Windows.Forms.Label();
            this.img_outcome = new System.Windows.Forms.PictureBox();
            this.img_producto = new System.Windows.Forms.PictureBox();
            this.img_barcode = new System.Windows.Forms.PictureBox();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.lb_outcome_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_outcome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_barcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lb_porfavor
            // 
            this.lb_porfavor.AutoSize = true;
            this.lb_porfavor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_porfavor.ForeColor = System.Drawing.Color.Gold;
            this.lb_porfavor.Location = new System.Drawing.Point(157, 205);
            this.lb_porfavor.Name = "lb_porfavor";
            this.lb_porfavor.Size = new System.Drawing.Size(1382, 55);
            this.lb_porfavor.TabIndex = 1;
            this.lb_porfavor.Text = "Por favor pase el codigo de barras por debajo del escaner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_porfavor2
            // 
            this.lb_porfavor2.AutoSize = true;
            this.lb_porfavor2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_porfavor2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_porfavor2.Location = new System.Drawing.Point(164, 275);
            this.lb_porfavor2.Name = "lb_porfavor2";
            this.lb_porfavor2.Size = new System.Drawing.Size(940, 40);
            this.lb_porfavor2.TabIndex = 5;
            this.lb_porfavor2.Text = "¡Busque el codigo de barra de su producto y lleveselo!";
            // 
            // lb_desc_nombre
            // 
            this.lb_desc_nombre.AutoSize = true;
            this.lb_desc_nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_desc_nombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_desc_nombre.Location = new System.Drawing.Point(15, 239);
            this.lb_desc_nombre.Name = "lb_desc_nombre";
            this.lb_desc_nombre.Size = new System.Drawing.Size(341, 75);
            this.lb_desc_nombre.TabIndex = 6;
            this.lb_desc_nombre.Text = "Producto:";
            // 
            // lb_nombreP
            // 
            this.lb_nombreP.AutoSize = true;
            this.lb_nombreP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombreP.ForeColor = System.Drawing.Color.Gold;
            this.lb_nombreP.Location = new System.Drawing.Point(56, 239);
            this.lb_nombreP.Name = "lb_nombreP";
            this.lb_nombreP.Size = new System.Drawing.Size(167, 55);
            this.lb_nombreP.TabIndex = 7;
            this.lb_nombreP.Text = "label3";
            // 
            // lb_desc_precio
            // 
            this.lb_desc_precio.AutoSize = true;
            this.lb_desc_precio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_desc_precio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_desc_precio.Location = new System.Drawing.Point(15, 262);
            this.lb_desc_precio.Name = "lb_desc_precio";
            this.lb_desc_precio.Size = new System.Drawing.Size(255, 75);
            this.lb_desc_precio.TabIndex = 8;
            this.lb_desc_precio.Text = "Precio:";
            // 
            // lb_precioP
            // 
            this.lb_precioP.AutoSize = true;
            this.lb_precioP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_precioP.ForeColor = System.Drawing.Color.Gold;
            this.lb_precioP.Location = new System.Drawing.Point(56, 262);
            this.lb_precioP.Name = "lb_precioP";
            this.lb_precioP.Size = new System.Drawing.Size(167, 55);
            this.lb_precioP.TabIndex = 9;
            this.lb_precioP.Text = "label5";
            // 
            // lb_desc_stock
            // 
            this.lb_desc_stock.AutoSize = true;
            this.lb_desc_stock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_desc_stock.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_desc_stock.Location = new System.Drawing.Point(15, 284);
            this.lb_desc_stock.Name = "lb_desc_stock";
            this.lb_desc_stock.Size = new System.Drawing.Size(348, 75);
            this.lb_desc_stock.TabIndex = 10;
            this.lb_desc_stock.Text = "Unidades:";
            // 
            // lb_stockP
            // 
            this.lb_stockP.AutoSize = true;
            this.lb_stockP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stockP.ForeColor = System.Drawing.Color.Gold;
            this.lb_stockP.Location = new System.Drawing.Point(56, 284);
            this.lb_stockP.Name = "lb_stockP";
            this.lb_stockP.Size = new System.Drawing.Size(167, 55);
            this.lb_stockP.TabIndex = 11;
            this.lb_stockP.Text = "label7";
            // 
            // lb_outcome
            // 
            this.lb_outcome.AutoSize = true;
            this.lb_outcome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_outcome.Location = new System.Drawing.Point(15, 302);
            this.lb_outcome.Name = "lb_outcome";
            this.lb_outcome.Size = new System.Drawing.Size(220, 75);
            this.lb_outcome.TabIndex = 12;
            this.lb_outcome.Text = "label8";
            // 
            // lb_descP
            // 
            this.lb_descP.AutoSize = true;
            this.lb_descP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_descP.ForeColor = System.Drawing.Color.Gold;
            this.lb_descP.Location = new System.Drawing.Point(77, 302);
            this.lb_descP.Name = "lb_descP";
            this.lb_descP.Size = new System.Drawing.Size(120, 40);
            this.lb_descP.TabIndex = 13;
            this.lb_descP.Text = "label9";
            // 
            // lb_porfavor3
            // 
            this.lb_porfavor3.AutoSize = true;
            this.lb_porfavor3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_porfavor3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_porfavor3.Location = new System.Drawing.Point(140, 377);
            this.lb_porfavor3.Name = "lb_porfavor3";
            this.lb_porfavor3.Size = new System.Drawing.Size(589, 40);
            this.lb_porfavor3.TabIndex = 14;
            this.lb_porfavor3.Text = "¡Siga comprando más por menos!";
            // 
            // lb_desc_desc
            // 
            this.lb_desc_desc.AutoSize = true;
            this.lb_desc_desc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_desc_desc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_desc_desc.Location = new System.Drawing.Point(18, 359);
            this.lb_desc_desc.Name = "lb_desc_desc";
            this.lb_desc_desc.Size = new System.Drawing.Size(323, 55);
            this.lb_desc_desc.TabIndex = 15;
            this.lb_desc_desc.Text = "Descripción:";
            // 
            // img_outcome
            // 
            this.img_outcome.Image = global::Verificador_Precios.Properties.Resources.error_removebg_preview;
            this.img_outcome.Location = new System.Drawing.Point(548, 109);
            this.img_outcome.Name = "img_outcome";
            this.img_outcome.Size = new System.Drawing.Size(240, 291);
            this.img_outcome.TabIndex = 16;
            this.img_outcome.TabStop = false;
            // 
            // img_producto
            // 
            this.img_producto.Image = global::Verificador_Precios.Properties.Resources.Esquina;
            this.img_producto.Location = new System.Drawing.Point(11, 12);
            this.img_producto.Margin = new System.Windows.Forms.Padding(2);
            this.img_producto.Name = "img_producto";
            this.img_producto.Size = new System.Drawing.Size(256, 225);
            this.img_producto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_producto.TabIndex = 4;
            this.img_producto.TabStop = false;
            // 
            // img_barcode
            // 
            this.img_barcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_barcode.Image = ((System.Drawing.Image)(resources.GetObject("img_barcode.Image")));
            this.img_barcode.Location = new System.Drawing.Point(329, 246);
            this.img_barcode.Name = "img_barcode";
            this.img_barcode.Size = new System.Drawing.Size(314, 207);
            this.img_barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_barcode.TabIndex = 2;
            this.img_barcode.TabStop = false;
            // 
            // img_logo
            // 
            this.img_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_logo.BackgroundImage")));
            this.img_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_logo.Location = new System.Drawing.Point(272, 12);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(316, 190);
            this.img_logo.TabIndex = 0;
            this.img_logo.TabStop = false;
            // 
            // lb_outcome_text
            // 
            this.lb_outcome_text.AutoSize = true;
            this.lb_outcome_text.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_outcome_text.ForeColor = System.Drawing.Color.Gold;
            this.lb_outcome_text.Location = new System.Drawing.Point(380, 273);
            this.lb_outcome_text.Name = "lb_outcome_text";
            this.lb_outcome_text.Size = new System.Drawing.Size(49, 55);
            this.lb_outcome_text.TabIndex = 17;
            this.lb_outcome_text.Text = "x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_outcome_text);
            this.Controls.Add(this.img_outcome);
            this.Controls.Add(this.lb_desc_desc);
            this.Controls.Add(this.lb_porfavor3);
            this.Controls.Add(this.lb_descP);
            this.Controls.Add(this.lb_outcome);
            this.Controls.Add(this.lb_stockP);
            this.Controls.Add(this.lb_desc_stock);
            this.Controls.Add(this.lb_precioP);
            this.Controls.Add(this.lb_desc_precio);
            this.Controls.Add(this.lb_nombreP);
            this.Controls.Add(this.lb_desc_nombre);
            this.Controls.Add(this.lb_porfavor2);
            this.Controls.Add(this.img_producto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.img_barcode);
            this.Controls.Add(this.lb_porfavor);
            this.Controls.Add(this.img_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_outcome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_barcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.Label lb_porfavor;
        private System.Windows.Forms.PictureBox img_barcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox img_producto;
		private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_porfavor2;
        private System.Windows.Forms.Label lb_descP;
        private System.Windows.Forms.Label lb_outcome;
        private System.Windows.Forms.Label lb_stockP;
        private System.Windows.Forms.Label lb_desc_stock;
        private System.Windows.Forms.Label lb_precioP;
        private System.Windows.Forms.Label lb_desc_precio;
        private System.Windows.Forms.Label lb_nombreP;
        private System.Windows.Forms.Label lb_desc_nombre;
        private System.Windows.Forms.Label lb_porfavor3;
        private System.Windows.Forms.Label lb_desc_desc;
        private System.Windows.Forms.PictureBox img_outcome;
        private System.Windows.Forms.Label lb_outcome_text;
    }
}

