using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P208_Academy.Data
{
    public static class GroupList // Qrup siyahisinin birge yerinin yaradilmasi
    {
        // Group tipinde bir List massivi yaradiriq 
        public static List<Group> Groups { get; private set; } 

        // Konstruktor
        static GroupList() // ilk ishe dushende bunlar icra olunsun
        {
            Groups = new List<Group>(); // yeni bir massivin yaradilmasi

            //masive qrup adinin daxil edilmesi
            Groups.Add(new Group("P208")); 
            Groups.Add(new Group("P209"));
            Groups.Add(new Group("V403"));
            Groups.Add(new Group("V305"));
        }

        // Sonradan yeni qrupun elave edilmesi metodu
        public static void Add(Group group) 
        {
            Groups.Add(group);
        }

        //==============  SONRADAN ISHLENECEK  ============//
                                                           //
        public static Group GetGroupById(string groupID)   //
        {                                                  //
            //possible with LINQ in the future             //
            foreach (Group group in Groups)                //
            {                                              //
                if(group.GroupID == groupID)               //
                {                                          //
                    return group;                          //
                }                                          //
            }                                              //
                                                           //
            return null;                                   //
        }                                                  //
        //=================================================//

        // Group-larin boyuk herfle bashlanmasinin yoxlanmasi 
        public static bool ContainsGroupName(string groupName)
        {
            foreach (Group group in GroupList.Groups)
            {
                if (group.GroupName.ToUpper() == groupName.ToUpper())
                {
                    return true;
                }
            }

            return false;
        }
    }
}
