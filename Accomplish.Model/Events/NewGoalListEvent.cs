using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accomplish.Model.Events
{
    using Prism.Events;
    public sealed class NewGoalListEvent : PubSubEvent<IGoalList>
    {
    }
}
