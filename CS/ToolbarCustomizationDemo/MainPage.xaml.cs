using System.Windows.Controls;
using DevExpress.Xpf.Bars;
// ...

namespace ToolbarCustomizationDemo {
    public partial class MainPage : UserControl {
        MainPageViewModel ViewModel {
            get { return (MainPageViewModel)DataContext; }
        }

        public MainPage() {
            InitializeComponent();
            preview.BarManager.ItemClick += BarManager_ItemClick;
        }

        void BarManager_ItemClick(object sender, ItemClickEventArgs e) {
            if (e.Item.Name == "clearButton") {
                ViewModel.PreviewModel.Clear();
            }
        }
    }
}
