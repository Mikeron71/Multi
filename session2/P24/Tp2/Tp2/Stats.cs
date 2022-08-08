namespace Tp2
{
    public partial class Stats : Form
    {
        double nbEleves;
        int longeur = 159;
        double totalTp1 = 0;
        double totalTp2 = 0;
        double totalIntra = 0;
        double totalFinal = 0;
        string codePermanent ="";
        string nom ="";
        string prenom  = "" ;
        char sexe  ;
        string dateNaissance = "" ;
        string adresse = ""  ;
        string ville ="" ;
        string codePostal ="" ;
        string telephone  ="" ;
        string noId  = "" ;
        double tp1 ;
        double tp2 ;
        double intra  ;
        double final  ;

        public Stats()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {

                Read();
                btn_list.Enabled = true;
                btn_stats.Enabled = true;

        }

        private void lb_stats_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            LoadStats();
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




                            //TOUT BIEN FORMATER AVANT REMISE ___________________________________________________________
                            
                            listb_stats.Items.Add("Code permanent".PadRight(30-codePermanent.Length) +codePermanent) ;
                            listb_stats.Items.Add("Nom".PadRight(30 - nom.Length) + codePermanent);
                            listb_stats.Items.Add("Prenom:".PadRight(50) + prenom);
                            listb_stats.Items.Add(sexe);
                            listb_stats.Items.Add(dateNaissance);
                            listb_stats.Items.Add(ville);
                            listb_stats.Items.Add(adresse);
                            listb_stats.Items.Add(codePostal);
                            listb_stats.Items.Add(telephone);
                            listb_stats.Items.Add(noId);
                            listb_stats.Items.Add(tp1);
                            listb_stats.Items.Add(tp2);
                            listb_stats.Items.Add(intra);
                            listb_stats.Items.Add(final);
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

        private void btn_list_Click(object sender, EventArgs e)
        {
            Read();
        }

        public void LoadStats()
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
    }
}
