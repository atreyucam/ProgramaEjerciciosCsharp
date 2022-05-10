namespace ProgramaEjercicios.Forms
{
    partial class FormCircunferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCircunferencia));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelValorA = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.inputRadio = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ButtonCalcularArea = new System.Windows.Forms.Button();
            this.ButtonCalcularLongitud = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(710, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 684);
            this.panel3.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 237);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(15);
            this.pictureBox1.Size = new System.Drawing.Size(710, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // labelValorA
            // 
            this.labelValorA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelValorA.AutoSize = true;
            this.labelValorA.BackColor = System.Drawing.Color.White;
            this.labelValorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorA.Location = new System.Drawing.Point(215, 184);
            this.labelValorA.Name = "labelValorA";
            this.labelValorA.Size = new System.Drawing.Size(284, 26);
            this.labelValorA.TabIndex = 16;
            this.labelValorA.Text = "Ingrese el valor del Radio";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.inputRadio);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Location = new System.Drawing.Point(201, 264);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 54);
            this.panel4.TabIndex = 23;
            // 
            // inputRadio
            // 
            this.inputRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputRadio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRadio.Location = new System.Drawing.Point(15, 14);
            this.inputRadio.Name = "inputRadio";
            this.inputRadio.Size = new System.Drawing.Size(256, 22);
            this.inputRadio.TabIndex = 26;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox4.Size = new System.Drawing.Size(286, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // ButtonCalcularArea
            // 
            this.ButtonCalcularArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonCalcularArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ButtonCalcularArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCalcularArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ButtonCalcularArea.Location = new System.Drawing.Point(147, 398);
            this.ButtonCalcularArea.Name = "ButtonCalcularArea";
            this.ButtonCalcularArea.Size = new System.Drawing.Size(170, 49);
            this.ButtonCalcularArea.TabIndex = 26;
            this.ButtonCalcularArea.Text = "Calcular Area";
            this.ButtonCalcularArea.UseVisualStyleBackColor = false;
            this.ButtonCalcularArea.Click += new System.EventHandler(this.ButtonCalcularArea_Click);
            // 
            // ButtonCalcularLongitud
            // 
            this.ButtonCalcularLongitud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonCalcularLongitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ButtonCalcularLongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCalcularLongitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ButtonCalcularLongitud.Location = new System.Drawing.Point(378, 398);
            this.ButtonCalcularLongitud.Name = "ButtonCalcularLongitud";
            this.ButtonCalcularLongitud.Size = new System.Drawing.Size(170, 49);
            this.ButtonCalcularLongitud.TabIndex = 27;
            this.ButtonCalcularLongitud.Text = "Calcular Longitud";
            this.ButtonCalcularLongitud.UseVisualStyleBackColor = false;
            this.ButtonCalcularLongitud.Click += new System.EventHandler(this.ButtonCalcularLongitud_Click);
            // 
            // FormCircunferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(975, 684);
            this.Controls.Add(this.ButtonCalcularLongitud);
            this.Controls.Add(this.ButtonCalcularArea);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelValorA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Name = "FormCircunferencia";
            this.Text = "Calculadora de la circunferencia";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelValorA;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox inputRadio;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button ButtonCalcularArea;
        private System.Windows.Forms.Button ButtonCalcularLongitud;
    }
}