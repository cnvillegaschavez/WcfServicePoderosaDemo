namespace WFTipoDeCambio
{
    partial class Form1
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.nMes = new System.Windows.Forms.NumericUpDown();
            this.nAnio = new System.Windows.Forms.NumericUpDown();
            this.dgResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(337, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // nMes
            // 
            this.nMes.Location = new System.Drawing.Point(38, 73);
            this.nMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMes.Name = "nMes";
            this.nMes.Size = new System.Drawing.Size(91, 20);
            this.nMes.TabIndex = 1;
            this.nMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nAnio
            // 
            this.nAnio.Location = new System.Drawing.Point(167, 73);
            this.nAnio.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nAnio.Name = "nAnio";
            this.nAnio.Size = new System.Drawing.Size(120, 20);
            this.nAnio.TabIndex = 2;
            // 
            // dgResult
            // 
            this.dgResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Location = new System.Drawing.Point(38, 120);
            this.dgResult.Name = "dgResult";
            this.dgResult.Size = new System.Drawing.Size(415, 222);
            this.dgResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 354);
            this.Controls.Add(this.dgResult);
            this.Controls.Add(this.nAnio);
            this.Controls.Add(this.nMes);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Form1";
            this.Text = "Tipo de Cambio";
            ((System.ComponentModel.ISupportInitialize)(this.nMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.NumericUpDown nMes;
        private System.Windows.Forms.NumericUpDown nAnio;
        private System.Windows.Forms.DataGridView dgResult;
    }
}

