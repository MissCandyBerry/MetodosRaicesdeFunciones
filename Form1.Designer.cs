namespace Metodos_de_Raices_de_Funciones
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
            lblMetodo = new Label();
            lblXi = new Label();
            lblXf = new Label();
            lblResultado = new Label();
            cmbMetodo = new ComboBox();
            txtXi = new TextBox();
            txtXf = new TextBox();
            txtEamax = new TextBox();
            label1 = new Label();
            lblIteraciones = new Label();
            btnCalcular = new Button();
            dgvIteraciones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvIteraciones).BeginInit();
            SuspendLayout();
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Font = new Font("Microsoft YaHei UI", 13.8F);
            lblMetodo.Location = new Point(28, 70);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(108, 30);
            lblMetodo.TabIndex = 0;
            lblMetodo.Text = "Metodo:";
            // 
            // lblXi
            // 
            lblXi.AutoSize = true;
            lblXi.Font = new Font("Microsoft YaHei UI", 13.8F);
            lblXi.Location = new Point(28, 119);
            lblXi.Name = "lblXi";
            lblXi.Size = new Size(193, 30);
            lblXi.TabIndex = 1;
            lblXi.Text = "Valor Inicial (Xi):";
            // 
            // lblXf
            // 
            lblXf.AutoSize = true;
            lblXf.Font = new Font("Microsoft YaHei UI", 13.8F);
            lblXf.Location = new Point(28, 171);
            lblXf.Name = "lblXf";
            lblXf.Size = new Size(182, 30);
            lblXf.TabIndex = 2;
            lblXf.Text = "Valor Final (Xf):";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Microsoft JhengHei UI", 13.8F);
            lblResultado.Location = new Point(28, 670);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(190, 29);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado Final: ";
            // 
            // cmbMetodo
            // 
            cmbMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodo.Font = new Font("Microsoft YaHei UI", 13.8F);
            cmbMetodo.FormattingEnabled = true;
            cmbMetodo.Items.AddRange(new object[] { "Bisección", "Regla Falsa" });
            cmbMetodo.Location = new Point(229, 70);
            cmbMetodo.Name = "cmbMetodo";
            cmbMetodo.Size = new Size(151, 38);
            cmbMetodo.TabIndex = 4;
            // 
            // txtXi
            // 
            txtXi.Font = new Font("Microsoft YaHei UI", 13.8F);
            txtXi.Location = new Point(229, 112);
            txtXi.Name = "txtXi";
            txtXi.Size = new Size(151, 37);
            txtXi.TabIndex = 5;
            // 
            // txtXf
            // 
            txtXf.Font = new Font("Microsoft YaHei UI", 13.8F);
            txtXf.Location = new Point(229, 164);
            txtXf.Name = "txtXf";
            txtXf.Size = new Size(151, 37);
            txtXf.TabIndex = 6;
            // 
            // txtEamax
            // 
            txtEamax.Font = new Font("Microsoft YaHei UI", 13.8F);
            txtEamax.Location = new Point(229, 210);
            txtEamax.Name = "txtEamax";
            txtEamax.Size = new Size(151, 37);
            txtEamax.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 13.8F);
            label1.Location = new Point(28, 213);
            label1.Name = "label1";
            label1.Size = new Size(202, 30);
            label1.TabIndex = 9;
            label1.Text = "Margen de Error:";
            // 
            // lblIteraciones
            // 
            lblIteraciones.AutoSize = true;
            lblIteraciones.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIteraciones.Location = new Point(417, 28);
            lblIteraciones.Name = "lblIteraciones";
            lblIteraciones.Size = new Size(232, 29);
            lblIteraciones.TabIndex = 10;
            lblIteraciones.Text = "Tabla de Iteraciones";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Microsoft YaHei UI", 13.8F);
            btnCalcular.Location = new Point(229, 268);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(151, 41);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // dgvIteraciones
            // 
            dgvIteraciones.AllowUserToAddRows = false;
            dgvIteraciones.AllowUserToDeleteRows = false;
            dgvIteraciones.AllowUserToResizeColumns = false;
            dgvIteraciones.AllowUserToResizeRows = false;
            dgvIteraciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIteraciones.Location = new Point(417, 60);
            dgvIteraciones.MultiSelect = false;
            dgvIteraciones.Name = "dgvIteraciones";
            dgvIteraciones.ReadOnly = true;
            dgvIteraciones.RowHeadersVisible = false;
            dgvIteraciones.RowHeadersWidth = 51;
            dgvIteraciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIteraciones.Size = new Size(839, 724);
            dgvIteraciones.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(1309, 827);
            Controls.Add(dgvIteraciones);
            Controls.Add(btnCalcular);
            Controls.Add(lblIteraciones);
            Controls.Add(label1);
            Controls.Add(txtEamax);
            Controls.Add(txtXf);
            Controls.Add(txtXi);
            Controls.Add(cmbMetodo);
            Controls.Add(lblResultado);
            Controls.Add(lblXf);
            Controls.Add(lblXi);
            Controls.Add(lblMetodo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvIteraciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMetodo;
        private Label lblXi;
        private Label lblXf;
        private Label lblResultado;
        private ComboBox cmbMetodo;
        private TextBox txtXi;
        private TextBox txtXf;
        private TextBox txtEamax;
        private Label label1;
        private Label lblIteraciones;
        private Button btnCalcular;
        private DataGridView dgvIteraciones;
    }
}
