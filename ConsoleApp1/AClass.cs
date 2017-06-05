namespace AllodsCalc
{
	public class AClass
	{
		public readonly string name;
		public readonly bool hasSKU;

		public AClass(string name, bool hasSKU)
		{
			this.name = name;
			this.hasSKU = hasSKU;
		}

		public override string ToString()
		{
			return name;
		}
	}
}