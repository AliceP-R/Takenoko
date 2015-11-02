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
            this.groupBoxInventaire = new System.Windows.Forms.GroupBox();
            this.groupBoxObjectif = new System.Windows.Forms.GroupBox();
            this.Obj5 = new System.Windows.Forms.Label();
            this.Obj4 = new System.Windows.Forms.Label();
            this.Obj1 = new System.Windows.Forms.Label();
            this.Obj3 = new System.Windows.Forms.Label();
            this.Obj2 = new System.Windows.Forms.Label();
            this.quitter = new System.Windows.Forms.Button();
            this.zoneJardin = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBoxAction.SuspendLayout();
            this.groupBoxObjectif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoneJardin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAction
            // 
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
            this.arroser.Location = new System.Drawing.Point(52, 59);
            this.arroser.Name = "arroser";
            this.arroser.Size = new System.Drawing.Size(75, 34);
            this.arroser.TabIndex = 2;
            this.arroser.Text = "Arroser";
            this.arroser.UseVisualStyleBackColor = true;
            // 
            // piocheCarte
            // 
            this.piocheCarte.Location = new System.Drawing.Point(87, 19);
            this.piocheCarte.Name = "piocheCarte";
            this.piocheCarte.Size = new System.Drawing.Size(75, 34);
            this.piocheCarte.TabIndex = 1;
            this.piocheCarte.Text = "Piocher Carte";
            this.piocheCarte.UseVisualStyleBackColor = true;
            this.piocheCarte.Click += new System.EventHandler(this.piocheCarte_Click);
            // 
            // piocheParcelle
            // 
            this.piocheParcelle.Location = new System.Drawing.Point(6, 19);
            this.piocheParcelle.Name = "piocheParcelle";
            this.piocheParcelle.Size = new System.Drawing.Size(75, 34);
            this.piocheParcelle.TabIndex = 0;
            this.piocheParcelle.Text = "Piocher Parcelle";
            this.piocheParcelle.UseVisualStyleBackColor = true;
            this.piocheParcelle.Click += new System.EventHandler(this.piocheParcelle_Click);
            // 
            // groupBoxInventaire
            // 
            this.groupBoxInventaire.Location = new System.Drawing.Point(12, 171);
            this.groupBoxInventaire.Name = "groupBoxInventaire";
            this.groupBoxInventaire.Size = new System.Drawing.Size(171, 139);
            this.groupBoxInventaire.TabIndex = 2;
            this.groupBoxInventaire.TabStop = false;
            this.groupBoxInventaire.Text = "Inventaire";
            // 
            // groupBoxObjectif
            // 
            this.groupBoxObjectif.Controls.Add(this.Obj5);
            this.groupBoxObjectif.Controls.Add(this.Obj4);
            this.groupBoxObjectif.Controls.Add(this.Obj1);
            this.groupBoxObjectif.Controls.Add(this.Obj3);
            this.groupBoxObjectif.Controls.Add(this.Obj2);
            this.groupBoxObjectif.Location = new System.Drawing.Point(12, 316);
            this.groupBoxObjectif.Name = "groupBoxObjectif";
            this.groupBoxObjectif.Size = new System.Drawing.Size(171, 150);
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
            this.quitter.Click += new System.EventHandler(this.button1_Click);
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
            // colorDialog1
            // 
            this.colorDialog1.AllowFullOpen = false;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // Bambouseraie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 526);
            this.Controls.Add(this.zoneJardin);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.groupBoxObjectif);
            this.Controls.Add(this.groupBoxInventaire);
            this.Controls.Add(this.groupBoxAction);
            this.Name = "Bambouseraie";
            this.Text = "Bambouseraie";
            this.groupBoxAction.ResumeLayout(false);
            this.groupBoxObjectif.ResumeLayout(false);
            this.groupBoxObjectif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoneJardin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.GroupBox groupBoxInventaire;
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
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}