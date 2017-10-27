using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AutoReceipt
{
    public partial class ReceiptForm : ContentPage
    {
        Entry AmountEntry;
        Entry PriceEntry;
        Entry TotalEntry;
        
        public ReceiptForm()
	  {
        this.SetBinding(ContentPage.TitleProperty, "Form");
         
        var layout = new StackLayout { Orientation = StackOrientation.Horizontal };
            
            var Labels = new StackLayout();
            var EntryLayout = new StackLayout();
            var button = new Button { Text = "StackLayout", HorizontalOptions = LayoutOptions.FillAndExpand };
            button.Clicked += Button_Clicked;
            layout.BackgroundColor = Color.Black;
            var ProductEntry = new Entry { Text = "Product", BackgroundColor = Color.LightGray};
            AmountEntry = new Entry { Text = "1", BackgroundColor = Color.LightGray , Keyboard = Keyboard.Numeric};
            AmountEntry.TextChanged += AmountEntry_TextChanged;
            PriceEntry = new Entry { Text = "0", BackgroundColor = Color.LightGray, Keyboard = Keyboard.Numeric };
            PriceEntry.TextChanged += PriceEntry_TextChanged;
            TotalEntry = new Entry { Text = "0", BackgroundColor = Color.LightGray, Keyboard = Keyboard.Numeric };
            TotalEntry.TextChanged += TotalEntry_TextChanged;
            var greenBox = new BoxView { Color = Color.Green, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };
		    var blueBox = new BoxView { Color = Color.Blue, VerticalOptions = LayoutOptions.FillAndExpand,
		    HorizontalOptions = LayoutOptions.FillAndExpand, HeightRequest = 75 };
            var ProductLabel = new Label { Text = "Product:", TextColor = Color.White, FontSize = 20 };
            var AmountLabel = new Label { Text = "Amount:", TextColor = Color.White, FontSize = 20 };
            var PriceLabel = new Label { Text = "Price:", TextColor = Color.White, FontSize = 20 };
            var TotalLabel = new Label { Text = "Total: ", TextColor = Color.White, FontSize = 20 };
            Labels.Children.Add(ProductLabel);
            Labels.Children.Add(AmountLabel);
            Labels.Children.Add(PriceLabel);
            Labels.Children.Add(TotalLabel);
            Labels.Spacing = 20;
            EntryLayout.Children.Add(ProductEntry);
		    EntryLayout.Children.Add(AmountEntry);
		    EntryLayout.Children.Add(PriceEntry);
            EntryLayout.Children.Add(TotalEntry);
            EntryLayout.Children.Add(button);
            layout.Children.Add(Labels);
            layout.Children.Add(EntryLayout);
            layout.Spacing = 10;
      
		    Content = layout;
	  }

        private void Button_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TotalEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry this_entry = (Entry)sender;
            float Total, Amount;
            if (float.TryParse(this_entry.Text, out Total) && float.TryParse(AmountEntry.Text, out Amount))
                PriceEntry.Text = (Total/Amount).ToString();
        }

        private void AmountEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry this_entry = (Entry)sender;
            float Amount, Price;
            if (float.TryParse(this_entry.Text, out Amount) && float.TryParse(PriceEntry.Text, out Price))
                TotalEntry.Text = (Price * Amount).ToString();
        }

        private void PriceEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry this_entry = (Entry)sender;
            float Price, Amount;
            if (float.TryParse(this_entry.Text, out Price) && float.TryParse(AmountEntry.Text, out Amount))
                TotalEntry.Text = (Price * Amount).ToString();
           
        }
    }

}
