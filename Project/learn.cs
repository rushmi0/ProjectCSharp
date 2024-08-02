using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Project
{
   
    public partial class Form1 : Form
    {
        public int count = 1 ; public int text = 0; //ลำดับตำแหน่ง

        Datatext data = new Datatext(); //เรียกใช้ class datatext
        public Form1()
        {
            InitializeComponent();
        }
        private void playSound(int text)  // method ประกาศตัวแปรเสียง
        {
            var soundP = new SoundPlayer();
            soundP.SoundLocation = data.soundFile(text);
            soundP.Play();
            
        }


        
        public void showtext(int text,int count) //แสดงตัวอักษรลง　textbox
        {
            try
            {
                txtjpn.Text = data.textJPN(text); 
                txteng.Text = data.textENG(text);
                label1.Text = ($"{count.ToString()}/46");
            }
            catch (ArgumentOutOfRangeException)
            {
                text = 0;
            }
        }
        

        //ปุ่มเลื่อน>>
        private void button2_Click(object sender, EventArgs e)
        {
           if (text < 0)
            {
                text = 0;
                count = 1;
            }
           else if (text > 45)
            {
                text = 45;
                count = 46;
            }
            else
            {
                text++;
                count++;
                showtext(text,count);
            }
        }


        //ปุ่มเลื่อน<<
        private void button1_Click(object sender, EventArgs e)
        {
            if (text < 0)
            {
                text = 0;
                count = 1;
            }
            else if (text > 45)
            {
                text = 45;
                count = 46;
            }
            else
            {
                text--;
                count--;
                showtext(text, count);
            }
        }


        //ใช้เวลาโหลดหน้านี้ขึ้นมาให้แสดงตัวอักษร ที่อยู่ตำแหน่งของ Array ล่าสุด (เริ่มต้น index[0])
        private void Form1_Load(object sender, EventArgs e) 
        {
            txtjpn.Text = data.textJPN(text);
            txteng.Text = data.textENG(text);
            label1.Text = ($"{count.ToString()}/46");
        }


        //ปุ่นกดไปหน้า menu
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            index LearnToMain = new index();
            LearnToMain.Show();
            //LearnToMain.ShowDialog();//
        }


        //method ปุ่มเล่นเสียง
        private void button4_Click(object sender, EventArgs e) 
        {
            if (text < 0)     //กันบัคหลุดนอก Array
            {
                text = 0;
                count = 1;
            }
            else if (text > 45)
            {
                text = 45;
                count = 46;
            }

            int play = text;  
            playSound(play);   //เล่นเสียง
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
