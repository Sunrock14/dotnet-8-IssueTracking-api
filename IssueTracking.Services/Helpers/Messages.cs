using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracking.Services.Helpers
{
    public static class Messages
    {
        public static class General
        {
            public static string Error => $"Hata";
            public static string NotFound(bool isPlural)
            {
                if (isPlural) 
                    return "Kayıt Bulunamadı.";
                else
                    return "Böyle bir makale bulunamadı.";
            }
            public static string Add(string Id)
            {
                return $"{Id}";
            }

            public static string Update(string Id)
            {
                return $"{Id}";
            }
            public static string Delete(string Id)
            {
                return $"{Id} ";
            }
            public static string HardDelete(string Id)
            {
                return $"{Id} ";
            }
            public static string UndoDelete(string Id)
            {
                return $"{Id} ";
            }
        }
    }
}
