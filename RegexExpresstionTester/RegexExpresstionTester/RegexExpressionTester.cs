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
      private class TimerController
      {
         private Timer _timer;
         private Label _label;
         private readonly int fadeStep = 10;

         public TimerController(Timer timer, Label label)
         {
            _timer = timer;
            _label = label;
            _timer.Tick += new EventHandler(_timer_Tick);
         }

         public void SetText(string text)
         {
            _label.Text = text;
            _label.ForeColor = Color.Red;
            _timer.Enabled = true;
         }

         void _timer_Tick(object sender, EventArgs e)
         {
            if (_label.ForeColor.A <= fadeStep)
            {
               _label.ForeColor = Color.FromArgb(0, Color.Red);
               _timer.Enabled = false;
               return;
            }

            _label.ForeColor = Color.FromArgb(_label.ForeColor.A - fadeStep, Color.Red);
         }
      }

      private TimerController _timerController;

      public RegexExpressionTester()
      {
         InitializeComponent();
         _timerController = new TimerController(LabelTimer, lblResult);
      }

      private void btnTest_Click(object sender, EventArgs e)
      {
         Regex expression = new Regex(txtExpression.Text);

         if (expression.IsMatch(txtTestText.Text))
         {
            _timerController.SetText("Match!!!!!");
         }
         else
         {
            _timerController.SetText("Not Match!!!!");
         }
      }
   }
}
