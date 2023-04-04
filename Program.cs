using System;

namespace OOP
{
   
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine();
            }
        }
        public class Character
        {
            private string Name;
            internal void thednm() { }
        }
        public class Player : Character
        {
            public string Health;
            public int Mana;
            public string Inventory;

            public void Attack() { }
            public void Useltem() { }

            private class TreasureChest
            {
                private string Type;
            }

            public void Array(string[] args)
            {
                string Potion;
                string Weapon;
            }
        }

        public class Enemy : Character
        {

        }

        public abstract class Creature
        {
            public abstract void Attack();
        }

        public class Goblin : Character
        {
        }
        public class Ork : Character
        {
        }

        public class Weapon
        {
            public int Damage;
            public int Durability;
            public void Attack()
            {
                Damage = 10;
                Durability = 100;
            }
        }
    }



