using System.Collections.Generic;
using System.Threading.Tasks;
using System.Timers;

namespace SpaceGraphics {

	public partial class MainPage : ContentPage
	{

		public delegate void TickEventHandler(object sender, EventArgs e);
		public event TickEventHandler DoTick;
		


		public MainPage()
		{
			InitializeComponent();
			Draw.Drawable = new MyDrawing();

			IDispatcherTimer timer = Application.Current.Dispatcher.CreateTimer();

			timer.Interval = TimeSpan.FromMicroseconds(1000);

		


		}
       
    }

}
	



