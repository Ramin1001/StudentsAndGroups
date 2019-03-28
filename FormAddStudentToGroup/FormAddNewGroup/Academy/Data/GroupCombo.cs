using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P208_Academy.Data
{
    public class GroupCombo // Qrup ad ve ID-lerinin qutusu
    {
        public string Text { get; set; }  // Group clasindaki GroupName
        public string Value { get; set; } // Group clasindaki  GroupID

        public override string ToString() => Text; // Qrup adini daxil eleme
        
    }
}
