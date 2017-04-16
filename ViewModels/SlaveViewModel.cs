using System;
using KpdApps.Orationi.Client.Base;
using KpdApps.Orationi.Common.Contracts;

namespace KpdApps.Orationi.Client.ViewModels
{
	public class SlaveViewModel : ObservableObject
	{
		private SlaveInfo slaveInfo;

		public Guid Id => slaveInfo.Id;

		public int Order => slaveInfo.Order;

		public string Name
		{
			get { return slaveInfo.Name; }
			set
			{
				if (slaveInfo.Name == value)
					return;

				slaveInfo.Name = value;

				RaisePropertyChanged("Name");
			}
		}

		public DateTime LastActivity { get; set; }


		public SlaveViewModel(SlaveInfo slaveInfo)
		{
			this.slaveInfo = slaveInfo;
		}
	}
}
