using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicCharactersDictionaryWPF.Models
{
    public class StoryModel
    {
        public int StoryID { get; set; }
        public string StoryTitle { get; set; }
        public string StoryGenre { get; set; }
        public string AuthorName { get; set; }
        public int Year { get; set; }
        public string StoryBio { get; set; }
        public List<CharacterModel> ListOfCharacters { get; set; } = new List<CharacterModel>();
        public CharacterModel Character { get; set; }

    }
}
