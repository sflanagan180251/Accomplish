using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accomplish.ViewModels
{
    public interface IGoalViewModel : INotifyPropertyChanged
    {
        string Title
        {
            get;
            set;
        }

        string Description
        {
            get;
            set;
        }
    }
}
