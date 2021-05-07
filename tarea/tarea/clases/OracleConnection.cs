using System;

namespace tarea.clases
{
    public class OracleConnection
    {
        private string conexion;

        public OracleConnection(string conexion)
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