namespace FlashCards
{
    partial class frmMain
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
            this.lbProblem = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPrevious = new System.Windows.Forms.Label();
            this.lbAvg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSolved = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.rbAddition = new System.Windows.Forms.RadioButton();
            this.rbSubtraction = new System.Windows.Forms.RadioButton();
            this.rbMultiplication = new System.Windows.Forms.RadioButton();
            this.rbDivision = new System.Windows.Forms.RadioButton();
            this.cbRandomize = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbProblem
            // 
            this.lbProblem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProblem.Font = new System.Drawing.Font("Segoe UI", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProblem.Location = new System.Drawing.Point(1, 37);
            this.lbProblem.Name = "lbProblem";
            this.lbProblem.Size = new System.Drawing.Size(658, 181);
            this.lbProblem.TabIndex = 0;
            this.lbProblem.Text = "12 x 12";
            this.lbProblem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAnswer.Enabled = false;
            this.tbAnswer.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnswer.Location = new System.Drawing.Point(236, 287);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(191, 96);
            this.tbAnswer.TabIndex = 1;
            this.tbAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAnswer_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Answer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Previous Problem";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbPrevious
            // 
            this.lbPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPrevious.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrevious.Location = new System.Drawing.Point(433, 287);
            this.lbPrevious.Name = "lbPrevious";
            this.lbPrevious.Size = new System.Drawing.Size(226, 37);
            this.lbPrevious.TabIndex = 4;
            this.lbPrevious.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbAvg
            // 
            this.lbAvg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAvg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvg.Location = new System.Drawing.Point(433, 353);
            this.lbAvg.Name = "lbAvg";
            this.lbAvg.Size = new System.Drawing.Size(226, 30);
            this.lbAvg.TabIndex = 6;
            this.lbAvg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Average Time (Seconds)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbSolved
            // 
            this.lbSolved.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSolved.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSolved.Location = new System.Drawing.Point(4, 287);
            this.lbSolved.Name = "lbSolved";
            this.lbSolved.Size = new System.Drawing.Size(226, 30);
            this.lbSolved.TabIndex = 8;
            this.lbSolved.Text = "0";
            this.lbSolved.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Problems Solved";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbTime
            // 
            this.lbTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(4, 353);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(226, 30);
            this.lbTime.TabIndex = 10;
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Time (Seconds)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.Color.Orange;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(273, 389);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 47);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbResult
            // 
            this.lbResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbResult.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbResult.Location = new System.Drawing.Point(1, 9);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(658, 37);
            this.lbResult.TabIndex = 12;
            this.lbResult.Text = "Correct!";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbResult.Visible = false;
            // 
            // rbAddition
            // 
            this.rbAddition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbAddition.AutoSize = true;
            this.rbAddition.Location = new System.Drawing.Point(437, 389);
            this.rbAddition.Name = "rbAddition";
            this.rbAddition.Size = new System.Drawing.Size(70, 17);
            this.rbAddition.TabIndex = 13;
            this.rbAddition.Text = "Addition";
            this.rbAddition.UseVisualStyleBackColor = true;
            this.rbAddition.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbSubtraction
            // 
            this.rbSubtraction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbSubtraction.AutoSize = true;
            this.rbSubtraction.Location = new System.Drawing.Point(437, 412);
            this.rbSubtraction.Name = "rbSubtraction";
            this.rbSubtraction.Size = new System.Drawing.Size(85, 17);
            this.rbSubtraction.TabIndex = 14;
            this.rbSubtraction.Text = "Subtraction";
            this.rbSubtraction.UseVisualStyleBackColor = true;
            this.rbSubtraction.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbMultiplication
            // 
            this.rbMultiplication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbMultiplication.AutoSize = true;
            this.rbMultiplication.Checked = true;
            this.rbMultiplication.Location = new System.Drawing.Point(527, 389);
            this.rbMultiplication.Name = "rbMultiplication";
            this.rbMultiplication.Size = new System.Drawing.Size(97, 17);
            this.rbMultiplication.TabIndex = 15;
            this.rbMultiplication.TabStop = true;
            this.rbMultiplication.Text = "Multiplication";
            this.rbMultiplication.UseVisualStyleBackColor = true;
            this.rbMultiplication.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbDivision
            // 
            this.rbDivision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbDivision.AutoSize = true;
            this.rbDivision.Location = new System.Drawing.Point(527, 412);
            this.rbDivision.Name = "rbDivision";
            this.rbDivision.Size = new System.Drawing.Size(66, 17);
            this.rbDivision.TabIndex = 16;
            this.rbDivision.Text = "Division";
            this.rbDivision.UseVisualStyleBackColor = true;
            this.rbDivision.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // cbRandomize
            // 
            this.cbRandomize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRandomize.AutoSize = true;
            this.cbRandomize.Checked = true;
            this.cbRandomize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRandomize.Location = new System.Drawing.Point(437, 435);
            this.cbRandomize.Name = "cbRandomize";
            this.cbRandomize.Size = new System.Drawing.Size(161, 17);
            this.cbRandomize.TabIndex = 17;
            this.cbRandomize.Text = "Randomize Problem Order";
            this.cbRandomize.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(659, 461);
            this.Controls.Add(this.cbRandomize);
            this.Controls.Add(this.rbDivision);
            this.Controls.Add(this.rbMultiplication);
            this.Controls.Add(this.rbSubtraction);
            this.Controls.Add(this.rbAddition);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbSolved);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbAvg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPrevious);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.lbProblem);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Flash Cards";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProblem;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPrevious;
        private System.Windows.Forms.Label lbAvg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSolved;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.RadioButton rbAddition;
        private System.Windows.Forms.RadioButton rbSubtraction;
        private System.Windows.Forms.RadioButton rbMultiplication;
        private System.Windows.Forms.RadioButton rbDivision;
        private System.Windows.Forms.CheckBox cbRandomize;
    }
}

