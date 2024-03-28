using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace AngelLayout
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class Symbolics : Form
    {
        public Symbolics()
        {
            InitializeComponent();
          //  angelView.Navigate(@"F:\VSProjects\AngelWolf\AngelLayout\symboltics.html");
         //   angelView.Navigate(Environment.CurrentDirectory + "symboltics.html");
        }

        private void Btn_Display_Click(object sender, EventArgs e)
        {
            var symbolInfo = new Symbol();
            symbolInfo.Name = text_input.Text;
            var symbolResult = SolidUntil.GetSymbols(symbolInfo).Scalars.ToString();
          ///  var g = angelView.Document.GetElementById("draw_symbols").InnerText = symbolResult; 
        }
    }
}
