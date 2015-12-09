namespace Accomplish.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Accomplish.Model;
    using Prism.Events;
    using Prism.Mvvm;

    internal sealed class GoalListViewModel : BindableBase, IGoalListViewModel
    {
        public GoalListViewModel(IEventAggregator eventAggregator)
        {
            Goals = new ObservableCollection<IGoal>();

            eventAggregator.GetEvent<RibbonEvent>().Subscribe(eventType =>
            {
                switch (eventType)
                {
                    case RibbonEvent.EventType.Create:
                        break;
                    case RibbonEvent.EventType.Open:
                        break;
                    case RibbonEvent.EventType.Add:
                        AddEvent();
                        break;
                    case RibbonEvent.EventType.Save:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(eventType), eventType, null);
                }
            });
        }

        public ObservableCollection<IGoal> Goals
        {
            get;
            set;
        }

        private void AddEvent()
        {
            Goals.Add(new Goal(Guid.NewGuid()));
        }
    }
}