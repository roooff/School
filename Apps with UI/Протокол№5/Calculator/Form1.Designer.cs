
namespace Calculator
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
            this.name = new System.Windows.Forms.Label();
            this.SecnuM = new System.Windows.Forms.TextBox();
            this.FirstNum = new System.Windows.Forms.TextBox();
            this.CalcSum = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Label();
            this.minus = new System.Windows.Forms.Label();
            this.multiply = new System.Windows.Forms.Label();
            this.divide = new System.Windows.Forms.Label();
            this.Enterx = new System.Windows.Forms.Label();
            this.Entery = new System.Windows.Forms.Label();
            this.character = new System.Windows.Forms.Label();
            this.ResultTxt = new System.Windows.Forms.Label();
            this.resultresult = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Char = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.name.Location = new System.Drawing.Point(359, 9);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(158, 29);
            this.name.TabIndex = 0;
            this.name.Text = "Калкулатор";
            // 
            // SecnuM
            // 
            this.SecnuM.BackColor = System.Drawing.Color.AntiqueWhite;
            this.SecnuM.Location = new System.Drawing.Point(236, 316);
            this.SecnuM.Margin = new System.Windows.Forms.Padding(4);
            this.SecnuM.Name = "SecnuM";
            this.SecnuM.Size = new System.Drawing.Size(109, 26);
            this.SecnuM.TabIndex = 1;
            this.SecnuM.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FirstNum
            // 
            this.FirstNum.BackColor = System.Drawing.Color.AntiqueWhite;
            this.FirstNum.Location = new System.Drawing.Point(13, 313);
            this.FirstNum.Margin = new System.Windows.Forms.Padding(4);
            this.FirstNum.Name = "FirstNum";
            this.FirstNum.Size = new System.Drawing.Size(86, 26);
            this.FirstNum.TabIndex = 2;
            // 
            // CalcSum
            // 
            this.CalcSum.BackColor = System.Drawing.Color.PaleGreen;
            this.CalcSum.Location = new System.Drawing.Point(13, 396);
            this.CalcSum.Margin = new System.Windows.Forms.Padding(4);
            this.CalcSum.Name = "CalcSum";
            this.CalcSum.Size = new System.Drawing.Size(317, 28);
            this.CalcSum.TabIndex = 3;
            this.CalcSum.Text = "Калкулирай";
            this.CalcSum.UseVisualStyleBackColor = false;
            this.CalcSum.Click += new System.EventHandler(this.CalcSum_Click);
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Location = new System.Drawing.Point(16, 97);
            this.Input.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(231, 20);
            this.Input.TabIndex = 4;
            this.Input.Text = "Въведи знак за операция:";
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Location = new System.Drawing.Point(16, 125);
            this.plus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(237, 20);
            this.plus.TabIndex = 5;
            this.plus.Text = "Събиране                           +\r\n";
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.Location = new System.Drawing.Point(16, 160);
            this.minus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(239, 20);
            this.minus.TabIndex = 6;
            this.minus.Text = "Изваждане                          -";
            // 
            // multiply
            // 
            this.multiply.AutoSize = true;
            this.multiply.Location = new System.Drawing.Point(16, 191);
            this.multiply.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(240, 20);
            this.multiply.TabIndex = 7;
            this.multiply.Text = "Умножение                          *";
            // 
            // divide
            // 
            this.divide.AutoSize = true;
            this.divide.Location = new System.Drawing.Point(16, 228);
            this.divide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(217, 20);
            this.divide.TabIndex = 8;
            this.divide.Text = "Деление                          /";
            // 
            // Enterx
            // 
            this.Enterx.AutoSize = true;
            this.Enterx.Location = new System.Drawing.Point(16, 282);
            this.Enterx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Enterx.Name = "Enterx";
            this.Enterx.Size = new System.Drawing.Size(97, 20);
            this.Enterx.TabIndex = 9;
            this.Enterx.Text = "Въведи  х:";
            // 
            // Entery
            // 
            this.Entery.AutoSize = true;
            this.Entery.Location = new System.Drawing.Point(254, 282);
            this.Entery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Entery.Name = "Entery";
            this.Entery.Size = new System.Drawing.Size(97, 20);
            this.Entery.TabIndex = 10;
            this.Entery.Text = "Въведи  y:";
            // 
            // character
            // 
            this.character.AutoSize = true;
            this.character.Location = new System.Drawing.Point(152, 319);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(0, 20);
            this.character.TabIndex = 11;
            // 
            // ResultTxt
            // 
            this.ResultTxt.AutoSize = true;
            this.ResultTxt.Location = new System.Drawing.Point(541, 282);
            this.ResultTxt.Name = "ResultTxt";
            this.ResultTxt.Size = new System.Drawing.Size(87, 20);
            this.ResultTxt.TabIndex = 12;
            this.ResultTxt.Text = "Резултат";
            // 
            // resultresult
            // 
            this.resultresult.AutoSize = true;
            this.resultresult.Location = new System.Drawing.Point(435, 319);
            this.resultresult.Name = "resultresult";
            this.resultresult.Size = new System.Drawing.Size(19, 20);
            this.resultresult.TabIndex = 13;
            this.resultresult.Text = "=";
            this.resultresult.Click += new System.EventHandler(this.label11_Click);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.Orange;
            this.Result.Location = new System.Drawing.Point(522, 316);
            this.Result.Margin = new System.Windows.Forms.Padding(4);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(109, 26);
            this.Result.TabIndex = 14;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(503, 396);
            this.Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(329, 28);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Изчисти";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(363, 467);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 28);
            this.Exit.TabIndex = 16;
            this.Exit.Text = "Изход";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Char
            // 
            this.Char.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.Char.BackColor = System.Drawing.Color.OldLace;
            this.Char.Location = new System.Drawing.Point(438, 97);
            this.Char.Margin = new System.Windows.Forms.Padding(4);
            this.Char.Name = "Char";
            this.Char.Size = new System.Drawing.Size(109, 26);
            this.Char.TabIndex = 17;
            this.Char.TextChanged += new System.EventHandler(this.Char_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 508);
            this.Controls.Add(this.Char);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.resultresult);
            this.Controls.Add(this.ResultTxt);
            this.Controls.Add(this.character);
            this.Controls.Add(this.Entery);
            this.Controls.Add(this.Enterx);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.CalcSum);
            this.Controls.Add(this.FirstNum);
            this.Controls.Add(this.SecnuM);
            this.Controls.Add(this.name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox SecnuM;
        private System.Windows.Forms.TextBox FirstNum;
        private System.Windows.Forms.Button CalcSum;
        private System.Windows.Forms.Label Input;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.Label minus;
        private System.Windows.Forms.Label multiply;
        private System.Windows.Forms.Label divide;
        private System.Windows.Forms.Label Enterx;
        private System.Windows.Forms.Label Entery;
        private System.Windows.Forms.Label character;
        private System.Windows.Forms.Label ResultTxt;
        private System.Windows.Forms.Label resultresult;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox Char;
    }
}

