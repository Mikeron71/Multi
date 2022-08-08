namespace Tp2
{
    partial class Inscription
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
            this.components = new System.ComponentModel.Container();
            this.btn_nouveau = new System.Windows.Forms.Button();
            this.lb_codePermanent = new System.Windows.Forms.Label();
            this.lb_nom = new System.Windows.Forms.Label();
            this.lb_Prenom = new System.Windows.Forms.Label();
            this.lb_sexe = new System.Windows.Forms.Label();
            this.lb_dateNais = new System.Windows.Forms.Label();
            this.lb_adresse = new System.Windows.Forms.Label();
            this.lb_ville = new System.Windows.Forms.Label();
            this.lb_codePostal = new System.Windows.Forms.Label();
            this.lb_telephone = new System.Windows.Forms.Label();
            this.lb_noid = new System.Windows.Forms.Label();
            this.tb_codePermanent = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.rb_feminin = new System.Windows.Forms.RadioButton();
            this.rb_masculin = new System.Windows.Forms.RadioButton();
            this.tb_dateNaissance = new System.Windows.Forms.MaskedTextBox();
            this.lb_noidAttribue = new System.Windows.Forms.Label();
            this.mtb_telephone = new System.Windows.Forms.MaskedTextBox();
            this.lb_titreInscription = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.gb_inscription = new System.Windows.Forms.GroupBox();
            this.mtb_codePostal = new System.Windows.Forms.MaskedTextBox();
            this.gb_recherche = new System.Windows.Forms.GroupBox();
            this.tb_rNoid = new System.Windows.Forms.TextBox();
            this.btn_recherche = new System.Windows.Forms.Button();
            this.tb_rPrenom = new System.Windows.Forms.TextBox();
            this.tb_rNom = new System.Windows.Forms.TextBox();
            this.lb_rnoid = new System.Windows.Forms.Label();
            this.lb_rPrenom = new System.Windows.Forms.Label();
            this.lb_rNom = new System.Windows.Forms.Label();
            this.gb_notes = new System.Windows.Forms.GroupBox();
            this.nud_final = new System.Windows.Forms.NumericUpDown();
            this.nud_intra = new System.Windows.Forms.NumericUpDown();
            this.nud_tp2 = new System.Windows.Forms.NumericUpDown();
            this.nud_tp1 = new System.Windows.Forms.NumericUpDown();
            this.lb_final = new System.Windows.Forms.Label();
            this.lb_intra = new System.Windows.Forms.Label();
            this.lb_tp2 = new System.Windows.Forms.Label();
            this.lb_tp1 = new System.Windows.Forms.Label();
            this.btn_reculer = new System.Windows.Forms.Button();
            this.btn_premier = new System.Windows.Forms.Button();
            this.btn_avancer = new System.Windows.Forms.Button();
            this.btn_dernier = new System.Windows.Forms.Button();
            this.pan_nav = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lb_positionEleves = new System.Windows.Forms.Label();
            this.gb_inscription.SuspendLayout();
            this.gb_recherche.SuspendLayout();
            this.gb_notes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_final)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_intra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tp1)).BeginInit();
            this.pan_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.Location = new System.Drawing.Point(896, 66);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(142, 81);
            this.btn_nouveau.TabIndex = 1;
            this.btn_nouveau.Text = "Nouveau";
            this.btn_nouveau.UseVisualStyleBackColor = true;
            this.btn_nouveau.Click += new System.EventHandler(this.btn_nouveau_Click);
            // 
            // lb_codePermanent
            // 
            this.lb_codePermanent.AutoSize = true;
            this.lb_codePermanent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_codePermanent.Location = new System.Drawing.Point(34, 27);
            this.lb_codePermanent.Name = "lb_codePermanent";
            this.lb_codePermanent.Size = new System.Drawing.Size(128, 21);
            this.lb_codePermanent.TabIndex = 2;
            this.lb_codePermanent.Text = "Code Permanent:";
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_nom.Location = new System.Drawing.Point(31, 91);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(48, 21);
            this.lb_nom.TabIndex = 3;
            this.lb_nom.Text = "Nom:";
            // 
            // lb_Prenom
            // 
            this.lb_Prenom.AutoSize = true;
            this.lb_Prenom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Prenom.Location = new System.Drawing.Point(34, 153);
            this.lb_Prenom.Name = "lb_Prenom";
            this.lb_Prenom.Size = new System.Drawing.Size(68, 21);
            this.lb_Prenom.TabIndex = 4;
            this.lb_Prenom.Text = "Prenom:";
            // 
            // lb_sexe
            // 
            this.lb_sexe.AutoSize = true;
            this.lb_sexe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_sexe.Location = new System.Drawing.Point(34, 246);
            this.lb_sexe.Name = "lb_sexe";
            this.lb_sexe.Size = new System.Drawing.Size(45, 21);
            this.lb_sexe.TabIndex = 5;
            this.lb_sexe.Text = "Sexe:";
            // 
            // lb_dateNais
            // 
            this.lb_dateNais.AutoSize = true;
            this.lb_dateNais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_dateNais.Location = new System.Drawing.Point(34, 294);
            this.lb_dateNais.Name = "lb_dateNais";
            this.lb_dateNais.Size = new System.Drawing.Size(137, 21);
            this.lb_dateNais.TabIndex = 6;
            this.lb_dateNais.Text = "Date de naissance:";
            // 
            // lb_adresse
            // 
            this.lb_adresse.AutoSize = true;
            this.lb_adresse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_adresse.Location = new System.Drawing.Point(34, 335);
            this.lb_adresse.Name = "lb_adresse";
            this.lb_adresse.Size = new System.Drawing.Size(68, 21);
            this.lb_adresse.TabIndex = 7;
            this.lb_adresse.Text = "Adresse:";
            // 
            // lb_ville
            // 
            this.lb_ville.AutoSize = true;
            this.lb_ville.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ville.Location = new System.Drawing.Point(34, 379);
            this.lb_ville.Name = "lb_ville";
            this.lb_ville.Size = new System.Drawing.Size(43, 21);
            this.lb_ville.TabIndex = 8;
            this.lb_ville.Text = "Ville:";
            // 
            // lb_codePostal
            // 
            this.lb_codePostal.AutoSize = true;
            this.lb_codePostal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_codePostal.Location = new System.Drawing.Point(34, 429);
            this.lb_codePostal.Name = "lb_codePostal";
            this.lb_codePostal.Size = new System.Drawing.Size(103, 21);
            this.lb_codePostal.TabIndex = 9;
            this.lb_codePostal.Text = "Code postale:";
            // 
            // lb_telephone
            // 
            this.lb_telephone.AutoSize = true;
            this.lb_telephone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_telephone.Location = new System.Drawing.Point(34, 479);
            this.lb_telephone.Name = "lb_telephone";
            this.lb_telephone.Size = new System.Drawing.Size(83, 21);
            this.lb_telephone.TabIndex = 10;
            this.lb_telephone.Text = "Téléphone:";
            // 
            // lb_noid
            // 
            this.lb_noid.AutoSize = true;
            this.lb_noid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_noid.Location = new System.Drawing.Point(34, 203);
            this.lb_noid.Name = "lb_noid";
            this.lb_noid.Size = new System.Drawing.Size(187, 21);
            this.lb_noid.TabIndex = 11;
            this.lb_noid.Text = "Numéro d\'indentification:";
            // 
            // tb_codePermanent
            // 
            this.tb_codePermanent.Enabled = false;
            this.tb_codePermanent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_codePermanent.Location = new System.Drawing.Point(256, 27);
            this.tb_codePermanent.MaxLength = 12;
            this.tb_codePermanent.Name = "tb_codePermanent";
            this.tb_codePermanent.Size = new System.Drawing.Size(297, 29);
            this.tb_codePermanent.TabIndex = 12;
            this.tb_codePermanent.Validating += new System.ComponentModel.CancelEventHandler(this.tb_codePermanent_Validating);
            // 
            // tb_nom
            // 
            this.tb_nom.Enabled = false;
            this.tb_nom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_nom.Location = new System.Drawing.Point(256, 91);
            this.tb_nom.MaxLength = 15;
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(297, 29);
            this.tb_nom.TabIndex = 13;
            this.tb_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nom_KeyPress);
            // 
            // tb_prenom
            // 
            this.tb_prenom.Enabled = false;
            this.tb_prenom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_prenom.Location = new System.Drawing.Point(256, 145);
            this.tb_prenom.MaxLength = 15;
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(297, 29);
            this.tb_prenom.TabIndex = 14;
            this.tb_prenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_prenom_KeyPress);
            // 
            // tb_adresse
            // 
            this.tb_adresse.Enabled = false;
            this.tb_adresse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_adresse.Location = new System.Drawing.Point(262, 330);
            this.tb_adresse.MaxLength = 30;
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(297, 29);
            this.tb_adresse.TabIndex = 15;
            // 
            // tb_ville
            // 
            this.tb_ville.Enabled = false;
            this.tb_ville.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ville.Location = new System.Drawing.Point(262, 371);
            this.tb_ville.MaxLength = 20;
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(297, 29);
            this.tb_ville.TabIndex = 16;
            // 
            // rb_feminin
            // 
            this.rb_feminin.AutoSize = true;
            this.rb_feminin.Enabled = false;
            this.rb_feminin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_feminin.Location = new System.Drawing.Point(278, 244);
            this.rb_feminin.Name = "rb_feminin";
            this.rb_feminin.Size = new System.Drawing.Size(84, 25);
            this.rb_feminin.TabIndex = 18;
            this.rb_feminin.TabStop = true;
            this.rb_feminin.Text = "Feminin";
            this.rb_feminin.UseVisualStyleBackColor = true;
            // 
            // rb_masculin
            // 
            this.rb_masculin.AutoSize = true;
            this.rb_masculin.Enabled = false;
            this.rb_masculin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_masculin.Location = new System.Drawing.Point(424, 244);
            this.rb_masculin.Name = "rb_masculin";
            this.rb_masculin.Size = new System.Drawing.Size(90, 25);
            this.rb_masculin.TabIndex = 19;
            this.rb_masculin.TabStop = true;
            this.rb_masculin.Text = "Masculin";
            this.rb_masculin.UseVisualStyleBackColor = true;
            // 
            // tb_dateNaissance
            // 
            this.tb_dateNaissance.Enabled = false;
            this.tb_dateNaissance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_dateNaissance.Location = new System.Drawing.Point(262, 286);
            this.tb_dateNaissance.Mask = "00/00/0000";
            this.tb_dateNaissance.Name = "tb_dateNaissance";
            this.tb_dateNaissance.Size = new System.Drawing.Size(100, 29);
            this.tb_dateNaissance.TabIndex = 20;
            this.tb_dateNaissance.ValidatingType = typeof(System.DateTime);
            this.tb_dateNaissance.Validating += new System.ComponentModel.CancelEventHandler(this.tb_dateNaissance_Validating);
            // 
            // lb_noidAttribue
            // 
            this.lb_noidAttribue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_noidAttribue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_noidAttribue.Location = new System.Drawing.Point(256, 192);
            this.lb_noidAttribue.Name = "lb_noidAttribue";
            this.lb_noidAttribue.Size = new System.Drawing.Size(150, 32);
            this.lb_noidAttribue.TabIndex = 21;
            // 
            // mtb_telephone
            // 
            this.mtb_telephone.Enabled = false;
            this.mtb_telephone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtb_telephone.Location = new System.Drawing.Point(262, 471);
            this.mtb_telephone.Mask = "(999) 000-0000";
            this.mtb_telephone.Name = "mtb_telephone";
            this.mtb_telephone.Size = new System.Drawing.Size(123, 29);
            this.mtb_telephone.TabIndex = 22;
            this.mtb_telephone.Validating += new System.ComponentModel.CancelEventHandler(this.mtb_telephone_Validating);
            // 
            // lb_titreInscription
            // 
            this.lb_titreInscription.AutoSize = true;
            this.lb_titreInscription.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_titreInscription.Location = new System.Drawing.Point(12, 9);
            this.lb_titreInscription.Name = "lb_titreInscription";
            this.lb_titreInscription.Size = new System.Drawing.Size(225, 50);
            this.lb_titreInscription.TabIndex = 23;
            this.lb_titreInscription.Text = "Inscriptions";
            // 
            // btn_ok
            // 
            this.btn_ok.Enabled = false;
            this.btn_ok.Location = new System.Drawing.Point(896, 175);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(142, 81);
            this.btn_ok.TabIndex = 24;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Enabled = false;
            this.btn_annuler.Location = new System.Drawing.Point(896, 286);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(142, 81);
            this.btn_annuler.TabIndex = 25;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(896, 399);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(142, 81);
            this.btn_modifier.TabIndex = 26;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(896, 515);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(142, 81);
            this.btn_supprimer.TabIndex = 27;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // gb_inscription
            // 
            this.gb_inscription.Controls.Add(this.mtb_codePostal);
            this.gb_inscription.Controls.Add(this.tb_codePermanent);
            this.gb_inscription.Controls.Add(this.tb_nom);
            this.gb_inscription.Controls.Add(this.tb_prenom);
            this.gb_inscription.Controls.Add(this.rb_feminin);
            this.gb_inscription.Controls.Add(this.rb_masculin);
            this.gb_inscription.Controls.Add(this.lb_noidAttribue);
            this.gb_inscription.Controls.Add(this.mtb_telephone);
            this.gb_inscription.Controls.Add(this.lb_noid);
            this.gb_inscription.Controls.Add(this.tb_dateNaissance);
            this.gb_inscription.Controls.Add(this.lb_telephone);
            this.gb_inscription.Controls.Add(this.lb_codePostal);
            this.gb_inscription.Controls.Add(this.lb_Prenom);
            this.gb_inscription.Controls.Add(this.tb_adresse);
            this.gb_inscription.Controls.Add(this.lb_nom);
            this.gb_inscription.Controls.Add(this.lb_ville);
            this.gb_inscription.Controls.Add(this.lb_codePermanent);
            this.gb_inscription.Controls.Add(this.lb_adresse);
            this.gb_inscription.Controls.Add(this.tb_ville);
            this.gb_inscription.Controls.Add(this.lb_dateNais);
            this.gb_inscription.Controls.Add(this.lb_sexe);
            this.gb_inscription.Location = new System.Drawing.Point(86, 64);
            this.gb_inscription.Name = "gb_inscription";
            this.gb_inscription.Size = new System.Drawing.Size(652, 530);
            this.gb_inscription.TabIndex = 28;
            this.gb_inscription.TabStop = false;
            this.gb_inscription.Text = "Informations";
            // 
            // mtb_codePostal
            // 
            this.mtb_codePostal.Enabled = false;
            this.mtb_codePostal.Location = new System.Drawing.Point(262, 427);
            this.mtb_codePostal.Mask = "A9A-9A9";
            this.mtb_codePostal.Name = "mtb_codePostal";
            this.mtb_codePostal.Size = new System.Drawing.Size(100, 23);
            this.mtb_codePostal.TabIndex = 23;
            this.mtb_codePostal.Validating += new System.ComponentModel.CancelEventHandler(this.mtb_codePostal_Validating);
            // 
            // gb_recherche
            // 
            this.gb_recherche.Controls.Add(this.tb_rNoid);
            this.gb_recherche.Controls.Add(this.btn_recherche);
            this.gb_recherche.Controls.Add(this.tb_rPrenom);
            this.gb_recherche.Controls.Add(this.tb_rNom);
            this.gb_recherche.Controls.Add(this.lb_rnoid);
            this.gb_recherche.Controls.Add(this.lb_rPrenom);
            this.gb_recherche.Controls.Add(this.lb_rNom);
            this.gb_recherche.Location = new System.Drawing.Point(86, 681);
            this.gb_recherche.Name = "gb_recherche";
            this.gb_recherche.Size = new System.Drawing.Size(652, 154);
            this.gb_recherche.TabIndex = 29;
            this.gb_recherche.TabStop = false;
            this.gb_recherche.Text = "Recherche";
            // 
            // tb_rNoid
            // 
            this.tb_rNoid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_rNoid.Location = new System.Drawing.Point(262, 115);
            this.tb_rNoid.Name = "tb_rNoid";
            this.tb_rNoid.Size = new System.Drawing.Size(297, 29);
            this.tb_rNoid.TabIndex = 32;
            // 
            // btn_recherche
            // 
            this.btn_recherche.Location = new System.Drawing.Point(565, 77);
            this.btn_recherche.Name = "btn_recherche";
            this.btn_recherche.Size = new System.Drawing.Size(78, 67);
            this.btn_recherche.TabIndex = 31;
            this.btn_recherche.Text = "Rechercher";
            this.btn_recherche.UseVisualStyleBackColor = true;
            this.btn_recherche.Click += new System.EventHandler(this.btn_recherche_Click);
            // 
            // tb_rPrenom
            // 
            this.tb_rPrenom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_rPrenom.Location = new System.Drawing.Point(262, 69);
            this.tb_rPrenom.Name = "tb_rPrenom";
            this.tb_rPrenom.Size = new System.Drawing.Size(297, 29);
            this.tb_rPrenom.TabIndex = 31;
            // 
            // tb_rNom
            // 
            this.tb_rNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_rNom.Location = new System.Drawing.Point(262, 24);
            this.tb_rNom.Name = "tb_rNom";
            this.tb_rNom.Size = new System.Drawing.Size(297, 29);
            this.tb_rNom.TabIndex = 23;
            // 
            // lb_rnoid
            // 
            this.lb_rnoid.AutoSize = true;
            this.lb_rnoid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_rnoid.Location = new System.Drawing.Point(29, 123);
            this.lb_rnoid.Name = "lb_rnoid";
            this.lb_rnoid.Size = new System.Drawing.Size(187, 21);
            this.lb_rnoid.TabIndex = 23;
            this.lb_rnoid.Text = "Numéro d\'indentification:";
            // 
            // lb_rPrenom
            // 
            this.lb_rPrenom.AutoSize = true;
            this.lb_rPrenom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_rPrenom.Location = new System.Drawing.Point(29, 77);
            this.lb_rPrenom.Name = "lb_rPrenom";
            this.lb_rPrenom.Size = new System.Drawing.Size(68, 21);
            this.lb_rPrenom.TabIndex = 30;
            this.lb_rPrenom.Text = "Prenom:";
            // 
            // lb_rNom
            // 
            this.lb_rNom.AutoSize = true;
            this.lb_rNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_rNom.Location = new System.Drawing.Point(29, 32);
            this.lb_rNom.Name = "lb_rNom";
            this.lb_rNom.Size = new System.Drawing.Size(48, 21);
            this.lb_rNom.TabIndex = 4;
            this.lb_rNom.Text = "Nom:";
            // 
            // gb_notes
            // 
            this.gb_notes.Controls.Add(this.nud_final);
            this.gb_notes.Controls.Add(this.nud_intra);
            this.gb_notes.Controls.Add(this.nud_tp2);
            this.gb_notes.Controls.Add(this.nud_tp1);
            this.gb_notes.Controls.Add(this.lb_final);
            this.gb_notes.Controls.Add(this.lb_intra);
            this.gb_notes.Controls.Add(this.lb_tp2);
            this.gb_notes.Controls.Add(this.lb_tp1);
            this.gb_notes.Location = new System.Drawing.Point(86, 598);
            this.gb_notes.Name = "gb_notes";
            this.gb_notes.Size = new System.Drawing.Size(652, 77);
            this.gb_notes.TabIndex = 38;
            this.gb_notes.TabStop = false;
            this.gb_notes.Text = "Notes";
            this.gb_notes.Visible = false;
            // 
            // nud_final
            // 
            this.nud_final.Location = new System.Drawing.Point(557, 35);
            this.nud_final.Name = "nud_final";
            this.nud_final.Size = new System.Drawing.Size(83, 23);
            this.nud_final.TabIndex = 7;
            this.nud_final.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nud_intra
            // 
            this.nud_intra.Location = new System.Drawing.Point(384, 35);
            this.nud_intra.Name = "nud_intra";
            this.nud_intra.Size = new System.Drawing.Size(83, 23);
            this.nud_intra.TabIndex = 6;
            this.nud_intra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nud_tp2
            // 
            this.nud_tp2.Location = new System.Drawing.Point(226, 35);
            this.nud_tp2.Name = "nud_tp2";
            this.nud_tp2.Size = new System.Drawing.Size(83, 23);
            this.nud_tp2.TabIndex = 5;
            this.nud_tp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nud_tp1
            // 
            this.nud_tp1.Location = new System.Drawing.Point(54, 35);
            this.nud_tp1.Name = "nud_tp1";
            this.nud_tp1.Size = new System.Drawing.Size(83, 23);
            this.nud_tp1.TabIndex = 4;
            this.nud_tp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_final
            // 
            this.lb_final.AutoSize = true;
            this.lb_final.Location = new System.Drawing.Point(521, 43);
            this.lb_final.Name = "lb_final";
            this.lb_final.Size = new System.Drawing.Size(30, 15);
            this.lb_final.TabIndex = 3;
            this.lb_final.Text = "final";
            // 
            // lb_intra
            // 
            this.lb_intra.AutoSize = true;
            this.lb_intra.Location = new System.Drawing.Point(347, 43);
            this.lb_intra.Name = "lb_intra";
            this.lb_intra.Size = new System.Drawing.Size(31, 15);
            this.lb_intra.TabIndex = 2;
            this.lb_intra.Text = "Intra";
            // 
            // lb_tp2
            // 
            this.lb_tp2.AutoSize = true;
            this.lb_tp2.Location = new System.Drawing.Point(196, 43);
            this.lb_tp2.Name = "lb_tp2";
            this.lb_tp2.Size = new System.Drawing.Size(24, 15);
            this.lb_tp2.TabIndex = 1;
            this.lb_tp2.Text = "tp2";
            // 
            // lb_tp1
            // 
            this.lb_tp1.AutoSize = true;
            this.lb_tp1.Location = new System.Drawing.Point(23, 43);
            this.lb_tp1.Name = "lb_tp1";
            this.lb_tp1.Size = new System.Drawing.Size(24, 15);
            this.lb_tp1.TabIndex = 0;
            this.lb_tp1.Text = "tp1";
            // 
            // btn_reculer
            // 
            this.btn_reculer.Location = new System.Drawing.Point(123, 49);
            this.btn_reculer.Name = "btn_reculer";
            this.btn_reculer.Size = new System.Drawing.Size(78, 67);
            this.btn_reculer.TabIndex = 34;
            this.btn_reculer.Text = "<--";
            this.btn_reculer.UseVisualStyleBackColor = true;
            this.btn_reculer.Click += new System.EventHandler(this.btn_reculer_Click);
            // 
            // btn_premier
            // 
            this.btn_premier.Location = new System.Drawing.Point(39, 49);
            this.btn_premier.Name = "btn_premier";
            this.btn_premier.Size = new System.Drawing.Size(78, 67);
            this.btn_premier.TabIndex = 33;
            this.btn_premier.Text = "|<";
            this.btn_premier.UseVisualStyleBackColor = true;
            this.btn_premier.Click += new System.EventHandler(this.btn_premier_Click);
            // 
            // btn_avancer
            // 
            this.btn_avancer.Location = new System.Drawing.Point(207, 49);
            this.btn_avancer.Name = "btn_avancer";
            this.btn_avancer.Size = new System.Drawing.Size(78, 67);
            this.btn_avancer.TabIndex = 35;
            this.btn_avancer.Text = "-->";
            this.btn_avancer.UseVisualStyleBackColor = true;
            this.btn_avancer.Click += new System.EventHandler(this.btn_avancer_Click);
            // 
            // btn_dernier
            // 
            this.btn_dernier.Location = new System.Drawing.Point(291, 49);
            this.btn_dernier.Name = "btn_dernier";
            this.btn_dernier.Size = new System.Drawing.Size(78, 67);
            this.btn_dernier.TabIndex = 36;
            this.btn_dernier.Text = ">|";
            this.btn_dernier.UseVisualStyleBackColor = true;
            this.btn_dernier.Click += new System.EventHandler(this.btn_dernier_Click);
            // 
            // pan_nav
            // 
            this.pan_nav.Controls.Add(this.btn_premier);
            this.pan_nav.Controls.Add(this.btn_reculer);
            this.pan_nav.Controls.Add(this.btn_dernier);
            this.pan_nav.Controls.Add(this.btn_avancer);
            this.pan_nav.Location = new System.Drawing.Point(790, 633);
            this.pan_nav.Name = "pan_nav";
            this.pan_nav.Size = new System.Drawing.Size(384, 161);
            this.pan_nav.TabIndex = 39;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lb_positionEleves
            // 
            this.lb_positionEleves.AutoSize = true;
            this.lb_positionEleves.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_positionEleves.Location = new System.Drawing.Point(932, 814);
            this.lb_positionEleves.Name = "lb_positionEleves";
            this.lb_positionEleves.Size = new System.Drawing.Size(113, 21);
            this.lb_positionEleves.TabIndex = 40;
            this.lb_positionEleves.Text = "position fichier";
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 911);
            this.ControlBox = false;
            this.Controls.Add(this.lb_positionEleves);
            this.Controls.Add(this.pan_nav);
            this.Controls.Add(this.gb_notes);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lb_titreInscription);
            this.Controls.Add(this.btn_nouveau);
            this.Controls.Add(this.gb_inscription);
            this.Controls.Add(this.gb_recherche);
            this.Name = "Inscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inscription";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.Inscription_Deactivate);
            this.gb_inscription.ResumeLayout(false);
            this.gb_inscription.PerformLayout();
            this.gb_recherche.ResumeLayout(false);
            this.gb_recherche.PerformLayout();
            this.gb_notes.ResumeLayout(false);
            this.gb_notes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_final)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_intra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tp1)).EndInit();
            this.pan_nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_nouveau;
        private Label lb_codePermanent;
        private Label lb_nom;
        private Label lb_Prenom;
        private Label lb_sexe;
        private Label lb_dateNais;
        private Label lb_adresse;
        private Label lb_ville;
        private Label lb_codePostal;
        private Label lb_telephone;
        private Label lb_noid;
        private TextBox tb_codePermanent;
        private TextBox tb_nom;
        private TextBox tb_prenom;
        private TextBox tb_adresse;
        private TextBox tb_ville;
        private RadioButton rb_feminin;
        private RadioButton rb_masculin;
        private MaskedTextBox tb_dateNaissance;
        private Label lb_noidAttribue;
        private MaskedTextBox mtb_telephone;
        private Label lb_titreInscription;
        private Button btn_ok;
        private Button btn_annuler;
        private Button btn_modifier;
        private Button btn_supprimer;
        private GroupBox gb_inscription;
        private GroupBox gb_recherche;
        private TextBox tb_rNoid;
        private Button btn_recherche;
        private TextBox tb_rPrenom;
        private TextBox tb_rNom;
        private Label lb_rnoid;
        private Label lb_rPrenom;
        private Label lb_rNom;
       
        private GroupBox gb_notes;
        private Label lb_final;
        private Label lb_intra;
        private Label lb_tp2;
        private Label lb_tp1;
        private Button btn_reculer;
        private Button btn_premier;
        private Button btn_avancer;
        private Button btn_dernier;
        private Panel pan_nav;
        private ErrorProvider errorProvider1;
        private MaskedTextBox mtb_codePostal;
        private NumericUpDown nud_final;
        private NumericUpDown nud_intra;
        private NumericUpDown nud_tp2;
        private NumericUpDown nud_tp1;
        private Label lb_positionEleves;
    }
}