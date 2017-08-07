using System;
using Xamarin.Forms;
namespace SwipeLib
{
	public interface ISwipeCallBack
	{

		void onLeftSwipe(View view);
		void onRightSwipe(View view);
		void onTopSwipe(View view);
		void onBottomSwipe(View view);
		void onNothingSwiped(View view);
	}
}
