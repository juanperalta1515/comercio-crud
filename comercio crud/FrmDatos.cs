using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comercio_crud
{
    public partial class FrmDatos : Form

    {
        DataTable tabla = new DataTable();


        public FrmDatos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabla.TableName = "Lista";
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Precio", typeof(decimal));
            tabla.Columns.Add("Codigo", typeof(int));
            dataGridView1.DataSource = tabla;




        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            

            tabla.Rows.Add();
            tabla.Rows[tabla.Rows.Count - 1][0] = "lavandina ayudin";
            tabla.Rows[tabla.Rows.Count - 1][1] = 40;
            tabla.Rows[tabla.Rows.Count - 1][2] = 2;

            tabla.Rows.Add();
            tabla.Rows[tabla.Rows.Count - 1][0] = "detergente magistral";
            tabla.Rows[tabla.Rows.Count - 1][1] = 40;
            tabla.Rows[tabla.Rows.Count - 1][2] = 3;


            tabla.Rows.Add();
            tabla.Rows[tabla.Rows.Count - 1][0] = "jamon paladini";
            tabla.Rows[tabla.Rows.Count - 1][1] = 850;
            tabla.Rows[tabla.Rows.Count - 1][2] = 4;
            
            tabla.Rows.Add();

            tabla.Rows[tabla.Rows.Count - 1]["Nombre"] = textBox1.Text;
            tabla.Rows[tabla.Rows.Count - 1]["Precio"] = System.Convert.ToInt32(textBox2.Text);
            tabla.Rows[tabla.Rows.Count - 1]["Codigo"] = textBox3.Text;



        }

        private void btBaja_Click(object sender, EventArgs e)
        {
            tabla.WriteXml(@"lista.xml");

        }

        private void btagregarproducto_Click(object sender, EventArgs e)
        {
            tabla.ReadXml(@"lista.xml");
                dataGridView1.DataSource = tabla;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
