using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LTSample.ViewModels {
    public class MainPageViewModel : ViewModelBase {
        public ReactiveCommand<string> Command { get; }
        public MainPageViewModel(INavigationService navigationService) : base(navigationService) {
            Command = new ReactiveCommand<string>().WithSubscribe(async x => await navigationService.NavigateAsync(x));
        }
    }
}
