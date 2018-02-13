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
    ///     In physics and engineering, in particular fluid dynamics and hydrometry, the volumetric flow rate, (also known as volume flow rate, rate of fluid flow or volume velocity) is the volume of fluid which passes through a given surface per unit time. The SI unit is m³/s (cubic meters per second). In US Customary Units and British Imperial Units, volumetric flow rate is often expressed as ft³/s (cubic feet per second). It is usually represented by the symbol Q.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
	public partial class Flow : UnitsNet.Generic.Flow<double, UnitsNet.InternalHelpers.Calculators.DoubleCalculator> { }

	namespace Generic
	{
#if WINDOWS_UWP
		public sealed partial class Flow
#else
		public partial class Flow <T, C> : IComparable, IComparable<Flow<T, C>>
			where T : struct
			where C : InternalHelpers.Calculators.INumberCalculator<T>, new()
#endif
		{
			/// <summary>
			///     Base unit of Flow.
			/// </summary>
			private readonly Number<T, C> _cubicMetersPerSecond;

			public Flow() : this(new Number<T,C>())
			{
			}

			public Flow(T cubicmeterspersecond)
			{
				_cubicMetersPerSecond = (cubicmeterspersecond);
			}

			public Flow(Number<T, C> cubicmeterspersecond)
			{
				_cubicMetersPerSecond = (cubicmeterspersecond);
			}

			#region Properties

			/// <summary>
			///     The <see cref="QuantityType" /> of this quantity.
			/// </summary>
			public static QuantityType QuantityType => QuantityType.Flow;

			/// <summary>
			///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
			/// </summary>
			public static FlowUnit BaseUnit
			{
				get { return FlowUnit.CubicMeterPerSecond; }
			}

			/// <summary>
			///     All units of measurement for the Flow quantity.
			/// </summary>
			public static FlowUnit[] Units { get; } = Enum.GetValues(typeof(FlowUnit)).Cast<FlowUnit>().ToArray();

			/// <summary>
			///     Get Flow in CentilitersPerMinute.
			/// </summary>
			public Number<T, C> CentilitersPerMinute
			{
				get { return (_cubicMetersPerSecond*60000.00000) / 1e-2d; }
			}

			/// <summary>
			///     Get Flow in CubicDecimetersPerMinute.
			/// </summary>
			public Number<T, C> CubicDecimetersPerMinute
			{
				get { return _cubicMetersPerSecond*60000.00000; }
			}

			/// <summary>
			///     Get Flow in CubicFeetPerHour.
			/// </summary>
			public Number<T, C> CubicFeetPerHour
			{
				get { return _cubicMetersPerSecond/7.8657907199999087346816086183876e-6; }
			}

			/// <summary>
			///     Get Flow in CubicFeetPerSecond.
			/// </summary>
			public Number<T, C> CubicFeetPerSecond
			{
				get { return _cubicMetersPerSecond*35.314666721; }
			}

			/// <summary>
			///     Get Flow in CubicMetersPerHour.
			/// </summary>
			public Number<T, C> CubicMetersPerHour
			{
				get { return _cubicMetersPerSecond*3600; }
			}

			/// <summary>
			///     Get Flow in CubicMetersPerSecond.
			/// </summary>
			public Number<T, C> CubicMetersPerSecond
			{
				get { return _cubicMetersPerSecond; }
			}

			/// <summary>
			///     Get Flow in DecilitersPerMinute.
			/// </summary>
			public Number<T, C> DecilitersPerMinute
			{
				get { return (_cubicMetersPerSecond*60000.00000) / 1e-1d; }
			}

			/// <summary>
			///     Get Flow in KilolitersPerMinute.
			/// </summary>
			public Number<T, C> KilolitersPerMinute
			{
				get { return (_cubicMetersPerSecond*60000.00000) / 1e3d; }
			}

			/// <summary>
			///     Get Flow in LitersPerHour.
			/// </summary>
			public Number<T, C> LitersPerHour
			{
				get { return _cubicMetersPerSecond*3600000.000; }
			}

			/// <summary>
			///     Get Flow in LitersPerMinute.
			/// </summary>
			public Number<T, C> LitersPerMinute
			{
				get { return _cubicMetersPerSecond*60000.00000; }
			}

			/// <summary>
			///     Get Flow in LitersPerSecond.
			/// </summary>
			public Number<T, C> LitersPerSecond
			{
				get { return _cubicMetersPerSecond*1000; }
			}

			/// <summary>
			///     Get Flow in MicrolitersPerMinute.
			/// </summary>
			public Number<T, C> MicrolitersPerMinute
			{
				get { return (_cubicMetersPerSecond*60000.00000) / 1e-6d; }
			}

			/// <summary>
			///     Get Flow in MillilitersPerMinute.
			/// </summary>
			public Number<T, C> MillilitersPerMinute
			{
				get { return (_cubicMetersPerSecond*60000.00000) / 1e-3d; }
			}

			/// <summary>
			///     Get Flow in MillionUsGallonsPerDay.
			/// </summary>
			public Number<T, C> MillionUsGallonsPerDay
			{
				get { return _cubicMetersPerSecond*22.824465227; }
			}

			/// <summary>
			///     Get Flow in NanolitersPerMinute.
			/// </summary>
			public Number<T, C> NanolitersPerMinute
			{
				get { return (_cubicMetersPerSecond*60000.00000) / 1e-9d; }
			}

			/// <summary>
			///     Get Flow in OilBarrelsPerDay.
			/// </summary>
			public Number<T, C> OilBarrelsPerDay
			{
				get { return _cubicMetersPerSecond/1.8401307283333333333333333333333e-6; }
			}

			/// <summary>
			///     Get Flow in UsGallonsPerMinute.
			/// </summary>
			public Number<T, C> UsGallonsPerMinute
			{
				get { return _cubicMetersPerSecond*15850.323141489; }
			}

			#endregion

			#region Static

			public static Flow<T, C> Zero
			{
				get { return new Flow<T, C>(); }
			}

			/// <summary>
			///     Get Flow from CentilitersPerMinute.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Flow<T, C> FromCentilitersPerMinute(Number<T, C> centilitersperminute)
			{
				Number<T,C> value = (Number<T,C>) centilitersperminute;
				return new Flow<T, C>((value/60000.00000) * 1e-2d);
			}
#else
			public static Flow<T, C> FromCentilitersPerMinute(Number<T, C> centilitersperminute)
			{
				Number<T,C> value = (Number<T,C>) centilitersperminute;
				return new Flow<T, C>(new Number<T,C>((value/60000.00000) * 1e-2d));
			}
#endif

			/// <summary>
			///     Get Flow from CubicDecimetersPerMinute.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Flow<T, C> FromCubicDecimetersPerMinute(Number<T, C> cubicdecimetersperminute)
			{
				Number<T,C> value = (Number<T,C>) cubicdecimetersperminute;
				return new Flow<T, C>(value/60000.00000);
			}
#else
			public static Flow<T, C> FromCubicDecimetersPerMinute(Number<T, C> cubicdecimetersperminute)
			{
				Number<T,C> value = (Number<T,C>) cubicdecimetersperminute;
				return new Flow<T, C>(new Number<T,C>(value/60000.00000));
			}
#endif

			/// <summary>
			///     Get Flow from CubicFeetPerHour.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Flow<T, C> FromCubicFeetPerHour(Number<T, C> cubicfeetperhour)
			{
				Number<T,C> value = (Number<T,C>) cubicfeetperhour;
				return new Flow<T, C>(value*7.8657907199999087346816086183876e-6);
			}
#else
			public static Flow<T, C> FromCubicFeetPerHour(Number<T, C> cubicfeetperhour)
			{
				Number<T,C> value = (Number<T,C>) cubicfeetperhour;
				return new Flow<T, C>(new Number<T,C>(value*7.8657907199999087346816086183876e-6));
			}
#endif

			/// <summary>
			///     Get Flow from CubicFeetPerSecond.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Flow<T, C> FromCubicFeetPerSecond(Number<T, C> cubicfeetpersecond)
			{
				Number<T,C> value = (Number<T,C>) cubicfeetpersecond;
				return new Flow<T, C>(value/35.314666721);
			}
#else
			public static Flow<T, C> FromCubicFeetPerSecond(Number<T, C> cubicfeetpersecond)
			{
				Number<T,C> value = (Number<T,C>) cubicfeetpersecond;
				return new Flow<T, C>(new Number<T,C>(value/35.314666721));
			}
#endif

			/// <summary>
			///     Get Flow from CubicMetersPerHour.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Flow<T, C> FromCubicMetersPerHour(Number<T, C> cubicmetersperhour)
			{
				Number<T,C> value = (Number<T,C>) cubicmetersperhour;
				return new Flow<T, C>(value/3600);
			}
#else
			public static Flow<T, C> FromCubicMetersPerHour(Number<T, C> cubicmetersperhour)
			{
				Number<T,C> value = (Number<T,C>) cubicmetersperhour;
				return new Flow<T, C>(new Number<T,C>(value/3600));
			}
#endif

			/// <summary>
			///     Get Flow from CubicMetersPerSecond.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Flow<T, C> FromCubicMetersPerSecond(Number<T, C> cubicmeterspersecond)
			{
				Number<T,C> value = (Number<T,C>) cubicmeterspersecond;
				return new Flow<T, C>(value);
			}
#else
			public static Flow<T, C> FromCubicMetersPerSecond(Number<T, C> cubicmeterspersecond)
			{
				Number<T,C> value = (Number<T,C>) cubicmeterspersecond;
				return new Flow<T, C>(new Number<T,C>(value));
			}
#endif

			/// <summary>
			///     Get Flow from DecilitersPerMinute.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Flow<T, C> FromDecilitersPerMinute(Number<T, C> decilitersperminute)
			{
				Number<T,C> value = (Number<T,C>) decilitersperminute;
				return new Flow<T, C>((value/60000.00000) * 1e-1d);
			}
#else
			public static Flow<T, C> FromDecilitersPerMinute(Number<T, C> decilitersperminute)
			{
				Number<T,C> value = (Number<T,C>) decilitersperminute;
				return new Flow<T, C>(new Number<T,C>((value/60000.00000) * 1e-1d));
			}
#endif

			/// <summary>
			///     Get Flow from KilolitersPerMinute.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Flow<T, C> FromKilolitersPerMinute(Number<T, C> kilolitersperminute)
			{
				Number<T,C> value = (Number<T,C>) kilolitersperminute;
				return new Flow<T, C>((value/60000.00000) * 1e3d);
			}
#else
			public static Flow<T, C> FromKilolitersPerMinute(Number<T, C> kilolitersperminute)
			{
				Number<T,C> value = (Number<T,C>) kilolitersperminute;
				return new Flow<T, C>(new Number<T,C>((value/60000.00000) * 1e3d));
			}
#endif

			/// <summary>
			///     Get Flow from LitersPerHour.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Flow<T, C> FromLitersPerHour(Number<T, C> litersperhour)
			{
				Number<T,C> value = (Number<T,C>) litersperhour;
				return new Flow<T, C>(value/3600000.000);
			}
#else
			public static Flow<T, C> FromLitersPerHour(Number<T, C> litersperhour)
			{
				Number<T,C> value = (Number<T,C>) litersperhour;
				return new Flow<T, C>(new Number<T,C>(value/3600000.000));
			}
#endif

			/// <summary>
			///     Get Flow from LitersPerMinute.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Flow<T, C> FromLitersPerMinute(Number<T, C> litersperminute)
			{
				Number<T,C> value = (Number<T,C>) litersperminute;
				return new Flow<T, C>(value/60000.00000);
			}
#else
			public static Flow<T, C> FromLitersPerMinute(Number<T, C> litersperminute)
			{
				Number<T,C> value = (Number<T,C>) litersperminute;
				return new Flow<T, C>(new Number<T,C>(value/60000.00000));
			}
#endif

			/// <summary>
			///     Get Flow from LitersPerSecond.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Flow<T, C> FromLitersPerSecond(Number<T, C> literspersecond)
			{
				Number<T,C> value = (Number<T,C>) literspersecond;
				return new Flow<T, C>(value/1000);
			}
#else
			public static Flow<T, C> FromLitersPerSecond(Number<T, C> literspersecond)
			{
				Number<T,C> value = (Number<T,C>) literspersecond;
				return new Flow<T, C>(new Number<T,C>(value/1000));
			}
#endif

			/// <summary>
			///     Get Flow from MicrolitersPerMinute.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Flow<T, C> FromMicrolitersPerMinute(Number<T, C> microlitersperminute)
			{
				Number<T,C> value = (Number<T,C>) microlitersperminute;
				return new Flow<T, C>((value/60000.00000) * 1e-6d);
			}
#else
			public static Flow<T, C> FromMicrolitersPerMinute(Number<T, C> microlitersperminute)
			{
				Number<T,C> value = (Number<T,C>) microlitersperminute;
				return new Flow<T, C>(new Number<T,C>((value/60000.00000) * 1e-6d));
			}
#endif

			/// <summary>
			///     Get Flow from MillilitersPerMinute.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Flow<T, C> FromMillilitersPerMinute(Number<T, C> millilitersperminute)
			{
				Number<T,C> value = (Number<T,C>) millilitersperminute;
				return new Flow<T, C>((value/60000.00000) * 1e-3d);
			}
#else
			public static Flow<T, C> FromMillilitersPerMinute(Number<T, C> millilitersperminute)
			{
				Number<T,C> value = (Number<T,C>) millilitersperminute;
				return new Flow<T, C>(new Number<T,C>((value/60000.00000) * 1e-3d));
			}
#endif

			/// <summary>
			///     Get Flow from MillionUsGallonsPerDay.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Flow<T, C> FromMillionUsGallonsPerDay(Number<T, C> millionusgallonsperday)
			{
				Number<T,C> value = (Number<T,C>) millionusgallonsperday;
				return new Flow<T, C>(value/22.824465227);
			}
#else
			public static Flow<T, C> FromMillionUsGallonsPerDay(Number<T, C> millionusgallonsperday)
			{
				Number<T,C> value = (Number<T,C>) millionusgallonsperday;
				return new Flow<T, C>(new Number<T,C>(value/22.824465227));
			}
#endif

			/// <summary>
			///     Get Flow from NanolitersPerMinute.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Flow<T, C> FromNanolitersPerMinute(Number<T, C> nanolitersperminute)
			{
				Number<T,C> value = (Number<T,C>) nanolitersperminute;
				return new Flow<T, C>((value/60000.00000) * 1e-9d);
			}
#else
			public static Flow<T, C> FromNanolitersPerMinute(Number<T, C> nanolitersperminute)
			{
				Number<T,C> value = (Number<T,C>) nanolitersperminute;
				return new Flow<T, C>(new Number<T,C>((value/60000.00000) * 1e-9d));
			}
#endif

			/// <summary>
			///     Get Flow from OilBarrelsPerDay.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Flow<T, C> FromOilBarrelsPerDay(Number<T, C> oilbarrelsperday)
			{
				Number<T,C> value = (Number<T,C>) oilbarrelsperday;
				return new Flow<T, C>(value*1.8401307283333333333333333333333e-6);
			}
#else
			public static Flow<T, C> FromOilBarrelsPerDay(Number<T, C> oilbarrelsperday)
			{
				Number<T,C> value = (Number<T,C>) oilbarrelsperday;
				return new Flow<T, C>(new Number<T,C>(value*1.8401307283333333333333333333333e-6));
			}
#endif

			/// <summary>
			///     Get Flow from UsGallonsPerMinute.
			/// </summary>
#if WINDOWS_UWP
			[Windows.Foundation.Metadata.DefaultOverload]
			public static Flow<T, C> FromUsGallonsPerMinute(Number<T, C> usgallonsperminute)
			{
				Number<T,C> value = (Number<T,C>) usgallonsperminute;
				return new Flow<T, C>(value/15850.323141489);
			}
#else
			public static Flow<T, C> FromUsGallonsPerMinute(Number<T, C> usgallonsperminute)
			{
				Number<T,C> value = (Number<T,C>) usgallonsperminute;
				return new Flow<T, C>(new Number<T,C>(value/15850.323141489));
			}
#endif



			/// <summary>
			///     Dynamically convert from value and unit enum <see cref="FlowUnit" /> to <see cref="Flow" />.
			/// </summary>
			/// <param name="value">Value to convert from.</param>
			/// <param name="fromUnit">Unit to convert from.</param>
			/// <returns>Flow unit value.</returns>
#if WINDOWS_UWP
			// Fix name conflict with parameter "value"
			[return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
			public static Flow<T, C> From(double value, FlowUnit fromUnit)
#else
			public static Flow<T, C> From(Number<T, C> value, FlowUnit fromUnit)
#endif
			{
				switch (fromUnit)
				{
					case FlowUnit.CentilitersPerMinute:
						return FromCentilitersPerMinute(value);
					case FlowUnit.CubicDecimeterPerMinute:
						return FromCubicDecimetersPerMinute(value);
					case FlowUnit.CubicFootPerHour:
						return FromCubicFeetPerHour(value);
					case FlowUnit.CubicFootPerSecond:
						return FromCubicFeetPerSecond(value);
					case FlowUnit.CubicMeterPerHour:
						return FromCubicMetersPerHour(value);
					case FlowUnit.CubicMeterPerSecond:
						return FromCubicMetersPerSecond(value);
					case FlowUnit.DecilitersPerMinute:
						return FromDecilitersPerMinute(value);
					case FlowUnit.KilolitersPerMinute:
						return FromKilolitersPerMinute(value);
					case FlowUnit.LitersPerHour:
						return FromLitersPerHour(value);
					case FlowUnit.LitersPerMinute:
						return FromLitersPerMinute(value);
					case FlowUnit.LitersPerSecond:
						return FromLitersPerSecond(value);
					case FlowUnit.MicrolitersPerMinute:
						return FromMicrolitersPerMinute(value);
					case FlowUnit.MillilitersPerMinute:
						return FromMillilitersPerMinute(value);
					case FlowUnit.MillionUsGallonsPerDay:
						return FromMillionUsGallonsPerDay(value);
					case FlowUnit.NanolitersPerMinute:
						return FromNanolitersPerMinute(value);
					case FlowUnit.OilBarrelsPerDay:
						return FromOilBarrelsPerDay(value);
					case FlowUnit.UsGallonsPerMinute:
						return FromUsGallonsPerMinute(value);

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
			public static string GetAbbreviation(FlowUnit unit)
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
			public static string GetAbbreviation(FlowUnit unit, [CanBeNull] Culture culture)
			{
				return UnitSystem.GetCached(culture).GetDefaultAbbreviation(unit);
			}

			#endregion

			#region Arithmetic Operators

			// Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
			public static Flow<T, C> operator -(Flow<T, C> right)
			{
				return new Flow<T, C>(-right._cubicMetersPerSecond);
			}

			public static Flow<T, C> operator +(Flow<T, C> left, Flow<T, C> right)
			{
				return new Flow<T, C>(left._cubicMetersPerSecond + right._cubicMetersPerSecond);
			}

			public static Flow<T, C> operator -(Flow<T, C> left, Flow<T, C> right)
			{
				return new Flow<T, C>(left._cubicMetersPerSecond - right._cubicMetersPerSecond);
			}

			public static Flow<T, C> operator *(Number<T, C> left, Flow<T, C> right)
			{
				return new Flow<T, C>(left*right._cubicMetersPerSecond);
			}

			public static Flow<T, C> operator *(Flow<T, C> left, double right)
			{
				return new Flow<T, C>(left._cubicMetersPerSecond*right);
			}

			public static Flow<T, C> operator /(Flow<T, C> left, double right)
			{
				return new Flow<T, C>(left._cubicMetersPerSecond/right);
			}

			public static double operator /(Flow<T, C> left, Flow<T, C> right)
			{
				return Convert.ToDouble(left._cubicMetersPerSecond/right._cubicMetersPerSecond);
			}
#endif

			#endregion

			#region Equality / IComparable

			public int CompareTo(object obj)
			{
				if (obj == null) throw new ArgumentNullException("obj");
				if (!(obj is Flow<T, C>)) throw new ArgumentException("Expected type Flow.", "obj");
				return CompareTo((Flow<T, C>) obj);
			}

			// Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
			internal
#else
			public
#endif
			int CompareTo(Flow<T, C> other)
			{
				return _cubicMetersPerSecond.CompareTo(other._cubicMetersPerSecond);
			}

			// Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
			public static bool operator <=(Flow<T, C> left, Flow<T, C> right)
			{
				return left._cubicMetersPerSecond <= right._cubicMetersPerSecond;
			}

			public static bool operator >=(Flow<T, C> left, Flow<T, C> right)
			{
				return left._cubicMetersPerSecond >= right._cubicMetersPerSecond;
			}

			public static bool operator <(Flow<T, C> left, Flow<T, C> right)
			{
				return left._cubicMetersPerSecond < right._cubicMetersPerSecond;
			}

			public static bool operator >(Flow<T, C> left, Flow<T, C> right)
			{
				return left._cubicMetersPerSecond > right._cubicMetersPerSecond;
			}

			[Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(Flow<T, C> left, Flow<T, C> right)
			{
				// ReSharper disable once CompareOfFloatsByEqualityOperator
				return left._cubicMetersPerSecond == right._cubicMetersPerSecond;
			}

			[Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(Flow<T, C> left, Flow<T, C> right)
			{
				// ReSharper disable once CompareOfFloatsByEqualityOperator
				return left._cubicMetersPerSecond != right._cubicMetersPerSecond;
			}
#endif

			[Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public override bool Equals(object obj)
			{
				if (obj == null || GetType() != obj.GetType())
				{
					return false;
				}

				return _cubicMetersPerSecond.Equals(((Flow<T, C>) obj)._cubicMetersPerSecond);
			}

			/// <summary>
			///     Compare equality to another Flow by specifying a max allowed difference.
			///     Note that it is advised against specifying zero difference, due to the nature
			///     of floating point operations and using System.Double internally.
			/// </summary>
			/// <param name="other">Other quantity to compare to.</param>
			/// <param name="maxError">Max error allowed.</param>
			/// <returns>True if the difference between the two values is not greater than the specified max.</returns>
			public bool Equals(Flow<T, C> other, Flow<T, C> maxError)
			{
				return Math.Abs((decimal)_cubicMetersPerSecond - (decimal)other._cubicMetersPerSecond) <= maxError._cubicMetersPerSecond;
			}

			public override int GetHashCode()
			{
				return _cubicMetersPerSecond.GetHashCode();
			}

			#endregion

			#region Conversion

			/// <summary>
			///     Convert to the unit representation <paramref name="unit" />.
			/// </summary>
			/// <returns>Value in new unit if successful, exception otherwise.</returns>
			/// <exception cref="NotImplementedException">If conversion was not successful.</exception>
			public Number<T, C> As(FlowUnit unit)
			{
				switch (unit)
				{
					case FlowUnit.CentilitersPerMinute:
						return CentilitersPerMinute;
					case FlowUnit.CubicDecimeterPerMinute:
						return CubicDecimetersPerMinute;
					case FlowUnit.CubicFootPerHour:
						return CubicFeetPerHour;
					case FlowUnit.CubicFootPerSecond:
						return CubicFeetPerSecond;
					case FlowUnit.CubicMeterPerHour:
						return CubicMetersPerHour;
					case FlowUnit.CubicMeterPerSecond:
						return CubicMetersPerSecond;
					case FlowUnit.DecilitersPerMinute:
						return DecilitersPerMinute;
					case FlowUnit.KilolitersPerMinute:
						return KilolitersPerMinute;
					case FlowUnit.LitersPerHour:
						return LitersPerHour;
					case FlowUnit.LitersPerMinute:
						return LitersPerMinute;
					case FlowUnit.LitersPerSecond:
						return LitersPerSecond;
					case FlowUnit.MicrolitersPerMinute:
						return MicrolitersPerMinute;
					case FlowUnit.MillilitersPerMinute:
						return MillilitersPerMinute;
					case FlowUnit.MillionUsGallonsPerDay:
						return MillionUsGallonsPerDay;
					case FlowUnit.NanolitersPerMinute:
						return NanolitersPerMinute;
					case FlowUnit.OilBarrelsPerDay:
						return OilBarrelsPerDay;
					case FlowUnit.UsGallonsPerMinute:
						return UsGallonsPerMinute;

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
			public static Flow<T, C> Parse(string str)
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
			public static Flow<T, C> Parse(string str, [CanBeNull] Culture culture)
			{
				if (str == null) throw new ArgumentNullException("str");

			// Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
				IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
				IFormatProvider formatProvider = culture;
#endif
					return QuantityParser.Parse<Flow<T, C>, FlowUnit>(str, formatProvider,
					delegate(string value, string unit, IFormatProvider formatProvider2)
					{
						double parsedValue = double.Parse(value, formatProvider2);
						FlowUnit parsedUnit = ParseUnit(unit, formatProvider2);
						return From(new C().ConvertToNumber(parsedValue), parsedUnit);
					}, (x, y) => FromCubicMetersPerSecond((Number<T, C>)x.CubicMetersPerSecond + y.CubicMetersPerSecond));
			}

			/// <summary>
			///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
			/// </summary>
			/// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
			/// <param name="result">Resulting unit quantity if successful.</param>
			/// <example>
			///     Length.Parse("5.5 m", new CultureInfo("en-US"));
			/// </example>
			public static bool TryParse([CanBeNull] string str, out Flow<T, C> result)
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
			public static bool TryParse([CanBeNull] string str, [CanBeNull] Culture culture, out Flow<T, C> result)
			{
				try
				{
					result = Parse(str, culture);
					return true;
				}
				catch
				{
					result = default(Flow<T, C>);
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
			public static FlowUnit ParseUnit(string str)
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
			public static FlowUnit ParseUnit(string str, [CanBeNull] string cultureName)
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
			static FlowUnit ParseUnit(string str, IFormatProvider formatProvider = null)
			{
				if (str == null) throw new ArgumentNullException("str");

				var unitSystem = UnitSystem.GetCached(formatProvider);
				var unit = unitSystem.Parse<FlowUnit>(str.Trim());

				if (unit == FlowUnit.Undefined)
				{
					var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized FlowUnit.");
					newEx.Data["input"] = str;
					newEx.Data["formatprovider"] = formatProvider?.ToString() ?? "(null)";
					throw newEx;
				}

				return unit;
			}

			#endregion

			/// <summary>
			///     Set the default unit used by ToString(). Default is CubicMeterPerSecond
			/// </summary>
			public static FlowUnit ToStringDefaultUnit { get; set; } = FlowUnit.CubicMeterPerSecond;

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
			public string ToString(FlowUnit unit)
			{
				return ToString(unit, null, 2);
			}

			/// <summary>
			///     Get string representation of value and unit. Using two significant digits after radix.
			/// </summary>
			/// <param name="unit">Unit representation to use.</param>
			/// <param name="culture">Culture to use for localization and number formatting.</param>
			/// <returns>String representation.</returns>
			public string ToString(FlowUnit unit, [CanBeNull] Culture culture)
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
			public string ToString(FlowUnit unit, [CanBeNull] Culture culture, int significantDigitsAfterRadix)
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
			public string ToString(FlowUnit unit, [CanBeNull] Culture culture, [NotNull] string format,
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
			/// Represents the largest possible value of Flow
			/// </summary>
			public static Number<T, C> MaxValue
			{
				get
				{
					return Number<T, C>.MaxValue;
				}
			}

			/// <summary>
			/// Represents the smallest possible value of Flow
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
