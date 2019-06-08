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
using System.Diagnostics;

namespace CHaszo6
{
    public partial class Form1 : Form
    {
        StreamReader file;
        List<string> Names;
        Dictionary<string, List<string>> NamesDicTwo;
        Dictionary<string, List<string>> NamesDicThree;
        TimeSpan readTime;
        TimeSpan twoSignsTime;
        TimeSpan threeSignsTime;
        AutoCompleteStringCollection dicSource;
        AutoCompleteStringCollection emptySource;

        public Form1()
        {
            Stopwatch timer = new Stopwatch();
            InitializeComponent();
            dicSource = new AutoCompleteStringCollection();
            emptySource = new AutoCompleteStringCollection();
            emptySource.Add(" ");
            timer.Start();
            file = new StreamReader("nazwiska.txt");
            Names = new List<string>();
            
            string line;
            string temp;
            while ((line = file.ReadLine()) != null)
            {
                var lineArray = line.Split();
                temp = lineArray[1];
                for (int i = 2; i < lineArray.Length; i++) {
                    if (lineArray[i] != null)
                    {
                        temp = temp + " " + lineArray[i];
                    }
                    else
                    {
                        break;
                    }
                }
                Names.Add(temp);
            }
            timer.Stop();
            readTime = timer.Elapsed;
            filetime_Timelabel.Text = readTime.ToString();
            timer.Reset();
            
            List<string> tempValues;
            timer.Start();
            NamesDicTwo = new Dictionary<string, List<string>>();
            foreach (string name in Names)
            {
                string twoSigns = name[0].ToString() + name[1].ToString();
                if (!NamesDicTwo.ContainsKey(twoSigns))
                {
                    tempValues = new List<string>();
                    tempValues.Add(name);
                    NamesDicTwo[twoSigns] = tempValues;
                }
                else
                {
                    tempValues = NamesDicTwo[twoSigns];
                    tempValues.Add(name);
                    NamesDicTwo[twoSigns] = tempValues;
                }
            }
            timer.Stop();
            twoSignsTime = timer.Elapsed;
            twostructure_Timelabel.Text = twoSignsTime.ToString();
            timer.Reset();

            timer.Start();
            NamesDicThree = new Dictionary<string, List<string>>();
            foreach (string name in Names)
            {
                if (name.Length > 2)
                {
                    string threeSigns = name[0].ToString() + name[1].ToString() + name[2].ToString();
                    if (!NamesDicThree.ContainsKey(threeSigns))
                    {
                        tempValues = new List<string>();
                        tempValues.Add(name);
                        NamesDicThree[threeSigns] = tempValues;
                    }
                    else
                    {
                        tempValues = NamesDicThree[threeSigns];
                        tempValues.Add(name);
                        NamesDicThree[threeSigns] = tempValues;
                    }
                }
            }
            timer.Stop();
            threeSignsTime = timer.Elapsed;
            threestructure_Timelabel.Text = threeSignsTime.ToString();
            timer.Reset();
            comboBox1.AutoCompleteCustomSource = emptySource;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
            if(comboBox1.Text.Length < 2)
            {
                comboBox1.AutoCompleteSource = AutoCompleteSource.None;   
            }
            else if (comboBox1.Text.Length == 2)
            {
                if (NamesDicTwo.ContainsKey(comboBox1.Text))
                {
                    dicSource.AddRange(NamesDicTwo[comboBox1.Text].ToArray());
                    comboBox1.AutoCompleteCustomSource = dicSource;
                    comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
            else if (comboBox1.Text.Length == 3)
            {
                if (NamesDicThree.ContainsKey(comboBox1.Text))
                {
                    dicSource.AddRange(NamesDicThree[comboBox1.Text].ToArray());
                    comboBox1.AutoCompleteCustomSource = dicSource;
                    comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
            else
            {

            }
            if (comboBox1.Text != null)
            {
               comboBox1.Select(comboBox1.Text.Length, 0);
            }
        }
    }
}
