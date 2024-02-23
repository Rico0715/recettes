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
            SuspendLayout();
            // 
            // textBoxNomRecette
            // 
            textBoxNomRecette.Location = new Point(160, 38);
            textBoxNomRecette.Name = "textBoxNomRecette";
            textBoxNomRecette.Size = new Size(74, 23);
            textBoxNomRecette.TabIndex = 1;
            // 
            // textBoxIngredients
            // 
            textBoxIngredients.Location = new Point(125, 97);
            textBoxIngredients.Name = "textBoxIngredients";
            textBoxIngredients.Size = new Size(100, 23);
            textBoxIngredients.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 41);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 3;
            label1.Text = "Nom de la recette :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 100);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 4;
            label2.Text = "Ingrédients :";
            // 
            // btn_Save_BDD
            // 
            btn_Save_BDD.Location = new Point(601, 371);
            btn_Save_BDD.Name = "btn_Save_BDD";
            btn_Save_BDD.Size = new Size(75, 23);
            btn_Save_BDD.TabIndex = 5;
            btn_Save_BDD.Text = "Enregistrer";
            btn_Save_BDD.UseVisualStyleBackColor = true;
            btn_Save_BDD.Click += btn_Save_BDD_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 145);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 7;
            label3.Text = "Quantité :";
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(244, 114);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 8;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // textBoxQuantite
            // 
            textBoxQuantite.Location = new Point(125, 137);
            textBoxQuantite.Name = "textBoxQuantite";
            textBoxQuantite.Size = new Size(100, 23);
            textBoxQuantite.TabIndex = 11;
            // 
            // listBoxIngredients
            // 
            listBoxIngredients.FormattingEnabled = true;
            listBoxIngredients.ItemHeight = 15;
            listBoxIngredients.Location = new Point(25, 214);
            listBoxIngredients.Name = "listBoxIngredients";
            listBoxIngredients.Size = new Size(120, 94);
            listBoxIngredients.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 180);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 14;
            label5.Text = "Liste des Ingrédients";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(229, 143);
            label4.Name = "label4";
            label4.Size = new Size(18, 20);
            label4.TabIndex = 15;
            label4.Text = "g";
            // 
            // SaisieRecetteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}