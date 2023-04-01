namespace CarrosCoppel
{
    partial class AgregarCarros
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
            this.txtIdCar = new System.Windows.Forms.TextBox();
            this.txtModCar = new System.Windows.Forms.TextBox();
            this.txtAñoCar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbMarCar = new System.Windows.Forms.ComboBox();
            this.CbColCar = new System.Windows.Forms.ComboBox();
            this.CbTipCar = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.rbMod = new System.Windows.Forms.RadioButton();
            this.rbNuevo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCar
            // 
            this.txtIdCar.Location = new System.Drawing.Point(103, 59);
            this.txtIdCar.Name = "txtIdCar";
            this.txtIdCar.Size = new System.Drawing.Size(121, 23);
            this.txtIdCar.TabIndex = 0;
            this.txtIdCar.TextChanged += new System.EventHandler(this.txtIdCar_TextChanged);
            this.txtIdCar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCar_KeyPress);
            // 
            // txtModCar
            // 
            this.txtModCar.Location = new System.Drawing.Point(102, 88);
            this.txtModCar.Name = "txtModCar";
            this.txtModCar.Size = new System.Drawing.Size(121, 23);
            this.txtModCar.TabIndex = 1;
            // 
            // txtAñoCar
            // 
            this.txtAñoCar.Location = new System.Drawing.Point(103, 146);
            this.txtAñoCar.Name = "txtAñoCar";
            this.txtAñoCar.Size = new System.Drawing.Size(121, 23);
            this.txtAñoCar.TabIndex = 3;
            this.txtAñoCar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAñoCar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Carro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modelo Carro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Marca Carro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Año Carro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Color Carro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo Carro";
            // 
            // CbMarCar
            // 
            this.CbMarCar.FormattingEnabled = true;
            this.CbMarCar.Location = new System.Drawing.Point(103, 117);
            this.CbMarCar.Name = "CbMarCar";
            this.CbMarCar.Size = new System.Drawing.Size(121, 23);
            this.CbMarCar.TabIndex = 12;
            // 
            // CbColCar
            // 
            this.CbColCar.FormattingEnabled = true;
            this.CbColCar.Location = new System.Drawing.Point(103, 175);
            this.CbColCar.Name = "CbColCar";
            this.CbColCar.Size = new System.Drawing.Size(121, 23);
            this.CbColCar.TabIndex = 13;
            // 
            // CbTipCar
            // 
            this.CbTipCar.FormattingEnabled = true;
            this.CbTipCar.Location = new System.Drawing.Point(103, 204);
            this.CbTipCar.Name = "CbTipCar";
            this.CbTipCar.Size = new System.Drawing.Size(121, 23);
            this.CbTipCar.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(397, 65);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(397, 116);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // rbMod
            // 
            this.rbMod.AutoSize = true;
            this.rbMod.Location = new System.Drawing.Point(15, 47);
            this.rbMod.Name = "rbMod";
            this.rbMod.Size = new System.Drawing.Size(76, 19);
            this.rbMod.TabIndex = 17;
            this.rbMod.Text = "Modificar";
            this.rbMod.UseVisualStyleBackColor = true;
            this.rbMod.CheckedChanged += new System.EventHandler(this.rbMod_CheckedChanged);
            // 
            // rbNuevo
            // 
            this.rbNuevo.AutoSize = true;
            this.rbNuevo.Checked = true;
            this.rbNuevo.Location = new System.Drawing.Point(15, 22);
            this.rbNuevo.Name = "rbNuevo";
            this.rbNuevo.Size = new System.Drawing.Size(60, 19);
            this.rbNuevo.TabIndex = 18;
            this.rbNuevo.TabStop = true;
            this.rbNuevo.Text = "Nuevo";
            this.rbNuevo.UseVisualStyleBackColor = true;
            this.rbNuevo.CheckedChanged += new System.EventHandler(this.rbNuevo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNuevo);
            this.groupBox1.Controls.Add(this.rbMod);
            this.groupBox1.Location = new System.Drawing.Point(397, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 84);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(812, 244);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AgregarCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
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
            this.Name = "AgregarCarros";
            this.Text = "AgregarCarros";
            this.Load += new System.EventHandler(this.AgregarCarros_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtIdCar;
        private TextBox txtModCar;
        private TextBox txtAñoCar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox CbMarCar;
        private ComboBox CbColCar;
        private ComboBox CbTipCar;
        private Button btnGuardar;
        private Button btnLimpiar;
        private RadioButton rbMod;
        private RadioButton rbNuevo;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
    }
}