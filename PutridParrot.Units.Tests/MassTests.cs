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
	public class CaratsTests
	{
		[Property]
		public void FromCaratsToMilligramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Carats.ToMilligrams(value);
				var convertBack = Mass.Milligrams.ToCarats(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(2.1, 420.0)]
		[TestCase(123.0, 24600.0)]
		[TestCase(0.8, 160.0)]
		public void ConvertKnownCaratsToMilligrams(double input, double expectation)
		{
			var result = Mass.Carats.ToMilligrams(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromCaratsToGramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Carats.ToGrams(value);
				var convertBack = Mass.Grams.ToCarats(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.8, 0.16)]
		[TestCase(1.5, 0.3)]
		[TestCase(12.0, 2.4)]
		public void ConvertKnownCaratsToGrams(double input, double expectation)
		{
			var result = Mass.Carats.ToGrams(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromCaratsToKilogramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Carats.ToKilograms(value);
				var convertBack = Mass.Kilograms.ToCarats(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(1009.0, 0.2018)]
		[TestCase(999.0, 0.1998)]
		[TestCase(1234.5, 0.2469)]
		public void ConvertKnownCaratsToKilograms(double input, double expectation)
		{
			var result = Mass.Carats.ToKilograms(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromCaratsToTonnesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Carats.ToTonnes(value);
				var convertBack = Mass.Tonnes.ToCarats(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(1234567.0, 0.2469134)]
		[TestCase(9999999.0, 1.9999998)]
		[TestCase(998877.99, 0.199775598)]
		public void ConvertKnownCaratsToTonnes(double input, double expectation)
		{
			var result = Mass.Carats.ToTonnes(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromCaratsToOuncesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Carats.ToOunces(value);
				var convertBack = Mass.Ounces.ToCarats(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(900.0, 6.34931)]
		[TestCase(123.45, 0.870914121)]
		[TestCase(800.0, 5.64383)]
		public void ConvertKnownCaratsToOunces(double input, double expectation)
		{
			var result = Mass.Carats.ToOunces(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromCaratsToPoundsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Carats.ToPounds(value);
				var convertBack = Mass.Pounds.ToCarats(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(1000.0, 0.440925)]
		[TestCase(123456.0, 54.4347781)]
		[TestCase(800.0, 0.35274)]
		public void ConvertKnownCaratsToPounds(double input, double expectation)
		{
			var result = Mass.Carats.ToPounds(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromCaratsToStonesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Carats.ToStones(value);
				var convertBack = Mass.Stones.ToCarats(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(9000.0, 0.2834515)]
		[TestCase(123456.0, 3.88819843)]
		[TestCase(80000.8, 2.519593906)]
		public void ConvertKnownCaratsToStones(double input, double expectation)
		{
			var result = Mass.Carats.ToStones(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

	}
	public class GramsTests
	{
		[Property]
		public void FromGramsToMilligramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Grams.ToMilligrams(value);
				var convertBack = Mass.Milligrams.ToGrams(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(1.2, 1200.0)]
		[TestCase(0.9, 900.0)]
		[TestCase(2.0, 2000.0)]
		public void ConvertKnownGramsToMilligrams(double input, double expectation)
		{
			var result = Mass.Grams.ToMilligrams(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromGramsToKilogramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Grams.ToKilograms(value);
				var convertBack = Mass.Kilograms.ToGrams(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(900.0, 0.9)]
		[TestCase(12345.0, 12.345)]
		[TestCase(670.0, 0.67)]
		public void ConvertKnownGramsToKilograms(double input, double expectation)
		{
			var result = Mass.Grams.ToKilograms(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromGramsToTonnesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Grams.ToTonnes(value);
				var convertBack = Mass.Tonnes.ToGrams(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(6700000.0, 6.7)]
		[TestCase(123456.0, 0.123456)]
		[TestCase(9809789.0, 9.809789)]
		public void ConvertKnownGramsToTonnes(double input, double expectation)
		{
			var result = Mass.Grams.ToTonnes(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromGramsToOuncesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Grams.ToOunces(value);
				var convertBack = Mass.Ounces.ToGrams(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(4.3, 0.151678)]
		[TestCase(170.0, 5.99657)]
		[TestCase(9.0, 0.317466)]
		public void ConvertKnownGramsToOunces(double input, double expectation)
		{
			var result = Mass.Grams.ToOunces(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromGramsToPoundsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Grams.ToPounds(value);
				var convertBack = Mass.Pounds.ToGrams(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(80.0, 0.17637)]
		[TestCase(190.0, 0.418878)]
		[TestCase(4500.0, 9.920802)]
		public void ConvertKnownGramsToPounds(double input, double expectation)
		{
			var result = Mass.Grams.ToPounds(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromGramsToStonesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Grams.ToStones(value);
				var convertBack = Mass.Stones.ToGrams(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(8000.0, 1.259784)]
		[TestCase(12345.0, 1.9440047)]
		[TestCase(900.0, 0.141726)]
		public void ConvertKnownGramsToStones(double input, double expectation)
		{
			var result = Mass.Grams.ToStones(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromGramsToCaratsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Grams.ToCarats(value);
				var convertBack = Mass.Carats.ToGrams(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(123.0, 615.0)]
		[TestCase(90.1, 450.5)]
		[TestCase(5000.0, 25000.0)]
		public void ConvertKnownGramsToCarats(double input, double expectation)
		{
			var result = Mass.Grams.ToCarats(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

	}
	public class KilogramsTests
	{
		[Property]
		public void FromKilogramsToMilligramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Kilograms.ToMilligrams(value);
				var convertBack = Mass.Milligrams.ToKilograms(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.9, 900000.0)]
		[TestCase(0.56, 560000.0)]
		[TestCase(0.007, 7000.0)]
		public void ConvertKnownKilogramsToMilligrams(double input, double expectation)
		{
			var result = Mass.Kilograms.ToMilligrams(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromKilogramsToGramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Kilograms.ToGrams(value);
				var convertBack = Mass.Grams.ToKilograms(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.8, 800.0)]
		[TestCase(12.0, 12000.0)]
		[TestCase(0.2, 200.0)]
		public void ConvertKnownKilogramsToGrams(double input, double expectation)
		{
			var result = Mass.Kilograms.ToGrams(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromKilogramsToTonnesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Kilograms.ToTonnes(value);
				var convertBack = Mass.Tonnes.ToKilograms(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(123.0, 0.123)]
		[TestCase(9000.0, 9.0)]
		[TestCase(2300.0, 2.3)]
		public void ConvertKnownKilogramsToTonnes(double input, double expectation)
		{
			var result = Mass.Kilograms.ToTonnes(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromKilogramsToOuncesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Kilograms.ToOunces(value);
				var convertBack = Mass.Ounces.ToKilograms(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(2300.0, 81130.19)]
		[TestCase(12.0, 423.288)]
		[TestCase(3.4, 119.931)]
		public void ConvertKnownKilogramsToOunces(double input, double expectation)
		{
			var result = Mass.Kilograms.ToOunces(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromKilogramsToPoundsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Kilograms.ToPounds(value);
				var convertBack = Mass.Pounds.ToKilograms(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(3.4, 7.49572)]
		[TestCase(0.9, 1.98416)]
		[TestCase(3.0, 6.61387)]
		public void ConvertKnownKilogramsToPounds(double input, double expectation)
		{
			var result = Mass.Kilograms.ToPounds(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromKilogramsToStonesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Kilograms.ToStones(value);
				var convertBack = Mass.Stones.ToKilograms(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(3.0, 0.472419)]
		[TestCase(98.0, 15.4324)]
		[TestCase(1.2, 0.188968)]
		public void ConvertKnownKilogramsToStones(double input, double expectation)
		{
			var result = Mass.Kilograms.ToStones(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromKilogramsToCaratsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Kilograms.ToCarats(value);
				var convertBack = Mass.Carats.ToKilograms(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.1, 500.0)]
		[TestCase(0.08, 400.0)]
		[TestCase(2.0, 10000.0)]
		public void ConvertKnownKilogramsToCarats(double input, double expectation)
		{
			var result = Mass.Kilograms.ToCarats(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

	}
	public class MilligramsTests
	{
		[Property]
		public void FromMilligramsToGramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Milligrams.ToGrams(value);
				var convertBack = Mass.Grams.ToMilligrams(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(190.0, 0.19)]
		[TestCase(2300.0, 2.3)]
		[TestCase(19000.0, 19.0)]
		public void ConvertKnownMilligramsToGrams(double input, double expectation)
		{
			var result = Mass.Milligrams.ToGrams(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMilligramsToKilogramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Milligrams.ToKilograms(value);
				var convertBack = Mass.Kilograms.ToMilligrams(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(1234567.0, 1.234567)]
		[TestCase(900800.0, 0.9008)]
		[TestCase(7800000.0, 7.8)]
		public void ConvertKnownMilligramsToKilograms(double input, double expectation)
		{
			var result = Mass.Milligrams.ToKilograms(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMilligramsToTonnesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Milligrams.ToTonnes(value);
				var convertBack = Mass.Tonnes.ToMilligrams(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(900000000.0, 0.9)]
		[TestCase(60000000.0, 0.06)]
		[TestCase(123456789.0, 0.123456789)]
		public void ConvertKnownMilligramsToTonnes(double input, double expectation)
		{
			var result = Mass.Milligrams.ToTonnes(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMilligramsToOuncesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Milligrams.ToOunces(value);
				var convertBack = Mass.Ounces.ToMilligrams(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(6000.0, 0.2116438)]
		[TestCase(123456.0, 4.35478225)]
		[TestCase(8001.0, 0.282227)]
		public void ConvertKnownMilligramsToOunces(double input, double expectation)
		{
			var result = Mass.Milligrams.ToOunces(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMilligramsToPoundsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Milligrams.ToPounds(value);
				var convertBack = Mass.Pounds.ToMilligrams(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(123456.0, 0.27217389)]
		[TestCase(800900.0, 1.76568226)]
		[TestCase(666666.0, 1.46974694)]
		public void ConvertKnownMilligramsToPounds(double input, double expectation)
		{
			var result = Mass.Milligrams.ToPounds(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMilligramsToStonesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Milligrams.ToStones(value);
				var convertBack = Mass.Stones.ToMilligrams(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(900000.0, 0.14172574)]
		[TestCase(12345678.0, 1.9441115001)]
		[TestCase(800100.0, 0.125994183)]
		public void ConvertKnownMilligramsToStones(double input, double expectation)
		{
			var result = Mass.Milligrams.ToStones(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMilligramsToCaratsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Milligrams.ToCarats(value);
				var convertBack = Mass.Carats.ToMilligrams(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(600.0, 3.0)]
		[TestCase(1234.0, 6.17)]
		[TestCase(9090.0, 45.45)]
		public void ConvertKnownMilligramsToCarats(double input, double expectation)
		{
			var result = Mass.Milligrams.ToCarats(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

	}
	public class OuncesTests
	{
		[Property]
		public void FromOuncesToMilligramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Ounces.ToMilligrams(value);
				var convertBack = Mass.Milligrams.ToOunces(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.2, 5669.9)]
		[TestCase(12.0, 340194.2772)]
		[TestCase(1.8, 51029.141579)]
		public void ConvertKnownOuncesToMilligrams(double input, double expectation)
		{
			var result = Mass.Ounces.ToMilligrams(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromOuncesToGramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Ounces.ToGrams(value);
				var convertBack = Mass.Grams.ToOunces(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(2.0, 56.699)]
		[TestCase(0.3, 8.50486)]
		[TestCase(7.0, 198.447)]
		public void ConvertKnownOuncesToGrams(double input, double expectation)
		{
			var result = Mass.Ounces.ToGrams(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromOuncesToKilogramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Ounces.ToKilograms(value);
				var convertBack = Mass.Kilograms.ToOunces(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(56.0, 1.58757)]
		[TestCase(123.0, 3.48699)]
		[TestCase(100.9, 2.8604669)]
		public void ConvertKnownOuncesToKilograms(double input, double expectation)
		{
			var result = Mass.Ounces.ToKilograms(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromOuncesToTonnesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Ounces.ToTonnes(value);
				var convertBack = Mass.Tonnes.ToOunces(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(8000.0, 0.2267962)]
		[TestCase(1234567.0, 34.99938572)]
		[TestCase(900800.0, 25.5372504)]
		public void ConvertKnownOuncesToTonnes(double input, double expectation)
		{
			var result = Mass.Ounces.ToTonnes(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromOuncesToPoundsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Ounces.ToPounds(value);
				var convertBack = Mass.Pounds.ToOunces(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(90.0, 5.625)]
		[TestCase(5.2, 0.325)]
		[TestCase(12.0, 0.75)]
		public void ConvertKnownOuncesToPounds(double input, double expectation)
		{
			var result = Mass.Ounces.ToPounds(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromOuncesToStonesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Ounces.ToStones(value);
				var convertBack = Mass.Stones.ToOunces(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(167.0, 0.745536)]
		[TestCase(800.7, 3.5745536)]
		[TestCase(1234.5, 5.51116071)]
		public void ConvertKnownOuncesToStones(double input, double expectation)
		{
			var result = Mass.Ounces.ToStones(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromOuncesToCaratsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Ounces.ToCarats(value);
				var convertBack = Mass.Carats.ToOunces(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.0012, 0.170097139)]
		[TestCase(4.0, 566.99)]
		[TestCase(1.4, 198.447)]
		public void ConvertKnownOuncesToCarats(double input, double expectation)
		{
			var result = Mass.Ounces.ToCarats(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

	}
	public class PoundsTests
	{
		[Property]
		public void FromPoundsToMilligramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Pounds.ToMilligrams(value);
				var convertBack = Mass.Milligrams.ToPounds(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(2.2, 997903.214)]
		[TestCase(0.7, 317514.6589)]
		[TestCase(0.32, 145149.5584)]
		public void ConvertKnownPoundsToMilligrams(double input, double expectation)
		{
			var result = Mass.Pounds.ToMilligrams(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromPoundsToGramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Pounds.ToGrams(value);
				var convertBack = Mass.Grams.ToPounds(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.3, 136.078)]
		[TestCase(1.2, 544.311)]
		[TestCase(9.0, 4082.33)]
		public void ConvertKnownPoundsToGrams(double input, double expectation)
		{
			var result = Mass.Pounds.ToGrams(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromPoundsToKilogramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Pounds.ToKilograms(value);
				var convertBack = Mass.Kilograms.ToPounds(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(5.0, 2.26796)]
		[TestCase(1.1, 0.498952)]
		[TestCase(0.7, 0.317515)]
		public void ConvertKnownPoundsToKilograms(double input, double expectation)
		{
			var result = Mass.Pounds.ToKilograms(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromPoundsToTonnesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Pounds.ToTonnes(value);
				var convertBack = Mass.Tonnes.ToPounds(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(1233.0, 0.5592794)]
		[TestCase(656565.0, 297.812874)]
		[TestCase(900.0, 0.408233)]
		public void ConvertKnownPoundsToTonnes(double input, double expectation)
		{
			var result = Mass.Pounds.ToTonnes(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromPoundsToOuncesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Pounds.ToOunces(value);
				var convertBack = Mass.Ounces.ToPounds(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(45.0, 720.0)]
		[TestCase(6.7, 107.2)]
		[TestCase(89.1, 1425.6)]
		public void ConvertKnownPoundsToOunces(double input, double expectation)
		{
			var result = Mass.Pounds.ToOunces(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromPoundsToStonesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Pounds.ToStones(value);
				var convertBack = Mass.Stones.ToPounds(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(89.1, 6.364286)]
		[TestCase(1.2, 0.0857143)]
		[TestCase(789.0, 56.3571)]
		public void ConvertKnownPoundsToStones(double input, double expectation)
		{
			var result = Mass.Pounds.ToStones(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromPoundsToCaratsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Pounds.ToCarats(value);
				var convertBack = Mass.Carats.ToPounds(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(80.0, 181436.7522)]
		[TestCase(2.34, 5307.031)]
		[TestCase(0.9, 2041.17)]
		public void ConvertKnownPoundsToCarats(double input, double expectation)
		{
			var result = Mass.Pounds.ToCarats(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

	}
	public class StonesTests
	{
		[Property]
		public void FromStonesToMilligramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Stones.ToMilligrams(value);
				var convertBack = Mass.Milligrams.ToStones(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.009, 57152.63861)]
		[TestCase(0.002, 12700.586)]
		[TestCase(0.0006, 3810.17591)]
		public void ConvertKnownStonesToMilligrams(double input, double expectation)
		{
			var result = Mass.Stones.ToMilligrams(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromStonesToGramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Stones.ToGrams(value);
				var convertBack = Mass.Grams.ToStones(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(1.2, 7620.35)]
		[TestCase(8.0, 50802.34543)]
		[TestCase(90.0, 571526.38619)]
		public void ConvertKnownStonesToGrams(double input, double expectation)
		{
			var result = Mass.Stones.ToGrams(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromStonesToKilogramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Stones.ToKilograms(value);
				var convertBack = Mass.Kilograms.ToStones(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(90.0, 571.526)]
		[TestCase(3.4, 21.591)]
		[TestCase(66.0, 419.119)]
		public void ConvertKnownStonesToKilograms(double input, double expectation)
		{
			var result = Mass.Stones.ToKilograms(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromStonesToTonnesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Stones.ToTonnes(value);
				var convertBack = Mass.Tonnes.ToStones(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(100.0, 0.635029)]
		[TestCase(12345.0, 78.394369)]
		[TestCase(10099.0, 64.131611)]
		public void ConvertKnownStonesToTonnes(double input, double expectation)
		{
			var result = Mass.Stones.ToTonnes(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromStonesToOuncesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Stones.ToOunces(value);
				var convertBack = Mass.Ounces.ToStones(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(34.0, 7616.0)]
		[TestCase(1.2, 268.8)]
		[TestCase(800.0, 179200.0)]
		public void ConvertKnownStonesToOunces(double input, double expectation)
		{
			var result = Mass.Stones.ToOunces(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromStonesToPoundsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Stones.ToPounds(value);
				var convertBack = Mass.Pounds.ToStones(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(800.0, 11200.0)]
		[TestCase(0.5, 7.0)]
		[TestCase(52.1, 729.4)]
		public void ConvertKnownStonesToPounds(double input, double expectation)
		{
			var result = Mass.Stones.ToPounds(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromStonesToCaratsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Stones.ToCarats(value);
				var convertBack = Mass.Carats.ToStones(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.01, 317.5147)]
		[TestCase(0.006, 190.5088)]
		[TestCase(2.1, 66677.25)]
		public void ConvertKnownStonesToCarats(double input, double expectation)
		{
			var result = Mass.Stones.ToCarats(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

	}
	public class TonnesTests
	{
		[Property]
		public void FromTonnesToMilligramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Tonnes.ToMilligrams(value);
				var convertBack = Mass.Milligrams.ToTonnes(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.009, 9000000.0)]
		[TestCase(0.00081, 810000.0)]
		[TestCase(0.00123, 1230000.0)]
		public void ConvertKnownTonnesToMilligrams(double input, double expectation)
		{
			var result = Mass.Tonnes.ToMilligrams(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromTonnesToGramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Tonnes.ToGrams(value);
				var convertBack = Mass.Grams.ToTonnes(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.00123, 1230.0)]
		[TestCase(0.8, 800000.0)]
		[TestCase(0.03, 30000.0)]
		public void ConvertKnownTonnesToGrams(double input, double expectation)
		{
			var result = Mass.Tonnes.ToGrams(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromTonnesToKilogramsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Tonnes.ToKilograms(value);
				var convertBack = Mass.Kilograms.ToTonnes(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.03, 30.0)]
		[TestCase(4.0, 4000.0)]
		[TestCase(1.2, 1200.0)]
		public void ConvertKnownTonnesToKilograms(double input, double expectation)
		{
			var result = Mass.Tonnes.ToKilograms(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromTonnesToOuncesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Tonnes.ToOunces(value);
				var convertBack = Mass.Ounces.ToTonnes(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(1.2, 42328.754376824065)]
		[TestCase(0.8, 28219.169584549378)]
		[TestCase(0.001, 35.273962)]
		public void ConvertKnownTonnesToOunces(double input, double expectation)
		{
			var result = Mass.Tonnes.ToOunces(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromTonnesToPoundsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Tonnes.ToPounds(value);
				var convertBack = Mass.Pounds.ToTonnes(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(1.2, 2645.55)]
		[TestCase(0.9, 1984.16)]
		[TestCase(34.0, 74957.08)]
		public void ConvertKnownTonnesToPounds(double input, double expectation)
		{
			var result = Mass.Tonnes.ToPounds(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromTonnesToStonesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Tonnes.ToStones(value);
				var convertBack = Mass.Stones.ToTonnes(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(12.0, 1889.68)]
		[TestCase(8.4, 1322.77)]
		[TestCase(0.3, 47.2419)]
		public void ConvertKnownTonnesToStones(double input, double expectation)
		{
			var result = Mass.Tonnes.ToStones(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromTonnesToCaratsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Mass.Tonnes.ToCarats(value);
				var convertBack = Mass.Carats.ToTonnes(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.003, 15000.0)]
		[TestCase(0.09, 450000.0)]
		[TestCase(0.0012, 6000.0)]
		public void ConvertKnownTonnesToCarats(double input, double expectation)
		{
			var result = Mass.Tonnes.ToCarats(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

	}
}
