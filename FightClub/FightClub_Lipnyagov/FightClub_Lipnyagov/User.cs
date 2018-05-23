using System;

namespace FightClub_Lipnyagov
{
    class User
    {
        public String name { get; }
        public short health {get; set;}
        private PartOfBody blocked;

        public delegate User DeathDelegate(User user);
        public delegate User WoundDelegate(User user);
        public delegate User BlockDelegate(User user, PartOfBody part);

        public event DeathDelegate Die;
        public event WoundDelegate TakeWound;
        public event BlockDelegate Block;

        public User(string name)
        {
            this.name = name;
            health = 100;
        }

        public void SetBlock(PartOfBody blockedPart)
        {
            blocked = blockedPart;
        }

        public User GetGit(PartOfBody attackedPart)
        {
            if(attackedPart == blocked)
            {
                return Block(this, attackedPart);
            }

            return TakeWound(this);
        }

        public User Death()
        {
            if (health > 0)
            {
                return this; 
            }

            return Die(this);
        }
    }
}
