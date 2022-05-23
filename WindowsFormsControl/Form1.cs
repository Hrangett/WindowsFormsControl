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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //매개변수 1 : 메세지 박스의 본문 메세지
            //매개변수 2 : 메세지 박스의 타이틀
            //매개변수 3 : 획인, 취소 버튼
            //매개변수 4 : 아이콘

            //MessageBox.Show("기본적인 메세지 박스");
            //MessageBox.Show("타이틀을 표시하느 ㄴ메세지 박스", "타이틀");
            
            //DialogResult result = 
            //    MessageBox.Show("버튼을 표시하느 ㄴ메세지 밗,ㅡ", "button", MessageBoxButtons.OKCancel);
            //DialogResult result =
            //   MessageBox.Show("버튼을 표시하느 ㄴ메세지 밗,ㅡ", "button", MessageBoxButtons.YesNoCancel, MessageBoxDefaultButton.Button3);

            //if (result == DialogResult.OK)
            //{
            //    MessageBox.Show("예스버틍");
            //}
        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
