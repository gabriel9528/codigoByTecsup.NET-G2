using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCalimbru_MVVM.ViewModels;

namespace WpfCalimbru_MVVM
{
    public class BootStrapper : BootstrapperBase
    {
        public BootStrapper()
        {
            Initialize();
        }
        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e)
        {
            DisplayRootViewForAsync<ShellViewModel>();
        }
    }
}
