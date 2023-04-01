namespace CarrosCoppel
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerCar = new System.Windows.Forms.Button();
            this.btnVerMar = new System.Windows.Forms.Button();
            this.btnVerTip = new System.Windows.Forms.Button();
            this.btnVerCol = new System.Windows.Forms.Button();
            this.btnAgMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerCar
            // 
            this.btnVerCar.Location = new System.Drawing.Point(22, 21);
            this.btnVerCar.Name = "btnVerCar";
            this.btnVerCar.Size = new System.Drawing.Size(196, 23);
            this.btnVerCar.TabIndex = 0;
            this.btnVerCar.Text = "Ver Carros";
            this.btnVerCar.UseVisualStyleBackColor = true;
            this.btnVerCar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnVerMar
            // 
            this.btnVerMar.Location = new System.Drawing.Point(22, 50);
            this.btnVerMar.Name = "btnVerMar";
            this.btnVerMar.Size = new System.Drawing.Size(196, 23);
            this.btnVerMar.TabIndex = 1;
            this.btnVerMar.Text = "Ver Marcas";
            this.btnVerMar.UseVisualStyleBackColor = true;
            this.btnVerMar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVerTip
            // 
            this.btnVerTip.Location = new System.Drawing.Point(22, 79);
            this.btnVerTip.Name = "btnVerTip";
            this.btnVerTip.Size = new System.Drawing.Size(196, 23);
            this.btnVerTip.TabIndex = 2;
            this.btnVerTip.Text = "Ver Tipos";
            this.btnVerTip.UseVisualStyleBackColor = true;
            this.btnVerTip.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVerCol
            // 
            this.btnVerCol.Location = new System.Drawing.Point(22, 108);
            this.btnVerCol.Name = "btnVerCol";
            this.btnVerCol.Size = new System.Drawing.Size(196, 23);
            this.btnVerCol.TabIndex = 3;
            this.btnVerCol.Text = "Ver Color";
            this.btnVerCol.UseVisualStyleBackColor = true;
            this.btnVerCol.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAgMod
            // 
            this.btnAgMod.Location = new System.Drawing.Point(22, 137);
            this.btnAgMod.Name = "btnAgMod";
            this.btnAgMod.Size = new System.Drawing.Size(196, 23);
            this.btnAgMod.TabIndex = 4;
            this.btnAgMod.Text = "Agregar o Modificar Carro";
            this.btnAgMod.UseVisualStyleBackColor = true;
            this.btnAgMod.Click += new System.EventHandler(this.button5_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 195);
            this.Controls.Add(this.btnAgMod);
            this.Controls.Add(this.btnVerCol);
            this.Controls.Add(this.btnVerTip);
            this.Controls.Add(this.btnVerMar);
            this.Controls.Add(this.btnVerCar);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnVerCar;
        private Button btnVerMar;
        private Button btnVerTip;
        private Button btnVerCol;
        private Button btnAgMod;
    }
}