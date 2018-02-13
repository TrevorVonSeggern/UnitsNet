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
    ///     The strength of a signal expressed in decibels (dB) relative to one volt RMS.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
	public partial class AmplitudeRatio : UnitsNet.Generic.AmplitudeRatio<double, UnitsNet.InternalHelpers.Calculators.DoubleCalculator> { }

	namespace Generic
	{
#if WINDOWS_UWP
		public sealed partial class AmplitudeRatio
#else
		public partial class AmplitudeRatio <T, C> : IComparable, IComparable<AmplitudeRatio<T, C>>
			where T : struct
			where C : InternalHelpers.Calculators.INumberCalculator<T>, new()
#endif
		{
			/// <summary>
			///     Base unit of AmplitudeRatio.
			/// </summary>
			private readonly Number<T, C> _decibelVolts;

			public AmplitudeRatio() : this(new Number<T,C>())
			{
			}

			public AmplitudeRatio(T decibelvolts)
			{
				_decibelVolts = (decibelvolts);
			}

			public AmplitudeRatio(Number<T, C> decibelvolts)
			{
				_decibelVolts = (decibelvolts);
			}

			#region Properties

			/// <summary>
			///     The <see cref="QuantityType" /> of this quantity.
			/// </summary>
			public static QuantityType QuantityType => QuantityType.AmplitudeRatio;

			/// <summary>
			///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
			/// </summary>
			public static AmplitudeRatioUnit BaseUnit
			{
				get { return AmplitudeRatioUnit.DecibelVolt; }
			}

			/// <summary>
			///     All units of measurement for the AmplitudeRatio quantity.
			/// </summary>
			public static AmplitudeRatioUnit[] Units { get; } = Enum.GetValues(typeof(AmplitudeRatioUnit)).Cast<AmplitudeRatioUnit>().ToArray();

			/// <summary>
			///     Get AmplitudeRatio in DecibelMicrovolts.
			/// </summary>
			public Number<T, C> DecibelMicrovolts
			{
				get { return _decibelVolts + 120; }
			}

			/// <summary>
			///     Get AmplitudeRatio in DecibelMillivolts.
			/// </summary>
			public Number<T, C> DecibelMillivolts
			{
				get { return _decibelVolts + 60; }
			}

			/// <summary>
			///     Get AmplitudeRatio in DecibelsUnloaded.
			/// </summary>
			public Number<T, C> DecibelsUnloaded
			{
				get { return _decibelVolts + 2.218487499; }
			}

			/// <summary>
			///     Get AmplitudeRatio in DecibelVolts.
			/// </summary>
			public Number<T, C> DecibelVolts
			{
				get { return _decibelVolts; }
			}

			#endregion

			#region Static

			public static AmplitudeRatio<T, C> Zero
			{
				get { return new AmplitudeRatio<T, C>(); }
			}

			/// <summary>
			///     Get AmplitudeRatio from DecibelMicrovolts.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static AmplitudeRatio<T, C> FromDecibelMicrovolts(Number<T, C> decibelmicrovolts)
			{
				Number<T,C> value = (Number<T,C>) decibelmicrovolts;
				return new AmplitudeRatio<T, C>(value - 120);
			}
#else
			public static AmplitudeRatio<T, C> FromDecibelMicrovolts(Number<T, C> decibelmicrovolts)
			{
				Number<T,C> value = (Number<T,C>) decibelmicrovolts;
				return new AmplitudeRatio<T, C>(new Number<T,C>(value - 120));
			}
#endif

			/// <summary>
			///     Get AmplitudeRatio from DecibelMillivolts.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static AmplitudeRatio<T, C> FromDecibelMillivolts(Number<T, C> decibelmillivolts)
			{
				Number<T,C> value = (Number<T,C>) decibelmillivolts;
				return new AmplitudeRatio<T, C>(value - 60);
			}
#else
			public static AmplitudeRatio<T, C> FromDecibelMillivolts(Number<T, C> decibelmillivolts)
			{
				Number<T,C> value = (Number<T,C>) decibelmillivolts;
				return new AmplitudeRatio<T, C>(new Number<T,C>(value - 60));
			}
#endif

			/// <summary>
			///     Get AmplitudeRatio from DecibelsUnloaded.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static AmplitudeRatio<T, C> FromDecibelsUnloaded(Number<T, C> decibelsunloaded)
			{
				Number<T,C> value = (Number<T,C>) decibelsunloaded;
				return new AmplitudeRatio<T, C>(value - 2.218487499);
			}
#else
			public static AmplitudeRatio<T, C> FromDecibelsUnloaded(Number<T, C> decibelsunloaded)
			{
				Number<T,C> value = (Number<T,C>) decibelsunloaded;
				return new AmplitudeRatio<T, C>(new Number<T,C>(value - 2.218487499));
			}
#endif

			/// <summary>
			///     Get AmplitudeRatio from DecibelVolts.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static AmplitudeRatio<T, C> FromDecibelVolts(Number<T, C> decibelvolts)
			{
				Number<T,C> value = (Number<T,C>) decibelvolts;
				return new AmplitudeRatio<T, C>(value);
			}
#else
			public static AmplitudeRatio<T, C> FromDecibelVolts(Number<T, C> decibelvolts)
			{
				Number<T,C> value = (Number<T,C>) decibelvolts;
				return new AmplitudeRatio<T, C>(new Number<T,C>(value));
			}
#endif



			/// <summary>
			///     Dynamically convert from value and unit enum <see cref="AmplitudeRatioUnit" /> to <see cref="AmplitudeRatio" />.
			/// </summary>
			/// <param name="value">Value to convert from.</param>
			/// <param name="fromUnit">Unit to convert from.</param>
			/// <returns>AmplitudeRatio unit value.</returns>
#if WINDOWS_UWP
			// Fix name conflict with parameter "value"
			[return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
			public static AmplitudeRatio<T, C> From(double value, AmplitudeRatioUnit fromUnit)
#else
			public static AmplitudeRatio<T, C> From(Number<T, C> value, AmplitudeRatioUnit fromUnit)
#endif
			{
				switch (fromUnit)
				{
					case AmplitudeRatioUnit.DecibelMicrovolt:
						return FromDecibelMicrovolts(value);
					case AmplitudeRatioUnit.DecibelMillivolt:
						return FromDecibelMillivolts(value);
					case AmplitudeRatioUnit.DecibelUnloaded:
						return FromDecibelsUnloaded(value);
					case AmplitudeRatioUnit.DecibelVolt:
						return FromDecibelVolts(value);

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
			public static string GetAbbreviation(AmplitudeRatioUnit unit)
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
			public static string GetAbbreviation(AmplitudeRatioUnit unit, [CanBeNull] Culture culture)
			{
				return UnitSystem.GetCached(culture).GetDefaultAbbreviation(unit);
			}

			#endregion

        #region Logarithmic Arithmetic Operators

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static AmplitudeRatio<T, C> operator -(AmplitudeRatio<T, C> right)
        {
            return new AmplitudeRatio<T, C>(-right._decibelVolts);
        }

        public static AmplitudeRatio<T, C> operator +(AmplitudeRatio<T, C> left, AmplitudeRatio<T, C> right)
        {
            // Logarithmic addition
            // Formula: 20*log10(10^(x/20) + 10^(y/20))
            return new AmplitudeRatio<T, C>(20*Math.Log10(Math.Pow(10, left._decibelVolts/20) + Math.Pow(10, right._decibelVolts/20)));
        }

        public static AmplitudeRatio<T, C> operator -(AmplitudeRatio<T, C> left, AmplitudeRatio<T, C> right)
        {
            // Logarithmic subtraction
            // Formula: 20*log10(10^(x/20) - 10^(y/20))
            return new AmplitudeRatio<T, C>(20*Math.Log10(Math.Pow(10, left._decibelVolts/20) - Math.Pow(10, right._decibelVolts/20)));
        }

        public static AmplitudeRatio<T, C> operator *(Number<T, C> left, AmplitudeRatio<T, C> right)
        {
            // Logarithmic multiplication = addition
            return new AmplitudeRatio<T, C>(left + right._decibelVolts);
        }

        public static AmplitudeRatio<T, C> operator *(AmplitudeRatio<T, C> left, double right)
        {
            // Logarithmic multiplication = addition
            return new AmplitudeRatio<T, C>(left._decibelVolts + (Number<T, C>)right);
        }

        public static AmplitudeRatio<T, C> operator /(AmplitudeRatio<T, C> left, double right)
        {
            // Logarithmic division = subtraction
            return new AmplitudeRatio<T, C>(left._decibelVolts - (Number<T, C>)right);
        }

        public static double operator /(AmplitudeRatio<T, C> left, AmplitudeRatio<T, C> right)
        {
            // Logarithmic division = subtraction
            return Convert.ToDouble(left._decibelVolts - right._decibelVolts);
        }
#endif

        #endregion

			#region Equality / IComparable

			public int CompareTo(object obj)
			{
				if (obj == null) throw new ArgumentNullException("obj");
				if (!(obj is AmplitudeRatio<T, C>)) throw new ArgumentException("Expected type AmplitudeRatio.", "obj");
				return CompareTo((AmplitudeRatio<T, C>) obj);
			}

			// Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
			internal
#else
			public
#endif
			int CompareTo(AmplitudeRatio<T, C> other)
			{
				return _decibelVolts.CompareTo(other._decibelVolts);
			}

			// Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
			public static bool operator <=(AmplitudeRatio<T, C> left, AmplitudeRatio<T, C> right)
			{
				return left._decibelVolts <= right._decibelVolts;
			}

			public static bool operator >=(AmplitudeRatio<T, C> left, AmplitudeRatio<T, C> right)
			{
				return left._decibelVolts >= right._decibelVolts;
			}

			public static bool operator <(AmplitudeRatio<T, C> left, AmplitudeRatio<T, C> right)
			{
				return left._decibelVolts < right._decibelVolts;
			}

			public static bool operator >(AmplitudeRatio<T, C> left, AmplitudeRatio<T, C> right)
			{
				return left._decibelVolts > right._decibelVolts;
			}

			[Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(AmplitudeRatio<T, C> left, AmplitudeRatio<T, C> right)
			{
				// ReSharper disable once CompareOfFloatsByEqualityOperator
				return left._decibelVolts == right._decibelVolts;
			}

			[Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(AmplitudeRatio<T, C> left, AmplitudeRatio<T, C> right)
			{
				// ReSharper disable once CompareOfFloatsByEqualityOperator
				return left._decibelVolts != right._decibelVolts;
			}
#endif

			[Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public override bool Equals(object obj)
			{
				if (obj == null || GetType() != obj.GetType())
				{
					return false;
				}

				return _decibelVolts.Equals(((AmplitudeRatio<T, C>) obj)._decibelVolts);
			}

			/// <summary>
			///     Compare equality to another AmplitudeRatio by specifying a max allowed difference.
			///     Note that it is advised against specifying zero difference, due to the nature
			///     of floating point operations and using System.Double internally.
			/// </summary>
			/// <param name="other">Other quantity to compare to.</param>
			/// <param name="maxError">Max error allowed.</param>
			/// <returns>True if the difference between the two values is not greater than the specified max.</returns>
			public bool Equals(AmplitudeRatio<T, C> other, AmplitudeRatio<T, C> maxError)
			{
				return Math.Abs((decimal)_decibelVolts - (decimal)other._decibelVolts) <= maxError._decibelVolts;
			}

			public override int GetHashCode()
			{
				return _decibelVolts.GetHashCode();
			}

			#endregion

			#region Conversion

			/// <summary>
			///     Convert to the unit representation <paramref name="unit" />.
			/// </summary>
			/// <returns>Value in new unit if successful, exception otherwise.</returns>
			/// <exception cref="NotImplementedException">If conversion was not successful.</exception>
			public Number<T, C> As(AmplitudeRatioUnit unit)
			{
				switch (unit)
				{
					case AmplitudeRatioUnit.DecibelMicrovolt:
						return DecibelMicrovolts;
					case AmplitudeRatioUnit.DecibelMillivolt:
						return DecibelMillivolts;
					case AmplitudeRatioUnit.DecibelUnloaded:
						return DecibelsUnloaded;
					case AmplitudeRatioUnit.DecibelVolt:
						return DecibelVolts;

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
			public static AmplitudeRatio<T, C> Parse(string str)
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
			public static AmplitudeRatio<T, C> Parse(string str, [CanBeNull] Culture culture)
			{
				if (str == null) throw new ArgumentNullException("str");

			// Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
				IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
				IFormatProvider formatProvider = culture;
#endif
					return QuantityParser.Parse<AmplitudeRatio<T, C>, AmplitudeRatioUnit>(str, formatProvider,
					delegate(string value, string unit, IFormatProvider formatProvider2)
					{
						double parsedValue = double.Parse(value, formatProvider2);
						AmplitudeRatioUnit parsedUnit = ParseUnit(unit, formatProvider2);
						return From(new C().ConvertToNumber(parsedValue), parsedUnit);
					}, (x, y) => FromDecibelVolts((Number<T, C>)x.DecibelVolts + y.DecibelVolts));
			}

			/// <summary>
			///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
			/// </summary>
			/// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
			/// <param name="result">Resulting unit quantity if successful.</param>
			/// <example>
			///     Length.Parse("5.5 m", new CultureInfo("en-US"));
			/// </example>
			public static bool TryParse([CanBeNull] string str, out AmplitudeRatio<T, C> result)
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
			public static bool TryParse([CanBeNull] string str, [CanBeNull] Culture culture, out AmplitudeRatio<T, C> result)
			{
				try
				{
					result = Parse(str, culture);
					return true;
				}
				catch
				{
					result = default(AmplitudeRatio<T, C>);
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
			public static AmplitudeRatioUnit ParseUnit(string str)
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
			public static AmplitudeRatioUnit ParseUnit(string str, [CanBeNull] string cultureName)
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
			static AmplitudeRatioUnit ParseUnit(string str, IFormatProvider formatProvider = null)
			{
				if (str == null) throw new ArgumentNullException("str");

				var unitSystem = UnitSystem.GetCached(formatProvider);
				var unit = unitSystem.Parse<AmplitudeRatioUnit>(str.Trim());

				if (unit == AmplitudeRatioUnit.Undefined)
				{
					var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized AmplitudeRatioUnit.");
					newEx.Data["input"] = str;
					newEx.Data["formatprovider"] = formatProvider?.ToString() ?? "(null)";
					throw newEx;
				}

				return unit;
			}

			#endregion

			/// <summary>
			///     Set the default unit used by ToString(). Default is DecibelVolt
			/// </summary>
			public static AmplitudeRatioUnit ToStringDefaultUnit { get; set; } = AmplitudeRatioUnit.DecibelVolt;

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
			public string ToString(AmplitudeRatioUnit unit)
			{
				return ToString(unit, null, 2);
			}

			/// <summary>
			///     Get string representation of value and unit. Using two significant digits after radix.
			/// </summary>
			/// <param name="unit">Unit representation to use.</param>
			/// <param name="culture">Culture to use for localization and number formatting.</param>
			/// <returns>String representation.</returns>
			public string ToString(AmplitudeRatioUnit unit, [CanBeNull] Culture culture)
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
			public string ToString(AmplitudeRatioUnit unit, [CanBeNull] Culture culture, int significantDigitsAfterRadix)
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
			public string ToString(AmplitudeRatioUnit unit, [CanBeNull] Culture culture, [NotNull] string format,
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
			/// Represents the largest possible value of AmplitudeRatio
			/// </summary>
			public static Number<T, C> MaxValue
			{
				get
				{
					return Number<T, C>.MaxValue;
				}
			}

			/// <summary>
			/// Represents the smallest possible value of AmplitudeRatio
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
