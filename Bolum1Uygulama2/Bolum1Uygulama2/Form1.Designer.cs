﻿namespace Bolum1Uygulama2
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
            this.btnKirmizi = new System.Windows.Forms.Button();
            this.btnYesil = new System.Windows.Forms.Button();
            this.btnMavi = new System.Windows.Forms.Button();
            this.btnSiyah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKirmizi
            // 
            this.btnKirmizi.BackColor = System.Drawing.Color.Red;
            this.btnKirmizi.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnKirmizi.Location = new System.Drawing.Point(92, 84);
            this.btnKirmizi.Name = "btnKirmizi";
            this.btnKirmizi.Size = new System.Drawing.Size(99, 63);
            this.btnKirmizi.TabIndex = 0;
            this.btnKirmizi.Text = "Kırmızı";
            this.btnKirmizi.UseVisualStyleBackColor = false;
            this.btnKirmizi.Click += new System.EventHandler(this.btnKirmizi_Click);
            // 
            // btnYesil
            // 
            this.btnYesil.BackColor = System.Drawing.Color.ForestGreen;
            this.btnYesil.ForeColor = System.Drawing.Color.Snow;
            this.btnYesil.Location = new System.Drawing.Point(92, 153);
            this.btnYesil.Name = "btnYesil";
            this.btnYesil.Size = new System.Drawing.Size(99, 63);
            this.btnYesil.TabIndex = 1;
            this.btnYesil.Text = "Yeşil";
            this.btnYesil.UseVisualStyleBackColor = false;
            this.btnYesil.Click += new System.EventHandler(this.btnYesil_Click);
            // 
            // btnMavi
            // 
            this.btnMavi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMavi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMavi.Location = new System.Drawing.Point(92, 222);
            this.btnMavi.Name = "btnMavi";
            this.btnMavi.Size = new System.Drawing.Size(99, 63);
            this.btnMavi.TabIndex = 2;
            this.btnMavi.Text = "Mavi";
            this.btnMavi.UseVisualStyleBackColor = false;
            this.btnMavi.Click += new System.EventHandler(this.btnMavi_Click);
            // 
            // btnSiyah
            // 
            this.btnSiyah.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSiyah.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSiyah.Location = new System.Drawing.Point(92, 291);
            this.btnSiyah.Name = "btnSiyah";
            this.btnSiyah.Size = new System.Drawing.Size(99, 63);
            this.btnSiyah.TabIndex = 3;
            this.btnSiyah.Text = "Siyah";
            this.btnSiyah.UseVisualStyleBackColor = false;
            this.btnSiyah.Click += new System.EventHandler(this.btnSiyah_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSiyah);
            this.Controls.Add(this.btnMavi);
            this.Controls.Add(this.btnYesil);
            this.Controls.Add(this.btnKirmizi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKirmizi;
        private System.Windows.Forms.Button btnYesil;
        private System.Windows.Forms.Button btnMavi;
        private System.Windows.Forms.Button btnSiyah;
    }
}

