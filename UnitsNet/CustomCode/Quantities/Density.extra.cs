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

using UnitsNet.Generic;
using UnitsNet.InternalHelpers.Calculators;

namespace UnitsNet.Generic
{
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class Density
#else
    public partial class Density<T, C>
            where T : struct
            where C : InternalHelpers.Calculators.INumberCalculator<T>, new()
#endif
    {
        /// <summary>
        ///     Get <see cref="Density" /> from <see cref="Molarity" />.
        /// </summary>
        /// <param name="molarity"></param>
        /// <param name="molecularWeight"></param>
        public static Density<T, C> FromMolarity(Molarity<T, C> molarity, Mass<T, C> molecularWeight)
        {
            return new Density<T, C>(molarity.MolesPerCubicMeter * molecularWeight.Kilograms);
        }

        public static Molarity<T, C> ToMolarity(Density<T, C> density, Mass<T, C> molecularWeight)
        {
            return Molarity<T, C>.FromMolesPerCubicMeter(density.KilogramsPerCubicMeter / molecularWeight.Kilograms);
        }

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static Mass<T, C> operator *(Density<T, C> density, Volume<T, C> volume)
        {
            return Mass<T, C>.FromKilograms(density.KilogramsPerCubicMeter * volume.CubicMeters);
        }

        public static Mass<T, C> operator *(Volume<T, C> volume, Density<T, C> density)
        {
            return Mass<T, C>.FromKilograms(density.KilogramsPerCubicMeter * volume.CubicMeters);
        }

        public static DynamicViscosity<T, C> operator *(Density<T, C> density, KinematicViscosity<T, C> kinematicViscosity)
        {
            return DynamicViscosity<T, C>.FromNewtonSecondsPerMeterSquared(kinematicViscosity.SquareMetersPerSecond * density.KilogramsPerCubicMeter);
        }
#endif
    }
}