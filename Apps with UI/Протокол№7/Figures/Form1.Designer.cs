
namespace Figures
{
    partial class Figures
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
            this.Calculate = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.Triangle = new System.Windows.Forms.RadioButton();
            this.Square = new System.Windows.Forms.RadioButton();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Fca = new System.Windows.Forms.Label();
            this.Perimeter = new System.Windows.Forms.Label();
            this.Face = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(490, 78);
            this.Calculate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(138, 32);
            this.Calculate.TabIndex = 3;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.ForeColor = System.Drawing.Color.Green;
            this.Rectangle.Location = new System.Drawing.Point(203, 41);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(113, 28);
            this.Rectangle.TabIndex = 4;
            this.Rectangle.TabStop = true;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Triangle
            // 
            this.Triangle.AutoSize = true;
            this.Triangle.ForeColor = System.Drawing.Color.Green;
            this.Triangle.Location = new System.Drawing.Point(437, 41);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(97, 28);
            this.Triangle.TabIndex = 5;
            this.Triangle.TabStop = true;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Square
            // 
            this.Square.AutoSize = true;
            this.Square.ForeColor = System.Drawing.Color.Green;
            this.Square.Location = new System.Drawing.Point(33, 41);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(89, 28);
            this.Square.TabIndex = 6;
            this.Square.TabStop = true;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelA.Location = new System.Drawing.Point(18, 126);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(66, 24);
            this.labelA.TabIndex = 7;
            this.labelA.Text = "Side А";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelB.Location = new System.Drawing.Point(18, 176);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(65, 24);
            this.labelB.TabIndex = 8;
            this.labelB.Text = "Side В";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelC.Location = new System.Drawing.Point(18, 228);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(66, 24);
            this.labelC.TabIndex = 9;
            this.labelC.Text = "Side С";
            // 
            // textBoxA
            // 
            this.textBoxA.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxA.Location = new System.Drawing.Point(175, 126);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(110, 29);
            this.textBoxA.TabIndex = 10;
            this.textBoxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxA.WordWrap = false;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxB.Location = new System.Drawing.Point(175, 171);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(110, 29);
            this.textBoxB.TabIndex = 11;
            this.textBoxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxB.WordWrap = false;
            // 
            // textBoxC
            // 
            this.textBoxC.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxC.Location = new System.Drawing.Point(175, 223);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(110, 29);
            this.textBoxC.TabIndex = 12;
            this.textBoxC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxC.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(238, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Choose the figure\'s type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(356, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Perimeter:";
            // 
            // Fca
            // 
            this.Fca.AutoSize = true;
            this.Fca.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fca.ForeColor = System.Drawing.Color.DarkOrange;
            this.Fca.Location = new System.Drawing.Point(392, 186);
            this.Fca.Name = "Fca";
            this.Fca.Size = new System.Drawing.Size(58, 24);
            this.Fca.TabIndex = 15;
            this.Fca.Text = "Face:";
            // 
            // Perimeter
            // 
            this.Perimeter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Perimeter.ForeColor = System.Drawing.Color.Green;
            this.Perimeter.Location = new System.Drawing.Point(561, 143);
            this.Perimeter.Name = "Perimeter";
            this.Perimeter.Size = new System.Drawing.Size(58, 24);
            this.Perimeter.TabIndex = 16;
            this.Perimeter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Face
            // 
            this.Face.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Face.ForeColor = System.Drawing.Color.DarkOrange;
            this.Face.Location = new System.Drawing.Point(561, 186);
            this.Face.Name = "Face";
            this.Face.Size = new System.Drawing.Size(58, 24);
            this.Face.TabIndex = 17;
            this.Face.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(337, 259);
            this.Clear.Margin = new System.Windows.Forms.Padding(6);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(126, 33);
            this.Clear.TabIndex = 18;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.ForeColor = System.Drawing.Color.Green;
            this.Exit.Location = new System.Drawing.Point(533, 259);
            this.Exit.Margin = new System.Windows.Forms.Padding(6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(110, 33);
            this.Exit.TabIndex = 19;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Figures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(658, 315);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Face);
            this.Controls.Add(this.Perimeter);
            this.Controls.Add(this.Fca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.Calculate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Figures";
            this.Text = "Figures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.RadioButton Triangle;
        private System.Windows.Forms.RadioButton Square;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Fca;
        private System.Windows.Forms.Label Perimeter;
        private System.Windows.Forms.Label Face;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
    }
}

