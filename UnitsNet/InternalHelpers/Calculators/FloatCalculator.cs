﻿namespace UnitsNet.InternalHelpers.Calculators
{
    using System;
    using numberType = System.Single;
    public struct FloatCalculator : INumberCalculator<numberType>
    {
        public numberType Sum(numberType a, numberType b) => a + b;
        public numberType Add(numberType a, numberType b) => a + b;
        public numberType Divide(numberType a, numberType b) => a / b;
        public numberType Multiply(numberType a, numberType b) => a * b;
        public numberType Subtract(numberType a, numberType b) => a - b;
        public numberType Power(numberType a, numberType b) => (numberType)Math.Pow(a, b);
        public numberType Modulo(numberType a, numberType b) => a % b;

        public bool LessThanOrEqual(numberType a, numberType b) => a <= b;
        public bool LessThan(numberType a, numberType b) => a < b;
        public bool GreaterThanOrEqual(numberType a, numberType b) => a >= b;
        public bool GreaterThan(numberType a, numberType b) => a > b;
        public bool Equals(numberType a, numberType b) => a == b;
        public bool NotEquals(numberType a, numberType b) => a != b;

        public numberType Sum(numberType a, double b) => (numberType)(a + b);
        public numberType Add(numberType a, double b) => (numberType)(a + b);
        public numberType Divide(numberType a, double b) => (numberType)(a / b);
        public numberType Multiply(numberType a, double b) => (numberType)(a * b);
        public numberType Subtract(numberType a, double b) => (numberType)(a - b);
        public numberType Power(numberType a, double b) => (numberType)Math.Pow(a, b);
        public numberType Modulo(numberType a, double b) => (numberType)(a % b);

        public numberType MaxValue() => numberType.MaxValue;
        public numberType MinValue() => numberType.MinValue;

        public numberType ConvertToNumber(decimal v) => Decimal.ToSingle(v);
        public numberType ConvertToNumber(double v) => (numberType)v;
        public numberType ConvertToNumber(float v) => v;
        public numberType ConvertToNumber(long v) => v;
        public numberType ConvertToNumber(int v) => v;
        public numberType ConvertToNumber(short v) => v;

        public decimal ConvertToDecimal(numberType v) => (decimal)v;
        public double ConvertToDouble(numberType v) => v;
        public float ConvertToFloat(numberType v) => v;
        public long ConvertToLong(numberType v) => (long)v;
        public int ConvertToInt(numberType v) => (int)v;
        public short ConvertToShort(numberType v) => (short)v;

        public numberType Floor(numberType a) => (numberType)Math.Floor(a);
        public numberType Negate(numberType a) => -a;
        public numberType Log10(numberType a) => (numberType)Math.Log10(a);
        public numberType Sqrt(numberType a) => (numberType)Math.Sqrt(a);
    }
}
