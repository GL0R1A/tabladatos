using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tarea.clases;

namespace tarea
{
    public partial class Form1 : Form
    {
        private string[] arreglonotas;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsarchivos ar = new clsarchivos();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "seleciona tu archivo plano porfavor";
            ofd.InitialDirectory = @"C:\Users\alumno\Desktop\BASE DE DATOS";
            ofd.Filter = "Archivo Plano (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String resultado = ar.LeertodoArchivo(archivo);
                arreglonotas = ar.LeerArchivo(archivo);



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            {
                ClsConexion cn = new ClsConexion();






                
                foreach (string linea in arreglonotas)

                {
                    string[] lineas = linea.Split(';');
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    string line = $"insert into tb_alumnos values('{lineas[0]}','{lineas[1]}','{lineas[2]}','{lineas[3]}','{lineas[4]}')";
                    cn.consultaTablaDirecta(line);
                }


            }
            }

        private void Button3_Click(object sender, EventArgs e)

;
          

                }


}
    
    

        
        
