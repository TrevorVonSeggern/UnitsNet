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

namespace UnitsNet.Generic
{
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class Force
#else
    public partial class Force<T, C>
            where T : struct
            where C : InternalHelpers.Calculators.INumberCalculator<T>, new()
#endif
    {
        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static Power<T, C> operator *(Force<T, C> force, Speed<T, C> speed)
        {
            return Power<T, C>.FromWatts(force.Newtons * speed.MetersPerSecond);
        }

        public static Power<T, C> operator *(Speed<T, C> speed, Force<T, C> force)
        {
            return Power<T, C>.FromWatts(force.Newtons * speed.MetersPerSecond);
        }

        public static Acceleration<T, C> operator /(Force<T, C> force, Mass<T, C> mass)
        {
            return Acceleration<T, C>.FromMeterPerSecondSquared(force.Newtons / mass.Kilograms);
        }

        public static Mass<T, C> operator /(Force<T, C> force, Acceleration<T, C> mass)
        {
            return Mass<T, C>.FromKilograms(force.Newtons / mass.MeterPerSecondSquared);
        }

        public static Pressure<T, C> operator /(Force<T, C> force, Area<T, C> area)
        {
            return Pressure<T, C>.FromPascals(force.Newtons / area.SquareMeters);
        }

        public static ForcePerLength<T, C> operator /(Force<T, C> force, Length<T, C> length)
        {
            return ForcePerLength<T, C>.FromNewtonsPerMeter(force.Newtons / length.Meters);
        }
#endif

        // Method overloads with same number of argumnets not supported in Universal Windows Platform (WinRT Components)
#if !WINDOWS_UWP
        public static Force<T, C> FromPressureByArea(Pressure<T, C> p, Length2d<T, C> area)
        {
            var metersSquared = area.Meters.X * area.Meters.Y;
            var newtons = p.Pascals * metersSquared;
            return new Force<T, C>(newtons);
        }

        public static Force<T, C> FromMassByAcceleration(Mass<T, C> mass, double metersPerSecondSquared)
        {
            return new Force<T, C>(mass.Kilograms * metersPerSecondSquared);
        }
#endif

        public static Force<T, C> FromPressureByArea(Pressure<T, C> p, Area<T, C> area)
        {
            var newtons = p.Pascals * area.SquareMeters;
            return new Force<T, C>(newtons);
        }

        public static Force<T, C> FromMassByAcceleration(Mass<T, C> mass, Acceleration<T, C> acceleration)
        {
            return new Force<T, C>(mass.Kilograms * acceleration.MeterPerSecondSquared);
        }
    }
}