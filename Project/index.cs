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
namespace Project
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) //คำสั่งไปหน้า learn
        {
            this.Hide();
            Form1 ToLearn = new Form1();
            ToLearn.Show();
           
        }

        private void button2_Click(object sender, EventArgs e) //คำสั่งไปหน้า challenge
        {
            this.Hide();
            challenge ToChallenge = new challenge();
            ToChallenge.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            scoreboard ToChallenge = new scoreboard();
            ToChallenge.Show();
        }
    }
}
