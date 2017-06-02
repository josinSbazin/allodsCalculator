namespace AllodsCalc
{
	public class AClass
	{
		public readonly string name;
		public readonly bool hasSKU;
		public readonly double partDamage;

		public AClass(string name, bool hasSKU, double partDamage)
		{
			this.name = name;
			this.hasSKU = hasSKU;
			this.partDamage = partDamage;
		}

		public override string ToString()
		{
			return name;
		}
	}
}