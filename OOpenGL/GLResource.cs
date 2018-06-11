using System;
namespace OOpenGL
{
	public abstract class GLResource : IDisposable
    {
		      
		~GLResource()
		{
			if (!IsDisposed)
				throw new ObjectDisposedException("A GL resource was garbage collected before it was properly disposed.");
		}

		protected abstract void Free();

		public void Dispose()
		{
			CheckDisposed();
			Free();
			IsDisposed = true;
		}

		protected bool IsDisposed { get; private set; }

		protected void CheckDisposed()
		{
			if (!IsDisposed)
				throw new ObjectDisposedException("Object already disposed");
		}
    }
}
