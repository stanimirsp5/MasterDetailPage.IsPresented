using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace livelabel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LiveLabelMaster : ContentPage
    {
        public ListView ListView;


        public MasterDetailPage MasterDetailPage;
        public string LabelTextMetod;

        public LiveLabelMaster()
        {
            InitializeComponent();
        }

        public void CloseMasterHandler(object sender, EventArgs args)
        {
            var liveLabel = new LiveLabel();
            liveLabel.CloseMasterPage(sender, args);
        }

    }
}