// <auto-generated>
// This code was generated by the UnitCodeGenerator tool
//
// Changes to this file will be lost if the code is regenerated
// </auto-generated>

using NUnit.Framework;
using FsCheck;
using PropertyAttribute = FsCheck.NUnit.PropertyAttribute;

namespace PutridParrot.Units.Tests
{
	public class CelsiusTests
	{
		[Property]
		public void FromCelsiusToFahrenheitAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Celsius.ToFahrenheit(value);
				var convertBack = Temperature.Fahrenheit.ToCelsius(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(32.0, 89.6)]
		[TestCase(0.9, 33.62)]
		[TestCase(0.0, 32.0)]
		public void ConvertKnownCelsiusToFahrenheit(double input, double expectation)
		{
			var result = Temperature.Celsius.ToFahrenheit(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromCelsiusToKelvinAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Celsius.ToKelvin(value);
				var convertBack = Temperature.Kelvin.ToCelsius(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(1.0, 274.15)]
		[TestCase(9.9, 283.05)]
		[TestCase(100.0, 373.15)]
		public void ConvertKnownCelsiusToKelvin(double input, double expectation)
		{
			var result = Temperature.Celsius.ToKelvin(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromCelsiusToRankineAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Celsius.ToRankine(value);
				var convertBack = Temperature.Rankine.ToCelsius(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(900.0, 2111.67)]
		[TestCase(12.0, 513.27)]
		[TestCase(-3.0, 486.27)]
		public void ConvertKnownCelsiusToRankine(double input, double expectation)
		{
			var result = Temperature.Celsius.ToRankine(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromCelsiusToReaumurAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Celsius.ToReaumur(value);
				var convertBack = Temperature.Reaumur.ToCelsius(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(123.0, 98.4)]
		[TestCase(15.67, 12.536)]
		[TestCase(87.0, 69.6)]
		public void ConvertKnownCelsiusToReaumur(double input, double expectation)
		{
			var result = Temperature.Celsius.ToReaumur(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

	}
	public class FahrenheitTests
	{
		[Property]
		public void FromFahrenheitToCelsiusAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Fahrenheit.ToCelsius(value);
				var convertBack = Temperature.Celsius.ToFahrenheit(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(109.0, 42.7778)]
		[TestCase(56.9, 13.83333)]
		[TestCase(102.0, 38.8889)]
		public void ConvertKnownFahrenheitToCelsius(double input, double expectation)
		{
			var result = Temperature.Fahrenheit.ToCelsius(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromFahrenheitToKelvinAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Fahrenheit.ToKelvin(value);
				var convertBack = Temperature.Kelvin.ToFahrenheit(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(34.5, 274.5389)]
		[TestCase(901.0, 755.928)]
		[TestCase(23.9, 268.65)]
		public void ConvertKnownFahrenheitToKelvin(double input, double expectation)
		{
			var result = Temperature.Fahrenheit.ToKelvin(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromFahrenheitToRankineAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Fahrenheit.ToRankine(value);
				var convertBack = Temperature.Rankine.ToFahrenheit(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(123.0, 582.67)]
		[TestCase(9.2, 468.87)]
		[TestCase(0.2, 459.87)]
		public void ConvertKnownFahrenheitToRankine(double input, double expectation)
		{
			var result = Temperature.Fahrenheit.ToRankine(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromFahrenheitToReaumurAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Fahrenheit.ToReaumur(value);
				var convertBack = Temperature.Reaumur.ToFahrenheit(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(67.0, 15.555555556)]
		[TestCase(1.6, -13.511111111)]
		[TestCase(900.0, 385.77777778)]
		public void ConvertKnownFahrenheitToReaumur(double input, double expectation)
		{
			var result = Temperature.Fahrenheit.ToReaumur(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

	}
	public class KelvinTests
	{
		[Property]
		public void FromKelvinToCelsiusAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Kelvin.ToCelsius(value);
				var convertBack = Temperature.Celsius.ToKelvin(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(80.0, -193.15)]
		[TestCase(0.9, -272.25)]
		[TestCase(305.15, 32.0)]
		public void ConvertKnownKelvinToCelsius(double input, double expectation)
		{
			var result = Temperature.Kelvin.ToCelsius(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromKelvinToFahrenheitAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Kelvin.ToFahrenheit(value);
				var convertBack = Temperature.Fahrenheit.ToKelvin(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(123.4, -237.55)]
		[TestCase(800.0, 980.33)]
		[TestCase(99.999, -279.6718)]
		public void ConvertKnownKelvinToFahrenheit(double input, double expectation)
		{
			var result = Temperature.Kelvin.ToFahrenheit(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromKelvinToRankineAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Kelvin.ToRankine(value);
				var convertBack = Temperature.Rankine.ToKelvin(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(156.0, 280.8)]
		[TestCase(8.2, 14.76)]
		[TestCase(0.8, 1.44)]
		public void ConvertKnownKelvinToRankine(double input, double expectation)
		{
			var result = Temperature.Kelvin.ToRankine(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromKelvinToReaumurAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Kelvin.ToReaumur(value);
				var convertBack = Temperature.Reaumur.ToKelvin(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(900.0, 501.48)]
		[TestCase(1.3, -217.48)]
		[TestCase(60.0, -170.52)]
		public void ConvertKnownKelvinToReaumur(double input, double expectation)
		{
			var result = Temperature.Kelvin.ToReaumur(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

	}
	public class RankineTests
	{
		[Property]
		public void FromRankineToCelsiusAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Rankine.ToCelsius(value);
				var convertBack = Temperature.Celsius.ToRankine(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(190.0, -167.59444444)]
		[TestCase(0.7, -272.76111111)]
		[TestCase(900.0, 226.85)]
		public void ConvertKnownRankineToCelsius(double input, double expectation)
		{
			var result = Temperature.Rankine.ToCelsius(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromRankineToFahrenheitAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Rankine.ToFahrenheit(value);
				var convertBack = Temperature.Fahrenheit.ToRankine(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(109.0, -350.67)]
		[TestCase(3567.0, 3107.33)]
		[TestCase(9.0, -450.67)]
		public void ConvertKnownRankineToFahrenheit(double input, double expectation)
		{
			var result = Temperature.Rankine.ToFahrenheit(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromRankineToKelvinAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Rankine.ToKelvin(value);
				var convertBack = Temperature.Kelvin.ToRankine(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(123.0, 68.333333333)]
		[TestCase(0.9, 0.5)]
		[TestCase(23.0, 12.777777778)]
		public void ConvertKnownRankineToKelvin(double input, double expectation)
		{
			var result = Temperature.Rankine.ToKelvin(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromRankineToReaumurAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Rankine.ToReaumur(value);
				var convertBack = Temperature.Reaumur.ToRankine(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(900.0, 181.48)]
		[TestCase(34.9, -203.00888889)]
		[TestCase(0.7, -218.20888889)]
		public void ConvertKnownRankineToReaumur(double input, double expectation)
		{
			var result = Temperature.Rankine.ToReaumur(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

	}
	public class ReaumurTests
	{
		[Property]
		public void FromReaumurToKelvinAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Reaumur.ToKelvin(value);
				var convertBack = Temperature.Kelvin.ToReaumur(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(128.0, 433.15)]
		[TestCase(7.4, 282.4)]
		[TestCase(1.5, 275.025)]
		public void ConvertKnownReaumurToKelvin(double input, double expectation)
		{
			var result = Temperature.Reaumur.ToKelvin(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromReaumurToCelsiusAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Reaumur.ToCelsius(value);
				var convertBack = Temperature.Celsius.ToReaumur(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(1.5, 1.875)]
		[TestCase(23.9, 29.875)]
		[TestCase(0.3, 0.375)]
		public void ConvertKnownReaumurToCelsius(double input, double expectation)
		{
			var result = Temperature.Reaumur.ToCelsius(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromReaumurToFahrenheitAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Reaumur.ToFahrenheit(value);
				var convertBack = Temperature.Fahrenheit.ToReaumur(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.3, 32.675)]
		[TestCase(87.0, 227.75)]
		[TestCase(34.1, 108.725)]
		public void ConvertKnownReaumurToFahrenheit(double input, double expectation)
		{
			var result = Temperature.Reaumur.ToFahrenheit(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromReaumurToRankineAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Temperature.Reaumur.ToRankine(value);
				var convertBack = Temperature.Rankine.ToReaumur(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(34.1, 568.395)]
		[TestCase(10.6, 515.52)]
		[TestCase(1.9, 495.945)]
		public void ConvertKnownReaumurToRankine(double input, double expectation)
		{
			var result = Temperature.Reaumur.ToRankine(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

	}
}
