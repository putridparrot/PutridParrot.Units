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
	public class MechanicalHorsePowerTests
	{
		[Property]
		public void FromMechanicalHorsePowerToMetricHorsePowerAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Power.MechanicalHorsePower.ToMetricHorsePower(value);
				var convertBack = Power.MetricHorsePower.ToMechanicalHorsePower(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(65.0971, 65.9999749)]
		[TestCase(121.317, 122.9996)]
		[TestCase(86.7962, 88.0)]
		public void ConvertKnownMechanicalHorsePowerToMetricHorsePower(double input, double expectation)
		{
			var result = Power.MechanicalHorsePower.ToMetricHorsePower(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

	}
	public class MetricHorsePowerTests
	{
		[Property]
		public void FromMetricHorsePowerToMechanicalHorsePowerAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Power.MetricHorsePower.ToMechanicalHorsePower(value);
				var convertBack = Power.MechanicalHorsePower.ToMetricHorsePower(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(126.734, 125.0)]
		[TestCase(91.2483, 90.0)]
		[TestCase(425.825, 419.9997)]
		public void ConvertKnownMetricHorsePowerToMechanicalHorsePower(double input, double expectation)
		{
			var result = Power.MetricHorsePower.ToMechanicalHorsePower(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

	}
}
