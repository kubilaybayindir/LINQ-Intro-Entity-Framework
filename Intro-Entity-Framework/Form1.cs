using MFramework.Services.FakeData;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Windows.Forms;

namespace Intro_Entity_Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] GenerateName()
        {
            string[] names =new string[30];


            for (int i = 0; i < 30; i++)
            {
                names[i]=NameData.GetFirstName();
            }

            return names;
        }

        private void BtSixLetter_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            IEnumerable<string> query = from name in GenerateName()
                                        where name.Length == 6
                                        orderby name
                                        select name.ToUpper();
            listBox1.DataSource = query.ToList();
        }

        private void BtAz_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            IEnumerable<string> query = from name in GenerateName()
                                        orderby name ascending
                                        select name.ToUpper();
            listBox1.DataSource = query.ToList();
        }

        private void BtZa_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            IEnumerable<string> query = from name in GenerateName()
                                        orderby name descending
                                        select name.ToUpper();
            listBox1.DataSource = query.ToList();
        }

        private void BtALetter_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            IEnumerable<string> query = from name in GenerateName()
                                        where name.ToUpper().StartsWith("A")
                                        select name.ToUpper();
            listBox1.DataSource=query.ToList();
        }

        private void BtRLetter_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            IEnumerable<string> query = from name in GenerateName()
                                            where name.ToUpper().EndsWith("R")
                                            orderby name ascending
                                        select name.ToUpper();
            listBox1.DataSource = query.ToList();
        }

        private void BtLongName_Click(object sender, EventArgs e)
        {
            listBox1.DataSource=null;
            listBox1.Items.Clear();

            List<string> list = GenerateName().ToList();
            string longest = list[0];
            foreach (string s in list)
            {
                if (s.Length > longest.Length)
                {
                    longest = s;
                }
            }
            listBox1.Items.Add(longest);
        }

        private void BtGetAllNames_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = GenerateName().ToList();
        }
    }
}