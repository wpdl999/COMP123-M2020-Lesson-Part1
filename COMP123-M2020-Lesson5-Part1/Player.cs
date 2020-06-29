using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson5_Part1
{
    class Player : GameObject
    {
        // PRIVATE INSTANCE VARIABLES
        private bool m_shieldsRaised;
        private float m_shieldLevel;

        // PUBLIC PROPERTIES
        public bool ShieldRaised 
        {
            get
            {
                return m_shieldsRaised;
            }

            set
            {
                m_shieldsRaised = value;
            }
        }

        public override float Health 
        {
            get
            {
                return m_health;   
            }

            set
            {
                /*if (ShieldRaised)                     
                {
                    m_health = value - 10.0f;
                }
                else
                {
                    m_health = value;
                }*/

                // use a ternary operator instead
                //m_health = (ShieldRaised) ? value + ShieldLevel : value;                //same above

                if (ShieldRaised)
                {
                    m_health = value + ShieldLevel;
                    Console.WriteLine($"Player's shields absorbed some damage {ShieldLevel} damage");
                }

                else
                {
                    m_health = value;
                }
            }
        }

        public float ShieldLevel
        {
            get
            {
                return m_shieldLevel;
            }

            set
            {
                m_shieldLevel = value;
            }
            
        }

        // CONSTRUCTOR
        public Player()
            : base(name:"Player")
        {
 
        }

        // PRIVATGE METHODS
        private void m_initialize()
        {
            m_shieldLevel = 10.0f;    
        }


        // PUBLIC METHODS
        public void RaiseShields()
        {
            Console.WriteLine("Raising Shields");
            ShieldRaised = true;
        }

        public void LowerShields()
        {
            Console.WriteLine("Lower Shields");
            ShieldRaised = false;
        }

        // PUBLIC OVERRIDDEN METHODS

        public override void Start()
        {
            Console.WriteLine($"{GetType()} Start Method");
            m_shieldLevel = 10.0F;
        }

        public override void Update()
        {
            Console.WriteLine($"{GetType()} was Updated");
        }

        public override void Reset()
        {
            
        }
    }
}
