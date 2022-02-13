using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Helpers.GuidHelper
{
    public class GuidHelperManager
    {
        public static string CreateGuid()
        {
            return Guid.NewGuid().ToString();
            /* Guid.NewGuid()=> bu metot bize eşsiz bir değer oluşturdu.
             * yani dosya eklerken dosyanın adı kendisi olmasın. Biz ona farklı bir isim 
             * verelim ki aynı isimde başka dosya varsa da çakışmasınlar
            *ToString ile de string hale çevirdik. */  
        }
    }
}
