using System;
using System.Collections.Generic;
using System.Linq;

namespace Converter
{
	public class Converter_2_11
	{
		private static readonly Dictionary<char, int> _11to10digit = new Dictionary<char, int>
		{
			{ '0', 0},
			{ '1', 1},
			{ '2', 2},
			{ '3', 3},
			{ '4', 4},
			{ '5', 5},
			{ '6', 6},
			{ '7', 7},
			{ '8', 8},
			{ '9', 9},
			{ 'A', 10},
		};

		public static bool TryConvert(string input, out string output, Direction direction)
		{
			return direction == Direction._11_to_2
				? Try11To2(input, out output)
				: Try2To11(input, out output);
		}

		private static bool Try2To11(string input, out string output)
		{
			output = null;

			try
			{
				var dec = ConvertAnyTo10(input, digit => digit == '0' ? 0 : 1, 2);
				output = Convert10toAny(dec, decDigit => _11to10digit.First(kvp=>kvp.Value == decDigit).Key, 11);
				return true;
			}
			catch
			{
				// ignored
			}

			return false;
		}

		private static bool Try11To2(string input, out string output)
		{
			output = null;

			try
			{
				var dec = ConvertAnyTo10(input, digit => _11to10digit[digit], 11);
				output = Convert10toAny(dec, digit => digit == 0 ? '0' : '1', 2);
				return true;
			}
			catch
			{
				// ignored
			}

			return false;
		}

		private static decimal ConvertAnyTo10(string input, Func<char,int> digitToDec, int @base)
		{
			decimal result = 0;
			var digits = input.Reverse().ToArray();
			for (int index = 0; index < digits.Length; index++)
				result += digitToDec(digits[index]) * Pow(@base, index);
			return result;
		}

		private static string Convert10toAny(decimal input, Func<int, char> decToDigit, int @base)
		{
			var result = new List<int>();
			while (input != 0)
			{
				result.Add((int)(input % @base));
				input = Math.Floor(input / @base);
			}
			result.Reverse();
			return new string(result.Select(decToDigit).ToArray());
		}

		private static decimal Pow(int num, int power)
		{
			if(power < 0)
				throw new InvalidOperationException("Power can not be less 0");
			if (power == 0)
				return 1;

			decimal result = num;
			for (int i = 1; i < power; i++)
				result *= num;
			return result;
		}
	}
}
