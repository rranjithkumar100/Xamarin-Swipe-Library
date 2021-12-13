# Xamarin-Swipe-Library


**Step 1: In your view**

For ex: your view is **lbl_swipe**

SwipeListener swipeListener = new SwipeListener(**lbl_swipe**, this);


**Step 2: In your Xamarin forms page ---> Implement ISwipeCallBack **


public partial class SwipeLibPage : ContentPage, **ISwipeCallBack**


You will get callback when user swipe left,right,top or bottom

