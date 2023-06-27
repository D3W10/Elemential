using Elemential.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Elemential
{
    public partial class Game : Form
    {
        private int slotPage;
        private int opponentCards;
        private readonly char type;
        private string cardChoosen;
        private readonly Deck deck;
        private List<string> deckCards;
        private List<string> specialCards;
        private Thread thread;
        private readonly PictureBox[] pictureSlots;
        private readonly PictureBox[] oPictureSlots;

        public Game(char type)
        {
            InitializeComponent();

            slotPage = 0;
            opponentCards = 7;
            this.type = type;
            cardChoosen = null;
            deck = new Deck();
            pictureSlots = new PictureBox[] { pbSlot1, pbSlot2, pbSlot3, pbSlot4, pbSlot5, pbSlot6, pbSlot7, pbSlot8, pbSlot9 };
            oPictureSlots = new PictureBox[] { pbOSlot1, pbOSlot2, pbOSlot3, pbOSlot4, pbOSlot5, pbOSlot6, pbOSlot7, pbOSlot8, pbOSlot9 };

            lblPlayer.Text = type == 'H' ? "Jogador 1" : "Jogador 2";
        }

        private void Game_Load(object sender, EventArgs e)
        {
            if (type == 'H')
                thread = new Thread(HostThread);
            else if (type == 'J')
                thread = new Thread(ClientThread);

            thread.IsBackground = true;
            thread.Start();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Interrupt();
            Program.Listener?.Stop();
            Program.Client.Close();
        }

        private void EnterCard(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Location = new Point(pictureBox.Location.X, 431);
            if ((lblMyTurn.Visible && (pictureBox.Name == "pbSlot1" || pictureBox.Name == "pbSlot2" || pictureBox.Name == "pbSlot3")) || (!lblMyTurn.Visible && pictureBox.Name == "pbSlot1"))
            {
                lblPlayer.Location = new Point(lblPlayer.Location.X, 400);
                lblMyTurn.Location = new Point(lblMyTurn.Location.X, 400);
            }
        }

        private void LeaveCard(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Location = new Point(pictureBox.Location.X, 451);
            if ((lblMyTurn.Visible && (pictureBox.Name == "pbSlot1" || pictureBox.Name == "pbSlot2" || pictureBox.Name == "pbSlot3")) || (!lblMyTurn.Visible && pictureBox.Name == "pbSlot1"))
            {
                lblPlayer.Location = new Point(lblPlayer.Location.X, 420);
                lblMyTurn.Location = new Point(lblMyTurn.Location.X, 420);
            }
        }

        private void UpdateSlots(int page)
        {
            int startSize = 9 * page, pageSize = deckCards.Count <= 9 * (page + 1) ? deckCards.Count : 9 * (page + 1);

            SetControlVisibility(btnForward, false);
            SetControlVisibility(btnBack, false);

            foreach (PictureBox pb in pictureSlots)
                RemoveCardSlots(pb);

            for (int i = startSize; i < pageSize; i++)
                CardSlotUpdate(pictureSlots[i - 9 * page], deckCards, i);

            if (pageSize != deckCards.Count)
                SetControlVisibility(btnForward, true);
            if (startSize != 0)
                SetControlVisibility(btnBack, true);
        }

        private void UpdateOpponentSlots(int opponent)
        {
            foreach (PictureBox pb in oPictureSlots)
                SetControlVisibility(pb, false);

            for (int i = 0; i < opponent; i++)
            {
                if (i >= oPictureSlots.Length)
                    break;
                SetControlVisibility(oPictureSlots[i], true);
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            UpdateSlots(++slotPage);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UpdateSlots(--slotPage);
        }

        private void CardClick(object sender, EventArgs e)
        {
            if (lblMyTurn.Visible)
            {
                int slotIndex = Array.IndexOf(pictureSlots, sender);
                cardChoosen = ((PictureBox)sender).Tag.ToString();

                lblPlayer.Location = new Point(lblPlayer.Location.X, 420);
                lblMyTurn.Location = new Point(lblMyTurn.Location.X, 420);

                if (deck.NewSpecialDeck().Contains(((PictureBox)sender).Tag.ToString()))
                {
                    specialCards.RemoveAt(slotIndex);
                    specialCards.RemoveAt(specialCards.Count - 1);
                    deck.AddUsedCard("S", ((PictureBox)sender).Tag.ToString());
                }
                else if (((PictureBox)sender).Tag.ToString() == "No")
                    specialCards.RemoveAt(slotIndex);
                else
                {
                    deckCards.RemoveAt(slotIndex);
                    deck.AddUsedCard("N", ((PictureBox)sender).Tag.ToString());
                }

                UpdateSlots(0);
            }
        }

        private char CalculateRoundWinner(string host, string client, string hostS, string clientS)
        {
            int cardNumberH = Convert.ToInt32(host.Replace(host[0].ToString(), "")), cardNumberC = Convert.ToInt32(client.Replace(client[0].ToString(), ""));
            char cardTypeH = host[0], cardTypeC = client[0];

            Dictionary<char, char> wins = new() { ['F'] = 'S', ['S'] = 'W', ['W'] = 'F' };

            if (hostS == "Wind" || clientS == "Wind")
                wins = new Dictionary<char, char>() { ['F'] = 'W', ['S'] = 'F', ['W'] = 'S' };
            if (hostS == "Sparkle")
                return 'H';
            if (clientS == "Sparkle")
                return 'C';

            if (wins[cardTypeH] == cardTypeC)
                return 'H';
            else if (wins[cardTypeC] == cardTypeH)
                return 'C';
            else
            {
                if (cardNumberH > cardNumberC)
                    return 'H';
                else if (cardNumberH < cardNumberC)
                    return 'C';
                else
                    return 'E';
            }
        }

        private void SpecialSlots()
        {
            btnForward.Visible = false;
            btnBack.Visible = false;

            foreach (PictureBox pb in pictureSlots)
                RemoveCardSlots(pb);

            specialCards.Add("No");
            for (int i = 0; i < specialCards.Count; i++)
                CardSlotUpdate(pictureSlots[i], specialCards, i);
        }

        private void UpdateSprites(bool mode, string card)
        {
            if (mode)
            {
                if (card == "Energy")
                    SetControlVisibility(pbEnergy, true);
                else if (card == "Wind")
                    SetControlVisibility(pbWind, true);
                else if (card == "Nature")
                    SetControlVisibility(pbNature, true);
                else if (card == "Sparkle")
                    SetControlVisibility(pbSparkle, true);
            }
            else
            {
                SetControlVisibility(pbEnergy, false);
                SetControlVisibility(pbWind, false);
                SetControlVisibility(pbNature, false);
                SetControlVisibility(pbSparkle, false);
            }
        }

        private void EnergySpecial(PictureBox pb)
        {
            string cardTag = pb.Tag.ToString();

            if (cardTag[1..] == "10")
                cardTag = cardTag[0] + "7";
            else if (cardTag[1..] == "2")
                cardTag = cardTag[0] + "1";
            else if (cardTag[1..] != "1")
                cardTag = cardTag[0] + (Convert.ToInt32(cardTag[1..]) - 2).ToString();

            SetPictureBoxImage(pb, cardTag);
        }

        #region Delegates

        private delegate void SetControlLocationCallback(Control control, Point point);

        private void SetControlLocation(Control control, Point point)
        {
            if (InvokeRequired)
                Invoke(new SetControlLocationCallback(SetControlLocation), new object[] { control, point });
            else
                control.Location = point;
        }

        private delegate void RemoveCardSlotsCallback(PictureBox pb);

        private void RemoveCardSlots(PictureBox pb)
        {
            if (InvokeRequired)
                Invoke(new RemoveCardSlotsCallback(RemoveCardSlots), new object[] { pb });
            else
            {
                pb.Visible = false;
                pb.Location = new Point(pb.Location.X, 451);
            }
        }

        private delegate void CardSlotUpdateCallback(PictureBox pb, List<string> cards, int i);

        private void CardSlotUpdate(PictureBox pb, List<string> cards, int i)
        {
            if (InvokeRequired)
                Invoke(new CardSlotUpdateCallback(CardSlotUpdate), new object[] { pb, cards, i });
            else
            {
                pb.Visible = true;
                pb.Image = Resources.ResourceManager.GetObject(cards[i]) as Bitmap;
                pb.Tag = cards[i];
                pb.BringToFront();
            }
        }

        private delegate void SetControlVisibilityCallback(Control control, bool visibility);

        private void SetControlVisibility(Control control, bool visibility)
        {
            if (InvokeRequired)
                Invoke(new SetControlVisibilityCallback(SetControlVisibility), new object[] { control, visibility });
            else
                control.Visible = visibility;
        }

        private delegate void SetPictureBoxImageCallback(PictureBox control, string image);

        private void SetPictureBoxImage(PictureBox control, string image)
        {
            if (InvokeRequired)
                Invoke(new SetPictureBoxImageCallback(SetPictureBoxImage), new object[] { control, image });
            else
            {
                control.Image = image != null ? Resources.ResourceManager.GetObject(image) as Bitmap : null;
                control.Tag = image;
            }
        }

        private delegate void FinishAndCloseCallback(bool win);

        private void FinishAndClose(bool win)
        {
            if (InvokeRequired)
                Invoke(new FinishAndCloseCallback(FinishAndClose), new object[] { win });
            else
            {
                new Finish(win).ShowDialog();
                Close();
            }
        }

        #endregion

        #region Host/Client calls

        private void HostThread()
        {
            try
            {
                StreamWriter networkWriter = new(Program.Client.GetStream());
                StreamReader networkReader = new(Program.Client.GetStream());

                networkReader.ReadLine();
                deckCards = deck.GetRandomDeck();
                specialCards = new List<string>();
                UpdateSlots(slotPage);
                UpdateOpponentSlots(opponentCards);
                networkWriter.WriteLine(string.Join(",", deck.GetRandomDeck()));
                networkWriter.Flush();

                while (deckCards.Count != 0 && opponentCards != 0)
                {
                    SetControlVisibility(lblMyTurn, true);
                    while (cardChoosen == null)
                        continue;

                    networkWriter.WriteLine(cardChoosen);
                    networkWriter.Flush();
                    SetPictureBoxImage(pbMe, cardChoosen);
                    SetControlVisibility(lblMyTurn, false);

                    string clientCard = networkReader.ReadLine();
                    SetPictureBoxImage(pbOpponent, "Card");
                    UpdateOpponentSlots(--opponentCards);

                    cardChoosen = null;
                    Thread.Sleep(2000);
                    SetPictureBoxImage(pbOpponent, clientCard);

                    string hostSpecialCard = "No", clientSpecialCard;
                    char currentWinner = CalculateRoundWinner(pbMe.Tag.ToString(), pbOpponent.Tag.ToString(), null, null);
                    if (specialCards.Count != 0)
                    {
                        SetControlVisibility(lblMyTurn, true);

                        if (currentWinner == 'H')
                        {
                            btnMe.BackColor = Color.FromArgb(255, 106, 188, 140);
                            pbMe.BackColor = Color.FromArgb(255, 106, 188, 140);
                        }
                        else if (currentWinner == 'C')
                        {
                            btnOpponent.BackColor = Color.FromArgb(255, 106, 188, 140);
                            pbOpponent.BackColor = Color.FromArgb(255, 106, 188, 140);
                        }

                        SpecialSlots();
                        while (cardChoosen == null)
                            continue;
                        hostSpecialCard = cardChoosen;
                        cardChoosen = null;

                        btnMe.BackColor = SystemColors.Control;
                        pbMe.BackColor = SystemColors.Control;
                        btnOpponent.BackColor = SystemColors.Control;
                        pbOpponent.BackColor = SystemColors.Control;
                        SetControlVisibility(lblMyTurn, false);

                        UpdateSprites(true, hostSpecialCard);

                        if (hostSpecialCard == "Energy")
                            EnergySpecial(pbOpponent);
                    }
                    networkWriter.WriteLine(hostSpecialCard);
                    networkWriter.Flush();
                    networkWriter.WriteLine(currentWinner);
                    networkWriter.Flush();

                    clientSpecialCard = networkReader.ReadLine();
                    UpdateSprites(true, clientSpecialCard);

                    if (clientSpecialCard == "Energy")
                        EnergySpecial(pbMe);
                    else if (clientSpecialCard == "Nature")
                    {
                        deckCards.Add(deck.GetCard(3)[1]);
                        deckCards.Add(deck.GetCard(3)[1]);
                    }

                    char winner = CalculateRoundWinner(pbMe.Tag.ToString(), pbOpponent.Tag.ToString(), hostSpecialCard, clientSpecialCard);
                    networkWriter.WriteLine(winner);
                    networkWriter.Flush();
                    if (winner == 'H')
                    {
                        SetPictureBoxImage(pbWinLose, "Trophy");
                        networkWriter.WriteLine(string.Join(",", deck.GetCard(Convert.ToInt32(networkReader.ReadLine()))));
                        networkWriter.Flush();
                    }
                    else
                    {
                        SetPictureBoxImage(pbWinLose, "Bang");

                        string[] newCard = deck.GetCard(specialCards.Count);
                        if (newCard[0] == "N")
                            deckCards.Add(newCard[1]);
                        else if (newCard[0] == "S")
                            specialCards.Add(newCard[1]);
                    }

                    Thread.Sleep(4000);
                    SetPictureBoxImage(pbMe, "Place");
                    SetPictureBoxImage(pbOpponent, "Place");
                    SetPictureBoxImage(pbWinLose, null);

                    UpdateSprites(false, null);

                    networkWriter.WriteLine(deckCards.Count);
                    networkWriter.Flush();
                    opponentCards = Convert.ToInt32(networkReader.ReadLine());
                    UpdateOpponentSlots(opponentCards);
                    UpdateSlots(0);
                }

                Program.Client.Close();
                Program.Listener.Stop();
                FinishAndClose(deckCards.Count == 0);
            }
            catch (ThreadInterruptedException)
            {
                Program.Client.Close();
                Program.Listener.Stop();
            }
            catch (FormatException)
            {
                Program.Client.Close();
                Program.Listener.Stop();
            }
        }

        private void ClientThread()
        {
            try
            {
                StreamWriter networkWriter = new(Program.Client.GetStream());
                StreamReader networkReader = new(Program.Client.GetStream());

                deckCards = new List<string>();
                specialCards = new List<string>();
                networkWriter.WriteLine("READY");
                networkWriter.Flush();
                foreach (string card in networkReader.ReadLine().Split(','))
                    deckCards.Add(card);
                UpdateSlots(slotPage);
                UpdateOpponentSlots(opponentCards);

                while (deckCards.Count != 0 && opponentCards != 0)
                {
                    string hostCard = networkReader.ReadLine();
                    SetPictureBoxImage(pbOpponent, "Card");
                    UpdateOpponentSlots(--opponentCards);

                    SetControlVisibility(lblMyTurn, true);
                    while (cardChoosen == null)
                        continue;
                    networkWriter.WriteLine(cardChoosen);
                    networkWriter.Flush();
                    SetPictureBoxImage(pbMe, cardChoosen);
                    SetControlVisibility(lblMyTurn, false);

                    cardChoosen = null;
                    Thread.Sleep(2000);
                    SetPictureBoxImage(pbOpponent, hostCard);

                    string clientSpecialCard = "No", hostSpecialCard = networkReader.ReadLine();
                    char currentWinner = Convert.ToChar(networkReader.ReadLine());

                    UpdateSprites(true, hostSpecialCard);

                    if (hostSpecialCard == "Energy")
                        EnergySpecial(pbMe);
                    else if (hostSpecialCard == "Nature")
                    {
                        deckCards.Add(deck.GetCard(3)[1]);
                        deckCards.Add(deck.GetCard(3)[1]);
                    }

                    if (specialCards.Count != 0)
                    {
                        SetControlVisibility(lblMyTurn, true);

                        if (currentWinner == 'C')
                        {
                            btnMe.BackColor = Color.FromArgb(255, 106, 188, 140);
                            pbMe.BackColor = Color.FromArgb(255, 106, 188, 140);
                        }
                        else if (currentWinner == 'H')
                        {
                            btnOpponent.BackColor = Color.FromArgb(255, 106, 188, 140);
                            pbOpponent.BackColor = Color.FromArgb(255, 106, 188, 140);
                        }

                        SpecialSlots();
                        while (cardChoosen == null)
                            continue;
                        clientSpecialCard = cardChoosen;
                        cardChoosen = null;

                        btnMe.BackColor = SystemColors.Control;
                        pbMe.BackColor = SystemColors.Control;
                        btnOpponent.BackColor = SystemColors.Control;
                        pbOpponent.BackColor = SystemColors.Control;
                        SetControlVisibility(lblMyTurn, false);

                        UpdateSprites(true, clientSpecialCard);

                        if (clientSpecialCard == "Energy")
                            EnergySpecial(pbOpponent);
                    }
                    networkWriter.WriteLine(clientSpecialCard);
                    networkWriter.Flush();

                    char winner = Convert.ToChar(networkReader.ReadLine());
                    if (winner == 'C')
                        SetPictureBoxImage(pbWinLose, "Trophy");
                    else
                    {
                        SetPictureBoxImage(pbWinLose, "Bang");
                        networkWriter.WriteLine(specialCards.Count);
                        networkWriter.Flush();

                        string[] newCard = networkReader.ReadLine().Split(',');
                        if (newCard[0] == "N")
                            deckCards.Add(newCard[1]);
                        else if (newCard[0] == "S")
                            specialCards.Add(newCard[1]);
                    }

                    Thread.Sleep(4000);
                    SetPictureBoxImage(pbMe, "Place");
                    SetPictureBoxImage(pbOpponent, "Place");
                    SetPictureBoxImage(pbWinLose, null);

                    UpdateSprites(false, null);

                    opponentCards = Convert.ToInt32(networkReader.ReadLine());
                    UpdateOpponentSlots(opponentCards);
                    networkWriter.WriteLine(deckCards.Count);
                    networkWriter.Flush();
                    UpdateSlots(0);
                }

                Program.Client.Close();
                FinishAndClose(deckCards.Count == 0);
            }
            catch (ThreadInterruptedException)
            {
                Program.Client.Close();
            }
            catch (FormatException)
            {
                Program.Client.Close();
            }
        }

        #endregion

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
    }
}