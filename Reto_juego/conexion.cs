using System.Collections.Generic;
using System.Data.OleDb;


namespace Reto_juego
{
     
    class Conexion
    {
        OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        public void Insertarpregunta(List<string> vs) 
        {
            var info = vs.ToArray();

            Cadenaconn();
            command.CommandText = ("INSERT INTO Preguntas ([Id_pregunta],[Nivel],[Puntaje],[Pregunta]) VALUES ('" + info[0] + "','" + info[1] + "','" + info[2] + "','" + info[3] + "')"); //se crea consulta
            command.ExecuteNonQuery();
            Cerrar();
        }

        public void Insertarrespuesta(List<string> vs)
        {
            var info = vs.ToArray();

            Cadenaconn();
            command.CommandText = ("INSERT INTO Respuestas ([Id_respuesta],[Id_pregunta],[Respuesta],[Validacion]) VALUES ('" + info[0] + "','" + info[1] + "','" + info[2] + "','" + info[3] + "')"); //se crea consulta
            command.ExecuteNonQuery();
            Cerrar();
        }

        public void Cadenaconn() 
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\bdpruebasofka1.mdb");
            command = connection.CreateCommand();
            connection.Open();
        }
        public void Cerrar()
        {
            connection.Close();
        }
    }


}
