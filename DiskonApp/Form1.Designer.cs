namespace DiskonApp
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
            btnApply = new Button();
            groupBox1 = new GroupBox();
            btnExit = new Button();
            txtTotal = new TextBox();
            txtDiskon = new TextBox();
            txtNominal = new TextBox();
            btnReset = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnApply
            // 
            btnApply.Location = new Point(339, 22);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 46);
            btnApply.TabIndex = 0;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(txtDiskon);
            groupBox1.Controls.Add(txtNominal);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnApply);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 177);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(339, 124);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 46);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(6, 137);
            txtTotal.Name = "txtTotal";
            txtTotal.PlaceholderText = "Total";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(327, 23);
            txtTotal.TabIndex = 4;
            // 
            // txtDiskon
            // 
            txtDiskon.Location = new Point(6, 87);
            txtDiskon.Name = "txtDiskon";
            txtDiskon.PlaceholderText = "Persentase Diskon %";
            txtDiskon.Size = new Size(327, 23);
            txtDiskon.TabIndex = 3;
            // 
            // txtNominal
            // 
            txtNominal.Location = new Point(6, 30);
            txtNominal.Name = "txtNominal";
            txtNominal.PlaceholderText = "Nominal";
            txtNominal.Size = new Size(327, 23);
            txtNominal.TabIndex = 2;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(339, 74);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 46);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 220);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Diskon App";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnApply;
        private GroupBox groupBox1;
        private Button btnExit;
        private TextBox txtTotal;
        private TextBox txtDiskon;
        private TextBox txtNominal;
        private Button btnReset;
    }
}