namespace recettes
{
    partial class SaisieRecetteForm
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
            textBoxNomRecette = new TextBox();
            textBoxIngredients = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_Save_BDD = new Button();
            label3 = new Label();
            btnAjouter = new Button();
            textBoxQuantite = new TextBox();
            listBoxIngredients = new ListBox();
            label5 = new Label();
            label4 = new Label();
            listBoxSuggestions = new ListBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBoxNomRecette
            // 
            textBoxNomRecette.Location = new Point(186, 108);
            textBoxNomRecette.Margin = new Padding(3, 4, 3, 4);
            textBoxNomRecette.Name = "textBoxNomRecette";
            textBoxNomRecette.Size = new Size(84, 27);
            textBoxNomRecette.TabIndex = 1;
            textBoxNomRecette.TextChanged += textBoxNomRecette_TextChanged;
            // 
            // textBoxIngredients
            // 
            textBoxIngredients.Location = new Point(140, 158);
            textBoxIngredients.Margin = new Padding(3, 4, 3, 4);
            textBoxIngredients.Name = "textBoxIngredients";
            textBoxIngredients.Size = new Size(114, 27);
            textBoxIngredients.TabIndex = 2;
            textBoxIngredients.TextChanged += textBoxIngredients_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 111);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 3;
            label1.Text = "Nom de la recette :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 161);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 4;
            label2.Text = "Ingrédients :";
            // 
            // btn_Save_BDD
            // 
            btn_Save_BDD.Location = new Point(687, 495);
            btn_Save_BDD.Margin = new Padding(3, 4, 3, 4);
            btn_Save_BDD.Name = "btn_Save_BDD";
            btn_Save_BDD.Size = new Size(91, 31);
            btn_Save_BDD.TabIndex = 5;
            btn_Save_BDD.Text = "Enregistrer";
            btn_Save_BDD.UseVisualStyleBackColor = true;
            btn_Save_BDD.Click += btn_Save_BDD_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 313);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 7;
            label3.Text = "Quantité :";
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(334, 238);
            btnAjouter.Margin = new Padding(3, 4, 3, 4);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(86, 31);
            btnAjouter.TabIndex = 8;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // textBoxQuantite
            // 
            textBoxQuantite.Location = new Point(123, 306);
            textBoxQuantite.Margin = new Padding(3, 4, 3, 4);
            textBoxQuantite.Name = "textBoxQuantite";
            textBoxQuantite.Size = new Size(114, 27);
            textBoxQuantite.TabIndex = 11;
            // 
            // listBoxIngredients
            // 
            listBoxIngredients.FormattingEnabled = true;
            listBoxIngredients.ItemHeight = 20;
            listBoxIngredients.Location = new Point(19, 423);
            listBoxIngredients.Margin = new Padding(3, 4, 3, 4);
            listBoxIngredients.Name = "listBoxIngredients";
            listBoxIngredients.Size = new Size(137, 124);
            listBoxIngredients.TabIndex = 13;
            listBoxIngredients.SelectedIndexChanged += listBoxIngredients_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 381);
            label5.Name = "label5";
            label5.Size = new Size(184, 25);
            label5.TabIndex = 14;
            label5.Text = "Liste des Ingrédients";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(243, 309);
            label4.Name = "label4";
            label4.Size = new Size(23, 25);
            label4.TabIndex = 15;
            label4.Text = "g";
            // 
            // listBoxSuggestions
            // 
            listBoxSuggestions.FormattingEnabled = true;
            listBoxSuggestions.ItemHeight = 20;
            listBoxSuggestions.Location = new Point(140, 184);
            listBoxSuggestions.Name = "listBoxSuggestions";
            listBoxSuggestions.Size = new Size(150, 104);
            listBoxSuggestions.TabIndex = 16;
            listBoxSuggestions.SelectedIndexChanged += listBoxSuggestions_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(265, 30);
            label6.Name = "label6";
            label6.Size = new Size(359, 35);
            label6.TabIndex = 17;
            label6.Text = "Nouvelle Recette (1 personnes)";
            // 
            // SaisieRecetteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label6);
            Controls.Add(listBoxSuggestions);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(listBoxIngredients);
            Controls.Add(textBoxQuantite);
            Controls.Add(btnAjouter);
            Controls.Add(label3);
            Controls.Add(btn_Save_BDD);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxIngredients);
            Controls.Add(textBoxNomRecette);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SaisieRecetteForm";
            Text = "SaisieRecetteForm";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private TextBox textBoxNomRecette;
        private TextBox textBoxIngredients;
        private Label label1;
        private Label label2;
        private Button btn_Save_BDD;
        private Label label3;
        private Button btnAjouter;
        private TextBox textBoxQuantite;
        private ListBox listBoxIngredients;
        private Label label5;
        private Label label4;
        private ListBox listBoxSuggestions;
        private Label label6;
    }
}