using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P208_Academy.Data
{
    public class Group
    {
        public string GroupID { get; private set; } //Qrupun ID nomresi, baxmaq olar-deyismek olmaz
        public string GroupName { get; set; } // Qrupun adi, baxmaq olar, duzelish olar

       
        private static int groupIDCounter = 1;  // qrupun ID nomresinin baslanqic noqtesi

        public Group(string groupName) // Konstruktor
        {
            GroupName = groupName; // verilen qrupun adi GroupName-e elave edilir

            // qrup ID-sinin 5 simvolu kecmemek alqoritmi
            GroupID = new string('0', 5 - groupIDCounter.ToString().Length) + groupIDCounter++;
        }

        // GroupName-in string-e cevirilmesi
        // yeeni, group-un adindan bashqa sistem yazilar cixmasin
        public override string ToString() => GroupName;

    }
}
