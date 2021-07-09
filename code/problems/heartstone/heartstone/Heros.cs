namespace Heartstone
{
    public abstract class Hero {
        public readonly string Name;
        public int Power {get; private set;}
        public WeaponCard Weapon {get; set;}
        

        public Hero(string name) {
            Name = name;
            Power = 30;
        }
    }

    public class Mage : Hero {
        public Mage(string name): base(name) {
        }
    }

    public class Priest : Hero {
        public Priest(string name): base(name) {
        }
    }

    public class Warlock : Hero {
        public Warlock(string name): base(name) {
        }
    }

    public class Paladin : Hero {
        public Paladin(string name): base(name) {
        }
    }

    public class Warrior : Hero {
        public Warrior(string name): base(name) {
        }
    }

    public class Droid : Hero {
        public Droid(string name): base(name) {
        }
    }

    public class Hunter : Hero {
        public Hunter(string name): base(name) {
        }
    }

    public class Rouge : Hero {
        public Rouge(string name): base(name) {
        }
    }

    public class Sharman : Hero {
        public Sharman(string name): base(name) {
        }
    }

    public class DemonHunter : Hero {
        public DemonHunter(string name): base(name) {
        }
    }
}
