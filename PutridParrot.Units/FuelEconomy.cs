// <auto-generated>
// This code was generated by the UnitCodeGenerator tool
//
// Changes to this file will be lost if the code is regenerated
// </auto-generated>

namespace PutridParrot.Units
{
	/// <summary>
	/// Fuel Economy conversion functions
	/// </summary>
	public static class FuelEconomy
	{
		/// <summary>
		/// Kilometre Per Litre conversion functions
		/// </summary>
		public static class KilometrePerLitre
		{
			/// <summary>
			/// Converts the supplied Kilometre Per Litre value to US Miles Per Gallon
			/// </summary>
			/// <param name="value">The Kilometre Per Litre input value</param>
			/// <returns>The value in US Miles Per Gallon</returns>
			public static double ToUSMilesPerGallon(double value) => value * 2.35215;
			/// <summary>
			/// Converts the supplied Kilometre Per Litre value to Miles Per Gallon
			/// </summary>
			/// <param name="value">The Kilometre Per Litre input value</param>
			/// <returns>The value in Miles Per Gallon</returns>
			public static double ToMilesPerGallon(double value) => value * 2.82481;
			/// <summary>
			/// Converts the supplied Kilometre Per Litre value to Litres Per 100 Kilometres
			/// </summary>
			/// <param name="value">The Kilometre Per Litre input value</param>
			/// <returns>The value in Litres Per 100 Kilometres</returns>
			public static double ToLitresPer100Kilometres(double value) => 100.0 / value;
		}
		/// <summary>
		/// Litres Per 100 Kilometres conversion functions
		/// </summary>
		public static class LitresPer100Kilometres
		{
			/// <summary>
			/// Converts the supplied Litres Per 100 Kilometres value to Kilometre Per Litre
			/// </summary>
			/// <param name="value">The Litres Per 100 Kilometres input value</param>
			/// <returns>The value in Kilometre Per Litre</returns>
			public static double ToKilometrePerLitre(double value) => 100.0 / value;
			/// <summary>
			/// Converts the supplied Litres Per 100 Kilometres value to Miles Per Gallon
			/// </summary>
			/// <param name="value">The Litres Per 100 Kilometres input value</param>
			/// <returns>The value in Miles Per Gallon</returns>
			public static double ToMilesPerGallon(double value) => 282.481 / value;
			/// <summary>
			/// Converts the supplied Litres Per 100 Kilometres value to US Miles Per Gallon
			/// </summary>
			/// <param name="value">The Litres Per 100 Kilometres input value</param>
			/// <returns>The value in US Miles Per Gallon</returns>
			public static double ToUSMilesPerGallon(double value) => 235.215 / value;
		}
		/// <summary>
		/// Miles Per Gallon conversion functions
		/// </summary>
		public static class MilesPerGallon
		{
			/// <summary>
			/// Converts the supplied Miles Per Gallon value to Kilometre Per Litre
			/// </summary>
			/// <param name="value">The Miles Per Gallon input value</param>
			/// <returns>The value in Kilometre Per Litre</returns>
			public static double ToKilometrePerLitre(double value) => value / 2.82481;
			/// <summary>
			/// Converts the supplied Miles Per Gallon value to US Miles Per Gallon
			/// </summary>
			/// <param name="value">The Miles Per Gallon input value</param>
			/// <returns>The value in US Miles Per Gallon</returns>
			public static double ToUSMilesPerGallon(double value) => value / 1.20095;
			/// <summary>
			/// Converts the supplied Miles Per Gallon value to Litres Per 100 Kilometres
			/// </summary>
			/// <param name="value">The Miles Per Gallon input value</param>
			/// <returns>The value in Litres Per 100 Kilometres</returns>
			public static double ToLitresPer100Kilometres(double value) => 282.481 / value;
		}
		/// <summary>
		/// US Miles Per Gallon conversion functions
		/// </summary>
		public static class USMilesPerGallon
		{
			/// <summary>
			/// Converts the supplied US Miles Per Gallon value to Kilometre Per Litre
			/// </summary>
			/// <param name="value">The US Miles Per Gallon input value</param>
			/// <returns>The value in Kilometre Per Litre</returns>
			public static double ToKilometrePerLitre(double value) => value / 2.35215;
			/// <summary>
			/// Converts the supplied US Miles Per Gallon value to Miles Per Gallon
			/// </summary>
			/// <param name="value">The US Miles Per Gallon input value</param>
			/// <returns>The value in Miles Per Gallon</returns>
			public static double ToMilesPerGallon(double value) => value * 1.20095;
			/// <summary>
			/// Converts the supplied US Miles Per Gallon value to Litres Per 100 Kilometres
			/// </summary>
			/// <param name="value">The US Miles Per Gallon input value</param>
			/// <returns>The value in Litres Per 100 Kilometres</returns>
			public static double ToLitresPer100Kilometres(double value) => 235.215 / value;
		}
	}
}
