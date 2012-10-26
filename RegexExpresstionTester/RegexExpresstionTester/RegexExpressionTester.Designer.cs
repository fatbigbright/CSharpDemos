namespace RegexExpresstionTester
{
   partial class RegexExpressionTester
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.lblExpression = new System.Windows.Forms.Label();
         this.txtExpression = new System.Windows.Forms.TextBox();
         this.txtTestText = new System.Windows.Forms.TextBox();
         this.lblText = new System.Windows.Forms.Label();
         this.btnTest = new System.Windows.Forms.Button();
         this.lblResult = new System.Windows.Forms.Label();
         this.LabelTimer = new System.Windows.Forms.Timer(this.components);
         this.SuspendLayout();
         // 
         // lblExpression
         // 
         this.lblExpression.AutoSize = true;
         this.lblExpression.Location = new System.Drawing.Point(53, 90);
         this.lblExpression.Name = "lblExpression";
         this.lblExpression.Size = new System.Drawing.Size(58, 13);
         this.lblExpression.TabIndex = 0;
         this.lblExpression.Text = "Expression";
         this.lblExpression.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // txtExpression
         // 
         this.txtExpression.Location = new System.Drawing.Point(117, 87);
         this.txtExpression.Multiline = true;
         this.txtExpression.Name = "txtExpression";
         this.txtExpression.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
         this.txtExpression.Size = new System.Drawing.Size(415, 102);
         this.txtExpression.TabIndex = 1;
         this.txtExpression.Text = "^[\\d]+$";
         // 
         // txtTestText
         // 
         this.txtTestText.Location = new System.Drawing.Point(117, 232);
         this.txtTestText.Multiline = true;
         this.txtTestText.Name = "txtTestText";
         this.txtTestText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
         this.txtTestText.Size = new System.Drawing.Size(415, 102);
         this.txtTestText.TabIndex = 3;
         this.txtTestText.Text = "12345";
         // 
         // lblText
         // 
         this.lblText.AutoSize = true;
         this.lblText.Location = new System.Drawing.Point(52, 235);
         this.lblText.Name = "lblText";
         this.lblText.Size = new System.Drawing.Size(52, 13);
         this.lblText.TabIndex = 2;
         this.lblText.Text = "Test Text";
         this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // btnTest
         // 
         this.btnTest.Location = new System.Drawing.Point(56, 375);
         this.btnTest.Name = "btnTest";
         this.btnTest.Size = new System.Drawing.Size(91, 87);
         this.btnTest.TabIndex = 4;
         this.btnTest.Text = "Test";
         this.btnTest.UseVisualStyleBackColor = true;
         this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
         // 
         // lblResult
         // 
         this.lblResult.AutoSize = true;
         this.lblResult.Location = new System.Drawing.Point(169, 410);
         this.lblResult.Name = "lblResult";
         this.lblResult.Size = new System.Drawing.Size(0, 13);
         this.lblResult.TabIndex = 5;
         // 
         // RegexExpressionTester
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(568, 567);
         this.Controls.Add(this.lblResult);
         this.Controls.Add(this.btnTest);
         this.Controls.Add(this.txtTestText);
         this.Controls.Add(this.lblText);
         this.Controls.Add(this.txtExpression);
         this.Controls.Add(this.lblExpression);
         this.MaximizeBox = false;
         this.Name = "RegexExpressionTester";
         this.Text = "RegexExpressionTester";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblExpression;
      private System.Windows.Forms.TextBox txtExpression;
      private System.Windows.Forms.TextBox txtTestText;
      private System.Windows.Forms.Label lblText;
      private System.Windows.Forms.Button btnTest;
      private System.Windows.Forms.Label lblResult;
      private System.Windows.Forms.Timer LabelTimer;
   }
}

