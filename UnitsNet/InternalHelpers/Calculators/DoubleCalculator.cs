namespace UnitsNet.InternalHelpers.Calculators
{
    using System;
    using numberType = System.Double;
    public struct DoubleCalculator : INumberCalculator<numberType>
    {
        public numberType Sum(numberType a, numberType b) => a + b;
        public numberType Add(numberType a, numberType b) => a + b;
        public numberType Divide(numberType a, numberType b) => a / b;
        public numberType Multiply(numberType a, numberType b) => a * b;
        public numberType Subtract(numberType a, numberType b) => a - b;
        public numberType Power(numberType a, numberType b) => Math.Pow(a, b);
        public numberType Modulo(numberType a, numberType b) => a % b;

        public bool LessThanOrEqual(numberType a, numberType b) => a <= b;
        public bool LessThan(numberType a, numberType b) => a < b;
        public bool GreaterThanOrEqual(numberType a, numberType b) => a >= b;
        public bool GreaterThan(numberType a, numberType b) => a > b;
        public bool Equals(numberType a, numberType b) => a == b;
        public bool NotEquals(numberType a, numberType b) => a != b;

        public numberType MaxValue() => numberType.MaxValue;
        public numberType MinValue() => numberType.MinValue;

        public numberType ConvertToNumber(decimal v) => Decimal.ToDouble(v);
        public numberType ConvertToNumber(double v) => v;
        public numberType ConvertToNumber(float v) => v;
        public numberType ConvertToNumber(long v) => v;
        public numberType ConvertToNumber(int v) => v;
        public numberType ConvertToNumber(short v) => v;

        public decimal ConvertToDecimal(numberType v) => (decimal)v;
        public double ConvertToDouble(numberType v) => v;
        public float ConvertToFloat(numberType v) => (float)v;
        public long ConvertToLong(numberType v) => (long)v;
        public int ConvertToInt(numberType v) => (int)v;
        public short ConvertToShort(numberType v) => (short)v;

        public numberType Floor(numberType a) => Math.Floor(a);
        public numberType Negate(numberType a) => -a;
        public numberType Log10(numberType a) => Math.Log10(a);
        public numberType Sqrt(numberType a) => Math.Sqrt(a);
    }
}
