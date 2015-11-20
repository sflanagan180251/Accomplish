using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accomplish.ViewModels
{
    public interface IGoalViewModel
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
