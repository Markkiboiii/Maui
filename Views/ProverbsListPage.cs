using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace TentakompletteringMaui.Views
{
    public class ProverbsListPage : ContentPage
    {
        public ProverbsListPage(List<string> proverbs)
        {
            Title = "Favorite Proverbs";
            Content = new StackLayout
            {
                Children =
                {
                    new Label { Text = "List of Favorite Proverbs", FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.CenterAndExpand },
                    new ListView
                    {
                        ItemsSource = proverbs,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        ItemTemplate = new DataTemplate(() =>
                        {
                            var proverbLabel = new Label();
                            proverbLabel.SetBinding(Label.TextProperty, new Binding("."));
                            return new ViewCell { View = proverbLabel };
                        })
                    }
                }
            };
        }
    }
}
