namespace TemperatureConverter
{
    partial class frmConverter
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
            this.btnToFahrenheit = new System.Windows.Forms.Button();
            this.btnToCelsius = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.grpToCelsius = new System.Windows.Forms.GroupBox();
            this.lblDegF = new System.Windows.Forms.Label();
            this.grpToFahrenheit = new System.Windows.Forms.GroupBox();
            this.lblDegC = new System.Windows.Forms.Label();
            this.grpToCelsius.SuspendLayout();
            this.grpToFahrenheit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToFahrenheit
            // 
            this.btnToFahrenheit.Location = new System.Drawing.Point(167, 27);
            this.btnToFahrenheit.Name = "btnToFahrenheit";
            this.btnToFahrenheit.Size = new System.Drawing.Size(86, 41);
            this.btnToFahrenheit.TabIndex = 4;
            this.btnToFahrenheit.Text = "Convert to Fahrenheit";
            this.btnToFahrenheit.UseVisualStyleBackColor = true;
            this.btnToFahrenheit.Click += new System.EventHandler(this.btnToFahrenheit_Click);
            // 
            // btnToCelsius
            // 
            this.btnToCelsius.Location = new System.Drawing.Point(167, 27);
            this.btnToCelsius.Name = "btnToCelsius";
            this.btnToCelsius.Size = new System.Drawing.Size(86, 41);
            this.btnToCelsius.TabIndex = 2;
            this.btnToCelsius.Text = "Convert to Celsius";
            this.btnToCelsius.UseVisualStyleBackColor = true;
            this.btnToCelsius.Click += new System.EventHandler(this.btnToCelsius_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(186, 209);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(86, 41);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblCelsius
            // 
            this.lblCelsius.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCelsius.Location = new System.Drawing.Point(17, 48);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(113, 20);
            this.lblCelsius.TabIndex = 0;
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFahrenheit.Location = new System.Drawing.Point(16, 50);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(116, 20);
            this.lblFahrenheit.TabIndex = 0;
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(15, 27);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsius.TabIndex = 3;
            this.txtCelsius.Text = "0";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(16, 25);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheit.TabIndex = 1;
            this.txtFahrenheit.Text = "0";
            // 
            // grpToCelsius
            // 
            this.grpToCelsius.Controls.Add(this.lblDegF);
            this.grpToCelsius.Controls.Add(this.btnToCelsius);
            this.grpToCelsius.Controls.Add(this.txtFahrenheit);
            this.grpToCelsius.Controls.Add(this.lblCelsius);
            this.grpToCelsius.Location = new System.Drawing.Point(12, 13);
            this.grpToCelsius.Name = "grpToCelsius";
            this.grpToCelsius.Size = new System.Drawing.Size(259, 79);
            this.grpToCelsius.TabIndex = 0;
            this.grpToCelsius.TabStop = false;
            this.grpToCelsius.Text = "Convert To Celsius";
            // 
            // lblDegF
            // 
            this.lblDegF.AutoSize = true;
            this.lblDegF.Location = new System.Drawing.Point(113, 28);
            this.lblDegF.Name = "lblDegF";
            this.lblDegF.Size = new System.Drawing.Size(17, 13);
            this.lblDegF.TabIndex = 0;
            this.lblDegF.Text = "°F";
            // 
            // grpToFahrenheit
            // 
            this.grpToFahrenheit.Controls.Add(this.lblDegC);
            this.grpToFahrenheit.Controls.Add(this.btnToFahrenheit);
            this.grpToFahrenheit.Controls.Add(this.txtCelsius);
            this.grpToFahrenheit.Controls.Add(this.lblFahrenheit);
            this.grpToFahrenheit.Location = new System.Drawing.Point(13, 114);
            this.grpToFahrenheit.Name = "grpToFahrenheit";
            this.grpToFahrenheit.Size = new System.Drawing.Size(259, 82);
            this.grpToFahrenheit.TabIndex = 0;
            this.grpToFahrenheit.TabStop = false;
            this.grpToFahrenheit.Text = "Convert To Fahrenheit";
            // 
            // lblDegC
            // 
            this.lblDegC.AutoSize = true;
            this.lblDegC.Location = new System.Drawing.Point(112, 30);
            this.lblDegC.Name = "lblDegC";
            this.lblDegC.Size = new System.Drawing.Size(18, 13);
            this.lblDegC.TabIndex = 0;
            this.lblDegC.Text = "°C";
            // 
            // frmConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.grpToCelsius);
            this.Controls.Add(this.grpToFahrenheit);
            this.Controls.Add(this.btnQuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConverter";
            this.Text = "Temperature Converter";
            this.grpToCelsius.ResumeLayout(false);
            this.grpToCelsius.PerformLayout();
            this.grpToFahrenheit.ResumeLayout(false);
            this.grpToFahrenheit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToFahrenheit;
        private System.Windows.Forms.Button btnToCelsius;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.GroupBox grpToCelsius;
        private System.Windows.Forms.GroupBox grpToFahrenheit;
        private System.Windows.Forms.Label lblDegC;
        private System.Windows.Forms.Label lblDegF;
    }
}

