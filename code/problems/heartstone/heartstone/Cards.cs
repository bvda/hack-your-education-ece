using System;
using System.Drawing;
namespace Heartstone
{
    // Abstract class cannot be instantiated
    // Eg. new Card() is not allowed
    public abstract class Card {
        public readonly int Mana;
        public readonly string Name;
        public readonly Color Color;
        public readonly Gem RarityGem;
        public readonly string AbilityText;
        public int PlayedAt {get; set;}

        public Card(int mana, string name, Color color) {
            Mana = mana;
            Name = name;
            Color = color;
        }

        public abstract void Play(Hero player, Hero opponent);

        public static Card CreateRandomCard() {
            Random random = new Random();
            int mana = random.Next() % 7;
            string name = "";
            Color color = Color.FromArgb(random.Next());
            switch (random.Next() % 5) {
                case 0:
                case 1:
                    int attack = random.Next() % 5;
                    int health = random.Next() % 5;
                    return new CreatureCard(mana, name, color, attack, health);
                case 2:
                case 3:
                    return new SpellCard(mana, name, color);
                case 4:
                    int attackBonus = random.Next() % 3;
                    int durability = random.Next() % 3;
                    return new WeaponCard(mana, name, color, attackBonus, durability);
            }
            throw new Exception("Henrik made an error");
        }
    }

    public class CreatureCard : Card {
        public readonly int Attack;
        public int Health {get; private set;}

        public CreatureCard(int mana, string name, Color color, int attack, int health): base(mana, name, color) {
            Attack = attack;
            Health = health;
        }

        public override void Play(Hero player, Hero opponent) {
        }
    }

    public class SpellCard : Card {
        public SpellCard(int mana, string name, Color color): base(mana, name, color) {
        }

        public override void Play(Hero player, Hero opponent) {
        }
    }

    public class WeaponCard : Card {
        public readonly int AttackBonus;
        public int Durability {get; private set;}

        public WeaponCard(int mana, string name, Color color, int attackBonus, int durability): base(mana, name, color) {
            AttackBonus = attackBonus;
            Durability = durability;
        }

        public override void Play(Hero player, Hero opponent) {
        }
    }
}