using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson5_Part1
{
    class Vector2D
    {
        // PUBLIC INSTANCE VARIABLES
        public float x;
        public float y;

        // PUBNLIC OPERATOR OVERLOADS
        public static Vector2D operator +(Vector2D lhs, Vector2D rhs)
        {
            float Xs = lhs.x + rhs.x;
            float Ys = lhs.y + rhs.y;
            return new Vector2D(x: Xs, y: Ys);
        }

        public static Vector2D operator -(Vector2D lhs, Vector2D rhs)
        {
            float Xs = lhs.x - rhs.x;
            float Ys = lhs.y - rhs.y;
            return new Vector2D(x: Xs, y: Ys);
        }

        public static Vector2D operator *(Vector2D lhs, Vector2D rhs)
        {
            float Xs = lhs.x * rhs.x;
            float Ys = lhs.y * rhs.y;
            return new Vector2D(x: Xs, y: Ys);
        }

        public static Vector2D operator *(Vector2D lhs, float rhs)
        {
            float Xs = lhs.x * rhs;
            float Ys = lhs.y * rhs;
            return new Vector2D(x: Xs, y: Ys);
        }


        public static Vector2D operator /(Vector2D lhs, Vector2D rhs)
        {
            float Xs = lhs.x / rhs.x;
            float Ys = lhs.y / rhs.y;
            return new Vector2D(x: Xs, y: Ys);
        }


        // CONSTRUCTOR

        /// <summary>
        /// This constructor takes x and y as opetional parameters
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Vector2D(float x = 0.0f, float y = 0.0f)
        {
            this.x = x;
            this.y = y;
        }

        // PUBLIC METHOD

        /// <summary>
        /// This method returns the value of the x and y components with the format (x,y) as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = $"({x}, {y})";


            return outputString;
        }

        // PUBLIC STATIC METHODS
        public static Vector2D Zero()
        {
            return new Vector2D(x: 0.0f, y: 0.0f);
        }

        public static Vector2D Up()
        {
            return new Vector2D(x: 0.0f, y: 1.0f);
        }

        public static Vector2D Down()
        {
            return new Vector2D(x: 0.0f, y: -1.0f);
        }

        public static Vector2D Right()
        {
            return new Vector2D(x: 1.0f, y: 0.0f);
        }

        public static Vector2D Left()
        {
            return new Vector2D(x: -1.0f, y: 1.0f);
        }

        public static float Dot(Vector2D lhs, Vector2D rhs)
        {
            return (lhs.x * rhs.x) + (lhs.y * rhs.y);
        }

        public static float Distance(Vector2D lhs, Vector2D rhs)
        {
            float diffXs = (rhs.x - lhs.x);
            float diffYs = (rhs.y - lhs.y);

            return Convert.ToSingle(Math.Sqrt(diffXs * diffXs + diffYs * diffYs));
        }
    }
}
