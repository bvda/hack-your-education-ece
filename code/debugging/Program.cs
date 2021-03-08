using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace hack_your_cs_education_debugging_c_sharp
{
    class Program
    {
        static async Task Main(string[] args = null)
        {
            try {
                var cards = await Program.ReadFile(args[0]);
                foreach(var c in cards) {
                    printCard(c);
                }
            } catch(JsonException e) {
                Console.Error.WriteLine(e.StackTrace);
            } catch(ArgumentException e) {
                Console.Error.WriteLine(e.StackTrace);
            } catch(IOException e) {
                Console.Error.WriteLine(e.StackTrace);
            }
        }

        static void printCard(HearthstoneCard card) {
           Console.WriteLine(card.Name);
           Console.WriteLine(card.Type);
           Console.WriteLine(card.Set);
           Console.WriteLine(card.Rarity); 
           Console.WriteLine("---");
        }

        static async Task<List<HearthstoneCard>> ReadFile(string path = "") {
            var stream = File.OpenRead(path);
            var cards = await JsonSerializer.DeserializeAsync<List<HearthstoneCard>>(stream);
            return cards;
        }
    }

    class HearthstoneCard {
        [JsonPropertyNameAttribute("name")]
        public String Name { get; set; }
        [JsonPropertyNameAttribute("type")]
        public String Type { get; set; }
        [JsonPropertyNameAttribute("set")]
        public String Set { get; set; }
        [JsonPropertyNameAttribute("rarity")]
        public String Rarity { get; set; }
    }
}
