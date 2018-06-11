using System;
using OpenTK.Graphics.OpenGL4;

namespace OOpenGL
{
	public class PointerType
	{
		private int _glType;

		private PointerType(int size, int glType)
		{
			this.Size = size;
			
		}

		public int Size { get; }

		public static PointerType Byte { get; } = new PointerType(1, (int)VertexAttribPointerType.Byte);

        public static PointerType Double { get; } = new PointerType(8, (int)VertexAttribPointerType.Double);

		public static PointerType Fixed { get; } = new PointerType(4, (int)VertexAttribPointerType.Fixed);

		public static PointerType Float { get; } = new PointerType(4, (int)VertexAttribPointerType.Float);

		public static PointerType HalfFloat { get; } = new PointerType(2, (int)VertexAttribPointerType.HalfFloat);

		public static PointerType Int { get; } = new PointerType(4, (int)VertexAttribPointerType.Int);

		public static PointerType Short { get; } = new PointerType(2, (int)VertexAttribPointerType.Short);

		public static PointerType UnsignedByte { get; } = new PointerType(1, (int)VertexAttribPointerType.UnsignedByte);

		public static PointerType UnsignedInt { get; } = new PointerType(4, (int)VertexAttribPointerType.UnsignedInt);
        
		public static PointerType UnsignedShort { get; } = new PointerType(2, (int)VertexAttribPointerType.UnsignedShort);


		public static implicit operator VertexAttribPointerType(PointerType type)
		{
			if (!Enum.IsDefined(typeof(VertexAttribPointerType), type._glType))
				throw new InvalidOperationException("Cannot use the specified pointer type as a VertexAttribPointerType.");

			return (VertexAttribPointerType)type._glType;
		}
    }
}