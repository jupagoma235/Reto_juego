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
        int nivel=1;int puntos=0;int cont = 1;int validador = 0;int qtypreguntas=0;
        Conexion conect = new Conexion();
        List<string> aux = new List<string>();

        public Ingresar_preguntas()
        {
            InitializeComponent();
            Inicio nfrm = new Inicio();
            qtypreguntas = nfrm.Contadorreg();
                      
            if (qtypreguntas > 0 && qtypreguntas < 6) { nivel = 1;Labnivel.Text = nivel.ToString();Labelpreg.Text = (qtypreguntas=qtypreguntas + 1).ToString();cont = qtypreguntas; }
            if (qtypreguntas > 5 && qtypreguntas < 11) { nivel = 2; Labnivel.Text = nivel.ToString(); Labelpreg.Text = (qtypreguntas=qtypreguntas + 1).ToString(); cont = qtypreguntas; }
            if (qtypreguntas > 10 && qtypreguntas < 16) { nivel = 3; Labnivel.Text = nivel.ToString(); Labelpreg.Text = (qtypreguntas=qtypreguntas + 1).ToString(); cont = qtypreguntas; }
            if (qtypreguntas > 15 && qtypreguntas < 21) { nivel = 4; Labnivel.Text = nivel.ToString(); Labelpreg.Text = (qtypreguntas=qtypreguntas + 1).ToString(); cont = qtypreguntas; }
            if (qtypreguntas > 21 && qtypreguntas < 26) { nivel = 5; Labnivel.Text = nivel.ToString(); Labelpreg.Text = (qtypreguntas = qtypreguntas + 1).ToString(); cont = qtypreguntas; }
            if (qtypreguntas ==25) { MessageBox.Show("las preguntas estan completas, ¿desea ingresarlas de nuevo?"); }
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

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btguardar_Click_1(object sender, EventArgs e)
        {
            validador = 0;
            if (cont == 26)
            {
                MessageBox.Show("Ya concluyo el ingreso de preguntas, seguidamente el formulario se cerrara  ¡¡Gracias!!");
                this.Close();
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
            if (validador == 3 && cont<26)
            {
                
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
                    bool j;
                    switch (i)
                    {
                        case 1:
                            aux.Add(TextBox2.Text);
                            j = CheckBox1.Checked;
                            aux.Add(j.ToString());
                            break;
                        case 2:
                            aux.Add(TextBox3.Text);
                            j = CheckBox2.Checked;
                            aux.Add(j.ToString());
                            break;
                        case 3:
                            aux.Add(TextBox4.Text);
                            j = CheckBox3.Checked;
                            aux.Add(j.ToString());
                            break;
                        case 4:
                            aux.Add(TextBox5.Text);
                            j = CheckBox4.Checked;
                            aux.Add(j.ToString());
                            break;
                        default:
                            break;
                    }
                   
                   conect.Insertarrespuesta(aux);
                   aux.Clear();
                    
                }
                if (cont > 25)
                {
                    MessageBox.Show("Concluyo el ingreso de las preguntas ¡¡Gracias!!");
                    this.Close();
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
            if (cont > 25)
            {
                MessageBox.Show("Concluyo el ingreso de las preguntas ¡¡Gracias!!");
                this.Close();
            }


        }
    }
}
