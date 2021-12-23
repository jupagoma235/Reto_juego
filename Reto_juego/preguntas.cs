using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Reto_juego
{
    public partial class Ingresar_preguntas : Form
    {
        int nivel=1;int puntos=0;int cont = 1;int validador = 0;
        Conexion conect = new Conexion();
        List<string> aux = new List<string>();
        
        public Ingresar_preguntas()
        {
            InitializeComponent();
            if (Labelpreg.Text == "1") { nivel = 1;Labnivel.Text = nivel.ToString(); }
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txpuntos_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        private void Labnivel_TextChanged(object sender, EventArgs e)
        {

        }


        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true) 
            {
                CheckBox1.Checked = true;
                CheckBox2.Checked = false;
                CheckBox3.Checked = false;
                CheckBox4.Checked = false;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                CheckBox2.Checked = true;
                CheckBox1.Checked = false;
                CheckBox3.Checked = false;
                CheckBox4.Checked = false;
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox3.Checked == true)
            {
                CheckBox3.Checked = true;
                CheckBox2.Checked = false;
                CheckBox1.Checked = false;
                CheckBox4.Checked = false;
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox4.Checked == true)
            {
                CheckBox4.Checked = true;
                CheckBox2.Checked = false;
                CheckBox3.Checked = false;
                CheckBox1.Checked = false;
            }
        }

        private void TextBox1_CursorChanged(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                TextBox2.Enabled = true;
                TextBox3.Enabled = true;
                TextBox4.Enabled = true;
                TextBox5.Enabled = true;
            }
            else 
            {
                TextBox2.Enabled = false;
                TextBox3.Enabled = false;
                TextBox4.Enabled = false;
                TextBox5.Enabled = false;
            }
        }

        private void Btguardar_Click(object sender, EventArgs e)
        {
            validador = 0;
            if (cont == 26)
            {
                Ingresar_preguntas frming = new Ingresar_preguntas();
                MessageBox.Show("Ya concluyo el ingreso de preguntas, seguidamente el formulario se cerrara  ¡¡Gracias!!");
                frming.Close();
            }
            //condicionales que validan que se ingresen los puntos al inicio del nivel
            if (Labelpreg.Text == "1" || Labelpreg.Text == "6" || Labelpreg.Text == "11" || Labelpreg.Text == "16" || Labelpreg.Text == "21")
            {
                if (Txpuntos.Text == "")
                {
                    MessageBox.Show("Debe ingresar los puntos correspondientes al nivel");
                    
                }
                else
                {
                    try
                    {
                        puntos = Convert.ToUInt16(Txpuntos.Text);
                        Txpuntos.Enabled = false;
                        validador = validador + 1;                        
                    }
                    catch
                    {
                        MessageBox.Show("Debe ingresar solo numeros enteros para configurar los puntos");
                        Txpuntos.Text = "";
                    }
                }
            }
            else 
            {
                Txpuntos.Text = puntos.ToString();
                validador = validador + 1;
                Txpuntos.Enabled = false;
            }

            //condicionales para validar que los textbox esten con las respuestas completas
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "")
            {
                MessageBox.Show("Debe diligenciar tanto la pregunta como las 4 opciones de respuesta");
            }
            else 
            {
                validador = validador + 1;
            }
            //condicionales para evaluar si se ha seleccionado algun checkbox
            if (CheckBox1.Checked == true || CheckBox2.Checked == true || CheckBox3.Checked == true || CheckBox4.Checked == true)
            {
                validador = validador + 1;
            }
            else
            {
                MessageBox.Show("Debe seleccionar mediante las casillas de verificación la respuesta correcta");                
            }
            //se valida si todas las validaciones fueron correctas 
            if (validador == 3) 
            {
                MessageBox.Show("Validaciones correctas aca se inserta en la bd");
                
                aux.Add(Labelpreg.Text);
                aux.Add(Labnivel.Text);
                aux.Add(Txpuntos.Text);
                aux.Add(TextBox1.Text);
                conect.Insertarpregunta(aux);
                aux.Clear();

                for (int i = 1; i < 5; i++) 
                {
                    string b = Labelpreg.Text + "." + i.ToString();
                    aux.Add(b);
                    aux.Add(Labelpreg.Text);
                    switch (i) 
                    {
                        case 1:
                            aux.Add(TextBox2.Text);
                            break;
                        case 2:
                            aux.Add(TextBox3.Text);
                            break;
                        case 3:
                            aux.Add(TextBox4.Text);
                            break;
                        case 4:
                            aux.Add(TextBox5.Text);
                            break;
                        default:
                            break;
                    }                    
                    aux.Add(CheckBox1.ToString());
                    conect.Insertarrespuesta(aux);
                    aux.Clear();
                }

                validador = 0;
                cont = cont + 1;
                Labelpreg.Text = cont.ToString();
                if (cont == 6 || cont == 11 || cont == 16 || cont == 21) 
                {
                    nivel = nivel + 1;
                    Labnivel.Text = nivel.ToString();
                    Txpuntos.Enabled = true;
                    Txpuntos.Text = "";
                }
                TextBox1.Text = ""; TextBox2.Text = ""; TextBox3.Text = ""; TextBox4.Text = ""; TextBox5.Text = "";
                CheckBox1.Checked = false; CheckBox2.Checked = false; CheckBox3.Checked = false; CheckBox4.Checked = false;
            }
            
        }
    }
}
