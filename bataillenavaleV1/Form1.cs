using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bataillenavaleV1
{
    public partial class Form1 : Form
    {
        
        List<Button> playerPosition; //List position joueur
        List<Button> positionEnnemi; // List position ennemie
        Random rand = new Random();


        int totalShips = 3; //nb 3 cases pour le joueur
        int totalenemy = 3; // 3 cases pour l'ennemie


        int tours = 10; // total nb tours 
        int playerTotalScore = 0; 
        int enemyTotalScore = 0; 

        public Form1()
        {
            InitializeComponent();
            loadbuttons(); 
            BtnAttaque.Enabled = false; // Desactive les boutons d'attaque car selectionne d'abord position navires
            ListEmpEnnemis.Text = null; 
                                        
                                   
        }

        private void loadbuttons()
        {
            playerPosition = new List<Button> { w1, w2, w3, w4, x1, x2, x3, x4, y1, y2, y3, y4, z1, z2, z3, z4 };
            positionEnnemi = new List<Button> { a1, a2, a3, a4, b1, b2, b3, b4, c1, c2, c3, c4, d1, d2, d3, d4 };

        //Chaque position ennemie
            for (int i = 0; i < positionEnnemi.Count; i++)
            {
                positionEnnemi[i].Tag = null;
                // ajoute à la liste déroulante 
                ListEmpEnnemis.Items.Add(positionEnnemi[i].Text);
            }
        }

        private void joueurClickPosition(object sender, EventArgs e)
        {

            if (totalShips > 0)
            {
                // bouton cliqué
                var button = (Button)sender;

                //Desactive le bouton
                button.Enabled = false;
                // on lui attribue une étiquette appelée playerShip
                button.Tag = "playerShip";
                // change la couleur en bleu
                button.BackColor = System.Drawing.Color.Blue;
                // -1 le nombre total de navires 
                totalShips--;
            }
            if (totalShips == 0)
            {//joueur a choisi les 3 positions 

                // Bouton attaQUE
                BtnAttaque.Enabled = true;
                //Couleur en rouge
                BtnAttaque.BackColor = System.Drawing.Color.Red;

                //changement emplacement aide
                Aide.Top = 55;
                Aide.Left = 230;
                Aide.Text = "Choisissez maintenant une position d'attaque dans la liste déroulante";
            }

        }

        private void EnnemyPosition(object sender, EventArgs e)
        {

            if (ListEmpEnnemis.Text != "")
            {
                // valeur de la liste deroulante select
                var attackPos = ListEmpEnnemis.Text;
                // changez la chaîne en minuscule pour qu'elle corresponde au nom du bouton
                attackPos = attackPos.ToLower();
                 //Position ennemie comparer a position choisie
                int index = positionEnnemi.FindIndex(a => a.Name == attackPos);
                

                
                if (positionEnnemi[index].Enabled && tours > 0)
                {
                    //tours -1
                    tours--;
                    NbTours.Text = "Tours " + tours;

                    if (positionEnnemi[index].Tag == "enemyship")
                    {
                        //desacr=tive le bouton
                        positionEnnemi[index].Enabled = false;
                        //Changer image fond par le feu
                        positionEnnemi[index].BackgroundImage = Properties.Resources.fireIcon;
                        //Changer couleur fond par du bleu foncé
                        positionEnnemi[index].BackColor = System.Drawing.Color.DarkBlue;
                        
                        playerTotalScore++;
                        
                        ScoreJoueur.Text = "" + playerTotalScore;
                        //lance le minuteur de l'ennemi
                        timerEnnemi.Start();
                    }
                    else
                    {
                        //SI pas bonne position 
                        //desactive bouton
                        positionEnnemi[index].Enabled = false;
                        // on change l'image d'arrière-plan pour l'icône de l'erreur
                        positionEnnemi[index].BackgroundImage = Properties.Resources.missIcon;
                        // change l'arrière-plan en bleu foncé
                        positionEnnemi[index].BackColor = System.Drawing.Color.DarkBlue;
                        // lance le minuteur de l'ennemi
                        timerEnnemi.Start();
                    }

                }


            }
            else
            {
                MessageBox.Show("Choisir un emplacement dans la liste ");
            }
        }

        private void ennemyAttackPlayer(object sender, EventArgs e)
        {

            if (playerPosition.Count > 0 && tours > 0)
            {

                tours--; // tour -1
                NbTours.Text = "Tours " + tours; 

                int index = rand.Next(playerPosition.Count); 


                if (playerPosition[index].Tag == "playerShip")
                {// si pos correct
                    //Changer photo en feu
                    playerPosition[index].BackgroundImage = Properties.Resources.fireIcon;

                    // bouton attaqué
                    MouvementEnnemi.Text = "" + playerPosition[index].Text;
                    //Désactive le bouton
                    playerPosition[index].Enabled = false;
                    //Changer couleur fond en bleu foncé
                    playerPosition[index].BackColor = System.Drawing.Color.DarkBlue;
                    //Suppr bouton de la liste joueur
                    playerPosition.RemoveAt(index);
                    // score +1
                    enemyTotalScore++;
                  
                    ScoreEnnemi.Text = "" + enemyTotalScore;
                    // Stop timmer
                    timerEnnemi.Stop();
                }
                else
                {// pos non ok

                    // afficher image croix
                    playerPosition[index].BackgroundImage = Properties.Resources.missIcon;
                    //bouton
                    MouvementEnnemi.Text = "" + playerPosition[index].Text;
                    // desactive bouton
                    playerPosition[index].Enabled = false;
                    //Changer couleur fond en bleu foncé
                    playerPosition[index].BackColor = System.Drawing.Color.DarkBlue;
                    //Suppr bouton de la liste joueur
                    playerPosition.RemoveAt(index);
                    //Stop timmer
                    timerEnnemi.Stop();
                }

            }

           
            if (tours < 1 || playerTotalScore > 2 || enemyTotalScore > 2)
            {
                if (playerTotalScore > enemyTotalScore)
                {
                    MessageBox.Show("Gagné");
                }
                if (playerTotalScore == enemyTotalScore)
                {
                    MessageBox.Show("Match nul");
                }
                if (enemyTotalScore > playerTotalScore)
                {
                    MessageBox.Show("Perdu");
                }
            }
        }

        private void ennemyPicksPositions(object sender, EventArgs e)
        {
            //Bouton aleatoire pos navires
            int index = rand.Next(positionEnnemi.Count);

            if (positionEnnemi[index].Enabled == true && positionEnnemi[index].Tag == null)
            {// si bouton activé + not balise
                positionEnnemi[index].Tag = "enemyship";
                // total ennemi -1
                totalenemy--;
                
              //  Debug.WriteLine("Pos E  " + positionEnnemi[index].Text);
            }
            else
            {
                index = rand.Next(positionEnnemi.Count);
            }
            if (totalenemy < 1)
            {//si 3 positions choisi stop timmer
                EnnemiPositionPicker.Stop();
            }

        }

       
    }
}
