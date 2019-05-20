using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToVS2019
{
    public partial class Form1 : Form
    {
        private Class1 obj;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obj = new Class1();
            obj.値・です = "aaa";

            this.class1BindingSource.DataSource = obj;


            this.Text = "ようこそ・ひみつのせかいへ"; //こっちの'・'は変えちゃだめ
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("これも・値・だよ\nってメッセージだよ");
        }
    }
}
