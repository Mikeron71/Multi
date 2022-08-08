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
            this.btn_list = new System.Windows.Forms.Button();
            this.lb_nbEtudiants = new System.Windows.Forms.Label();
            this.lb_nbEtudiantsValeur = new System.Windows.Forms.Label();
            this.lb_moyennetp1 = new System.Windows.Forms.Label();
            this.lb_moyenneFinal = new System.Windows.Forms.Label();
            this.lb_moyenneIntra = new System.Windows.Forms.Label();
            this.lb_moyennetp2 = new System.Windows.Forms.Label();
            this.lb_data_moyennetp1 = new System.Windows.Forms.Label();
            this.lb_data_moyennetp2 = new System.Windows.Forms.Label();
            this.lb_moyenneTotal = new System.Windows.Forms.Label();
            this.btn_stats = new System.Windows.Forms.Button();
            this.lv_stats = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.lb_data_moyennefinal = new System.Windows.Forms.Label();
            this.lb_data_moyenneintra = new System.Windows.Forms.Label();
            this.lb_data_moyenneTotal = new System.Windows.Forms.Label();
            this.pan_stats = new System.Windows.Forms.Panel();
            this.pan_stats.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_list
            // 
            this.btn_list.Enabled = false;
            this.btn_list.Location = new System.Drawing.Point(30, 734);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(206, 93);
            this.btn_list.TabIndex = 2;
            this.btn_list.Text = "Liste";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // lb_nbEtudiants
            // 
            this.lb_nbEtudiants.AutoSize = true;
            this.lb_nbEtudiants.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_nbEtudiants.Location = new System.Drawing.Point(561, 704);
            this.lb_nbEtudiants.Name = "lb_nbEtudiants";
            this.lb_nbEtudiants.Size = new System.Drawing.Size(193, 20);
            this.lb_nbEtudiants.TabIndex = 3;
            this.lb_nbEtudiants.Text = "Nombre d\'étudiants inscrits:";
            // 
            // lb_nbEtudiantsValeur
            // 
            this.lb_nbEtudiantsValeur.AutoSize = true;
            this.lb_nbEtudiantsValeur.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_nbEtudiantsValeur.Location = new System.Drawing.Point(797, 704);
            this.lb_nbEtudiantsValeur.Name = "lb_nbEtudiantsValeur";
            this.lb_nbEtudiantsValeur.Size = new System.Drawing.Size(57, 25);
            this.lb_nbEtudiantsValeur.TabIndex = 4;
            this.lb_nbEtudiantsValeur.Text = "DATA";
            // 
            // lb_moyennetp1
            // 
            this.lb_moyennetp1.AutoSize = true;
            this.lb_moyennetp1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_moyennetp1.Location = new System.Drawing.Point(561, 765);
            this.lb_moyennetp1.Name = "lb_moyennetp1";
            this.lb_moyennetp1.Size = new System.Drawing.Size(120, 20);
            this.lb_moyennetp1.TabIndex = 5;
            this.lb_moyennetp1.Text = "Moyenne du tp1:";
            // 
            // lb_moyenneFinal
            // 
            this.lb_moyenneFinal.AutoSize = true;
            this.lb_moyenneFinal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_moyenneFinal.Location = new System.Drawing.Point(934, 767);
            this.lb_moyenneFinal.Name = "lb_moyenneFinal";
            this.lb_moyenneFinal.Size = new System.Drawing.Size(127, 20);
            this.lb_moyenneFinal.TabIndex = 6;
            this.lb_moyenneFinal.Text = "Moyenne du final:";
            // 
            // lb_moyenneIntra
            // 
            this.lb_moyenneIntra.AutoSize = true;
            this.lb_moyenneIntra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_moyenneIntra.Location = new System.Drawing.Point(934, 709);
            this.lb_moyenneIntra.Name = "lb_moyenneIntra";
            this.lb_moyenneIntra.Size = new System.Drawing.Size(135, 20);
            this.lb_moyenneIntra.TabIndex = 7;
            this.lb_moyenneIntra.Text = "Moyenne de l\'intra:";
            // 
            // lb_moyennetp2
            // 
            this.lb_moyennetp2.AutoSize = true;
            this.lb_moyennetp2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_moyennetp2.Location = new System.Drawing.Point(561, 822);
            this.lb_moyennetp2.Name = "lb_moyennetp2";
            this.lb_moyennetp2.Size = new System.Drawing.Size(120, 20);
            this.lb_moyennetp2.TabIndex = 8;
            this.lb_moyennetp2.Text = "Moyenne du tp2:";
            // 
            // lb_data_moyennetp1
            // 
            this.lb_data_moyennetp1.AutoSize = true;
            this.lb_data_moyennetp1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_data_moyennetp1.Location = new System.Drawing.Point(797, 765);
            this.lb_data_moyennetp1.Name = "lb_data_moyennetp1";
            this.lb_data_moyennetp1.Size = new System.Drawing.Size(57, 25);
            this.lb_data_moyennetp1.TabIndex = 9;
            this.lb_data_moyennetp1.Text = "DATA";
            // 
            // lb_data_moyennetp2
            // 
            this.lb_data_moyennetp2.AutoSize = true;
            this.lb_data_moyennetp2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_data_moyennetp2.Location = new System.Drawing.Point(797, 821);
            this.lb_data_moyennetp2.Name = "lb_data_moyennetp2";
            this.lb_data_moyennetp2.Size = new System.Drawing.Size(57, 25);
            this.lb_data_moyennetp2.TabIndex = 10;
            this.lb_data_moyennetp2.Text = "DATA";
            // 
            // lb_moyenneTotal
            // 
            this.lb_moyenneTotal.AutoSize = true;
            this.lb_moyenneTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_moyenneTotal.Location = new System.Drawing.Point(934, 826);
            this.lb_moyenneTotal.Name = "lb_moyenneTotal";
            this.lb_moyenneTotal.Size = new System.Drawing.Size(133, 20);
            this.lb_moyenneTotal.TabIndex = 13;
            this.lb_moyenneTotal.Text = "Moyenne du cours:";
            // 
            // btn_stats
            // 
            this.btn_stats.Enabled = false;
            this.btn_stats.Location = new System.Drawing.Point(269, 734);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(206, 93);
            this.btn_stats.TabIndex = 15;
            this.btn_stats.Text = "Statistiques";
            this.btn_stats.UseVisualStyleBackColor = true;
            this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
            // 
            // lv_stats
            // 
            this.lv_stats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_stats.GridLines = true;
            this.lv_stats.Location = new System.Drawing.Point(33, 39);
            this.lv_stats.Name = "lv_stats";
            this.lv_stats.Size = new System.Drawing.Size(1165, 614);
            this.lv_stats.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lv_stats.TabIndex = 18;
            this.lv_stats.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code Permanent";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            // 
            // lb_data_moyennefinal
            // 
            this.lb_data_moyennefinal.AutoSize = true;
            this.lb_data_moyennefinal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_data_moyennefinal.Location = new System.Drawing.Point(31, 88);
            this.lb_data_moyennefinal.Name = "lb_data_moyennefinal";
            this.lb_data_moyennefinal.Size = new System.Drawing.Size(57, 25);
            this.lb_data_moyennefinal.TabIndex = 12;
            this.lb_data_moyennefinal.Text = "DATA";
            // 
            // lb_data_moyenneintra
            // 
            this.lb_data_moyenneintra.AutoSize = true;
            this.lb_data_moyenneintra.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_data_moyenneintra.Location = new System.Drawing.Point(31, 33);
            this.lb_data_moyenneintra.Name = "lb_data_moyenneintra";
            this.lb_data_moyenneintra.Size = new System.Drawing.Size(57, 25);
            this.lb_data_moyenneintra.TabIndex = 11;
            this.lb_data_moyenneintra.Text = "DATA";
            // 
            // lb_data_moyenneTotal
            // 
            this.lb_data_moyenneTotal.AutoSize = true;
            this.lb_data_moyenneTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_data_moyenneTotal.Location = new System.Drawing.Point(31, 150);
            this.lb_data_moyenneTotal.Name = "lb_data_moyenneTotal";
            this.lb_data_moyenneTotal.Size = new System.Drawing.Size(57, 25);
            this.lb_data_moyenneTotal.TabIndex = 14;
            this.lb_data_moyenneTotal.Text = "DATA";
            // 
            // pan_stats
            // 
            this.pan_stats.Controls.Add(this.lb_data_moyenneTotal);
            this.pan_stats.Controls.Add(this.lb_data_moyenneintra);
            this.pan_stats.Controls.Add(this.lb_data_moyennefinal);
            this.pan_stats.Location = new System.Drawing.Point(1075, 676);
            this.pan_stats.Name = "pan_stats";
            this.pan_stats.Size = new System.Drawing.Size(135, 201);
            this.pan_stats.TabIndex = 17;
            this.pan_stats.Visible = false;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 911);
            this.ControlBox = false;
            this.Controls.Add(this.lb_data_moyennetp2);
            this.Controls.Add(this.lb_data_moyennetp1);
            this.Controls.Add(this.lb_nbEtudiantsValeur);
            this.Controls.Add(this.lv_stats);
            this.Controls.Add(this.pan_stats);
            this.Controls.Add(this.btn_stats);
            this.Controls.Add(this.lb_moyenneTotal);
            this.Controls.Add(this.lb_moyennetp2);
            this.Controls.Add(this.lb_moyenneIntra);
            this.Controls.Add(this.lb_moyenneFinal);
            this.Controls.Add(this.lb_moyennetp1);
            this.Controls.Add(this.lb_nbEtudiants);
            this.Controls.Add(this.btn_list);
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
        private Button btn_list;
        private Label lb_nbEtudiants;
        private Label lb_nbEtudiantsValeur;
        private Label lb_moyennetp1;
        private Label lb_moyenneFinal;
        private Label lb_moyenneIntra;
        private Label lb_moyennetp2;
        private Label lb_data_moyennetp1;
        private Label lb_data_moyennetp2;
        private Label lb_moyenneTotal;
        private Button btn_stats;
        private ListView lv_stats;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label lb_data_moyennefinal;
        private Label lb_data_moyenneintra;
        private Label lb_data_moyenneTotal;
        private Panel pan_stats;
    }
}