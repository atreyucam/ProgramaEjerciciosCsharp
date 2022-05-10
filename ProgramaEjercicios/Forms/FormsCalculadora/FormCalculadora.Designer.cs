namespace ProgramaEjercicios.Forms
{
    partial class FormCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculadora));
            this.buttonAvanzado = new System.Windows.Forms.Button();
            this.ButtonSimple = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMainCalculadora = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMainCalculadora.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAvanzado
            // 
            this.buttonAvanzado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAvanzado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.buttonAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvanzado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.buttonAvanzado.Location = new System.Drawing.Point(555, 296);
            this.buttonAvanzado.Name = "buttonAvanzado";
            this.buttonAvanzado.Size = new System.Drawing.Size(160, 49);
            this.buttonAvanzado.TabIndex = 28;
            this.buttonAvanzado.Text = "Avanzada";
            this.buttonAvanzado.UseVisualStyleBackColor = false;
            this.buttonAvanzado.Click += new System.EventHandler(this.buttonAvanzado_Click);
            // 
            // ButtonSimple
            // 
            this.ButtonSimple.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonSimple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ButtonSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSimple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ButtonSimple.Location = new System.Drawing.Point(256, 296);
            this.ButtonSimple.Name = "ButtonSimple";
            this.ButtonSimple.Size = new System.Drawing.Size(160, 49);
            this.ButtonSimple.TabIndex = 27;
            this.ButtonSimple.Text = "Simple";
            this.ButtonSimple.UseVisualStyleBackColor = false;
            this.ButtonSimple.Click += new System.EventHandler(this.ButtonSimple_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(285, 390);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(98, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(581, 390);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(98, 98);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(15);
            this.pictureBox1.Size = new System.Drawing.Size(975, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panelMainCalculadora
            // 
            this.panelMainCalculadora.Controls.Add(this.label2);
            this.panelMainCalculadora.Controls.Add(this.buttonAvanzado);
            this.panelMainCalculadora.Controls.Add(this.pictureBox4);
            this.panelMainCalculadora.Controls.Add(this.ButtonSimple);
            this.panelMainCalculadora.Controls.Add(this.pictureBox3);
            this.panelMainCalculadora.Controls.Add(this.pictureBox1);
            this.panelMainCalculadora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainCalculadora.Location = new System.Drawing.Point(0, 0);
            this.panelMainCalculadora.Name = "panelMainCalculadora";
            this.panelMainCalculadora.Size = new System.Drawing.Size(975, 684);
            this.panelMainCalculadora.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 37);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tipos de calculadora";
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 684);
            this.Controls.Add(this.panelMainCalculadora);
            this.Name = "FormCalculadora";
            this.Text = "Calculadora matemática";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMainCalculadora.ResumeLayout(false);
            this.panelMainCalculadora.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonSimple;
        private System.Windows.Forms.Button buttonAvanzado;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelMainCalculadora;
        private System.Windows.Forms.Label label2;
    }
}