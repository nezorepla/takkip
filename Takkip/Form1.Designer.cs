﻿namespace Takkip
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
            this.btnBekleyenler = new System.Windows.Forms.Button();
            this.YeniGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBekleyenler
            // 
            this.btnBekleyenler.Location = new System.Drawing.Point(172, 12);
            this.btnBekleyenler.Name = "btnBekleyenler";
            this.btnBekleyenler.Size = new System.Drawing.Size(108, 76);
            this.btnBekleyenler.TabIndex = 0;
            this.btnBekleyenler.Text = "Bekleyenler";
            this.btnBekleyenler.UseVisualStyleBackColor = true;
            this.btnBekleyenler.Click += new System.EventHandler(this.btnBekleyenler_Click);
            // 
            // YeniGiris
            // 
            this.YeniGiris.Location = new System.Drawing.Point(408, 12);
            this.YeniGiris.Name = "YeniGiris";
            this.YeniGiris.Size = new System.Drawing.Size(115, 76);
            this.YeniGiris.TabIndex = 1;
            this.YeniGiris.Text = "Yeni I$";
            this.YeniGiris.UseVisualStyleBackColor = true;
            this.YeniGiris.Click += new System.EventHandler(this.YeniGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YeniGiris);
            this.Controls.Add(this.btnBekleyenler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBekleyenler;
        private System.Windows.Forms.Button YeniGiris;
        private System.Windows.Forms.Label label1;
    }
}

