using System;
using Xamarin.Forms;

namespace SwipeLib
{
	public partial class SwipeLibPage : ContentPage, ISwipeCallBack
	{
		public SwipeLibPage()
		{
			InitializeComponent();

			SwipeListener swipeListener = new SwipeListener(lbl_swipe, this);
		}

		public void onBottomSwipe(View view)
		{
			if (view == lbl_swipe) {
				lbl_result.Text = "OnBottomSwipe";
			}
		}

		public void onLeftSwipe(View view)
		{
			if (view == lbl_swipe) {
				lbl_result.Text = "onLeftSwipe";
			}
		}

		public void onNothingSwiped(View view)
		{
			if (view == lbl_swipe) {
				lbl_result.Text = "onNothingSwiped";
			}
		}

		public void onRightSwipe(View view)
		{
			if (view == lbl_swipe) {
				lbl_result.Text = "onRightSwipe";
			}
		}

		public void onTopSwipe(View view)
		{
			if (view == lbl_swipe) {
				lbl_result.Text = "onTopSwipe";
			}
		}
	}
}
