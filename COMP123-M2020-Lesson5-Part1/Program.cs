using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson5_Part1
{
    class Program
    {
        private static List<GameObject> gameObjects;

        static void Update()
        {
            // access each object in the collection
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Update();

                switch (gameObject.Type)
                {
                    case GameObjectType.PLAYER:
                        Console.WriteLine("Player was accessed");
                        break;
                    case GameObjectType.RED_ENEMY:
                        Console.WriteLine("Red Enemy was accessed");
                        break;
                    case GameObjectType.BOSS:
                        Console.WriteLine("Boss was accessed");
                        break;
                }
            }
        }


        static void Main(string[] args)
        {
            // creates an empty container
            gameObjects = new List<GameObject>();


            float playerSpeed = 20.0f;          // 20 units

            Player player = new Player();
            gameObjects.Add(player);

            player.RaiseShields();
            player.transform.position = new Vector2D(x: 100.0f, y: 100.0f);
            Console.WriteLine(player.ToString());

            //player.transform.position = Vector2D.Right();
            
            //player.transform.position += Vector2D.Up() * playerSpeed;
            //Console.WriteLine(player.ToString());

            Enemy redEnemy = new Enemy(GameObjectType.RED_ENEMY);
            gameObjects.Add(redEnemy);
            redEnemy.transform.position = new Vector2D(x: 225.0f, y:200.0f);
            Console.WriteLine(redEnemy.ToString());

            float distance = Vector2D.Distance(lhs:player.transform.position, rhs:redEnemy.transform.position);
            Console.WriteLine($"The Distance between the player and the red enemy is {distance}");

            player.Health -= redEnemy.FireBullet();
            Console.WriteLine(player.ToString());

            BossEnemy boss = new BossEnemy();
            gameObjects.Add(boss);
            boss.transform.position = Vector2D.Zero();
            Console.WriteLine(boss.ToString());

            float bossDistance = Vector2D.Distance(lhs: player.transform.position, rhs: boss.transform.position);
            Console.WriteLine($"The Distance between the player and the red enemy is {bossDistance}");

            player.Health -= boss.FireBullet();
            Console.WriteLine(player.ToString());

            Update();


            /*Vector2D vector1 = new Vector2D(x:0.0f, y:3.0f);                                  //20200624
            Vector2D vector2 = new Vector2D(x:4.0f, y:0.0f);
            Console.WriteLine("Value of vector1 is: " + vector1.ToString());
            Console.WriteLine("Value of vector2 is: " + vector2.ToString());


            float dot = Vector2D.Dot(lhs: vector1, rhs: vector2);
            Console.WriteLine($"The Dot product is: {dot}");

            float distance = Vector2D.Distance(lhs: vector1, rhs: vector2);
            Console.WriteLine($"The Distance between vector1 and vector2 is {distance}");*/




            /*Enemy greenEnemy = new Enemy(name: "Green Enemy");
            Enemy redEnemy = new Enemy(name: "Red Enemy");

            BossEnemy bossEnemy = new BossEnemy();

            greenEnemy.FireBullet();
            greenEnemy.transform.position = new Vector2D(x: 60.0f, y: 80.0f);
            Console.WriteLine(greenEnemy.ToString());

            redEnemy.FireBullet();
            redEnemy.transform.position = new Vector2D();
            Console.WriteLine(redEnemy.ToString());

            bossEnemy.FireBullet();
            bossEnemy.transform.position = new Vector2D(x: 200.0f, y: 200.0f);
            Console.WriteLine(bossEnemy.ToString());*/

            /*GameObject player = new GameObject(name:"Player");

            player.transform.position = new Vector2D();

            Console.WriteLine(player.transform.position.ToString());

            Console.WriteLine(player.Name);
            Console.WriteLine(player.transform.ToString());

            Console.WriteLine(player.ToString());

            Console.WriteLine(greenEnemy.ToString());
            greenEnemy.FireBullet();

            Console.WriteLine(redEnemy.ToString());
            redEnemy.FireBullet();*/



            // listen for any key
            Console.ReadLine();
        }
    }
}
