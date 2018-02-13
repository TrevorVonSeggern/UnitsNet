namespace UnitsNet.InternalHelpers.Calculators
{
    using System;
    public interface INumberCalculator<T> where T : struct
    {
        T Sum(T a, T b);
        T Add(T a, T b);
        T Divide(T a, T b);
        T Multiply(T a, T b);
        T Subtract(T a, T b);
        T Power(T a, T b);
        T Modulo(T a, T b);

        T Sum(T a, double b);
        T Add(T a, double b);
        T Divide(T a, double b);
        T Multiply(T a, double b);
        T Subtract(T a, double b);
        T Power(T a, double b);
        T Modulo(T a, double b);

        T Negate(T a);
        T Floor(T number);
        T Log10(T number); 
        T Sqrt(T number);

        bool LessThanOrEqual(T a, T b);
        bool LessThan(T a, T b);
        bool GreaterThanOrEqual(T a, T b);
        bool GreaterThan(T a, T b);
        bool Equals(T a, T b);
        bool NotEquals(T a, T b);

        T MaxValue();
        T MinValue();

        T ConvertToNumber(decimal v);
        T ConvertToNumber(double v);
        T ConvertToNumber(float v);
        T ConvertToNumber(long v);
        T ConvertToNumber(int v);
        T ConvertToNumber(short v);

        decimal ConvertToDecimal(T v);
        double ConvertToDouble(T v);
        float ConvertToFloat(T v);
        long ConvertToLong(T v);
        int ConvertToInt(T v);
        short ConvertToShort(T v);
    }
}
