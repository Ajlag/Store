using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Class
{
    class Cashier : Product
    {
        public Cashier()
        {

        }
        public void paint(String first, string second, string third, string fourth,int count, float change, float paid, float total )
        {
            Font font = new Font("Arial Bold", 11);
            SolidBrush brush = new SolidBrush(Color.Black);


            PrintDocument print = new PrintDocument();
            print.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
             
                e1.Graphics.DrawString("---Products---", font, brush, new RectangleF(0, 30, 0, 0));
                e1.Graphics.DrawString("Date: " + DateTime.Now, font, brush, new RectangleF(0, 50, 0, 0));
                e1.Graphics.DrawString("\n "  + "\n"  , new Font("Arial Bold", 11), new SolidBrush(Color.Black), new RectangleF(0, 0, print.DefaultPageSettings.PrintableArea.Width, print.DefaultPageSettings.PrintableArea.Height));
                var startX = 0;
                var startY = 80;
                var Offset = 0;

                for (int i = 0; i < count; i++)
                {
                    int ii = 1;
                    ii++;

                    e1.Graphics.DrawString("Name: " + first + "\t",font,brush, startX, startY + Offset);
                    Offset = Offset + 25;
                    e1.Graphics.DrawString("Quantity: " + third + "\t"+"Price: " + second, font, brush, startX, startY + Offset);
                    Offset = Offset + 25;
                }
                Offset = Offset + 25;
                e1.Graphics.DrawString("----------------------------------------", font, brush, startX, startY + Offset);
                Offset = Offset + 25;
                e1.Graphics.DrawString("Subtotal: "+ total, font, brush, startX, startY + Offset);
                Offset = Offset + 25;
                e1.Graphics.DrawString("Paid: " + paid , font, brush, startX, startY + Offset);
                Offset = Offset + 25;
                e1.Graphics.DrawString("Change: " + change , font, brush, startX, startY + Offset);
                Offset = Offset + 25;


            };

            try
            {
                print.Print();
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured While Printing", ex);
            }
        }
    }
}
