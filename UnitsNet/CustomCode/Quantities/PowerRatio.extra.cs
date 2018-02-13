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
using UnitsNet.InternalHelpers.Calculators;

namespace UnitsNet.Generic
{
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class PowerRatio<T, C>
#else
    public partial class PowerRatio<T, C>
            where T : struct
            where C : InternalHelpers.Calculators.INumberCalculator<T>, new()
#endif
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PowerRatio" /> struct from the specified power referenced to one watt.
        /// </summary>
        /// <param name="power">The power relative to one watt.</param>

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
            PowerRatio(Power<T, C> power)
            : this()
        {
            if (power.Watts <= 0)
                throw new ArgumentOutOfRangeException(
                    nameof(power), "The base-10 logarithm of a number ≤ 0 is undefined. Power must be greater than 0 W.");

            // P(dBW) = 10*log10(value(W)/reference(W))
            _decibelWatts = new Number<T, C>(new C().Log10(power.Watts)) * 10;
        }

        /// <summary>
        ///     Gets a <see cref="PowerRatio" /> from a <see cref="Power" /> relative to one watt.
        /// </summary>
        /// <param name="power">The power relative to one watt.</param>
        public static PowerRatio<T, C> FromPower(Power<T, C> power)
        {
            return new PowerRatio<T, C>(power);
        }

        /// <summary>
        ///     Gets a <see cref="Power" /> from a <see cref="PowerRatio" /> (which is a power level relative to one watt).
        /// </summary>
        /// <param name="powerRatio">The power level relative to one watt.</param>
        public static Power<T, C> ToPower(PowerRatio<T, C> powerRatio)
        {
            // P(W) = 1W * 10^(P(dBW)/10)
            return Power<T, C>.FromWatts(new C().Power(new C().ConvertToNumber(10), powerRatio._decibelWatts / 10));
        }

        /// <summary>
        ///     Gets a <see cref="AmplitudeRatio" /> from a <see cref="PowerRatio" />.
        /// </summary>
        /// <param name="powerRatio">The power ratio.</param>
        /// <param name="impedance">The input impedance of the load. This is usually 50, 75 or 600 ohms.</param>
        /// <remarks>http://www.maximintegrated.com/en/app-notes/index.mvp/id/808</remarks>
        public static AmplitudeRatio<T, C> ToAmplitudeRatio(PowerRatio<T, C> powerRatio, ElectricResistance<T, C> impedance)
        {
            // E(dBV) = 10*log10(Z(Ω)/1) + P(dBW)
            return AmplitudeRatio<T, C>.FromDecibelVolts(new C().ConvertToNumber(10 * Math.Log10(new C().ConvertToDouble(powerRatio.DecibelWatts) + new C().ConvertToDouble(impedance.Ohms) / 1)));
        }
    }
}