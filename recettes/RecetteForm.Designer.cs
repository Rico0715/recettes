using System.Data.SqlClient;

namespace recettes
{
    partial class RecetteForm
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
            labelNomRecette = new Label();
            listBoxIngredients = new ListBox();
            flowLayoutPanelBoutonsRecettes = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            ComboBoxNombrePersonnes = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // labelNomRecette
            // 
            labelNomRecette.AutoSize = true;
            labelNomRecette.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelNomRecette.Location = new Point(84, 30);
            labelNomRecette.Name = "labelNomRecette";
            labelNomRecette.Size = new Size(231, 28);
            labelNomRecette.TabIndex = 1;
            labelNomRecette.Text = "Selectionner une recette :";
            labelNomRecette.Click += label1_Click;
            // 
            // listBoxIngredients
            // 
            listBoxIngredients.FormattingEnabled = true;
            listBoxIngredients.ItemHeight = 15;
            listBoxIngredients.Location = new Point(84, 128);
            listBoxIngredients.Name = "listBoxIngredients";
            listBoxIngredients.Size = new Size(196, 289);
            listBoxIngredients.TabIndex = 2;
            listBoxIngredients.SelectedIndexChanged += listBoxIngredients_SelectedIndexChanged;
            // 
            // flowLayoutPanelBoutonsRecettes
            // 
            flowLayoutPanelBoutonsRecettes.AutoScroll = true;
            flowLayoutPanelBoutonsRecettes.AutoSize = true;
            flowLayoutPanelBoutonsRecettes.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelBoutonsRecettes.Location = new Point(361, 30);
            flowLayoutPanelBoutonsRecettes.Name = "flowLayoutPanelBoutonsRecettes";
            flowLayoutPanelBoutonsRecettes.Size = new Size(184, 86);
            flowLayoutPanelBoutonsRecettes.TabIndex = 3;
            flowLayoutPanelBoutonsRecettes.Click += flowLayoutPanelBoutonsRecettes_Click;
            flowLayoutPanelBoutonsRecettes.Paint += flowLayoutPanelBoutonsRecettes_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 105);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 4;
            label1.Text = "Liste des ingrédients :";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(84, 77);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 5;
            // 
            // ComboBoxNombrePersonnes
            // 
            ComboBoxNombrePersonnes.FormattingEnabled = true;
            ComboBoxNombrePersonnes.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            ComboBoxNombrePersonnes.Location = new Point(274, 82);
            ComboBoxNombrePersonnes.Name = "ComboBoxNombrePersonnes";
            ComboBoxNombrePersonnes.Size = new Size(41, 23);
            ComboBoxNombrePersonnes.TabIndex = 6;
            ComboBoxNombrePersonnes.SelectedIndexChanged += ComboBoxNombrePersonnes_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(105, 79);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 7;
            label3.Text = "Nombre de personnes :";
            // 
            // RecetteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(796, 447);
            Controls.Add(label3);
            Controls.Add(ComboBoxNombrePersonnes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanelBoutonsRecettes);
            Controls.Add(listBoxIngredients);
            Controls.Add(labelNomRecette);
            Name = "RecetteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecetteForm";
            Load += RecetteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void ChargerBoutonsRecettes()
        {
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=recettes;Integrated Security=True"; // Remplacez cela par votre propre chaîne de connexion à la base de données

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Nom FROM Recettes";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string nomRecette = reader["Nom"].ToString();
                        Button boutonRecette = new Button();
                        boutonRecette.AutoSize = true;
                        boutonRecette.Text = nomRecette;
                        boutonRecette.Margin = new Padding(5); // Espacement entre les boutons
                        boutonRecette.Click += (sender, e) => AfficherDetailsRecette(nomRecette); // Vous pouvez passer l'identifiant ou le nom de la recette ici
                        boutonRecette.Tag = nomRecette;
                        flowLayoutPanelBoutonsRecettes.Controls.Add(boutonRecette);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des recettes : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComboBox()

        {
            // Remplir le ComboBox avec les nombres de 1 à 8
            ComboBoxNombrePersonnes = new ComboBox(); // Instanciez le ComboBox
            ComboBoxNombrePersonnes.DropDownStyle = ComboBoxStyle.DropDownList; // Empêchez l'utilisateur de saisir des valeurs
            ComboBoxNombrePersonnes.Location = new Point(10, 10); // Définissez la position du ComboBox sur le formulaire
            ComboBoxNombrePersonnes.Size = new Size(50, 20); // Définissez la taille du ComboBox
            Controls.Add(ComboBoxNombrePersonnes); // Ajoutez le ComboBox au formulaire

            // Remplissez le ComboBox avec les nombres de 1 à 8
            for (int i = 1; i <= 8; i++)
            {
                ComboBoxNombrePersonnes.Items.Add(i);
            }

            // Écoutez l'événement SelectedIndexChanged du ComboBox
            ComboBoxNombrePersonnes.SelectedIndexChanged += ComboBoxNombrePersonnes_SelectedIndexChanged;
        }
        #endregion
        private Label labelNomRecette;
        private ListBox listBoxIngredients;
        private FlowLayoutPanel flowLayoutPanelBoutonsRecettes;
        private Label label1;
        private Label label2;
        private ComboBox ComboBoxNombrePersonnes;
        private Label label3;
    }
}