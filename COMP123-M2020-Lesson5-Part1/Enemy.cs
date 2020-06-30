using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson5_Part1
{
    class Enemy : GameObject, IUpdatable
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTOR

        public Enemy(GameObjectType type)
            : base(type)
        {

        }

        // PRIVATGE METHODS

        // PUBLIC METHODS

        public virtual float FireBullet()                    // override from BossEnemy class
        {
            Console.WriteLine($"{Type} Firing Bullet!");

            return 20.0f;
        }

        // PUBLIC OVERRIDEEN METHODS (MUST override)
        public override void Start()
        {
            Console.WriteLine($"{Type.ToString()} Start Method");
            Health = 50.0f;
        }

        public void Update()
        {
            Console.WriteLine($"{Type.ToString()} was Updated");
        }

        public override void Reset()
        {

        }
    }
}
