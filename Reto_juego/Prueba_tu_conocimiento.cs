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
    public partial class Prueba_tu_conocimiento : Form
    {
        string[] auxvs1 = new string[16];
        public int cantreg;
        Inicio conect = new Inicio();
        Conexion prueba = new Conexion();
        Ingresar_preguntas crear = new Ingresar_preguntas();
        DataTable preguntas = new DataTable();
        int contp;int acumulado;
        public Prueba_tu_conocimiento()
        {
            InitializeComponent();
            cantreg=conect.Contadorreg();
            if (cantreg > 25) 
            {
                MessageBox.Show("Debe terminar de crear las preguntas, sera redirigido al formulario de creacion de preguntas");
                //this.Close();
                
                
            }
            else{ Mostrarpregunta(); }
            
            
        }

        public void Mostrarpregunta()
        {
            contp = Convert.ToInt16(label2.Text);
            auxvs1.Initialize();
            switch (contp) 
            {
                case 0:                    
                    Labelpreg.Text = "1";
                    break;
                case 1:
                    contp = 5;
                    Labelpreg.Text = "2";
                    break;
                case 2:
                    contp = 10;
                    Labelpreg.Text = "3";
                    break;
                case 3:
                    contp = 15;
                    Labelpreg.Text = "4";
                    break;
                case 4:
                    contp = 20;
                    Labelpreg.Text = "5";
                    break;
                default:
                    break;

            }
            string[] auxvs = new string[4];
            auxvs = prueba.Cargarpreguntas(contp).ToArray();
            try { acumulado = acumulado + Convert.ToInt32(auxvs[2]); } catch { }
            

            label1.Text = auxvs[3]; //pregunta
            label4.Text = acumulado.ToString(); //puntaje
            label2.Text = auxvs[1]; //nivel

            
            auxvs1 = prueba.Cargarrespuestas(Convert.ToInt16(auxvs[0])).ToArray();

            label5.Text = auxvs1[2];
            label3.Text = auxvs1[6];
            label7.Text = auxvs1[10];
            label6.Text = auxvs1[14];

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

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true || CheckBox2.Checked == true || CheckBox3.Checked == true || CheckBox4.Checked == true)
            {
                int valid = Convert.ToInt16(label2.Text);

                if (valid < 5)
                {
                    int vdacion = 0;

                    if (CheckBox1.Checked == true && auxvs1[3]== "True") 
                    {
                        vdacion = 1;
                    }
                    if (CheckBox2.Checked == true && auxvs1[7] == "True")
                    {
                        vdacion = 1;
                    }
                    if (CheckBox3.Checked == true && auxvs1[11] == "True")
                    {
                        vdacion = 1;
                    }
                    if (CheckBox4.Checked == true && auxvs1[15] == "True")
                    {
                        vdacion = 1;
                    }
                    if (vdacion == 1)
                    {
                        if (valid == 5) 
                        {
                            MessageBox.Show("¡¡¡  FELICITACIONES, HAS LOGRADO EL OBJETIVO !!!");
                            this.Close();
                        }
                        Mostrarpregunta();
                        CheckBox1.Checked = false;
                        CheckBox2.Checked = false;
                        CheckBox3.Checked = false;
                        CheckBox4.Checked = false;
                        vdacion = 0;
                    }
                    else 
                    {
                        MessageBox.Show("No ha superado el nivel, sigue intentando");
                        this.Close();
                    }

                    
                }
                else { 
                    //validar pregunta
                    
                }
                
            }
            else {
                MessageBox.Show("Debe seleccionar una de las respuestas para continuar.");
            }
        }
        
        
    }
}
