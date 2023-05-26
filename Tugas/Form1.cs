using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Tugas
{
    public partial class Form1 : Form
    {
        bool mousePress;
        int xLast;
        int yLast;
        Graphics myGraphics;
        Pen myPen;
        private Point[] segiPoints; 
        int rectX;
        int rectY;
        int rectWidth;
        int rectHeight;
        bool drawRectangle;
        bool showNIM = false;
        bool allowPaint = false;
        private int score;
        private int generatedNumber;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pnlBlackboard.BackgroundImage = new Bitmap(pnlBlackboard.Width, pnlBlackboard.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            myGraphics = Graphics.FromImage(pnlBlackboard.BackgroundImage);
            myGraphics = pnlBlackboard.CreateGraphics();
            myPen = new Pen(Color.White, 1);
            rdoMerah.ForeColor = Color.Red;
            rdoBiru.ForeColor = Color.Blue;
            rdoKuning.ForeColor = Color.Yellow;
            rdoPutih.ForeColor = Color.White;
            rdoPutih.Checked = true;
            mousePress = false;
            drawRectangle = false;
            showNIM = false;
        }
        private void pnlBlackboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePress)
            {
                pnlBlackboard.Refresh();
                myGraphics.DrawLine(myPen, xLast, yLast, e.X, e.Y);
                xLast = e.X;
                yLast = e.Y;
            }
        }
        private void pnlBlackboard_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pnlBlackboard.Refresh();
                myGraphics.DrawLine(myPen, xLast, yLast, e.X, e.Y);
                mousePress = false;
            }
        }
        private void pnlBlackboard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousePress = true;
                xLast = e.X;
                yLast = e.Y;
            }
        }
        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (generatedNumber != 0)
                {
                    if ((rdoPersegi.Checked && generatedNumber == 1) ||
                        (rdoSegi.Checked && generatedNumber == 2) ||
                        (rdoNIM.Checked && generatedNumber == 3))
                    {
                        score = 100;
                    }
                    else
                    {
                        score = 0;
                    }
                }
                else
                {
                    score = 0;
                }
                grpSkor.Text = "Score: " + score.ToString();
            }

            if (rdoPersegi.Checked)
            {
                drawRectangle = true;
                showNIM = false;
                segiPoints = null;
            }
            else if (rdoSegi.Checked)
            {
                drawRectangle = false;
                showNIM = false;
                segiPoints = CalculateOctagonPoints(rectX, rectY, 70);
            }
            else if (rdoNIM.Checked)
            {
                drawRectangle = false;
                showNIM = true;
                segiPoints = null;
            }

            allowPaint = true;
            pnlBlackboard.Refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            myGraphics.Clear(pnlBlackboard.BackColor);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myGraphics.Dispose();
            myPen.Dispose();
        }
        private void rdoPutih_CheckedChanged(object sender, EventArgs e)
        {
            myPen.Color = rdoPutih.ForeColor;
        }
        private void rdoBiru_CheckedChanged(object sender, EventArgs e)
        {
            myPen.Color = rdoBiru.ForeColor;
        }
        private void rdoMerah_CheckedChanged(object sender, EventArgs e)
        {
            myPen.Color = rdoMerah.ForeColor;
        }
        private void rdoKuning_CheckedChanged(object sender, EventArgs e)
        {
            myPen.Color = rdoKuning.ForeColor;
        }

        private void pnlBlackboard_Paint(object sender, PaintEventArgs e)
        {
            if (allowPaint)
            {
                if (showNIM && rdoNIM.Checked) 
                {
                    string nimText = "22.60.0159";
                    Font nimFont = new Font(FontFamily.GenericSansSerif, 15, FontStyle.Bold);
                    SizeF nimSize = e.Graphics.MeasureString(nimText, nimFont);
                    e.Graphics.DrawString(nimText, nimFont, myPen.Brush, rectX, rectY);
                }
                else if (segiPoints != null && rdoSegi.Checked)
                {
                    e.Graphics.DrawPolygon(myPen, segiPoints);
                }
                else if (drawRectangle && rdoPersegi.Checked) 
                {
                    e.Graphics.DrawRectangle(myPen, rectX, rectY, rectWidth, rectHeight);
                }
            }
        }

        private void pnlBlackboard_CheckedChanged(object sender, EventArgs e)
        {
            allowPaint = false; 
        }

            private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Random random = new Random();
                generatedNumber = random.Next(1, 4); 
            }
            else
            {
                generatedNumber = 0;
                score = 0; 
                grpSkor.Text = "Score: ";
            }
        }

        private void rdoPersegi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPersegi.Checked)
            {
                rectX = 50;
                rectY = 50;
                rectWidth = 70;
                rectHeight = 70;

                Random random = new Random();
                int randomNumber = random.Next(1, 4);

                if (randomNumber == 1)
                {
                    drawRectangle = true;
                    segiPoints = null; 
                    showNIM = false; 
                    pnlBlackboard.Refresh();
                }
                else
                {
                    drawRectangle = false;
                    pnlBlackboard.Refresh();
                }
            }
        }

        private void rdoNIM_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNIM.Checked)
            {
                rectX = 50;
                rectY = 90;

                Random random = new Random();
                int randomNumber = random.Next(1, 4);

                if (randomNumber == 3)
                {
                    drawRectangle = false; // Tambahkan ini untuk menghapus drawRectangle
                    segiPoints = null; // Tambahkan ini untuk menghapus segiPoints
                    showNIM = true;
                    pnlBlackboard.Refresh();
                }
                else
                {
                    showNIM = false;
                    pnlBlackboard.Refresh();
                }
            }
        }

        private void rdoSegi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSegi.Checked)
            {
                rectX = 50;
                rectY = 50;
                int rectSize = 70;

                Random random = new Random();
                int randomNumber = random.Next(1, 4);

                if (randomNumber == 2)
                {
                    drawRectangle = false; 
                    showNIM = false; 
                    segiPoints = CalculateOctagonPoints(rectX, rectY, rectSize);
                    pnlBlackboard.Refresh();
                }
                else
                {
                    segiPoints = null;
                    pnlBlackboard.Refresh();
                }
                pnlBlackboard.Refresh();
            }
        }

        private Point[] CalculateOctagonPoints(int rectX, int rectY, int rectSize)
        {
            Point[] points = new Point[8];
            int halfSize = rectSize / 2;
            int quarterSize = rectSize / 4;

            points[0] = new Point(rectX + quarterSize, rectY);
            points[1] = new Point(rectX + rectSize - quarterSize, rectY);
            points[2] = new Point(rectX + rectSize, rectY + quarterSize);
            points[3] = new Point(rectX + rectSize, rectY + rectSize - quarterSize);
            points[4] = new Point(rectX + rectSize - quarterSize, rectY + rectSize);
            points[5] = new Point(rectX + quarterSize, rectY + rectSize);
            points[6] = new Point(rectX, rectY + rectSize - quarterSize);
            points[7] = new Point(rectX, rectY + quarterSize);

            return points;
        }

        private void grpSkor_Enter(object sender, EventArgs e)
        {

        }

        private void grpBangun_Enter(object sender, EventArgs e)
        {

        }

        private void grpWarna_Enter(object sender, EventArgs e)
        {

        }
    }
}