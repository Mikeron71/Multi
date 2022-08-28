
namespace Tp2
{
    public class StudentFile
    {
        const int longeur = 175;
        public int nbEleves = 0;
        public Etudiant ReadStudent(int pos)
        {
            Etudiant etudiant = new Etudiant();
            using (FileStream fs = new("Eleve.Dta", FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new(fs, System.Text.Encoding.Latin1))
                {
                    nbEleves = (int)fs.Length / longeur;
                    if (nbEleves > 0)
                    {
                        fs.Seek(pos * longeur, SeekOrigin.Begin);
                        etudiant.CodePermanent = br.ReadString();
                        etudiant.Nom = br.ReadString().TrimEnd();
                        etudiant.Prenom = br.ReadString().TrimEnd();
                        etudiant.Sexe = br.ReadChar();
                        etudiant.DateNaissance = br.ReadString().TrimEnd();
                        etudiant.Adresse = br.ReadString().TrimEnd();
                        etudiant.Ville = br.ReadString().TrimEnd();
                        etudiant.CodePostal = br.ReadString();
                        etudiant.Telephone = br.ReadString();
                        etudiant.NoId = br.ReadString();
                        etudiant.Tp1 = br.ReadDouble();
                        etudiant.Tp2 = br.ReadDouble();
                        etudiant.Intra = br.ReadDouble();
                        etudiant.Final = br.ReadDouble();
                    }
                }
            }
            return etudiant;
        }
        public int FindStudent(string Idcherche, bool modecompte)
        {
            bool found = false;
            Etudiant etudiant = new Etudiant();
            try
            {
                using (FileStream fs = new("Eleve.Dta", FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new(fs, System.Text.Encoding.Latin1))
                    {
                        var nbEleves = (int)fs.Length / longeur;
                        if (nbEleves > 0)
                            for (; ; )
                            {
                                if (br.PeekChar() == -1) break;
                                {

                                    etudiant.CodePermanent = br.ReadString();
                                    etudiant.Nom = br.ReadString().TrimEnd();
                                    etudiant.Prenom = br.ReadString().TrimEnd();
                                    etudiant.Sexe = br.ReadChar();
                                    etudiant.DateNaissance = br.ReadString().TrimEnd();
                                    etudiant.Adresse = br.ReadString().TrimEnd();
                                    etudiant.Ville = br.ReadString().TrimEnd();
                                    etudiant.CodePostal = br.ReadString();
                                    etudiant.Telephone = br.ReadString();
                                    etudiant.NoId = br.ReadString();
                                    etudiant.Tp1 = br.ReadDouble();
                                    etudiant.Tp2 = br.ReadDouble();
                                    etudiant.Intra = br.ReadDouble();
                                    etudiant.Final = br.ReadDouble();
                                }
                                if (Idcherche == etudiant.NoId && modecompte == false)
                                {
                                    int positionTrouvee = (int)fs.Position / 175 - 1;

                                    return positionTrouvee;
                                }
                                else if (Idcherche == etudiant.NoId && modecompte == true)
                                {
                                    frmAccueil.frmInscription.compteExistant++;
                                    found = true;

                                }
                            }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Pas d'etudiants");
            }
            if (!found)
                return -1;
            else
            {
                return 1;
            }
        }

        public int FindStudent(string nomrecherche, string prenomrecherche)
        {
            Etudiant etudiant = new Etudiant();
            using (FileStream fs = new("Eleve.Dta", FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new(fs, System.Text.Encoding.Latin1))
                {
                    var nbEleves = (int)fs.Length / longeur;
                    if (nbEleves > 0)
                        for (; ; )
                        {
                            if (br.PeekChar() == -1) break;
                            {

                                etudiant.CodePermanent = br.ReadString();
                                etudiant.Nom = br.ReadString().TrimEnd();
                                etudiant.Prenom = br.ReadString().TrimEnd();
                                etudiant.Sexe = br.ReadChar();
                                etudiant.DateNaissance = br.ReadString().TrimEnd();
                                etudiant.Adresse = br.ReadString().TrimEnd();
                                etudiant.Ville = br.ReadString().TrimEnd();
                                etudiant.CodePostal = br.ReadString();
                                etudiant.Telephone = br.ReadString();
                                etudiant.NoId = br.ReadString();
                                etudiant.Tp1 = br.ReadDouble();
                                etudiant.Tp2 = br.ReadDouble();
                                etudiant.Intra = br.ReadDouble();
                                etudiant.Final = br.ReadDouble();
                            }
                            if (nomrecherche == etudiant.Nom && prenomrecherche == etudiant.Prenom)
                            {
                                int positionTrouvee = (int)fs.Position / 175 - 1;
                                return positionTrouvee;
                            }
                        }
                }
            }
            return -1;
        }
        public void AddStudent(Etudiant etudiant)
        {
            using (FileStream fs = new("Eleve.Dta", FileMode.Append, FileAccess.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fs, System.Text.Encoding.Latin1))
                {
                    bw.Write(etudiant.CodePermanent);
                    bw.Write(etudiant.Nom);
                    bw.Write(etudiant.Prenom);
                    bw.Write(etudiant.Sexe);
                    bw.Write(etudiant.DateNaissance);
                    bw.Write(etudiant.Adresse);
                    bw.Write(etudiant.Ville);
                    bw.Write(etudiant.CodePostal);
                    bw.Write(etudiant.Telephone);
                    bw.Write(etudiant.NoId);
                    bw.Write(etudiant.Tp1);
                    bw.Write(etudiant.Tp2);
                    bw.Write(etudiant.Intra);
                    bw.Write(etudiant.Final);
                }
            }
        }

        public void EditStudent(Etudiant etudiant, int pos)
        {
            using (FileStream fs = new("Eleve.Dta", FileMode.Open, FileAccess.Write))
            {
                using (BinaryWriter bw = new(fs, System.Text.Encoding.Latin1))
                {
                    fs.Seek(pos * longeur, SeekOrigin.Begin);
                    bw.Write(etudiant.CodePermanent);
                    bw.Write(etudiant.Nom);
                    bw.Write(etudiant.Prenom);
                    bw.Write(etudiant.Sexe);
                    bw.Write(etudiant.DateNaissance);
                    bw.Write(etudiant.Adresse);
                    bw.Write(etudiant.Ville);
                    bw.Write(etudiant.CodePostal);
                    bw.Write(etudiant.Telephone);
                    bw.Write(etudiant.NoId);
                    bw.Write(etudiant.Tp1);
                    bw.Write(etudiant.Tp2);
                    bw.Write(etudiant.Intra);
                    bw.Write(etudiant.Final);

                }
            }
        }

        public void DeleteStudent(string idToDelete)
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
                        string dateNaissance = br.ReadString().TrimEnd();
                        string adresse = br.ReadString();
                        string ville = br.ReadString();
                        string codePostal = br.ReadString();
                        string telephone = br.ReadString();
                        string noId = br.ReadString();
                        double tp1 = br.ReadDouble();
                        double tp2 = br.ReadDouble();
                        double intra = br.ReadDouble();
                        double final = br.ReadDouble();

                        if (idToDelete != noId)
                        {
                            using (FileStream fs2 = new("Eleve2.Dta", FileMode.Append, FileAccess.Write))
                            {
                                using (BinaryWriter bw = new(fs2, System.Text.Encoding.Latin1))
                                {
                                    bw.Write(codePermanent.PadRight(13).ToUpper());
                                    bw.Write(nom.PadRight(16).ToLower());
                                    bw.Write(prenom.PadRight(16).ToLower());
                                    bw.Write(sexe);
                                    bw.Write(dateNaissance.PadRight(10));
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
                MessageBox.Show("Erreur!");
            }
        }
    }
}
