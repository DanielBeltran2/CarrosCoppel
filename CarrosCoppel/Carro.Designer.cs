namespace CarrosCoppel
{
    partial class Carro
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CbTipCar = new System.Windows.Forms.ComboBox();
            this.CbColCar = new System.Windows.Forms.ComboBox();
            this.CbMarCar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAñoCar = new System.Windows.Forms.TextBox();
            this.txtModCar = new System.Windows.Forms.TextBox();
            this.txtIdCar = new System.Windows.Forms.TextBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(753, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // CbTipCar
            // 
            this.CbTipCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipCar.FormattingEnabled = true;
            this.CbTipCar.Location = new System.Drawing.Point(129, 181);
            this.CbTipCar.Name = "CbTipCar";
            this.CbTipCar.Size = new System.Drawing.Size(121, 23);
            this.CbTipCar.TabIndex = 26;
            this.CbTipCar.SelectedIndexChanged += new System.EventHandler(this.CbTipCar_SelectedIndexChanged);
            // 
            // CbColCar
            // 
            this.CbColCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbColCar.FormattingEnabled = true;
            this.CbColCar.Location = new System.Drawing.Point(129, 152);
            this.CbColCar.Name = "CbColCar";
            this.CbColCar.Size = new System.Drawing.Size(121, 23);
            this.CbColCar.TabIndex = 25;
            this.CbColCar.SelectedIndexChanged += new System.EventHandler(this.CbColCar_SelectedIndexChanged);
            // 
            // CbMarCar
            // 
            this.CbMarCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMarCar.FormattingEnabled = true;
            this.CbMarCar.Location = new System.Drawing.Point(129, 94);
            this.CbMarCar.Name = "CbMarCar";
            this.CbMarCar.Size = new System.Drawing.Size(121, 23);
            this.CbMarCar.TabIndex = 24;
            this.CbMarCar.SelectedIndexChanged += new System.EventHandler(this.CbMarCar_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tipo Carro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Color Carro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Año Carro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Marca Carro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Modelo Carro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID Carro";
            // 
            // txtAñoCar
            // 
            this.txtAñoCar.Location = new System.Drawing.Point(129, 123);
            this.txtAñoCar.Name = "txtAñoCar";
            this.txtAñoCar.Size = new System.Drawing.Size(121, 23);
            this.txtAñoCar.TabIndex = 17;
            this.txtAñoCar.TextChanged += new System.EventHandler(this.txtAñoCar_TextChanged);
            // 
            // txtModCar
            // 
            this.txtModCar.Location = new System.Drawing.Point(128, 65);
            this.txtModCar.Name = "txtModCar";
            this.txtModCar.Size = new System.Drawing.Size(121, 23);
            this.txtModCar.TabIndex = 16;
            this.txtModCar.TextChanged += new System.EventHandler(this.txtModCar_TextChanged);
            // 
            // txtIdCar
            // 
            this.txtIdCar.Location = new System.Drawing.Point(129, 36);
            this.txtIdCar.Name = "txtIdCar";
            this.txtIdCar.Size = new System.Drawing.Size(121, 23);
            this.txtIdCar.TabIndex = 15;
            this.txtIdCar.TextChanged += new System.EventHandler(this.txtIdCar_TextChanged);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(414, 44);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 27;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 538);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.CbTipCar);
            this.Controls.Add(this.CbColCar);
            this.Controls.Add(this.CbMarCar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAñoCar);
            this.Controls.Add(this.txtModCar);
            this.Controls.Add(this.txtIdCar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Carro";
            this.Text = "BuscarCarro";
            this.Load += new System.EventHandler(this.Carros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox CbTipCar;
        private ComboBox CbColCar;
        private ComboBox CbMarCar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAñoCar;
        private TextBox txtModCar;
        private TextBox txtIdCar;
        private Button btnReiniciar;
    }
}