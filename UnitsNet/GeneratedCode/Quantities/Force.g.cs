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
    ///     In physics, a force is any influence that causes an object to undergo a certain change, either concerning its movement, direction, or geometrical construction. In other words, a force can cause an object with mass to change its velocity (which includes to begin moving from a state of rest), i.e., to accelerate, or a flexible object to deform, or both. Force can also be described by intuitive concepts such as a push or a pull. A force has both magnitude and direction, making it a vector quantity. It is measured in the SI unit of newtons and represented by the symbol F.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
	public partial class Force : UnitsNet.Generic.Force<double, UnitsNet.InternalHelpers.Calculators.DoubleCalculator> { }

	namespace Generic
	{
#if WINDOWS_UWP
		public sealed partial class Force
#else
		public partial class Force <T, C> : IComparable, IComparable<Force<T, C>>
			where T : struct
			where C : InternalHelpers.Calculators.INumberCalculator<T>, new()
#endif
		{
			/// <summary>
			///     Base unit of Force.
			/// </summary>
			private readonly Number<T, C> _newtons;

			public Force() : this(new Number<T,C>())
			{
			}

			public Force(T newtons)
			{
				_newtons = (newtons);
			}

			public Force(Number<T, C> newtons)
			{
				_newtons = (newtons);
			}

			#region Properties

			/// <summary>
			///     The <see cref="QuantityType" /> of this quantity.
			/// </summary>
			public static QuantityType QuantityType => QuantityType.Force;

			/// <summary>
			///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
			/// </summary>
			public static ForceUnit BaseUnit
			{
				get { return ForceUnit.Newton; }
			}

			/// <summary>
			///     All units of measurement for the Force quantity.
			/// </summary>
			public static ForceUnit[] Units { get; } = Enum.GetValues(typeof(ForceUnit)).Cast<ForceUnit>().ToArray();

			/// <summary>
			///     Get Force in Decanewtons.
			/// </summary>
			public Number<T, C> Decanewtons
			{
				get { return (_newtons) / 1e1d; }
			}

			/// <summary>
			///     Get Force in Dyne.
			/// </summary>
			public Number<T, C> Dyne
			{
				get { return _newtons*1e5; }
			}

			/// <summary>
			///     Get Force in KilogramsForce.
			/// </summary>
			public Number<T, C> KilogramsForce
			{
				get { return _newtons/9.80665002864; }
			}

			/// <summary>
			///     Get Force in Kilonewtons.
			/// </summary>
			public Number<T, C> Kilonewtons
			{
				get { return (_newtons) / 1e3d; }
			}

			/// <summary>
			///     Get Force in KiloPonds.
			/// </summary>
			public Number<T, C> KiloPonds
			{
				get { return _newtons/9.80665002864; }
			}

			/// <summary>
			///     Get Force in Meganewtons.
			/// </summary>
			public Number<T, C> Meganewtons
			{
				get { return (_newtons) / 1e6d; }
			}

			/// <summary>
			///     Get Force in Newtons.
			/// </summary>
			public Number<T, C> Newtons
			{
				get { return _newtons; }
			}

			/// <summary>
			///     Get Force in Poundals.
			/// </summary>
			public Number<T, C> Poundals
			{
				get { return _newtons/0.13825502798973041652092282466083; }
			}

			/// <summary>
			///     Get Force in PoundsForce.
			/// </summary>
			public Number<T, C> PoundsForce
			{
				get { return _newtons/4.4482216152605095551842641431421; }
			}

			/// <summary>
			///     Get Force in TonnesForce.
			/// </summary>
			public Number<T, C> TonnesForce
			{
				get { return _newtons/9.80665002864/1000; }
			}

			#endregion

			#region Static

			public static Force<T, C> Zero
			{
				get { return new Force<T, C>(); }
			}

			/// <summary>
			///     Get Force from Decanewtons.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Force<T, C> FromDecanewtons(Number<T, C> decanewtons)
			{
				Number<T,C> value = (Number<T,C>) decanewtons;
				return new Force<T, C>((value) * 1e1d);
			}
#else
			public static Force<T, C> FromDecanewtons(Number<T, C> decanewtons)
			{
				Number<T,C> value = (Number<T,C>) decanewtons;
				return new Force<T, C>(new Number<T,C>((value) * 1e1d));
			}
#endif

			/// <summary>
			///     Get Force from Dyne.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Force<T, C> FromDyne(Number<T, C> dyne)
			{
				Number<T,C> value = (Number<T,C>) dyne;
				return new Force<T, C>(value/1e5);
			}
#else
			public static Force<T, C> FromDyne(Number<T, C> dyne)
			{
				Number<T,C> value = (Number<T,C>) dyne;
				return new Force<T, C>(new Number<T,C>(value/1e5));
			}
#endif

			/// <summary>
			///     Get Force from KilogramsForce.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Force<T, C> FromKilogramsForce(Number<T, C> kilogramsforce)
			{
				Number<T,C> value = (Number<T,C>) kilogramsforce;
				return new Force<T, C>(value*9.80665002864);
			}
#else
			public static Force<T, C> FromKilogramsForce(Number<T, C> kilogramsforce)
			{
				Number<T,C> value = (Number<T,C>) kilogramsforce;
				return new Force<T, C>(new Number<T,C>(value*9.80665002864));
			}
#endif

			/// <summary>
			///     Get Force from Kilonewtons.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Force<T, C> FromKilonewtons(Number<T, C> kilonewtons)
			{
				Number<T,C> value = (Number<T,C>) kilonewtons;
				return new Force<T, C>((value) * 1e3d);
			}
#else
			public static Force<T, C> FromKilonewtons(Number<T, C> kilonewtons)
			{
				Number<T,C> value = (Number<T,C>) kilonewtons;
				return new Force<T, C>(new Number<T,C>((value) * 1e3d));
			}
#endif

			/// <summary>
			///     Get Force from KiloPonds.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Force<T, C> FromKiloPonds(Number<T, C> kiloponds)
			{
				Number<T,C> value = (Number<T,C>) kiloponds;
				return new Force<T, C>(value*9.80665002864);
			}
#else
			public static Force<T, C> FromKiloPonds(Number<T, C> kiloponds)
			{
				Number<T,C> value = (Number<T,C>) kiloponds;
				return new Force<T, C>(new Number<T,C>(value*9.80665002864));
			}
#endif

			/// <summary>
			///     Get Force from Meganewtons.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Force<T, C> FromMeganewtons(Number<T, C> meganewtons)
			{
				Number<T,C> value = (Number<T,C>) meganewtons;
				return new Force<T, C>((value) * 1e6d);
			}
#else
			public static Force<T, C> FromMeganewtons(Number<T, C> meganewtons)
			{
				Number<T,C> value = (Number<T,C>) meganewtons;
				return new Force<T, C>(new Number<T,C>((value) * 1e6d));
			}
#endif

			/// <summary>
			///     Get Force from Newtons.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Force<T, C> FromNewtons(Number<T, C> newtons)
			{
				Number<T,C> value = (Number<T,C>) newtons;
				return new Force<T, C>(value);
			}
#else
			public static Force<T, C> FromNewtons(Number<T, C> newtons)
			{
				Number<T,C> value = (Number<T,C>) newtons;
				return new Force<T, C>(new Number<T,C>(value));
			}
#endif

			/// <summary>
			///     Get Force from Poundals.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Force<T, C> FromPoundals(Number<T, C> poundals)
			{
				Number<T,C> value = (Number<T,C>) poundals;
				return new Force<T, C>(value*0.13825502798973041652092282466083);
			}
#else
			public static Force<T, C> FromPoundals(Number<T, C> poundals)
			{
				Number<T,C> value = (Number<T,C>) poundals;
				return new Force<T, C>(new Number<T,C>(value*0.13825502798973041652092282466083));
			}
#endif

			/// <summary>
			///     Get Force from PoundsForce.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Force<T, C> FromPoundsForce(Number<T, C> poundsforce)
			{
				Number<T,C> value = (Number<T,C>) poundsforce;
				return new Force<T, C>(value*4.4482216152605095551842641431421);
			}
#else
			public static Force<T, C> FromPoundsForce(Number<T, C> poundsforce)
			{
				Number<T,C> value = (Number<T,C>) poundsforce;
				return new Force<T, C>(new Number<T,C>(value*4.4482216152605095551842641431421));
			}
#endif

			/// <summary>
			///     Get Force from TonnesForce.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Force<T, C> FromTonnesForce(Number<T, C> tonnesforce)
			{
				Number<T,C> value = (Number<T,C>) tonnesforce;
				return new Force<T, C>(value*9.80665002864*1000);
			}
#else
			public static Force<T, C> FromTonnesForce(Number<T, C> tonnesforce)
			{
				Number<T,C> value = (Number<T,C>) tonnesforce;
				return new Force<T, C>(new Number<T,C>(value*9.80665002864*1000));
			}
#endif



			/// <summary>
			///     Dynamically convert from value and unit enum <see cref="ForceUnit" /> to <see cref="Force" />.
			/// </summary>
			/// <param name="value">Value to convert from.</param>
			/// <param name="fromUnit">Unit to convert from.</param>
			/// <returns>Force unit value.</returns>
#if WINDOWS_UWP
			// Fix name conflict with parameter "value"
			[return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
			public static Force<T, C> From(double value, ForceUnit fromUnit)
#else
			public static Force<T, C> From(Number<T, C> value, ForceUnit fromUnit)
#endif
			{
				switch (fromUnit)
				{
					case ForceUnit.Decanewton:
						return FromDecanewtons(value);
					case ForceUnit.Dyn:
						return FromDyne(value);
					case ForceUnit.KilogramForce:
						return FromKilogramsForce(value);
					case ForceUnit.Kilonewton:
						return FromKilonewtons(value);
					case ForceUnit.KiloPond:
						return FromKiloPonds(value);
					case ForceUnit.Meganewton:
						return FromMeganewtons(value);
					case ForceUnit.Newton:
						return FromNewtons(value);
					case ForceUnit.Poundal:
						return FromPoundals(value);
					case ForceUnit.PoundForce:
						return FromPoundsForce(value);
					case ForceUnit.TonneForce:
						return FromTonnesForce(value);

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
			public static string GetAbbreviation(ForceUnit unit)
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
			public static string GetAbbreviation(ForceUnit unit, [CanBeNull] Culture culture)
			{
				return UnitSystem.GetCached(culture).GetDefaultAbbreviation(unit);
			}

			#endregion

			#region Arithmetic Operators

			// Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
			public static Force<T, C> operator -(Force<T, C> right)
			{
				return new Force<T, C>(-right._newtons);
			}

			public static Force<T, C> operator +(Force<T, C> left, Force<T, C> right)
			{
				return new Force<T, C>(left._newtons + right._newtons);
			}

			public static Force<T, C> operator -(Force<T, C> left, Force<T, C> right)
			{
				return new Force<T, C>(left._newtons - right._newtons);
			}

			public static Force<T, C> operator *(Number<T, C> left, Force<T, C> right)
			{
				return new Force<T, C>(left*right._newtons);
			}

			public static Force<T, C> operator *(Force<T, C> left, double right)
			{
				return new Force<T, C>(left._newtons*right);
			}

			public static Force<T, C> operator /(Force<T, C> left, double right)
			{
				return new Force<T, C>(left._newtons/right);
			}

			public static double operator /(Force<T, C> left, Force<T, C> right)
			{
				return Convert.ToDouble(left._newtons/right._newtons);
			}
#endif

			#endregion

			#region Equality / IComparable

			public int CompareTo(object obj)
			{
				if (obj == null) throw new ArgumentNullException("obj");
				if (!(obj is Force<T, C>)) throw new ArgumentException("Expected type Force.", "obj");
				return CompareTo((Force<T, C>) obj);
			}

			// Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
			internal
#else
			public
#endif
			int CompareTo(Force<T, C> other)
			{
				return _newtons.CompareTo(other._newtons);
			}

			// Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
			public static bool operator <=(Force<T, C> left, Force<T, C> right)
			{
				return left._newtons <= right._newtons;
			}

			public static bool operator >=(Force<T, C> left, Force<T, C> right)
			{
				return left._newtons >= right._newtons;
			}

			public static bool operator <(Force<T, C> left, Force<T, C> right)
			{
				return left._newtons < right._newtons;
			}

			public static bool operator >(Force<T, C> left, Force<T, C> right)
			{
				return left._newtons > right._newtons;
			}

			[Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(Force<T, C> left, Force<T, C> right)
			{
				// ReSharper disable once CompareOfFloatsByEqualityOperator
				return left._newtons == right._newtons;
			}

			[Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(Force<T, C> left, Force<T, C> right)
			{
				// ReSharper disable once CompareOfFloatsByEqualityOperator
				return left._newtons != right._newtons;
			}
#endif

			[Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public override bool Equals(object obj)
			{
				if (obj == null || GetType() != obj.GetType())
				{
					return false;
				}

				return _newtons.Equals(((Force<T, C>) obj)._newtons);
			}

			/// <summary>
			///     Compare equality to another Force by specifying a max allowed difference.
			///     Note that it is advised against specifying zero difference, due to the nature
			///     of floating point operations and using System.Double internally.
			/// </summary>
			/// <param name="other">Other quantity to compare to.</param>
			/// <param name="maxError">Max error allowed.</param>
			/// <returns>True if the difference between the two values is not greater than the specified max.</returns>
			public bool Equals(Force<T, C> other, Force<T, C> maxError)
			{
				return Math.Abs((decimal)_newtons - (decimal)other._newtons) <= maxError._newtons;
			}

			public override int GetHashCode()
			{
				return _newtons.GetHashCode();
			}

			#endregion

			#region Conversion

			/// <summary>
			///     Convert to the unit representation <paramref name="unit" />.
			/// </summary>
			/// <returns>Value in new unit if successful, exception otherwise.</returns>
			/// <exception cref="NotImplementedException">If conversion was not successful.</exception>
			public Number<T, C> As(ForceUnit unit)
			{
				switch (unit)
				{
					case ForceUnit.Decanewton:
						return Decanewtons;
					case ForceUnit.Dyn:
						return Dyne;
					case ForceUnit.KilogramForce:
						return KilogramsForce;
					case ForceUnit.Kilonewton:
						return Kilonewtons;
					case ForceUnit.KiloPond:
						return KiloPonds;
					case ForceUnit.Meganewton:
						return Meganewtons;
					case ForceUnit.Newton:
						return Newtons;
					case ForceUnit.Poundal:
						return Poundals;
					case ForceUnit.PoundForce:
						return PoundsForce;
					case ForceUnit.TonneForce:
						return TonnesForce;

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
			public static Force<T, C> Parse(string str)
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
			public static Force<T, C> Parse(string str, [CanBeNull] Culture culture)
			{
				if (str == null) throw new ArgumentNullException("str");

			// Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
				IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
				IFormatProvider formatProvider = culture;
#endif
					return QuantityParser.Parse<Force<T, C>, ForceUnit>(str, formatProvider,
					delegate(string value, string unit, IFormatProvider formatProvider2)
					{
						double parsedValue = double.Parse(value, formatProvider2);
						ForceUnit parsedUnit = ParseUnit(unit, formatProvider2);
						return From(new C().ConvertToNumber(parsedValue), parsedUnit);
					}, (x, y) => FromNewtons((Number<T, C>)x.Newtons + y.Newtons));
			}

			/// <summary>
			///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
			/// </summary>
			/// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
			/// <param name="result">Resulting unit quantity if successful.</param>
			/// <example>
			///     Length.Parse("5.5 m", new CultureInfo("en-US"));
			/// </example>
			public static bool TryParse([CanBeNull] string str, out Force<T, C> result)
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
			public static bool TryParse([CanBeNull] string str, [CanBeNull] Culture culture, out Force<T, C> result)
			{
				try
				{
					result = Parse(str, culture);
					return true;
				}
				catch
				{
					result = default(Force<T, C>);
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
			public static ForceUnit ParseUnit(string str)
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
			public static ForceUnit ParseUnit(string str, [CanBeNull] string cultureName)
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
			static ForceUnit ParseUnit(string str, IFormatProvider formatProvider = null)
			{
				if (str == null) throw new ArgumentNullException("str");

				var unitSystem = UnitSystem.GetCached(formatProvider);
				var unit = unitSystem.Parse<ForceUnit>(str.Trim());

				if (unit == ForceUnit.Undefined)
				{
					var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized ForceUnit.");
					newEx.Data["input"] = str;
					newEx.Data["formatprovider"] = formatProvider?.ToString() ?? "(null)";
					throw newEx;
				}

				return unit;
			}

			#endregion

			/// <summary>
			///     Set the default unit used by ToString(). Default is Newton
			/// </summary>
			public static ForceUnit ToStringDefaultUnit { get; set; } = ForceUnit.Newton;

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
			public string ToString(ForceUnit unit)
			{
				return ToString(unit, null, 2);
			}

			/// <summary>
			///     Get string representation of value and unit. Using two significant digits after radix.
			/// </summary>
			/// <param name="unit">Unit representation to use.</param>
			/// <param name="culture">Culture to use for localization and number formatting.</param>
			/// <returns>String representation.</returns>
			public string ToString(ForceUnit unit, [CanBeNull] Culture culture)
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
			public string ToString(ForceUnit unit, [CanBeNull] Culture culture, int significantDigitsAfterRadix)
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
			public string ToString(ForceUnit unit, [CanBeNull] Culture culture, [NotNull] string format,
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
			/// Represents the largest possible value of Force
			/// </summary>
			public static Number<T, C> MaxValue
			{
				get
				{
					return Number<T, C>.MaxValue;
				}
			}

			/// <summary>
			/// Represents the smallest possible value of Force
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
