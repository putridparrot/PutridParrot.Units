// <auto-generated>
// This code was generated by the UnitCodeGenerator tool
//
// Changes to this file will be lost if the code is regenerated
// </auto-generated>

namespace PutridParrot.Units;

public static class Temperature
{
	public static class Celsius
	{
		public static double ToFahrenheit(double value) => value * 1.8 + 32.0;
		public static double ToKelvin(double value) => value + 273.15;
		public static double ToRankine(double value) => value * 9.0/5.0 + 491.67;
	}
	public static class Fahrenheit
	{
		public static double ToCelsius(double value) => ((value - 32.0) * 5.0) / 9.0;
		public static double ToKelvin(double value) => (((value - 32.0) * 5.0) / 9.0) + 273.15;
		public static double ToRankine(double value) => value + 459.67;
	}
	public static class Kelvin
	{
		public static double ToCelsius(double value) => value - 273.15;
		public static double ToFahrenheit(double value) => ((value - 273.15) * 1.8) + 32.0;
		public static double ToRankine(double value) => value * 1.8;
	}
	public static class Rankine
	{
		public static double ToCelsius(double value) => (value - 491.67) * 5.0/9.0;
		public static double ToFahrenheit(double value) => value - 459.67;
		public static double ToKelvin(double value) => value / 1.8;
	}
}
