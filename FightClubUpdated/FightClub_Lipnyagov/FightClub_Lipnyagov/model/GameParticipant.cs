using System;

namespace FightClub_Lipnyagov
{
    class GameParticipant
    {
        public String name { get; }
        public short health {get; set;}
        private PartOfBody blocked;

        public delegate GameParticipant DeathDelegate(GameParticipant user);
        public delegate GameParticipant WoundDelegate(GameParticipant user);
        public delegate GameParticipant BlockDelegate(GameParticipant user, PartOfBody part);

        public event DeathDelegate Die;
        public event WoundDelegate TakeWound;
        public event BlockDelegate Block;

        public GameParticipant(string name)
        {
            this.name = name;
            health = 100;
        }

        public void SetBlock(PartOfBody blockedPart)
        {
            blocked = blockedPart;
        }

        public GameParticipant GetGit(PartOfBody attackedPart)
        {
            if(attackedPart == blocked)
            {
                return Block(this, attackedPart);
            }

            return TakeWound(this);
        }

        public GameParticipant Death()
        {
            if (health > 0)
            {
                return this; 
            }

            return Die(this);
        }
    }
}
