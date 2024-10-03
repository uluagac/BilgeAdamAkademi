using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_GameTry_Study_
{
    public class Character : LivingBeing
    {
        // Fields
        private string _name;
        private int _characterType;
        private string _weapon;
        private int _armorPoint;


        //Constructor
        public Character(string name, int characterType)
        {
            _name = name;
            switch (characterType)
            {
                case 1:
                    _characterType = 1; // warrior
                    HealthPoint = 1000;
                    ManaPoint = 0;
                    AttackPoint = 100;
                    SkillDamage = 0;
                    _weapon = "Kılıç";
                    _armorPoint = 50;
                    break;
                case 2:
                    _characterType = 2; // mage
                    HealthPoint = 800;
                    ManaPoint = 400;
                    AttackPoint = 50;
                    SkillDamage = 200;
                    _weapon = "Asa";
                    _armorPoint = 15;
                    break;
                default:
                    break;
            }
        }

        // Properties
        public string Name
        {
            get { return _name; }
        }
        public int CharacterType
        {
            get { return _characterType; }
        }
        public string Weapon
        {
            get
            {
                return _weapon;
            }
            set
            {
                if (_characterType == 1)
                {
                    _weapon = "Kılıç";
                }
                else if (_characterType == 2)
                {
                    _weapon = "Asa";
                }
            }
        }
        public int ArmorPoint
        {
            get { return _armorPoint; }
        }


        // Abstract Override Method
        public override int Attack(int damage, int hp)
        {
            return hp - damage;
        }
    }
}
