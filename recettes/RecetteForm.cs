    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace recettes
    {
        public partial class RecetteForm : Form
        {

            public RecetteForm()
            {
                InitializeComponent();
                ChargerBoutonsRecettes();
                InitializeComboBox();
            }



            List<int> quantitesInitiales = new List<int>();

            private void AfficherIngredientsDeRecette(int recetteId)
            {
            listBoxIngredients.Items.Clear(); // Efface les anciens ingrédients affichés

            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=recettes;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT NomIngre, Quantite, Prix FROM Ingredients WHERE RecetteId = @RecetteId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RecetteId", recetteId);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string ingredient = reader["NomIngre"].ToString();
                        int quantite = Convert.ToInt32(reader["Quantite"]);
                        decimal prix;
                        if (reader["Prix"] != DBNull.Value)
                        {
                            prix = Convert.ToDecimal(reader["Prix"]);
                        }
                        else
                        {
                            prix = 0; // Ou une autre valeur par défaut que vous souhaitez utiliser pour les prix nuls
                        }
                        decimal coutTotal = prix * quantite;
                        string displayText = ingredient + " - " + quantite.ToString() + " - " + coutTotal.ToString(); // Ajoutez le prix total à afficher
                        listBoxIngredients.Items.Add(displayText);

                        // Stocker la quantité initiale dans la liste
                        quantitesInitiales.Add(quantite);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des ingrédients : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





            private void AfficherDetailsRecette(string nomRecette)
            {
                labelNomRecette.Text = nomRecette;
                int recetteId = GetRecetteIdFromDatabase(nomRecette);
                AfficherIngredientsDeRecette(recetteId);


            }
            private void btn_Recette1_Click(object sender, EventArgs e)
            {
                RecetteForm recetteForm = new RecetteForm();

                recetteForm.ShowDialog();
            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void RecetteForm_Load(object sender, EventArgs e)
            {

            }

            private void label1_Click_1(object sender, EventArgs e)
            {

            }

            private void flowLayoutPanelBoutonsRecettes_Paint(object sender, PaintEventArgs e)
            {

            }



            private void flowLayoutPanelBoutonsRecettes_Click(object sender, EventArgs e)
            {
                Button boutonRecette = (Button)sender;
                string nomRecette = boutonRecette.Text;

                // Obtenez l'identifiant de la recette à partir du nom de la recette
                int recetteId = GetRecetteIdFromDatabase(nomRecette); // Vous devez implémenter cette méthode pour récupérer l'identifiant de la recette

                AfficherIngredientsDeRecette(recetteId);
            }

            private int GetRecetteIdFromDatabase(string nomRecette)
            {
                int recetteId = -1; // Valeur par défaut si l'identifiant n'est pas trouvé

                string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=recettes;Integrated Security=True"; // Remplacez cela par votre propre chaîne de connexion à la base de données

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "SELECT Id FROM Recettes WHERE Nom = @NomRecette";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@NomRecette", nomRecette);

                        object result = command.ExecuteScalar(); // Exécute la requête et récupère la première colonne de la première ligne du résultat

                    if (result != null && result != DBNull.Value) // Vérifie si l'identifiant de la recette a été trouvé
                    {
                        recetteId = Convert.ToInt32(result); // Convertit le résultat en entier
                    }
                    
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération de l'identifiant de la recette : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Console.WriteLine("Recette ID trouvé: " + recetteId);
                return recetteId;
            }

            private void listBoxIngredients_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void ComboBoxNombrePersonnes_SelectedIndexChanged(object sender, EventArgs e)
            {
                // Vérifier si un nombre de personnes est sélectionné
    if (ComboBoxNombrePersonnes.SelectedItem != null)
    {
        int nombrePersonnes = (int)ComboBoxNombrePersonnes.SelectedItem;

        // Parcourir les ingrédients affichés dans la listBoxIngredients
        for (int i = 0; i < listBoxIngredients.Items.Count; i++)
        {
            // Récupérer la quantité initiale de l'ingrédient
            int quantiteInitiale = quantitesInitiales[i];

            string ingredientText = listBoxIngredients.Items[i].ToString();
            string[] parts = ingredientText.Split('-');

            if (parts.Length == 3) // Assurez-vous que la ligne contient le prix
            {
                string nomIngredient = parts[0].Trim();
                int quantite = quantiteInitiale * nombrePersonnes;
                
                // Mettre à jour le prix total en fonction du nombre de personnes
                decimal prixUnitaire = decimal.Parse(parts[1].Trim());
                decimal coutTotal = prixUnitaire * quantite;

                // Mettre à jour le texte de l'ingrédient dans la listBoxIngredients
                listBoxIngredients.Items[i] = nomIngredient + " - " + quantite.ToString() + " - " + coutTotal.ToString();
            }
        }
    }
            }

        }
    }
