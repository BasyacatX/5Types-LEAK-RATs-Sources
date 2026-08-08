using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

public class AsyncLock
{
	private class Releaser : IDisposable
	{
		private AsyncLock m_lock;

		public Releaser(AsyncLock @lock)
		{
			m_lock = @lock;
		}

		public void Dispose()
		{
			if (m_lock != null)
			{
				m_lock.Release();
				m_lock = null;
			}
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose();
		}
	}

	[CompilerGenerated]
	private sealed class VB_0024StateMachine_2_LockAsync : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncTaskMethodBuilder<IDisposable> _0024Builder;

		internal AsyncLock _0024VB_0024Me;

		internal TaskAwaiter _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			IDisposable result;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = _0024VB_0024Me.m_semaphore.WaitAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_0024State = 0;
						_0024A0 = awaiter;
						ref AsyncTaskMethodBuilder<IDisposable> reference = ref _0024Builder;
						VB_0024StateMachine_2_LockAsync stateMachine = this;
						reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
						return;
					}
				}
				else
				{
					num = -1;
					_0024State = -1;
					awaiter = _0024A0;
					_0024A0 = default(TaskAwaiter);
				}
				awaiter.GetResult();
				awaiter = default(TaskAwaiter);
				result = new Releaser(_0024VB_0024Me);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception = ex;
				_0024State = -2;
				_0024Builder.SetException(exception);
				//////CraxsAlert.Showinformation("Sorry");
				return;
			}
			num = -2;
			_0024State = -2;
			_0024Builder.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerNonUserCode]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private SemaphoreSlim m_semaphore;

	public AsyncLock()
	{
		m_semaphore = new SemaphoreSlim(1, 1);
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_2_LockAsync))]
	[DebuggerStepThrough]
	public Task<IDisposable> LockAsync()
	{
		VB_0024StateMachine_2_LockAsync stateMachine = new VB_0024StateMachine_2_LockAsync();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncTaskMethodBuilder<IDisposable>.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
		return stateMachine._0024Builder.Task;
	}

	public void Release()
	{
		m_semaphore.Release();
	}
}
