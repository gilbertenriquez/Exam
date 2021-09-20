using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Model
{
    public class TBL_Login
    {
        public String id { get; set; }
        public String username { get; set; }
        public String pass { get; set; }


        public static async Task Insert(TBL_Login userLogin)
        {
            await App.MobileService.GetTable<TBL_Login>().InsertAsync(userLogin);
        }
    }
}