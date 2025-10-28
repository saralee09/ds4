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
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_historial = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lst_historial = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_m2y
            // 
            this.txt_m2y.Location = new System.Drawing.Point(112, 43);
            this.txt_m2y.Name = "txt_m2y";
            this.txt_m2y.Size = new System.Drawing.Size(100, 20);
            this.txt_m2y.TabIndex = 0;
            this.txt_m2y.TextChanged += new System.EventHandler(this.txt_m2y_TextChanged);
            // 
            // lbl_m2y
            // 
            this.lbl_m2y.AutoSize = true;
            this.lbl_m2y.Location = new System.Drawing.Point(22, 46);
            this.lbl_m2y.Name = "lbl_m2y";
            this.lbl_m2y.Size = new System.Drawing.Size(84, 13);
            this.lbl_m2y.TabIndex = 1;
            this.lbl_m2y.Text = "Metros a Yardas";
            this.lbl_m2y.Click += new System.EventHandler(this.lbl_m2y_Click);
            // 
            // btn_m2y
            // 
            this.btn_m2y.Location = new System.Drawing.Point(218, 43);
            this.btn_m2y.Name = "btn_m2y";
            this.btn_m2y.Size = new System.Drawing.Size(75, 23);
            this.btn_m2y.TabIndex = 2;
            this.btn_m2y.Text = "->";
            this.btn_m2y.UseVisualStyleBackColor = true;
            this.btn_m2y.Click += new System.EventHandler(this.btn_m2y_Click);
            // 
            // txt_m2yans
            // 
            this.txt_m2yans.Location = new System.Drawing.Point(300, 42);
            this.txt_m2yans.Name = "txt_m2yans";
            this.txt_m2yans.Size = new System.Drawing.Size(100, 20);
            this.txt_m2yans.TabIndex = 3;
            this.txt_m2yans.TextChanged += new System.EventHandler(this.txt_m2yans_TextChanged);
            // 
            // txt_y2mans
            // 
            this.txt_y2mans.Location = new System.Drawing.Point(300, 85);
            this.txt_y2mans.Name = "txt_y2mans";
            this.txt_y2mans.Size = new System.Drawing.Size(100, 20);
            this.txt_y2mans.TabIndex = 7;
            this.txt_y2mans.TextChanged += new System.EventHandler(this.txt_y2mans_TextChanged);
            // 
            // btn_y2m
            // 
            this.btn_y2m.Location = new System.Drawing.Point(218, 86);
            this.btn_y2m.Name = "btn_y2m";
            this.btn_y2m.Size = new System.Drawing.Size(75, 23);
            this.btn_y2m.TabIndex = 6;
            this.btn_y2m.Text = "->";
            this.btn_y2m.UseVisualStyleBackColor = true;
            this.btn_y2m.Click += new System.EventHandler(this.btn_y2m_Click);
            // 
            // lbl_y2m
            // 
            this.lbl_y2m.AutoSize = true;
            this.lbl_y2m.Location = new System.Drawing.Point(22, 89);
            this.lbl_y2m.Name = "lbl_y2m";
            this.lbl_y2m.Size = new System.Drawing.Size(84, 13);
            this.lbl_y2m.TabIndex = 5;
            this.lbl_y2m.Text = "Yardas a Metros";
            this.lbl_y2m.Click += new System.EventHandler(this.lbl_y2m_Click);
            // 
            // txt_y2m
            // 
            this.txt_y2m.Location = new System.Drawing.Point(112, 86);
            this.txt_y2m.Name = "txt_y2m";
            this.txt_y2m.Size = new System.Drawing.Size(100, 20);
            this.txt_y2m.TabIndex = 4;
            this.txt_y2m.TextChanged += new System.EventHandler(this.txt_y2m_TextChanged);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(25, 136);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 8;
            this.btn_limpiar.Text = "<--";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_historial
            // 
            this.btn_historial.Location = new System.Drawing.Point(25, 165);
            this.btn_historial.Name = "btn_historial";
            this.btn_historial.Size = new System.Drawing.Size(168, 23);
            this.btn_historial.TabIndex = 9;
            this.btn_historial.Text = "Ver historial de conversiones";
            this.btn_historial.UseVisualStyleBackColor = true;
            this.btn_historial.Click += new System.EventHandler(this.btn_historial_Click);
            // 
            // lst_historial
            // 
            this.lst_historial.FormattingEnabled = true;
            this.lst_historial.Location = new System.Drawing.Point(420, 14);
            this.lst_historial.Name = "lst_historial";
            this.lst_historial.Size = new System.Drawing.Size(357, 199);
            this.lst_historial.TabIndex = 10;
            this.lst_historial.SelectedIndexChanged += new System.EventHandler(this.lst_hitorial_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_historial);
            this.Controls.Add(this.btn_historial);
            this.Controls.Add(this.btn_limpiar);
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
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_historial;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox lst_historial;
    }
}

