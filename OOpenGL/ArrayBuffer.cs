using System;
using OpenTK.Graphics.OpenGL4;

namespace OOpenGL
{
	public class ArrayBuffer : GLResource
    {
        public ArrayBuffer()
        {
			Id = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, _arrayBuffer);

        }

		protected override void Free()
		{
			GL.DeleteBuffer(Id);
		}


		public int Id { get; }
    }
}
