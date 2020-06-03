using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LTSample.Models {
    public class CoreModel : BindableBase {
        
        public IVisual Visual {
            get => visual;
            set => SetProperty(ref visual, value);
        }
        private IVisual visual;

        public void VisualSet(bool isMaterial) => Visual = isMaterial ? VisualMarker.Material : VisualMarker.Default; 
    }
}
