//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OrdlisteFilter
//{
//    class OldFunctions
//    {
//        //using System;
//        //using System.Collections.Generic;
//        //using System.Linq;
//        //using System.Text;
//        //using System.Threading.Tasks;

//        //namespace OrdlisteFilter
//        //{
//        //    class Substantiv
//        //    {
//        //        public string Ord { get; set; }

//        //        public Substantiv(string word)
//        //        {
//        //            Ord = word;
//        //        }
//        //    }
//        //}

//        //switch (useInput)
//        //{
//        //    //case "subst":
//        //    //    GetSubst();
//        //    //    break;
//        //    //case "adv":
//        //    //    GetAdv();
//        //    //    break;
//        //    //case "verb":
//        //    //    GetVerb();
//        //    //    break; 
//        //    //case "adj":
//        //    //    GetAdj();
//        //    //    break; 
//        //    case "det":
//        //        GetDet();
//        //        break;  
//        //    case "create":
//        //        CreateList();
//        //        break;
//        //    case "exit":
//        //        return;
//        //    default:
//        //        Console.WriteLine("Default case");
//        //        break;
//        //}
//        //public static void GetSubst()
//        //{
//        //    var counter = 0;
//        //    var prevWord = "";


//        //    foreach (var line in File.ReadLines(FilePath, Encoding.UTF8))
//        //    {
//        //        var parts = line.Split('\t');
//        //        var word = parts[2];

//        //        var isSubst = parts[3];
//        //        var sisSubst = isSubst.Split(' ');

//        //        if (sisSubst[0] == "subst" && word != prevWord)
//        //        {
//        //            Console.WriteLine(word);
//        //            prevWord = word;
//        //            counter++;
//        //        }
//        //    }
//        //    Console.WriteLine("det er " + counter + " substantiv");
//        //}        

//        //public static void GetAdv()
//        //{
//        //    var counter = 0;
//        //    var prevWord = "";


//        //    foreach (var line in File.ReadLines(FilePath, Encoding.UTF8))
//        //    {
//        //        var parts = line.Split('\t');
//        //        var word = parts[2];

//        //        var isSubst = parts[3];
//        //        var sisSubst = isSubst.Split(' ');

//        //        if (sisSubst[0] == "adv" && word != prevWord)
//        //        {
//        //            Console.WriteLine(word);
//        //            prevWord = word;
//        //            counter++;
//        //        }
//        //    }
//        //    Console.WriteLine("det er " + counter + " adverb");
//        //}      

//        //public static void GetVerb()
//        //{
//        //    var counter = 0;
//        //    var prevWord = "";


//        //    foreach (var line in File.ReadLines(FilePath, Encoding.UTF8))
//        //    {
//        //        var parts = line.Split('\t');
//        //        var word = parts[2];

//        //        var isSubst = parts[3];
//        //        var sisSubst = isSubst.Split(' ');

//        //        if (sisSubst[0] == "verb" && word != prevWord)
//        //        {
//        //            Console.WriteLine(word);
//        //            prevWord = word;
//        //            counter++;
//        //        }
//        //    }
//        //    Console.WriteLine("det er " + counter + " verb");
//        //}       

//        //public static void GetAdj()
//        //{
//        //    var counter = 0;
//        //    var prevWord = "";

//        //    foreach (var line in File.ReadLines(FilePath, Encoding.UTF8))
//        //    {
//        //        var parts = line.Split('\t');
//        //        var word = parts[2];

//        //        var isSubst = parts[3];
//        //        var sisSubst = isSubst.Split(' ');

//        //        if (sisSubst[0] == "adj" && word != prevWord)
//        //        {
//        //            Console.WriteLine(word);
//        //            prevWord = word;
//        //            counter++;
//        //        }
//        //    }
//        //    Console.WriteLine("det er " + counter + " adjektiv");
//        //}

//        /*string
//    leste inn en gang lage liste av alle ordkalssende 

//                //if (sisSubst[0] == "det" && word != prevWord)
//                //{
//                //    //Console.WriteLine(word);
//                //    prevWord = word;
//                //    //counter++;
//                //    WordList.Add(new WordClass(word));
//                //}        

//                //if (sisSubst[0] == "adj" && word != prevWord)
//                //{
//                //    Console.WriteLine(word);
//                //    prevWord = word;
//                //    counter++;
//                //    WordList.Add(new WordClass(word));
//                //}    

//                //if (sisSubst[0] == "verb" && word != prevWord)
//                //{
//                //    //Console.WriteLine(word);
//                //    prevWord = word;
//                //    //counter++;
//                //    WordList.Add(new WordClass(word));
//                //}    

//                //if (sisSubst[0] == "adv" && word != prevWord)
//                //{
//                //    prevWord = word;
//                //    WordList.Add(new WordClass(sisSubst[0], word));
//                //}

//                //if (sisSubst[0] == "det" && word != prevWord)
//                //{
//                //    Console.WriteLine(word);
//                //    prevWord = word;
//                //    WordList.Add(new WordClass(sisSubst[0], word));
//                //}


//        //public static void GetDet()
//        //{
//        //    var counter = 0;
//        //    var prevWord = "";

//        //    foreach (var line in File.ReadLines(FilePath, Encoding.UTF8))
//        //    {
//        //        var parts = line.Split('\t');
//        //        var word = parts[2];

//        //        var isSubst = parts[3];
//        //        var sisSubst = isSubst.Split(' ');

//        //        if (sisSubst[0] == "det" && word != prevWord)
//        //        {
//        //            Console.WriteLine(word);
//        //            prevWord = word;
//        //            counter++;
//        //            WordList.Add(new WordClass(word));
//        //        }
//        //    }
//        //    Console.WriteLine("det er " + counter + " determinative ord");
//        //    Console.WriteLine(WordList[0].Category);
//        //}
//*/
//    }
//}
//static void CreateList()
//{

//    FileStream file = new FileStream(@"c:\users\tobias-tofsland\source\repos\ordlistefilter\ordliste.txt", FileMode.Open, FileAccess.Read);
//    using (var sr = new StreamReader(file, Encoding.UTF8))
//    {
//        while (sr.Peek() >= 0)
//        {


//        }
//    }

//    //Console.WriteLine("Line Count:{0}", myList.Count);

//    Console.ReadLine();
//}
