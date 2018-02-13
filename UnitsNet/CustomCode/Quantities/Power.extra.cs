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

#if !WINDOWS_UWP
using System;

#endif

namespace UnitsNet.Generic
{
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class Power
#else
    public partial class Power<T, C>
            where T : struct
            where C : InternalHelpers.Calculators.INumberCalculator<T>, new()
#endif
    {
        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static Energy<T, C> operator *(Power<T, C> power, TimeSpan time)
        {
            return Energy<T, C>.FromJoules(power.Watts * time.TotalSeconds);
        }

        public static Energy<T, C> operator *(TimeSpan time, Power<T, C> power)
        {
            return Energy<T, C>.FromJoules(power.Watts * time.TotalSeconds);
        }

        public static Energy<T, C> operator *(Power<T, C> power, Duration<T, C> duration)
        {
            return Energy<T, C>.FromJoules(power.Watts * duration.Seconds);
        }

        public static Energy<T, C> operator *(Duration<T, C> duration, Power<T, C> power)
        {
            return Energy<T, C>.FromJoules(power.Watts * duration.Seconds);
        }

        public static Force<T, C> operator /(Power<T, C> power, Speed<T, C> speed)
        {
            return Force<T, C>.FromNewtons(power.Watts / speed.MetersPerSecond);
        }

        public static Torque<T, C> operator /(Power<T, C> power, RotationalSpeed<T, C> rotationalSpeed)
        {
            return Torque<T, C>.FromNewtonMeters(power.Watts / rotationalSpeed.RadiansPerSecond);
        }

        public static RotationalSpeed<T, C> operator /(Power<T, C> power, Torque<T, C> torque)
        {
            return RotationalSpeed<T, C>.FromRadiansPerSecond(power.Watts / torque.NewtonMeters);
        }

        public static MassFlow<T, C> operator *(Power<T, C> power, BrakeSpecificFuelConsumption<T, C> bsfc)
        {
            return MassFlow<T, C>.FromKilogramsPerSecond(bsfc.KilogramsPerJoule * power.Watts);
        }

        public static SpecificEnergy<T, C> operator /(Power<T, C> power, MassFlow<T, C> massFlow)
        {
            return SpecificEnergy<T, C>.FromJoulesPerKilogram(power.Watts / massFlow.KilogramsPerSecond);
        }

        public static MassFlow<T, C> operator /(Power<T, C> power, SpecificEnergy<T, C> specificEnergy)
        {
            return MassFlow<T, C>.FromKilogramsPerSecond(power.Watts / specificEnergy.JoulesPerKilogram);
        }
#endif
    }
}