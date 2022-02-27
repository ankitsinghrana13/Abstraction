using System;
namespace ConsoleApp7
{

    abstract class progrm
    {
        public string name;
        public abstract void data();

        public void inform(string name)
        {
            this.name = name;
            Console.WriteLine("name=" + name);

        }

    }
        class property : progrm
        {
       public override void data()
        {
            Console.WriteLine("this class belongs to property");
            
        }

        }
    
        class program
        {
            static void Main(string[] arg)
            {

            property obj = new property();
            obj.data();
            obj.inform("hashi");

           
            






        }
        }
    
}