namespace recettes
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_My_Recettes = new Button();
            btnSaisieRecette = new Button();
            SuspendLayout();
            // 
            // btn_My_Recettes
            // 
            btn_My_Recettes.Location = new Point(461, 63);
            btn_My_Recettes.Name = "btn_My_Recettes";
            btn_My_Recettes.Size = new Size(237, 71);
            btn_My_Recettes.TabIndex = 0;
            btn_My_Recettes.Text = "Mes Recettes";
            btn_My_Recettes.UseVisualStyleBackColor = true;
            btn_My_Recettes.Click += button1_Click;
            // 
            // btnSaisieRecette
            // 
            btnSaisieRecette.Location = new Point(67, 63);
            btnSaisieRecette.Name = "btnSaisieRecette";
            btnSaisieRecette.Size = new Size(260, 71);
            btnSaisieRecette.TabIndex = 1;
            btnSaisieRecette.Text = "Nouvelle Recette";
            btnSaisieRecette.UseVisualStyleBackColor = true;
            btnSaisieRecette.Click += btnSaisieRecette_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaisieRecette);
            Controls.Add(btn_My_Recettes);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_My_Recettes;
        private Button btnSaisieRecette;
    }
}