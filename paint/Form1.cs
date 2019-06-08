using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CHash4
{
    public partial class Form1 : Form
    {
        Graphics GFX;
        Figure newFigure;
        List<Figure> listOfFigures;
        Pen pen;
        bool moving = false;
      
        public Form1()
        {
            InitializeComponent();
            GFX = panel1.CreateGraphics();
            GFX.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 3);
            listOfFigures = new List<Figure>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (newFigure != null) newFigure.paint(GFX, pen);
        }

        private void figurePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void colorPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioLinia_CheckedChanged(object sender, EventArgs e)
        {
     
        }

        private void panel1_Click(object sender, EventArgs e)
        {
         
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioLinia.Checked)
            {
                newFigure = new Line();
            }

            if (radioProstokat.Checked)
            {
                newFigure = new Rectangle();
            }

            if (radioSwobodne.Checked)
            {
                newFigure = new freeLine();
                moving = true;
            }

            newFigure.x1 = e.X;
            newFigure.y1 = e.Y;
            listOfFigures.Add(newFigure);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            newFigure.x2 = e.X;
            newFigure.y2 = e.Y;
            panel1_Paint(this, null);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                newFigure.x2 = e.X;
                newFigure.y2 = e.Y;
                panel1_Paint(this, null);
                newFigure.x1 = e.X;
                newFigure.y1 = e.Y;
            }
        }

        private void colorBlackBox_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
        }

        private void colorRedBox_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
        }

        private void colorGreenBox_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Green;
        }

        private void colorBlueBox_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
        }

        private void colorWhiteBox_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            GFX.Clear(Color.White);
        }
    }

    public class Figure
    {
        public int x1, x2;
        public int y1, y2;
    
        virtual public void paint(Graphics GFX, Pen pen)
        {
         
        }
    }

    public class Line : Figure
    {
        public override void paint(Graphics GFX, Pen pen)
        {
            GFX.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
        }
    }

    public class Rectangle : Figure
    {
        public override void paint(Graphics GFX, Pen pen)
        {
            GFX.DrawLine(pen, new Point(x1, y1), new Point(x2, y1));
            GFX.DrawLine(pen, new Point(x1, y1), new Point(x1, y2));
            GFX.DrawLine(pen, new Point(x2, y2), new Point(x2, y1));
            GFX.DrawLine(pen, new Point(x2, y2), new Point(x1, y2));
        }
    }

    public class freeLine : Figure
    {
        public override void paint( Graphics GFX, Pen pen)
        {
            GFX.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
        }
    }
}
