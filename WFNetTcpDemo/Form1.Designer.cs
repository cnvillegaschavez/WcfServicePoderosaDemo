namespace WFNetTcpDemo
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
            this.BtnGetPerson = new System.Windows.Forms.Button();
            this.TxtPersonId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.BtnTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGetPerson
            // 
            this.BtnGetPerson.Location = new System.Drawing.Point(263, 40);
            this.BtnGetPerson.Name = "BtnGetPerson";
            this.BtnGetPerson.Size = new System.Drawing.Size(75, 23);
            this.BtnGetPerson.TabIndex = 0;
            this.BtnGetPerson.Text = "Get Person";
            this.BtnGetPerson.UseVisualStyleBackColor = true;
            this.BtnGetPerson.Click += new System.EventHandler(this.BtnGetPerson_Click);
            // 
            // TxtPersonId
            // 
            this.TxtPersonId.Location = new System.Drawing.Point(145, 42);
            this.TxtPersonId.Name = "TxtPersonId";
            this.TxtPersonId.Size = new System.Drawing.Size(100, 20);
            this.TxtPersonId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Person Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(142, 81);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(0, 13);
            this.LblName.TabIndex = 4;
            // 
            // BtnTransaction
            // 
            this.BtnTransaction.Location = new System.Drawing.Point(263, 122);
            this.BtnTransaction.Name = "BtnTransaction";
            this.BtnTransaction.Size = new System.Drawing.Size(75, 23);
            this.BtnTransaction.TabIndex = 5;
            this.BtnTransaction.Text = "Transfer";
            this.BtnTransaction.UseVisualStyleBackColor = true;
            this.BtnTransaction.Click += new System.EventHandler(this.BtnTransaction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 261);
            this.Controls.Add(this.BtnTransaction);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPersonId);
            this.Controls.Add(this.BtnGetPerson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGetPerson;
        private System.Windows.Forms.TextBox TxtPersonId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button BtnTransaction;
    }
}

