namespace Laboratorio12
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblvelocidad = new System.Windows.Forms.Label();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtvelocidad = new System.Windows.Forms.TextBox();
            this.txttiempo = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(266, 34);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(100, 13);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Distancia Recorrida";
            this.lbltitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblvelocidad
            // 
            this.lblvelocidad.AutoSize = true;
            this.lblvelocidad.Location = new System.Drawing.Point(197, 73);
            this.lblvelocidad.Name = "lblvelocidad";
            this.lblvelocidad.Size = new System.Drawing.Size(88, 13);
            this.lblvelocidad.TabIndex = 1;
            this.lblvelocidad.Text = "Velocidad (km/h)";
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.Location = new System.Drawing.Point(197, 96);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(42, 13);
            this.lbltiempo.TabIndex = 2;
            this.lbltiempo.Text = "Tiempo";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(197, 189);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(118, 13);
            this.lblresultado.TabIndex = 3;
            this.lblresultado.Text = "Distancia total recorrida";
            // 
            // txtvelocidad
            // 
            this.txtvelocidad.Location = new System.Drawing.Point(334, 70);
            this.txtvelocidad.Name = "txtvelocidad";
            this.txtvelocidad.Size = new System.Drawing.Size(100, 20);
            this.txtvelocidad.TabIndex = 4;
            // 
            // txttiempo
            // 
            this.txttiempo.Location = new System.Drawing.Point(334, 97);
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.Size = new System.Drawing.Size(100, 20);
            this.txttiempo.TabIndex = 5;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(334, 182);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 6;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(200, 136);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 7;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnlimpiar.Location = new System.Drawing.Point(281, 136);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 8;
            this.btnlimpiar.Text = "Reiniciar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            // 
            // btnsalida
            // 
            this.btnsalida.Location = new System.Drawing.Point(359, 136);
            this.btnsalida.Name = "btnsalida";
            this.btnsalida.Size = new System.Drawing.Size(75, 23);
            this.btnsalida.TabIndex = 9;
            this.btnsalida.Text = "Salir";
            this.btnsalida.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalida);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txttiempo);
            this.Controls.Add(this.txtvelocidad);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lbltiempo);
            this.Controls.Add(this.lblvelocidad);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblvelocidad;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtvelocidad;
        private System.Windows.Forms.TextBox txttiempo;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalida;
    }
}

