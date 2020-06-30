using System;

namespace COMP123_M2020_Lesson5_Part1
{
    abstract class GameObject
    {
        // PRIVATE INSTANCE MEMBERS (FIELDS)
        private GameObjectType m_type;
        protected float m_health;

        // PUBLIC PROPERTIES
        public Transform transform { get; set; }

        public GameObjectType Type
        {
            get 
            {
                return m_type;
            }

            set
            {
                m_type = value;
            }
        }

        public virtual float Health
        {
            get 
            {
                return m_health;
            }

            set
            {
                m_health = value;
            }
        }

        // CONSTRUCTOR(S)


        /// <summary>
        ///  This Constructor requires a name for the GameObject with an option health value.
        ///  By Default all GameObjects have a health value of 100.0
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>

        public GameObject(GameObjectType type, float health = 100.0f)
        {
            Type = type;
            Health = health;

            m_initialize();

            Start();
        }

        // PRIVATE METHODS
        private void m_initialize()
        {
            transform = new Transform();
        }

        // PUBLIC METHOD
        public override string ToString()
        {
            string outputString = "";

            outputString += $"Type    : {Type.ToString()}\n";
            outputString += $"Health  : {Health}\n";
            outputString += transform.ToString();

            return outputString;
        }

        // PUBLIC ABSTRACT METHODS (MUST BE overriden in the derived class)
        public abstract void Start();

        public abstract void Update();

        public abstract void Reset();
    }
}
