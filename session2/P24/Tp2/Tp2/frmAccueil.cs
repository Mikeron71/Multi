namespace Tp2
{
    public partial class frmAccueil : Form
    {
        public static Inscription? frmInscription =  null;
        public frmAccueil()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadInscription(); 
        }
      
        // MENU BAR_________________________________________________________________________
        
        private void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadInscription();
        }

        public  void  LoadInscription()
        {
            if (System.Windows.Forms.Application.OpenForms["Inscription"] as Inscription == null)
            {
                frmInscription = new Inscription();
                frmInscription.MdiParent = this;
                frmInscription.Show();
            }
            else
            {
                Inscription frmInscription = (Inscription)Application.OpenForms["Inscription"];
                frmInscription.Focus();
            }
        }

        private void listeEtStatistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (System.Windows.Forms.Application.OpenForms["Stats"] as Stats == null)
            {
                Stats frmStats = new Stats();
                frmStats.MdiParent = this;
                frmStats.Show();
            }
            else
            {
                Stats frmStats = (Stats)Application.OpenForms["Stats"];
                frmStats.Focus();
                frmStats.Read();
                frmStats.LoadMoyenne();
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Êtes-vous sûr de vouloir quitter?", "QUITTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Environment.Exit(0);
        }
    }
}