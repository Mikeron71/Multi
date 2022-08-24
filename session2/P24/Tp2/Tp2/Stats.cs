namespace Tp2
{
    public partial class Stats : Form
    {
        double nbEleves;
        int longeur = 175;
        double totalTp1, totalTp2, totalIntra, totalFinal;
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
            CreateList();
        }

        public void Read()
        {
            lv_stats.Items.Clear();
            totalTp1 = 0;
            totalTp2 = 0;
            totalIntra = 0;
            totalFinal = 0;
            try
            {
                using (FileStream fs = new ("Eleve.Dta", FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new (fs, System.Text.Encoding.Latin1))
                    {

                        nbEleves = (int)fs.Length / longeur;

                        for (; ; )
                        {
                            if (br.PeekChar() == -1) break;
                            Etudiant.codePermanent = br.ReadString();
                            Etudiant.nom = br.ReadString().TrimEnd();
                            Etudiant.prenom = br.ReadString().TrimEnd();
                            Etudiant.sexe = br.ReadChar();
                            Etudiant.dateNaissance = br.ReadString();
                            Etudiant.adresse = br.ReadString().TrimEnd();
                            Etudiant.ville = br.ReadString().TrimEnd();
                            Etudiant.codePostal = br.ReadString();
                            Etudiant.telephone = br.ReadString();
                            Etudiant.noId = br.ReadString();
                            tp1 = br.ReadDouble();
                            tp2 = br.ReadDouble();
                            intra = br.ReadDouble();
                            final = br.ReadDouble();

                            totalTp1 += tp1;
                            totalTp2 += tp2;
                            totalIntra += intra;
                            totalFinal += final;

                            string[] arr = new string[14];
                            arr[0] = Etudiant.noId;
                            arr[1] = Etudiant.nom;
                            arr[2] = Etudiant.prenom;
                            arr[3] = Etudiant.sexe.ToString();
                            arr[4] = Etudiant.dateNaissance;
                            arr[5] = Etudiant.adresse;
                            arr[6] = Etudiant.ville;
                            arr[7] = Etudiant.codePostal;
                            arr[8] = Etudiant.telephone;
                            arr[9] = Etudiant.codePermanent;
                            arr[10] = tp1.ToString();
                            arr[11] = tp2.ToString();
                            arr[12] = intra.ToString();
                            arr[13] = final.ToString();

                            ListViewItem item;
                            item = new ListViewItem(arr);
                            lv_stats.Items.Add(item);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Il n'y a aucun élève d'incrit");
            }
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

        private void CreateList()
        {
            lv_stats.View = View.Details;
            lv_stats.GridLines = true;
            lv_stats.FullRowSelect = true;
            lv_stats.Columns.Add("Id", 70);
            lv_stats.Columns.Add("Nom", 110);
            lv_stats.Columns.Add("Prenom", 110);
            lv_stats.Columns.Add("sexe", 35);
            lv_stats.Columns.Add("Date de naissance", 110);
            lv_stats.Columns.Add("Adresse", 110);
            lv_stats.Columns.Add("Ville", 110);
            lv_stats.Columns.Add("Code Postal", 90);
            lv_stats.Columns.Add("telephone", 110);
            lv_stats.Columns.Add("Code permanent:", 110);
            lv_stats.Columns.Add("Tp1", 40);
            lv_stats.Columns.Add("Tp2", 40);
            lv_stats.Columns.Add("Intra", 40);
            lv_stats.Columns.Add("Final", 40);
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

        private void lv_stats_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string noid = lv_stats.SelectedItems[0].Text;
            frmAccueil.frmInscription.Focus();
            frmAccueil.frmInscription.action = "rechercheEleve";
            frmAccueil.frmInscription.Find(noid);
        }


    }
}
