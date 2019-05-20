using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToVS2019_2
{
    public partial class Form1 : Form
    {
        private Class2 obj2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obj2 = new Class2();
            obj2.これも・値・だよ = "bcbc";

            this.class2BindingSource.DataSource = obj2;


            this.Text = "これが・なかぐろの・おそろしさ。"; //こっちの'・'は変えちゃだめ
        }
    }
}
