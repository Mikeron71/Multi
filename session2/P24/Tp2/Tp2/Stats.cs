namespace Tp2
{
    public partial class Stats : Form
    {
        int nbEleves;
        int longeur = 159;
        int totalTp1 = 0;
        int totalTp2 = 0;
        int totalIntra = 0;
        int totalFinal = 0;



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
        int tp1 ;
        int tp2 ;
        int intra  ;
        int final  ;



        public Stats()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {

            try
            {
                Read();
                btn_list.Enabled = true;
                btn_stats.Enabled = true;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void lb_stats_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("load ok ");


        }

        private void btn_load_Click(object sender, EventArgs e)
        {

            Read();
        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            try
            {
                lb_nbEtudiantsValeur.Text = nbEleves.ToString();
                lb_data_moyennetp1.Text = (totalTp1 / nbEleves).ToString();
                lb_data_moyennetp2.Text = (totalTp2 / nbEleves).ToString();
                lb_data_moyenneintra.Text = (totalIntra / nbEleves).ToString();
                lb_data_moyennefinal.Text = (totalFinal / nbEleves).ToString();


                double moyenneTotal = (totalTp1 * 0.1) + (totalTp2 * 0.1) + (totalIntra * 0.4) + (totalFinal * 0.4);

                lb_data_moyenneTotal.Text = (moyenneTotal / nbEleves).ToString();
            }catch(System.DivideByZeroException ex)
            {
                MessageBox.Show("Il n'y a aucun élève d'incrit.");
            }
        }



        private void Read()
        {
            listb_stats.Items.Clear();
            using (FileStream fs = new FileStream("Eleve.Dta", FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {

                    nbEleves = (int)fs.Length / longeur;



                    for (; ; )
                    {
                        if (br.PeekChar() == -1) break;
                        codePermanent = br.ReadString();
                        nom = br.ReadString();
                        prenom = br.ReadString();
                        sexe = br.ReadChar();
                        dateNaissance = br.ReadString();
                        adresse = br.ReadString();
                        ville = br.ReadString();
                        codePostal = br.ReadString();
                        telephone = br.ReadString();
                        noId = br.ReadString();
                        tp1 = br.ReadInt32();
                        tp2 = br.ReadInt32();
                        intra = br.ReadInt32();
                        final = br.ReadInt32();

                        totalTp1 += tp1;
                        totalTp2 += tp2;
                        totalIntra += intra;
                        totalFinal += final;




                        //TOUT BIEN FORMATER AVANT REMISE ___________________________________________________________
                       
                        listb_stats.Items.Add("code permanent " + ":".PadRight(5) + codePermanent);
                        listb_stats.Items.Add("nom " + ":".PadRight(20) + nom);
                        listb_stats.Items.Add(prenom);
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

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Êtes-vous sûr de vouloir quitter?", "QUITTER",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            Environment.Exit(0);
        }
    }
}
