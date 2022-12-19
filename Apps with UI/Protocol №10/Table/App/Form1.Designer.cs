
namespace App
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showBttn = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Date";
            // 
            // showBttn
            // 
            this.showBttn.Location = new System.Drawing.Point(51, 178);
            this.showBttn.Name = "showBttn";
            this.showBttn.Size = new System.Drawing.Size(127, 35);
            this.showBttn.TabIndex = 3;
            this.showBttn.Text = "Show";
            this.showBttn.UseVisualStyleBackColor = true;
            this.showBttn.Click += new System.EventHandler(this.showBttn_Click);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(181, 20);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 29);
            this.firstName.TabIndex = 4;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(181, 124);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(100, 29);
            this.date.TabIndex = 5;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(181, 76);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 29);
            this.lastName.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 250);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.date);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.showBttn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Dataase filler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showBttn;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox lastName;
    }
}

