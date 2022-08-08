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
            this.listb_stats = new System.Windows.Forms.ListBox();
            this.btn_list = new System.Windows.Forms.Button();
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
            this.btn_stats = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.pan_stats = new System.Windows.Forms.Panel();
            this.pan_stats.SuspendLayout();
            this.SuspendLayout();
            // 
            // listb_stats
            // 
            this.listb_stats.FormattingEnabled = true;
            this.listb_stats.ItemHeight = 15;
            this.listb_stats.Location = new System.Drawing.Point(99, 85);
            this.listb_stats.Name = "listb_stats";
            this.listb_stats.Size = new System.Drawing.Size(523, 514);
            this.listb_stats.TabIndex = 1;
            this.listb_stats.SelectedIndexChanged += new System.EventHandler(this.lb_stats_SelectedIndexChanged);
            // 
            // btn_list
            // 
            this.btn_list.Enabled = false;
            this.btn_list.Location = new System.Drawing.Point(99, 698);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(142, 61);
            this.btn_list.TabIndex = 2;
            this.btn_list.Text = "Liste";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // lb_nbEtudiants
            // 
            this.lb_nbEtudiants.AutoSize = true;
            this.lb_nbEtudiants.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_nbEtudiants.Location = new System.Drawing.Point(657, 114);
            this.lb_nbEtudiants.Name = "lb_nbEtudiants";
            this.lb_nbEtudiants.Size = new System.Drawing.Size(247, 25);
            this.lb_nbEtudiants.TabIndex = 3;
            this.lb_nbEtudiants.Text = "Nombre d\'étudiants inscrits:";
            // 
            // lb_nbEtudiantsValeur
            // 
            this.lb_nbEtudiantsValeur.AutoSize = true;
            this.lb_nbEtudiantsValeur.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_nbEtudiantsValeur.Location = new System.Drawing.Point(70, 29);
            this.lb_nbEtudiantsValeur.Name = "lb_nbEtudiantsValeur";
            this.lb_nbEtudiantsValeur.Size = new System.Drawing.Size(57, 25);
            this.lb_nbEtudiantsValeur.TabIndex = 4;
            this.lb_nbEtudiantsValeur.Text = "DATA";
            // 
            // lb_moyennetp1
            // 
            this.lb_moyennetp1.AutoSize = true;
            this.lb_moyennetp1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_moyennetp1.Location = new System.Drawing.Point(657, 175);
            this.lb_moyennetp1.Name = "lb_moyennetp1";
            this.lb_moyennetp1.Size = new System.Drawing.Size(154, 25);
            this.lb_moyennetp1.TabIndex = 5;
            this.lb_moyennetp1.Text = "Moyenne du tp1:";
            // 
            // lb_moyenneFinal
            // 
            this.lb_moyenneFinal.AutoSize = true;
            this.lb_moyenneFinal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_moyenneFinal.Location = new System.Drawing.Point(657, 347);
            this.lb_moyenneFinal.Name = "lb_moyenneFinal";
            this.lb_moyenneFinal.Size = new System.Drawing.Size(164, 25);
            this.lb_moyenneFinal.TabIndex = 6;
            this.lb_moyenneFinal.Text = "Moyenne du final:";
            // 
            // lb_moyenneIntra
            // 
            this.lb_moyenneIntra.AutoSize = true;
            this.lb_moyenneIntra.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_moyenneIntra.Location = new System.Drawing.Point(657, 289);
            this.lb_moyenneIntra.Name = "lb_moyenneIntra";
            this.lb_moyenneIntra.Size = new System.Drawing.Size(174, 25);
            this.lb_moyenneIntra.TabIndex = 7;
            this.lb_moyenneIntra.Text = "Moyenne de l\'intra:";
            // 
            // lb_moyennetp2
            // 
            this.lb_moyennetp2.AutoSize = true;
            this.lb_moyennetp2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_moyennetp2.Location = new System.Drawing.Point(657, 232);
            this.lb_moyennetp2.Name = "lb_moyennetp2";
            this.lb_moyennetp2.Size = new System.Drawing.Size(154, 25);
            this.lb_moyennetp2.TabIndex = 8;
            this.lb_moyennetp2.Text = "Moyenne du tp2:";
            // 
            // lb_data_moyennetp1
            // 
            this.lb_data_moyennetp1.AutoSize = true;
            this.lb_data_moyennetp1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_data_moyennetp1.Location = new System.Drawing.Point(70, 90);
            this.lb_data_moyennetp1.Name = "lb_data_moyennetp1";
            this.lb_data_moyennetp1.Size = new System.Drawing.Size(57, 25);
            this.lb_data_moyennetp1.TabIndex = 9;
            this.lb_data_moyennetp1.Text = "DATA";
            // 
            // lb_data_moyennetp2
            // 
            this.lb_data_moyennetp2.AutoSize = true;
            this.lb_data_moyennetp2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_data_moyennetp2.Location = new System.Drawing.Point(70, 147);
            this.lb_data_moyennetp2.Name = "lb_data_moyennetp2";
            this.lb_data_moyennetp2.Size = new System.Drawing.Size(57, 25);
            this.lb_data_moyennetp2.TabIndex = 10;
            this.lb_data_moyennetp2.Text = "DATA";
            // 
            // lb_data_moyenneintra
            // 
            this.lb_data_moyenneintra.AutoSize = true;
            this.lb_data_moyenneintra.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_data_moyenneintra.Location = new System.Drawing.Point(70, 204);
            this.lb_data_moyenneintra.Name = "lb_data_moyenneintra";
            this.lb_data_moyenneintra.Size = new System.Drawing.Size(57, 25);
            this.lb_data_moyenneintra.TabIndex = 11;
            this.lb_data_moyenneintra.Text = "DATA";
            // 
            // lb_data_moyennefinal
            // 
            this.lb_data_moyennefinal.AutoSize = true;
            this.lb_data_moyennefinal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_data_moyennefinal.Location = new System.Drawing.Point(70, 262);
            this.lb_data_moyennefinal.Name = "lb_data_moyennefinal";
            this.lb_data_moyennefinal.Size = new System.Drawing.Size(57, 25);
            this.lb_data_moyennefinal.TabIndex = 12;
            this.lb_data_moyennefinal.Text = "DATA";
            // 
            // lb_moyenneTotal
            // 
            this.lb_moyenneTotal.AutoSize = true;
            this.lb_moyenneTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_moyenneTotal.Location = new System.Drawing.Point(657, 406);
            this.lb_moyenneTotal.Name = "lb_moyenneTotal";
            this.lb_moyenneTotal.Size = new System.Drawing.Size(173, 25);
            this.lb_moyenneTotal.TabIndex = 13;
            this.lb_moyenneTotal.Text = "Moyenne du cours:";
            // 
            // lb_data_moyenneTotal
            // 
            this.lb_data_moyenneTotal.AutoSize = true;
            this.lb_data_moyenneTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_data_moyenneTotal.Location = new System.Drawing.Point(70, 321);
            this.lb_data_moyenneTotal.Name = "lb_data_moyenneTotal";
            this.lb_data_moyenneTotal.Size = new System.Drawing.Size(57, 25);
            this.lb_data_moyenneTotal.TabIndex = 14;
            this.lb_data_moyenneTotal.Text = "DATA";
            // 
            // btn_stats
            // 
            this.btn_stats.Enabled = false;
            this.btn_stats.Location = new System.Drawing.Point(288, 698);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(142, 61);
            this.btn_stats.TabIndex = 15;
            this.btn_stats.Text = "Statistiques";
            this.btn_stats.UseVisualStyleBackColor = true;
            this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(480, 698);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(142, 61);
            this.btn_quitter.TabIndex = 16;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // pan_stats
            // 
            this.pan_stats.Controls.Add(this.lb_nbEtudiantsValeur);
            this.pan_stats.Controls.Add(this.lb_data_moyennetp1);
            this.pan_stats.Controls.Add(this.lb_data_moyennetp2);
            this.pan_stats.Controls.Add(this.lb_data_moyenneTotal);
            this.pan_stats.Controls.Add(this.lb_data_moyenneintra);
            this.pan_stats.Controls.Add(this.lb_data_moyennefinal);
            this.pan_stats.Location = new System.Drawing.Point(921, 97);
            this.pan_stats.Name = "pan_stats";
            this.pan_stats.Size = new System.Drawing.Size(200, 360);
            this.pan_stats.TabIndex = 17;
            this.pan_stats.Visible = false;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 911);
            this.Controls.Add(this.pan_stats);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_stats);
            this.Controls.Add(this.lb_moyenneTotal);
            this.Controls.Add(this.lb_moyennetp2);
            this.Controls.Add(this.lb_moyenneIntra);
            this.Controls.Add(this.lb_moyenneFinal);
            this.Controls.Add(this.lb_moyennetp1);
            this.Controls.Add(this.lb_nbEtudiants);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.listb_stats);
            this.Name = "Stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stats";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stats_Load);
            this.pan_stats.ResumeLayout(false);
            this.pan_stats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox listb_stats;
        private Button btn_list;
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
        private Button btn_stats;
        private Button btn_quitter;
        private Panel pan_stats;
    }
}