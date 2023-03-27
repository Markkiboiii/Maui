using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace TentakompletteringMaui.Models
{
    public class Friend
    {
        public string Name { get; set; }
        public List<string> FavoriteProverbs { get; set; }
        List<Friend> friends = new List<Friend>();
        public string FavoriteProverbsFormatted => string.Join(", ", FavoriteProverbs);
    }
}
