/// <summary>
/// Do not change this code, it's generated by the UnitCodeGenerator app.
/// </summary>

using NUnit.Framework;
using FsCheck;
using PropertyAttribute = FsCheck.NUnit.PropertyAttribute;

namespace PutridParrot.Units.Tests;

public class DegreesTests
{
	[Property]
	public void FromDegreesToRadiansAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Degrees.ToRadians(value);
			var convertBack = Angle.Radians.ToDegrees(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(98.8, 1.724385)]
	[TestCase(8000.0, 139.6263)]
	[TestCase(8.0, 0.139626)]
	public void ConvertKnownDegreesToRadians(double input, double expectation)
	{
		var result = Angle.Degrees.ToRadians(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromDegreesToGradiansAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Degrees.ToGradians(value);
			var convertBack = Angle.Gradians.ToDegrees(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(123.0, 136.667)]
	[TestCase(65.0, 72.2222)]
	[TestCase(900.0, 1000.0)]
	public void ConvertKnownDegreesToGradians(double input, double expectation)
	{
		var result = Angle.Degrees.ToGradians(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromDegreesToMilliradiansAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Degrees.ToMilliradians(value);
			var convertBack = Angle.Milliradians.ToDegrees(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(900.0, 15707.969)]
	[TestCase(76.0, 1326.45)]
	[TestCase(4.5, 78.5398)]
	public void ConvertKnownDegreesToMilliradians(double input, double expectation)
	{
		var result = Angle.Degrees.ToMilliradians(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromDegreesToMinuteOfArcAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Degrees.ToMinuteOfArc(value);
			var convertBack = Angle.MinuteOfArc.ToDegrees(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(97.0, 5820.0)]
	[TestCase(8.65, 519.0)]
	[TestCase(12.0, 720.0)]
	public void ConvertKnownDegreesToMinuteOfArc(double input, double expectation)
	{
		var result = Angle.Degrees.ToMinuteOfArc(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromDegreesToSecondsOfArcAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Degrees.ToSecondsOfArc(value);
			var convertBack = Angle.SecondsOfArc.ToDegrees(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(12.0, 43200.0)]
	[TestCase(910.4, 3277440)]
	[TestCase(5.6, 20160.0)]
	public void ConvertKnownDegreesToSecondsOfArc(double input, double expectation)
	{
		var result = Angle.Degrees.ToSecondsOfArc(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

}
public class GradiansTests
{
	[Property]
	public void FromGradiansToDegreesAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Gradians.ToDegrees(value);
			var convertBack = Angle.Degrees.ToGradians(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(5.6, 5.04)]
	[TestCase(167.0, 150.3)]
	[TestCase(0.1, 0.09)]
	public void ConvertKnownGradiansToDegrees(double input, double expectation)
	{
		var result = Angle.Gradians.ToDegrees(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromGradiansToRadiansAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Gradians.ToRadians(value);
			var convertBack = Angle.Radians.ToGradians(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(67.9, 1.066571)]
	[TestCase(8000.0, 125.6637)]
	[TestCase(6.5, 0.102102)]
	public void ConvertKnownGradiansToRadians(double input, double expectation)
	{
		var result = Angle.Gradians.ToRadians(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromGradiansToMilliradiansAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Gradians.ToMilliradians(value);
			var convertBack = Angle.Milliradians.ToGradians(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(8.1, 127.2348)]
	[TestCase(900.0, 14137.2)]
	[TestCase(1902.5, 29884.47)]
	public void ConvertKnownGradiansToMilliradians(double input, double expectation)
	{
		var result = Angle.Gradians.ToMilliradians(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromGradiansToMinuteOfArcAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Gradians.ToMinuteOfArc(value);
			var convertBack = Angle.MinuteOfArc.ToGradians(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(80.9, 4368.6)]
	[TestCase(1678.0, 90612.0)]
	[TestCase(900.0, 48600.0)]
	public void ConvertKnownGradiansToMinuteOfArc(double input, double expectation)
	{
		var result = Angle.Gradians.ToMinuteOfArc(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromGradiansToSecondsOfArcAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Gradians.ToSecondsOfArc(value);
			var convertBack = Angle.SecondsOfArc.ToGradians(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(0.9, 2916.0)]
	[TestCase(12.3, 39852.0)]
	[TestCase(5.1, 16524.0)]
	public void ConvertKnownGradiansToSecondsOfArc(double input, double expectation)
	{
		var result = Angle.Gradians.ToSecondsOfArc(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

}
public class MilliradiansTests
{
	[Property]
	public void FromMilliradiansToDegreesAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Milliradians.ToDegrees(value);
			var convertBack = Angle.Degrees.ToMilliradians(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(5.9, 0.338045)]
	[TestCase(109.0, 6.24524)]
	[TestCase(7009.0, 401.5861)]
	public void ConvertKnownMilliradiansToDegrees(double input, double expectation)
	{
		var result = Angle.Milliradians.ToDegrees(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromMilliradiansToRadiansAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Milliradians.ToRadians(value);
			var convertBack = Angle.Radians.ToMilliradians(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(8011.0, 8.011)]
	[TestCase(7689.0, 7.689)]
	[TestCase(129.0, 0.129)]
	public void ConvertKnownMilliradiansToRadians(double input, double expectation)
	{
		var result = Angle.Milliradians.ToRadians(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromMilliradiansToGradiansAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Milliradians.ToGradians(value);
			var convertBack = Angle.Gradians.ToMilliradians(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(129.0, 8.2124)]
	[TestCase(800.0, 50.9296)]
	[TestCase(12.89, 0.8206029)]
	public void ConvertKnownMilliradiansToGradians(double input, double expectation)
	{
		var result = Angle.Milliradians.ToGradians(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromMilliradiansToMinuteOfArcAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Milliradians.ToMinuteOfArc(value);
			var convertBack = Angle.MinuteOfArc.ToMilliradians(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(12.0, 41.253)]
	[TestCase(0.9, 3.09397)]
	[TestCase(800.0, 2750.2)]
	public void ConvertKnownMilliradiansToMinuteOfArc(double input, double expectation)
	{
		var result = Angle.Milliradians.ToMinuteOfArc(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromMilliradiansToSecondsOfArcAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Milliradians.ToSecondsOfArc(value);
			var convertBack = Angle.SecondsOfArc.ToMilliradians(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(67.0, 13819.742)]
	[TestCase(900.0, 185638.32562238674)]
	[TestCase(812.5, 167590.16)]
	public void ConvertKnownMilliradiansToSecondsOfArc(double input, double expectation)
	{
		var result = Angle.Milliradians.ToSecondsOfArc(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

}
public class MinuteOfArcTests
{
	[Property]
	public void FromMinuteOfArcToDegreesAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.MinuteOfArc.ToDegrees(value);
			var convertBack = Angle.Degrees.ToMinuteOfArc(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(89.0, 1.48333)]
	[TestCase(160.5, 2.675)]
	[TestCase(0.9, 0.015)]
	public void ConvertKnownMinuteOfArcToDegrees(double input, double expectation)
	{
		var result = Angle.MinuteOfArc.ToDegrees(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromMinuteOfArcToRadiansAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.MinuteOfArc.ToRadians(value);
			var convertBack = Angle.Radians.ToMinuteOfArc(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(1790.0, 0.5206899)]
	[TestCase(9999.0, 2.908591)]
	[TestCase(12345.0, 3.5910149)]
	public void ConvertKnownMinuteOfArcToRadians(double input, double expectation)
	{
		var result = Angle.MinuteOfArc.ToRadians(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromMinuteOfArcToGradiansAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.MinuteOfArc.ToGradians(value);
			var convertBack = Angle.Gradians.ToMinuteOfArc(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(300.0, 5.55556)]
	[TestCase(1009.0, 18.68519)]
	[TestCase(6700.5, 124.083335)]
	public void ConvertKnownMinuteOfArcToGradians(double input, double expectation)
	{
		var result = Angle.MinuteOfArc.ToGradians(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromMinuteOfArcToMilliradiansAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.MinuteOfArc.ToMilliradians(value);
			var convertBack = Angle.Milliradians.ToMinuteOfArc(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(600.0, 174.533)]
	[TestCase(90.7, 26.38356)]
	[TestCase(1700.0, 494.51)]
	public void ConvertKnownMinuteOfArcToMilliradians(double input, double expectation)
	{
		var result = Angle.MinuteOfArc.ToMilliradians(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromMinuteOfArcToSecondsOfArcAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.MinuteOfArc.ToSecondsOfArc(value);
			var convertBack = Angle.SecondsOfArc.ToMinuteOfArc(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(0.9, 54.0)]
	[TestCase(70.0, 4200.0)]
	[TestCase(901.6, 54096.0)]
	public void ConvertKnownMinuteOfArcToSecondsOfArc(double input, double expectation)
	{
		var result = Angle.MinuteOfArc.ToSecondsOfArc(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

}
public class RadiansTests
{
	[Property]
	public void FromRadiansToDegreesAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Radians.ToDegrees(value);
			var convertBack = Angle.Degrees.ToRadians(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(4.5, 257.831)]
	[TestCase(0.9, 51.5662)]
	[TestCase(78.9, 4520.637)]
	public void ConvertKnownRadiansToDegrees(double input, double expectation)
	{
		var result = Angle.Radians.ToDegrees(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromRadiansToGradiansAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Radians.ToGradians(value);
			var convertBack = Angle.Gradians.ToRadians(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(5.0, 318.31)]
	[TestCase(0.9, 57.2958)]
	[TestCase(89.0, 5665.92)]
	public void ConvertKnownRadiansToGradians(double input, double expectation)
	{
		var result = Angle.Radians.ToGradians(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromRadiansToMilliradiansAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Radians.ToMilliradians(value);
			var convertBack = Angle.Milliradians.ToRadians(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(5.0, 5000.0)]
	[TestCase(0.13, 130.0)]
	[TestCase(0.13, 130.0)]
	[TestCase(89.1, 89100.0)]
	public void ConvertKnownRadiansToMilliradians(double input, double expectation)
	{
		var result = Angle.Radians.ToMilliradians(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromRadiansToMinuteOfArcAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Radians.ToMinuteOfArc(value);
			var convertBack = Angle.MinuteOfArc.ToRadians(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(6.0, 20626.480624709635)]
	[TestCase(0.8, 2750.2)]
	[TestCase(2.3, 7906.82)]
	public void ConvertKnownRadiansToMinuteOfArc(double input, double expectation)
	{
		var result = Angle.Radians.ToMinuteOfArc(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromRadiansToSecondsOfArcAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.Radians.ToSecondsOfArc(value);
			var convertBack = Angle.SecondsOfArc.ToRadians(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(0.8, 165011.84499767708)]
	[TestCase(0.001, 206.26481)]
	[TestCase(0.9, 185638.32562238674)]
	public void ConvertKnownRadiansToSecondsOfArc(double input, double expectation)
	{
		var result = Angle.Radians.ToSecondsOfArc(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

}
public class SecondsOfArcTests
{
	[Property]
	public void FromSecondsOfArcToDegreesAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.SecondsOfArc.ToDegrees(value);
			var convertBack = Angle.Degrees.ToSecondsOfArc(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(900.0, 0.25)]
	[TestCase(123.4, 0.034277778)]
	[TestCase(8000.0, 2.222222)]
	public void ConvertKnownSecondsOfArcToDegrees(double input, double expectation)
	{
		var result = Angle.SecondsOfArc.ToDegrees(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromSecondsOfArcToRadiansAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.SecondsOfArc.ToRadians(value);
			var convertBack = Angle.Radians.ToSecondsOfArc(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(190000.0, 0.921145994)]
	[TestCase(88990.0, 0.43143569)]
	[TestCase(100000.0, 0.48481368)]
	public void ConvertKnownSecondsOfArcToRadians(double input, double expectation)
	{
		var result = Angle.SecondsOfArc.ToRadians(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromSecondsOfArcToGradiansAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.SecondsOfArc.ToGradians(value);
			var convertBack = Angle.Gradians.ToSecondsOfArc(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(1000.0, 0.308642)]
	[TestCase(809.0, 0.249691)]
	[TestCase(1567.9, 0.483919761)]
	public void ConvertKnownSecondsOfArcToGradians(double input, double expectation)
	{
		var result = Angle.SecondsOfArc.ToGradians(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromSecondsOfArcToMilliradiansAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.SecondsOfArc.ToMilliradians(value);
			var convertBack = Angle.Milliradians.ToSecondsOfArc(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(1234.0, 5.982601)]
	[TestCase(909.0, 4.40696)]
	[TestCase(190009.0, 921.189627)]
	public void ConvertKnownSecondsOfArcToMilliradians(double input, double expectation)
	{
		var result = Angle.SecondsOfArc.ToMilliradians(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

	[Property]
	public void FromSecondsOfArcToMinuteOfArcAndBack()
	{
		Prop.ForAll<int>(value =>
		{
			var convertTo = Angle.SecondsOfArc.ToMinuteOfArc(value);
			var convertBack = Angle.MinuteOfArc.ToSecondsOfArc(convertTo);
			return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
		}).QuickCheckThrowOnFailure();
	}

	[TestCase(100.0, 1.66667)]
	[TestCase(908.0, 15.1333)]
	[TestCase(8091.0, 134.85)]
	public void ConvertKnownSecondsOfArcToMinuteOfArc(double input, double expectation)
	{
		var result = Angle.SecondsOfArc.ToMinuteOfArc(input);
		Assert.AreEqual(expectation, result, 0.01);
	}

}
