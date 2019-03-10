using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsTask
{
    public partial class UserControl1 : UserControl
    {
        //private string linkstr;
        public static string linkedText = "初期状態";
        public static int closeflag = 0;


        public string linkText2()
        {
            //string mylinkstr = linkedText;
            return linkedText;
        }
        public UserControl1()
        {
            InitializeComponent();
           

        }
        //文字連結の処理
        private void button1_Click(object sender, EventArgs e)
        {
            linkedText = textBox1.Text + textBox2.Text;
         
            Form1.ctr1.Visible = false;
            Form1.ctr2.Visible = true;
            File.AppendAllText(@"Linkaplog.txt", "文字連結" + Environment.NewLine);

        }

        //※不使用
       

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        //閉じるボタン
        public void button2_Click(object sender, EventArgs e)
        {
            File.AppendAllText(@"Linkaplog.txt", "閉じる：画面1" + Environment.NewLine);
            closeflag = 1;
            this.ParentForm.Close();
        }
        public int closeFlag()
        {
            return closeflag;
        }

        //タイトル変更
        private void button1_Paint(object sender, PaintEventArgs e)
        {
            this.ParentForm.Text = "課題アプリ画面1";
        }
    }
}
