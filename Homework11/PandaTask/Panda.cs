namespace Homework11.PandaTask
{
    public class Panda
    {

        private static int pandasCounter = 1;
        public string Name { get; init; }
        public Gender Gender { get; init; }
        public Color Color { get; init; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }

        public Panda(string name, Gender gender, Color color, int hp, int attack, int defence)
        {
            Name = name;
            Gender = gender;
            Color = color;
            Hp = hp;
            Attack = attack;
            Defence = defence;
        }

        public override bool Equals(object? obj)
        {
            return obj is Panda panda &&
                   Color == panda.Color &&
                   Hp == panda.Hp;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Color, Hp);
        }

        public override string? ToString()
        {
            return $"Panda: {{\"name\": \"{Name}\", \"gender\": \"{Gender}\", \"color\": \"{Color}\", " +
                $"\"HP\": \"{Hp}\", \"attack\": \"{Attack}\", \"defence\": \"{Defence}\"}}";
        }

        public static Panda operator +(Panda a, Panda b)
        {
            if (a.Gender == b.Gender)
            {
                throw new ArgumentException($"Pandas should be heterosexual, but both are {a.Gender}");
            }

            string name = $"panda{pandasCounter++}";
            Random random = new();
            Gender gender = (Gender)random.Next(0, 2);
            Color color = random.Next(0, 2) == 0 ? a.Color : b.Color;
            return new Panda(name, gender, color, 50, 5, 3);
        }

        public static Panda operator -(Panda victim, Panda attacker)
        {
            int damage = Math.Max(attacker.Attack - victim.Defence, 0);
            int hpRemaining = victim.Hp - damage;
            if (hpRemaining < 1) 
            {
                throw new ArgumentException($"Attack is not possible as panda {victim.Name} has {victim.Hp} HP and defence {victim.Defence}" +
                    $"and will die after attack by panda {attacker.Name} with attack {attacker.Attack}");
            }
            victim.Hp = hpRemaining;
            return victim;
        }
    }

    

  
}
