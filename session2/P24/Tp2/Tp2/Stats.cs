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

        public Stats()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {

          


        }

        private void lb_stats_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("load ok ");


        }

        private void btn_load_Click(object sender, EventArgs e)
        {   
            using (FileStream fs = new FileStream("Eleve.Dta", FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {

                    nbEleves = (int)fs.Length / longeur;



                    for (; ; )
                    {
                        if (br.PeekChar() == -1) break;
                        string codePermanent = br.ReadString();
                        string nom = br.ReadString();
                        string prenom = br.ReadString();
                        char sexe  = br.ReadChar();
                        string dateNaissance = br.ReadString();
                        string adresse = br.ReadString();
                        string ville = br.ReadString();
                        string codePostal = br.ReadString();
                        string telephone = br.ReadString();
                        string noId = br.ReadString();
                        int tp1 = br.ReadInt32();
                        int tp2 = br.ReadInt32();
                        int intra = br.ReadInt32();
                        int final = br.ReadInt32();

                        totalTp1 += tp1;
                        totalTp2 += tp2;
                        totalIntra += intra;
                        totalFinal += final;




                        //TOUT BIEN FORMATER AVANT REMISE ___________________________________________________________
                        lb_stats.Items.Add("code permanent " +":".PadRight(5) + codePermanent);
                        lb_stats.Items.Add("nom " + ":".PadRight(20) + nom);
                        lb_stats.Items.Add(prenom);
                        lb_stats.Items.Add(sexe);
                        lb_stats.Items.Add(dateNaissance);
                        lb_stats.Items.Add(ville);
                        lb_stats.Items.Add(adresse);
                        lb_stats.Items.Add(codePostal);
                        lb_stats.Items.Add(telephone);
                        lb_stats.Items.Add(noId);
                        lb_stats.Items.Add(tp1);
                        lb_stats.Items.Add(tp2);
                        lb_stats.Items.Add(intra);
                        lb_stats.Items.Add(final);

                    }


                }
            }
            lb_nbEtudiantsValeur.Text = nbEleves.ToString();
            lb_data_moyennetp1.Text = (totalTp1 / nbEleves).ToString();
            lb_data_moyennetp2.Text = (totalTp2 / nbEleves).ToString();
            lb_data_moyenneintra.Text = (totalIntra / nbEleves).ToString();
            lb_data_moyennefinal.Text = (totalFinal / nbEleves).ToString();


            double moyenneTotal = (totalTp1 * 0.1)+(totalTp2*0.1)+(totalIntra * 0.4)+(totalFinal*0.4);

            lb_data_moyenneTotal.Text = (moyenneTotal/nbEleves).ToString();
        }
    }
}
