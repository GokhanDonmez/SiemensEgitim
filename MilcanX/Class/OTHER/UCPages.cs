using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MilcanX.Class.OTHER
{
    
    public class UCPages
    {
        public static void ucEkle(Grid gr, UserControl uc)
        {
            if (gr.Children.Count > 0)
            {
                gr.Children.Clear();
                gr.Children.Add(uc);
            }
            else { gr.Children.Add(uc); }
        }
        public static void pageEkle(Grid gr, Page page)
        {
            if (gr.Children.Count > 0)
            {
                gr.Children.Clear();
                gr.Children.Add(page);
            }
            else { gr.Children.Add(page); }
        }


    }
    
}
