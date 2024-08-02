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
    public partial class challenge : Form
    {   //ประกาศตัวแปรที่ใช้สุ่มตัวอักษร
        public Random Random = new Random();
        public int ranText;

        //ใช้รับถอยหลังเวลา
        public int timeLeft;

        //ใช้นับคะแนน
        public int _score = 0;

        //เรียกใช้ Method ที่อยู่ใน class Datatext
        Datatext data = new Datatext();

        //ประกาศตัวแปร file เก็บชื่อและคะแนน
        public string filepath = "D:\\Project\\scorepoint.csv";


        public challenge()
        {
            InitializeComponent();
        }

        private void challenge_Load(object sender, EventArgs e)
        {
            
        }

        public void randomText() //method ใข้สุ่มตัวอักษร
        {
            ranText = Random.Next(45); //สุ่มเลข 0-45 ตรงกับ index ของ Array ที่เก็บตัวอักษร
            txtjpn.Text = data.textJPN(ranText); //แสดงตัวอักษรลงใน textbox ตรงกับที่สุ่มไว้

        }
        public void default_color() //ตั้ง defaul color ของ textbox
        {
            txteng.BackColor = Color.White;
            txteng.ForeColor = Color.Black;
        }
        public void correct_color() //แสดงสีเมื่อตอบถูก
        {
            txteng.BackColor = Color.LawnGreen;
            txteng.ForeColor = Color.White;
        }
        public void inorrect_color() //แสดงสีเมื่อตอบผิด
        {
            txteng.BackColor = Color.Red;
            txteng.ForeColor = Color.White;
        }
        public void correct_msg() //แสดงข้อความเมื่อตอบถูก
        {
            List<string> msg = new List<string>(new string[] { "Goodboy!!", "Yeah!! is correct", "exellent!!" });
            int ranMSG = Random.Next(3);
            MessageBox.Show(msg[ranMSG], "Yeahhh!!");
        }
        public void incorrect_msg() //แสดงข้อความเมื่อตอบผิด
        {
            List<string> msg = new List<string>(new string[] { "Try again", "A little more", "Noooooo!!" });
            int ranMSG = Random.Next(3);
            MessageBox.Show(msg[ranMSG], "Incorrect answer");
        }

        
        private void button1_Click(object sender, EventArgs e) //ปุ่ม start
        {
            if (textName.Text == "")
            {
                MessageBox.Show("Please type your name" , "Error");
            }
            else
            {
                button1.Enabled = false;
                txteng.Enabled = true;
                _score = 0;
                randomText();
                timeLeft = 20;
                time_label2.Text = "20";
                timer1.Start();
            }
        }

        
       
       

        private void button2_Click(object sender, EventArgs e) //ปุ่ม Exit ไปหน้า menu
        {
            timer1.Stop();
            this.Hide();
            index menu = new index();
            menu.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e) //Code การทำงานของ timer
        {
                
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                time_label2.Text = timeLeft + "";
            }
            else
            {
                timer1.Stop();
                time_label2.Text = "Time is up!";
                MessageBox.Show("Your score is " + _score.ToString() , "Time Out");
                button3.Visible = true;
                txteng.Enabled = false;
                
            }
        }


        //ใช้นับคะแนน เมื่อกดปุ่ม enter เมื่อพิมพ์ตอบเสร็จ
        private void txteng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txteng.Text.ToLower() == data.textENG(ranText))
                {
                    e.Handled = true;
                    correct_color();
                    correct_msg();
                    default_color();
                    txteng.Clear();
                    randomText();
                    _score++;
                }
                else
                {
                    e.Handled = true; 
                    inorrect_color();
                    incorrect_msg();
                    default_color();
                    txteng.Clear();
                    if (_score < 0)  //เช็คถ้าคะแนนต่ำกว่า 0 จะถูก set ค่าใหม่ให้เป็น 0
                    {
                        _score = 0;
                    }
                    else
                    {
                        _score--;
                    }

                }
            }
        }


        //แสดงตัวข้อความใน textbox ที่จะพิมพ์
        private void txteng_Enter(object sender, EventArgs e)
        {
            if (txteng.Text == "Type your answer here")
            {
                txteng.Text = "";
                txteng.ForeColor = Color.Black;
            }
        }

       
         //ปุ่มบันทึกชื่อและคะแนนลงในไฟล์   
        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter writerscore = new StreamWriter(filepath, true);
            writerscore.WriteLine("{0},{1}", textName.Text, _score);
            writerscore.Close();
        }
    }
}
