using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TentakompletteringMaui.Models;

namespace TentakompletteringMaui.ViewModels
{
    public class FriendListViewModel : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }

            }


        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private List<Friend> _friends;

        public List<Friend> Friends
        {
            get => _friends;
            set => _friends = value;
        }

        public FriendListViewModel()
        {
            // Generera 50 namn
            List<string> names = new List<string>
        {
            "Harry", "Lord", "Hermione", "Albus", "Severus", "Ron", "Draco",
            "Frodo", "Gandalf", "Sam", "Peregrin", "Saruman"
        };
            List<Friend> friends = new List<Friend>();
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                // Välj ett slumpmässigt namn
                string name = names[random.Next(names.Count)];
                // Generera mellan 0 och 5 favorit ordspråk
                List<string> proverbs = new List<string>();
                int numProverbs = random.Next(6); // mellan 0 och 5
                for (int j = 0; j < numProverbs; j++)
                {
                    proverbs.Add(GetRandomProverb());
                }
                // Lägg till en ny vän i listan
                friends.Add(new Friend { Name = name, FavoriteProverbs = proverbs });
            }
            Friends = friends;
        }

        private string GetRandomProverb()
        {
            List<string> proverbs = new List<string>
        {
            "Alla vägar bär till Rom",
            "En droppe i havet",
            "Det finns inget dåligt väder, bara dåliga kläder",
            "Allt gott kommer från ovan",
            "Ingen rök utan eld",
            "Den som gräver en grop åt andra faller själv däri",
            "Bättre en fågel i handen än tio i skogen",
            "Man ska inte kasta sten i glashus",
            "Man ska inte säga hopp i galopp",
            "Den som gapskrattar sist gapskrattar bäst"
        };
            Random random = new Random();
            return proverbs[random.Next(proverbs.Count)];
        }
 
    }
}
