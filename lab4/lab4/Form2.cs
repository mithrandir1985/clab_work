using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model model = new Model
            {
                count = int.Parse(count.Text),
                price = double.Parse(price.Text),
                itemname = (objectname.Text),
                invintory = int.Parse(invintorynumber.Text),
                Date = (datetxt.Text),
                Number = int.Parse(textnumber.Text),


            };
            Boolean notempty = true;
            if (string.IsNullOrEmpty(model.itemname)) {
                errorname.SetError(objectname, "needs name");
                notempty = false;
            }
            else { errorname.Clear(); }
         
            if (notempty) {
                MessageBox.Show("succses");
                model.save();
                modelinfo.DataSource = null;
                modelinfo.DataSource = Model.getall(); }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
