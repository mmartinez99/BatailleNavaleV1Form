namespace bataillenavaleV1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.ScoreJoueur = new System.Windows.Forms.Label();
            this.ScoreEnnemi = new System.Windows.Forms.Label();
            this.MouvementEnnemi = new System.Windows.Forms.Label();
            this.NbTours = new System.Windows.Forms.Label();
            this.Aide = new System.Windows.Forms.Label();
            this.ListEmpEnnemis = new System.Windows.Forms.ComboBox();
            this.BtnAttaque = new System.Windows.Forms.Button();
            this.w1 = new System.Windows.Forms.Button();
            this.w2 = new System.Windows.Forms.Button();
            this.w3 = new System.Windows.Forms.Button();
            this.w4 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.x4 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.Button();
            this.y2 = new System.Windows.Forms.Button();
            this.y3 = new System.Windows.Forms.Button();
            this.y4 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.Button();
            this.z2 = new System.Windows.Forms.Button();
            this.z3 = new System.Windows.Forms.Button();
            this.z4 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.timerEnnemi = new System.Windows.Forms.Timer(this.components);
            this.EnnemiPositionPicker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ScoreJoueur
            // 
            this.ScoreJoueur.AutoSize = true;
            this.ScoreJoueur.Location = new System.Drawing.Point(350, 101);
            this.ScoreJoueur.Name = "ScoreJoueur";
            this.ScoreJoueur.Size = new System.Drawing.Size(27, 20);
            this.ScoreJoueur.TabIndex = 0;
            this.ScoreJoueur.Text = "00";
            // 
            // ScoreEnnemi
            // 
            this.ScoreEnnemi.AutoSize = true;
            this.ScoreEnnemi.Location = new System.Drawing.Point(914, 101);
            this.ScoreEnnemi.Name = "ScoreEnnemi";
            this.ScoreEnnemi.Size = new System.Drawing.Size(27, 20);
            this.ScoreEnnemi.TabIndex = 1;
            this.ScoreEnnemi.Text = "00";
            // 
            // MouvementEnnemi
            // 
            this.MouvementEnnemi.AutoSize = true;
            this.MouvementEnnemi.Location = new System.Drawing.Point(886, 44);
            this.MouvementEnnemi.Name = "MouvementEnnemi";
            this.MouvementEnnemi.Size = new System.Drawing.Size(29, 20);
            this.MouvementEnnemi.TabIndex = 2;
            this.MouvementEnnemi.Text = "A1";
            // 
            // NbTours
            // 
            this.NbTours.AutoSize = true;
            this.NbTours.Location = new System.Drawing.Point(505, 113);
            this.NbTours.Name = "NbTours";
            this.NbTours.Size = new System.Drawing.Size(49, 20);
            this.NbTours.TabIndex = 3;
            this.NbTours.Text = "Tours";
            // 
            // Aide
            // 
            this.Aide.AutoSize = true;
            this.Aide.Location = new System.Drawing.Point(112, 536);
            this.Aide.Name = "Aide";
            this.Aide.Size = new System.Drawing.Size(442, 20);
            this.Aide.TabIndex = 4;
            this.Aide.Text = "1) Cliqure sur 3 boutons différents ci-dessus pour commencer";
            // 
            // ListEmpEnnemis
            // 
            this.ListEmpEnnemis.FormattingEnabled = true;
            this.ListEmpEnnemis.Location = new System.Drawing.Point(212, 26);
            this.ListEmpEnnemis.Name = "ListEmpEnnemis";
            this.ListEmpEnnemis.Size = new System.Drawing.Size(139, 28);
            this.ListEmpEnnemis.TabIndex = 5;
            // 
            // BtnAttaque
            // 
            this.BtnAttaque.Location = new System.Drawing.Point(382, 15);
            this.BtnAttaque.Name = "BtnAttaque";
            this.BtnAttaque.Size = new System.Drawing.Size(125, 49);
            this.BtnAttaque.TabIndex = 6;
            this.BtnAttaque.Text = "Attaquer";
            this.BtnAttaque.UseVisualStyleBackColor = true;
            this.BtnAttaque.Click += new System.EventHandler(this.EnnemyPosition);
            // 
            // w1
            // 
            this.w1.Location = new System.Drawing.Point(126, 234);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(60, 49);
            this.w1.TabIndex = 7;
            this.w1.Text = "W1";
            this.w1.UseVisualStyleBackColor = true;
            this.w1.Click += new System.EventHandler(this.joueurClickPosition);
            // 
            // w2
            // 
            this.w2.Location = new System.Drawing.Point(212, 234);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(60, 49);
            this.w2.TabIndex = 8;
            this.w2.Text = "W2";
            this.w2.UseVisualStyleBackColor = true;
            this.w2.Click += new System.EventHandler(this.joueurClickPosition);
            // 
            // w3
            // 
            this.w3.Location = new System.Drawing.Point(302, 234);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(60, 49);
            this.w3.TabIndex = 9;
            this.w3.Text = "W3";
            this.w3.UseVisualStyleBackColor = true;
            this.w3.Click += new System.EventHandler(this.joueurClickPosition);
            // 
            // w4
            // 
            this.w4.Location = new System.Drawing.Point(398, 234);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(60, 49);
            this.w4.TabIndex = 10;
            this.w4.Text = "W4";
            this.w4.UseVisualStyleBackColor = true;
            this.w4.Click += new System.EventHandler(this.joueurClickPosition);
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(126, 310);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(60, 49);
            this.x1.TabIndex = 11;
            this.x1.Text = "X1";
            this.x1.UseVisualStyleBackColor = true;
            this.x1.Click += new System.EventHandler(this.joueurClickPosition);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(212, 310);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(60, 49);
            this.x2.TabIndex = 12;
            this.x2.Text = "X2";
            this.x2.UseVisualStyleBackColor = true;
            this.x2.Click += new System.EventHandler(this.joueurClickPosition);
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(302, 310);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(60, 49);
            this.x3.TabIndex = 13;
            this.x3.Text = "X3";
            this.x3.UseVisualStyleBackColor = true;
            this.x3.Click += new System.EventHandler(this.joueurClickPosition);
            // 
            // x4
            // 
            this.x4.Location = new System.Drawing.Point(398, 310);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(60, 49);
            this.x4.TabIndex = 14;
            this.x4.Text = "X4";
            this.x4.UseVisualStyleBackColor = true;
            this.x4.Click += new System.EventHandler(this.joueurClickPosition);
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(126, 390);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(60, 49);
            this.y1.TabIndex = 15;
            this.y1.Text = "Y1";
            this.y1.UseVisualStyleBackColor = true;
            this.y1.Click += new System.EventHandler(this.joueurClickPosition);
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(212, 390);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(60, 49);
            this.y2.TabIndex = 16;
            this.y2.Text = "Y2";
            this.y2.UseVisualStyleBackColor = true;
            this.y2.Click += new System.EventHandler(this.joueurClickPosition);
            // 
            // y3
            // 
            this.y3.Location = new System.Drawing.Point(302, 390);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(60, 49);
            this.y3.TabIndex = 17;
            this.y3.Text = "Y3";
            this.y3.UseVisualStyleBackColor = true;
            this.y3.Click += new System.EventHandler(this.joueurClickPosition);
            // 
            // y4
            // 
            this.y4.Location = new System.Drawing.Point(398, 390);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(60, 49);
            this.y4.TabIndex = 18;
            this.y4.Text = "Y4";
            this.y4.UseVisualStyleBackColor = true;
            this.y4.Click += new System.EventHandler(this.joueurClickPosition);
            // 
            // z1
            // 
            this.z1.Location = new System.Drawing.Point(126, 465);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(60, 49);
            this.z1.TabIndex = 19;
            this.z1.Text = "Z1";
            this.z1.UseVisualStyleBackColor = true;
            this.z1.Click += new System.EventHandler(this.joueurClickPosition);
            // 
            // z2
            // 
            this.z2.Location = new System.Drawing.Point(212, 465);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(60, 49);
            this.z2.TabIndex = 20;
            this.z2.Text = "Z2";
            this.z2.UseVisualStyleBackColor = true;
            this.z2.Click += new System.EventHandler(this.joueurClickPosition);
            // 
            // z3
            // 
            this.z3.Location = new System.Drawing.Point(302, 465);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(60, 49);
            this.z3.TabIndex = 21;
            this.z3.Text = "Z3";
            this.z3.UseVisualStyleBackColor = true;
            this.z3.Click += new System.EventHandler(this.joueurClickPosition);
            // 
            // z4
            // 
            this.z4.Location = new System.Drawing.Point(398, 465);
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(60, 49);
            this.z4.TabIndex = 22;
            this.z4.Text = "Z4";
            this.z4.UseVisualStyleBackColor = true;
            this.z4.Click += new System.EventHandler(this.joueurClickPosition);
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(616, 234);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(60, 49);
            this.a1.TabIndex = 23;
            this.a1.Text = "A1";
            this.a1.UseVisualStyleBackColor = true;
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(719, 234);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(60, 49);
            this.a2.TabIndex = 24;
            this.a2.Text = "A2";
            this.a2.UseVisualStyleBackColor = true;
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(811, 234);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(60, 49);
            this.a3.TabIndex = 25;
            this.a3.Text = "A3";
            this.a3.UseVisualStyleBackColor = true;
            // 
            // a4
            // 
            this.a4.Location = new System.Drawing.Point(900, 234);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(60, 49);
            this.a4.TabIndex = 26;
            this.a4.Text = "A4";
            this.a4.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(616, 310);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(60, 49);
            this.b1.TabIndex = 27;
            this.b1.Text = "B1";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(616, 390);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(60, 49);
            this.c1.TabIndex = 28;
            this.c1.Text = "C1";
            this.c1.UseVisualStyleBackColor = true;
            // 
            // d1
            // 
            this.d1.Location = new System.Drawing.Point(616, 465);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(60, 49);
            this.d1.TabIndex = 29;
            this.d1.Text = "D1";
            this.d1.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(719, 310);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(60, 49);
            this.b2.TabIndex = 30;
            this.b2.Text = "B2";
            this.b2.UseVisualStyleBackColor = true;
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(719, 390);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(60, 49);
            this.c2.TabIndex = 31;
            this.c2.Text = "C2";
            this.c2.UseVisualStyleBackColor = true;
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(719, 465);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(60, 49);
            this.d2.TabIndex = 32;
            this.d2.Text = "D2";
            this.d2.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(811, 310);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(60, 49);
            this.b3.TabIndex = 33;
            this.b3.Text = "B3";
            this.b3.UseVisualStyleBackColor = true;
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(811, 390);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(60, 49);
            this.c3.TabIndex = 34;
            this.c3.Text = "C3";
            this.c3.UseVisualStyleBackColor = true;
            // 
            // d3
            // 
            this.d3.Location = new System.Drawing.Point(811, 465);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(60, 49);
            this.d3.TabIndex = 35;
            this.d3.Text = "D3";
            this.d3.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(900, 310);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(60, 49);
            this.b4.TabIndex = 36;
            this.b4.Text = "B4";
            this.b4.UseVisualStyleBackColor = true;
            // 
            // c4
            // 
            this.c4.Location = new System.Drawing.Point(900, 390);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(60, 49);
            this.c4.TabIndex = 37;
            this.c4.Text = "C4";
            this.c4.UseVisualStyleBackColor = true;
            // 
            // d4
            // 
            this.d4.Location = new System.Drawing.Point(900, 465);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(60, 49);
            this.d4.TabIndex = 38;
            this.d4.Text = "D4";
            this.d4.UseVisualStyleBackColor = true;
            // 
            // timerEnnemi
            // 
            this.timerEnnemi.Interval = 1000;
            this.timerEnnemi.Tick += new System.EventHandler(this.ennemyAttackPlayer);
            // 
            // EnnemiPositionPicker
            // 
            this.EnnemiPositionPicker.Enabled = true;
            this.EnnemiPositionPicker.Interval = 500;
            this.EnnemiPositionPicker.Tick += new System.EventHandler(this.ennemyPicksPositions);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bataillenavaleV1.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1059, 568);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.z4);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.y4);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.BtnAttaque);
            this.Controls.Add(this.ListEmpEnnemis);
            this.Controls.Add(this.Aide);
            this.Controls.Add(this.NbTours);
            this.Controls.Add(this.MouvementEnnemi);
            this.Controls.Add(this.ScoreEnnemi);
            this.Controls.Add(this.ScoreJoueur);
            this.Name = "Form1";
            this.Text = "Bataille Navale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreJoueur;
        private System.Windows.Forms.Label ScoreEnnemi;
        private System.Windows.Forms.Label MouvementEnnemi;
        private System.Windows.Forms.Label NbTours;
        private System.Windows.Forms.Label Aide;
        private System.Windows.Forms.ComboBox ListEmpEnnemis;
        private System.Windows.Forms.Button BtnAttaque;
        private System.Windows.Forms.Button w1;
        private System.Windows.Forms.Button w2;
        private System.Windows.Forms.Button w3;
        private System.Windows.Forms.Button w4;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button x4;
        private System.Windows.Forms.Button y1;
        private System.Windows.Forms.Button y2;
        private System.Windows.Forms.Button y3;
        private System.Windows.Forms.Button y4;
        private System.Windows.Forms.Button z1;
        private System.Windows.Forms.Button z2;
        private System.Windows.Forms.Button z3;
        private System.Windows.Forms.Button z4;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.Timer timerEnnemi;
        private System.Windows.Forms.Timer EnnemiPositionPicker;
    }
}

