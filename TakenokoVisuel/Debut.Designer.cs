namespace TakenokoVisuel
{
    partial class Debut
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
            this.joueur2 = new System.Windows.Forms.Button();
            this.joueur3 = new System.Windows.Forms.Button();
            this.joueur4 = new System.Windows.Forms.Button();
            this.groupeBoxNbreJoueur = new System.Windows.Forms.GroupBox();
            this.groupeBoxNomJoueur = new System.Windows.Forms.GroupBox();
            this.labelNomJoueur4 = new System.Windows.Forms.Label();
            this.labelNomJoueur3 = new System.Windows.Forms.Label();
            this.labelNomJoueur2 = new System.Windows.Forms.Label();
            this.labelNomJoueur1 = new System.Windows.Forms.Label();
            this.NomJoueur4 = new System.Windows.Forms.TextBox();
            this.NomJoueur3 = new System.Windows.Forms.TextBox();
            this.NomJoueur2 = new System.Windows.Forms.TextBox();
            this.NomJoueur1 = new System.Windows.Forms.TextBox();
            this.DebutPartie = new System.Windows.Forms.Button();
            this.quitter = new System.Windows.Forms.Button();
            this.groupeBoxNbreJoueur.SuspendLayout();
            this.groupeBoxNomJoueur.SuspendLayout();
            this.SuspendLayout();
            // 
            // joueur2
            // 
            this.joueur2.Location = new System.Drawing.Point(21, 19);
            this.joueur2.Name = "joueur2";
            this.joueur2.Size = new System.Drawing.Size(27, 23);
            this.joueur2.TabIndex = 3;
            this.joueur2.Text = "2";
            this.joueur2.UseVisualStyleBackColor = true;
            this.joueur2.Click += new System.EventHandler(this.joueur2_Click);
            // 
            // joueur3
            // 
            this.joueur3.Location = new System.Drawing.Point(102, 19);
            this.joueur3.Name = "joueur3";
            this.joueur3.Size = new System.Drawing.Size(27, 23);
            this.joueur3.TabIndex = 4;
            this.joueur3.Text = "3";
            this.joueur3.UseVisualStyleBackColor = true;
            this.joueur3.Click += new System.EventHandler(this.joueur3_Click);
            // 
            // joueur4
            // 
            this.joueur4.Location = new System.Drawing.Point(184, 19);
            this.joueur4.Name = "joueur4";
            this.joueur4.Size = new System.Drawing.Size(27, 23);
            this.joueur4.TabIndex = 5;
            this.joueur4.Text = "4";
            this.joueur4.UseVisualStyleBackColor = true;
            this.joueur4.Click += new System.EventHandler(this.joueur4_Click);
            // 
            // groupeBoxNbreJoueur
            // 
            this.groupeBoxNbreJoueur.Controls.Add(this.joueur4);
            this.groupeBoxNbreJoueur.Controls.Add(this.joueur3);
            this.groupeBoxNbreJoueur.Controls.Add(this.joueur2);
            this.groupeBoxNbreJoueur.Location = new System.Drawing.Point(28, 12);
            this.groupeBoxNbreJoueur.Name = "groupeBoxNbreJoueur";
            this.groupeBoxNbreJoueur.Size = new System.Drawing.Size(229, 53);
            this.groupeBoxNbreJoueur.TabIndex = 6;
            this.groupeBoxNbreJoueur.TabStop = false;
            this.groupeBoxNbreJoueur.Text = "Combien de joueur êtes vous ?";
            // 
            // groupeBoxNomJoueur
            // 
            this.groupeBoxNomJoueur.Controls.Add(this.labelNomJoueur4);
            this.groupeBoxNomJoueur.Controls.Add(this.labelNomJoueur3);
            this.groupeBoxNomJoueur.Controls.Add(this.labelNomJoueur2);
            this.groupeBoxNomJoueur.Controls.Add(this.labelNomJoueur1);
            this.groupeBoxNomJoueur.Controls.Add(this.NomJoueur4);
            this.groupeBoxNomJoueur.Controls.Add(this.NomJoueur3);
            this.groupeBoxNomJoueur.Controls.Add(this.NomJoueur2);
            this.groupeBoxNomJoueur.Controls.Add(this.NomJoueur1);
            this.groupeBoxNomJoueur.Location = new System.Drawing.Point(28, 71);
            this.groupeBoxNomJoueur.Name = "groupeBoxNomJoueur";
            this.groupeBoxNomJoueur.Size = new System.Drawing.Size(222, 141);
            this.groupeBoxNomJoueur.TabIndex = 7;
            this.groupeBoxNomJoueur.TabStop = false;
            this.groupeBoxNomJoueur.Text = "Entrez vos noms :";
            // 
            // labelNomJoueur4
            // 
            this.labelNomJoueur4.AutoSize = true;
            this.labelNomJoueur4.Location = new System.Drawing.Point(24, 115);
            this.labelNomJoueur4.Name = "labelNomJoueur4";
            this.labelNomJoueur4.Size = new System.Drawing.Size(48, 13);
            this.labelNomJoueur4.TabIndex = 8;
            this.labelNomJoueur4.Text = "Joueur 4";
            // 
            // labelNomJoueur3
            // 
            this.labelNomJoueur3.AutoSize = true;
            this.labelNomJoueur3.Location = new System.Drawing.Point(24, 89);
            this.labelNomJoueur3.Name = "labelNomJoueur3";
            this.labelNomJoueur3.Size = new System.Drawing.Size(48, 13);
            this.labelNomJoueur3.TabIndex = 6;
            this.labelNomJoueur3.Text = "Joueur 3";
            // 
            // labelNomJoueur2
            // 
            this.labelNomJoueur2.AutoSize = true;
            this.labelNomJoueur2.Location = new System.Drawing.Point(24, 63);
            this.labelNomJoueur2.Name = "labelNomJoueur2";
            this.labelNomJoueur2.Size = new System.Drawing.Size(48, 13);
            this.labelNomJoueur2.TabIndex = 5;
            this.labelNomJoueur2.Text = "Joueur 2";
            // 
            // labelNomJoueur1
            // 
            this.labelNomJoueur1.AutoSize = true;
            this.labelNomJoueur1.Location = new System.Drawing.Point(24, 37);
            this.labelNomJoueur1.Name = "labelNomJoueur1";
            this.labelNomJoueur1.Size = new System.Drawing.Size(48, 13);
            this.labelNomJoueur1.TabIndex = 4;
            this.labelNomJoueur1.Text = "Joueur 1";
            // 
            // NomJoueur4
            // 
            this.NomJoueur4.Location = new System.Drawing.Point(78, 112);
            this.NomJoueur4.Name = "NomJoueur4";
            this.NomJoueur4.Size = new System.Drawing.Size(100, 20);
            this.NomJoueur4.TabIndex = 3;
            this.NomJoueur4.Leave += new System.EventHandler(this.NomJoueur4_Leave);
            // 
            // NomJoueur3
            // 
            this.NomJoueur3.Location = new System.Drawing.Point(78, 86);
            this.NomJoueur3.Name = "NomJoueur3";
            this.NomJoueur3.Size = new System.Drawing.Size(100, 20);
            this.NomJoueur3.TabIndex = 2;
            this.NomJoueur3.Leave += new System.EventHandler(this.NomJoueur3_Leave);
            // 
            // NomJoueur2
            // 
            this.NomJoueur2.Location = new System.Drawing.Point(78, 60);
            this.NomJoueur2.Name = "NomJoueur2";
            this.NomJoueur2.Size = new System.Drawing.Size(100, 20);
            this.NomJoueur2.TabIndex = 1;
            this.NomJoueur2.Leave += new System.EventHandler(this.NomJoueur2_Leave);
            // 
            // NomJoueur1
            // 
            this.NomJoueur1.Location = new System.Drawing.Point(78, 34);
            this.NomJoueur1.Name = "NomJoueur1";
            this.NomJoueur1.Size = new System.Drawing.Size(100, 20);
            this.NomJoueur1.TabIndex = 0;
            this.NomJoueur1.Leave += new System.EventHandler(this.NomJoueur1_Leave);
            // 
            // DebutPartie
            // 
            this.DebutPartie.Location = new System.Drawing.Point(28, 227);
            this.DebutPartie.Name = "DebutPartie";
            this.DebutPartie.Size = new System.Drawing.Size(144, 23);
            this.DebutPartie.TabIndex = 8;
            this.DebutPartie.Text = "Commencer !";
            this.DebutPartie.UseVisualStyleBackColor = true;
            this.DebutPartie.Click += new System.EventHandler(this.debut_Click);
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(197, 227);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(53, 22);
            this.quitter.TabIndex = 9;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Debut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.DebutPartie);
            this.Controls.Add(this.groupeBoxNomJoueur);
            this.Controls.Add(this.groupeBoxNbreJoueur);
            this.Name = "Debut";
            this.Text = "Nombre de joueur";
            this.groupeBoxNbreJoueur.ResumeLayout(false);
            this.groupeBoxNomJoueur.ResumeLayout(false);
            this.groupeBoxNomJoueur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button joueur2;
        private System.Windows.Forms.Button joueur3;
        private System.Windows.Forms.Button joueur4;
        private System.Windows.Forms.GroupBox groupeBoxNbreJoueur;
        private System.Windows.Forms.GroupBox groupeBoxNomJoueur;
        private System.Windows.Forms.TextBox NomJoueur4;
        private System.Windows.Forms.TextBox NomJoueur3;
        private System.Windows.Forms.TextBox NomJoueur2;
        private System.Windows.Forms.TextBox NomJoueur1;
        private System.Windows.Forms.Label labelNomJoueur4;
        private System.Windows.Forms.Label labelNomJoueur3;
        private System.Windows.Forms.Label labelNomJoueur2;
        private System.Windows.Forms.Label labelNomJoueur1;
        private System.Windows.Forms.Button DebutPartie;
        private System.Windows.Forms.Button quitter;
    }
}