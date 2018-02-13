﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

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
using UnitsNet.InternalHelpers.Calculators;

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToDuration
{
    public static class NumberToDurationExtensions
    {
        #region Day

        /// <inheritdoc cref="Duration.FromDays(double)"/>
        public static Duration Days(this int value) => (Duration)Duration.FromDays(value);
	
        /// <inheritdoc cref="Duration.FromDays(double)"/>
        public static Duration Days(this long value) => (Duration)Duration.FromDays(value);

        /// <inheritdoc cref="Duration.FromDays(double)"/>
        public static Duration Days(this double value) => (Duration)Duration.FromDays(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Duration.FromDays(double)"/>
        public static Duration Days(this float value) => (Duration)Duration.FromDays(value);

        /// <inheritdoc cref="Duration.FromDays(double)"/>
        public static Duration Days(this decimal value) => (Duration)Duration.FromDays(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Hour

        /// <inheritdoc cref="Duration.FromHours(double)"/>
        public static Duration Hours(this int value) => (Duration)Duration.FromHours(value);
	
        /// <inheritdoc cref="Duration.FromHours(double)"/>
        public static Duration Hours(this long value) => (Duration)Duration.FromHours(value);

        /// <inheritdoc cref="Duration.FromHours(double)"/>
        public static Duration Hours(this double value) => (Duration)Duration.FromHours(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Duration.FromHours(double)"/>
        public static Duration Hours(this float value) => (Duration)Duration.FromHours(value);

        /// <inheritdoc cref="Duration.FromHours(double)"/>
        public static Duration Hours(this decimal value) => (Duration)Duration.FromHours(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Microsecond

        /// <inheritdoc cref="Duration.FromMicroseconds(double)"/>
        public static Duration Microseconds(this int value) => (Duration)Duration.FromMicroseconds(value);
	
        /// <inheritdoc cref="Duration.FromMicroseconds(double)"/>
        public static Duration Microseconds(this long value) => (Duration)Duration.FromMicroseconds(value);

        /// <inheritdoc cref="Duration.FromMicroseconds(double)"/>
        public static Duration Microseconds(this double value) => (Duration)Duration.FromMicroseconds(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Duration.FromMicroseconds(double)"/>
        public static Duration Microseconds(this float value) => (Duration)Duration.FromMicroseconds(value);

        /// <inheritdoc cref="Duration.FromMicroseconds(double)"/>
        public static Duration Microseconds(this decimal value) => (Duration)Duration.FromMicroseconds(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Millisecond

        /// <inheritdoc cref="Duration.FromMilliseconds(double)"/>
        public static Duration Milliseconds(this int value) => (Duration)Duration.FromMilliseconds(value);
	
        /// <inheritdoc cref="Duration.FromMilliseconds(double)"/>
        public static Duration Milliseconds(this long value) => (Duration)Duration.FromMilliseconds(value);

        /// <inheritdoc cref="Duration.FromMilliseconds(double)"/>
        public static Duration Milliseconds(this double value) => (Duration)Duration.FromMilliseconds(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Duration.FromMilliseconds(double)"/>
        public static Duration Milliseconds(this float value) => (Duration)Duration.FromMilliseconds(value);

        /// <inheritdoc cref="Duration.FromMilliseconds(double)"/>
        public static Duration Milliseconds(this decimal value) => (Duration)Duration.FromMilliseconds(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Minute

        /// <inheritdoc cref="Duration.FromMinutes(double)"/>
        public static Duration Minutes(this int value) => (Duration)Duration.FromMinutes(value);
	
        /// <inheritdoc cref="Duration.FromMinutes(double)"/>
        public static Duration Minutes(this long value) => (Duration)Duration.FromMinutes(value);

        /// <inheritdoc cref="Duration.FromMinutes(double)"/>
        public static Duration Minutes(this double value) => (Duration)Duration.FromMinutes(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Duration.FromMinutes(double)"/>
        public static Duration Minutes(this float value) => (Duration)Duration.FromMinutes(value);

        /// <inheritdoc cref="Duration.FromMinutes(double)"/>
        public static Duration Minutes(this decimal value) => (Duration)Duration.FromMinutes(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Month

        /// <inheritdoc cref="Duration.FromMonths(double)"/>
        public static Duration Months(this int value) => (Duration)Duration.FromMonths(value);
	
        /// <inheritdoc cref="Duration.FromMonths(double)"/>
        public static Duration Months(this long value) => (Duration)Duration.FromMonths(value);

        /// <inheritdoc cref="Duration.FromMonths(double)"/>
        public static Duration Months(this double value) => (Duration)Duration.FromMonths(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Duration.FromMonths(double)"/>
        public static Duration Months(this float value) => (Duration)Duration.FromMonths(value);

        /// <inheritdoc cref="Duration.FromMonths(double)"/>
        public static Duration Months(this decimal value) => (Duration)Duration.FromMonths(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Nanosecond

        /// <inheritdoc cref="Duration.FromNanoseconds(double)"/>
        public static Duration Nanoseconds(this int value) => (Duration)Duration.FromNanoseconds(value);
	
        /// <inheritdoc cref="Duration.FromNanoseconds(double)"/>
        public static Duration Nanoseconds(this long value) => (Duration)Duration.FromNanoseconds(value);

        /// <inheritdoc cref="Duration.FromNanoseconds(double)"/>
        public static Duration Nanoseconds(this double value) => (Duration)Duration.FromNanoseconds(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Duration.FromNanoseconds(double)"/>
        public static Duration Nanoseconds(this float value) => (Duration)Duration.FromNanoseconds(value);

        /// <inheritdoc cref="Duration.FromNanoseconds(double)"/>
        public static Duration Nanoseconds(this decimal value) => (Duration)Duration.FromNanoseconds(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Second

        /// <inheritdoc cref="Duration.FromSeconds(double)"/>
        public static Duration Seconds(this int value) => (Duration)Duration.FromSeconds(value);
	
        /// <inheritdoc cref="Duration.FromSeconds(double)"/>
        public static Duration Seconds(this long value) => (Duration)Duration.FromSeconds(value);

        /// <inheritdoc cref="Duration.FromSeconds(double)"/>
        public static Duration Seconds(this double value) => (Duration)Duration.FromSeconds(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Duration.FromSeconds(double)"/>
        public static Duration Seconds(this float value) => (Duration)Duration.FromSeconds(value);

        /// <inheritdoc cref="Duration.FromSeconds(double)"/>
        public static Duration Seconds(this decimal value) => (Duration)Duration.FromSeconds(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Week

        /// <inheritdoc cref="Duration.FromWeeks(double)"/>
        public static Duration Weeks(this int value) => (Duration)Duration.FromWeeks(value);
	
        /// <inheritdoc cref="Duration.FromWeeks(double)"/>
        public static Duration Weeks(this long value) => (Duration)Duration.FromWeeks(value);

        /// <inheritdoc cref="Duration.FromWeeks(double)"/>
        public static Duration Weeks(this double value) => (Duration)Duration.FromWeeks(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Duration.FromWeeks(double)"/>
        public static Duration Weeks(this float value) => (Duration)Duration.FromWeeks(value);

        /// <inheritdoc cref="Duration.FromWeeks(double)"/>
        public static Duration Weeks(this decimal value) => (Duration)Duration.FromWeeks(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Year

        /// <inheritdoc cref="Duration.FromYears(double)"/>
        public static Duration Years(this int value) => (Duration)Duration.FromYears(value);
	
        /// <inheritdoc cref="Duration.FromYears(double)"/>
        public static Duration Years(this long value) => (Duration)Duration.FromYears(value);

        /// <inheritdoc cref="Duration.FromYears(double)"/>
        public static Duration Years(this double value) => (Duration)Duration.FromYears(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Duration.FromYears(double)"/>
        public static Duration Years(this float value) => (Duration)Duration.FromYears(value);

        /// <inheritdoc cref="Duration.FromYears(double)"/>
        public static Duration Years(this decimal value) => (Duration)Duration.FromYears(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

    }
}
#endif
