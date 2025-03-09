using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace try_Statments_and_Exceptions
{
    public  class NotFoundExeption:Exception // اکسپشن دستی
    {
        public NotFoundExeption()
        { 
        
        }
        public NotFoundExeption(string Message):base(Message) 
        { 
        
        }
    }
}
