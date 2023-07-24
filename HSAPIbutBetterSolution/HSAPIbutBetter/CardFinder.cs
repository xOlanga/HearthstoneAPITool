using System;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics.Tracing;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Text.Json;
using System.Linq;
using System.Reflection;
using System.Text;
using HearthDb;
using HearthDb.Deckstrings;
using HearthDb.Enums;
using Newtonsoft.Json.Linq;




namespace HSAPIbutBetter
{
    public partial class CardFinder : Form
    {
        private List<CardData> cardDataList; // List to store the loaded card data


        public CardFinder()
        {
            InitializeComponent();
            LoadAllCards();
        }


        private void LoadAllCards()
        {
            string fileName = "CardData.json";

            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                cardDataList = JsonConvert.DeserializeObject<List<CardData>>(json);
            }
            else
            {
                cardDataList = new List<CardData>();
            }
        }

        private static void WriteToFile(string json, string fileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(json);
                }
            }
            catch (Exception exp)
            {
                Console.Write(exp.Message);
            }
        }

        private static async Task<string> GetCardContents()
        {
            string url = "https://api.hearthstonejson.com/v1/latest/enUS/cards.json";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        // Handle unsuccessful response (e.g., return null or throw an exception)
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during the HTTP request
                    return null;
                }
            }
        }

        private string GetPropertyNameFromCheckbox(string checkboxText)
        {
            switch (checkboxText)
            {
                case "Artist":
                    return "artist";
                case "Attack":
                    return "attack";
                case "Class":
                    return "cardClass";
                case "Cost":
                    return "cost";
                case "DbfID":
                    return "dbfId";
                case "Flavor":
                    return "flavor";
                case "Health":
                    return "health";
                case "ID":
                    return "id";
                case "Mechanics":
                    return "mechanics";
                case "Name":
                    return "name";
                case "Races":
                    return "races";
                case "Rarity":
                    return "rarity";
                case "Set":
                    return "set";
                case "Spell School":
                    return "spellSchool";
                case "Type":
                    return "type";
                case "Text":
                    return "text";
                default:
                    return string.Empty;
            }
        }

        private CardData SearchCardByName(string name)
        {
            if (cardDataList != null)
            {
                // Perform the case-insensitive search for the card with the specified name
                CardData card = cardDataList.Find(c => string.Equals(c.name, name, StringComparison.OrdinalIgnoreCase));
                return card;
            }
            else
            {
                return null; // Handle the case when cardDataList is null
            }
        }


        private void CardFinder_Load(object sender, EventArgs e)
        {

        }

        private async void UpdateDataButton_Click_1(object sender, EventArgs e)
        {
            {
                string json = await GetCardContents();
                // Parse the JSON array
                var cards = System.Text.Json.JsonSerializer.Deserialize<List<CardData>>(json);

                // Filter out cards from the "BATTLEGROUNDS" set "Story_
                cardDataList = cards.Where(c => c.set != "BATTLEGROUNDS" && !c.id.Contains("Story") && Regex.IsMatch(c.id, @"\b\w{2,3}_\d{3}\b")).ToList();
                // Serialize the parsed cards back to a formatted JSON string
                string formattedJson = System.Text.Json.JsonSerializer.Serialize(cardDataList, new JsonSerializerOptions { WriteIndented = true });

                Console.WriteLine(formattedJson);
                WriteToFile(formattedJson, "CardData.json");
            }
        }

        private void FindDataButton_Click_1(object sender, EventArgs e)
        {
            string cardName = CardNameTextBox.Text;

            // Search for the card with the specified name
            CardData card = SearchCardByName(cardName);

            // Display the results in the ResultsOutput TextBox
            if (card != null)
            {
                List<string> selectedInformation = InformationCheckboxes.CheckedItems.Cast<ListViewItem>()
                    .Select(item => item.Text)
                    .ToList();

                StringBuilder resultBuilder = new StringBuilder();

                // Define the desired order of the information
                List<string> desiredOrder = new List<string>
                {
                    "Name",
                    "ID",
                    "DbfID",
                    "Class",
                    "Type",
                    "Cost",
                    "Set",
                    "Races",
                    "Spell School",
                    "Rarity",
                    "Attack",
                    "Health",
                    "Artist",
                    "Mechanics",
                    "Text",
                    "Flavor"
                };

                foreach (string information in desiredOrder)
                {
                    if (selectedInformation.Contains(information))
                    {
                        switch (information)
                        {
                            case "Name":
                                if (!string.IsNullOrEmpty(card.name))
                                    resultBuilder.AppendLine($"Card Name: {card.name}");
                                break;
                            case "ID":
                                if (!string.IsNullOrEmpty(card.id))
                                    resultBuilder.AppendLine($"Card ID: {card.id}");
                                break;
                            case "DbfID":
                                resultBuilder.AppendLine($"Card DbfID: {card.dbfId.ToString()}");
                                break;
                            case "Class":
                                if (!string.IsNullOrEmpty(card.cardClass))
                                    resultBuilder.AppendLine($"Card Class: {card.cardClass}");
                                break;
                            case "Type":
                                if (!string.IsNullOrEmpty(card.type))
                                    resultBuilder.AppendLine($"Card Type: {card.type}");
                                break;
                            case "Cost":
                                resultBuilder.AppendLine($"Card Cost: {card.cost}");
                                break;
                            case "Set":
                                if (!string.IsNullOrEmpty(card.set))
                                    resultBuilder.AppendLine($"Card Set: {card.set}");
                                break;
                            case "Races":
                                if (card.races != null && card.races.Any())
                                    resultBuilder.AppendLine($"Card Races: {string.Join(", ", card.races)}");
                                break;
                            case "Spell School":
                                if (!string.IsNullOrEmpty(card.spellSchool))
                                    resultBuilder.AppendLine($"Card Spell School: {card.spellSchool}");
                                break;
                            case "Rarity":
                                if (!string.IsNullOrEmpty(card.rarity))
                                    resultBuilder.AppendLine($"Card Rarity: {card.rarity}");
                                break;
                            case "Attack":
                                if (card.type == "SPELL")
                                    resultBuilder.AppendLine("Card Attack: N/A (Spell)");
                                if (card.type == "LOCATION")
                                {
                                    resultBuilder.AppendLine("Card Attack: N/A (Location)");
                                }
                                else if (card.attack.HasValue)
                                    resultBuilder.AppendLine($"Card Attack: {card.attack}");
                                break;
                            case "Health":
                                if (card.type == "SPELL")
                                {
                                    resultBuilder.AppendLine("Card Health: N/A (Spell)");
                                }
                                else if (card.type == "WEAPON" || card.type == "LOCATION")
                                {
                                    if (card.health.HasValue)
                                        resultBuilder.AppendLine($"Card Durability: {card.health}");
                                }
                                else
                                {
                                    if (card.health.HasValue)
                                        resultBuilder.AppendLine($"Card Health: {card.health}");
                                }
                                break;
                            case "Artist":
                                if (!string.IsNullOrEmpty(card.artist))
                                    resultBuilder.AppendLine($"Card Artist: {card.artist}");
                                break;
                            case "Mechanics":
                                if (card.mechanics != null && card.mechanics.Any())
                                    resultBuilder.AppendLine($"Card Mechanics: {string.Join(", ", card.mechanics)}");
                                break;
                            case "Text":
                                if (!string.IsNullOrEmpty(card.text))
                                    resultBuilder.AppendLine($"Card Text: {card.text}");
                                break;
                            case "Flavor":
                                if (!string.IsNullOrEmpty(card.flavor))
                                    resultBuilder.AppendLine($"Card Flavor: {card.flavor}");
                                break;
                        }
                    }
                }

                ResultsOutput.Text = resultBuilder.ToString();
            }
            else
            {
                ResultsOutput.Text = "Card not found.";
            }
        }

        private void CardNameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            // Clear the ResultsOutput TextBox when the card name input changes
            ResultsOutput.Clear();
        }

        private void InformationCheckboxes_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void SelectAllCheckbox_CheckedChanged_1(object sender, EventArgs e)
        {
            bool isChecked = SelectAllCheckbox.Checked;

            foreach (ListViewItem item in InformationCheckboxes.Items)
            {
                item.Checked = isChecked;
            }
        }

        private void ResultsOutput_TextChanged_1(object sender, EventArgs e)
        {
            ResultsOutput.SelectionStart = ResultsOutput.Text.Length;
            ResultsOutput.ScrollToCaret();
        }

        //--------------DECK SECTION-------------
       

        private async void UpdateDataButtonDeck_Click(object sender, EventArgs e)
        {
            {
                string json = await GetCardContents();
                // Parse the JSON array
                var cards = System.Text.Json.JsonSerializer.Deserialize<List<CardData>>(json);

                // Filter out cards from the "BATTLEGROUNDS" set "Story_
                cardDataList = cards;
                // Serialize the parsed cards back to a formatted JSON string
                string formattedJson = System.Text.Json.JsonSerializer.Serialize(cardDataList, new JsonSerializerOptions { WriteIndented = true });

                Console.WriteLine(formattedJson);
                WriteToFile(formattedJson, "CardData.json");
            }
        }

        

        private void DeckCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            DeckCodeOutputTextbox.Clear();  
        }

        private void checkedListBoxDeck_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetDataDeckCodeButton_Click(object sender, EventArgs e)
        {
            string Space = " ";
            string deckCode = DeckCodeTextBox.Text;

            // Deserialize the deck code
            DeckSerializationManager serializationManager = new DeckSerializationManager();
            Deck deck = serializationManager.DeserializeDeck(deckCode);

            if (deck != null)
            {
                // Display the deck information in the output textbox
                StringBuilder outputBuilder = new StringBuilder();
                outputBuilder.AppendLine($"Format: {deck.Format}\n");
                //outputBuilder.AppendLine($"HeroDbfId: {deck.HeroDbfId}");

                outputBuilder.AppendLine("Cards in Deck:\n"); // Modified output heading

                // Retrieve card names using HearthDb
                List<Card> cards = new List<Card>();

                foreach (var cardDbfId in deck.CardDbfIds)
                {
                    // Lookup the card information by DBF ID
                    Card card = HearthDb.Cards.Collectible.Values.FirstOrDefault(c => c.DbfId == cardDbfId.Key);

                    if (card != null)
                    {
                        cards.Add(card);
                    }
                }

                // Sort the cards by cost in ascending order
                cards.Sort((card1, card2) => card1.Cost.CompareTo(card2.Cost));

                foreach (var card in cards)
                {
                    var cardDbfId = deck.CardDbfIds.FirstOrDefault(c => c.Key == card.DbfId);

                    if (cardDbfId.Value != null)
                    {
                        outputBuilder.AppendLine($"==={card.Name}===\n\n ID: {card.Id}\n DbfID: {card.DbfId}\n Cost: {card.Cost}\n Copys in Deck: {cardDbfId.Value}\n ");
                       
                    }
                    else
                    {
                        outputBuilder.AppendLine($"- Unknown Card, DBF ID: {card.DbfId}");
                    }
                }

                DeckCodeOutputTextbox.Text = outputBuilder.ToString();
            }
            else
            {
                DeckCodeOutputTextbox.Text = "Invalid deck code. Please enter a valid deck code.";
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void DeckCodeOutputTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DecodeDeckStringButton_Click(object sender, EventArgs e)
        {


        }

        private string GetDeckInformation(Deck deck)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + deck.Name);
            sb.AppendLine("Format: " + deck.Format.ToString());
            sb.AppendLine("HeroDbfId: " + deck.HeroDbfId);

            sb.AppendLine("Card DBFIds:");
            foreach (var card in deck.CardDbfIds)
            {
                string cardName = "Unknown";
                string cardId = "";
                string cardType = "";
                string cardClass = "";

                // Read the card information from CardData.json
                JObject cardData = ReadCardData();
                if (cardData != null)
                {
                    JToken cardInfo = cardData[card.Key.ToString()];
                    if (cardInfo != null)
                    {
                        cardName = cardInfo["name"]?.ToString();
                        cardId = cardInfo["id"]?.ToString();
                        cardType = cardInfo["type"]?.ToString();
                        cardClass = cardInfo["cardClass"]?.ToString();
                    }
                }

                sb.AppendLine($"- Card: {card.Key}, Name: {cardName}, ID: {cardId}, Type: {cardType}, Class: {cardClass}, Count: {card.Value}");
            }

            return sb.ToString();
        }


        private JObject ReadCardData()
        {
            string path = "CardData.json";
            if (File.Exists(path))
            {
                try
                {
                    string json = File.ReadAllText(path);
                    return JObject.Parse(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error reading CardData.json: " + ex.Message);
                }
            }

            return null;
        }

        private void GenerateRegionsButton_Click(object sender, EventArgs e)
        {
            {
                string Indent = "    ";

                string deckCode = DeckCodeTextBox.Text;

                // Deserialize the deck code
                DeckSerializationManager serializationManager = new DeckSerializationManager();
                Deck deck = serializationManager.DeserializeDeck(deckCode);

                if (deck != null)
                {
                    // Display the deck information in the output textbox
                    StringBuilder outputBuilder = new StringBuilder();
                    //outputBuilder.AppendLine($"Format: {deck.Format}\n");
                    //outputBuilder.AppendLine($"HeroDbfId: {deck.HeroDbfId}");

                    outputBuilder.AppendLine("//Regions for Profile:\n"); // Modified output heading

                    // Retrieve card names using HearthDb
                    List<Card> cards = new List<Card>();

                    foreach (var cardDbfId in deck.CardDbfIds)
                    {
                        // Lookup the card information by DBF ID
                        Card card = HearthDb.Cards.Collectible.Values.FirstOrDefault(c => c.DbfId == cardDbfId.Key);

                        if (card != null)
                        {
                            cards.Add(card);
                        }
                    }

                    // Sort the cards by cost in ascending order
                    cards.Sort((card1, card2) => card1.Cost.CompareTo(card2.Cost));

                    foreach (var card in cards)
                    {
                        var cardDbfId = deck.CardDbfIds.FirstOrDefault(c => c.Key == card.DbfId);

                        if (cardDbfId.Value != null)
                        {
                            outputBuilder.AppendLine($"#region {card.Name} ID: {card.Id}\n\n    if(board.HasCardInHand(Card.Cards.{card.Id}))\n     {{\n       AddLog(\"[Card in Hand] {card.Name}.\");\n     }}\n\n#endregion\n");



                        }
                        else
                        {
                            outputBuilder.AppendLine($"- Unknown Card, DBF ID: {card.DbfId}");
                        }
                    }

                    DeckCodeOutputTextbox.Text = outputBuilder.ToString();
                }
                else
                {
                    DeckCodeOutputTextbox.Text = "Invalid deck code. Please enter a valid deck code.";
                }
            }
        }

        private void GenerateVariablesButton_Click(object sender, EventArgs e)
        {
            {
                string Indent = "    ";

                string deckCode = DeckCodeTextBox.Text;

                // Deserialize the deck code
                DeckSerializationManager serializationManager = new DeckSerializationManager();
                Deck deck = serializationManager.DeserializeDeck(deckCode);

                if (deck != null)
                {
                    // Display the deck information in the output textbox
                    StringBuilder outputBuilder = new StringBuilder();
                    //outputBuilder.AppendLine($"Format: {deck.Format}\n");
                    //outputBuilder.AppendLine($"HeroDbfId: {deck.HeroDbfId}");

                    outputBuilder.AppendLine("//Variables for Profile:\n"); // Modified output heading

                    // Retrieve card names using HearthDb
                    List<Card> cards = new List<Card>();

                    foreach (var cardDbfId in deck.CardDbfIds)
                    {
                        // Lookup the card information by DBF ID
                        Card card = HearthDb.Cards.Collectible.Values.FirstOrDefault(c => c.DbfId == cardDbfId.Key);

                        if (card != null)
                        {
                            cards.Add(card);
                        }
                    }

                    // Sort the cards by cost in ascending order
                    cards.Sort((card1, card2) => card1.Cost.CompareTo(card2.Cost));

                    foreach (var card in cards)
                    {
                        var cardDbfId = deck.CardDbfIds.FirstOrDefault(c => c.Key == card.DbfId);

                        if (cardDbfId.Value != null)
                        {
                            outputBuilder.AppendLine($"var {Regex.Replace(card.Name, @"[^a-zA-Z0-9]", "")} = Card.Cards.{card.Id};");

                        }
                        else
                        {
                            outputBuilder.AppendLine($"- Unknown Card, DBF ID: {card.DbfId}");
                        }
                    }

                    DeckCodeOutputTextbox.Text = outputBuilder.ToString();
                }
                else
                {
                    DeckCodeOutputTextbox.Text = "Invalid deck code. Please enter a valid deck code.";
                }
            }
        }
    }
    public class DeckSerializationManager
    {
        public string SerializeDeck(Deck deck, bool includeComments)
        {
            try
            {
                return DeckSerializer.Serialize(deck, includeComments);
            }
            catch (Exception ex)
            {
                // Handle any serialization errors
                Console.WriteLine($"Error occurred while serializing deck: {ex.Message}");
                return null;
            }
        }

        public Deck DeserializeDeck(string deckString)
        {
            try
            {
                return DeckSerializer.Deserialize(deckString);
            }
            catch (Exception ex)
            {
                // Handle any deserialization errors
                Console.WriteLine($"Error occurred while deserializing deck: {ex.Message}");
                return null;
            }
        }
    }
    public class DeckCard
    {
        public int dbfId { get; set; }
        public string name { get; set; }
        public string id { get; set; }
    }
    public class CardData
    {
        public string artist { get; set; }
        public int? attack { get; set; }
        public string cardClass { get; set; }
        public int cost { get; set; }
        public int dbfId { get; set; }
        public string flavor { get; set; }
        public int? health { get; set; }
        public string id { get; set; }

        [JsonProperty("mechanics")]
        public List<string> mechanics { get; set; }

        public string name { get; set; }

        [JsonProperty("races")]
        public List<string> races { get; set; }

        public string rarity { get; set; }
        public string set { get; set; }
        public string spellSchool { get; set; }
        public string type { get; set; }
        public string text { get; set; }


    }
}