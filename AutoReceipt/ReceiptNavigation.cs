using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AutoReceipt
{
    public partial class ReceiptNavigation : TabbedPage
    {
		public ReceiptNavigation()
	  {
		 Children.Add (new ReceiptForm ());
		 Children.Add (new ReceiptForm ());
	  }

      
       
}

}
