using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_GameTry_Study_
{
    public abstract class LivingBeing
    {
        // Fileds
        private int _healthPoint;
        private int _manaPoint;
        private int _attackPoint;
        private int _skillDamage;

        // Constructor
        public LivingBeing()
        {
            
        }

        // Properties
        public int HealthPoint
        {
            get
            {
                return _healthPoint;
            }
            set
            {
                _healthPoint = value;
            }
        }
        public int ManaPoint
        {
            get
            {
                return _manaPoint;
            }
            set
            {
                _manaPoint = value;
            }
        }
        public int AttackPoint
        {
            get
            {
                return _attackPoint;
            }
            set
            {
                _attackPoint = value;
            }
        }
        public int SkillDamage
        {
            get
            {
                return _skillDamage;
            }
            set
            {
                _skillDamage = value;
            }
        }

        // Abstract Method
        public abstract int Attack(int damage, int hp);
    }
}
