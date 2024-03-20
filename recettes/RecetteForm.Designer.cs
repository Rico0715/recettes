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
            label3 = new Label();
            ComboBoxNombrePersonnes = new ComboBox();
            SuspendLayout();
            // 
            // labelNomRecette
            // 
            labelNomRecette.AutoSize = true;
            labelNomRecette.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelNomRecette.Location = new Point(96, 40);
            labelNomRecette.Name = "labelNomRecette";
            labelNomRecette.Size = new Size(294, 35);
            labelNomRecette.TabIndex = 1;
            labelNomRecette.Text = "Selectionner une recette :";
            labelNomRecette.Click += label1_Click;
            // 
            // listBoxIngredients
            // 
            listBoxIngredients.FormattingEnabled = true;
            listBoxIngredients.ItemHeight = 20;
            listBoxIngredients.Location = new Point(96, 171);
            listBoxIngredients.Margin = new Padding(3, 4, 3, 4);
            listBoxIngredients.Name = "listBoxIngredients";
            listBoxIngredients.Size = new Size(223, 384);
            listBoxIngredients.TabIndex = 2;
            listBoxIngredients.SelectedIndexChanged += listBoxIngredients_SelectedIndexChanged;
            // 
            // flowLayoutPanelBoutonsRecettes
            // 
            flowLayoutPanelBoutonsRecettes.AutoScroll = true;
            flowLayoutPanelBoutonsRecettes.AutoSize = true;
            flowLayoutPanelBoutonsRecettes.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelBoutonsRecettes.Location = new Point(457, 40);
            flowLayoutPanelBoutonsRecettes.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelBoutonsRecettes.Name = "flowLayoutPanelBoutonsRecettes";
            flowLayoutPanelBoutonsRecettes.Size = new Size(399, 502);
            flowLayoutPanelBoutonsRecettes.TabIndex = 3;
            flowLayoutPanelBoutonsRecettes.Click += flowLayoutPanelBoutonsRecettes_Click;
            flowLayoutPanelBoutonsRecettes.Paint += flowLayoutPanelBoutonsRecettes_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(96, 140);
            label1.Name = "label1";
            label1.Size = new Size(193, 25);
            label1.TabIndex = 4;
            label1.Text = "Liste des ingrédients :";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(96, 103);
            label2.Name = "label2";
            label2.Size = new Size(0, 35);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(120, 105);
            label3.Name = "label3";
            label3.Size = new Size(208, 25);
            label3.TabIndex = 7;
            label3.Text = "Nombre de personnes :";
            // 
            // ComboBoxNombrePersonnes
            // 
            ComboBoxNombrePersonnes.FormattingEnabled = true;
            ComboBoxNombrePersonnes.Location = new Point(313, 107);
            ComboBoxNombrePersonnes.Margin = new Padding(3, 4, 3, 4);
            ComboBoxNombrePersonnes.Name = "ComboBoxNombrePersonnes";
            ComboBoxNombrePersonnes.Size = new Size(138, 28);
            ComboBoxNombrePersonnes.TabIndex = 8;
            // 
            // RecetteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(910, 596);
            Controls.Add(ComboBoxNombrePersonnes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanelBoutonsRecettes);
            Controls.Add(listBoxIngredients);
            Controls.Add(labelNomRecette);
            Margin = new Padding(3, 4, 3, 4);
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
            // Instanciez le ComboBox
            ComboBoxNombrePersonnes.DropDownStyle = ComboBoxStyle.DropDownList; // Empêchez l'utilisateur de saisir des valeurs
                                                                                // Définissez la position du ComboBox sur le formulaire
            ComboBoxNombrePersonnes.Size = new Size(50, 20);// Définissez la taille du ComboBox
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
        private Label label3;
        private ComboBox ComboBoxNombrePersonnes;
    }
}