using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace CHash4
{
    public partial class Form2 : TitleBarTabs
    {
        public int counter = 1;
        public Form2()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }

        public override TitleBarTab CreateTab()
        {
            counter++;
            return new TitleBarTab(this)
            {
                Content = new Form1
                {
                    Text = counter.ToString()
                }

            };
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
