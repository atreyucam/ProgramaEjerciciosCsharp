namespace ProgramaEjercicios.Forms
{
    partial class FormSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSimple));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelValorA = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.inputvalor1 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ButtonSuma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inputValor2 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonProducto = new System.Windows.Forms.Button();
            this.buttonResta = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 44);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora simple";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(704, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 640);
            this.panel3.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 195);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 230);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(15);
            this.pictureBox1.Size = new System.Drawing.Size(704, 640);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // labelValorA
            // 
            this.labelValorA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelValorA.AutoSize = true;
            this.labelValorA.BackColor = System.Drawing.Color.White;
            this.labelValorA.Font = new System.Drawing.Font("SF Pro Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorA.Location = new System.Drawing.Point(216, 147);
            this.labelValorA.Name = "labelValorA";
            this.labelValorA.Size = new System.Drawing.Size(240, 26);
            this.labelValorA.TabIndex = 17;
            this.labelValorA.Text = "Ingrese el primer valor: ";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.inputvalor1);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Location = new System.Drawing.Point(204, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 54);
            this.panel4.TabIndex = 24;
            // 
            // inputvalor1
            // 
            this.inputvalor1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputvalor1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputvalor1.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputvalor1.Location = new System.Drawing.Point(15, 14);
            this.inputvalor1.Name = "inputvalor1";
            this.inputvalor1.Size = new System.Drawing.Size(256, 23);
            this.inputvalor1.TabIndex = 26;
            this.inputvalor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputvalor1_KeyPress);
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
            // ButtonSuma
            // 
            this.ButtonSuma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(104)))), ((int)(((byte)(106)))));
            this.ButtonSuma.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonSuma.FlatAppearance.BorderSize = 2;
            this.ButtonSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSuma.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSuma.ForeColor = System.Drawing.Color.Black;
            this.ButtonSuma.Location = new System.Drawing.Point(66, 504);
            this.ButtonSuma.Name = "ButtonSuma";
            this.ButtonSuma.Size = new System.Drawing.Size(126, 49);
            this.ButtonSuma.TabIndex = 27;
            this.ButtonSuma.Text = "Suma";
            this.ButtonSuma.UseVisualStyleBackColor = false;
            this.ButtonSuma.Click += new System.EventHandler(this.ButtonSuma_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ingrese el segundo valor: ";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.inputValor2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(204, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 54);
            this.panel2.TabIndex = 27;
            // 
            // inputValor2
            // 
            this.inputValor2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputValor2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputValor2.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputValor2.Location = new System.Drawing.Point(15, 14);
            this.inputValor2.Name = "inputValor2";
            this.inputValor2.Size = new System.Drawing.Size(256, 23);
            this.inputValor2.TabIndex = 26;
            this.inputValor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputValor2_KeyPress);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox3.Size = new System.Drawing.Size(286, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // buttonProducto
            // 
            this.buttonProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(158)))), ((int)(((byte)(33)))));
            this.buttonProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonProducto.FlatAppearance.BorderSize = 2;
            this.buttonProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducto.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProducto.ForeColor = System.Drawing.Color.Black;
            this.buttonProducto.Location = new System.Drawing.Point(341, 504);
            this.buttonProducto.Name = "buttonProducto";
            this.buttonProducto.Size = new System.Drawing.Size(126, 49);
            this.buttonProducto.TabIndex = 29;
            this.buttonProducto.Text = "Producto";
            this.buttonProducto.UseVisualStyleBackColor = false;
            this.buttonProducto.Click += new System.EventHandler(this.buttonProducto_Click);
            // 
            // buttonResta
            // 
            this.buttonResta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(177)))), ((int)(((byte)(204)))));
            this.buttonResta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonResta.FlatAppearance.BorderSize = 2;
            this.buttonResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResta.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResta.ForeColor = System.Drawing.Color.Black;
            this.buttonResta.Location = new System.Drawing.Point(204, 504);
            this.buttonResta.Name = "buttonResta";
            this.buttonResta.Size = new System.Drawing.Size(126, 49);
            this.buttonResta.TabIndex = 30;
            this.buttonResta.Text = "Resta";
            this.buttonResta.UseVisualStyleBackColor = false;
            this.buttonResta.Click += new System.EventHandler(this.buttonResta_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(106)))));
            this.buttonDivision.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDivision.FlatAppearance.BorderSize = 2;
            this.buttonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivision.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.ForeColor = System.Drawing.Color.Black;
            this.buttonDivision.Location = new System.Drawing.Point(478, 504);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(126, 49);
            this.buttonDivision.TabIndex = 31;
            this.buttonDivision.Text = "División";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // FormSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(975, 684);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonResta);
            this.Controls.Add(this.buttonProducto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonSuma);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelValorA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormSimple";
            this.Text = "Calculadora Simple";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelValorA;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox inputvalor1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button ButtonSuma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox inputValor2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonProducto;
        private System.Windows.Forms.Button buttonResta;
        private System.Windows.Forms.Button buttonDivision;
    }
}