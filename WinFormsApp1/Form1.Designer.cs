namespace WinFormsApp1
{
    partial class Form1
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
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            lblResultado = new Label();
            lblPrimerOperando = new Label();
            lblSegundoOperando = new Label();
            lblHistorial = new Label();
            label4 = new Label();
            txtSegundoOperando = new TextBox();
            txtPrimerOperando = new TextBox();
            cmbOperacion = new ComboBox();
            lstHistorial = new ListBox();
            SuspendLayout();
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(28, 368);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(154, 70);
            btnOperar.TabIndex = 0;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += button1_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(318, 368);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(144, 71);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(573, 368);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(142, 71);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rdbBinario.Location = new Point(276, 200);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(90, 29);
            rdbBinario.TabIndex = 3;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rdbDecimal.Location = new Point(392, 200);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(96, 29);
            rdbDecimal.TabIndex = 4;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(12, 50);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 37);
            lblResultado.TabIndex = 5;
            // 
            // lblPrimerOperando
            // 
            lblPrimerOperando.AutoSize = true;
            lblPrimerOperando.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperando.Location = new Point(12, 253);
            lblPrimerOperando.Name = "lblPrimerOperando";
            lblPrimerOperando.Size = new Size(217, 37);
            lblPrimerOperando.TabIndex = 6;
            lblPrimerOperando.Text = "Primer operando";
            // 
            // lblSegundoOperando
            // 
            lblSegundoOperando.AutoSize = true;
            lblSegundoOperando.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperando.Location = new Point(506, 253);
            lblSegundoOperando.Name = "lblSegundoOperando";
            lblSegundoOperando.Size = new Size(250, 37);
            lblSegundoOperando.TabIndex = 7;
            lblSegundoOperando.Text = "Segundo Operando";
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorial.Location = new Point(763, 23);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(122, 37);
            lblHistorial.TabIndex = 8;
            lblHistorial.Text = "Historial:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(117, 141);
            label4.Name = "label4";
            label4.Size = new Size(272, 28);
            label4.TabIndex = 9;
            label4.Text = "Elija sistema para su resultado";
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.Location = new Point(573, 325);
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.Size = new Size(142, 23);
            txtSegundoOperando.TabIndex = 10;
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Location = new Point(29, 325);
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.Size = new Size(153, 23);
            txtPrimerOperando.TabIndex = 11;
            // 
            // cmbOperacion
            // 
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(318, 305);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(144, 23);
            cmbOperacion.TabIndex = 12;
            cmbOperacion.SelectedIndexChanged += cmbOperacion_SelectedIndexChanged;
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Location = new Point(857, 72);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(187, 454);
            lstHistorial.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 596);
            Controls.Add(lstHistorial);
            Controls.Add(cmbOperacion);
            Controls.Add(txtPrimerOperando);
            Controls.Add(txtSegundoOperando);
            Controls.Add(label4);
            Controls.Add(lblHistorial);
            Controls.Add(lblSegundoOperando);
            Controls.Add(lblPrimerOperando);
            Controls.Add(lblResultado);
            Controls.Add(rdbDecimal);
            Controls.Add(rdbBinario);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Name = "Form1";
            Text = "weqweq";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private Label lblResultado;
        private Label lblPrimerOperando;
        private Label lblSegundoOperando;
        private Label lblHistorial;
        private Label label4;
        private TextBox txtSegundoOperando;
        private TextBox txtPrimerOperando;
        private ComboBox cmbOperacion;
        private ListBox lstHistorial;
    }
}