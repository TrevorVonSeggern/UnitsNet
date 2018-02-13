﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// Windows Runtime Component does not support CultureInfo type, so use culture name string instead for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
using Culture = System.String;
#else
using Culture = System.IFormatProvider;
#endif

// ReSharper disable once CheckNamespace
namespace UnitsNet
{
    using UnitsNet.InternalHelpers.Calculators;

    /// <summary>
    ///     Heat Transfer Coefficient or Thermal conductivity - indicates a materials ability to conduct heat.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
	public partial class ThermalResistance : UnitsNet.Generic.ThermalResistance<double, UnitsNet.InternalHelpers.Calculators.DoubleCalculator> { }

	namespace Generic
	{
#if WINDOWS_UWP
		public sealed partial class ThermalResistance
#else
		public partial class ThermalResistance <T, C> : IComparable, IComparable<ThermalResistance<T, C>>
			where T : struct
			where C : InternalHelpers.Calculators.INumberCalculator<T>, new()
#endif
		{
			/// <summary>
			///     Base unit of ThermalResistance.
			/// </summary>
			private readonly Number<T, C> _squareMeterKelvinsPerKilowatt;

			public ThermalResistance() : this(new Number<T,C>())
			{
			}

			public ThermalResistance(T squaremeterkelvinsperkilowatt)
			{
				_squareMeterKelvinsPerKilowatt = (squaremeterkelvinsperkilowatt);
			}

			public ThermalResistance(Number<T, C> squaremeterkelvinsperkilowatt)
			{
				_squareMeterKelvinsPerKilowatt = (squaremeterkelvinsperkilowatt);
			}

			#region Properties

			/// <summary>
			///     The <see cref="QuantityType" /> of this quantity.
			/// </summary>
			public static QuantityType QuantityType => QuantityType.ThermalResistance;

			/// <summary>
			///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
			/// </summary>
			public static ThermalResistanceUnit BaseUnit
			{
				get { return ThermalResistanceUnit.SquareMeterKelvinPerKilowatt; }
			}

			/// <summary>
			///     All units of measurement for the ThermalResistance quantity.
			/// </summary>
			public static ThermalResistanceUnit[] Units { get; } = Enum.GetValues(typeof(ThermalResistanceUnit)).Cast<ThermalResistanceUnit>().ToArray();

			/// <summary>
			///     Get ThermalResistance in HourSquareFeetDegreesFahrenheitPerBtu.
			/// </summary>
			public Number<T, C> HourSquareFeetDegreesFahrenheitPerBtu
			{
				get { return _squareMeterKelvinsPerKilowatt/176.1121482159839; }
			}

			/// <summary>
			///     Get ThermalResistance in SquareCentimeterHourDegreesCelsiusPerKilocalorie.
			/// </summary>
			public Number<T, C> SquareCentimeterHourDegreesCelsiusPerKilocalorie
			{
				get { return _squareMeterKelvinsPerKilowatt/0.0859779507590433; }
			}

			/// <summary>
			///     Get ThermalResistance in SquareCentimeterKelvinsPerWatt.
			/// </summary>
			public Number<T, C> SquareCentimeterKelvinsPerWatt
			{
				get { return _squareMeterKelvinsPerKilowatt/0.0999964777570357; }
			}

			/// <summary>
			///     Get ThermalResistance in SquareMeterDegreesCelsiusPerWatt.
			/// </summary>
			public Number<T, C> SquareMeterDegreesCelsiusPerWatt
			{
				get { return _squareMeterKelvinsPerKilowatt/1000.088056074108; }
			}

			/// <summary>
			///     Get ThermalResistance in SquareMeterKelvinsPerKilowatt.
			/// </summary>
			public Number<T, C> SquareMeterKelvinsPerKilowatt
			{
				get { return _squareMeterKelvinsPerKilowatt; }
			}

			#endregion

			#region Static

			public static ThermalResistance<T, C> Zero
			{
				get { return new ThermalResistance<T, C>(); }
			}

			/// <summary>
			///     Get ThermalResistance from HourSquareFeetDegreesFahrenheitPerBtu.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static ThermalResistance<T, C> FromHourSquareFeetDegreesFahrenheitPerBtu(Number<T, C> hoursquarefeetdegreesfahrenheitperbtu)
			{
				Number<T,C> value = (Number<T,C>) hoursquarefeetdegreesfahrenheitperbtu;
				return new ThermalResistance<T, C>(value*176.1121482159839);
			}
#else
			public static ThermalResistance<T, C> FromHourSquareFeetDegreesFahrenheitPerBtu(Number<T, C> hoursquarefeetdegreesfahrenheitperbtu)
			{
				Number<T,C> value = (Number<T,C>) hoursquarefeetdegreesfahrenheitperbtu;
				return new ThermalResistance<T, C>(new Number<T,C>(value*176.1121482159839));
			}
#endif

			/// <summary>
			///     Get ThermalResistance from SquareCentimeterHourDegreesCelsiusPerKilocalorie.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static ThermalResistance<T, C> FromSquareCentimeterHourDegreesCelsiusPerKilocalorie(Number<T, C> squarecentimeterhourdegreescelsiusperkilocalorie)
			{
				Number<T,C> value = (Number<T,C>) squarecentimeterhourdegreescelsiusperkilocalorie;
				return new ThermalResistance<T, C>(value*0.0859779507590433);
			}
#else
			public static ThermalResistance<T, C> FromSquareCentimeterHourDegreesCelsiusPerKilocalorie(Number<T, C> squarecentimeterhourdegreescelsiusperkilocalorie)
			{
				Number<T,C> value = (Number<T,C>) squarecentimeterhourdegreescelsiusperkilocalorie;
				return new ThermalResistance<T, C>(new Number<T,C>(value*0.0859779507590433));
			}
#endif

			/// <summary>
			///     Get ThermalResistance from SquareCentimeterKelvinsPerWatt.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static ThermalResistance<T, C> FromSquareCentimeterKelvinsPerWatt(Number<T, C> squarecentimeterkelvinsperwatt)
			{
				Number<T,C> value = (Number<T,C>) squarecentimeterkelvinsperwatt;
				return new ThermalResistance<T, C>(value*0.0999964777570357);
			}
#else
			public static ThermalResistance<T, C> FromSquareCentimeterKelvinsPerWatt(Number<T, C> squarecentimeterkelvinsperwatt)
			{
				Number<T,C> value = (Number<T,C>) squarecentimeterkelvinsperwatt;
				return new ThermalResistance<T, C>(new Number<T,C>(value*0.0999964777570357));
			}
#endif

			/// <summary>
			///     Get ThermalResistance from SquareMeterDegreesCelsiusPerWatt.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static ThermalResistance<T, C> FromSquareMeterDegreesCelsiusPerWatt(Number<T, C> squaremeterdegreescelsiusperwatt)
			{
				Number<T,C> value = (Number<T,C>) squaremeterdegreescelsiusperwatt;
				return new ThermalResistance<T, C>(value*1000.088056074108);
			}
#else
			public static ThermalResistance<T, C> FromSquareMeterDegreesCelsiusPerWatt(Number<T, C> squaremeterdegreescelsiusperwatt)
			{
				Number<T,C> value = (Number<T,C>) squaremeterdegreescelsiusperwatt;
				return new ThermalResistance<T, C>(new Number<T,C>(value*1000.088056074108));
			}
#endif

			/// <summary>
			///     Get ThermalResistance from SquareMeterKelvinsPerKilowatt.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static ThermalResistance<T, C> FromSquareMeterKelvinsPerKilowatt(Number<T, C> squaremeterkelvinsperkilowatt)
			{
				Number<T,C> value = (Number<T,C>) squaremeterkelvinsperkilowatt;
				return new ThermalResistance<T, C>(value);
			}
#else
			public static ThermalResistance<T, C> FromSquareMeterKelvinsPerKilowatt(Number<T, C> squaremeterkelvinsperkilowatt)
			{
				Number<T,C> value = (Number<T,C>) squaremeterkelvinsperkilowatt;
				return new ThermalResistance<T, C>(new Number<T,C>(value));
			}
#endif



			/// <summary>
			///     Dynamically convert from value and unit enum <see cref="ThermalResistanceUnit" /> to <see cref="ThermalResistance" />.
			/// </summary>
			/// <param name="value">Value to convert from.</param>
			/// <param name="fromUnit">Unit to convert from.</param>
			/// <returns>ThermalResistance unit value.</returns>
#if WINDOWS_UWP
			// Fix name conflict with parameter "value"
			[return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
			public static ThermalResistance<T, C> From(double value, ThermalResistanceUnit fromUnit)
#else
			public static ThermalResistance<T, C> From(Number<T, C> value, ThermalResistanceUnit fromUnit)
#endif
			{
				switch (fromUnit)
				{
					case ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu:
						return FromHourSquareFeetDegreesFahrenheitPerBtu(value);
					case ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie:
						return FromSquareCentimeterHourDegreesCelsiusPerKilocalorie(value);
					case ThermalResistanceUnit.SquareCentimeterKelvinPerWatt:
						return FromSquareCentimeterKelvinsPerWatt(value);
					case ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt:
						return FromSquareMeterDegreesCelsiusPerWatt(value);
					case ThermalResistanceUnit.SquareMeterKelvinPerKilowatt:
						return FromSquareMeterKelvinsPerKilowatt(value);

					default:
						throw new NotImplementedException("fromUnit: " + fromUnit);
				}
			}

			/// <summary>
			///     Get unit abbreviation string.
			/// </summary>
			/// <param name="unit">Unit to get abbreviation for.</param>
			/// <returns>Unit abbreviation string.</returns>
			[UsedImplicitly]
			public static string GetAbbreviation(ThermalResistanceUnit unit)
			{
				return GetAbbreviation(unit, null);
			}

			/// <summary>
			///     Get unit abbreviation string.
			/// </summary>
			/// <param name="unit">Unit to get abbreviation for.</param>
			/// <param name="culture">Culture to use for localization. Defaults to Thread.CurrentUICulture.</param>
			/// <returns>Unit abbreviation string.</returns>
			[UsedImplicitly]
			public static string GetAbbreviation(ThermalResistanceUnit unit, [CanBeNull] Culture culture)
			{
				return UnitSystem.GetCached(culture).GetDefaultAbbreviation(unit);
			}

			#endregion

			#region Arithmetic Operators

			// Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
			public static ThermalResistance<T, C> operator -(ThermalResistance<T, C> right)
			{
				return new ThermalResistance<T, C>(-right._squareMeterKelvinsPerKilowatt);
			}

			public static ThermalResistance<T, C> operator +(ThermalResistance<T, C> left, ThermalResistance<T, C> right)
			{
				return new ThermalResistance<T, C>(left._squareMeterKelvinsPerKilowatt + right._squareMeterKelvinsPerKilowatt);
			}

			public static ThermalResistance<T, C> operator -(ThermalResistance<T, C> left, ThermalResistance<T, C> right)
			{
				return new ThermalResistance<T, C>(left._squareMeterKelvinsPerKilowatt - right._squareMeterKelvinsPerKilowatt);
			}

			public static ThermalResistance<T, C> operator *(Number<T, C> left, ThermalResistance<T, C> right)
			{
				return new ThermalResistance<T, C>(left*right._squareMeterKelvinsPerKilowatt);
			}

			public static ThermalResistance<T, C> operator *(ThermalResistance<T, C> left, double right)
			{
				return new ThermalResistance<T, C>(left._squareMeterKelvinsPerKilowatt*right);
			}

			public static ThermalResistance<T, C> operator /(ThermalResistance<T, C> left, double right)
			{
				return new ThermalResistance<T, C>(left._squareMeterKelvinsPerKilowatt/right);
			}

			public static double operator /(ThermalResistance<T, C> left, ThermalResistance<T, C> right)
			{
				return Convert.ToDouble(left._squareMeterKelvinsPerKilowatt/right._squareMeterKelvinsPerKilowatt);
			}
#endif

			#endregion

			#region Equality / IComparable

			public int CompareTo(object obj)
			{
				if (obj == null) throw new ArgumentNullException("obj");
				if (!(obj is ThermalResistance<T, C>)) throw new ArgumentException("Expected type ThermalResistance.", "obj");
				return CompareTo((ThermalResistance<T, C>) obj);
			}

			// Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
			internal
#else
			public
#endif
			int CompareTo(ThermalResistance<T, C> other)
			{
				return _squareMeterKelvinsPerKilowatt.CompareTo(other._squareMeterKelvinsPerKilowatt);
			}

			// Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
			public static bool operator <=(ThermalResistance<T, C> left, ThermalResistance<T, C> right)
			{
				return left._squareMeterKelvinsPerKilowatt <= right._squareMeterKelvinsPerKilowatt;
			}

			public static bool operator >=(ThermalResistance<T, C> left, ThermalResistance<T, C> right)
			{
				return left._squareMeterKelvinsPerKilowatt >= right._squareMeterKelvinsPerKilowatt;
			}

			public static bool operator <(ThermalResistance<T, C> left, ThermalResistance<T, C> right)
			{
				return left._squareMeterKelvinsPerKilowatt < right._squareMeterKelvinsPerKilowatt;
			}

			public static bool operator >(ThermalResistance<T, C> left, ThermalResistance<T, C> right)
			{
				return left._squareMeterKelvinsPerKilowatt > right._squareMeterKelvinsPerKilowatt;
			}

			[Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(ThermalResistance<T, C> left, ThermalResistance<T, C> right)
			{
				// ReSharper disable once CompareOfFloatsByEqualityOperator
				return left._squareMeterKelvinsPerKilowatt == right._squareMeterKelvinsPerKilowatt;
			}

			[Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(ThermalResistance<T, C> left, ThermalResistance<T, C> right)
			{
				// ReSharper disable once CompareOfFloatsByEqualityOperator
				return left._squareMeterKelvinsPerKilowatt != right._squareMeterKelvinsPerKilowatt;
			}
#endif

			[Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public override bool Equals(object obj)
			{
				if (obj == null || GetType() != obj.GetType())
				{
					return false;
				}

				return _squareMeterKelvinsPerKilowatt.Equals(((ThermalResistance<T, C>) obj)._squareMeterKelvinsPerKilowatt);
			}

			/// <summary>
			///     Compare equality to another ThermalResistance by specifying a max allowed difference.
			///     Note that it is advised against specifying zero difference, due to the nature
			///     of floating point operations and using System.Double internally.
			/// </summary>
			/// <param name="other">Other quantity to compare to.</param>
			/// <param name="maxError">Max error allowed.</param>
			/// <returns>True if the difference between the two values is not greater than the specified max.</returns>
			public bool Equals(ThermalResistance<T, C> other, ThermalResistance<T, C> maxError)
			{
				return Math.Abs((decimal)_squareMeterKelvinsPerKilowatt - (decimal)other._squareMeterKelvinsPerKilowatt) <= maxError._squareMeterKelvinsPerKilowatt;
			}

			public override int GetHashCode()
			{
				return _squareMeterKelvinsPerKilowatt.GetHashCode();
			}

			#endregion

			#region Conversion

			/// <summary>
			///     Convert to the unit representation <paramref name="unit" />.
			/// </summary>
			/// <returns>Value in new unit if successful, exception otherwise.</returns>
			/// <exception cref="NotImplementedException">If conversion was not successful.</exception>
			public Number<T, C> As(ThermalResistanceUnit unit)
			{
				switch (unit)
				{
					case ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu:
						return HourSquareFeetDegreesFahrenheitPerBtu;
					case ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie:
						return SquareCentimeterHourDegreesCelsiusPerKilocalorie;
					case ThermalResistanceUnit.SquareCentimeterKelvinPerWatt:
						return SquareCentimeterKelvinsPerWatt;
					case ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt:
						return SquareMeterDegreesCelsiusPerWatt;
					case ThermalResistanceUnit.SquareMeterKelvinPerKilowatt:
						return SquareMeterKelvinsPerKilowatt;

					default:
						throw new NotImplementedException("unit: " + unit);
				}
			}

			#endregion

			#region Parsing

			/// <summary>
			///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
			/// </summary>
			/// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
			/// <example>
			///     Length.Parse("5.5 m", new CultureInfo("en-US"));
			/// </example>
			/// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
			/// <exception cref="ArgumentException">
			///     Expected string to have one or two pairs of quantity and unit in the format
			///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
			/// </exception>
			/// <exception cref="AmbiguousUnitParseException">
			///     More than one unit is represented by the specified unit abbreviation.
			///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
			///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
			/// </exception>
			/// <exception cref="UnitsNetException">
			///     If anything else goes wrong, typically due to a bug or unhandled case.
			///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
			///     Units.NET exceptions from other exceptions.
			/// </exception>
			public static ThermalResistance<T, C> Parse(string str)
			{
				return Parse(str, null);
			}

			/// <summary>
			///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
			/// </summary>
			/// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
			/// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
			/// <example>
			///     Length.Parse("5.5 m", new CultureInfo("en-US"));
			/// </example>
			/// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
			/// <exception cref="ArgumentException">
			///     Expected string to have one or two pairs of quantity and unit in the format
			///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
			/// </exception>
			/// <exception cref="AmbiguousUnitParseException">
			///     More than one unit is represented by the specified unit abbreviation.
			///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
			///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
			/// </exception>
			/// <exception cref="UnitsNetException">
			///     If anything else goes wrong, typically due to a bug or unhandled case.
			///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
			///     Units.NET exceptions from other exceptions.
			/// </exception>
			public static ThermalResistance<T, C> Parse(string str, [CanBeNull] Culture culture)
			{
				if (str == null) throw new ArgumentNullException("str");

			// Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
				IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
				IFormatProvider formatProvider = culture;
#endif
					return QuantityParser.Parse<ThermalResistance<T, C>, ThermalResistanceUnit>(str, formatProvider,
					delegate(string value, string unit, IFormatProvider formatProvider2)
					{
						double parsedValue = double.Parse(value, formatProvider2);
						ThermalResistanceUnit parsedUnit = ParseUnit(unit, formatProvider2);
						return From(new C().ConvertToNumber(parsedValue), parsedUnit);
					}, (x, y) => FromSquareMeterKelvinsPerKilowatt((Number<T, C>)x.SquareMeterKelvinsPerKilowatt + y.SquareMeterKelvinsPerKilowatt));
			}

			/// <summary>
			///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
			/// </summary>
			/// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
			/// <param name="result">Resulting unit quantity if successful.</param>
			/// <example>
			///     Length.Parse("5.5 m", new CultureInfo("en-US"));
			/// </example>
			public static bool TryParse([CanBeNull] string str, out ThermalResistance<T, C> result)
			{
				return TryParse(str, null, out result);
			}

			/// <summary>
			///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
			/// </summary>
			/// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
			/// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
			/// <param name="result">Resulting unit quantity if successful.</param>
			/// <example>
			///     Length.Parse("5.5 m", new CultureInfo("en-US"));
			/// </example>
			public static bool TryParse([CanBeNull] string str, [CanBeNull] Culture culture, out ThermalResistance<T, C> result)
			{
				try
				{
					result = Parse(str, culture);
					return true;
				}
				catch
				{
					result = default(ThermalResistance<T, C>);
					return false;
				}
			}

			/// <summary>
			///     Parse a unit string.
			/// </summary>
			/// <example>
			///     Length.ParseUnit("m", new CultureInfo("en-US"));
			/// </example>
			/// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
			/// <exception cref="UnitsNetException">Error parsing string.</exception>
			public static ThermalResistanceUnit ParseUnit(string str)
			{
				return ParseUnit(str, (IFormatProvider)null);
			}

			/// <summary>
			///     Parse a unit string.
			/// </summary>
			/// <example>
			///     Length.ParseUnit("m", new CultureInfo("en-US"));
			/// </example>
			/// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
			/// <exception cref="UnitsNetException">Error parsing string.</exception>
			public static ThermalResistanceUnit ParseUnit(string str, [CanBeNull] string cultureName)
			{
				return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
			}

			/// <summary>
			///     Parse a unit string.
			/// </summary>
			/// <example>
			///     Length.ParseUnit("m", new CultureInfo("en-US"));
			/// </example>
			/// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
			/// <exception cref="UnitsNetException">Error parsing string.</exception>

			// Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
			internal
#else
			public
#endif
			static ThermalResistanceUnit ParseUnit(string str, IFormatProvider formatProvider = null)
			{
				if (str == null) throw new ArgumentNullException("str");

				var unitSystem = UnitSystem.GetCached(formatProvider);
				var unit = unitSystem.Parse<ThermalResistanceUnit>(str.Trim());

				if (unit == ThermalResistanceUnit.Undefined)
				{
					var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized ThermalResistanceUnit.");
					newEx.Data["input"] = str;
					newEx.Data["formatprovider"] = formatProvider?.ToString() ?? "(null)";
					throw newEx;
				}

				return unit;
			}

			#endregion

			/// <summary>
			///     Set the default unit used by ToString(). Default is SquareMeterKelvinPerKilowatt
			/// </summary>
			public static ThermalResistanceUnit ToStringDefaultUnit { get; set; } = ThermalResistanceUnit.SquareMeterKelvinPerKilowatt;

			/// <summary>
			///     Get default string representation of value and unit.
			/// </summary>
			/// <returns>String representation.</returns>
			public override string ToString()
			{
				return ToString(ToStringDefaultUnit);
			}

			/// <summary>
			///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
			/// </summary>
			/// <param name="unit">Unit representation to use.</param>
			/// <returns>String representation.</returns>
			public string ToString(ThermalResistanceUnit unit)
			{
				return ToString(unit, null, 2);
			}

			/// <summary>
			///     Get string representation of value and unit. Using two significant digits after radix.
			/// </summary>
			/// <param name="unit">Unit representation to use.</param>
			/// <param name="culture">Culture to use for localization and number formatting.</param>
			/// <returns>String representation.</returns>
			public string ToString(ThermalResistanceUnit unit, [CanBeNull] Culture culture)
			{
				return ToString(unit, culture, 2);
			}

			/// <summary>
			///     Get string representation of value and unit.
			/// </summary>
			/// <param name="unit">Unit representation to use.</param>
			/// <param name="culture">Culture to use for localization and number formatting.</param>
			/// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
			/// <returns>String representation.</returns>
			[UsedImplicitly]
			public string ToString(ThermalResistanceUnit unit, [CanBeNull] Culture culture, int significantDigitsAfterRadix)
			{
				Number<T, C>  value = As(unit);
				string format = UnitFormatter.GetFormat((double)value, significantDigitsAfterRadix);
				return ToString(unit, culture, format);
			}

			/// <summary>
			///     Get string representation of value and unit.
			/// </summary>
			/// <param name="culture">Culture to use for localization and number formatting.</param>
			/// <param name="unit">Unit representation to use.</param>
			/// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
			/// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
			/// <returns>String representation.</returns>
			[UsedImplicitly]
			public string ToString(ThermalResistanceUnit unit, [CanBeNull] Culture culture, [NotNull] string format,
				[NotNull] params object[] args)
			{
				if (format == null) throw new ArgumentNullException(nameof(format));
				if (args == null) throw new ArgumentNullException(nameof(args));

			// Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
				IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
				IFormatProvider formatProvider = culture;
#endif
				Number<T, C>  value = As(unit);
				object[] formatArgs = UnitFormatter.GetFormatArgs(unit, (double)value, formatProvider, args);
				return string.Format(formatProvider, format, formatArgs);
			}

			/// <summary>
			/// Represents the largest possible value of ThermalResistance
			/// </summary>
			public static Number<T, C> MaxValue
			{
				get
				{
					return Number<T, C>.MaxValue;
				}
			}

			/// <summary>
			/// Represents the smallest possible value of ThermalResistance
			/// </summary>
			public static Number<T, C> MinValue
			{
				get
				{
					return Number<T, C>.MinValue;
				}
			}
		}
	}
}
