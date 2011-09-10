namespace OrcaMDF.Core.Engine.SqlTypes
{
	public class SqlImage : ISqlType
	{
		public bool IsVariableLength
		{
			get { return true; }
		}

		public short? FixedLength
		{
			get { return null; }
		}

		public object GetValue(byte[] value)
		{
			return value;
		}
	}
}