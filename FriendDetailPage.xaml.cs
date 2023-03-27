using Microsoft.Maui.Controls;
using TentakompletteringMaui.Models;
using TentakompletteringMaui.Views;

namespace TentakompletteringMaui.Views
{
    public class FriendDetailPage : ContentPage
    {
        public FriendDetailPage(Friend friend)
        {
            Title = friend.Name;

            var nameLabel = new Label
            {
                Text = friend.Name,
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var proverbsButton = new Button
            {
                Text = "View Favorite Proverbs",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            proverbsButton.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new ProverbsListPage(friend.FavoriteProverbs));
            };

            Content = new StackLayout
            {
                Children =
                {
                    nameLabel,
                    proverbsButton
                }
            };
        }
    }
}
