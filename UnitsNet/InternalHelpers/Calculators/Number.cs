using System;
using System.Collections.Generic;

namespace UnitsNet.InternalHelpers.Calculators
{
    public struct Number<T, C> : IComparable, IComparable<T>, IEquatable<Number<T, C>> 
        where T : struct
        where C : INumberCalculator<T>, new()
    {
        private T value;
        private static C calculator = new C(); // struct is 0 size. No overhead for a new.
        public Number(T value)
        {
            this.value = value;
        }

        public static implicit operator Number<T, C>(T a) => new Number<T, C>(a);
        public static implicit operator T(Number<T, C> a) => a.value;

        public static implicit operator Number<T, C>(double val) => new Number<T, C>(new Number<T, C>(calculator.ConvertToNumber(val)));
        public static implicit operator Number<T, C>(float val) => new Number<T, C>(new Number<T, C>(calculator.ConvertToNumber(val)));
        public static implicit operator Number<T, C>(long val) => new Number<T, C>(new Number<T, C>(calculator.ConvertToNumber(val)));
        public static implicit operator Number<T, C>(decimal val) => new Number<T, C>(new Number<T, C>(calculator.ConvertToNumber(val)));
        public static implicit operator Number<T, C>(short val) => new Number<T, C>(new Number<T, C>(calculator.ConvertToNumber(val)));
        public static implicit operator Number<T, C>(byte val) => new Number<T, C>(new Number<T, C>(calculator.ConvertToNumber(val)));

        public static implicit operator Number<T, C>(double? val) => new Number<T, C>(new Number<T, C>(calculator.ConvertToNumber(val.Value)));
        public static implicit operator Number<T, C>(float? val) => new Number<T, C>(new Number<T, C>(calculator.ConvertToNumber(val.Value)));
        public static implicit operator Number<T, C>(long? val) => new Number<T, C>(new Number<T, C>(calculator.ConvertToNumber(val.Value)));
        public static implicit operator Number<T, C>(decimal? val) => new Number<T, C>(new Number<T, C>(calculator.ConvertToNumber(val.Value)));
        public static implicit operator Number<T, C>(short? val) => new Number<T, C>(new Number<T, C>(calculator.ConvertToNumber(val.Value)));
        public static implicit operator Number<T, C>(byte? val) => new Number<T, C>(new Number<T, C>(calculator.ConvertToNumber(val.Value)));

        public static explicit operator decimal(Number<T, C> number) => calculator.ConvertToDecimal(number.value);
        public static explicit operator double(Number<T, C> number) => calculator.ConvertToDouble(number.value);
        public static explicit operator float(Number<T, C> number) => calculator.ConvertToFloat(number.value);
        public static explicit operator long(Number<T, C> number) => calculator.ConvertToLong(number.value);
        public static explicit operator int(Number<T, C> number) => calculator.ConvertToInt(number.value);
        public static explicit operator short(Number<T, C> number) => calculator.ConvertToShort(number.value);

        public static Number<T, C> operator +(Number<T, C> a, Number<T, C> b) => calculator.Add(a.value, b.value);
        public static Number<T, C> operator -(Number<T, C> a, Number<T, C> b) => calculator.Subtract(a.value, b.value);
        public static Number<T, C> operator *(Number<T, C> a, Number<T, C> b) => calculator.Multiply(a.value, b.value);
        public static Number<T, C> operator /(Number<T, C> a, Number<T, C> b) => calculator.Divide(a.value, b.value);
        public static Number<T, C> operator ^(Number<T, C> a, Number<T, C> b) => calculator.Power(a.value, b.value);
        public static Number<T, C> operator %(Number<T, C> a, Number<T, C> b) => calculator.Modulo(a.value, b.value);

        public static Number<T, C> operator +(Number<T, C> a, double b) => calculator.Add(a.value, b);
        public static Number<T, C> operator -(Number<T, C> a, double b) => calculator.Subtract(a.value, b);
        public static Number<T, C> operator *(Number<T, C> a, double b) => calculator.Multiply(a.value, b);
        public static Number<T, C> operator /(Number<T, C> a, double b) => calculator.Divide(a.value, b);
        public static Number<T, C> operator ^(Number<T, C> a, double b) => calculator.Power(a.value, b);
        public static Number<T, C> operator %(Number<T, C> a, double b) => calculator.Modulo(a.value, b);

        public static Number<T, C> operator -(Number<T, C> a) => calculator.Negate(a);

        public static bool operator <=(Number<T, C> a, Number<T, C> b) => calculator.LessThanOrEqual(a, b);
        public static bool operator <(Number<T, C> a, Number<T, C> b) => calculator.LessThan(a, b);
        public static bool operator >=(Number<T, C> a, Number<T, C> b) => calculator.GreaterThanOrEqual(a, b);
        public static bool operator >(Number<T, C> a, Number<T, C> b) => calculator.GreaterThan(a, b);
        public static bool operator ==(Number<T, C> a, Number<T, C> b) => calculator.Equals(a, b);
        public static bool operator !=(Number<T, C> a, Number<T, C> b) => calculator.NotEquals(a, b);

        public static T MaxValue => calculator.MaxValue();
        public static T MinValue => calculator.MinValue();

        public bool Equals(Number<T, C> obj) => this == obj;

        public override int GetHashCode()
        {
            var hashCode = 1113510858;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<T>.Default.GetHashCode(value);
            return hashCode;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Number<T, C>))
                return -1;
            var number = (Number<T, C>)obj;
            return CompareTo(number);
        }

        public int CompareTo(T other)
        {
            if (calculator.LessThan(value, other))
                return -1;
            if (calculator.Equals(value, other))
                return 0;
            return 1;
        }

        public override string ToString() => value.ToString();

        public override bool Equals(object obj)
        {
            if (!(obj is Number<T, C>))
                return false;
            var number = (Number<T, C>)obj;
            return this == number;
        }
    }
}
