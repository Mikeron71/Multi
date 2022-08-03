namespace Tp2
{
    public partial class Form1 : Form
    {
   
        public Form1()
        {
            InitializeComponent();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loadInscription();
         
        }
       
        
        // MENU BAR_________________________________________________________________________
        
        private void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Inscription f2 = (Inscription)Application.OpenForms["Inscription"];
            f2.Focus();

        }


        private void listeEtStatistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (System.Windows.Forms.Application.OpenForms["Stats"] as Stats == null)
            {
                Stats f3 = new Stats();
                f3.MdiParent = this;
                f3.Show();
            }
            else
            {
                Stats f3 = (Stats)Application.OpenForms["Stats"];
                f3.Focus();
            }

        }
        public void  loadInscription()
        {
            if (System.Windows.Forms.Application.OpenForms["Inscription"] as Inscription == null)
            {
                Inscription f2 = new Inscription();
                f2.MdiParent = this;
                f2.Show();
            }
            else
            {
                Inscription f2 = (Inscription)Application.OpenForms["Inscription"];
                f2.Focus();
            }
        }
        

        
    }
}