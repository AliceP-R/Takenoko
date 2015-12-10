namespace TakenokoVisuel
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Jouer = new System.Windows.Forms.Button();
            this.Quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Jouer
            // 
            this.Jouer.Location = new System.Drawing.Point(101, 69);
            this.Jouer.Name = "Jouer";
            this.Jouer.Size = new System.Drawing.Size(75, 23);
            this.Jouer.TabIndex = 0;
            this.Jouer.Text = "Jouer";
            this.Jouer.UseVisualStyleBackColor = true;
            this.Jouer.Click += new System.EventHandler(this.button1_Click);
            // 
            // Quitter
            // 
            this.Quitter.Location = new System.Drawing.Point(101, 132);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(75, 23);
            this.Quitter.TabIndex = 1;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.button2_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Jouer);
            this.Name = "Accueil";
            this.Text = "Takenoko";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Jouer;
        private System.Windows.Forms.Button Quitter;
    }
}

