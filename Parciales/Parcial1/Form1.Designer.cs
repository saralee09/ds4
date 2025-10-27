namespace Parcial1
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
            this.txt_m2y = new System.Windows.Forms.TextBox();
            this.lbl_m2y = new System.Windows.Forms.Label();
            this.btn_m2y = new System.Windows.Forms.Button();
            this.txt_m2yans = new System.Windows.Forms.TextBox();
            this.txt_y2mans = new System.Windows.Forms.TextBox();
            this.btn_y2m = new System.Windows.Forms.Button();
            this.lbl_y2m = new System.Windows.Forms.Label();
            this.txt_y2m = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_m2y
            // 
            this.txt_m2y.Location = new System.Drawing.Point(112, 43);
            this.txt_m2y.Name = "txt_m2y";
            this.txt_m2y.Size = new System.Drawing.Size(100, 20);
            this.txt_m2y.TabIndex = 0;
            // 
            // lbl_m2y
            // 
            this.lbl_m2y.AutoSize = true;
            this.lbl_m2y.Location = new System.Drawing.Point(22, 46);
            this.lbl_m2y.Name = "lbl_m2y";
            this.lbl_m2y.Size = new System.Drawing.Size(84, 13);
            this.lbl_m2y.TabIndex = 1;
            this.lbl_m2y.Text = "Metros a Yardas";
            // 
            // btn_m2y
            // 
            this.btn_m2y.Location = new System.Drawing.Point(218, 43);
            this.btn_m2y.Name = "btn_m2y";
            this.btn_m2y.Size = new System.Drawing.Size(75, 23);
            this.btn_m2y.TabIndex = 2;
            this.btn_m2y.Text = "->";
            this.btn_m2y.UseVisualStyleBackColor = true;
            // 
            // txt_m2yans
            // 
            this.txt_m2yans.Location = new System.Drawing.Point(300, 42);
            this.txt_m2yans.Name = "txt_m2yans";
            this.txt_m2yans.Size = new System.Drawing.Size(100, 20);
            this.txt_m2yans.TabIndex = 3;
            // 
            // txt_y2mans
            // 
            this.txt_y2mans.Location = new System.Drawing.Point(300, 85);
            this.txt_y2mans.Name = "txt_y2mans";
            this.txt_y2mans.Size = new System.Drawing.Size(100, 20);
            this.txt_y2mans.TabIndex = 7;
            // 
            // btn_y2m
            // 
            this.btn_y2m.Location = new System.Drawing.Point(218, 86);
            this.btn_y2m.Name = "btn_y2m";
            this.btn_y2m.Size = new System.Drawing.Size(75, 23);
            this.btn_y2m.TabIndex = 6;
            this.btn_y2m.Text = "->";
            this.btn_y2m.UseVisualStyleBackColor = true;
            // 
            // lbl_y2m
            // 
            this.lbl_y2m.AutoSize = true;
            this.lbl_y2m.Location = new System.Drawing.Point(22, 89);
            this.lbl_y2m.Name = "lbl_y2m";
            this.lbl_y2m.Size = new System.Drawing.Size(84, 13);
            this.lbl_y2m.TabIndex = 5;
            this.lbl_y2m.Text = "Yardas a Metros";
            // 
            // txt_y2m
            // 
            this.txt_y2m.Location = new System.Drawing.Point(112, 86);
            this.txt_y2m.Name = "txt_y2m";
            this.txt_y2m.Size = new System.Drawing.Size(100, 20);
            this.txt_y2m.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_y2mans);
            this.Controls.Add(this.btn_y2m);
            this.Controls.Add(this.lbl_y2m);
            this.Controls.Add(this.txt_y2m);
            this.Controls.Add(this.txt_m2yans);
            this.Controls.Add(this.btn_m2y);
            this.Controls.Add(this.lbl_m2y);
            this.Controls.Add(this.txt_m2y);
            this.Name = "Form1";
            this.Text = "Covertidor Numerico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_m2y;
        private System.Windows.Forms.Label lbl_m2y;
        private System.Windows.Forms.Button btn_m2y;
        private System.Windows.Forms.TextBox txt_m2yans;
        private System.Windows.Forms.TextBox txt_y2mans;
        private System.Windows.Forms.Button btn_y2m;
        private System.Windows.Forms.Label lbl_y2m;
        private System.Windows.Forms.TextBox txt_y2m;
    }
}

