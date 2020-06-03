using Prism.Commands;
using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LTSample.ViewModels {
    public class TabbedPage1ViewModel : BindableBase {
        public ReactiveCollection<string> Collection { get; }
        public TabbedPage1ViewModel() {
            var items = new[] {"万葉集","古今和歌集","古事記","日本書紀","奥の細道" };
            Collection = new ReactiveCollection<string>();
            foreach(var item in items) {
                Collection.Add(item);
            }
        }
    }
}
