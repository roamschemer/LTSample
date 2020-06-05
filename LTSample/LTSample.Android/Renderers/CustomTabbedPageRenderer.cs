#pragma warning disable CS0618
using Android.Views;
using AndroidX.ViewPager.Widget;
using Google.Android.Material.Tabs;
using LTSample.Controls;
using LTSample.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(CustomTabbedPage), typeof(CustomTabbedPageRenderer))]
namespace LTSample.Droid.Renderers {
    public class CustomTabbedPageRenderer : TabbedPageRenderer {
        protected override void OnLayout(bool changed, int l, int t, int r, int b) {
            InvertLayoutThroughScale();
            base.OnLayout(changed, l, t, r, b);
        }

        private void InvertLayoutThroughScale() {
            ViewGroup.ScaleY = -1;

            TabLayout tabLayout = null;
            ViewPager viewPager = null;

            for (var i = 0; i < ChildCount; ++i) {
                var view = (Android.Views.View)GetChildAt(i);
                if (view is TabLayout) tabLayout = (TabLayout)view;
                else if (view is ViewPager) viewPager = (ViewPager)view;
            }

            tabLayout.ScaleY = viewPager.ScaleY = -1;
            viewPager.SetPadding(0, -tabLayout.MeasuredHeight - 60, 0, 0);
        }
    }
}
#pragma warning restore CS0618
