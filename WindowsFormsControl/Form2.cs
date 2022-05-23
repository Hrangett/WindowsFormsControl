using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControl
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chkResult = "";
            CheckBox[] chkBox = { checkBox1, checkBox2, checkBox3 };
            
            foreach(var item in chkBox)
            {
                chkResult
                    += string.Format("{0} : {1}\n", item.Text, item.Checked);

            }

            MessageBox.Show(chkResult, "chkResult");

        }
    }
}
