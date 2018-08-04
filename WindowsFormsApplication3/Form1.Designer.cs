namespace WindowsFormsApplication3
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
            this.btnCD_ac = new System.Windows.Forms.Button();
            this.btnCD_kapa = new System.Windows.Forms.Button();
            this.btn_acik_sure = new System.Windows.Forms.Button();
            this.lblSure = new System.Windows.Forms.Label();
            this.btnYanSon = new System.Windows.Forms.Button();
            this.btnAnimasyon = new System.Windows.Forms.Button();
            this.btnAnimasyon2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCD_ac
            // 
            this.btnCD_ac.Location = new System.Drawing.Point(12, 12);
            this.btnCD_ac.Name = "btnCD_ac";
            this.btnCD_ac.Size = new System.Drawing.Size(75, 23);
            this.btnCD_ac.TabIndex = 0;
            this.btnCD_ac.Text = " CD AC";
            this.btnCD_ac.UseVisualStyleBackColor = true;
            this.btnCD_ac.Click += new System.EventHandler(this.btnCD_ac_Click);
            // 
            // btnCD_kapa
            // 
            this.btnCD_kapa.Location = new System.Drawing.Point(197, 12);
            this.btnCD_kapa.Name = "btnCD_kapa";
            this.btnCD_kapa.Size = new System.Drawing.Size(75, 23);
            this.btnCD_kapa.TabIndex = 1;
            this.btnCD_kapa.Text = "KAPAT";
            this.btnCD_kapa.UseVisualStyleBackColor = true;
            this.btnCD_kapa.Click += new System.EventHandler(this.btnCD_kapa_Click);
            // 
            // btn_acik_sure
            // 
            this.btn_acik_sure.Location = new System.Drawing.Point(12, 56);
            this.btn_acik_sure.Name = "btn_acik_sure";
            this.btn_acik_sure.Size = new System.Drawing.Size(75, 23);
            this.btn_acik_sure.TabIndex = 2;
            this.btn_acik_sure.Text = "acık süre";
            this.btn_acik_sure.UseVisualStyleBackColor = true;
            this.btn_acik_sure.Click += new System.EventHandler(this.btn_acik_sure_Click);
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(114, 66);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(35, 13);
            this.lblSure.TabIndex = 3;
            this.lblSure.Text = "label1";
            // 
            // btnYanSon
            // 
            this.btnYanSon.Location = new System.Drawing.Point(12, 99);
            this.btnYanSon.Name = "btnYanSon";
            this.btnYanSon.Size = new System.Drawing.Size(75, 46);
            this.btnYanSon.TabIndex = 4;
            this.btnYanSon.Text = "YanSön";
            this.btnYanSon.UseVisualStyleBackColor = true;
            this.btnYanSon.Click += new System.EventHandler(this.btnYanSon_Click);
            // 
            // btnAnimasyon
            // 
            this.btnAnimasyon.Location = new System.Drawing.Point(12, 163);
            this.btnAnimasyon.Name = "btnAnimasyon";
            this.btnAnimasyon.Size = new System.Drawing.Size(75, 23);
            this.btnAnimasyon.TabIndex = 5;
            this.btnAnimasyon.Text = "Animasyon1";
            this.btnAnimasyon.UseVisualStyleBackColor = true;
            this.btnAnimasyon.Click += new System.EventHandler(this.btnAnimasyon_Click);
            // 
            // btnAnimasyon2
            // 
            this.btnAnimasyon2.Location = new System.Drawing.Point(148, 163);
            this.btnAnimasyon2.Name = "btnAnimasyon2";
            this.btnAnimasyon2.Size = new System.Drawing.Size(75, 23);
            this.btnAnimasyon2.TabIndex = 6;
            this.btnAnimasyon2.Text = "Anmasyon2";
            this.btnAnimasyon2.UseVisualStyleBackColor = true;
            this.btnAnimasyon2.Click += new System.EventHandler(this.btnAnimasyon2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 262);
            this.Controls.Add(this.btnAnimasyon2);
            this.Controls.Add(this.btnAnimasyon);
            this.Controls.Add(this.btnYanSon);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.btn_acik_sure);
            this.Controls.Add(this.btnCD_kapa);
            this.Controls.Add(this.btnCD_ac);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCD_ac;
        private System.Windows.Forms.Button btnCD_kapa;
        private System.Windows.Forms.Button btn_acik_sure;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Button btnYanSon;
        private System.Windows.Forms.Button btnAnimasyon;
        private System.Windows.Forms.Button btnAnimasyon2;
    }
}

