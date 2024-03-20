using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace recettes
{
    public partial class SaisieRecetteForm : Form
    {
        private List<Ingredient> ingredients = new List<Ingredient>();
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=recettes;Integrated Security=True";
        private SqlConnection connection;
        public SaisieRecetteForm()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);


        }

        SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=recettes;Integrated Security=True");


        private void btn_Save_BDD_Click(object sender, EventArgs e)
        {
            String Nom, NomIngre;

            Nom = textBoxNomRecette.Text;
            string listeIngredients = textBoxIngredients.Text;
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=recettes;Integrated Security=True";
            string nomRecette = textBoxNomRecette.Text;




            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string queryRecette = "INSERT INTO Recettes (Nom) VALUES (@Nom); SELECT SCOPE_IDENTITY();";
                    SqlCommand commandRecette = new SqlCommand(queryRecette, connection);
                    commandRecette.Parameters.AddWithValue("@Nom", nomRecette);

                    int recetteId = Convert.ToInt32(commandRecette.ExecuteScalar());

                    foreach (Ingredient ingredient in ingredients)
                    {
                        string queryIngredient = "INSERT INTO Ingredients (NomIngre, Quantite, RecetteId) VALUES (@NomIngre, @Quantite, @RecetteId)";
                        SqlCommand commandIngredient = new SqlCommand(queryIngredient, connection);
                        commandIngredient.Parameters.AddWithValue("@NomIngre", ingredient.NomIngre);
                        commandIngredient.Parameters.AddWithValue("@Quantite", ingredient.Quantite);
                        commandIngredient.Parameters.AddWithValue("@RecetteId", recetteId);

                        int rowsAffectedIngredient = commandIngredient.ExecuteNonQuery();
                    }

                    MessageBox.Show("La recette a été insérée avec succès dans la base de données.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnAjouter_Click(object sender, EventArgs e)
        {

            string NomIngre = textBoxIngredients.Text;
            int quantite;

            if (!string.IsNullOrWhiteSpace(NomIngre) && int.TryParse(textBoxQuantite.Text, out quantite))
            {
                Ingredient ingredient = new Ingredient { NomIngre = NomIngre, Quantite = quantite };
                ingredients.Add(ingredient);

                // Optionnel : Afficher l'ingrédient ajouté dans une liste ou une autre zone de texte
                listBoxIngredients.Items.Add($"{NomIngre} - {quantite}");

                // Effacer les zones de texte
                textBoxIngredients.Clear();
                textBoxQuantite.Clear();
            }
            else
            {
                MessageBox.Show("Veuillez entrer un ingrédient valide avec une quantité.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIngredients_TextChanged(object sender, EventArgs e)
        {
            // Effacer les suggestions précédentes
            listBoxSuggestions.Items.Clear();

            // Récupérer le texte entré dans le textBoxIngredient
            string recherche = textBoxIngredients.Text.ToLower();

            // Vérifier si le textBoxIngredient n'est pas vide
            if (!string.IsNullOrEmpty(recherche))
            {
                // Récupérer les suggestions à partir de la base de données
                List<string> suggestions = GetSuggestionsFromDatabase(recherche);

                // Afficher les suggestions dans la listBoxSuggestions
                foreach (string suggestion in suggestions)
                {
                    listBoxSuggestions.Items.Add(suggestion);
                }
            }
        }
        private List<string> GetSuggestionsFromDatabase(string recherche)
        {
            List<string> suggestions = new List<string>();

            // Connexion à la base de données et exécution de la requête SQL pour récupérer les suggestions
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=recettes;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT NomIngre FROM Ingredients WHERE NomIngre LIKE @Recherche + '%'";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Recherche", recherche);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string suggestion = reader["NomIngre"].ToString();

                    // Vérifier si la suggestion commence par la recherche
                    if (suggestion.ToLower().StartsWith(recherche))
                    {
                        suggestions.Add(suggestion);
                    }
                }
            }

            return suggestions;
        }

        private void listBoxSuggestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSuggestions.SelectedItem != null)
            {
                // Récupérer l'ingrédient sélectionné
                string ingredientSelectionne = listBoxSuggestions.SelectedItem.ToString();

                // Remplacer le contenu du textBoxIngredients par l'ingrédient sélectionné
                textBoxIngredients.Text = ingredientSelectionne;

                // Sélectionner tout le texte dans le textBoxIngredients
                textBoxIngredients.SelectAll();
            }
        }

        private void textBoxNomRecette_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

