using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static functions;
namespace ekayic.forms.elements
{
    public class RoundedButton : Button
    {

        private int borderRadius = 5;


        public int BorderRadius { get { return borderRadius; } set { borderRadius = value; } }

        public RoundedButton()
        {
            Paint += RoundedPanel_Paint;
        }

        private void RoundedPanel_Paint(object sender, PaintEventArgs e)
        {
            Region =  CalcRegion(Size, borderRadius);
        }
    }
}
