using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto_juego
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath+ @"\recursos\MyImage1.jpg");
            this.BackgroundImage = img;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Ingresar_preguntas frm = new Ingresar_preguntas();
            frm.Show();
        }
    }
}
