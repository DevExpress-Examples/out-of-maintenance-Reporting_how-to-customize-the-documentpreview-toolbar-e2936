using System.Windows.Controls;
using DevExpress.Xpf.Bars;
// ...

namespace ToolbarCustomizationDemo {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            preview.BarManager.ItemClick += new ItemClickEventHandler(BarManager_ItemClick);
        }

        void BarManager_ItemClick(object sender, ItemClickEventArgs e) {
            if (e.Item.Name == "clearButton") {
                ((MainPageViewModel)DataContext).PreviewModel.Clear();
            }
        }

    }
}
