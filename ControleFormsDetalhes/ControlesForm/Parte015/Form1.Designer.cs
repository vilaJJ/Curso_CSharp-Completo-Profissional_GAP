﻿namespace Parte015
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
            this.progresso = new System.Windows.Forms.ProgressBar();
            this.button_Executar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progresso
            // 
            this.progresso.Location = new System.Drawing.Point(12, 326);
            this.progresso.MarqueeAnimationSpeed = 10;
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(760, 23);
            this.progresso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progresso.TabIndex = 0;
            // 
            // button_Executar
            // 
            this.button_Executar.Location = new System.Drawing.Point(697, 297);
            this.button_Executar.Name = "button_Executar";
            this.button_Executar.Size = new System.Drawing.Size(75, 23);
            this.button_Executar.TabIndex = 1;
            this.button_Executar.Text = "Executar";
            this.button_Executar.UseVisualStyleBackColor = true;
            this.button_Executar.Click += new System.EventHandler(this.button_Executar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.button_Executar);
            this.Controls.Add(this.progresso);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progresso;
        private System.Windows.Forms.Button button_Executar;
    }
}

