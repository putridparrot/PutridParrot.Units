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
	public class KilometrePerLitreTests
	{
		[Property]
		public void FromKilometrePerLitreToUSMilesPerGallonAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = FuelEconomy.KilometrePerLitre.ToUSMilesPerGallon(value);
				var convertBack = FuelEconomy.USMilesPerGallon.ToKilometrePerLitre(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(109.0, 256.384)]
		[TestCase(9.4, 22.1102)]
		[TestCase(1.3, 3.05779)]
		public void ConvertKnownKilometrePerLitreToUSMilesPerGallon(double input, double expectation)
		{
			var result = FuelEconomy.KilometrePerLitre.ToUSMilesPerGallon(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromKilometrePerLitreToMilesPerGallonAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = FuelEconomy.KilometrePerLitre.ToMilesPerGallon(value);
				var convertBack = FuelEconomy.MilesPerGallon.ToKilometrePerLitre(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(5.0, 14.124)]
		[TestCase(180.0, 508.466)]
		[TestCase(5.4, 15.254)]
		public void ConvertKnownKilometrePerLitreToMilesPerGallon(double input, double expectation)
		{
			var result = FuelEconomy.KilometrePerLitre.ToMilesPerGallon(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromKilometrePerLitreToLitresper100KilometresAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = FuelEconomy.KilometrePerLitre.ToLitresper100Kilometres(value);
				var convertBack = FuelEconomy.Litresper100Kilometres.ToKilometrePerLitre(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(109.0, 0.917431)]
		[TestCase(0.8, 125.0)]
		[TestCase(2.3, 43.4783)]
		public void ConvertKnownKilometrePerLitreToLitresper100Kilometres(double input, double expectation)
		{
			var result = FuelEconomy.KilometrePerLitre.ToLitresper100Kilometres(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

	}
	public class Litresper100KilometresTests
	{
		[Property]
		public void FromLitresper100KilometresToKilometrePerLitreAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = FuelEconomy.Litresper100Kilometres.ToKilometrePerLitre(value);
				var convertBack = FuelEconomy.KilometrePerLitre.ToLitresper100Kilometres(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.7, 142.857)]
		[TestCase(109.0, 0.917431)]
		[TestCase(0.012, 8333.3333)]
		public void ConvertKnownLitresper100KilometresToKilometrePerLitre(double input, double expectation)
		{
			var result = FuelEconomy.Litresper100Kilometres.ToKilometrePerLitre(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromLitresper100KilometresToMilesPerGallonAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = FuelEconomy.Litresper100Kilometres.ToMilesPerGallon(value);
				var convertBack = FuelEconomy.MilesPerGallon.ToLitresper100Kilometres(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(107.0, 2.64001)]
		[TestCase(0.8, 353.101)]
		[TestCase(0.02, 14124.05)]
		public void ConvertKnownLitresper100KilometresToMilesPerGallon(double input, double expectation)
		{
			var result = FuelEconomy.Litresper100Kilometres.ToMilesPerGallon(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromLitresper100KilometresToUSMilesPerGallonAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = FuelEconomy.Litresper100Kilometres.ToUSMilesPerGallon(value);
				var convertBack = FuelEconomy.USMilesPerGallon.ToLitresper100Kilometres(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(12.0, 19.6012)]
		[TestCase(0.3, 784.049)]
		[TestCase(1.5, 156.81)]
		public void ConvertKnownLitresper100KilometresToUSMilesPerGallon(double input, double expectation)
		{
			var result = FuelEconomy.Litresper100Kilometres.ToUSMilesPerGallon(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

	}
	public class MilesPerGallonTests
	{
		[Property]
		public void FromMilesPerGallonToKilometrePerLitreAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = FuelEconomy.MilesPerGallon.ToKilometrePerLitre(value);
				var convertBack = FuelEconomy.KilometrePerLitre.ToMilesPerGallon(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(12.0, 4.24807)]
		[TestCase(8.2, 2.90285)]
		[TestCase(0.5, 0.177003)]
		public void ConvertKnownMilesPerGallonToKilometrePerLitre(double input, double expectation)
		{
			var result = FuelEconomy.MilesPerGallon.ToKilometrePerLitre(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMilesPerGallonToUSMilesPerGallonAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = FuelEconomy.MilesPerGallon.ToUSMilesPerGallon(value);
				var convertBack = FuelEconomy.USMilesPerGallon.ToMilesPerGallon(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(1.4, 1.16574)]
		[TestCase(1008.0, 839.3356)]
		[TestCase(0.8, 0.666139)]
		public void ConvertKnownMilesPerGallonToUSMilesPerGallon(double input, double expectation)
		{
			var result = FuelEconomy.MilesPerGallon.ToUSMilesPerGallon(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMilesPerGallonToLitresper100KilometresAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = FuelEconomy.MilesPerGallon.ToLitresper100Kilometres(value);
				var convertBack = FuelEconomy.Litresper100Kilometres.ToMilesPerGallon(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(22.3, 12.66731)]
		[TestCase(0.4, 706.202)]
		[TestCase(5.2, 54.3233)]
		public void ConvertKnownMilesPerGallonToLitresper100Kilometres(double input, double expectation)
		{
			var result = FuelEconomy.MilesPerGallon.ToLitresper100Kilometres(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

	}
	public class USMilesPerGallonTests
	{
		[Property]
		public void FromUSMilesPerGallonToKilometrePerLitreAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = FuelEconomy.USMilesPerGallon.ToKilometrePerLitre(value);
				var convertBack = FuelEconomy.KilometrePerLitre.ToUSMilesPerGallon(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(23.0, 9.77831)]
		[TestCase(7.0, 2.97601)]
		[TestCase(0.9, 0.382629)]
		public void ConvertKnownUSMilesPerGallonToKilometrePerLitre(double input, double expectation)
		{
			var result = FuelEconomy.USMilesPerGallon.ToKilometrePerLitre(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromUSMilesPerGallonToMilesPerGallonAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = FuelEconomy.USMilesPerGallon.ToMilesPerGallon(value);
				var convertBack = FuelEconomy.MilesPerGallon.ToUSMilesPerGallon(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(109.0, 130.9036)]
		[TestCase(78.2, 93.91432)]
		[TestCase(0.9, 1.08086)]
		public void ConvertKnownUSMilesPerGallonToMilesPerGallon(double input, double expectation)
		{
			var result = FuelEconomy.USMilesPerGallon.ToMilesPerGallon(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromUSMilesPerGallonToLitresper100KilometresAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = FuelEconomy.USMilesPerGallon.ToLitresper100Kilometres(value);
				var convertBack = FuelEconomy.Litresper100Kilometres.ToUSMilesPerGallon(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(111.0, 2.11905)]
		[TestCase(0.4, 588.036)]
		[TestCase(5.2, 45.2336)]
		public void ConvertKnownUSMilesPerGallonToLitresper100Kilometres(double input, double expectation)
		{
			var result = FuelEconomy.USMilesPerGallon.ToLitresper100Kilometres(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

	}
}
