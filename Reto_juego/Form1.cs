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
        public int cantreg = 0;
        
        public Inicio()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath+ @"\recursos\MyImage1.jpg");
            this.BackgroundImage = img;
            Conexion connec = new Conexion();
            cantreg=connec.Qtyregistros();           
        }

        public int Contadorreg() 
        {
            return cantreg;
        }
     
        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.toolStripContainer1.ContentPanel.Controls.Clear();

            Ingresar_preguntas frm = new Ingresar_preguntas();          
            frm.MdiParent = this;            
            this.toolStripContainer1.ContentPanel.Controls.Add(frm);
            frm.Location = new Point((toolStripContainer1.Width - frm.Width) / 2, (toolStripContainer1.Height - frm.Height) / 2);
            frm.Show();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Prueba_tu_conocimiento frm11 = new Prueba_tu_conocimiento();
            frm11.MdiParent = this;
            this.toolStripContainer1.ContentPanel.Controls.Add(frm11);
            frm11.Location = new Point((toolStripContainer1.Width - frm11.Width) / 2, (toolStripContainer1.Height - frm11.Height) / 2);
            frm11.Show();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Ingresar_preguntas frm = new Ingresar_preguntas();
            frm.MdiParent = this;
            this.toolStripContainer1.ContentPanel.Controls.Add(frm);
            frm.Location = new Point((toolStripContainer1.Width - frm.Width) / 2, (toolStripContainer1.Height - frm.Height) / 2);
            frm.Show();
        }
    }
}
