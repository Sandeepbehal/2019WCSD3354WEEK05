using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019WCSD3354WEEK05
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new testques2();
            a.Play();
        }
    }

    class testques2
    {
        public int myfavvari = 0;
        public void Play()
        {
            //write a for loop

            for (; my();)
            {
                if (myfavvari <= 10)
                    Console.WriteLine("you are fool");
                break;
            }
            Console.WriteLine("shit for loop again");
        }
        public bool my()
        {
            myfavvari++;
            return true;
        }
    }

    class dog
    {
        public dog(string name, string breed)
        {
            dog_name = name;
            dog_breed = breed;
        }



        public string dog_name;
        public string dog_breed;
        public dog next_dog;
        public dog prev_dog;

    }
    class birthday_party
    {
        public dog peanut;
        public dog fifi;
        public dog clarence;
        public dog roy;

        public dog head;
        public dog tail;
        public dog temporary;



        public void mapini()
        {
            peanut = new dog("peanut", "bichon");
            fifi = new dog("fifi", "poodle");
            clarence = new dog("clarence", "german");
            roy = new dog("roy", "beagle");


            peanut.prev_dog = null;
            peanut.next_dog = fifi;

            fifi.prev_dog = peanut;
            fifi.next_dog = clarence;

            clarence.prev_dog = fifi;
            clarence.next_dog = roy;

            roy.prev_dog = clarence;
            roy.next_dog = null;
            head = peanut;
            tail = roy;



        }
        public void run()
        {
            this.mapini();
            Console.WriteLine(dognames);
        }

        public void dognames()
        {
            head = peanut;
            while (temporary.next_dog != null)
            {
                Console.WriteLine(temporary.dog_name);
            }
        }
    }
}