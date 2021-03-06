// <auto-generated>
// This code was generated by the UnitCodeGenerator tool
//
// Changes to this file will be lost if the code is regenerated
// </auto-generated>

namespace PutridParrot.Units
{
	using System;
	/// <summary>
	/// Angle conversion functions
	/// </summary>
	public static class Angle
	{
		/// <summary>
		/// Degrees conversion functions
		/// </summary>
		public static class Degrees
		{
			/// <summary>
			/// Converts the supplied Degrees value to Radians
			/// </summary>
			/// <param name="value">The Degrees input value</param>
			/// <returns>The value in Radians</returns>
			public static double ToRadians(double value) => value * Math.PI/180.0;
			/// <summary>
			/// Converts the supplied Degrees value to Gradians
			/// </summary>
			/// <param name="value">The Degrees input value</param>
			/// <returns>The value in Gradians</returns>
			public static double ToGradians(double value) => value * 200.0/180.0;
			/// <summary>
			/// Converts the supplied Degrees value to Milliradians
			/// </summary>
			/// <param name="value">The Degrees input value</param>
			/// <returns>The value in Milliradians</returns>
			public static double ToMilliradians(double value) => value * (1000.0 * Math.PI)/180.0;
			/// <summary>
			/// Converts the supplied Degrees value to Minute Of Arc
			/// </summary>
			/// <param name="value">The Degrees input value</param>
			/// <returns>The value in Minute Of Arc</returns>
			public static double ToMinuteOfArc(double value) => value * 60.0;
			/// <summary>
			/// Converts the supplied Degrees value to Seconds Of Arc
			/// </summary>
			/// <param name="value">The Degrees input value</param>
			/// <returns>The value in Seconds Of Arc</returns>
			public static double ToSecondsOfArc(double value) => value * 3600.0;
		}
		/// <summary>
		/// Gradians conversion functions
		/// </summary>
		public static class Gradians
		{
			/// <summary>
			/// Converts the supplied Gradians value to Degrees
			/// </summary>
			/// <param name="value">The Gradians input value</param>
			/// <returns>The value in Degrees</returns>
			public static double ToDegrees(double value) => value * 180.0/200.0;
			/// <summary>
			/// Converts the supplied Gradians value to Radians
			/// </summary>
			/// <param name="value">The Gradians input value</param>
			/// <returns>The value in Radians</returns>
			public static double ToRadians(double value) => value * Math.PI/200.0;
			/// <summary>
			/// Converts the supplied Gradians value to Milliradians
			/// </summary>
			/// <param name="value">The Gradians input value</param>
			/// <returns>The value in Milliradians</returns>
			public static double ToMilliradians(double value) => value * (1000.0*Math.PI)/200.0;
			/// <summary>
			/// Converts the supplied Gradians value to Minute Of Arc
			/// </summary>
			/// <param name="value">The Gradians input value</param>
			/// <returns>The value in Minute Of Arc</returns>
			public static double ToMinuteOfArc(double value) => value * 54.0;
			/// <summary>
			/// Converts the supplied Gradians value to Seconds Of Arc
			/// </summary>
			/// <param name="value">The Gradians input value</param>
			/// <returns>The value in Seconds Of Arc</returns>
			public static double ToSecondsOfArc(double value) => value * 3240.0;
		}
		/// <summary>
		/// Milliradians conversion functions
		/// </summary>
		public static class Milliradians
		{
			/// <summary>
			/// Converts the supplied Milliradians value to Degrees
			/// </summary>
			/// <param name="value">The Milliradians input value</param>
			/// <returns>The value in Degrees</returns>
			public static double ToDegrees(double value) => value * 180.0/(1000.0 * Math.PI);
			/// <summary>
			/// Converts the supplied Milliradians value to Radians
			/// </summary>
			/// <param name="value">The Milliradians input value</param>
			/// <returns>The value in Radians</returns>
			public static double ToRadians(double value) => value / 1000.0;
			/// <summary>
			/// Converts the supplied Milliradians value to Gradians
			/// </summary>
			/// <param name="value">The Milliradians input value</param>
			/// <returns>The value in Gradians</returns>
			public static double ToGradians(double value) => value * 200.0/(1000.0 * Math.PI);
			/// <summary>
			/// Converts the supplied Milliradians value to Minute Of Arc
			/// </summary>
			/// <param name="value">The Milliradians input value</param>
			/// <returns>The value in Minute Of Arc</returns>
			public static double ToMinuteOfArc(double value) => value * (60.0 * 180.0)/(1000.0 * Math.PI);
			/// <summary>
			/// Converts the supplied Milliradians value to Seconds Of Arc
			/// </summary>
			/// <param name="value">The Milliradians input value</param>
			/// <returns>The value in Seconds Of Arc</returns>
			public static double ToSecondsOfArc(double value) => value * (3600.0 * 180.0)/(1000.0 * Math.PI);
		}
		/// <summary>
		/// Minute Of Arc conversion functions
		/// </summary>
		public static class MinuteOfArc
		{
			/// <summary>
			/// Converts the supplied Minute Of Arc value to Degrees
			/// </summary>
			/// <param name="value">The Minute Of Arc input value</param>
			/// <returns>The value in Degrees</returns>
			public static double ToDegrees(double value) => value / 60.0;
			/// <summary>
			/// Converts the supplied Minute Of Arc value to Radians
			/// </summary>
			/// <param name="value">The Minute Of Arc input value</param>
			/// <returns>The value in Radians</returns>
			public static double ToRadians(double value) => value * Math.PI/(60.0 * 180.0);
			/// <summary>
			/// Converts the supplied Minute Of Arc value to Gradians
			/// </summary>
			/// <param name="value">The Minute Of Arc input value</param>
			/// <returns>The value in Gradians</returns>
			public static double ToGradians(double value) => value / 54.0;
			/// <summary>
			/// Converts the supplied Minute Of Arc value to Milliradians
			/// </summary>
			/// <param name="value">The Minute Of Arc input value</param>
			/// <returns>The value in Milliradians</returns>
			public static double ToMilliradians(double value) => value * (1000.0 * Math.PI) / (60.0 * 180.0);
			/// <summary>
			/// Converts the supplied Minute Of Arc value to Seconds Of Arc
			/// </summary>
			/// <param name="value">The Minute Of Arc input value</param>
			/// <returns>The value in Seconds Of Arc</returns>
			public static double ToSecondsOfArc(double value) => value * 60.0;
		}
		/// <summary>
		/// Radians conversion functions
		/// </summary>
		public static class Radians
		{
			/// <summary>
			/// Converts the supplied Radians value to Degrees
			/// </summary>
			/// <param name="value">The Radians input value</param>
			/// <returns>The value in Degrees</returns>
			public static double ToDegrees(double value) => value * 180.0/Math.PI;
			/// <summary>
			/// Converts the supplied Radians value to Gradians
			/// </summary>
			/// <param name="value">The Radians input value</param>
			/// <returns>The value in Gradians</returns>
			public static double ToGradians(double value) => value * 200.0/Math.PI;
			/// <summary>
			/// Converts the supplied Radians value to Milliradians
			/// </summary>
			/// <param name="value">The Radians input value</param>
			/// <returns>The value in Milliradians</returns>
			public static double ToMilliradians(double value) => value * 1000.0;
			/// <summary>
			/// Converts the supplied Radians value to Minute Of Arc
			/// </summary>
			/// <param name="value">The Radians input value</param>
			/// <returns>The value in Minute Of Arc</returns>
			public static double ToMinuteOfArc(double value) => value * (60.0 * 180.0)/Math.PI;
			/// <summary>
			/// Converts the supplied Radians value to Seconds Of Arc
			/// </summary>
			/// <param name="value">The Radians input value</param>
			/// <returns>The value in Seconds Of Arc</returns>
			public static double ToSecondsOfArc(double value) => value * (3600.0 * 180.0)/Math.PI;
		}
		/// <summary>
		/// Seconds Of Arc conversion functions
		/// </summary>
		public static class SecondsOfArc
		{
			/// <summary>
			/// Converts the supplied Seconds Of Arc value to Degrees
			/// </summary>
			/// <param name="value">The Seconds Of Arc input value</param>
			/// <returns>The value in Degrees</returns>
			public static double ToDegrees(double value) => value / 3600.0;
			/// <summary>
			/// Converts the supplied Seconds Of Arc value to Radians
			/// </summary>
			/// <param name="value">The Seconds Of Arc input value</param>
			/// <returns>The value in Radians</returns>
			public static double ToRadians(double value) => value * Math.PI/(180.0 * 3600.0);
			/// <summary>
			/// Converts the supplied Seconds Of Arc value to Gradians
			/// </summary>
			/// <param name="value">The Seconds Of Arc input value</param>
			/// <returns>The value in Gradians</returns>
			public static double ToGradians(double value) => value / 3240.0;
			/// <summary>
			/// Converts the supplied Seconds Of Arc value to Milliradians
			/// </summary>
			/// <param name="value">The Seconds Of Arc input value</param>
			/// <returns>The value in Milliradians</returns>
			public static double ToMilliradians(double value) => value * (1000.0 * Math.PI) / (180.0 * 3600.0);
			/// <summary>
			/// Converts the supplied Seconds Of Arc value to Minute Of Arc
			/// </summary>
			/// <param name="value">The Seconds Of Arc input value</param>
			/// <returns>The value in Minute Of Arc</returns>
			public static double ToMinuteOfArc(double value) => value / 60.0;
		}
	}
}
