using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //variabili globali
        string nomeG1, nomeG2;
        bool turnoG1;
        static int cs = 0, C = 0, javascript = 0, python = 0;
        int[] quantitàgenerate = new int[4] { cs, C, javascript, python };
        bool[] selezioneCarte = new bool[8];
        string[] fioriGenerati = new string[8];
        PictureBox[] carte = new PictureBox[8];
        int carteselezionate = 0, card1 = 0, card2 = 0, coppiecarteG1 = 0, coppiecarteG2 = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            creazioneFile();
        }
        //controlla che il file della esista sennò viene creato
        private void creazioneFile()
        {
            string posizione_file = AppDomain.CurrentDomain.BaseDirectory + "Classifica.txt";
            if (!File.Exists(posizione_file))
            {
                File.Create(posizione_file);
            }
            GenerazioneCarte();
        }

        //genera le carte randomicamente
        private void GenerazioneCarte()
        {
            Random generatore = new Random();
            int numerogen = 0;
            for (int i = 0; i < 8; i++)
            {
                numerogen = generatore.Next(0, 4);
                AumentoConteggioCarte(numerogen);
                if (i > 1 && controllo(numerogen) == -1)
                {
                    i--;
                }
                else
                {
                    //crea una carta con rispettivo sfondo e 
                    fioriGenerati[i] = AssegnazioneCarte(numerogen);
                }

            }
            AssegnazioneSfondiCarte();
            NascondiOggetti();
        }
        //serve per generare randomicamente il giocatore che dovrà iniziare
        private void SelezionePrimoGiocatore()
        {
            Random selezione = new Random();
            int turno = selezione.Next(0, 2);
            if (turno == 0)//inizia il giocatore 1 
            {
                turnoG1 = true;
                this.BackColor = Color.Blue;
                label1.Text = "E' il turno di " + nomeG1;
            }
            else //inizia il giocatore 2
            {
                turnoG1 = false;
                this.BackColor = Color.Red;
                label1.Text = "E' il turno di " + nomeG2;
            }
        }
        //se il tipo della carta è stato generato più di due volte, fa ripetere la generazione della carta
        private int controllo(int valore)
        {
            if (quantitàgenerate[valore] == 3)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        //aumenta la variabile che contiene il tipo di carta estratto e se più di due non viene aumentetao
        private void AumentoConteggioCarte(int numero)
        {
            if (quantitàgenerate[numero] < 3)
            {
                quantitàgenerate[numero]++;
            }
        }
        //in base al numero estratto restituisce il tipocarta corrispondente
        private string AssegnazioneCarte(int indice)
        {
            string tipocarta = "";
            switch (indice)
            {
                case 0:
                    tipocarta = "cs";
                    break;
                case 1:
                    tipocarta = "C";
                    break;
                case 2:
                    tipocarta = "javascript";
                    break;
                case 3:
                    tipocarta = "python";
                    break;
            };
            return tipocarta;
        }
        //salva le picturebox all'interno di un array e a ciascuna viene assegnato l'immagine
        private void AssegnazioneSfondiCarte()
        {
            carte[0] = carta1;
            carte[1] = carta2;
            carte[2] = carta3;
            carte[3] = carta4;
            carte[4] = carta5;
            carte[5] = carta6;
            carte[6] = carta7;
            carte[7] = carta8;
            for (int i = 0; i < carte.Length; i++)
            {
                carte[i].Image = Properties.Resources.sfondo_carta;
            }
        }
        private void NascondiOggetti()
        {
            for (int i = 0; i < carte.Length; i++)
            {
                carte[i].Visible = false;
            }
            ncoppieG1lbl.Visible = false;
            ncoppieG2lbl.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            textBox2.Visible = false;
            button2.Visible = false;
            backtostartbtn.Visible = false;
            restartbtn.Visible = false;
        }
        //in base alla carta premuta, essa viene gira
        private void CartaClick(int n1)
        {
            n1 -= 1;
            if(selezioneCarte[n1] == false)
            {
                carte[n1].Image = creazioneimmagine(n1);
                selezioneCarte[n1] = true;
                ControlloCoppie(n1);
            }
        }
        //se le carte selezionate sono un multiplo di 2 vengono controllate per vedere se le carte selezionate
        //formano una coppia oppure siano diverse, rigirandole e passando il turno all'altro giocatore
        private void ControlloCoppie(int indicecarta)
        {
            carteselezionate++;
            if(carteselezionate % 2 == 0)
            {
                card2 = indicecarta;
                if(fioriGenerati[card1] != fioriGenerati[card2])
                {
                    selezioneCarte[card1] = false;
                    selezioneCarte[card2] = false;
                    wait(500);
                    carteselezionate -= 2;
                    carte[card1].Image = Properties.Resources.sfondo_carta;
                    carte[card2].Image = Properties.Resources.sfondo_carta;
                    CambiaTurno();
                }
                else
                {
                    if (turnoG1)
                    {
                        coppiecarteG1++;
                        ncoppieG1lbl.Text = nomeG1 + ":\n" + Convert.ToString(coppiecarteG1);
                    }
                    else
                    {
                        coppiecarteG2++;
                        ncoppieG2lbl.Text = nomeG2 + ":\n" + Convert.ToString(coppiecarteG2);
                    }
                }
            }
            else
            {
                card1 = indicecarta;
            }
            if (carteselezionate == 8)//se sono state formate tutte le coppie il gioco finisce
            {
                this.BackColor = Color.Green;
                if (coppiecarteG1 > coppiecarteG2)
                {
                    MessageBox.Show("Il vincitore della partita è:\n" + nomeG1);
                    label1.Text = "Ha vinto: " + nomeG1;
                    SalvaVittoria(nomeG1);
                }
                else if (coppiecarteG1 < coppiecarteG2)
                {
                    MessageBox.Show("Il vincitore della partita è:\n " + nomeG2);
                    label1.Text = "Ha vinto: " + nomeG2;
                    SalvaVittoria(nomeG2);
                }
                else
                {
                    MessageBox.Show("Nessuno dei due giocatori ha vinto");
                    label1.Text = "Pareggio";
                    MostraBottoni();
                }
            }
        }
        public void wait(int milliseconds)
        {
            //crea un oggetto Timer
            var timer1 = new System.Windows.Forms.Timer();
            //controlla che il valore dei millisecondi non sia 0 o minore di 0
            if (milliseconds == 0 || milliseconds < 0) return;

            // inizia il timer
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            //controlla se il valore inserito in millisecondi è trascorso
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // finisce il timer
            };

            while (timer1.Enabled)//permette di elaborare le azioni che il form riceve
            {
                Application.DoEvents();
            }
        }
        //assegna alla picturebox, l'immagine corrispondente in base al valore dell'array dei tipi di carte corrispondente
        private System.Drawing.Image creazioneimmagine(int indice)
        {
            if(fioriGenerati[indice] == "cs")
            {
                return Properties.Resources.cs;
            }
            else if (fioriGenerati[indice] == "C")
            {
                return Properties.Resources.C;
            }
            else if (fioriGenerati[indice] == "javascript")
            {
                return Properties.Resources.javascript;
            }
            else
            {
                return Properties.Resources.python;
            }
        }
        //
        private void CambiaTurno()
        {
            if (turnoG1)
            {
                turnoG1 = false;
                this.BackColor = Color.Red;
                label1.Text = "E' il turno di: \n" + nomeG2;
            }
            else
            {
                turnoG1 = true;
                this.BackColor = Color.Blue;
                label1.Text = "E' il turno di: \n" + nomeG1;
            }
        }

        //crea un'altro form2 per ricomniare la partita
        private void backtostartbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SchermataPrincipale f1 = new SchermataPrincipale();
            f1.ShowDialog();
        }

        //per riavviare la partita viene creato un nuovo Form2 chiudendo quello appena usato
        private void restartbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        //Controllo il contenuto della textbox non sia vuoto e che non contenga nessuna virgola
        private void button1_Click(object sender, EventArgs e)
        {
            nomeG1 = textBox1.Text;
            if (nomeG1 == ""|| nomeG1.Contains(",") || nomeG1.Contains(" ") || nomeG1.Length > 10)
            {
                MessageBox.Show(" Prima di continuare,\n inserisci un nome che abbia queste caratteristiche: \n non contenga virgole \n non sia vuoto \n non contenga spazi");
            }
            else
            {
                label3.Visible = true;
                textBox2.Visible = true;
                button2.Visible = true;
                label2.Visible = false;
                textBox1.Visible = false;
                button1.Visible = false;
            }
        }

        //Controllo il contenuto della textbox non sia vuoto ,che sia diverso dal nome del primo giocatore e che non contenga nessuna virgola
        private void button2_Click(object sender, EventArgs e)
        {
            nomeG2 = textBox2.Text;
            if (nomeG2 == "" || nomeG2.Contains(",") || nomeG2.Contains(" ") || nomeG2 == nomeG1 || nomeG2.Length > 10)
            {
                MessageBox.Show(" Prima di continuare,\n inserisci un nome che abbia queste caratteristiche: \n non contenga virgole \n non sia vuoto \n non contenga spazi \n sia diverso dal nome del primo giocatore");
            }
            else
            {
                for (int i = 0; i < carte.Length; i++)
                {
                    carte[i].Visible = true;
                }
                SelezionePrimoGiocatore();
                label1.Visible = true;
                label3.Visible = false;
                textBox2.Visible = false;
                button2.Visible = false;
                ncoppieG1lbl.Text = nomeG1 + ":\n" + Convert.ToString(coppiecarteG1);
                ncoppieG1lbl.Visible = true;
                ncoppieG2lbl.Text = nomeG2 + ":\n" + Convert.ToString(coppiecarteG2);
                ncoppieG2lbl.Visible = true;
            }
        }

        private void MostraBottoni()
        {
            backtostartbtn.Visible = true;
            restartbtn.Visible = true;
        }
        //in base alla carta che viene cliccata
        //viene richiamata la funzione assegnandoli l'indice di quale carta girare nell'array di picturebox
        private void carta1_Click(object sender, EventArgs e)
        {
            CartaClick(1);
        }

        private void carta2_Click(object sender, EventArgs e)
        {
            CartaClick(2);
        }

        private void carta3_Click(object sender, EventArgs e)
        {
            CartaClick(3);
        }

        private void carta4_Click(object sender, EventArgs e)
        {
            CartaClick(4);
        }

        private void carta5_Click(object sender, EventArgs e)
        {
            CartaClick(5);
        }

        private void carta6_Click(object sender, EventArgs e)
        {
            CartaClick(6);
        }

        private void carta7_Click(object sender, EventArgs e)
        {
            CartaClick(7);
        }
        //Image[] immaginicarte = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory)
        private void carta8_Click(object sender, EventArgs e)
        {
            CartaClick(8);
        }
        //se il giocatore che ha vinto era già presente nel file, gli viene aggiunta una vittoria
        //altrimenti viene salvato come nuovo giocatore
        private void SalvaVittoria(string nomevincitore)
        {
            string posizione_file = AppDomain.CurrentDomain.BaseDirectory + "Classifica.txt";
            string[] giocatorifile = File.ReadAllLines(posizione_file);
            bool salvataggio = false;
            for(int i= 0; i < 3 && salvataggio == false; i++)
            {
                switch (i)
                {
                    case 0:
                        for (int c = 0; c < giocatorifile.Length; c++)
                        {

                            string[] playerfile = giocatorifile[c].Split(',');
                            if (playerfile[0] == nomevincitore)
                            {
                                int vittorie = Convert.ToInt32(playerfile[1]) + 1;
                                playerfile[1] = Convert.ToString(vittorie);
                                giocatorifile[c] = playerfile[0] + "," + playerfile[1];
                                c = giocatorifile.Length - 1;
                                salvataggio = true;
                            }
                        }
                        break;
                    case 1:
                        string persona = nomevincitore + ",1";
                        Array.Resize(ref giocatorifile, giocatorifile.Length + 1);
                        giocatorifile[giocatorifile.Length - 1] = persona;
                        salvataggio = true;
                        break; 
                };
            }
            File.WriteAllLines(posizione_file, giocatorifile);
            RiordinaArray();
        }
        //tramite bubble sort riordino i giocatori in ordine decrescente in base al numero di vittorie
        //e dopo viene salvato nel file
        private void RiordinaArray()
        {
            string posizione_file = AppDomain.CurrentDomain.BaseDirectory + "Classifica.txt";
            string[] array = File.ReadAllLines(posizione_file);
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    string[] g1 = array[j].Split(',');
                    string[] g2 = array[j + 1].Split(',');
                    if (Int32.Parse(g1[1]) < Int32.Parse(g2[1]))
                    {
                        var t = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = t;
                    }
                }

            }
            File.WriteAllLines(posizione_file, array);
            MostraBottoni();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
