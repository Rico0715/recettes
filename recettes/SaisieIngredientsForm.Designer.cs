namespace recettes
{
    partial class SaisieIngredientsForm
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
            btnEnregistrer = new Button();
            textBoxNomIngredient = new TextBox();
            label1 = new Label();
            textBoxQuantite = new TextBox();
            textBoxPrix = new TextBox();
            SuspendLayout();
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Location = new Point(597, 337);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(94, 29);
            btnEnregistrer.TabIndex = 0;
            btnEnregistrer.Text = "Enregister";
            btnEnregistrer.UseVisualStyleBackColor = true;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // textBoxNomIngredient
            // 
            textBoxNomIngredient.Location = new Point(170, 157);
            textBoxNomIngredient.Name = "textBoxNomIngredient";
            textBoxNomIngredient.Size = new Size(125, 27);
            textBoxNomIngredient.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 164);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 2;
            label1.Text = "Ingredient :";
            // 
            // textBoxQuantite
            // 
            textBoxQuantite.Location = new Point(170, 205);
            textBoxQuantite.Name = "textBoxQuantite";
            textBoxQuantite.Size = new Size(125, 27);
            textBoxQuantite.TabIndex = 3;
            // 
            // textBoxPrix
            // 
            textBoxPrix.Location = new Point(170, 256);
            textBoxPrix.Name = "textBoxPrix";
            textBoxPrix.Size = new Size(125, 27);
            textBoxPrix.TabIndex = 4;
            // 
            // SaisieIngredientsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPrix);
            Controls.Add(textBoxQuantite);
            Controls.Add(label1);
            Controls.Add(textBoxNomIngredient);
            Controls.Add(btnEnregistrer);
            Name = "SaisieIngredientsForm";
            Text = "SaisieIngredientsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnregistrer;
        private TextBox textBoxNomIngredient;
        private Label label1;
        private TextBox textBoxQuantite;
        private TextBox textBoxPrix;
    }
}