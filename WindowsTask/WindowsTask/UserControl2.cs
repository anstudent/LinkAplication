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
    public partial class UserControl2 : UserControl
    {
        
        public UserControl2()
        {
            InitializeComponent();

        }
        //画面遷移
        private void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllText(@"Linkaplog.txt", "閉じる：画面2" + Environment.NewLine);
            Form1.ctr1.Visible = true;
            Form1.ctr2.Visible = false;
        }
        //※不使用
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
           
        }

        private void UserControl2_Enter(object sender, EventArgs e)
        {
        }

        private void UserControl2_Leave(object sender, EventArgs e)
        {

        }

        //遷移時初期処理
        private void UserControl2_Paint(object sender, PaintEventArgs e)
        {
            this.ParentForm.Text = "課題アプリ画面2";
            string linkedstr = "def";
            UserControl1 UserControl1 = new UserControl1();
            //結合された文字列を取得
            linkedstr = UserControl1.linkText2();
            //反映
            richTextBox1.Text = linkedstr;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
