
namespace calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Dato1 = new System.Windows.Forms.TextBox();
            this.Dato2 = new System.Windows.Forms.TextBox();
            this.Ope = new System.Windows.Forms.TextBox();
            this.res = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dato 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dato 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "operacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resultado";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Dato1
            // 
            this.Dato1.BackColor = System.Drawing.SystemColors.Info;
            this.Dato1.Location = new System.Drawing.Point(188, 54);
            this.Dato1.Name = "Dato1";
            this.Dato1.Size = new System.Drawing.Size(100, 20);
            this.Dato1.TabIndex = 4;
            this.Dato1.Text = "0";
            // 
            // Dato2
            // 
            this.Dato2.BackColor = System.Drawing.SystemColors.Info;
            this.Dato2.Location = new System.Drawing.Point(188, 96);
            this.Dato2.Name = "Dato2";
            this.Dato2.Size = new System.Drawing.Size(100, 20);
            this.Dato2.TabIndex = 5;
            this.Dato2.Text = "0";
            this.Dato2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Ope
            // 
            this.Ope.BackColor = System.Drawing.SystemColors.Info;
            this.Ope.Location = new System.Drawing.Point(188, 139);
            this.Ope.Name = "Ope";
            this.Ope.Size = new System.Drawing.Size(30, 20);
            this.Ope.TabIndex = 6;
            this.Ope.Text = "+";
            this.Ope.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // res
            // 
            this.res.BackColor = System.Drawing.SystemColors.Info;
            this.res.Location = new System.Drawing.Point(188, 191);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(100, 20);
            this.res.TabIndex = 7;
            this.res.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(141, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.res);
            this.Controls.Add(this.Ope);
            this.Controls.Add(this.Dato2);
            this.Controls.Add(this.Dato1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Dato1;
        private System.Windows.Forms.TextBox Dato2;
        private System.Windows.Forms.TextBox Ope;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Button button1;
    }
}

