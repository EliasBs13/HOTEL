using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL
{
    public partial class Check_in : Form
    {
        public Check_in()
        {
            InitializeComponent();
        }

        int tot = 0;
        int tot1 = 300;
        int tot2 = 0;
        int tot3 = 0;
        int tot4 = 0;
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Check_in_Load(object sender, EventArgs e)
        {
            cboH.Items.Add("Habitacion sencilla $100");
            cboH.Items.Add("Habitacion Doble $200");
            cboH.Items.Add("Habitacion VIP $500");
            cboH.Items.Add("Habitacion VIP doble $300");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string habitacion_deseada = cboH.SelectedItem.ToString();

           // dataGridView1.Rows.Add(cboH);

            string nombre, telefono, edad, Habitacion;
            int dias ;

            nombre = txtNombre.Text;
            telefono = txtTelefono.Text;
            edad = txtEdad.Text;
            Habitacion = cboH.Text;
            dias=int.Parse(txtDias.Text);


            if (cboH.SelectedItem == "Habitacion sencilla $100") 
            {
            
                tot = 100;
                tot = tot * dias;
                tot4 = tot;
             
               

            }
           
           
           
            if (cboH.SelectedItem == "Habitacion Doble $200")
            {


                tot1 = 200;
                tot1 = tot1 * dias;
                tot4 = tot1;
                

            }
            if (cboH.SelectedItem == "Habitacion VIP $500")
            {
                tot2 = 500;
                
                tot2 = tot2 * dias;
                tot4 = tot2;
                
            }
            if (cboH.SelectedItem == "Habitacion VIP doble $300")
            {
                tot3 = 300;
                
                tot3 = tot3 * dias;
                tot4 = tot3;
                
            }
            

            //tot = int.Parse(txtTotal.Text);
            



            dataGridView1.Rows.Add(nombre, telefono, edad, dias, Habitacion,tot4);
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtEdad.Text = "";
            txtDias.Text = "";
            cboH.Text = "";

            double final = 0;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                final += Convert.ToDouble(row.Cells["Column6"].Value);
            }
            txtTotal.Text = Convert.ToString(final);
           

           
        }

        

      

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
