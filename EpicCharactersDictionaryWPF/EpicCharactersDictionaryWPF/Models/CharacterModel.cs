using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicCharactersDictionaryWPF.Models
{
    public class CharacterModel
    {
        public int CharacterID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public string Alignment { get; set; }
        public string Nationality { get; set; }
        public string Bio { get; set; }
        public string PhysicalFeatures { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
