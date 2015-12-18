namespace Accomplish.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Accomplish.Model.Enum;
    using Model;
    using Prism.Events;
    using Prism.Mvvm;

    internal sealed class GoalListViewModel : BindableBase, IGoalListViewModel
    {
        private readonly IGoalFactory goalFactory;

        public GoalListViewModel(IEventAggregator eventAggregator, IGoalFactory goalFactory)
        {
            this.goalFactory = goalFactory;
            Goals = new ObservableCollection<IGoal>();

            eventAggregator.GetEvent<RibbonEvent>().Subscribe(eventType =>
            {
                switch (eventType)
                {
                    case RibbonEvent.EventType.Add:
                        AddEvent();
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
            Goals.Add(goalFactory.Create());
        }
    }
}