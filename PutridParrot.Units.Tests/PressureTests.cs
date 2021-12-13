/// <summary>
/// Do not change this code, it's generated by the UnitCodeGenerator app.
/// </summary>

using NUnit.Framework;
using FsCheck;
using PropertyAttribute = FsCheck.NUnit.PropertyAttribute;

namespace PutridParrot.Units.Tests;

public class AtmospheresTests
{
	[Property]
	public void FromAtmospheresToBarsAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Atmospheres.ToBars(value);
			var convertBack = Pressure.Bars.ToAtmospheres(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(6.0, 6.0795)]
	[TestCase(1.2, 1.2159)]
	[TestCase(0.8, 0.8106)]
	public void ConvertKnownAtmospheresToBars(double input, double expectation)
	{
		var result = Pressure.Atmospheres.ToBars(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromAtmospheresToPascalsAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Atmospheres.ToPascals(value);
			var convertBack = Pressure.Pascals.ToAtmospheres(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(0.8, 81060.0)]
	[TestCase(1.2, 121590.0)]
	[TestCase(0.45, 45596.25)]
	public void ConvertKnownAtmospheresToPascals(double input, double expectation)
	{
		var result = Pressure.Atmospheres.ToPascals(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromAtmospheresToTorrsAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Atmospheres.ToTorrs(value);
			var convertBack = Pressure.Torrs.ToAtmospheres(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(0.45, 342.0)]
	[TestCase(1.2, 912.0)]
	[TestCase(6.0, 4560.0)]
	public void ConvertKnownAtmospheresToTorrs(double input, double expectation)
	{
		var result = Pressure.Atmospheres.ToTorrs(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromAtmospheresToPsiAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Atmospheres.ToPsi(value);
			var convertBack = Pressure.Psi.ToAtmospheres(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(6.0, 88.1757)]
	[TestCase(0.4, 5.87838)]
	[TestCase(1.2, 17.6351)]
	public void ConvertKnownAtmospheresToPsi(double input, double expectation)
	{
		var result = Pressure.Atmospheres.ToPsi(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

}
public class BarsTests
{
	[Property]
	public void FromBarsToAtmospheresAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Bars.ToAtmospheres(value);
			var convertBack = Pressure.Atmospheres.ToBars(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(800.0, 789.539)]
	[TestCase(123.0, 121.392)]
	[TestCase(89.0, 87.8362)]
	public void ConvertKnownBarsToAtmospheres(double input, double expectation)
	{
		var result = Pressure.Bars.ToAtmospheres(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromBarsToPascalsAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Bars.ToPascals(value);
			var convertBack = Pressure.Pascals.ToBars(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(0.89, 89000.0)]
	[TestCase(0.01, 1000.0)]
	[TestCase(0.123, 12300.0)]
	public void ConvertKnownBarsToPascals(double input, double expectation)
	{
		var result = Pressure.Bars.ToPascals(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromBarsToTorrsAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Bars.ToTorrs(value);
			var convertBack = Pressure.Torrs.ToBars(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(0.123, 92.257587)]
	[TestCase(2.0, 1500.12)]
	[TestCase(8.9, 6675.55)]
	public void ConvertKnownBarsToTorrs(double input, double expectation)
	{
		var result = Pressure.Bars.ToTorrs(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromBarsToPsiAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Bars.ToPsi(value);
			var convertBack = Pressure.Psi.ToBars(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(8.1, 117.481)]
	[TestCase(1001.0, 14518.29290)]
	[TestCase(6.0, 87.0226)]
	public void ConvertKnownBarsToPsi(double input, double expectation)
	{
		var result = Pressure.Bars.ToPsi(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

}
public class PascalsTests
{
	[Property]
	public void FromPascalsToAtmospheresAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Pascals.ToAtmospheres(value);
			var convertBack = Pressure.Atmospheres.ToPascals(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(90000.0, 0.88823094)]
	[TestCase(1234567.0, 12.18422897)]
	[TestCase(204060.0, 2.01391562)]
	public void ConvertKnownPascalsToAtmospheres(double input, double expectation)
	{
		var result = Pressure.Pascals.ToAtmospheres(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromPascalsToBarsAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Pascals.ToBars(value);
			var convertBack = Pressure.Bars.ToPascals(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(10000.0, 0.1)]
	[TestCase(12345.0, 0.12345)]
	[TestCase(80000.0, 0.8)]
	public void ConvertKnownPascalsToBars(double input, double expectation)
	{
		var result = Pressure.Pascals.ToBars(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromPascalsToTorrsAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Pascals.ToTorrs(value);
			var convertBack = Pressure.Torrs.ToPascals(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(80000.0, 600.04935)]
	[TestCase(1234.0, 9.255761)]
	[TestCase(80.0, 0.600049)]
	public void ConvertKnownPascalsToTorrs(double input, double expectation)
	{
		var result = Pressure.Pascals.ToTorrs(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromPascalsToPsiAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Pascals.ToPsi(value);
			var convertBack = Pressure.Psi.ToPascals(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(800.0, 0.11603)]
	[TestCase(8670.0, 1.257477)]
	[TestCase(1000.0, 0.145038)]
	public void ConvertKnownPascalsToPsi(double input, double expectation)
	{
		var result = Pressure.Pascals.ToPsi(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

}
public class PsiTests
{
	[Property]
	public void FromPsiToBarsAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Psi.ToBars(value);
			var convertBack = Pressure.Bars.ToPsi(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(900.0, 62.0528)]
	[TestCase(134.0, 9.23897)]
	[TestCase(111.2, 7.6669701)]
	public void ConvertKnownPsiToBars(double input, double expectation)
	{
		var result = Pressure.Psi.ToBars(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromPsiToPascalsAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Psi.ToPascals(value);
			var convertBack = Pressure.Pascals.ToPsi(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(0.9, 6205.28)]
	[TestCase(0.03, 206.8427)]
	[TestCase(2.0, 13789.5)]
	public void ConvertKnownPsiToPascals(double input, double expectation)
	{
		var result = Pressure.Psi.ToPascals(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromPsiToAtmospheresAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Psi.ToAtmospheres(value);
			var convertBack = Pressure.Atmospheres.ToPsi(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(2.0, 0.136092)]
	[TestCase(109.0, 7.41701)]
	[TestCase(8.0, 0.544368)]
	public void ConvertKnownPsiToAtmospheres(double input, double expectation)
	{
		var result = Pressure.Psi.ToAtmospheres(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromPsiToTorrsAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Psi.ToTorrs(value);
			var convertBack = Pressure.Torrs.ToPsi(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(6.0, 310.29)]
	[TestCase(3.4, 175.831)]
	[TestCase(0.5, 25.8575)]
	public void ConvertKnownPsiToTorrs(double input, double expectation)
	{
		var result = Pressure.Psi.ToTorrs(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

}
public class TorrsTests
{
	[Property]
	public void FromTorrsToBarsAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Torrs.ToBars(value);
			var convertBack = Pressure.Bars.ToTorrs(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(100.0, 0.133322)]
	[TestCase(9000.1, 11.9991465)]
	[TestCase(1234.0, 1.645198)]
	public void ConvertKnownTorrsToBars(double input, double expectation)
	{
		var result = Pressure.Torrs.ToBars(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromTorrsToPascalsAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Torrs.ToPascals(value);
			var convertBack = Pressure.Pascals.ToTorrs(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(190.0, 25331.2499)]
	[TestCase(6.5, 866.595)]
	[TestCase(3.4, 453.296)]
	public void ConvertKnownTorrsToPascals(double input, double expectation)
	{
		var result = Pressure.Torrs.ToPascals(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromTorrsToAtmospheresAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Torrs.ToAtmospheres(value);
			var convertBack = Pressure.Atmospheres.ToTorrs(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(5678.0, 7.471053)]
	[TestCase(100.0, 0.131579)]
	[TestCase(4509.0, 5.932895)]
	public void ConvertKnownTorrsToAtmospheres(double input, double expectation)
	{
		var result = Pressure.Torrs.ToAtmospheres(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromTorrsToPsiAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Pressure.Torrs.ToPsi(value);
			var convertBack = Pressure.Psi.ToTorrs(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(4500.0, 87.01549)]
	[TestCase(1234.0, 23.86158)]
	[TestCase(900.0, 17.4031)]
	public void ConvertKnownTorrsToPsi(double input, double expectation)
	{
		var result = Pressure.Torrs.ToPsi(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

}
