﻿
namespace Tp2
{
    public partial class Inscription : Form
    {
        private StudentFile _studentFile;
        int pos = 0;
        public int nbEleves = 0;
        public string noId = "";
        int compteExistant = 1;
        public string action = "";
        public Inscription(StudentFile studentFile)
        {
            _studentFile = studentFile;
            InitializeComponent();
            GetEtudiant(pos);
        }
        // MODES INTERFACE _____________________________________________________________________________
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
            gb_recherche.Enabled = false;
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
            pan_nav.Enabled = true;
            gb_recherche.Enabled = true;
        }
        private void EditMode()
        {
            action = "modif";
            tb_adresse.Enabled = true;
            tb_ville.Enabled = true;
            mtb_codePostal.Enabled = true;
            mtb_telephone.Enabled = true;
            gb_recherche.Enabled = true;
            btn_nouveau.Enabled = false;
            btn_ok.Enabled = true;
            btn_annuler.Enabled = true;
            btn_modifier.Enabled = false;
            gb_notes.Visible = true;
        }

        //CREATION MODIFICATION ___________________________________________________________________________
        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            AddMode();
            ClearGroup(gb_inscription);
            pan_nav.Enabled = false;
            btn_nouveau.Enabled = false;

        }
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            EditMode();
            GetEtudiant(pos);
            pan_nav.Enabled = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            var etudiant = new Etudiant();
            etudiant.CodePermanent = tb_codePermanent.Text.PadRight(13).ToUpper();
            etudiant.Nom = tb_nom.Text.PadRight(16).ToLower();
            etudiant.Prenom = tb_prenom.Text.PadRight(16).ToLower();
            etudiant.Sexe = rb_feminin.Checked ? 'F' : 'M';
            etudiant.DateNaissance = tb_dateNaissance.Text;
            etudiant.Adresse = tb_adresse.Text.PadRight(31);
            etudiant.Ville = tb_ville.Text.PadRight(21);
            etudiant.CodePostal = mtb_codePostal.Text;
            etudiant.Telephone = mtb_telephone.Text;
            etudiant.Tp1 = 0;
            etudiant.Tp2 = 0;
            etudiant.Intra = 0;
            etudiant.Final = 0;

            bool ready = Valider();

            if (action == "ajout" && ready == true)
            {
                etudiant.NoId = CreerNoid();
                _studentFile.AddStudent(etudiant);
                MessageBox.Show($"Inscription de {etudiant.Prenom.TrimEnd()} {etudiant.Nom.TrimEnd()} réussie.");
                ClearGroup(gb_inscription);
                IdleMode();
                GetEtudiant(pos);
            }


            if (action == "modif")
            {
                etudiant.Tp1 = (double)nud_tp1.Value;
                etudiant.Tp2 = (double)nud_tp2.Value;
                etudiant.Intra = (double)nud_intra.Value;
                etudiant.NoId = lb_noidAttribue.Text;
                etudiant.Final = (double)nud_final.Value;
                _studentFile.EditStudent(etudiant, pos);

                MessageBox.Show($"Modification de {etudiant.Prenom.TrimEnd()} {etudiant.Nom.TrimEnd()} réussie.");
                ClearGroup(gb_inscription);
                IdleMode();
            }
        }



        private void btn_annuler_Click(object sender, EventArgs e)
        {
            ClearGroup(gb_inscription);
            GetEtudiant(pos);
            IdleMode();
            ResetError();

        }

        //Creation du ID ___________________________________________________________________
        public string CreerNoid()
        {

            bool existant = false;
            if (tb_nom.Text.Length > 2 && tb_prenom.Text.Length > 1)
            {
                string lettresNom = tb_nom.Text.Substring(0, 3);
                string lettrePrenom = tb_prenom.Text.Substring(0, 1);
                string noIdACreer = lettresNom.ToUpper() + lettrePrenom.ToUpper() + 1;
                existant = Find(noIdACreer);
                if (existant)
                {
                    noId = lettresNom.ToUpper() + lettrePrenom.ToUpper() + compteExistant;
                }
                else
                {
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
                var etudiant = _studentFile.ReadEtudiant(pos);
                if (nbEleves > 0)
                {
                    lb_positionEleves.Text = "";
                }
                lb_positionEleves.Text = $"Élève {pos + 1} sur {nbEleves.ToString()}";

                tb_codePermanent.Text = etudiant.CodePermanent;
                tb_nom.Text = etudiant.Nom;
                tb_prenom.Text = etudiant.Prenom;
                char sexe = etudiant.Sexe;
                if (sexe == 'M')
                {
                    rb_masculin.Checked = true;
                }
                else
                {
                    rb_feminin.Checked = true;
                }
                tb_dateNaissance.Text = etudiant.DateNaissance;
                tb_adresse.Text = etudiant.Adresse;
                tb_ville.Text = etudiant.Ville;
                mtb_codePostal.Text = etudiant.CodePostal;
                mtb_telephone.Text = etudiant.Telephone;
                lb_noidAttribue.Text = etudiant.NoId;
                nud_tp1.Value = (decimal)etudiant.Tp1;
                nud_tp2.Value = (decimal)etudiant.Tp2;
                nud_intra.Value = (decimal)etudiant.Intra;
                nud_final.Value = (decimal)etudiant.Final;


            }
            catch (FileNotFoundException)
            {
                btn_supprimer.Enabled = false;
            }
            catch (Exception)
            {

            }
        }

        private void btn_recherche_Click(object sender, EventArgs e)
        {
            action = "rechercheEleve";
            bool noidFound, nomFound;
            if (tb_rNoid.Text != "")
            {
                noidFound = Find(tb_rNoid.Text.ToUpper());
                if (noidFound)
                {
                    MessageBox.Show("Étudiant(e) trouvé(e).");
                    ClearGroup(gb_recherche);
                    GetEtudiant(pos);
                }
                else
                {
                    MessageBox.Show("Étudiant(e) inexistant(e)");
                }
            }

            if (tb_rNom.Text != "" && tb_rPrenom.Text != "")
            {
                nomFound = Find(tb_rNom.Text.ToLower(), tb_rPrenom.Text.ToLower());
                if (nomFound)
                {
                    MessageBox.Show("Étudiant(e) trouvé(e).");
                    ClearGroup(gb_recherche);
                    GetEtudiant(pos);
                }
                else
                {
                    MessageBox.Show("Étudiant(e) inexistant(e)");
                }
            }
        }

        public bool Find(string noidRecherche)
        {
            bool trouve = false;
            try
            {
                using (FileStream fs = new("Eleve.Dta", FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new(fs, System.Text.Encoding.Latin1))
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
                            string codePostal = br.ReadString();
                            string telephone = br.ReadString();
                            string noId = br.ReadString();
                            double tp1 = br.ReadDouble();
                            double tp2 = br.ReadDouble();
                            double intra = br.ReadDouble();
                            double final = br.ReadDouble();
                            if (noidRecherche == noId && action == "rechercheEleve")
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
                                mtb_codePostal.Text = codePostal;
                                mtb_telephone.Text = telephone;
                                lb_noidAttribue.Text = noId;
                                nud_tp1.Value = (decimal)tp1;
                                nud_tp2.Value = (decimal)tp2;
                                nud_intra.Value = (decimal)intra;
                                nud_final.Value = (decimal)final;
                                trouve = true;
                            }
                            if (noidRecherche.Substring(0, 4) == noId.Substring(0, 4))
                            {
                                trouve = true;
                                pos = (int)fs.Position / 175 - 1;
                                compteExistant++;

                            }
                        }
                    }
                }
                return trouve;
            }
            catch (Exception e)
            {
                return trouve;
            }
        }


        public bool Find(string name, string firstname)

        {
            bool trouve = false;
            using (FileStream fs = new("Eleve.Dta", FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new(fs, System.Text.Encoding.Latin1))
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
                        double tp1 = br.ReadDouble();
                        double tp2 = br.ReadDouble();
                        double intra = br.ReadDouble();
                        double final = br.ReadDouble();

                        if (name == nom && firstname == prenom)
                        {
                            tb_codePermanent.Text = codePermanent;
                            tb_nom.Text = nom.TrimEnd();
                            tb_prenom.Text = prenom.TrimEnd();
                            tb_dateNaissance.Text = dateNaissance;
                            tb_adresse.Text = adresse.TrimEnd();
                            tb_ville.Text = ville.TrimEnd();
                            mtb_codePostal.Text = codePostal;
                            mtb_telephone.Text = telephone;
                            lb_noidAttribue.Text = noId;
                            nud_tp1.Value = (decimal)tp1;
                            nud_tp2.Value = (decimal)tp2;
                            nud_intra.Value = (decimal)intra;
                            nud_final.Value = (decimal)final;
                            trouve = true;
                            pos = (int)fs.Position / 175 - 1;
                            break;
                        }
                    }
                }
            }
            return trouve;
        }
        private void btn_premier_Click(object sender, EventArgs e)
        {
            pos = 0;
            GetEtudiant(pos);
        }

        private void btn_avancer_Click(object sender, EventArgs e)
        {
            if (pos < nbEleves - 1)
            {
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
        public void ClearGroup(GroupBox group)
        {
            foreach (Control ctr in group.Controls)
            {
                if (ctr is TextBox || ctr is MaskedTextBox)
                {
                    ctr.Text = "";
                }
            }
            lb_noidAttribue.Text = "";
            rb_feminin.Checked = false;
            rb_masculin.Checked = false;

        }


        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            string toDel = lb_noidAttribue.Text;
            var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet élève?", "SUPPRESSION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (FileStream fs = new("Eleve.Dta", FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new(fs, System.Text.Encoding.Latin1))
                    {
                        fs.Seek(0, SeekOrigin.Begin);

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
                            double tp1 = br.ReadDouble();
                            double tp2 = br.ReadDouble();
                            double intra = br.ReadDouble();
                            double final = br.ReadDouble();

                            if (toDel != noId)
                            {
                                using (FileStream fs2 = new("Eleve2.Dta", FileMode.Append, FileAccess.Write))
                                {
                                    using (BinaryWriter bw = new(fs2, System.Text.Encoding.Latin1))
                                    {
                                        bw.Write(codePermanent.PadRight(13).ToUpper());
                                        bw.Write(nom.PadRight(16).ToLower());
                                        bw.Write(prenom.PadRight(16).ToLower());
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
                catch (Exception)
                {

                }
                if (pos > 0)
                {
                    pos--;
                    ClearGroup(gb_inscription);
                }
                GetEtudiant(pos);
            }
        }
        // VALIDATION _______________________________________________________________________________________________________________
        private bool Valider()
        {
            bool valide = true;
            foreach (Control ct in gb_inscription.Controls)
            {
                if (ct is TextBox && ct.Text == "")
                {
                    errorProvider1.SetError(ct, "Ce champ est requis");
                    valide = false;
                }
                //else if (ct is MaskedTextBox && ct.Text.Length != 12 )
                //{
                //    errorProvider1.SetError(ct, "Ce champ est requis");
                //    valide = false;
                //}
                else
                {
                    errorProvider1.SetError(ct, "");
                }

            }
            if (rb_feminin.Checked == false && rb_masculin.Checked == false)
            {
                errorProvider1.SetError(rb_masculin, "Vous devez cocher un des deux choix");
                valide = false;
            }

            if (tb_codePermanent.Text.Length != 12 || tb_dateNaissance.Text.Length != 10 || mtb_telephone.Text.Length != 14)
            {
                valide = false;
            }
            return valide;
        }

        private void ResetError()
        {
            foreach (Control ct in gb_inscription.Controls)
                errorProvider1.SetError(ct, "");
        }

        private void tb_codePermanent_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tb_codePermanent.Text.Length != 12 && tb_codePermanent.Enabled == true)
            {
                errorProvider1.SetError(tb_codePermanent, "Le code permanent doit contenir 12 caractères");
                tb_codePermanent.Focus();
            }
            else
            {
                errorProvider1.SetError(tb_codePermanent, "");
            }
        }

        private void tb_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void tb_prenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else e.Handled = true;

        }
        private void tb_dateNaissance_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tb_dateNaissance.Text.Length != 10)
            {
                errorProvider1.SetError(tb_dateNaissance, "Entrez la date en format 00/00/0000");
                tb_dateNaissance.Focus();
            }
        }

        private void mtb_codePostal_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (mtb_codePostal.Text.Length != 7)
            {
                errorProvider1.SetError(mtb_codePostal, "Entrez le code postal en format A0A-0A0");
                mtb_codePostal.Focus();
            }
        }

        private void mtb_telephone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (mtb_telephone.Text.Length != 14)
            {
                errorProvider1.SetError(mtb_telephone, "Entrez le numéro de téléphone  postal en format 000-000-0000");
                mtb_telephone.Focus();
            }
        }

        // Annule tout si je change de page
        private void Inscription_Deactivate(object sender, EventArgs e)
        {
            ClearGroup(gb_inscription);
            GetEtudiant(pos);
            IdleMode();
        }

        private void tb_dateNaissance_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                tb_dateNaissance.Select(0, 0);
            });


        }

        private void tb_ville_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) || e.KeyChar == '-' || e.KeyChar == 'é' || e.KeyChar == ' ')
                {
                    e.Handled = false;
                }
                else e.Handled = true;

            }
        }
    }
}
