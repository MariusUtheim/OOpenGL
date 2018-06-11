namespace OOpenGL
{
    public class VertexArrayPointerSpecifier
    {

		public VertexArrayPointerSpecifier(int count, PointerType pointerType, bool normalized)
		{
			Count = count;
			PointerType = pointerType;
			Normalized = normalized;
		}

		public int Count { get; }

		public PointerType PointerType { get; }

		public bool Normalized { get; }


		public static VertexArrayPointerSpecifier Pointd2 { get; }
		    = new VertexArrayPointerSpecifier(2, PointerType.Double, false);

   		public static VertexArrayPointerSpecifier Pointd3 { get; }
    		= new VertexArrayPointerSpecifier(3, PointerType.Double, false);

		public static VertexArrayPointerSpecifier ColorBGRA { get; }
		    = new VertexArrayPointerSpecifier(4, PointerType.UnsignedByte, true);
    }
}