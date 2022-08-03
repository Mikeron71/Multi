namespace Tp2
{
    partial class Stats
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
            this.lb_stats = new System.Windows.Forms.ListBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.lb_nbEtudiants = new System.Windows.Forms.Label();
            this.lb_nbEtudiantsValeur = new System.Windows.Forms.Label();
            this.lb_moyennetp1 = new System.Windows.Forms.Label();
            this.lb_moyenneFinal = new System.Windows.Forms.Label();
            this.lb_moyenneIntra = new System.Windows.Forms.Label();
            this.lb_moyennetp2 = new System.Windows.Forms.Label();
            this.lb_data_moyennetp1 = new System.Windows.Forms.Label();
            this.lb_data_moyennetp2 = new System.Windows.Forms.Label();
            this.lb_data_moyenneintra = new System.Windows.Forms.Label();
            this.lb_data_moyennefinal = new System.Windows.Forms.Label();
            this.lb_moyenneTotal = new System.Windows.Forms.Label();
            this.lb_data_moyenneTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1044, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "stats";
            // 
            // lb_stats
            // 
            this.lb_stats.FormattingEnabled = true;
            this.lb_stats.ItemHeight = 15;
            this.lb_stats.Location = new System.Drawing.Point(43, 156);
            this.lb_stats.Name = "lb_stats";
            this.lb_stats.Size = new System.Drawing.Size(363, 484);
            this.lb_stats.TabIndex = 1;
            this.lb_stats.SelectedIndexChanged += new System.EventHandler(this.lb_stats_SelectedIndexChanged);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(272, 676);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 2;
            this.btn_load.Text = "load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // lb_nbEtudiants
            // 
            this.lb_nbEtudiants.AutoSize = true;
            this.lb_nbEtudiants.Location = new System.Drawing.Point(503, 156);
            this.lb_nbEtudiants.Name = "lb_nbEtudiants";
            this.lb_nbEtudiants.Size = new System.Drawing.Size(156, 15);
            this.lb_nbEtudiants.TabIndex = 3;
            this.lb_nbEtudiants.Text = "Nombre d\'étudiants inscrits:";
            // 
            // lb_nbEtudiantsValeur
            // 
            this.lb_nbEtudiantsValeur.AutoSize = true;
            this.lb_nbEtudiantsValeur.Location = new System.Drawing.Point(725, 156);
            this.lb_nbEtudiantsValeur.Name = "lb_nbEtudiantsValeur";
            this.lb_nbEtudiantsValeur.Size = new System.Drawing.Size(38, 15);
            this.lb_nbEtudiantsValeur.TabIndex = 4;
            this.lb_nbEtudiantsValeur.Text = "label2";
            // 
            // lb_moyennetp1
            // 
            this.lb_moyennetp1.AutoSize = true;
            this.lb_moyennetp1.Location = new System.Drawing.Point(503, 236);
            this.lb_moyennetp1.Name = "lb_moyennetp1";
            this.lb_moyennetp1.Size = new System.Drawing.Size(97, 15);
            this.lb_moyennetp1.TabIndex = 5;
            this.lb_moyennetp1.Text = "Moyenne du tp1:";
            // 
            // lb_moyenneFinal
            // 
            this.lb_moyenneFinal.AutoSize = true;
            this.lb_moyenneFinal.Location = new System.Drawing.Point(503, 373);
            this.lb_moyenneFinal.Name = "lb_moyenneFinal";
            this.lb_moyenneFinal.Size = new System.Drawing.Size(103, 15);
            this.lb_moyenneFinal.TabIndex = 6;
            this.lb_moyenneFinal.Text = "Moyenne du final:";
            // 
            // lb_moyenneIntra
            // 
            this.lb_moyenneIntra.AutoSize = true;
            this.lb_moyenneIntra.Location = new System.Drawing.Point(503, 336);
            this.lb_moyenneIntra.Name = "lb_moyenneIntra";
            this.lb_moyenneIntra.Size = new System.Drawing.Size(109, 15);
            this.lb_moyenneIntra.TabIndex = 7;
            this.lb_moyenneIntra.Text = "Moyenne de l\'intra:";
            // 
            // lb_moyennetp2
            // 
            this.lb_moyennetp2.AutoSize = true;
            this.lb_moyennetp2.Location = new System.Drawing.Point(503, 284);
            this.lb_moyennetp2.Name = "lb_moyennetp2";
            this.lb_moyennetp2.Size = new System.Drawing.Size(97, 15);
            this.lb_moyennetp2.TabIndex = 8;
            this.lb_moyennetp2.Text = "Moyenne du tp2:";
            // 
            // lb_data_moyennetp1
            // 
            this.lb_data_moyennetp1.AutoSize = true;
            this.lb_data_moyennetp1.Location = new System.Drawing.Point(712, 236);
            this.lb_data_moyennetp1.Name = "lb_data_moyennetp1";
            this.lb_data_moyennetp1.Size = new System.Drawing.Size(38, 15);
            this.lb_data_moyennetp1.TabIndex = 9;
            this.lb_data_moyennetp1.Text = "label2";
            // 
            // lb_data_moyennetp2
            // 
            this.lb_data_moyennetp2.AutoSize = true;
            this.lb_data_moyennetp2.Location = new System.Drawing.Point(712, 284);
            this.lb_data_moyennetp2.Name = "lb_data_moyennetp2";
            this.lb_data_moyennetp2.Size = new System.Drawing.Size(38, 15);
            this.lb_data_moyennetp2.TabIndex = 10;
            this.lb_data_moyennetp2.Text = "label2";
            // 
            // lb_data_moyenneintra
            // 
            this.lb_data_moyenneintra.AutoSize = true;
            this.lb_data_moyenneintra.Location = new System.Drawing.Point(712, 336);
            this.lb_data_moyenneintra.Name = "lb_data_moyenneintra";
            this.lb_data_moyenneintra.Size = new System.Drawing.Size(38, 15);
            this.lb_data_moyenneintra.TabIndex = 11;
            this.lb_data_moyenneintra.Text = "label2";
            // 
            // lb_data_moyennefinal
            // 
            this.lb_data_moyennefinal.AutoSize = true;
            this.lb_data_moyennefinal.Location = new System.Drawing.Point(712, 373);
            this.lb_data_moyennefinal.Name = "lb_data_moyennefinal";
            this.lb_data_moyennefinal.Size = new System.Drawing.Size(38, 15);
            this.lb_data_moyennefinal.TabIndex = 12;
            this.lb_data_moyennefinal.Text = "label2";
            // 
            // lb_moyenneTotal
            // 
            this.lb_moyenneTotal.AutoSize = true;
            this.lb_moyenneTotal.Location = new System.Drawing.Point(503, 479);
            this.lb_moyenneTotal.Name = "lb_moyenneTotal";
            this.lb_moyenneTotal.Size = new System.Drawing.Size(109, 15);
            this.lb_moyenneTotal.TabIndex = 13;
            this.lb_moyenneTotal.Text = "Moyenne du cours:";
            // 
            // lb_data_moyenneTotal
            // 
            this.lb_data_moyenneTotal.AutoSize = true;
            this.lb_data_moyenneTotal.Location = new System.Drawing.Point(712, 479);
            this.lb_data_moyenneTotal.Name = "lb_data_moyenneTotal";
            this.lb_data_moyenneTotal.Size = new System.Drawing.Size(38, 15);
            this.lb_data_moyenneTotal.TabIndex = 14;
            this.lb_data_moyenneTotal.Text = "label2";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.lb_data_moyenneTotal);
            this.Controls.Add(this.lb_moyenneTotal);
            this.Controls.Add(this.lb_data_moyennefinal);
            this.Controls.Add(this.lb_data_moyenneintra);
            this.Controls.Add(this.lb_data_moyennetp2);
            this.Controls.Add(this.lb_data_moyennetp1);
            this.Controls.Add(this.lb_moyennetp2);
            this.Controls.Add(this.lb_moyenneIntra);
            this.Controls.Add(this.lb_moyenneFinal);
            this.Controls.Add(this.lb_moyennetp1);
            this.Controls.Add(this.lb_nbEtudiantsValeur);
            this.Controls.Add(this.lb_nbEtudiants);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.lb_stats);
            this.Controls.Add(this.label1);
            this.Name = "Stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stats";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lb_stats;
        private Button btn_load;
        private Label lb_nbEtudiants;
        private Label lb_nbEtudiantsValeur;
        private Label lb_moyennetp1;
        private Label lb_moyenneFinal;
        private Label lb_moyenneIntra;
        private Label lb_moyennetp2;
        private Label lb_data_moyennetp1;
        private Label lb_data_moyennetp2;
        private Label lb_data_moyenneintra;
        private Label lb_data_moyennefinal;
        private Label lb_moyenneTotal;
        private Label lb_data_moyenneTotal;
    }
}