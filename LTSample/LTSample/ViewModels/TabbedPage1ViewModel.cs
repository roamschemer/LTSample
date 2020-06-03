using LTSample.Models;
using Prism.Commands;
using Prism.Mvvm;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace LTSample.ViewModels {
    public class TabbedPage1ViewModel : BindableBase {
        public ReactiveCollection<string> Collection { get; }
        public ReactiveProperty<bool> Switch { get; }
        public ReactiveProperty<IVisual> Visual { get; } 
        public TabbedPage1ViewModel(CoreModel coreModel) {
            var items = new[] {"万葉集","古今和歌集","古事記","日本書紀","奥の細道" };
            Collection = new ReactiveCollection<string>();
            foreach(var item in items) {
                Collection.Add(item);
            }
            Visual = coreModel.ObserveProperty(x => x.Visual).ToReactiveProperty();
        }
    }
}
