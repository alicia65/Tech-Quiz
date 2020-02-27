namespace Tech_Quiz
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoTrue = new System.Windows.Forms.RadioButton();
            this.rdoFalse = new System.Windows.Forms.RadioButton();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoFalse);
            this.panel1.Controls.Add(this.rdoTrue);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 65);
            this.panel1.TabIndex = 0;
            // 
            // rdoTrue
            // 
            this.rdoTrue.Location = new System.Drawing.Point(26, 3);
            this.rdoTrue.Name = "rdoTrue";
            this.rdoTrue.Size = new System.Drawing.Size(104, 24);
            this.rdoTrue.TabIndex = 0;
            this.rdoTrue.TabStop = true;
            this.rdoTrue.Text = "True";
            this.rdoTrue.UseVisualStyleBackColor = true;
            // 
            // rdoFalse
            // 
            this.rdoFalse.Location = new System.Drawing.Point(26, 38);
            this.rdoFalse.Name = "rdoFalse";
            this.rdoFalse.Size = new System.Drawing.Size(104, 24);
            this.rdoFalse.TabIndex = 1;
            this.rdoFalse.TabStop = true;
            this.rdoFalse.Text = "False";
            this.rdoFalse.UseVisualStyleBackColor = true;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(0, 7);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(357, 22);
            this.txtQuestion.TabIndex = 2;
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Location = new System.Drawing.Point(122, 123);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(165, 23);
            this.btnCheckAnswer.TabIndex = 3;
            this.btnCheckAnswer.Text = "Check answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(139, 182);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 23);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score: ?";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 293);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoFalse;
        private System.Windows.Forms.RadioButton rdoTrue;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.Label lblScore;
    }
}

