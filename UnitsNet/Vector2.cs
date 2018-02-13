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
using UnitsNet.InternalHelpers.Calculators;

namespace UnitsNet
{
    public class Vector2 : UnitsNet.Generic.Vector2<double, DoubleCalculator> { }

    namespace Generic
    {
#if WINDOWS_UWP
        public struct Vector2
        {
            public double X;
            public double Y;
        }
#else
        public class Vector2<T, C> : IEquatable<Vector2<T, C>>
            where T : struct
            where C : INumberCalculator<T>, new()
        {
            public readonly Number<T, C> X;
            public readonly Number<T, C> Y;

            public Vector2()
            {
                X = 0;
                Y = 0;
            }

            public Vector2(Number<T, C> x, Number<T, C> y)
            {
                X = x;
                Y = y;
            }

            public Vector2(Number<T, C> xy) : this()
            {
                X = xy;
                Y = xy;
            }

            #region Equality

            private static IEqualityComparer<Vector2<T, C>> XyComparer { get; } = new XyEqualityComparer();

            public bool Equals(Vector2<T, C> other)
            {
                return XyComparer.Equals(this, other);
            }

            public static bool operator !=(Vector2<T, C> left, Vector2<T, C> right)
            {
                return !XyComparer.Equals(left, right);
            }

            public static bool operator ==(Vector2<T, C> left, Vector2<T, C> right)
            {
                return XyComparer.Equals(left, right);
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                return obj is Vector2<T, C> && Equals((Vector2<T, C>) obj);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    return (X.GetHashCode()*397) ^ Y.GetHashCode();
                }
            }

            private sealed class XyEqualityComparer : IEqualityComparer<Vector2<T, C>>
            {
                public bool Equals(Vector2<T, C> x, Vector2<T, C> y)
                {
                    return x.X.Equals(y.X) && x.Y.Equals(y.Y);
                }

                public int GetHashCode(Vector2<T, C> obj)
                {
                    unchecked
                    {
                        return (obj.X.GetHashCode()*397) ^ obj.Y.GetHashCode();
                    }
                }
            }

            #endregion

            public override string ToString()
            {
                return $"[{X:0.####}, {Y:0.####}]";
            }
        }
#endif

    }
}