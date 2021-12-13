// <auto-generated>
// This code was generated by the UnitCodeGenerator tool
//
// Changes to this file will be lost if the code is regenerated
// </auto-generated>

namespace PutridParrot.Units;

/// <summary>
/// Pressure conversion functions
/// </summary>
public static class Pressure
{
	/// <summary>
	/// Atmospheres conversion functions
	/// </summary>
	public static class Atmospheres
	{
		/// <summary>
		/// Converts the supplied Atmospheres value to Bars
		/// </summary>
		/// <param name="value">The Atmospheres input value</param>
		/// <returns>The value in Bars</returns>
		public static double ToBars(double value) => value * 1.01325;
		/// <summary>
		/// Converts the supplied Atmospheres value to Pascals
		/// </summary>
		/// <param name="value">The Atmospheres input value</param>
		/// <returns>The value in Pascals</returns>
		public static double ToPascals(double value) => value * 101325.0;
		/// <summary>
		/// Converts the supplied Atmospheres value to Torrs
		/// </summary>
		/// <param name="value">The Atmospheres input value</param>
		/// <returns>The value in Torrs</returns>
		public static double ToTorrs(double value) => value * 760.0;
		/// <summary>
		/// Converts the supplied Atmospheres value to Psi
		/// </summary>
		/// <param name="value">The Atmospheres input value</param>
		/// <returns>The value in Psi</returns>
		public static double ToPsi(double value) => value * 14.69596432068;
	}
	/// <summary>
	/// Bars conversion functions
	/// </summary>
	public static class Bars
	{
		/// <summary>
		/// Converts the supplied Bars value to Atmospheres
		/// </summary>
		/// <param name="value">The Bars input value</param>
		/// <returns>The value in Atmospheres</returns>
		public static double ToAtmospheres(double value) => value / 1.01325;
		/// <summary>
		/// Converts the supplied Bars value to Pascals
		/// </summary>
		/// <param name="value">The Bars input value</param>
		/// <returns>The value in Pascals</returns>
		public static double ToPascals(double value) => value / 0.00001;
		/// <summary>
		/// Converts the supplied Bars value to Torrs
		/// </summary>
		/// <param name="value">The Bars input value</param>
		/// <returns>The value in Torrs</returns>
		public static double ToTorrs(double value) => value * 750.0616827042;
		/// <summary>
		/// Converts the supplied Bars value to Psi
		/// </summary>
		/// <param name="value">The Bars input value</param>
		/// <returns>The value in Psi</returns>
		public static double ToPsi(double value) => value * 14.50378911491;
	}
	/// <summary>
	/// Pascals conversion functions
	/// </summary>
	public static class Pascals
	{
		/// <summary>
		/// Converts the supplied Pascals value to Atmospheres
		/// </summary>
		/// <param name="value">The Pascals input value</param>
		/// <returns>The value in Atmospheres</returns>
		public static double ToAtmospheres(double value) => value / 101325.0;
		/// <summary>
		/// Converts the supplied Pascals value to Bars
		/// </summary>
		/// <param name="value">The Pascals input value</param>
		/// <returns>The value in Bars</returns>
		public static double ToBars(double value) => value * 0.00001;
		/// <summary>
		/// Converts the supplied Pascals value to Torrs
		/// </summary>
		/// <param name="value">The Pascals input value</param>
		/// <returns>The value in Torrs</returns>
		public static double ToTorrs(double value) => value * 0.007500616827042;
		/// <summary>
		/// Converts the supplied Pascals value to Psi
		/// </summary>
		/// <param name="value">The Pascals input value</param>
		/// <returns>The value in Psi</returns>
		public static double ToPsi(double value) => value * 0.0001450378911491;
	}
	/// <summary>
	/// Psi conversion functions
	/// </summary>
	public static class Psi
	{
		/// <summary>
		/// Converts the supplied Psi value to Bars
		/// </summary>
		/// <param name="value">The Psi input value</param>
		/// <returns>The value in Bars</returns>
		public static double ToBars(double value) => value / 14.50378911491;
		/// <summary>
		/// Converts the supplied Psi value to Pascals
		/// </summary>
		/// <param name="value">The Psi input value</param>
		/// <returns>The value in Pascals</returns>
		public static double ToPascals(double value) => value / 0.0001450378911491;
		/// <summary>
		/// Converts the supplied Psi value to Atmospheres
		/// </summary>
		/// <param name="value">The Psi input value</param>
		/// <returns>The value in Atmospheres</returns>
		public static double ToAtmospheres(double value) => value / 14.69596432068;
		/// <summary>
		/// Converts the supplied Psi value to Torrs
		/// </summary>
		/// <param name="value">The Psi input value</param>
		/// <returns>The value in Torrs</returns>
		public static double ToTorrs(double value) => value / 0.01933679515879;
	}
	/// <summary>
	/// Torrs conversion functions
	/// </summary>
	public static class Torrs
	{
		/// <summary>
		/// Converts the supplied Torrs value to Bars
		/// </summary>
		/// <param name="value">The Torrs input value</param>
		/// <returns>The value in Bars</returns>
		public static double ToBars(double value) => value / 750.0616827042;
		/// <summary>
		/// Converts the supplied Torrs value to Pascals
		/// </summary>
		/// <param name="value">The Torrs input value</param>
		/// <returns>The value in Pascals</returns>
		public static double ToPascals(double value) => value / 0.007500616827042;
		/// <summary>
		/// Converts the supplied Torrs value to Atmospheres
		/// </summary>
		/// <param name="value">The Torrs input value</param>
		/// <returns>The value in Atmospheres</returns>
		public static double ToAtmospheres(double value) => value / 760.0;
		/// <summary>
		/// Converts the supplied Torrs value to Psi
		/// </summary>
		/// <param name="value">The Torrs input value</param>
		/// <returns>The value in Psi</returns>
		public static double ToPsi(double value) => value * 0.01933679515879;
	}
}