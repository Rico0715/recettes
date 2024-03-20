namespace recettes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click sur le bouton");
            RecetteForm recetteForm = new RecetteForm();

            recetteForm.ShowDialog();

        }

        private void btnSaisieRecette_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click sur le bouton");
            SaisieRecetteForm saisieRecetteForm = new SaisieRecetteForm();

            saisieRecetteForm.ShowDialog();

        }

        private void btnSaisieIngredients_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click sur le bouton");
            SaisieIngredientsForm saisieIngredientsForm = new SaisieIngredientsForm();

            saisieIngredientsForm.ShowDialog();
        }
    }
}