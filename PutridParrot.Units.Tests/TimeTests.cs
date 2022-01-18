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
	public class CenturiesTests
	{
		[Property]
		public void FromCenturiesToSecondsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Centuries.ToSeconds(value);
				var convertBack = Time.Seconds.ToCenturies(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromCenturiesToMinutesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Centuries.ToMinutes(value);
				var convertBack = Time.Minutes.ToCenturies(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromCenturiesToHoursAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Centuries.ToHours(value);
				var convertBack = Time.Hours.ToCenturies(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromCenturiesToDaysAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Centuries.ToDays(value);
				var convertBack = Time.Days.ToCenturies(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromCenturiesToWeeksAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Centuries.ToWeeks(value);
				var convertBack = Time.Weeks.ToCenturies(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromCenturiesToMonthsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Centuries.ToMonths(value);
				var convertBack = Time.Months.ToCenturies(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromCenturiesToYearsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Centuries.ToYears(value);
				var convertBack = Time.Years.ToCenturies(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromCenturiesToDecadesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Centuries.ToDecades(value);
				var convertBack = Time.Decades.ToCenturies(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

	}
	public class DaysTests
	{
		[Property]
		public void FromDaysToSecondsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Days.ToSeconds(value);
				var convertBack = Time.Seconds.ToDays(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(1.4, 120960.0)]
		[TestCase(0.06, 5184.0)]
		[TestCase(0.2, 17280.0)]
		public void ConvertKnownDaysToSeconds(double input, double expectation)
		{
			var result = Time.Days.ToSeconds(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromDaysToMinutesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Days.ToMinutes(value);
				var convertBack = Time.Minutes.ToDays(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(34.0, 48960.0)]
		[TestCase(0.06, 86.4)]
		[TestCase(8.1, 11664.0)]
		public void ConvertKnownDaysToMinutes(double input, double expectation)
		{
			var result = Time.Days.ToMinutes(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromDaysToHoursAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Days.ToHours(value);
				var convertBack = Time.Hours.ToDays(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(8.1, 194.4)]
		[TestCase(0.2, 4.8)]
		[TestCase(121.0, 2904.0)]
		public void ConvertKnownDaysToHours(double input, double expectation)
		{
			var result = Time.Days.ToHours(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromDaysToWeeksAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Days.ToWeeks(value);
				var convertBack = Time.Weeks.ToDays(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(121.0, 17.2857)]
		[TestCase(7.2, 1.02857)]
		[TestCase(0.9, 0.128571)]
		public void ConvertKnownDaysToWeeks(double input, double expectation)
		{
			var result = Time.Days.ToWeeks(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromDaysToMonthsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Days.ToMonths(value);
				var convertBack = Time.Months.ToDays(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.9, 0.029589)]
		[TestCase(108.0, 3.55068)]
		[TestCase(55.0, 1.80822)]
		public void ConvertKnownDaysToMonths(double input, double expectation)
		{
			var result = Time.Days.ToMonths(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromDaysToYearsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Days.ToYears(value);
				var convertBack = Time.Years.ToDays(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(55.0, 0.150685)]
		[TestCase(123.0, 0.336986)]
		[TestCase(900.0, 2.46575)]
		public void ConvertKnownDaysToYears(double input, double expectation)
		{
			var result = Time.Days.ToYears(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromDaysToDecadesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Days.ToDecades(value);
				var convertBack = Time.Decades.ToDays(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromDaysToCenturiesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Days.ToCenturies(value);
				var convertBack = Time.Centuries.ToDays(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

	}
	public class DecadesTests
	{
		[Property]
		public void FromDecadesToSecondsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Decades.ToSeconds(value);
				var convertBack = Time.Seconds.ToDecades(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromDecadesToMinutesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Decades.ToMinutes(value);
				var convertBack = Time.Minutes.ToDecades(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromDecadesToHoursAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Decades.ToHours(value);
				var convertBack = Time.Hours.ToDecades(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromDecadesToDaysAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Decades.ToDays(value);
				var convertBack = Time.Days.ToDecades(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromDecadesToWeeksAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Decades.ToWeeks(value);
				var convertBack = Time.Weeks.ToDecades(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromDecadesToMonthsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Decades.ToMonths(value);
				var convertBack = Time.Months.ToDecades(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromDecadesToYearsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Decades.ToYears(value);
				var convertBack = Time.Years.ToDecades(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromDecadesToCenturiesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Decades.ToCenturies(value);
				var convertBack = Time.Centuries.ToDecades(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

	}
	public class HoursTests
	{
		[Property]
		public void FromHoursToSecondsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Hours.ToSeconds(value);
				var convertBack = Time.Seconds.ToHours(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(12.0, 43200.0)]
		[TestCase(3.2, 11520.0)]
		[TestCase(0.3, 1080.0)]
		public void ConvertKnownHoursToSeconds(double input, double expectation)
		{
			var result = Time.Hours.ToSeconds(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromHoursToMinutesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Hours.ToMinutes(value);
				var convertBack = Time.Minutes.ToHours(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.3, 18.0)]
		[TestCase(700.0, 42000.0)]
		[TestCase(4.8, 288.0)]
		public void ConvertKnownHoursToMinutes(double input, double expectation)
		{
			var result = Time.Hours.ToMinutes(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromHoursToDaysAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Hours.ToDays(value);
				var convertBack = Time.Days.ToHours(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(4.8, 0.2)]
		[TestCase(190.0, 7.91667)]
		[TestCase(8.5, 0.354167)]
		public void ConvertKnownHoursToDays(double input, double expectation)
		{
			var result = Time.Hours.ToDays(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromHoursToWeeksAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Hours.ToWeeks(value);
				var convertBack = Time.Weeks.ToHours(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(800.0, 4.7619)]
		[TestCase(90.0, 0.535714)]
		[TestCase(102.0, 0.607143)]
		public void ConvertKnownHoursToWeeks(double input, double expectation)
		{
			var result = Time.Hours.ToWeeks(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromHoursToMonthsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Hours.ToMonths(value);
				var convertBack = Time.Months.ToHours(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(102.0, 0.139726)]
		[TestCase(9876.0, 13.52875)]
		[TestCase(100.8, 0.13808204)]
		public void ConvertKnownHoursToMonths(double input, double expectation)
		{
			var result = Time.Hours.ToMonths(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromHoursToYearsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Hours.ToYears(value);
				var convertBack = Time.Years.ToHours(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(9000.0, 1.027397)]
		[TestCase(1003.0, 0.1144977)]
		[TestCase(809.0, 0.0923516)]
		public void ConvertKnownHoursToYears(double input, double expectation)
		{
			var result = Time.Hours.ToYears(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromHoursToDecadesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Hours.ToDecades(value);
				var convertBack = Time.Decades.ToHours(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromHoursToCenturiesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Hours.ToCenturies(value);
				var convertBack = Time.Centuries.ToHours(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

	}
	public class MinutesTests
	{
		[Property]
		public void FromMinutesToSecondsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Minutes.ToSeconds(value);
				var convertBack = Time.Seconds.ToMinutes(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(90.0, 5400.0)]
		[TestCase(0.9, 54.0)]
		[TestCase(123.0, 7380.0)]
		public void ConvertKnownMinutesToSeconds(double input, double expectation)
		{
			var result = Time.Minutes.ToSeconds(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMinutesToHoursAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Minutes.ToHours(value);
				var convertBack = Time.Hours.ToMinutes(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(123.0, 2.05)]
		[TestCase(77.0, 1.28333)]
		[TestCase(0.8, 0.0133333)]
		public void ConvertKnownMinutesToHours(double input, double expectation)
		{
			var result = Time.Minutes.ToHours(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMinutesToDaysAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Minutes.ToDays(value);
				var convertBack = Time.Days.ToMinutes(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(800.0, 0.555556)]
		[TestCase(190.0, 0.131944)]
		[TestCase(55.0, 0.0381944)]
		public void ConvertKnownMinutesToDays(double input, double expectation)
		{
			var result = Time.Minutes.ToDays(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMinutesToWeeksAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Minutes.ToWeeks(value);
				var convertBack = Time.Weeks.ToMinutes(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(1900.0, 0.1884921)]
		[TestCase(800.0, 0.0793651)]
		[TestCase(12345.0, 1.2247024)]
		public void ConvertKnownMinutesToWeeks(double input, double expectation)
		{
			var result = Time.Minutes.ToWeeks(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMinutesToMonthsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Minutes.ToMonths(value);
				var convertBack = Time.Months.ToMinutes(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(1234.0, 0.02817349)]
		[TestCase(90000.0, 2.0547923)]
		[TestCase(7100.0, 0.1621003)]
		public void ConvertKnownMinutesToMonths(double input, double expectation)
		{
			var result = Time.Minutes.ToMonths(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMinutesToYearsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Minutes.ToYears(value);
				var convertBack = Time.Years.ToMinutes(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(900800.0, 1.71385084)]
		[TestCase(12345.0, 0.023487443)]
		[TestCase(610910.0, 1.16230974)]
		public void ConvertKnownMinutesToYears(double input, double expectation)
		{
			var result = Time.Minutes.ToYears(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMinutesToDecadesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Minutes.ToDecades(value);
				var convertBack = Time.Decades.ToMinutes(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromMinutesToCenturiesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Minutes.ToCenturies(value);
				var convertBack = Time.Centuries.ToMinutes(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

	}
	public class MonthsTests
	{
		[Property]
		public void FromMonthsToSecondsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Months.ToSeconds(value);
				var convertBack = Time.Seconds.ToMonths(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.03, 78840.00)]
		[TestCase(0.1, 262800.0)]
		[TestCase(0.008, 21024.0)]
		public void ConvertKnownMonthsToSeconds(double input, double expectation)
		{
			var result = Time.Months.ToSeconds(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMonthsToMinutesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Months.ToMinutes(value);
				var convertBack = Time.Minutes.ToMonths(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.7, 30660.0)]
		[TestCase(1.4, 61319.99)]
		[TestCase(5.0, 219000.0)]
		public void ConvertKnownMonthsToMinutes(double input, double expectation)
		{
			var result = Time.Months.ToMinutes(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMonthsToHoursAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Months.ToHours(value);
				var convertBack = Time.Hours.ToMonths(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(4.0, 2920.0)]
		[TestCase(0.3, 219.0)]
		[TestCase(4.5, 3285.0)]
		public void ConvertKnownMonthsToHours(double input, double expectation)
		{
			var result = Time.Months.ToHours(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMonthsToDaysAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Months.ToDays(value);
				var convertBack = Time.Days.ToMonths(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(4.5, 136.875)]
		[TestCase(90.0, 2737.53)]
		[TestCase(0.4, 12.1667)]
		public void ConvertKnownMonthsToDays(double input, double expectation)
		{
			var result = Time.Months.ToDays(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMonthsToWeeksAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Months.ToWeeks(value);
				var convertBack = Time.Weeks.ToMonths(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.5, 2.17262)]
		[TestCase(88.0, 382.359)]
		[TestCase(12.6, 54.75006)]
		public void ConvertKnownMonthsToWeeks(double input, double expectation)
		{
			var result = Time.Months.ToWeeks(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMonthsToYearsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Months.ToYears(value);
				var convertBack = Time.Years.ToMonths(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(12.6, 1.050001)]
		[TestCase(109.0, 9.08334)]
		[TestCase(23.0, 1.91667)]
		public void ConvertKnownMonthsToYears(double input, double expectation)
		{
			var result = Time.Months.ToYears(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromMonthsToDecadesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Months.ToDecades(value);
				var convertBack = Time.Decades.ToMonths(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromMonthsToCenturiesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Months.ToCenturies(value);
				var convertBack = Time.Centuries.ToMonths(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

	}
	public class SecondsTests
	{
		[Property]
		public void FromSecondsToMinutesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Seconds.ToMinutes(value);
				var convertBack = Time.Minutes.ToSeconds(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(100.0, 1.66667)]
		[TestCase(9000.0, 150.0)]
		[TestCase(2300.0, 38.33333)]
		public void ConvertKnownSecondsToMinutes(double input, double expectation)
		{
			var result = Time.Seconds.ToMinutes(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromSecondsToHoursAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Seconds.ToHours(value);
				var convertBack = Time.Hours.ToSeconds(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(2300.0, 0.6388889)]
		[TestCase(9999.0, 2.7775)]
		[TestCase(36000.0, 10.0)]
		public void ConvertKnownSecondsToHours(double input, double expectation)
		{
			var result = Time.Seconds.ToHours(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromSecondsToDaysAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Seconds.ToDays(value);
				var convertBack = Time.Days.ToSeconds(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(36000.0, 0.41666667)]
		[TestCase(90000.0, 1.0416667)]
		[TestCase(190000.0, 2.19907407)]
		public void ConvertKnownSecondsToDays(double input, double expectation)
		{
			var result = Time.Seconds.ToDays(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromSecondsToWeeksAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Seconds.ToWeeks(value);
				var convertBack = Time.Weeks.ToSeconds(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(190000.0, 0.314153439)]
		[TestCase(1234567.0, 2.041281415)]
		[TestCase(100200.0, 0.165674603)]
		public void ConvertKnownSecondsToWeeks(double input, double expectation)
		{
			var result = Time.Seconds.ToWeeks(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromSecondsToMonthsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Seconds.ToMonths(value);
				var convertBack = Time.Months.ToSeconds(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(1000000.0, 0.380517087)]
		[TestCase(9876543.0, 3.75819337)]
		[TestCase(200900.0, 0.0764458827)]
		public void ConvertKnownSecondsToMonths(double input, double expectation)
		{
			var result = Time.Seconds.ToMonths(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromSecondsToYearsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Seconds.ToYears(value);
				var convertBack = Time.Years.ToSeconds(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(123456789.0, 3.91478909817)]
		[TestCase(100900.0, 0.00319951801)]
		[TestCase(987654.0, 0.0313183029)]
		public void ConvertKnownSecondsToYears(double input, double expectation)
		{
			var result = Time.Seconds.ToYears(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromSecondsToDecadesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Seconds.ToDecades(value);
				var convertBack = Time.Decades.ToSeconds(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromSecondsToCenturiesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Seconds.ToCenturies(value);
				var convertBack = Time.Centuries.ToSeconds(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

	}
	public class WeeksTests
	{
		[Property]
		public void FromWeeksToSecondsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Weeks.ToSeconds(value);
				var convertBack = Time.Seconds.ToWeeks(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.1, 60480.0)]
		[TestCase(0.08, 48384.0)]
		[TestCase(3.0, 1814400.0)]
		public void ConvertKnownWeeksToSeconds(double input, double expectation)
		{
			var result = Time.Weeks.ToSeconds(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromWeeksToMinutesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Weeks.ToMinutes(value);
				var convertBack = Time.Minutes.ToWeeks(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(2.0, 20160.0)]
		[TestCase(0.4, 4032.0)]
		[TestCase(0.02, 201.6)]
		public void ConvertKnownWeeksToMinutes(double input, double expectation)
		{
			var result = Time.Weeks.ToMinutes(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromWeeksToHoursAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Weeks.ToHours(value);
				var convertBack = Time.Hours.ToWeeks(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.02, 3.36)]
		[TestCase(77.0, 12936.0)]
		[TestCase(9.2, 1545.6)]
		public void ConvertKnownWeeksToHours(double input, double expectation)
		{
			var result = Time.Weeks.ToHours(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromWeeksToDaysAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Weeks.ToDays(value);
				var convertBack = Time.Days.ToWeeks(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(9.2, 64.4)]
		[TestCase(169.0, 1183.0)]
		[TestCase(4.0, 28.0)]
		public void ConvertKnownWeeksToDays(double input, double expectation)
		{
			var result = Time.Weeks.ToDays(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromWeeksToMonthsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Weeks.ToMonths(value);
				var convertBack = Time.Months.ToWeeks(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(4.0, 0.920547)]
		[TestCase(900.0, 207.134637)]
		[TestCase(3.8, 0.87452)]
		public void ConvertKnownWeeksToMonths(double input, double expectation)
		{
			var result = Time.Weeks.ToMonths(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromWeeksToYearsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Weeks.ToYears(value);
				var convertBack = Time.Years.ToWeeks(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(3.0, 0.0575342)]
		[TestCase(235.0, 4.50685)]
		[TestCase(1090.0, 20.90411)]
		public void ConvertKnownWeeksToYears(double input, double expectation)
		{
			var result = Time.Weeks.ToYears(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromWeeksToDecadesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Weeks.ToDecades(value);
				var convertBack = Time.Decades.ToWeeks(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromWeeksToCenturiesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Weeks.ToCenturies(value);
				var convertBack = Time.Centuries.ToWeeks(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

	}
	public class YearsTests
	{
		[Property]
		public void FromYearsToSecondsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Years.ToSeconds(value);
				var convertBack = Time.Seconds.ToYears(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.06, 1892160.0)]
		[TestCase(0.009, 283824.0)]
		[TestCase(0.02, 630720.0)]
		public void ConvertKnownYearsToSeconds(double input, double expectation)
		{
			var result = Time.Years.ToSeconds(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromYearsToMinutesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Years.ToMinutes(value);
				var convertBack = Time.Minutes.ToYears(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.02, 10512.0)]
		[TestCase(0.3, 157680.0)]
		[TestCase(0.001, 525.6)]
		public void ConvertKnownYearsToMinutes(double input, double expectation)
		{
			var result = Time.Years.ToMinutes(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromYearsToHoursAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Years.ToHours(value);
				var convertBack = Time.Hours.ToYears(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(0.001, 8.76)]
		[TestCase(0.3, 2628.0)]
		[TestCase(2.0, 17520.0)]
		public void ConvertKnownYearsToHours(double input, double expectation)
		{
			var result = Time.Years.ToHours(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromYearsToDaysAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Years.ToDays(value);
				var convertBack = Time.Days.ToYears(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(2.0, 730.0)]
		[TestCase(1009.0, 368285.0)]
		[TestCase(7.0, 2555.0)]
		public void ConvertKnownYearsToDays(double input, double expectation)
		{
			var result = Time.Years.ToDays(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromYearsToWeeksAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Years.ToWeeks(value);
				var convertBack = Time.Weeks.ToYears(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(7.0, 365.0)]
		[TestCase(1.3, 67.7857)]
		[TestCase(88.0, 4588.5839)]
		public void ConvertKnownYearsToWeeks(double input, double expectation)
		{
			var result = Time.Years.ToWeeks(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromYearsToMonthsAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Years.ToMonths(value);
				var convertBack = Time.Months.ToYears(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[TestCase(6.0, 71.9999)]
		[TestCase(12.0, 144.0)]
		[TestCase(0.3, 3.6)]
		public void ConvertKnownYearsToMonths(double input, double expectation)
		{
			var result = Time.Years.ToMonths(input);
			Assert.AreEqual(expectation, result, 0.01);
		}

		[Property]
		public void FromYearsToDecadesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Years.ToDecades(value);
				var convertBack = Time.Decades.ToYears(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

		[Property]
		public void FromYearsToCenturiesAndBack()
		{
			Prop.ForAll<int>(value =>
			{
				var convertTo = Time.Years.ToCenturies(value);
				var convertBack = Time.Centuries.ToYears(convertTo);
				return Is.EqualTo(convertBack).Within(0.01).ApplyTo(value).IsSuccess;
			}).QuickCheckThrowOnFailure();
		}

	}
}
