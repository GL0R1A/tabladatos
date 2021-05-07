using System;

namespace tarea.clases
{
    internal class MySqlCommand
    {
        private string sqll;
        private MySqlConnection conexion;

        public MySqlCommand(string sqll, MySqlConnection conexion)
        {
            this.sqll = sqll;
            this.conexion = conexion;
        }

        internal void ExecuteReader()
        {
            throw new NotImplementedException();
        }
    }
}