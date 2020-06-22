using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson5_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Enemy greenEnemy = new Enemy(name:"Green Enemy");
            Enemy redEnemy = new Enemy(name: "Red Enemy");

            BossEnemy bossEnemy = new BossEnemy();

            player.RaiseShields();
            player.transform.position = new Vector2D(x: 100.0f, y: 100.0f);
            Console.WriteLine(player.ToString());

            greenEnemy.FireBullet();
            greenEnemy.transform.position = new Vector2D(x: 60.0f, y: 80.0f);
            Console.WriteLine(greenEnemy.ToString());


            redEnemy.FireBullet();
            redEnemy.transform.position = new Vector2D();
            Console.WriteLine(redEnemy.ToString());

            bossEnemy.FireBullet();
            bossEnemy.transform.position = new Vector2D(x: 200.0f, y: 200.0f);
            Console.WriteLine(bossEnemy.ToString());

            //GameObject player = new GameObject(name:"Player");

            //player.transform.position = new Vector2D();

            //Console.WriteLine(player.transform.position.ToString());

            //Console.WriteLine(player.Name);
            //Console.WriteLine(player.transform.ToString());

            Console.WriteLine(player.ToString());

            Console.WriteLine(greenEnemy.ToString());
            greenEnemy.FireBullet();

            Console.WriteLine(redEnemy.ToString());
            redEnemy.FireBullet();

            // listen for any key
            Console.ReadLine();
        }
    }
}
