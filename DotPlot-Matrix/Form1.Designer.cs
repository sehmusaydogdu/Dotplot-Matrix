namespace DotPlot_Matrix
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBilgi1 = new System.Windows.Forms.TextBox();
            this.txtBilgi2 = new System.Windows.Forms.TextBox();
            this.btnMatrisOlustur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lstView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Sekansı Giriniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Sekansı Giriniz";
            // 
            // txtBilgi1
            // 
            this.txtBilgi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBilgi1.Location = new System.Drawing.Point(182, 26);
            this.txtBilgi1.Name = "txtBilgi1";
            this.txtBilgi1.Size = new System.Drawing.Size(285, 26);
            this.txtBilgi1.TabIndex = 2;
            // 
            // txtBilgi2
            // 
            this.txtBilgi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBilgi2.Location = new System.Drawing.Point(182, 65);
            this.txtBilgi2.Name = "txtBilgi2";
            this.txtBilgi2.Size = new System.Drawing.Size(285, 26);
            this.txtBilgi2.TabIndex = 3;
            // 
            // btnMatrisOlustur
            // 
            this.btnMatrisOlustur.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMatrisOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatrisOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMatrisOlustur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMatrisOlustur.Location = new System.Drawing.Point(487, 26);
            this.btnMatrisOlustur.Name = "btnMatrisOlustur";
            this.btnMatrisOlustur.Size = new System.Drawing.Size(285, 62);
            this.btnMatrisOlustur.TabIndex = 4;
            this.btnMatrisOlustur.Text = "Dotplot Matrisi Oluştur";
            this.btnMatrisOlustur.UseVisualStyleBackColor = false;
            this.btnMatrisOlustur.Click += new System.EventHandler(this.btnMatrisOlustur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(178, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Benzerlik Oranı   =>";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(378, 110);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(19, 20);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "0";
            // 
            // lstView
            // 
            this.lstView.Location = new System.Drawing.Point(16, 184);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(756, 449);
            this.lstView.TabIndex = 7;
            this.lstView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(824, 659);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMatrisOlustur);
            this.Controls.Add(this.txtBilgi2);
            this.Controls.Add(this.txtBilgi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dotplot Matrix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBilgi1;
        private System.Windows.Forms.TextBox txtBilgi2;
        private System.Windows.Forms.Button btnMatrisOlustur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListView lstView;
    }
}

