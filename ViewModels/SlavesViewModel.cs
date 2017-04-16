using System.Collections.ObjectModel;
using KpdApps.Orationi.Client.Base;
using KpdApps.Orationi.Common.Contracts;

namespace KpdApps.Orationi.Client.ViewModels
{
	public class SlavesViewModel : ObservableObject
	{
		public ObservableCollection<SlaveViewModel> Slaves { get; set; }

		public SlavesViewModel(SlaveInfoList slaveInfoList)
		{
			Slaves = new ObservableCollection<SlaveViewModel>();

			if (slaveInfoList.Count == 0)
				return;

			foreach (SlaveInfo slaveInfo in slaveInfoList)
			{
				SlaveViewModel slaveViewModel = new SlaveViewModel(slaveInfo);
				Slaves.Add(slaveViewModel);
			}
		}
	}
}
