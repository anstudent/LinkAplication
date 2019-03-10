using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsTask
{
    public partial class Form1 : Form
    {
        
        public static UserControl1 ctr1;
        public static UserControl2 ctr2;
        


        public Form1()
        {
            InitializeComponent();
            ctr1 = new UserControl1();
            ctr2 = new UserControl2();
            

            
            //パネルにコントロール１、２を追加
            panel1.Controls.Add(ctr1);
            panel1.Controls.Add(ctr2);
            UserControl1 UserControl1 = new UserControl1();
            
            //コントロール1のみを見えるようにする
            ctr1.Visible = true;
            ctr2.Visible = false;
            this.Text = "課題アプリ画面1";
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
               
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            int closeOr = ctr1.closeFlag();
            if (closeOr == 0)
            {
                e.Cancel = true;
                MessageBox.Show("閉じるボタンで終了してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.AppendAllText(@"Linkaplog.txt", "閉じる：×ボタン" + Environment.NewLine);
            }
            else if(closeOr == 1)
            {

            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("例外が発生しました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
