using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
	public class Conversion
	{
		public Direction Direction { get; set; }
		public string Source { get; set; }
		public string Destination { get; set; }

		public string DisplayName
		{
			get { return string.Format("{0} -> {1}", Source, Destination); }
		}
		public Conversion(string source, string destination, Direction direction)
		{
			Source = source;
			Destination = destination;
			Direction = direction;
		}

	}

	public enum Direction
	{
		_2_to_11,
		_11_to_2
	}
}
