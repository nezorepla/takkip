using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Takkip
{
    class Bilgiler
    { 
        private static string ConStr = @"Data Source=.;Initial Catalog=Collection;  Integrated Security=SSPI;Connection Timeout=120;";

        private static string Sicil = "A25318";
        private static List<String> liste = null;
        public void setSicil(string user)
        {
            Sicil = user;
        }
        public string getSicil()
        {
            return Sicil;
        }
        public void setListe(List<String> list)
        {
            liste = list;
        }
        public List<String> getListe()
        {
            return liste;
        }
     
        public string getConStr()
        { return ConStr; }
    }
}
