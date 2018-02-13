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
using System.Collections.Generic;
using UnitsNet.InternalHelpers.Calculators;
using UnitsNet.Units;

#endif

namespace UnitsNet.Generic
{
    /// <summary>
    ///     A class for representing position in two dimensions.
    /// </summary>
#if WINDOWS_UWP
    public struct Length2d
    {
        /// <summary>
        ///     Returns a point represented in meters.
        /// </summary>
        public Vector2 Meters;
    }
#else
    public struct Length2d<T, C> : IEquatable<Length2d<T, C>>
        where T : struct
        where C : INumberCalculator<T>, new()
    {
        /// <summary>
        ///     Returns a point represented in meters.
        /// </summary>
        public readonly Vector2<T, C> Meters;

        /// <summary>
        ///     Creates an instance based on X and Y in implicitly defined SI units.
        /// </summary>
        public Length2d(Number<T, C> xMeters, Number<T, C> yMeters)
        {
            Meters = new Vector2<T, C>(xMeters, yMeters);
        }

        /// <summary>
        ///     Creates an instance based on X and Y in implicitly defined SI units.
        /// </summary>
        public Length2d(T xMeters, T yMeters)
        {
            Meters = new Vector2<T, C>(new Number<T, C>(xMeters), new Number<T, C>(yMeters));
        }

        public Length2d(Length<T, C> x, Length<T, C> y) : this(x.Meters, y.Meters)
        {
        }

        #region Static

        public static Length<T, C> GetDistance(Length2d<T, C> a, Length2d<T, C> b)
        {
            Vector2<T, C> d = (a - b).Meters;
            return Length<T, C>.FromMeters(new Number<T, C>(new C().Sqrt(d.X*d.X + d.Y*d.Y)));
        }

        #endregion

        #region Public properties

        public Length<T, C> Length
        {
            get
            {
                var x = Meters.X;
                var y = Meters.Y;
                return Length<T, C>.FromMeters(new Number<T, C>(new C().Sqrt(x*x + y*y)));
            }
        }

        public Length<T, C> X => Length<T, C>.FromMeters(Meters.X);

        public Length<T, C> Y => Length<T, C>.FromMeters(Meters.Y);

        public Vector2<T, C> Miles => new Vector2<T, C>(X.Miles, Y.Miles);

        public Vector2<T, C> Yards => new Vector2<T, C>(X.Yards, Y.Yards);

        public Vector2<T, C> Feet => new Vector2<T, C>(X.Feet, Y.Feet);

        public Vector2<T, C> Inches => new Vector2<T, C>(X.Inches, Y.Inches);

        public Vector2<T, C> Kilometers => new Vector2<T, C>(X.Kilometers, Y.Kilometers);

        public Vector2<T, C> Decimeters => new Vector2<T, C>(X.Decimeters, Y.Decimeters);

        /// <summary>
        ///     Returns a point represented in centimeters.
        /// </summary>
        public Vector2<T, C> Centimeters => new Vector2<T, C>(Meters.X*1E2, Meters.Y*1E2);

        /// <summary>
        ///     Returns a point represented in millimeters.
        /// </summary>
        public Vector2<T, C> Millimeters => new Vector2<T, C>(Meters.X*1E3, Meters.Y*1E3);

        public Vector2<T, C> Micrometers => new Vector2<T, C>(X.Micrometers, Y.Micrometers);

        public Vector2<T, C> Nanometers => new Vector2<T, C>(X.Nanometers, Y.Nanometers);

        #endregion

        #region Static methods

        public static Length2d<T, C> Zero => new Length2d<T, C>();

        public static Length2d<T, C> FromMeters(Number<T, C> xMeters, Number<T, C> yMeters)
        {
            return new Length2d<T, C>(xMeters, yMeters);
        }

        public static Length2d<T, C> FromCentimeters(Number<T, C> xCentimeters, Number<T, C> yCentimeters)
        {
            return new Length2d<T, C>(xCentimeters*1E-2, yCentimeters*1E-2);
        }

        public static Length2d<T, C> FromMillimeters(Number<T, C> xMillimeters, Number<T, C> yMillimeters)
        {
            return new Length2d<T, C>(xMillimeters*1E-3, yMillimeters*1E-3);
        }

        #endregion

        #region Arithmetic operators

        public static Length2d<T, C> operator -(Length2d<T, C> right)
        {
            return FromMeters(-right.X.Meters, -right.Y.Meters);
        }

        public static Length2d<T, C> operator +(Length2d<T, C> left, Length2d<T, C> right)
        {
            var x = left.X.Meters + right.X.Meters;
            var y = left.Y.Meters + right.Y.Meters;
            return FromMeters(x, y);
        }

        public static Length2d<T, C> operator -(Length2d<T, C> left, Length2d<T, C> right)
        {
            var x = left.X.Meters - right.X.Meters;
            var y = left.Y.Meters - right.Y.Meters;
            return FromMeters(x, y);
        }

        public static Length2d<T, C> operator *(Number<T, C> left, Length2d<T, C> right)
        {
            var x = left*right.X.Meters;
            var y = left*right.Y.Meters;
            return FromMeters(x, y);
        }

        public static Length2d<T, C> operator *(Length2d<T, C> left, Number<T, C> right)
        {
            var x = left.X.Meters*right;
            var y = left.Y.Meters*right;
            return FromMeters(x, y);
        }

        public static Length2d<T, C> operator *(Length2d<T, C> left, Length2d<T, C> right)
        {
            var x = left.X.Meters*right.X.Meters;
            var y = left.Y.Meters*right.Y.Meters;
            return FromMeters(x, y);
        }

        public static Length2d<T, C> operator /(Length2d<T, C> left, Number<T, C> right)
        {
            var x = left.X.Meters/right;
            var y = left.Y.Meters/right;
            return FromMeters(x, y);
        }

        public static Vector2<T, C> operator /(Length2d<T, C> left, Length2d<T, C> right)
        {
            var x = left.X.Meters/right.X.Meters;
            var y = left.Y.Meters/right.Y.Meters;
            return new Vector2<T, C>(x, y);
        }

        #endregion

        #region Public methods

        public override string ToString()
        {
            return
                $"({X.Meters:0.##}, {Y.Meters:0.##}) {UnitSystem.GetCached().GetDefaultAbbreviation(LengthUnit.Meter)}";
        }

        public Length<T, C> DistanceTo(Length2d<T, C> other)
        {
            var dx = X.Meters - other.X.Meters;
            var dy = Y.Meters - other.Y.Meters;
            var distance = new C().Sqrt(dx*dx + dy*dy);

            return Length<T, C>.FromMeters(distance);
        }

        #endregion

        #region Equality

        private static IEqualityComparer<Length2d<T, C>> MetersComparer { get; } = new MetersEqualityComparer();

        public bool Equals(Length2d<T, C> other)
        {
            return MetersComparer.Equals(this, other);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Length2d<T, C> && Equals((Length2d<T, C>) obj);
        }

        public override int GetHashCode()
        {
            return Meters.GetHashCode();
        }

        public static bool operator !=(Length2d<T, C> left, Length2d<T, C> right)
        {
            return left.Meters != right.Meters;
        }

        public static bool operator ==(Length2d<T, C> left, Length2d<T, C> right)
        {
            return left.Meters == right.Meters;
        }

        private sealed class MetersEqualityComparer : IEqualityComparer<Length2d<T, C>>
        {
            public bool Equals(Length2d<T, C> x, Length2d<T, C> y)
            {
                return x.Meters.Equals(y.Meters);
            }

            public int GetHashCode(Length2d<T, C> obj)
            {
                return obj.Meters.GetHashCode();
            }
        }

        #endregion
    }
#endif
}