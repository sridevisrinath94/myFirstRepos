using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //switch (textBox1.Text)
            //{
            //    case "Happy":
            //        MessageBox.Show("Phoebe");
            //        break;
            //    case "Good":
            //        MessageBox.Show("Joey");
            //        break;
            //    default:
            //        MessageBox.Show("Ross");
            //        break;
            //}
            //string[] names = { "Joey", "Phoebe", "Chandler", "Monica" };
            //for (int i = 0; i < 4; i++)
            //{
            //    MessageBox.Show(names[i]);
            //}

            //List<string> nameList = new List<string>();
            //nameList.Add("Shubhu");
            //nameList.Add("Arpita");
            //nameList.Add("Giri");

            //foreach (string name in nameList)
            //{
            //    MessageBox.Show(name);
            //}

            //int s = 0;
            //while (s < 5)
            //{
            //    textBox1.Text += s.ToString();
            //    s++;
            //MessageBox.Show(s.ToString());

            for (int i = 0; i < 10; i++)
            {
                if (i == 4) continue;
                textBox1.Text += i.ToString();
            }


        }
    }
}
