using System;

namespace tarea.clases
{
    public class MySqlConnection
    {
        private string conexion;

        public MySqlConnection(string conexion)
        {
            this.conexion = conexion;
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}