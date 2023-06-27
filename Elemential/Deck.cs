namespace Elemential
{
    public class Deck
    {
        private Random randomChooser;
        private Stack<string> normalStack;
        private Stack<string> specialStack;
        private List<string> usedCards;
        private List<string> usedSpecialCards;

        public Deck()
        {
            randomChooser = new Random();
            normalStack = new Stack<string>();
            specialStack = new Stack<string>();
            usedCards = new List<string>();
            usedSpecialCards = new List<string>();

            int rand;
            List<string> normalDeck = NewNormalDeck();
            List<string> specialDeck = NewSpecialDeck();

            while (normalDeck.Count != 0)
            {
                rand = randomChooser.Next(0, normalDeck.Count);
                normalStack.Push(normalDeck[rand]);
                normalDeck.RemoveAt(rand);
            }

            while (specialDeck.Count != 0)
            {
                rand = randomChooser.Next(0, specialDeck.Count);
                specialStack.Push(specialDeck[rand]);
                specialDeck.RemoveAt(rand);
            }
        }

        public List<string> NewNormalDeck()
        {
            return new List<string> {
                "F1",
                "F2",
                "F3",
                "F4",
                "F5",
                "F6",
                "F7",
                "F1",
                "F2",
                "F3",
                "F4",
                "F5",
                "F6",
                "F7",
                "F10",
                "W1",
                "W2",
                "W3",
                "W4",
                "W5",
                "W6",
                "W7",
                "W1",
                "W2",
                "W3",
                "W4",
                "W5",
                "W6",
                "W7",
                "W10",
                "S1",
                "S2",
                "S3",
                "S4",
                "S5",
                "S6",
                "S7",
                "S1",
                "S2",
                "S3",
                "S4",
                "S5",
                "S6",
                "S7",
                "S10"
            };
        }

        public List<string> NewSpecialDeck()
        {
            return new List<string> {
                "Wind",
                "Wind",
                "Wind",
                "Energy",
                "Energy",
                "Energy",
                "Nature",
                "Nature",
                "Nature",
                "Sparkle",
                "Sparkle"
            };
        }

        public List<string> GetRandomDeck()
        {
            List<string> deck = new List<string>();

            for (int i = 0; i < 7; i++)
                deck.Add(normalStack.Pop());

            return deck;
        }

        public void AddUsedCard(string type, string card)
        {
            if (type == "N")
                usedCards.Add(card);
            else if (type == "S")
                usedSpecialCards.Add(card);
        }

        public string[] GetCard(int special)
        {
            if (normalStack.Count == 0)
            {
                while (usedCards.Count != 0)
                {
                    int rand = randomChooser.Next(0, usedCards.Count);
                    normalStack.Push(usedCards[rand]);
                    usedCards.RemoveAt(rand);
                }
            }
            if (specialStack.Count == 0)
            {
                while (usedSpecialCards.Count != 0)
                {
                    int rand = randomChooser.Next(0, usedSpecialCards.Count);
                    specialStack.Push(usedSpecialCards[rand]);
                    usedSpecialCards.RemoveAt(rand);
                }
            }

            if (special == 3 || randomChooser.Next(0, 3) != 0 || specialStack.Count == 0)
                return new string[] { "N", normalStack.Pop() };
            else
                return new string[] { "S", specialStack.Pop() };
        }
    }
}