using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace livelabel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LiveLabel : MasterDetailPage
    {
        public Xamarin.Forms.Color BarBackgroundColor { get; set; }
        public Xamarin.Forms.Color BarTextColor { get; set; }

        public LiveLabel()
        {
            InitializeComponent();
            IsPresented = false;
        }
        void CloseMasterPage(object sender, System.EventArgs e)
        {
            IsPresented = false;
        }
    }
}