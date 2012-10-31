using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexExpresstionTester
{
   public partial class RegexExpressionTester : Form
   {
      private class LabelController
      {
         private Timer _timer;
         private Label _label;
         private int blueWithGreen = 0;
         private readonly int fadeStep = 10;

         public LabelController(Timer timer, Label label)
         {
            _timer = timer;
            _label = label;
            _timer.Tick += new EventHandler(_timer_Tick);
            _label.Paint += new PaintEventHandler(_label_Paint);
            _label.BorderStyle = BorderStyle.None;
         }

         void _label_Paint(object sender, PaintEventArgs e)
         {
            System.Windows.Forms.Application.DoEvents();
         }

         public void SetText(string text)
         {
            _label.Text = text;
            _label.ForeColor = Color.Red;
            _timer.Enabled = true;
         }

         void _timer_Tick(object sender, EventArgs e)
         {
            if (blueWithGreen + fadeStep >= 255)
            {
               _label.ForeColor = Color.FromArgb(255, 255, 255);
               _timer.Enabled = false;
               blueWithGreen = 0;
               return;
            }

            blueWithGreen += fadeStep;
            _label.ForeColor = Color.FromArgb(255, blueWithGreen, blueWithGreen);
         }
      }

      private LabelController _labelController;

      public RegexExpressionTester()
      {
         InitializeComponent();
         _labelController = new LabelController(LabelTimer, lblResult);
      }

      private void btnTest_Click(object sender, EventArgs e)
      {
         Regex expression = new Regex(txtExpression.Text);

         if (expression.IsMatch(txtTestText.Text))
         {
            _labelController.SetText("Match!!!!!");
         }
         else
         {
            _labelController.SetText("Not Match!!!!");
         }
      }
   }
}
