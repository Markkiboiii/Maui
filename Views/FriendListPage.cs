namespace TentakompletteringMaui.Views;
using TentakompletteringMaui.ViewModels;
using TentakompletteringMaui.Models;

public class FriendListPage : ContentPage
{
    public FriendListPage()
    {
        // lista av v�nner och favoritordspr�k
        List<Friend> friends = new List<Friend>();

        Random random = new Random();
        for (int i = 0; i < 50; i++)
        {
            List<string> proverbs = new List<string>();
            int count = random.Next(6); // mellan 0 och 5 favorit ordspr�k
            for (int j = 0; j < count; j++)
            {
                proverbs.Add($"Proverb {j + 1}");
            }

            friends.Add(new Friend { Name = $"Friend {i + 1}", FavoriteProverbs = proverbs });
        }

        // ListView f�r att visa v�nner
        ListView friendListView = new ListView
        {
            ItemsSource = friends,
            ItemTemplate = new DataTemplate(() =>
            {
                TextCell textCell = new TextCell();
                textCell.SetBinding(TextCell.TextProperty, "Name");
                return textCell;
            })
        };

        // StackLayout f�r att visa ListView
        StackLayout stackLayout = new StackLayout
        {
            Children = { friendListView }
        };

        // Content f�r att visa StackLayout
        Content = stackLayout;
    }
}

