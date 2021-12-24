using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System;
using System.Windows.Forms;

namespace Reto_juego
{
     
    class Conexion
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\bdpruebasofka1.mdb");
        OleDbCommand command;
        DataTable tablesoporte = new DataTable();
        public void Insertarpregunta(List<string> vs) 
        {
            var info = vs.ToArray();

            Cadenaconn();
            command.CommandText = ("INSERT INTO Preguntas ([Id_pregunta],[Nivel],[Puntaje],[Pregunta]) VALUES ('" + info[0] + "','" + info[1] + "','" + info[2] + "','" + info[3] + "')"); //se crea consulta
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Insertarrespuesta(List<string> vs)
        {
            var info = vs.ToArray();

            Cadenaconn();
            command.CommandText = ("INSERT INTO Respuestas ([Id_respuesta],[Id_pregunta],[Respuesta],[Validacion]) VALUES ('" + info[0] + "','" + info[1] + "','" + info[2] + "','" + info[3] + "')"); //se crea consulta
            command.ExecuteNonQuery();
            connection.Close();            
        }

        public void Cadenaconn() 
        {
           // OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\bdpruebasofka1.mdb");
            command = connection.CreateCommand();
            connection.Open();
        }
        
        public int Qtyregistros() 
        {
            int numregistros=0;
            int acumuladopuntos = 0;
            int[] valores = new int[2];
            Cadenaconn();
            OleDbCommand planta = new OleDbCommand("SELECT puntaje FROM Preguntas", connection); //se crea consulta
            IDataReader cm = planta.ExecuteReader();
            while (cm.Read())
            {


                //_pts= cm[0];
                var r = cm.GetInt32(0);
                acumuladopuntos =r;
                numregistros = numregistros + 1;                               
            }
            valores[0] = numregistros+1;
            //MessageBox.Show(Convert.ToString(valores[0]));
            valores[1] = acumuladopuntos;
            //MessageBox.Show(Convert.ToString(valores[1]));
            cm.Close();
            connection.Close();
            return numregistros;
        }

        public List<string> Cargarpreguntas(int a)
        {
            tablesoporte.Clear();
            Cadenaconn();
            OleDbCommand planta = new OleDbCommand("SELECT Id_pregunta,Nivel,Puntaje,Pregunta FROM Preguntas", connection);
            OleDbDataAdapter adapter1 = new OleDbDataAdapter(planta);
            adapter1.Fill(tablesoporte);
            connection.Close();
            
            List<string> vs = new List<string>();
            Random myObject = new Random();
            int ranNum;
                    switch (a)
                    {
                        case 0:
                            ranNum = myObject.Next(1, 5);
                            vs.Add(tablesoporte.Rows[ranNum][0].ToString());
                            vs.Add(tablesoporte.Rows[ranNum][1].ToString());
                            vs.Add(tablesoporte.Rows[ranNum][2].ToString());
                            vs.Add(tablesoporte.Rows[ranNum][3].ToString());
                            break;
                        case 5:
                            ranNum = myObject.Next(6, 10);
                            vs.Add(tablesoporte.Rows[ranNum][0].ToString());
                            vs.Add(tablesoporte.Rows[ranNum][1].ToString());
                            vs.Add(tablesoporte.Rows[ranNum][2].ToString());
                            vs.Add(tablesoporte.Rows[ranNum][3].ToString());
                            break;
                        case 10:
                            ranNum = myObject.Next(11, 15);
                            vs.Add(tablesoporte.Rows[ranNum][0].ToString());
                            vs.Add(tablesoporte.Rows[ranNum][1].ToString());
                            vs.Add(tablesoporte.Rows[ranNum][2].ToString());
                            vs.Add(tablesoporte.Rows[ranNum][3].ToString());
                            break;
                        case 15:
                            ranNum = myObject.Next(16, 20);
                            vs.Add(tablesoporte.Rows[ranNum][0].ToString());
                            vs.Add(tablesoporte.Rows[ranNum][1].ToString());
                            vs.Add(tablesoporte.Rows[ranNum][2].ToString());
                            vs.Add(tablesoporte.Rows[ranNum][3].ToString());
                            break;
                        case 20:
                            ranNum = myObject.Next(21, 25);
                            vs.Add(tablesoporte.Rows[ranNum][0].ToString());
                            vs.Add(tablesoporte.Rows[ranNum][1].ToString());
                            vs.Add(tablesoporte.Rows[ranNum][2].ToString());
                            vs.Add(tablesoporte.Rows[ranNum][3].ToString()); 
                            break;
                        default:
                            break;
                    
                
                
                    }
            return vs;
        }

        public List<string> Cargarrespuestas(int a)
        {
            tablesoporte.Clear();
            Cadenaconn();
            OleDbCommand planta1 = new OleDbCommand("SELECT Id_respuesta,Id_pregunta,respuesta,Validacion FROM Respuestas WHERE Id_pregunta="+a.ToString(), connection);
            OleDbDataAdapter adapter2 = new OleDbDataAdapter(planta1);
            adapter2.Fill(tablesoporte);
            connection.Close();

            List<string> vs = new List<string>();
            for (int i=0; i <4; i++)
            {
                
                vs.Add(tablesoporte.Rows[i][0].ToString());
                vs.Add(tablesoporte.Rows[i][4].ToString());
                vs.Add(tablesoporte.Rows[i][5].ToString());
                vs.Add(tablesoporte.Rows[i][6].ToString());
            }
            return vs;
        }
    }


}
