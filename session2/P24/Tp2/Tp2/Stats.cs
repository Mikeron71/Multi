﻿namespace Tp2
{
    public partial class Stats : Form
    {
        double nbEleves;
        int longeur = 159;
        double totalTp1, totalTp2, totalIntra, totalFinal;
        string? codePermanent, nom, prenom, dateNaissance, adresse, ville, codePostal, telephone, noId;
        char sexe;
        double tp1 ,tp2,intra,final;
   

        public Stats()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
                Read();
                LoadMoyenne();
                btn_list.Enabled = true;
                btn_stats.Enabled = true;
        }

        public void Read()
        {
            listb_stats.Items.Clear();
            totalTp1 = 0;
            totalTp2 = 0;
            totalIntra = 0;
            totalFinal = 0;
            try
            {
                using (FileStream fs = new ("Eleve.Dta", FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new (fs))
                    {

                        nbEleves = (int)fs.Length / longeur;

                        for (; ; )
                        {
                            if (br.PeekChar() == -1) break;
                            codePermanent = br.ReadString();
                            nom = br.ReadString().TrimEnd();
                            prenom = br.ReadString().TrimEnd();
                            sexe = br.ReadChar();
                            dateNaissance = br.ReadString();
                            adresse = br.ReadString().TrimEnd();
                            ville = br.ReadString().TrimEnd();
                            codePostal = br.ReadString();
                            telephone = br.ReadString();
                            noId = br.ReadString();
                            tp1 = br.ReadDouble();
                            tp2 = br.ReadDouble();
                            intra = br.ReadDouble();
                            final = br.ReadDouble();

                            totalTp1 += tp1;
                            totalTp2 += tp2;
                            totalIntra += intra;
                            totalFinal += final;

                            listb_stats.Items.Add(String.Format("{0,-20} {1,-20}", "Code permanent :", codePermanent));
                            listb_stats.Items.Add(String.Format("{0,-20} {1,-20}", "Nom :", nom));
                            listb_stats.Items.Add(String.Format("{0,-20} {1,-20}", "Prenom :", prenom));
                            listb_stats.Items.Add(String.Format("{0,-20} {1,-20}", "Sexe :", sexe));
                            listb_stats.Items.Add(String.Format("{0,-20} {1,-20}", "Date de naissance :", dateNaissance));
                            listb_stats.Items.Add(String.Format("{0,-20} {1,-20}", "Adresse :", adresse));
                            listb_stats.Items.Add(String.Format("{0,-20} {1,-20}", "Ville :", ville)); ;
                            listb_stats.Items.Add(String.Format("{0,-20} {1,-20}", "Code postal :", codePostal));
                            listb_stats.Items.Add(String.Format("{0,-20} {1,-20}", "Telephone :", telephone)); ;
                            listb_stats.Items.Add(String.Format("{0,-20} {1,-20}", "No Id :", noId));
                            listb_stats.Items.Add(String.Format("{0,-20} {1,-20}", "Note tp1 :", tp1));
                            listb_stats.Items.Add(String.Format("{0,-20} {1,-20}", "Note tp2 :", tp2));
                            listb_stats.Items.Add(String.Format("{0,-20} {1,-20}", "Note Intra :", intra));
                            listb_stats.Items.Add(String.Format("{0,-20} {1,-20}", "Note final :", final));
                            listb_stats.Items.Add("______________________________________________________________________________");

                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Il n'y a aucun élève d'incrit");
            }
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Êtes-vous sûr de vouloir quitter?", "QUITTER",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            Environment.Exit(0);
        }

        public void LoadMoyenne()
        {
            if (nbEleves > 0)
            {
                try
                {
                    lb_nbEtudiantsValeur.Text = nbEleves.ToString();
                    lb_data_moyennetp1.Text = (totalTp1 / nbEleves / 100).ToString("p");
                    lb_data_moyennetp2.Text = (totalTp2 / nbEleves / 100).ToString("p");
                    lb_data_moyenneintra.Text = (totalIntra / nbEleves / 100).ToString("p");
                    lb_data_moyennefinal.Text = (totalFinal / nbEleves / 100).ToString("p");
                    double moyenneTotal = ((totalTp1 * 0.1) + (totalTp2 * 0.1) + (totalIntra * 0.4) + (totalFinal * 0.4)) / 100 / nbEleves;
                    lb_data_moyenneTotal.Text = moyenneTotal.ToString("p");
                    pan_stats.Visible = true;
                }
                catch (System.DivideByZeroException)
                {
                    MessageBox.Show("Il n'y a aucun élève incrit.");
                }
            }
        }

        
        //BOUTONS (ils ne sont pas nécessaires puisque je met a jour lors du focus.)
        
        private void btn_stats_Click(object sender, EventArgs e)
        {
            LoadMoyenne();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            Read();
        }
    }
}
