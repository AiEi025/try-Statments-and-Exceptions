using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace try_Statments_and_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Dis = 0;
                TryDiv(100, 0, out Dis);
                DIv(10, 0);

                TestMethod("");

                int[] marray = { 1, 2 };
                int b = 0;
                //int c = 50 / b;
                int c = 50 / marray[50];
                WebClient webClient = new WebClient();
                webClient.DownloadString("https://testsite.ir");



                int z = int.Parse("sdww");// به اکسپشن می رود
                int x = 0;
                int.TryParse("dfe", out x);// به اکسپشن نمیرود ودر خود خط رفع مشکل می شود


            }
            catch (WebException ex) when (ex.Status == WebExceptionStatus.SendFailure)//exception filter //باعث میشود چند اکسپشن اجرا شوند 
            {
                Console.Write(ex.Message);
            }
            catch (WebException ex) when (ex.Status == WebExceptionStatus.ProtocolError)
            {

            }
            catch (WebException ex)
            {

            }
            catch (DivideByZeroException ex)
            {
                Console.Write(ex.Message);
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);

            }
            finally //همیشه اجرا میشود
            {

            }
            Console.ReadLine();
        }
        static private void TestMethod(string Name)
        {

            try
            {
                TestMethod2(Name);
                if (string.IsNullOrEmpty(Name))
                {
                    throw new NotSupportedException("Name is Null");
                }
            }
            catch (Exception ex)
            {
                ex.Data.Add("Test Key", " We have an error in program ");
                //throw new Exception(ex.Message,ex);
                throw;
            }


        }
        static private void TestMethod2(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                //throw new NotImplementedException("Not Implemented Method");
                throw new NotFoundExeption("Not Implemented Method");
            }

        }//برای دسترسی به اکسپشن های اصلی به قسمت ویو میرویم روی ابجکت بروزر اکسپشن را جست وجو میکنیم

        static private bool TryDiv(int a, int b, out int result)
        {
            try
            {
                result = a / b;
                return true;
            }
            catch (Exception ex)
            {
                result = 0;
                return false;
            }
            
        }

        static private int DIv(int a, int b)
        {
            int result;
            if (!TryDiv(a, b, out result))
            {
                throw new Exception("ٍError");
            }
            return result;
        }
    }
}
