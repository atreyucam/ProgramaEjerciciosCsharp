namespace ProgramaEjercicios.Forms
{
    partial class FormConversion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConversion));
            this.inputValorA = new System.Windows.Forms.TextBox();
            this.labelValorA = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.CalcularDescriminante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // inputValorA
            // 
            this.inputValorA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputValorA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputValorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputValorA.Location = new System.Drawing.Point(245, 242);
            this.inputValorA.Name = "inputValorA";
            this.inputValorA.Size = new System.Drawing.Size(256, 22);
            this.inputValorA.TabIndex = 23;
            this.inputValorA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputValorA_KeyPress);
            // 
            // labelValorA
            // 
            this.labelValorA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelValorA.AutoSize = true;
            this.labelValorA.BackColor = System.Drawing.Color.White;
            this.labelValorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorA.Location = new System.Drawing.Point(219, 196);
            this.labelValorA.Name = "labelValorA";
            this.labelValorA.Size = new System.Drawing.Size(312, 26);
            this.labelValorA.TabIndex = 21;
            this.labelValorA.Text = "Ingrese la talla en pulgadas:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(235, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Size = new System.Drawing.Size(276, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(15);
            this.pictureBox3.Size = new System.Drawing.Size(975, 684);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
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
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::ProgramaEjercicios.Properties.Resources.clothes_hanger;
            this.pictureBox4.Location = new System.Drawing.Point(661, 194);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(261, 288);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // CalcularDescriminante
            // 
            this.CalcularDescriminante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalcularDescriminante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.CalcularDescriminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularDescriminante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.CalcularDescriminante.Location = new System.Drawing.Point(306, 328);
            this.CalcularDescriminante.Name = "CalcularDescriminante";
            this.CalcularDescriminante.Size = new System.Drawing.Size(146, 49);
            this.CalcularDescriminante.TabIndex = 25;
            this.CalcularDescriminante.Text = "Calcular";
            this.CalcularDescriminante.UseVisualStyleBackColor = false;
            this.CalcularDescriminante.Click += new System.EventHandler(this.CalcularDescriminante_Click);
            // 
            // FormConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 684);
            this.Controls.Add(this.CalcularDescriminante);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.inputValorA);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelValorA);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormConversion";
            this.Text = "Conversiòn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox inputValorA;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelValorA;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button CalcularDescriminante;
    }
}