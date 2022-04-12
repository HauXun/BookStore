using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore.Extensions.Popup
{
	class DummyProcessor
	{
		Action onComplete;
		Thread backGroundWorker;

		public DummyProcessor(Action onComplete)
		{
			this.onComplete = onComplete;
		}

		public void StarProcessing()
		{
			backGroundWorker = new Thread(Process);
			backGroundWorker.Start();
		}

		private void Process()
		{
			Thread.Sleep(5000);
			this.onComplete();
		}
	}
}
