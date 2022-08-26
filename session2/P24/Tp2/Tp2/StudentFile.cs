
namespace Tp2
{
    public class StudentFile
    {
        const int longeur = 175;
        public Etudiant ReadEtudiant(int pos)
        {
            Etudiant etudiant = new Etudiant();
            using (FileStream fs = new("Eleve.Dta", FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new(fs, System.Text.Encoding.Latin1))
                {
                    var nbEleves = (int)fs.Length / longeur;
                    if (nbEleves > 0)
                    {
                        fs.Seek(pos * longeur, SeekOrigin.Begin);
                        etudiant.CodePermanent = br.ReadString();
                        etudiant.Nom = br.ReadString().TrimEnd();
                        etudiant.Prenom = br.ReadString().TrimEnd();
                        etudiant.Sexe = br.ReadChar();
                        etudiant.DateNaissance = br.ReadString();
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
        public Etudiant FindStudent()
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
                                etudiant.DateNaissance = br.ReadString();
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
            }
            return etudiant;
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



        public void DeleteStudent()
        {

        }



    }
}
