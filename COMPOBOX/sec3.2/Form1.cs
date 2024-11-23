using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sec3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            string[] a = new string[] { "الدقهليه", "طنطا" };
            foreach (string i in a)
            {
                comboBox1.Items.Add(i);
            }

        }

        




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                comboBox2.Items.Clear();
                if (comboBox1.SelectedItem.ToString() == "الدقهليه")
                {
                    comboBox2.Items.Add("المنصوره");
                    comboBox2.Items.Add("الجلاء");
                    comboBox2.Items.Add("المحافظه");
                }
                
                if (comboBox1.SelectedItem.ToString() == "طنطا")
                {
                    comboBox2.Items.Add("كفرالزيات");
                    comboBox2.Items.Add("السيدالبدوي");
                }
                

            }
        }

        private void المحافظه_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

