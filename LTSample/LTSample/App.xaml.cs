using Prism;
using Prism.Ioc;
using LTSample.ViewModels;
using LTSample.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LTSample.Models;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace LTSample {
    public partial class App {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized() {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry) {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.RegisterSingleton<CoreModel>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<TabbedPage1, TabbedPage1ViewModel>();
            containerRegistry.RegisterForNavigation<TabbedPage2, TabbedPage1ViewModel>();
            containerRegistry.RegisterForNavigation<TabbedPage3, TabbedPage1ViewModel>();
        }
    }
}
