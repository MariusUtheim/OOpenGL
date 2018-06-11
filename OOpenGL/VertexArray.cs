using System;
using System.Linq;
using OpenTK.Graphics.OpenGL4;

namespace OOpenGL
{
	public class VertexArray : GLResource
    {
		private static int BoundIndex;

        public VertexArray(VertexArrayPointerSpecifier[] pointers)
        {
			if (pointers == null)
				throw new ArgumentNullException();
			if (pointers.Length == 0)
				throw new ArgumentException();

			Id = GL.GenVertexArray();
			GL.BindVertexArray(Id);

			var stride = pointers.Sum(specifier => specifier.Count);

			var partialStride = 0;
			for (var i = 0; i < pointers.Length; i++)
			{
				GL.EnableVertexAttribArray(i);
				GL.VertexAttribPointer(i, pointers[i].Count, pointers[i].PointerType, pointers[i].Normalized, stride, partialStride);
				partialStride += pointers[i].Count * pointers[i].PointerType.Size;
			}
        }

		protected override void Free()
		{
			GL.DeleteVertexArray(Id);
		}

		public int Id { get; }

		private void Bind()
		{
			CheckDisposed();
			if (BoundIndex != Id)
				GL.BindVertexArray(Id);
		}

		public void EnableVertexAttribArray(int index)
		{
			Bind();
			GL.EnableVertexAttribArray(index);
		}
    }
}
