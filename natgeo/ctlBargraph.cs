using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace natgeo
{
    public partial class ctlBargraph : UserControl
    {
        private List<bicycle> bikes = new List<bicycle>();

        public ctlBargraph()
        {
            InitializeComponent();
        }

        private void ctlBargraph_Load(object sender, EventArgs e)
        {

        }

        public void addBicycle(bicycle toAdd)
        {
            bikes.Add(toAdd);
            toAdd.onNewPowerReading += (a,b) => this.Invalidate();

            this.Invalidate();
        }

        private void ctlBargraph_Paint(object sender, PaintEventArgs e)
        {
            if (bikes.Count == 0)
                return;
            int barLeft = 100;
            int charthWidth = ClientRectangle.Width - barLeft;
            int barSpacing = charthWidth / bikes.Count;
            int barWidth = barSpacing;
            int bottomMargin = 40;

            int barMaxHeight = ClientRectangle.Height - bottomMargin;
            Font labelFont = new Font(Font.Name, 30.0f, Font.Style, GraphicsUnit.Pixel);

            using (SolidBrush textBrush = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString("Bike", labelFont, textBrush, 0, barMaxHeight);

                foreach (bicycle thisBike in bikes.OrderBy(x => x.bikeIndex))
                {
                    using (SolidBrush barBrush = new SolidBrush(Color.Brown))
                    {
                        switch (thisBike.bikeIndex % 3)
                        {
                            case 0:
                                {
                                    barBrush.Color = System.Drawing.ColorTranslator.FromHtml("#20A4F3");
                                    break;
                                }
                            case 1:
                                {
                                    barBrush.Color = System.Drawing.ColorTranslator.FromHtml("#2EC4B6");
                                    break;
                                }
                            case 2:
                                {
                                    barBrush.Color = System.Drawing.ColorTranslator.FromHtml("#FF3366");
                                    break;
                                }
                        }
                        int barHeight = (int) (barMaxHeight * (thisBike.lastPowerReadingW / 500));
                        int barTop = ClientRectangle.Height - barHeight - 1 - bottomMargin;
                        e.Graphics.FillRectangle(barBrush, barLeft, barTop, barWidth, barHeight);

                        // Now draw the label on each bar. Take care to clamp so it is always visible, even when the bar is tiny or huge.
                        string txtlabel = thisBike.lastPowerReadingW.ToString("F0");
                        if (txtlabel.Length == 0)
                            txtlabel = "0";

                        using (Font myFont = new Font(Font.Name, (barWidth * 0.75f) / txtlabel.Length, Font.Style, GraphicsUnit.Pixel))
                        {
                            SizeF textSize = e.Graphics.MeasureString(txtlabel, myFont);

                            barTop = (int) (barTop - textSize.Height);
                            if (barTop < 0)
                                barTop = 0;
                            if (barTop > barMaxHeight - textSize.Height)
                                barTop = (int) barMaxHeight;

                            e.Graphics.DrawString(txtlabel, myFont, textBrush, barLeft, barTop);
                            e.Graphics.DrawString((thisBike.bikeIndex+1).ToString() , labelFont, textBrush, barLeft, barMaxHeight+0);
                            barLeft += barSpacing;
                        }
                    }
                }
            }
        }

    }
}
