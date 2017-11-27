using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace FFManager.Views.ViewModels.ServiceAuthorization.TestService
{
    public class ServiceLoginPanelViewModel : ServiceAuthorizationPanelViewModelBase
    {
        public ServiceLoginPanelViewModel()
        {
            var testGrid = new Grid();
            testGrid.Background = Brushes.Red;

            this.Target = testGrid;
        }
    }
}
