using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Verificador_Precios
{
    public partial class Form1 : Form
    {
        private int segundos = 0;

        private String codigo = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            img_outcome.SizeMode = PictureBoxSizeMode.StretchImage;
            img_outcome.Visible = false;
            lb_outcome.Visible = false;
            lb_outcome_text.Visible = false;
            lb_porfavor3.Visible = false;
            lb_porfavor3.Location = new Point(this.Width / 2 - lb_porfavor3.Width / 2, this.Height - 100);
            img_producto.Location = new Point(this.Width - 600, this.Height / 2 - 80);
            lb_desc_desc.Location = new Point(this.Width - 620, this.Height - 380);
            lb_descP.Location = new Point(this.Width - 613, this.Height - 320);
            lb_desc_nombre.Location = new Point(200, 380);
            lb_desc_precio.Location = new Point(200, 480);
            lb_desc_stock.Location = new Point(200, 580);
            lb_nombreP.Location = new Point(600, 400);
            lb_precioP.Location = new Point(600, 500);
            lb_stockP.Location = new Point(600, 600);
            lb_porfavor.Location = new Point(this.Width / 2 - lb_porfavor.Width / 2, img_logo.Height + 200);
            lb_porfavor2.Location = new Point(this.Width / 2 - lb_porfavor2.Width / 2, lb_porfavor.Height + lb_porfavor.Location.Y + 30);
            img_barcode.Location = new Point(this.Width / 2 - img_barcode.Width / 2, this.Height / 2);
            Inicio(sender, e);
        }

        private void Ocultar(object sender, EventArgs e,Boolean mostrar)
        {
            //texto
            lb_desc_nombre.Visible = mostrar;
            lb_desc_precio.Visible = mostrar;
            lb_desc_stock.Visible = mostrar;
            lb_desc_desc.Visible = mostrar;
            //producto
            img_producto.Visible = mostrar;
            lb_descP.Visible = mostrar;
            lb_nombreP.Visible = mostrar;
            lb_precioP.Visible = mostrar;
            lb_stockP.Visible = mostrar;
            
        }
        private void Inicio(object sender, EventArgs e)
        {
            Ocultar(sender, e ,false);
            img_logo.Location = new Point(this.Width / 2 - img_logo.Width / 2, 180);
            lb_porfavor.Visible = true;
            lb_porfavor2.Visible = true;
            img_barcode.Visible = true;
        }

        private void Resultado(object sender, EventArgs e, int estado)
        {
            lb_outcome_text.Visible = true;
            img_logo.Location = new Point(this.Width - img_logo.Width - 100, 100);
            lb_porfavor.Visible = false;
            lb_porfavor2.Visible = false;
            img_barcode.Visible = false;
            lb_porfavor3.Visible = true;
            img_outcome.Visible = true;
            lb_outcome.Visible = true;
            if (estado == 0) {
                lb_outcome_text.Visible = false;
                Ocultar(sender, e, true);
                lb_outcome.Location = new Point(190, 200);
                img_outcome.Location = new Point(100, 210);
                img_outcome.Size = new Size(100, 50);
                img_outcome.Image = Properties.Resources.exito_removebg_preview;
                lb_outcome.Text = "¡Busqueda exitosa!";
                lb_outcome.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                Ocultar(sender, e, false);
                img_outcome.Size = new Size(240, 291);
                img_outcome.Location = new Point(this.Width/2 - img_outcome.Width/2, 210);
                
                if (estado == 1)
                {
                    
                    lb_outcome.Text = "¡Busqueda fallida!";
                    lb_outcome.ForeColor = System.Drawing.Color.Red;
                    lb_outcome_text.Text = "Lo sentimos, el producto que buscaba no fue identificado. \n Por favor acuda a servicio al cliente para mas información.";
                    img_outcome.Image = Properties.Resources.error_removebg_preview;
                }
                else
                {
                    
                    lb_outcome.Text = "!Dispositivo en mantenimiento!";
                    lb_outcome.ForeColor = System.Drawing.Color.Yellow;
                    lb_outcome_text.Text = "Lo sentimos, intente utilizar el dispositivo mas tarde. \n Por favor acuda a servicio al cliente para mas información.";
                    img_outcome.Image = Properties.Resources.alerta_removebg_preview;
                }
                lb_outcome.Location = new Point(this.Width / 2 - lb_outcome.Width / 2, 500);
                lb_outcome_text.Location = new Point(this.Width / 2 - lb_outcome_text.Width / 2, 600);

            }
            


        }




        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //MessageBox.Show("vamos a buscar el producto "+codigo);
                try
                {
                    MySqlConnection servidor;
                    servidor = new MySqlConnection("server = 127.0.0.1; user = root; database = verificador_precios2; SSL Mode = None; ");
                    servidor.Open();
                    string query = "SELECT producto_nombre, producto_precio, producto_stock, producto_desc, producto_imagen FROM productos WHERE producto_codigo =" + codigo + ";";
                    //MessageBox.Show(query);
                    MySqlCommand consulta;
                    consulta = new MySqlCommand(query, servidor);
                    MySqlDataReader resultado = consulta.ExecuteReader();
                    if (resultado.HasRows)
                    {
                        Resultado(sender, e,0);
                        resultado.Read();
                        //MessageBox.Show(resultado.GetString(1));


                        lb_nombreP.Text = resultado.GetString(0);
                        lb_precioP.Text = resultado.GetString(1);
                        lb_stockP.Text = resultado.GetString(2); 
                        lb_descP.Text = resultado.GetString(3);
                        img_producto.ImageLocation = resultado.GetString(4);
                        img_producto.SizeMode = PictureBoxSizeMode.StretchImage;

                        
                    }
                    else
                    {
                        Resultado(sender, e, 1);

                    }
                    segundos = 0;
                    timer1.Enabled = true;
                }
                catch (Exception x)
                {
                    Resultado(sender, e, 2);
                    segundos = 0;
                    timer1.Enabled = true;
                    MessageBox.Show(x.ToString(), "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
                codigo = "";
            }
            else
            {
                codigo += e.KeyChar;
            }
        }

		private void timer1_Tick(object sender, EventArgs e)
		{
            segundos++;

            if (segundos == 4)
            {
                timer1.Enabled = false;
                Inicio(sender, e);
                lb_porfavor3.Visible = false;
                lb_outcome.Visible = false;
                img_outcome.Visible = false;
                lb_outcome_text.Visible = false;
            }
		}

       
    }
}