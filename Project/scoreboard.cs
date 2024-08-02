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
    public partial class scoreboard : Form
    {
        Datatext data = new Datatext();
        public scoreboard()
        {
            InitializeComponent();
        }


        //เรียงลำดับคะแนน ที่มากที่สุด 5 อันดับ
        private void scoreboard_Load(object sender, EventArgs e)
        {
            int count = 1;
            //-------------------------------------------

            //เก็บค่าจาก scorepoint.csv ไปไว้ใน Array sortTemp Start
            string filepath = "D:\\Project\\scorepoint.csv";

            StreamReader ReadLength = new StreamReader(filepath);
            string sortTemp = "";

            int i = 0;

            while ((sortTemp = ReadLength.ReadLine()) != null)
            {
                i++;
            }
            ReadLength.Close();

            string[] sortArray = new string[i];
            StreamReader ReadtoArray = new StreamReader(filepath);
            sortTemp = "";

            i = 0;

            while ((sortTemp = ReadtoArray.ReadLine()) != null)
            {
                sortArray[i] = sortTemp;
                i++;
            }
            ReadtoArray.Close();

            //เก็บค่าจาก scorepoint.csv ไปไว้ใน Array sortTemp End

            string tempofArray;

            for (int ij = 0; ij < sortArray.Length - 1; ij++)
            {
                for (int fj = 0; fj < sortArray.Length - ij - 1; fj++)
                {
                    string[] dataArray = sortArray[fj].Split(',');
                    string[] dataArrayAdd1 = sortArray[fj + 1].Split(',');

                    if (int.Parse(dataArray[1]) < int.Parse(dataArrayAdd1[1]))
                    {
                        tempofArray = sortArray[fj];        //สลับที่
                        sortArray[fj] = sortArray[fj + 1];  //สลับที่
                        sortArray[fj + 1] = tempofArray;    //สลับที่
                    }
                }
            }
            
                string[] data = sortArray[0].Split(',');
                no1.Text = count + "";
                name1.Text = data[0];
                score1.Text = data[1];

                data = sortArray[1].Split(',');
                no2.Text = ++count + "";
                name2.Text = data[0];
                score2.Text = data[1];


                data = sortArray[2].Split(',');
                no3.Text = ++count + "";
                name3.Text = data[0];
                score3.Text = data[1];


                data = sortArray[3].Split(',');
                no4.Text = ++count + "";
                name4.Text = data[0];
                score4.Text = data[1];


                data = sortArray[4].Split(',');
                no5.Text = ++count + "";
                name5.Text = data[0];
                score5.Text = data[1];

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            index menu = new index();
            menu.Show();
        }
    }
} //while ((temp = reader.ReadLine()) != null)




