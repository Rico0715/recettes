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
    public partial class SaisieIngredientsForm : Form
    {
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=recettes;Integrated Security=True";

        public SaisieIngredientsForm()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string nomIngredient = textBoxNomIngredient.Text;
            int quantite;
            decimal prix;

            // Vérifier si les champs sont vides ou invalides
            if (string.IsNullOrWhiteSpace(nomIngredient) ||
                !int.TryParse(textBoxQuantite.Text, out quantite) ||
                !decimal.TryParse(textBoxPrix.Text, out prix))
            {
                MessageBox.Show("Veuillez remplir tous les champs avec des valeurs valides.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insérer les données dans la base de données
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Ingredients (NomIngre, Quantite, Prix) VALUES (@NomIngre, @Quantite, @Prix)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NomIngre", nomIngredient);
                    command.Parameters.AddWithValue("@Quantite", quantite);
                    command.Parameters.AddWithValue("@Prix", prix);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("L'ingrédient a été ajouté avec succès à la base de données.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Effacez les champs après l'insertion réussie si nécessaire
                        textBoxNomIngredient.Clear();
                        textBoxQuantite.Clear();
                        textBoxPrix.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Une erreur s'est produite lors de l'insertion de l'ingrédient.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
