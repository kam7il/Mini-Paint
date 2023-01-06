using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Point tempPoint;
        Bitmap bitmapCopy;
        public Form1()
        {
            InitializeComponent();

            pbFrame.Image = new Bitmap(pbFrame.Width, pbFrame.Height);
            graphics = Graphics.FromImage(pbFrame.Image);
            graphics.Clear(Color.White);
        }
        private void pbFrame_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!rbCurve.Checked && !rbFill.Checked)
                {
                    //bitmapCopy = pbFrame.Image.Clone() as Bitmap;
                    bitmapCopy = new Bitmap(pbFrame.Image);
                }

                tempPoint = e.Location;
            }
        }
        private void pbFrame_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!rbCurve.Checked && !rbFill.Checked)
                {
                    pbFrame.Image = new Bitmap(bitmapCopy);
                    graphics = Graphics.FromImage(pbFrame.Image);
                }
                Draw(e);
                pbFrame.Refresh();
            }
        }
        private void pbFrame_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                Draw(e);
                pbFrame.Refresh();
            }
        }

        private void Draw(MouseEventArgs e)
        {
            if (rbLine.Checked)
            {
                graphics.DrawLine(ucPenBrush.MyPen, tempPoint.X, tempPoint.Y, e.X, e.Y);
            }
            else if (rbEllipse.Checked)
            {
                if (ucPenBrush.MyBrush != null)
                {
                    graphics.FillEllipse(ucPenBrush.MyBrush, Math.Min(tempPoint.X, e.X),
                                                    Math.Min(tempPoint.Y, e.Y),
                                                    Math.Abs(e.X - tempPoint.X),
                                                    Math.Abs(e.Y - tempPoint.Y));
                }
                graphics.DrawEllipse(ucPenBrush.MyPen, Math.Min(tempPoint.X, e.X),
                                                  Math.Min(tempPoint.Y, e.Y),
                                                  Math.Abs(e.X - tempPoint.X),
                                                  Math.Abs(e.Y - tempPoint.Y));
            }
            else if (rbRectangle.Checked)
            {
                if (ucPenBrush.MyBrush != null)
                {
                    graphics.FillRectangle(ucPenBrush.MyBrush, Math.Min(tempPoint.X, e.X),
                                                          Math.Min(tempPoint.Y, e.Y),
                                                          Math.Abs(e.X - tempPoint.X),
                                                          Math.Abs(e.Y - tempPoint.Y));
                }
                graphics.DrawRectangle(ucPenBrush.MyPen, Math.Min(tempPoint.X, e.X),
                                                    Math.Min(tempPoint.Y, e.Y),
                                                    Math.Abs(e.X - tempPoint.X),
                                                    Math.Abs(e.Y - tempPoint.Y));
            }
            else if (rbCurve.Checked)
            {
                graphics.DrawLine(ucPenBrush.MyPen, tempPoint.X, tempPoint.Y, e.X, e.Y);
                tempPoint = e.Location;
            }
            else if (rbFill.Checked)
            {
                if (ucPenBrush.MyBrush != null)
                {
                    Fill(e.X, e.Y);
                }
            }
        }
        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbFrame.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName.EndsWith(".bmp"))
                {
                    pbFrame.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                }
                else if (saveFileDialog.FileName.EndsWith(".jpg"))
                {
                    pbFrame.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else
                {
                    MessageBox.Show("Zły format pliku");
                }
            }
        }
        private void Fill(int x, int y)
        {
            List<Point> points = new List<Point>();
            Bitmap bitmap = pbFrame.Image as Bitmap;
            Color color = bitmap.GetPixel(x, y);
            if (color.ToArgb() != ucPenBrush.MyBrush.Color.ToArgb())
            {
                bitmap.SetPixel(x, y, ucPenBrush.MyBrush.Color);
                points.Add(new Point(x, y));
                int w = bitmap.Width;
                int h = bitmap.Height;

                while (points.Count() > 0)
                {
                    int xx, yy;
                    xx = points.First().X - 1;
                    yy = points.First().Y;
                    if (xx >= 0 && xx < w && yy >= 0 && yy < h && bitmap.GetPixel(xx, yy).ToArgb() == color.ToArgb())
                    {
                        bitmap.SetPixel(xx, yy, ucPenBrush.MyBrush.Color);
                        points.Add(new Point(xx, yy));
                    }
                    xx = points.First().X;
                    yy = points.First().Y - 1;
                    if (xx >= 0 && xx < w && yy >= 0 && yy < h && bitmap.GetPixel(xx, yy).ToArgb() == color.ToArgb())
                    {
                        bitmap.SetPixel(xx, yy, ucPenBrush.MyBrush.Color);
                        points.Add(new Point(xx, yy));
                    }
                    xx = points.First().X + 1;
                    yy = points.First().Y;
                    if (xx >= 0 && xx < w && yy >= 0 && yy < h && bitmap.GetPixel(xx, yy).ToArgb() == color.ToArgb())
                    {
                        bitmap.SetPixel(xx, yy, ucPenBrush.MyBrush.Color);
                        points.Add(new Point(xx, yy));
                    }
                    xx = points.First().X;
                    yy = points.First().Y + 1;
                    if (xx >= 0 && xx < w && yy >= 0 && yy < h && bitmap.GetPixel(xx, yy).ToArgb() == color.ToArgb())
                    {
                        bitmap.SetPixel(xx, yy, ucPenBrush.MyBrush.Color);
                        points.Add(new Point(xx, yy));
                    }
                    points.RemoveAt(0);
                }
            }
        }
    }
}
