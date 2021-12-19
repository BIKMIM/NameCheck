using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tBoxInput_TextChanged(object sender, EventArgs e)
        {
            // 카톡 작업 전체 목록
            string AllWorkList = tBoxInput.Text;

            leesy.Text = AllWorkList.Contains("이상엽").ToString();
            kangbi.Text = AllWorkList.Contains("강범일").ToString();
            choiks.Text = AllWorkList.Contains("최광섭").ToString();
            kimjt.Text = AllWorkList.Contains("김진탁").ToString();
            chokh.Text = AllWorkList.Contains("조광호").ToString();
            kimty.Text = AllWorkList.Contains("김태영").ToString();
            choihc.Text = AllWorkList.Contains("최현철").ToString();
            shinjw.Text = AllWorkList.Contains("신재웅").ToString();
            nojs.Text = AllWorkList.Contains("노진성").ToString();
            jangdb.Text = AllWorkList.Contains("장다빈").ToString();
            imsy.Text = AllWorkList.Contains("임성용").ToString();
            kwonyd.Text = AllWorkList.Contains("권용덕").ToString();
            choyj.Text = AllWorkList.Contains("조용준").ToString();
            kimmw.Text = AllWorkList.Contains("김민우").ToString();
            shinjh.Text = AllWorkList.Contains("신지호").ToString();
            yoonjh.Text = AllWorkList.Contains("윤재현").ToString();


            List<string> names = new List<string>();

            if (leesy.Text == "False")
            {
                names.Add("이상엽");
            }
            
            if (kangbi.Text == "False")
            {
                names.Add("강범일");
            }

            if (choiks.Text == "False")
            {
                names.Add("최광섭");
            }

            if (kimjt.Text == "False")
            {
                names.Add("김진탁");
            }

            if (chokh.Text == "False")
            {
                names.Add("조광호");
            }

            if (kimty.Text == "False")
            {
                names.Add("김태영");
            }

            if (choihc.Text == "False")
            {
                names.Add("최현철");
            }

            if (shinjw.Text == "False")
            {
                names.Add("신재웅");
            }

            if (nojs.Text == "False")
            {
                names.Add("노진성");
            }

            if (jangdb.Text == "False")
            {
                names.Add("장다빈");
            }

            if (imsy.Text == "False")
            {
                names.Add("임성용");
            }

            if (kwonyd.Text == "False")
            {
                names.Add("권용덕");
            }

            if (choyj.Text == "False")
            {
                names.Add("조용준");
            }

            if (kimmw.Text == "False")
            {
                names.Add("김민우");
            }

            if (shinjh.Text == "False")
            {
                names.Add("신지호");
            }

            if (yoonjh.Text == "False")
            {
                names.Add("윤재현");
            }

            string line = string.Join(",", names.ToArray());
            lblRemainPerson.Text = line;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
