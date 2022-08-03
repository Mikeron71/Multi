namespace Tp2
{
    public partial class Inscription : Form
    {
        int pos = 0;
        int longeur = 159;
        public int nbEleves = 0;
        public string noId = "";
        int compteExistant = 1;
        string action = "";
       
        public Inscription()
        {
            InitializeComponent();
            GetEtudiant(pos);
        }
        public void AddMode()
        {
            action = "ajout";

            foreach (Control item in gb_inscription.Controls)
            {
                item.Enabled = true;

            }

            btn_modifier.Enabled = false;
            btn_supprimer.Enabled = false;
            btn_ok.Enabled = true;
            btn_annuler.Enabled = true;
            
        }
        public void IdleMode()
        {
            foreach (Control item in gb_inscription.Controls)
            {
                item.Enabled = false;
            }
            btn_modifier.Enabled = true;
            btn_supprimer.Enabled = true;
            btn_ok.Enabled = false;
            btn_annuler.Enabled = false;
            btn_nouveau.Enabled = true;
            gb_notes.Visible = false;
            gb_recherche.Visible = false;
            pan_nav.Enabled = true;
        }

        private void btn_nouveau_Click(object sender, EventArgs e)
        {   
            AddMode();
            ClearGroup(gb_inscription);
            pan_nav.Enabled = false;
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
                
                string codePermanent = tb_codePermanent.Text.PadRight(13);
                string nom = tb_nom.Text.PadRight(16);
                string prenom = tb_prenom.Text.PadRight(16);
                char sexe = rb_feminin.Checked ? 'F' : 'M';
                string dateNaissance = tb_dateNaissance.Text;
                string adresse = tb_adresse.Text.PadRight(31);
                string ville = tb_ville.Text.PadRight(21);
                string codePostal = tb_codePostal.Text;
                string telephone = mtb_telephone.Text;
                string nodid = CreerNoid();
                int tp1 = 0;
                int tp2 = 0;
                int intra = 0;
                int final = 0;

            if (action == "ajout")
            {


                using (FileStream fs = new FileStream("Eleve.Dta", FileMode.Append, FileAccess.Write))
                {
                    using (BinaryWriter bw = new BinaryWriter(fs))
                    {
                        bw.Write(codePermanent);
                        bw.Write(nom);
                        bw.Write(prenom);
                        bw.Write(sexe);
                        bw.Write(dateNaissance);
                        bw.Write(adresse);
                        bw.Write(ville);
                        bw.Write(codePostal);
                        bw.Write(telephone);
                        bw.Write(nodid);
                        bw.Write(intra);
                        bw.Write(final);
                        bw.Write(tp1);
                        bw.Write(tp2);

                    }
                }
                MessageBox.Show($"Inscription de {prenom.TrimEnd()} {nom.TrimEnd()} réussie.");
                ClearGroup(gb_inscription);
                IdleMode();
                GetEtudiant(pos);
            }

            if(action == "modif")
            {
                intra = (int)nud_tp1.Value;
                final = (int)nud_tp2.Value;
                tp1 = (int)nud_intra.Value;
                tp2 = (int)nud_final.Value;


                using (FileStream fs = new FileStream("Eleve.Dta", FileMode.Open, FileAccess.Write))
                {
                    using (BinaryWriter bw = new BinaryWriter(fs))
                    {
                        fs.Seek(pos * 159, SeekOrigin.Begin);
                        bw.Write(codePermanent);
                        bw.Write(nom);
                        bw.Write(prenom);
                        bw.Write(sexe);
                        bw.Write(dateNaissance);
                        bw.Write(adresse);
                        bw.Write(ville);
                        bw.Write(codePostal);
                        bw.Write(telephone);
                        bw.Write(nodid);
                        bw.Write(tp1);
                        bw.Write(tp2);
                        bw.Write(intra);
                        bw.Write(final);

                        MessageBox.Show($"Modification de {prenom.TrimEnd()} {nom.TrimEnd()} réussie.");
                        ClearGroup(gb_inscription);
                        GetEtudiant(pos);
                        IdleMode();
                    }
                }
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            ClearGroup(gb_inscription);
            GetEtudiant(pos);
            IdleMode();
        }

        //Je dois incrementer le noid ????? ___________________________________________________________________
        public string CreerNoid()
        {   
            
            bool existant = false;
            if (tb_nom.Text.Length > 2 && tb_prenom.Text.Length > 1)
            {
                string lettresNom = tb_nom.Text.Substring(0, 3);
                string lettrePrenom = tb_prenom.Text.Substring(0, 1);
                string noIdACreer = lettresNom.ToUpper() + lettrePrenom.ToUpper() + 1;
                existant = Find(noIdACreer);
             if(existant)
                {
                   
                    noId = lettresNom.ToUpper() + lettrePrenom.ToUpper() + compteExistant ;
                 
                }
                else
                {
                    //MessageBox.Show(" NOT foud");
                    noId = lettresNom.ToUpper() + lettrePrenom.ToUpper() + 1;
                }
            }
            compteExistant = 1;
            return noId;
            
        }

        public void GetEtudiant(int pos)
        {
            try
            {
                using (FileStream fs = new FileStream("Eleve.Dta", FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        nbEleves = (int)fs.Length / longeur;
                        lb_positionEleves.Text = $"Élève {pos+1} sur {nbEleves.ToString()}";
                        fs.Seek(pos * 159, SeekOrigin.Begin);
                        tb_codePermanent.Text = br.ReadString();
                        tb_nom.Text = br.ReadString().TrimEnd();
                        tb_prenom.Text = br.ReadString().TrimEnd();
                        char sexe = br.ReadChar();
                        if (sexe == 'M')
                        {
                            rb_masculin.Checked = true;
                        }
                        else
                        {
                            rb_feminin.Checked = true;
                        }

                        tb_dateNaissance.Text = br.ReadString();
                        tb_adresse.Text = br.ReadString().TrimEnd();
                        tb_ville.Text = br.ReadString().TrimEnd();
                        tb_codePostal.Text = br.ReadString();
                        mtb_telephone.Text = br.ReadString();
                        lb_noidAttribue.Text = br.ReadString();
                        nud_tp1.Value = br.ReadInt32();
                        nud_tp2.Value = br.ReadInt32();
                        nud_intra.Value = br.ReadInt32();
                        nud_final.Value = br.ReadInt32();



                    }
                }
            }
            catch (Exception)
            {

                
            }
        }

        private void btn_recherche_Click(object sender, EventArgs e)
        {
            action = "rechercheEleve";
            bool noidFound, nomFound;
            if(tb_rNoid.Text != "")
            {
            noidFound = Find(tb_rNoid.Text);
                if (noidFound) {
                    MessageBox.Show("trouve");
                        } else {
                    MessageBox.Show(" non trouve");
                }
            }

            if (tb_rNom.Text != "" && tb_rPrenom.Text != "")
            {
                nomFound = Find(tb_rNom.Text, tb_rPrenom.Text);
                if (nomFound)
                {
                    MessageBox.Show("trouve");
                }
                else
                {
                    MessageBox.Show(" non trouve");
                }
            }


        }


        public bool Find(string noid)
        {
            bool trouve = false;

            try
            {
                using (FileStream fs = new FileStream("Eleve.Dta", FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        for (; ; )
                        {
                            if (br.PeekChar() == -1) break;
                            string codePermanent = br.ReadString();
                            string nom = br.ReadString();
                            string prenom = br.ReadString();
                            char sexe = br.ReadChar();
                            string dateNaissance = br.ReadString();
                            string adresse = br.ReadString();
                            string ville = br.ReadString();
                            string codePostal =br.ReadString();
                            string telephone = br.ReadString();
                            string noId = br.ReadString();
                            int tp1 = br.ReadInt32();
                            int tp2 =  br.ReadInt32();
                            int intra = br.ReadInt32();
                            int final = br.ReadInt32();
                            if (noid == noId && action == "rechercheEleve")
                            {

                                tb_codePermanent.Text = codePermanent;
                                tb_nom.Text = nom.TrimEnd();
                                tb_prenom.Text = prenom.TrimEnd();
                                if (sexe == 'M')
                                {
                                    rb_masculin.Checked = true;
                                }
                                else
                                {
                                    rb_feminin.Checked = true;
                                }

                                tb_dateNaissance.Text = dateNaissance;
                                tb_adresse.Text = adresse.TrimEnd();
                                tb_ville.Text = ville.TrimEnd();
                                tb_codePostal.Text = codePostal;
                                mtb_telephone.Text = telephone;
                                lb_noidAttribue.Text = noid;
                                nud_tp1.Value = tp1;
                                nud_tp2.Value = tp2;
                                nud_intra.Value = intra;
                                nud_final.Value = final;
                                trouve = true;

                            }
                            if (noid.Substring(0, 4) == noId.Substring(0, 4))
                            {
                                trouve = true;
                                compteExistant++;
                               
                            }

                        }
                    }
                }


                return trouve;
            }catch(Exception e)
            {
                return trouve;
            }
        }
     

        public bool Find(string name,string firstname)

        {
            
            bool trouve = false;


            using (FileStream fs = new FileStream("Eleve.Dta", FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    for (; ; )
                    {
                        if (br.PeekChar() == -1) break;
                        string codePermanent = br.ReadString();
                        string nom = br.ReadString().TrimEnd();
                        string prenom = br.ReadString().TrimEnd();
                        char sexe = br.ReadChar();
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

                        if (name == nom && firstname == prenom)
                        {
                            tb_codePermanent.Text = codePermanent;
                            tb_nom.Text = nom.TrimEnd();
                            tb_prenom.Text = prenom.TrimEnd();
                            tb_dateNaissance.Text = dateNaissance;
                            tb_adresse.Text = adresse.TrimEnd();
                            tb_ville.Text = ville.TrimEnd();
                            tb_codePostal.Text = codePostal;
                            mtb_telephone.Text = telephone;
                            lb_noidAttribue.Text = noId;
                            nud_tp1.Value = tp1;
                            nud_tp2.Value = tp2;
                            nud_intra.Value = intra;
                            nud_final.Value = final;
                            trouve = true;
                            break;
                        }
                    }
                }
            }
         
            return trouve;

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            gb_recherche.Visible = true;

            EditMode();
            GetEtudiant(pos);
        }


        private void btn_premier_Click(object sender, EventArgs e)
        {
            pos = 0;
            GetEtudiant(pos);
        }

        private void btn_avancer_Click(object sender, EventArgs e)
        {
            
            
                if(pos < nbEleves - 1) {
                pos++;
                GetEtudiant(pos);
            }
                

        }

        private void btn_reculer_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos--;
                GetEtudiant(pos);
            }

        }

        private void btn_dernier_Click(object sender, EventArgs e)
        {
            pos = nbEleves - 1;
            GetEtudiant(pos); 

        }
        private void ClearGroup(GroupBox group)
        {
            foreach (Control ctr in group.Controls)
            {
                if (ctr is TextBox  || ctr is MaskedTextBox)
                {
                    ctr.Text = "";
                }
            }
                lb_noidAttribue.Text   = "";
            rb_feminin.Checked = false;
            rb_masculin.Checked = false;
        }
        private void EditMode()
        {
            action = "modif";
            tb_adresse.Enabled = true;
            tb_ville.Enabled = true;
            tb_codePostal.Enabled = true;
            mtb_telephone.Enabled = true;
            gb_recherche.Enabled = true;
            btn_nouveau.Enabled = false;
            btn_ok.Enabled = true;
            btn_annuler.Enabled = true;
            btn_modifier.Enabled = false;
            gb_notes.Visible = true;
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {   
                    string toDel = lb_noidAttribue.Text;
            var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet élève?", "SUPPRESSION",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (FileStream fs = new FileStream("Eleve.Dta", FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        fs.Seek(0,SeekOrigin.Begin);

                        for (; ; )
                        {
                            if (br.PeekChar() == -1) break;
                            string codePermanent = br.ReadString();
                            string nom = br.ReadString().TrimEnd();
                            string prenom = br.ReadString().TrimEnd();
                            char sexe = br.ReadChar();
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

                            if (toDel != noId)
                            {
                                using (FileStream fs2 = new FileStream("Eleve2.Dta", FileMode.Append, FileAccess.Write))
                                {
                                    using (BinaryWriter bw = new BinaryWriter(fs2))
                                    {
                                        bw.Write(codePermanent.PadRight(13));
                                        bw.Write(nom.PadRight(16));
                                        bw.Write(prenom.PadRight(16));
                                        bw.Write(sexe);
                                        bw.Write(dateNaissance);
                                        bw.Write(adresse.PadRight(31));
                                        bw.Write(ville.PadRight(21));
                                        bw.Write(codePostal);
                                        bw.Write(telephone);
                                        bw.Write(noId);
                                        bw.Write(tp1);
                                        bw.Write(tp2);
                                        bw.Write(intra);
                                        bw.Write(final);

                                    }
                                }
                            }

                        }
                    }
                }
                try
                {
                    File.Delete("Eleve.Dta");
                    File.Move("Eleve2.Dta", "Eleve.Dta");
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                pos--;

                GetEtudiant(pos);
            }

        }
    }
}
