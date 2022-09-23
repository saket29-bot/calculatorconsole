using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDECaseSt
{
    internal class Program
    {

        static void Main(string[] args)
        {
            IDE ide = new IDE();
            ide.languages.Add(new LCsharp());
            ide.languages.Add(new LJava());
            ide.languages.Add(new LC());
            ide.DoWork();
        }

        
    }

    class IDE
    {
       public List<ILanguage> languages = new List<ILanguage>();  


        public void DoWork()
        {
            foreach (ILanguage lang in languages)
            {
                Console.WriteLine($"working with:{lang.GetName()}");
                Console.WriteLine(lang.GetUnit());
                Console.WriteLine(lang.GetParadigm());
                Console.WriteLine("----------------------------------");
            }
        }
    }

    interface ILanguage
    {
        string GetName();
        string GetUnit();
        string GetParadigm();


    }
    abstract class OOlang : ILanguage
    {
        public string GetUnit()
        {
            return "class";

        }
        public string GetParadigm()
        {
            return "object oriented";
        }

        abstract public string GetName();//use keyword virtual if method is not abstract;

    }
    class LCsharp : OOlang// contract signed b/t interface and class
    {
        public override string GetName()//override to implete it over base class.
        {
            return "csharp";
        }
        
    }

    class LJava: OOlang
    {
        public override string GetName()
        {
            return "Java";
        }

    }

    class LC:ILanguage
    {
        public string GetName()
        {
            return "C";
        }
        public string GetUnit()
        {
            return "Function";

        }
        public string GetParadigm()
        {
            return "Procedure oriented";
        }

    }
}
