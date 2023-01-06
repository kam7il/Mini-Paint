using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class UserControlPen : UserControl
    {
        private Pen myPen;
        public Pen MyPen
        {
            get
            {
                return myPen;
            }
        }
        private SolidBrush myBrush;
        public SolidBrush MyBrush
        {
            get
            {
                if (cbFill.Checked)
                {
                    return myBrush;
                }
                else
                {
                    return null;
                }
            }
        }
        public UserControlPen()
        {
            InitializeComponent();
            myPen = new Pen(bPenColor.BackColor, (float)nudPenWidth.Value);
            myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            myBrush = new SolidBrush(bBrushColor.BackColor);

            lbStyle.SelectedIndex = 0;
        }
        private void nudPenWidth_ValueChanged(object sender, EventArgs e)
        {
            myPen.Width = (float)nudPenWidth.Value;
        }

        private void bPenColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                myPen.Color = colorDialog.Color;
                bPenColor.BackColor = colorDialog.Color;
            }
        }

        private void lbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbStyle.Text)
            {
                case "Ciągła":
                    myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    break;
                case "Kropka":
                    myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    break;
                case "Kreska":
                    myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    break;
                case "Kropka-Kreska":
                    myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                    break;
            }
        }

        private void bBrushColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                myBrush.Color = colorDialog.Color;
                bBrushColor.BackColor = colorDialog.Color;
            }
        }
    }
}
