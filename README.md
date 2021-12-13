# PutridParrot.Units

[![Build PutridParrot.Units](https://github.com/putridparrot/PutridParrot.Units/actions/workflows/dotnet-core.yml/badge.svg)](https://github.com/putridparrot/PutridParrot.Units/actions/workflows/dotnet-core.yml)
[![NuGet version (PutridParrot.Units)](https://img.shields.io/nuget/v/PutridParrot.Units.svg?style=flat-square)](https://www.nuget.org/packages/PutridParrot.Units/)

The main aim for this project is to produce conversion functions for the various units of measurement (listed below). The code and the unit tests
are auto-generated by the UnitCodeGenerator tool. Hence any changes need to made within the definitions file.

The code is written in the style of C# if you're after something aimed at F# checkout [FSharp.Units](https://github.com/putridparrot/FSharp.Units).
### Example

Example of usage:

var fahrenheit = Temperature.Celsius.ToFahrenheit(12.0);

Each unit of measure then includes functions to convert to each for example, converting each Temperature unit of measure to each other Temperature.

### Angle

	* Degrees (deg)
	* Gradians (grad)
	* Milliradians (mrad)
	* Minute Of Arc (arcmin)
	* Radians (rad)
	* Seconds Of Arc (arcseconds)

### Area

	* Acres (acre)
	* Hectares (hectare)
	* Square Feet (feet2)
	* Square Inches (inch2)
	* Square Kilometres (km2)
	* Square Metres (m2)
	* Square Miles (mile2)
	* Square Yards (yard2)

### Data Transfer Rate

	* Bits Per Second (bps)
	* GigaBits Per Second (Gbps)
	* GigaBytes Per Second (GBps)
	* Kibibits Per Second (Kibitps)
	* KiloBits Per Second (kbps)
	* KiloBytes Per Second (kBps)
	* Mebibits Per Second (Mibit)
	* MegaBits Per Second (Mbps)
	* MegaBytes Per Second (MBps)
	* TeraBits Per Second (Tbps)
	* TeraBytes Per Second (TBps)

### Energy

	* Btu (btu)
	* Calories (cal)
	* ElectronVolts (eV)
	* Foot Pounds (ftlb)
	* Joules (J)
	* Kilocalories (kCal)
	* Kilojoules (kJ)
	* Kilowatt Hours (kWh)
	* US Therms (ustherm)
	* Watt Hours (Wh)

### Frequency

	* Gigahertz (GHz)
	* Hertz (Hz)
	* Kilohertz (kHz)
	* Megahertz (MHz)

### Length

	* Centimetres (cm)
	* Feet (ft)
	* Inches (inch)
	* Kilometres (km)
	* Metres (m)
	* Miles (mile)
	* Millimetres (mm)
	* Nautical Miles (NM)
	* Yards (yard)

### Luminous Energy

	* LumenHour (lmh)
	* LumenMinute (lmmin)
	* LumenSecond (lms)
	* Talbot (T)

### Luminous Intensity

	* Candela (cd)
	* Candlepower (Candlepower)
	* Hefnerkerse (HK)
	* Lumen Per Steradian (lmsr)

### Magnetomotive Force

	* Ampere-turns (AT)
	* Gilberts (Gi)

### Mass

	* Grams (g)
	* Kilograms (kg)
	* Milligrams (mg)
	* Ounces (oz)
	* Pounds (lb)
	* Stones (stone)
	* Tonnes (tonne)

### Pressure

	* Atmospheres (atm)
	* Bars (b)
	* Pascals (Pa)
	* Psi (psi)
	* Torrs (Torr)
