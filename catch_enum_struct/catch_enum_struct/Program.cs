using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandag280518TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * #region TryParseFinally
            //string s = "5555555555555555555555555555555555555";

            //try
            //{
            //    int i = int.Parse(s);
            //}
            //catch (ArgumentNullException ee)
            //{
            //    Console.WriteLine(ee.Message);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message + " " + e.StackTrace);
            //}
            //catch (Exception eee) ///generel type, der fanger alle andre exceptions uanset type (toppen af hierakiet)
            //{
            //    Console.WriteLine(eee.Message);
            //    //Environment.FailFast("FailFast"); //for programmet til at lukke ned uden her og nu, uden finally gennemføres
            //}
            //finally
            //{
            //    Console.WriteLine("Dette bliver altid udført - finally");
            //}

            #endregion

            #region throw exception
            try
            {
                string s = OpendAndParse(null);
            }
            catch (ArgumentNullException e)
            {

                Console.WriteLine("Arg null ex: " + e.Message);
            }

        
            #endregion
        }

        private static string OpendAndParse(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename))
            {
                throw new ArgumentNullException("filename", "filename is required");
            }
            return File.ReadAllText(filename);
             
             */ 
            string str = "123a";

            //int i = int.Parse(str);

            try
            {
                int i = int.Parse(str);
                Console.WriteLine("Der kom ikke en exception");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Du skal angives en værdi");
            }

            catch (Exception e)
            {
                Console.WriteLine("Der kom en exception, {0} er ikke valid", str);
                Console.WriteLine("Message: " + e.Message);
                Console.WriteLine("StackTrace: " + e.StackTrace);
                Console.WriteLine("HelpLink: " + e.HelpLink);
                Console.WriteLine("InnerException: " + e.InnerException);
                Console.WriteLine("TargetSite: " + e.TargetSite);
                Console.WriteLine("Source: " + e.Source);

                //Environment.FailFast("Program fejler lukkes ned");
            }
            finally
            {
                //kode udføres altid
                Console.WriteLine("Program afsluttes");
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
