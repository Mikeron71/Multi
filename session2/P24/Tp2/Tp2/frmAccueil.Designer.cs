﻿namespace Tp2
{
    partial class frmAccueil
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
            this.menu_Inscription = new System.Windows.Forms.MenuStrip();
            this.inscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeEtStatistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Inscription.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_Inscription
            // 
            this.menu_Inscription.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscriptionToolStripMenuItem,
            this.listeEtStatistiquesToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menu_Inscription.Location = new System.Drawing.Point(0, 0);
            this.menu_Inscription.Name = "menu_Inscription";
            this.menu_Inscription.Size = new System.Drawing.Size(1234, 24);
            this.menu_Inscription.TabIndex = 1;
            this.menu_Inscription.Text = "Inscription";
            // 
            // inscriptionToolStripMenuItem
            // 
            this.inscriptionToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.inscriptionToolStripMenuItem.Name = "inscriptionToolStripMenuItem";
            this.inscriptionToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.inscriptionToolStripMenuItem.Text = "Inscription";
            this.inscriptionToolStripMenuItem.Click += new System.EventHandler(this.inscriptionToolStripMenuItem_Click);
            // 
            // listeEtStatistiquesToolStripMenuItem
            // 
            this.listeEtStatistiquesToolStripMenuItem.Name = "listeEtStatistiquesToolStripMenuItem";
            this.listeEtStatistiquesToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.listeEtStatistiquesToolStripMenuItem.Text = "Liste et statistiques";
            this.listeEtStatistiquesToolStripMenuItem.Click += new System.EventHandler(this.listeEtStatistiquesToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 911);
            this.Controls.Add(this.menu_Inscription);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu_Inscription;
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu_Inscription.ResumeLayout(false);
            this.menu_Inscription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menu_Inscription;
        private ToolStripMenuItem inscriptionToolStripMenuItem;
        private ToolStripMenuItem listeEtStatistiquesToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
    }
}