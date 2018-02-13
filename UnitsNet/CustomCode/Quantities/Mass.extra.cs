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
using JetBrains.Annotations;
using UnitsNet.InternalHelpers.Calculators;
using UnitsNet.Units;

#if WINDOWS_UWP
using Culture = System.String;
#else
using Culture = System.IFormatProvider;
#endif

namespace UnitsNet.Generic
{
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class Mass
#else
    public partial class Mass<T, C>
            where T : struct
            where C : InternalHelpers.Calculators.INumberCalculator<T>, new()
#endif
    {
        public static Mass<T, C> FromGravitationalForce(Force<T, C> f)
        {
            return new Mass<T, C>(f.KilogramsForce);
        }

        /// <summary>
        ///     StonePounds related code makes it easier to work with Stone/Pound combination, which are customarily used in the UK
        ///     to express body weight. For example, someone weighs 11 stone 4 pounds (about 72 kilograms).
        /// </summary>
        private const double StoneToPounds = 14;

        /// <summary>
        ///     Converts the mass to a customary stone/pounds combination.
        /// </summary>
        public StonePounds StonePounds
        {
            get
            {
                var totalPounds = Pounds;
                var wholeStone = new C().Floor(totalPounds/StoneToPounds);
                var pounds = totalPounds % StoneToPounds;

                return new StonePounds(new C().ConvertToDouble(wholeStone), new C().ConvertToDouble(pounds));
            }
        }

        /// <summary>
        ///     Get Mass from combination of stone and pounds.
        /// </summary>
        public static Mass<T, C> FromStonePounds(double stone, double pounds)
        {
            return FromPounds(StoneToPounds*stone + pounds);
        }

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static MassFlow<T, C> operator /(Mass<T, C> mass, TimeSpan timeSpan)
        {
            return MassFlow<T, C>.FromKilogramsPerSecond(mass.Kilograms/timeSpan.TotalSeconds);
        }

        public static MassFlow<T, C> operator /(Mass<T, C> mass, Duration<T, C> duration)
        {
            return MassFlow<T, C>.FromKilogramsPerSecond(mass.Kilograms/duration.Seconds);
        }

        public static Density<T, C> operator /(Mass<T, C> mass, Volume<T, C> volume)
        {
            return Density<T, C>.FromKilogramsPerCubicMeter(mass.Kilograms/volume.CubicMeters);
        }

        public static Volume<T, C> operator /(Mass<T, C> mass, Density<T, C> density)
        {
            return Volume<T, C>.FromCubicMeters(mass.Kilograms / density.KilogramsPerCubicMeter);
        }

        public static Force<T, C> operator *(Mass<T, C> mass, Acceleration<T, C> acceleration)
        {
            return Force<T, C>.FromNewtons(mass.Kilograms*acceleration.MeterPerSecondSquared);
        }

        public static Force<T, C> operator *(Acceleration<T, C> acceleration, Mass<T, C> mass)
        {
            return Force<T, C>.FromNewtons(mass.Kilograms*acceleration.MeterPerSecondSquared);
        }
#endif
    }

    public sealed class StonePounds
    {
        public StonePounds(double stone, double pounds)
        {
            Stone = stone;
            Pounds = pounds;
        }

        public double Stone { get; }
        public double Pounds { get; }

        public override string ToString()
        {
            return ToString(null);
        }

        public string ToString([CanBeNull] Culture cultureInfo)
        {
            // Note that it isn't customary to use fractions - one wouldn't say "I am 11 stone and 4.5 pounds".
            // So pounds are rounded here.

            UnitSystem unitSystem = UnitSystem.GetCached(cultureInfo);
            string stoneUnit = unitSystem.GetDefaultAbbreviation(MassUnit.Stone);
            string poundUnit = unitSystem.GetDefaultAbbreviation(MassUnit.Pound);

            return string.Format(unitSystem.Culture, "{0:n0} {1} {2:n0} {3}",
                Stone, stoneUnit, Math.Round(Pounds), poundUnit);
        }
    }
}