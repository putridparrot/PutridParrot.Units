// <auto-generated>
// This code was generated by the UnitCodeGenerator tool
//
// Changes to this file will be lost if the code is regenerated
// </auto-generated>

namespace PutridParrot.Units;

/// <summary>
/// Temperature conversion functions
/// </summary>
public static class Temperature
{
	/// <summary>
	/// Celsius conversion functions
	/// </summary>
	public static class Celsius
	{
		/// <summary>
		/// Converts the supplied Celsius value to Fahrenheit
		/// </summary>
		/// <param name="value">The Celsius input value</param>
		/// <returns>The value in Fahrenheit</returns>
		public static double ToFahrenheit(double value) => value * 1.8 + 32.0;
		/// <summary>
		/// Converts the supplied Celsius value to Kelvin
		/// </summary>
		/// <param name="value">The Celsius input value</param>
		/// <returns>The value in Kelvin</returns>
		public static double ToKelvin(double value) => value + 273.15;
		/// <summary>
		/// Converts the supplied Celsius value to Rankine
		/// </summary>
		/// <param name="value">The Celsius input value</param>
		/// <returns>The value in Rankine</returns>
		public static double ToRankine(double value) => value * 9.0/5.0 + 491.67;
	}
	/// <summary>
	/// Fahrenheit conversion functions
	/// </summary>
	public static class Fahrenheit
	{
		/// <summary>
		/// Converts the supplied Fahrenheit value to Celsius
		/// </summary>
		/// <param name="value">The Fahrenheit input value</param>
		/// <returns>The value in Celsius</returns>
		public static double ToCelsius(double value) => ((value - 32.0) * 5.0) / 9.0;
		/// <summary>
		/// Converts the supplied Fahrenheit value to Kelvin
		/// </summary>
		/// <param name="value">The Fahrenheit input value</param>
		/// <returns>The value in Kelvin</returns>
		public static double ToKelvin(double value) => (((value - 32.0) * 5.0) / 9.0) + 273.15;
		/// <summary>
		/// Converts the supplied Fahrenheit value to Rankine
		/// </summary>
		/// <param name="value">The Fahrenheit input value</param>
		/// <returns>The value in Rankine</returns>
		public static double ToRankine(double value) => value + 459.67;
	}
	/// <summary>
	/// Kelvin conversion functions
	/// </summary>
	public static class Kelvin
	{
		/// <summary>
		/// Converts the supplied Kelvin value to Celsius
		/// </summary>
		/// <param name="value">The Kelvin input value</param>
		/// <returns>The value in Celsius</returns>
		public static double ToCelsius(double value) => value - 273.15;
		/// <summary>
		/// Converts the supplied Kelvin value to Fahrenheit
		/// </summary>
		/// <param name="value">The Kelvin input value</param>
		/// <returns>The value in Fahrenheit</returns>
		public static double ToFahrenheit(double value) => ((value - 273.15) * 1.8) + 32.0;
		/// <summary>
		/// Converts the supplied Kelvin value to Rankine
		/// </summary>
		/// <param name="value">The Kelvin input value</param>
		/// <returns>The value in Rankine</returns>
		public static double ToRankine(double value) => value * 1.8;
	}
	/// <summary>
	/// Rankine conversion functions
	/// </summary>
	public static class Rankine
	{
		/// <summary>
		/// Converts the supplied Rankine value to Celsius
		/// </summary>
		/// <param name="value">The Rankine input value</param>
		/// <returns>The value in Celsius</returns>
		public static double ToCelsius(double value) => (value - 491.67) * 5.0/9.0;
		/// <summary>
		/// Converts the supplied Rankine value to Fahrenheit
		/// </summary>
		/// <param name="value">The Rankine input value</param>
		/// <returns>The value in Fahrenheit</returns>
		public static double ToFahrenheit(double value) => value - 459.67;
		/// <summary>
		/// Converts the supplied Rankine value to Kelvin
		/// </summary>
		/// <param name="value">The Rankine input value</param>
		/// <returns>The value in Kelvin</returns>
		public static double ToKelvin(double value) => value / 1.8;
	}
}
