using LTSample.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace LTSample.ViewModels {
    public class MainPageViewModel : ViewModelBase {
        public ReactiveCommand<string> Command { get; }
        public ReactiveProperty<bool> Switch { get; }
        public MainPageViewModel(INavigationService navigationService, CoreModel coreModel) : base(navigationService) {
            Command = new ReactiveCommand<string>().WithSubscribe(async x => await navigationService.NavigateAsync(x));
            Switch = new ReactiveProperty<bool>();
            Switch.Subscribe(_ => coreModel.VisualSet(Switch.Value));
        }
    }
}
