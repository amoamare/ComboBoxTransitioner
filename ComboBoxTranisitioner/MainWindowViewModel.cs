using System.Collections.ObjectModel;
using ComboBoxTranisitioner.Pages;
using MaterialDesignThemes.Wpf.Transitions;

namespace ComboBoxTranisitioner
{
    internal class MainWindowViewModel : BaseViewModel
    {
        public ObservableCollection<CustomTransitionerSlide> Views { get; }

        internal MainWindowViewModel()
        {
            Views = new ObservableCollection<CustomTransitionerSlide>
            {
                new CustomTransitionerSlide
                {
                    Content = new Page1View(),
                    DisplayName = "Page 1",
                    OpeningEffect = new TransitionEffect(TransitionEffectKind.FadeIn),
                    BackwardWipe = new CircleWipe()
                },
                new CustomTransitionerSlide
                {
                    Content = new Page2View(),
                    DisplayName = "Page 2",
                    OpeningEffect = new TransitionEffect(TransitionEffectKind.FadeIn),
                    BackwardWipe = new CircleWipe()
                },
                new CustomTransitionerSlide
                {
                    Content = new Page3View(),
                    DisplayName = "Page 3",
                    OpeningEffect = new TransitionEffect(TransitionEffectKind.FadeIn),
                    BackwardWipe = new CircleWipe()
                },
                new CustomTransitionerSlide
                {
                    Content = new Page4View(),
                    DisplayName = "Page 4",
                    OpeningEffect = new TransitionEffect(TransitionEffectKind.FadeIn),
                    BackwardWipe = new CircleWipe()
                },
            };
        }


        private int _selectedIndex;

        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                if (_selectedIndex == value) return;
                _selectedIndex = value;
                OnPropertyChanged();
            }
        }
    }
}
