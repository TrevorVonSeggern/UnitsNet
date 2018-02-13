namespace UnitsNet.InternalHelpers.Calculators
{
    using System;
    using numberType = System.Decimal;
    public struct DecimalCalculator : INumberCalculator<numberType>
    {
        public numberType Sum(numberType a, numberType b) => a + b;
        public numberType Add(numberType a, numberType b) => a + b;
        public numberType Divide(numberType a, numberType b) => a / b;
        public numberType Multiply(numberType a, numberType b) => a * b;
        public numberType Subtract(numberType a, numberType b) => a - b;
        public numberType Power(numberType a, numberType b) => (numberType)Math.Pow(numberType.ToDouble(a), numberType.ToDouble(b));
        public numberType Modulo(numberType a, numberType b) => a % b;

        public numberType Sum(numberType a, double b) => (a + (numberType)(b));
        public numberType Add(numberType a, double b) => (a + new numberType(b));
        public numberType Divide(numberType a, double b) => (a / new numberType(b));
        public numberType Multiply(numberType a, double b) => (a * new numberType(b));
        public numberType Subtract(numberType a, double b) => (a - new numberType(b));
        public numberType Power(numberType a, double b) => (numberType)Math.Pow(numberType.ToDouble(a), b);
        public numberType Modulo(numberType a, double b) => a % new numberType(b);

        public bool LessThanOrEqual(numberType a, numberType b) => a <= b;
        public bool LessThan(numberType a, numberType b) => a < b;
        public bool GreaterThanOrEqual(numberType a, numberType b) => a >= b;
        public bool GreaterThan(numberType a, numberType b) => a > b;
        public bool Equals(numberType a, numberType b) => a == b;
        public bool NotEquals(numberType a, numberType b) => a != b;

        public numberType MaxValue() => numberType.MaxValue;
        public numberType MinValue() => numberType.MinValue;

        public numberType ConvertToNumber(decimal v) => v;
        public numberType ConvertToNumber(double v) => new numberType(v);
        public numberType ConvertToNumber(float v) => new numberType(v);
        public numberType ConvertToNumber(long v) => new numberType(v);
        public numberType ConvertToNumber(int v) => new numberType(v);
        public numberType ConvertToNumber(short v) => new numberType(v);

        public decimal ConvertToDecimal(numberType v) => v;
        public double ConvertToDouble(numberType v) => numberType.ToDouble(v);
        public float ConvertToFloat(numberType v) => numberType.ToSingle(v);
        public long ConvertToLong(numberType v) => numberType.ToInt64(v);
        public int ConvertToInt(numberType v) => numberType.ToInt32(v);
        public short ConvertToShort(numberType v) => numberType.ToInt16(v);

        public numberType Floor(numberType a) => Math.Floor(a);
        public numberType Negate(numberType a) => -a;
        public numberType Log10(numberType a) => new numberType(Math.Log10(numberType.ToDouble(a)));
        public numberType Sqrt(numberType a) => new numberType(Math.Sqrt(numberType.ToDouble(a)));
    }
}
