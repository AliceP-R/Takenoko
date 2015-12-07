namespace TakenokoVisuel
{
    partial class Bambouseraie
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
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.deplacerPanda = new System.Windows.Forms.Button();
            this.deplacerJardinier = new System.Windows.Forms.Button();
            this.arroser = new System.Windows.Forms.Button();
            this.piocheCarte = new System.Windows.Forms.Button();
            this.piocheParcelle = new System.Windows.Forms.Button();
            this.groupBoxObjectif = new System.Windows.Forms.GroupBox();
            this.Obj5 = new System.Windows.Forms.Label();
            this.Obj4 = new System.Windows.Forms.Label();
            this.Obj1 = new System.Windows.Forms.Label();
            this.Obj3 = new System.Windows.Forms.Label();
            this.Obj2 = new System.Windows.Forms.Label();
            this.quitter = new System.Windows.Forms.Button();
            this.zoneJardin = new System.Windows.Forms.PictureBox();
            this.choixCouleurParcelle = new System.Windows.Forms.GroupBox();
            this.ColorPink = new System.Windows.Forms.Button();
            this.ColorYellow = new System.Windows.Forms.Button();
            this.ColorGreen = new System.Windows.Forms.Button();
            this.lancement = new System.Windows.Forms.Button();
            this.irriguer = new System.Windows.Forms.Button();
            this.groupBoxAction.SuspendLayout();
            this.groupBoxObjectif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoneJardin)).BeginInit();
            this.choixCouleurParcelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.irriguer);
            this.groupBoxAction.Controls.Add(this.deplacerPanda);
            this.groupBoxAction.Controls.Add(this.deplacerJardinier);
            this.groupBoxAction.Controls.Add(this.arroser);
            this.groupBoxAction.Controls.Add(this.piocheCarte);
            this.groupBoxAction.Controls.Add(this.piocheParcelle);
            this.groupBoxAction.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(171, 153);
            this.groupBoxAction.TabIndex = 1;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "Action";
            // 
            // deplacerPanda
            // 
            this.deplacerPanda.Location = new System.Drawing.Point(87, 99);
            this.deplacerPanda.Name = "deplacerPanda";
            this.deplacerPanda.Size = new System.Drawing.Size(75, 34);
            this.deplacerPanda.TabIndex = 4;
            this.deplacerPanda.Text = "Déplacer Panda";
            this.deplacerPanda.UseVisualStyleBackColor = true;
            // 
            // deplacerJardinier
            // 
            this.deplacerJardinier.Location = new System.Drawing.Point(6, 99);
            this.deplacerJardinier.Name = "deplacerJardinier";
            this.deplacerJardinier.Size = new System.Drawing.Size(75, 34);
            this.deplacerJardinier.TabIndex = 3;
            this.deplacerJardinier.Text = "Déplacer Jardinier";
            this.deplacerJardinier.UseVisualStyleBackColor = true;
            // 
            // arroser
            // 
            this.arroser.Location = new System.Drawing.Point(6, 59);
            this.arroser.Name = "arroser";
            this.arroser.Size = new System.Drawing.Size(75, 34);
            this.arroser.TabIndex = 2;
            this.arroser.Text = "Arroser";
            this.arroser.UseVisualStyleBackColor = true;
            this.arroser.Click += new System.EventHandler(this.arroser_Click);
            // 
            // piocheCarte
            // 
            this.piocheCarte.Location = new System.Drawing.Point(87, 19);
            this.piocheCarte.Name = "piocheCarte";
            this.piocheCarte.Size = new System.Drawing.Size(75, 34);
            this.piocheCarte.TabIndex = 1;
            this.piocheCarte.Text = "Piocher Carte";
            this.piocheCarte.UseVisualStyleBackColor = true;
            this.piocheCarte.Click += new System.EventHandler(this.piocherCarte_Click);
            // 
            // piocheParcelle
            // 
            this.piocheParcelle.Location = new System.Drawing.Point(6, 19);
            this.piocheParcelle.Name = "piocheParcelle";
            this.piocheParcelle.Size = new System.Drawing.Size(75, 34);
            this.piocheParcelle.TabIndex = 0;
            this.piocheParcelle.Text = "Piocher Parcelle";
            this.piocheParcelle.UseVisualStyleBackColor = true;
            this.piocheParcelle.Click += new System.EventHandler(this.piocherParcelle_Click);
            // 
            // groupBoxObjectif
            // 
            this.groupBoxObjectif.Controls.Add(this.Obj5);
            this.groupBoxObjectif.Controls.Add(this.Obj4);
            this.groupBoxObjectif.Controls.Add(this.Obj1);
            this.groupBoxObjectif.Controls.Add(this.Obj3);
            this.groupBoxObjectif.Controls.Add(this.Obj2);
            this.groupBoxObjectif.Location = new System.Drawing.Point(12, 321);
            this.groupBoxObjectif.Name = "groupBoxObjectif";
            this.groupBoxObjectif.Size = new System.Drawing.Size(171, 145);
            this.groupBoxObjectif.TabIndex = 3;
            this.groupBoxObjectif.TabStop = false;
            this.groupBoxObjectif.Text = "Objectifs";
            // 
            // Obj5
            // 
            this.Obj5.AutoSize = true;
            this.Obj5.Location = new System.Drawing.Point(6, 121);
            this.Obj5.Name = "Obj5";
            this.Obj5.Size = new System.Drawing.Size(52, 13);
            this.Obj5.TabIndex = 4;
            this.Obj5.Text = "Objectif 5";
            // 
            // Obj4
            // 
            this.Obj4.AutoSize = true;
            this.Obj4.Location = new System.Drawing.Point(6, 98);
            this.Obj4.Name = "Obj4";
            this.Obj4.Size = new System.Drawing.Size(52, 13);
            this.Obj4.TabIndex = 3;
            this.Obj4.Text = "Objectif 4";
            // 
            // Obj1
            // 
            this.Obj1.AutoSize = true;
            this.Obj1.Location = new System.Drawing.Point(6, 27);
            this.Obj1.Name = "Obj1";
            this.Obj1.Size = new System.Drawing.Size(49, 13);
            this.Obj1.TabIndex = 2;
            this.Obj1.Text = "Objectif1";
            // 
            // Obj3
            // 
            this.Obj3.AutoSize = true;
            this.Obj3.Location = new System.Drawing.Point(6, 73);
            this.Obj3.Name = "Obj3";
            this.Obj3.Size = new System.Drawing.Size(52, 13);
            this.Obj3.TabIndex = 1;
            this.Obj3.Text = "Objectif 3";
            // 
            // Obj2
            // 
            this.Obj2.AutoSize = true;
            this.Obj2.Location = new System.Drawing.Point(6, 49);
            this.Obj2.Name = "Obj2";
            this.Obj2.Size = new System.Drawing.Size(52, 13);
            this.Obj2.TabIndex = 0;
            this.Obj2.Text = "Objectif 2";
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(64, 489);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(66, 25);
            this.quitter.TabIndex = 4;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // zoneJardin
            // 
            this.zoneJardin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zoneJardin.Location = new System.Drawing.Point(213, 31);
            this.zoneJardin.Name = "zoneJardin";
            this.zoneJardin.Size = new System.Drawing.Size(450, 450);
            this.zoneJardin.TabIndex = 5;
            this.zoneJardin.TabStop = false;
            this.zoneJardin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.zoneJardin_Click);
            // 
            // choixCouleurParcelle
            // 
            this.choixCouleurParcelle.Controls.Add(this.ColorPink);
            this.choixCouleurParcelle.Controls.Add(this.ColorYellow);
            this.choixCouleurParcelle.Controls.Add(this.ColorGreen);
            this.choixCouleurParcelle.Location = new System.Drawing.Point(12, 171);
            this.choixCouleurParcelle.Name = "choixCouleurParcelle";
            this.choixCouleurParcelle.Size = new System.Drawing.Size(171, 144);
            this.choixCouleurParcelle.TabIndex = 6;
            this.choixCouleurParcelle.TabStop = false;
            this.choixCouleurParcelle.Text = "Couleur de la parcelle ?";
            this.choixCouleurParcelle.Visible = false;
            // 
            // ColorPink
            // 
            this.ColorPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ColorPink.Location = new System.Drawing.Point(52, 102);
            this.ColorPink.Name = "ColorPink";
            this.ColorPink.Size = new System.Drawing.Size(75, 23);
            this.ColorPink.TabIndex = 2;
            this.ColorPink.Text = "Rose";
            this.ColorPink.UseVisualStyleBackColor = false;
            this.ColorPink.Click += new System.EventHandler(this.ColorPink_Click);
            // 
            // ColorYellow
            // 
            this.ColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.ColorYellow.Location = new System.Drawing.Point(52, 63);
            this.ColorYellow.Name = "ColorYellow";
            this.ColorYellow.Size = new System.Drawing.Size(75, 23);
            this.ColorYellow.TabIndex = 1;
            this.ColorYellow.Text = "Jaune";
            this.ColorYellow.UseVisualStyleBackColor = false;
            this.ColorYellow.Click += new System.EventHandler(this.ColorYellow_Click);
            // 
            // ColorGreen
            // 
            this.ColorGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ColorGreen.Location = new System.Drawing.Point(52, 19);
            this.ColorGreen.Name = "ColorGreen";
            this.ColorGreen.Size = new System.Drawing.Size(75, 23);
            this.ColorGreen.TabIndex = 0;
            this.ColorGreen.Text = "Vert";
            this.ColorGreen.UseVisualStyleBackColor = false;
            this.ColorGreen.Click += new System.EventHandler(this.ColorGreen_Click);
            // 
            // lancement
            // 
            this.lancement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lancement.Location = new System.Drawing.Point(349, 63);
            this.lancement.Name = "lancement";
            this.lancement.Size = new System.Drawing.Size(173, 82);
            this.lancement.TabIndex = 7;
            this.lancement.Text = "Lancer la partie !";
            this.lancement.UseVisualStyleBackColor = true;
            this.lancement.Click += new System.EventHandler(this.lancement_Click);
            // 
            // irriguer
            // 
            this.irriguer.Location = new System.Drawing.Point(87, 59);
            this.irriguer.Name = "irriguer";
            this.irriguer.Size = new System.Drawing.Size(75, 34);
            this.irriguer.TabIndex = 5;
            this.irriguer.Text = "Irriguer";
            this.irriguer.UseVisualStyleBackColor = true;
            this.irriguer.Click += new System.EventHandler(this.irriguer_Click);
            // 
            // Bambouseraie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 526);
            this.Controls.Add(this.lancement);
            this.Controls.Add(this.choixCouleurParcelle);
            this.Controls.Add(this.zoneJardin);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.groupBoxObjectif);
            this.Controls.Add(this.groupBoxAction);
            this.Name = "Bambouseraie";
            this.Text = "Bambouseraie";
            this.groupBoxAction.ResumeLayout(false);
            this.groupBoxObjectif.ResumeLayout(false);
            this.groupBoxObjectif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoneJardin)).EndInit();
            this.choixCouleurParcelle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.GroupBox groupBoxObjectif;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Button deplacerPanda;
        private System.Windows.Forms.Button deplacerJardinier;
        private System.Windows.Forms.Button arroser;
        private System.Windows.Forms.Button piocheCarte;
        private System.Windows.Forms.Button piocheParcelle;
        private System.Windows.Forms.Label Obj5;
        private System.Windows.Forms.Label Obj4;
        private System.Windows.Forms.Label Obj1;
        private System.Windows.Forms.Label Obj3;
        private System.Windows.Forms.Label Obj2;
        private System.Windows.Forms.PictureBox zoneJardin;
        private System.Windows.Forms.GroupBox choixCouleurParcelle;
        private System.Windows.Forms.Button ColorPink;
        private System.Windows.Forms.Button ColorYellow;
        private System.Windows.Forms.Button ColorGreen;
        private System.Windows.Forms.Button lancement;
        private System.Windows.Forms.Button irriguer;
    }
}