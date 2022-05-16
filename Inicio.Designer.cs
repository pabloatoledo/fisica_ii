namespace Fisica_II
{
    partial class Fisica_II
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
            this.tblPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbFormula = new System.Windows.Forms.ComboBox();
            this.cmbSubtema = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblForm1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.lblFinal = new System.Windows.Forms.Label();
            this.txtVal6 = new System.Windows.Forms.TextBox();
            this.txtVal5 = new System.Windows.Forms.TextBox();
            this.txtVal4 = new System.Windows.Forms.TextBox();
            this.txtVal3 = new System.Windows.Forms.TextBox();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.lblVal6 = new System.Windows.Forms.Label();
            this.lblVal5 = new System.Windows.Forms.Label();
            this.lblVal4 = new System.Windows.Forms.Label();
            this.lblVal3 = new System.Windows.Forms.Label();
            this.lblVal2 = new System.Windows.Forms.Label();
            this.lblVal1 = new System.Windows.Forms.Label();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tblPrincipal.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tblForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.ColumnCount = 1;
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPrincipal.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tblPrincipal.Controls.Add(this.dataGridView1, 0, 2);
            this.tblPrincipal.Controls.Add(this.tblForm1, 0, 1);
            this.tblPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblPrincipal.Name = "tblPrincipal";
            this.tblPrincipal.RowCount = 3;
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPrincipal.Size = new System.Drawing.Size(1029, 561);
            this.tblPrincipal.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Controls.Add(this.cmbFormula, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbSubtema, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbTema, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1023, 190);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cmbFormula
            // 
            this.cmbFormula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFormula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormula.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormula.FormattingEnabled = true;
            this.cmbFormula.Items.AddRange(new object[] {
            "Formula 1",
            "Formula 2",
            "Formula 3",
            "Formula 4"});
            this.cmbFormula.Location = new System.Drawing.Point(258, 139);
            this.cmbFormula.Name = "cmbFormula";
            this.cmbFormula.Size = new System.Drawing.Size(762, 37);
            this.cmbFormula.TabIndex = 4;
            this.cmbFormula.SelectedValueChanged += new System.EventHandler(this.muestraFormula);
            // 
            // cmbSubtema
            // 
            this.cmbSubtema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSubtema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubtema.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubtema.FormattingEnabled = true;
            this.cmbSubtema.Items.AddRange(new object[] {
            "Subtema 1",
            "Subtema 2",
            "Subtema 3",
            "Subtema 4"});
            this.cmbSubtema.Location = new System.Drawing.Point(258, 76);
            this.cmbSubtema.Name = "cmbSubtema";
            this.cmbSubtema.Size = new System.Drawing.Size(762, 37);
            this.cmbSubtema.TabIndex = 3;
            this.cmbSubtema.SelectedValueChanged += new System.EventHandler(this.actFormulas);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 64);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fórmula";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subtema";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tema";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTema
            // 
            this.cmbTema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTema.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Items.AddRange(new object[] {
            "Tema 1",
            "Tema 2",
            "Tema 3",
            "Tema 4"});
            this.cmbTema.Location = new System.Drawing.Point(258, 13);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(762, 37);
            this.cmbTema.TabIndex = 1;
            this.cmbTema.SelectedIndexChanged += new System.EventHandler(this.actSubtemas);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 423);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 135);
            this.dataGridView1.TabIndex = 1;
            // 
            // tblForm1
            // 
            this.tblForm1.ColumnCount = 6;
            this.tblForm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.665F));
            this.tblForm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.665F));
            this.tblForm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.665F));
            this.tblForm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.665F));
            this.tblForm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.665F));
            this.tblForm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.675F));
            this.tblForm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblForm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblForm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblForm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblForm1.Controls.Add(this.txtFinal, 4, 2);
            this.tblForm1.Controls.Add(this.lblFinal, 3, 2);
            this.tblForm1.Controls.Add(this.txtVal6, 5, 1);
            this.tblForm1.Controls.Add(this.txtVal5, 4, 1);
            this.tblForm1.Controls.Add(this.txtVal4, 3, 1);
            this.tblForm1.Controls.Add(this.txtVal3, 2, 1);
            this.tblForm1.Controls.Add(this.txtVal2, 1, 1);
            this.tblForm1.Controls.Add(this.lblVal6, 5, 0);
            this.tblForm1.Controls.Add(this.lblVal5, 4, 0);
            this.tblForm1.Controls.Add(this.lblVal4, 3, 0);
            this.tblForm1.Controls.Add(this.lblVal3, 2, 0);
            this.tblForm1.Controls.Add(this.lblVal2, 1, 0);
            this.tblForm1.Controls.Add(this.lblVal1, 0, 0);
            this.tblForm1.Controls.Add(this.txtVal1, 0, 1);
            this.tblForm1.Controls.Add(this.btnCalcular, 1, 2);
            this.tblForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblForm1.Location = new System.Drawing.Point(3, 199);
            this.tblForm1.Name = "tblForm1";
            this.tblForm1.RowCount = 3;
            this.tblForm1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblForm1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblForm1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tblForm1.Size = new System.Drawing.Size(1023, 218);
            this.tblForm1.TabIndex = 2;
            // 
            // txtFinal
            // 
            this.txtFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblForm1.SetColumnSpan(this.txtFinal, 2);
            this.txtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.Location = new System.Drawing.Point(683, 165);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(337, 29);
            this.txtFinal.TabIndex = 21;
            this.txtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFinal.Visible = false;
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(513, 142);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(164, 76);
            this.lblFinal.TabIndex = 20;
            this.lblFinal.Text = "Resultado";
            this.lblFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFinal.Visible = false;
            // 
            // txtVal6
            // 
            this.txtVal6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVal6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal6.Location = new System.Drawing.Point(853, 92);
            this.txtVal6.Name = "txtVal6";
            this.txtVal6.Size = new System.Drawing.Size(167, 29);
            this.txtVal6.TabIndex = 15;
            this.txtVal6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVal5
            // 
            this.txtVal5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVal5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal5.Location = new System.Drawing.Point(683, 92);
            this.txtVal5.Name = "txtVal5";
            this.txtVal5.Size = new System.Drawing.Size(164, 29);
            this.txtVal5.TabIndex = 14;
            this.txtVal5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVal4
            // 
            this.txtVal4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVal4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal4.Location = new System.Drawing.Point(513, 92);
            this.txtVal4.Name = "txtVal4";
            this.txtVal4.Size = new System.Drawing.Size(164, 29);
            this.txtVal4.TabIndex = 13;
            this.txtVal4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVal3
            // 
            this.txtVal3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal3.Location = new System.Drawing.Point(343, 92);
            this.txtVal3.Name = "txtVal3";
            this.txtVal3.Size = new System.Drawing.Size(164, 29);
            this.txtVal3.TabIndex = 12;
            this.txtVal3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVal2
            // 
            this.txtVal2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal2.Location = new System.Drawing.Point(173, 92);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(164, 29);
            this.txtVal2.TabIndex = 11;
            this.txtVal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVal6
            // 
            this.lblVal6.AutoSize = true;
            this.lblVal6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVal6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVal6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal6.Location = new System.Drawing.Point(853, 0);
            this.lblVal6.Name = "lblVal6";
            this.lblVal6.Size = new System.Drawing.Size(167, 71);
            this.lblVal6.TabIndex = 5;
            this.lblVal6.Text = "Valor 6";
            this.lblVal6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVal5
            // 
            this.lblVal5.AutoSize = true;
            this.lblVal5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVal5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVal5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal5.Location = new System.Drawing.Point(683, 0);
            this.lblVal5.Name = "lblVal5";
            this.lblVal5.Size = new System.Drawing.Size(164, 71);
            this.lblVal5.TabIndex = 4;
            this.lblVal5.Text = "Valor 5";
            this.lblVal5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVal4
            // 
            this.lblVal4.AutoSize = true;
            this.lblVal4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVal4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVal4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal4.Location = new System.Drawing.Point(513, 0);
            this.lblVal4.Name = "lblVal4";
            this.lblVal4.Size = new System.Drawing.Size(164, 71);
            this.lblVal4.TabIndex = 3;
            this.lblVal4.Text = "Valor 4";
            this.lblVal4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVal3
            // 
            this.lblVal3.AutoSize = true;
            this.lblVal3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVal3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal3.Location = new System.Drawing.Point(343, 0);
            this.lblVal3.Name = "lblVal3";
            this.lblVal3.Size = new System.Drawing.Size(164, 71);
            this.lblVal3.TabIndex = 2;
            this.lblVal3.Text = "Valor 3";
            this.lblVal3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVal2
            // 
            this.lblVal2.AutoSize = true;
            this.lblVal2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVal2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal2.Location = new System.Drawing.Point(173, 0);
            this.lblVal2.Name = "lblVal2";
            this.lblVal2.Size = new System.Drawing.Size(164, 71);
            this.lblVal2.TabIndex = 1;
            this.lblVal2.Text = "Valor 2";
            this.lblVal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVal1
            // 
            this.lblVal1.AutoSize = true;
            this.lblVal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal1.Location = new System.Drawing.Point(3, 0);
            this.lblVal1.Name = "lblVal1";
            this.lblVal1.Size = new System.Drawing.Size(164, 71);
            this.lblVal1.TabIndex = 0;
            this.lblVal1.Text = "Valor 1";
            this.lblVal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVal1
            // 
            this.txtVal1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal1.Location = new System.Drawing.Point(3, 92);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(164, 29);
            this.txtVal1.TabIndex = 10;
            this.txtVal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(173, 145);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(164, 70);
            this.btnCalcular.TabIndex = 22;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Fisica_II
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 561);
            this.Controls.Add(this.tblPrincipal);
            this.Name = "Fisica_II";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fisica_II";
            this.Load += new System.EventHandler(this.Fisica_II_Load);
            this.tblPrincipal.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tblForm1.ResumeLayout(false);
            this.tblForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFormula;
        private System.Windows.Forms.ComboBox cmbSubtema;
        public System.Windows.Forms.ComboBox cmbTema;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tblForm1;
        private System.Windows.Forms.TextBox txtVal6;
        private System.Windows.Forms.TextBox txtVal5;
        private System.Windows.Forms.TextBox txtVal4;
        private System.Windows.Forms.TextBox txtVal3;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.Label lblVal6;
        private System.Windows.Forms.Label lblVal5;
        private System.Windows.Forms.Label lblVal4;
        private System.Windows.Forms.Label lblVal3;
        private System.Windows.Forms.Label lblVal2;
        private System.Windows.Forms.Label lblVal1;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Button btnCalcular;
    }
}

