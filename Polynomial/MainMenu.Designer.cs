
namespace Polynomial
{
    partial class MainMenu
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
            this.labelSum1 = new System.Windows.Forms.Label();
            this.labelSum2 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.buttonSum = new System.Windows.Forms.Button();
            this.labelSubtraction1 = new System.Windows.Forms.Label();
            this.buttonSubstract = new System.Windows.Forms.Button();
            this.labelMultiply = new System.Windows.Forms.Label();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSum1
            // 
            this.labelSum1.AutoSize = true;
            this.labelSum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum1.Location = new System.Drawing.Point(21, 105);
            this.labelSum1.Name = "labelSum1";
            this.labelSum1.Size = new System.Drawing.Size(188, 25);
            this.labelSum1.TabIndex = 0;
            this.labelSum1.Text = "Сумма полиномов";
            // 
            // labelSum2
            // 
            this.labelSum2.AutoSize = true;
            this.labelSum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum2.Location = new System.Drawing.Point(50, 9);
            this.labelSum2.Name = "labelSum2";
            this.labelSum2.Size = new System.Drawing.Size(395, 25);
            this.labelSum2.TabIndex = 1;
            this.labelSum2.Text = "Введите через запятую второй полином";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(26, 49);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(436, 26);
            this.textBoxSum.TabIndex = 2;
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(268, 103);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(194, 32);
            this.buttonSum.TabIndex = 3;
            this.buttonSum.Text = "Найти сумму";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // labelSubtraction1
            // 
            this.labelSubtraction1.AutoSize = true;
            this.labelSubtraction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubtraction1.Location = new System.Drawing.Point(21, 159);
            this.labelSubtraction1.Name = "labelSubtraction1";
            this.labelSubtraction1.Size = new System.Drawing.Size(225, 25);
            this.labelSubtraction1.TabIndex = 4;
            this.labelSubtraction1.Text = "Вычитание полиномов";
            // 
            // buttonSubstract
            // 
            this.buttonSubstract.Location = new System.Drawing.Point(268, 159);
            this.buttonSubstract.Name = "buttonSubstract";
            this.buttonSubstract.Size = new System.Drawing.Size(194, 32);
            this.buttonSubstract.TabIndex = 5;
            this.buttonSubstract.Text = "Найти разность";
            this.buttonSubstract.UseVisualStyleBackColor = true;
            this.buttonSubstract.Click += new System.EventHandler(this.buttonSubstract_Click);
            // 
            // labelMultiply
            // 
            this.labelMultiply.AutoSize = true;
            this.labelMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMultiply.Location = new System.Drawing.Point(21, 216);
            this.labelMultiply.Name = "labelMultiply";
            this.labelMultiply.Size = new System.Drawing.Size(234, 25);
            this.labelMultiply.TabIndex = 6;
            this.labelMultiply.Text = "Умножение полиномов";
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(268, 214);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(194, 32);
            this.buttonMultiply.TabIndex = 7;
            this.buttonMultiply.Text = "Найти произведение";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 268);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.labelMultiply);
            this.Controls.Add(this.buttonSubstract);
            this.Controls.Add(this.labelSubtraction1);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.labelSum2);
            this.Controls.Add(this.labelSum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Полином";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSum1;
        private System.Windows.Forms.Label labelSum2;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Label labelSubtraction1;
        private System.Windows.Forms.Button buttonSubstract;
        private System.Windows.Forms.Label labelMultiply;
        private System.Windows.Forms.Button buttonMultiply;
    }
}