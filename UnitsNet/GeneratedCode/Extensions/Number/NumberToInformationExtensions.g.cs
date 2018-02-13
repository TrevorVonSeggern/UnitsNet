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
namespace UnitsNet.Extensions.NumberToInformation
{
    public static class NumberToInformationExtensions
    {
        #region Bit

        /// <inheritdoc cref="Information.FromBits(double)"/>
        public static Information Bits(this int value) => (Information)Information.FromBits(value);
	
        /// <inheritdoc cref="Information.FromBits(double)"/>
        public static Information Bits(this long value) => (Information)Information.FromBits(value);

        /// <inheritdoc cref="Information.FromBits(double)"/>
        public static Information Bits(this double value) => (Information)Information.FromBits(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromBits(double)"/>
        public static Information Bits(this float value) => (Information)Information.FromBits(value);

        /// <inheritdoc cref="Information.FromBits(double)"/>
        public static Information Bits(this decimal value) => (Information)Information.FromBits(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Byte

        /// <inheritdoc cref="Information.FromBytes(double)"/>
        public static Information Bytes(this int value) => (Information)Information.FromBytes(value);
	
        /// <inheritdoc cref="Information.FromBytes(double)"/>
        public static Information Bytes(this long value) => (Information)Information.FromBytes(value);

        /// <inheritdoc cref="Information.FromBytes(double)"/>
        public static Information Bytes(this double value) => (Information)Information.FromBytes(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromBytes(double)"/>
        public static Information Bytes(this float value) => (Information)Information.FromBytes(value);

        /// <inheritdoc cref="Information.FromBytes(double)"/>
        public static Information Bytes(this decimal value) => (Information)Information.FromBytes(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Exabit

        /// <inheritdoc cref="Information.FromExabits(double)"/>
        public static Information Exabits(this int value) => (Information)Information.FromExabits(value);
	
        /// <inheritdoc cref="Information.FromExabits(double)"/>
        public static Information Exabits(this long value) => (Information)Information.FromExabits(value);

        /// <inheritdoc cref="Information.FromExabits(double)"/>
        public static Information Exabits(this double value) => (Information)Information.FromExabits(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromExabits(double)"/>
        public static Information Exabits(this float value) => (Information)Information.FromExabits(value);

        /// <inheritdoc cref="Information.FromExabits(double)"/>
        public static Information Exabits(this decimal value) => (Information)Information.FromExabits(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Exabyte

        /// <inheritdoc cref="Information.FromExabytes(double)"/>
        public static Information Exabytes(this int value) => (Information)Information.FromExabytes(value);
	
        /// <inheritdoc cref="Information.FromExabytes(double)"/>
        public static Information Exabytes(this long value) => (Information)Information.FromExabytes(value);

        /// <inheritdoc cref="Information.FromExabytes(double)"/>
        public static Information Exabytes(this double value) => (Information)Information.FromExabytes(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromExabytes(double)"/>
        public static Information Exabytes(this float value) => (Information)Information.FromExabytes(value);

        /// <inheritdoc cref="Information.FromExabytes(double)"/>
        public static Information Exabytes(this decimal value) => (Information)Information.FromExabytes(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Exbibit

        /// <inheritdoc cref="Information.FromExbibits(double)"/>
        public static Information Exbibits(this int value) => (Information)Information.FromExbibits(value);
	
        /// <inheritdoc cref="Information.FromExbibits(double)"/>
        public static Information Exbibits(this long value) => (Information)Information.FromExbibits(value);

        /// <inheritdoc cref="Information.FromExbibits(double)"/>
        public static Information Exbibits(this double value) => (Information)Information.FromExbibits(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromExbibits(double)"/>
        public static Information Exbibits(this float value) => (Information)Information.FromExbibits(value);

        /// <inheritdoc cref="Information.FromExbibits(double)"/>
        public static Information Exbibits(this decimal value) => (Information)Information.FromExbibits(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Exbibyte

        /// <inheritdoc cref="Information.FromExbibytes(double)"/>
        public static Information Exbibytes(this int value) => (Information)Information.FromExbibytes(value);
	
        /// <inheritdoc cref="Information.FromExbibytes(double)"/>
        public static Information Exbibytes(this long value) => (Information)Information.FromExbibytes(value);

        /// <inheritdoc cref="Information.FromExbibytes(double)"/>
        public static Information Exbibytes(this double value) => (Information)Information.FromExbibytes(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromExbibytes(double)"/>
        public static Information Exbibytes(this float value) => (Information)Information.FromExbibytes(value);

        /// <inheritdoc cref="Information.FromExbibytes(double)"/>
        public static Information Exbibytes(this decimal value) => (Information)Information.FromExbibytes(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Gibibit

        /// <inheritdoc cref="Information.FromGibibits(double)"/>
        public static Information Gibibits(this int value) => (Information)Information.FromGibibits(value);
	
        /// <inheritdoc cref="Information.FromGibibits(double)"/>
        public static Information Gibibits(this long value) => (Information)Information.FromGibibits(value);

        /// <inheritdoc cref="Information.FromGibibits(double)"/>
        public static Information Gibibits(this double value) => (Information)Information.FromGibibits(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromGibibits(double)"/>
        public static Information Gibibits(this float value) => (Information)Information.FromGibibits(value);

        /// <inheritdoc cref="Information.FromGibibits(double)"/>
        public static Information Gibibits(this decimal value) => (Information)Information.FromGibibits(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Gibibyte

        /// <inheritdoc cref="Information.FromGibibytes(double)"/>
        public static Information Gibibytes(this int value) => (Information)Information.FromGibibytes(value);
	
        /// <inheritdoc cref="Information.FromGibibytes(double)"/>
        public static Information Gibibytes(this long value) => (Information)Information.FromGibibytes(value);

        /// <inheritdoc cref="Information.FromGibibytes(double)"/>
        public static Information Gibibytes(this double value) => (Information)Information.FromGibibytes(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromGibibytes(double)"/>
        public static Information Gibibytes(this float value) => (Information)Information.FromGibibytes(value);

        /// <inheritdoc cref="Information.FromGibibytes(double)"/>
        public static Information Gibibytes(this decimal value) => (Information)Information.FromGibibytes(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Gigabit

        /// <inheritdoc cref="Information.FromGigabits(double)"/>
        public static Information Gigabits(this int value) => (Information)Information.FromGigabits(value);
	
        /// <inheritdoc cref="Information.FromGigabits(double)"/>
        public static Information Gigabits(this long value) => (Information)Information.FromGigabits(value);

        /// <inheritdoc cref="Information.FromGigabits(double)"/>
        public static Information Gigabits(this double value) => (Information)Information.FromGigabits(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromGigabits(double)"/>
        public static Information Gigabits(this float value) => (Information)Information.FromGigabits(value);

        /// <inheritdoc cref="Information.FromGigabits(double)"/>
        public static Information Gigabits(this decimal value) => (Information)Information.FromGigabits(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Gigabyte

        /// <inheritdoc cref="Information.FromGigabytes(double)"/>
        public static Information Gigabytes(this int value) => (Information)Information.FromGigabytes(value);
	
        /// <inheritdoc cref="Information.FromGigabytes(double)"/>
        public static Information Gigabytes(this long value) => (Information)Information.FromGigabytes(value);

        /// <inheritdoc cref="Information.FromGigabytes(double)"/>
        public static Information Gigabytes(this double value) => (Information)Information.FromGigabytes(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromGigabytes(double)"/>
        public static Information Gigabytes(this float value) => (Information)Information.FromGigabytes(value);

        /// <inheritdoc cref="Information.FromGigabytes(double)"/>
        public static Information Gigabytes(this decimal value) => (Information)Information.FromGigabytes(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Kibibit

        /// <inheritdoc cref="Information.FromKibibits(double)"/>
        public static Information Kibibits(this int value) => (Information)Information.FromKibibits(value);
	
        /// <inheritdoc cref="Information.FromKibibits(double)"/>
        public static Information Kibibits(this long value) => (Information)Information.FromKibibits(value);

        /// <inheritdoc cref="Information.FromKibibits(double)"/>
        public static Information Kibibits(this double value) => (Information)Information.FromKibibits(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromKibibits(double)"/>
        public static Information Kibibits(this float value) => (Information)Information.FromKibibits(value);

        /// <inheritdoc cref="Information.FromKibibits(double)"/>
        public static Information Kibibits(this decimal value) => (Information)Information.FromKibibits(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Kibibyte

        /// <inheritdoc cref="Information.FromKibibytes(double)"/>
        public static Information Kibibytes(this int value) => (Information)Information.FromKibibytes(value);
	
        /// <inheritdoc cref="Information.FromKibibytes(double)"/>
        public static Information Kibibytes(this long value) => (Information)Information.FromKibibytes(value);

        /// <inheritdoc cref="Information.FromKibibytes(double)"/>
        public static Information Kibibytes(this double value) => (Information)Information.FromKibibytes(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromKibibytes(double)"/>
        public static Information Kibibytes(this float value) => (Information)Information.FromKibibytes(value);

        /// <inheritdoc cref="Information.FromKibibytes(double)"/>
        public static Information Kibibytes(this decimal value) => (Information)Information.FromKibibytes(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Kilobit

        /// <inheritdoc cref="Information.FromKilobits(double)"/>
        public static Information Kilobits(this int value) => (Information)Information.FromKilobits(value);
	
        /// <inheritdoc cref="Information.FromKilobits(double)"/>
        public static Information Kilobits(this long value) => (Information)Information.FromKilobits(value);

        /// <inheritdoc cref="Information.FromKilobits(double)"/>
        public static Information Kilobits(this double value) => (Information)Information.FromKilobits(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromKilobits(double)"/>
        public static Information Kilobits(this float value) => (Information)Information.FromKilobits(value);

        /// <inheritdoc cref="Information.FromKilobits(double)"/>
        public static Information Kilobits(this decimal value) => (Information)Information.FromKilobits(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Kilobyte

        /// <inheritdoc cref="Information.FromKilobytes(double)"/>
        public static Information Kilobytes(this int value) => (Information)Information.FromKilobytes(value);
	
        /// <inheritdoc cref="Information.FromKilobytes(double)"/>
        public static Information Kilobytes(this long value) => (Information)Information.FromKilobytes(value);

        /// <inheritdoc cref="Information.FromKilobytes(double)"/>
        public static Information Kilobytes(this double value) => (Information)Information.FromKilobytes(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromKilobytes(double)"/>
        public static Information Kilobytes(this float value) => (Information)Information.FromKilobytes(value);

        /// <inheritdoc cref="Information.FromKilobytes(double)"/>
        public static Information Kilobytes(this decimal value) => (Information)Information.FromKilobytes(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Mebibit

        /// <inheritdoc cref="Information.FromMebibits(double)"/>
        public static Information Mebibits(this int value) => (Information)Information.FromMebibits(value);
	
        /// <inheritdoc cref="Information.FromMebibits(double)"/>
        public static Information Mebibits(this long value) => (Information)Information.FromMebibits(value);

        /// <inheritdoc cref="Information.FromMebibits(double)"/>
        public static Information Mebibits(this double value) => (Information)Information.FromMebibits(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromMebibits(double)"/>
        public static Information Mebibits(this float value) => (Information)Information.FromMebibits(value);

        /// <inheritdoc cref="Information.FromMebibits(double)"/>
        public static Information Mebibits(this decimal value) => (Information)Information.FromMebibits(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Mebibyte

        /// <inheritdoc cref="Information.FromMebibytes(double)"/>
        public static Information Mebibytes(this int value) => (Information)Information.FromMebibytes(value);
	
        /// <inheritdoc cref="Information.FromMebibytes(double)"/>
        public static Information Mebibytes(this long value) => (Information)Information.FromMebibytes(value);

        /// <inheritdoc cref="Information.FromMebibytes(double)"/>
        public static Information Mebibytes(this double value) => (Information)Information.FromMebibytes(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromMebibytes(double)"/>
        public static Information Mebibytes(this float value) => (Information)Information.FromMebibytes(value);

        /// <inheritdoc cref="Information.FromMebibytes(double)"/>
        public static Information Mebibytes(this decimal value) => (Information)Information.FromMebibytes(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Megabit

        /// <inheritdoc cref="Information.FromMegabits(double)"/>
        public static Information Megabits(this int value) => (Information)Information.FromMegabits(value);
	
        /// <inheritdoc cref="Information.FromMegabits(double)"/>
        public static Information Megabits(this long value) => (Information)Information.FromMegabits(value);

        /// <inheritdoc cref="Information.FromMegabits(double)"/>
        public static Information Megabits(this double value) => (Information)Information.FromMegabits(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromMegabits(double)"/>
        public static Information Megabits(this float value) => (Information)Information.FromMegabits(value);

        /// <inheritdoc cref="Information.FromMegabits(double)"/>
        public static Information Megabits(this decimal value) => (Information)Information.FromMegabits(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Megabyte

        /// <inheritdoc cref="Information.FromMegabytes(double)"/>
        public static Information Megabytes(this int value) => (Information)Information.FromMegabytes(value);
	
        /// <inheritdoc cref="Information.FromMegabytes(double)"/>
        public static Information Megabytes(this long value) => (Information)Information.FromMegabytes(value);

        /// <inheritdoc cref="Information.FromMegabytes(double)"/>
        public static Information Megabytes(this double value) => (Information)Information.FromMegabytes(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromMegabytes(double)"/>
        public static Information Megabytes(this float value) => (Information)Information.FromMegabytes(value);

        /// <inheritdoc cref="Information.FromMegabytes(double)"/>
        public static Information Megabytes(this decimal value) => (Information)Information.FromMegabytes(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Pebibit

        /// <inheritdoc cref="Information.FromPebibits(double)"/>
        public static Information Pebibits(this int value) => (Information)Information.FromPebibits(value);
	
        /// <inheritdoc cref="Information.FromPebibits(double)"/>
        public static Information Pebibits(this long value) => (Information)Information.FromPebibits(value);

        /// <inheritdoc cref="Information.FromPebibits(double)"/>
        public static Information Pebibits(this double value) => (Information)Information.FromPebibits(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromPebibits(double)"/>
        public static Information Pebibits(this float value) => (Information)Information.FromPebibits(value);

        /// <inheritdoc cref="Information.FromPebibits(double)"/>
        public static Information Pebibits(this decimal value) => (Information)Information.FromPebibits(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Pebibyte

        /// <inheritdoc cref="Information.FromPebibytes(double)"/>
        public static Information Pebibytes(this int value) => (Information)Information.FromPebibytes(value);
	
        /// <inheritdoc cref="Information.FromPebibytes(double)"/>
        public static Information Pebibytes(this long value) => (Information)Information.FromPebibytes(value);

        /// <inheritdoc cref="Information.FromPebibytes(double)"/>
        public static Information Pebibytes(this double value) => (Information)Information.FromPebibytes(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromPebibytes(double)"/>
        public static Information Pebibytes(this float value) => (Information)Information.FromPebibytes(value);

        /// <inheritdoc cref="Information.FromPebibytes(double)"/>
        public static Information Pebibytes(this decimal value) => (Information)Information.FromPebibytes(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Petabit

        /// <inheritdoc cref="Information.FromPetabits(double)"/>
        public static Information Petabits(this int value) => (Information)Information.FromPetabits(value);
	
        /// <inheritdoc cref="Information.FromPetabits(double)"/>
        public static Information Petabits(this long value) => (Information)Information.FromPetabits(value);

        /// <inheritdoc cref="Information.FromPetabits(double)"/>
        public static Information Petabits(this double value) => (Information)Information.FromPetabits(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromPetabits(double)"/>
        public static Information Petabits(this float value) => (Information)Information.FromPetabits(value);

        /// <inheritdoc cref="Information.FromPetabits(double)"/>
        public static Information Petabits(this decimal value) => (Information)Information.FromPetabits(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Petabyte

        /// <inheritdoc cref="Information.FromPetabytes(double)"/>
        public static Information Petabytes(this int value) => (Information)Information.FromPetabytes(value);
	
        /// <inheritdoc cref="Information.FromPetabytes(double)"/>
        public static Information Petabytes(this long value) => (Information)Information.FromPetabytes(value);

        /// <inheritdoc cref="Information.FromPetabytes(double)"/>
        public static Information Petabytes(this double value) => (Information)Information.FromPetabytes(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromPetabytes(double)"/>
        public static Information Petabytes(this float value) => (Information)Information.FromPetabytes(value);

        /// <inheritdoc cref="Information.FromPetabytes(double)"/>
        public static Information Petabytes(this decimal value) => (Information)Information.FromPetabytes(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Tebibit

        /// <inheritdoc cref="Information.FromTebibits(double)"/>
        public static Information Tebibits(this int value) => (Information)Information.FromTebibits(value);
	
        /// <inheritdoc cref="Information.FromTebibits(double)"/>
        public static Information Tebibits(this long value) => (Information)Information.FromTebibits(value);

        /// <inheritdoc cref="Information.FromTebibits(double)"/>
        public static Information Tebibits(this double value) => (Information)Information.FromTebibits(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromTebibits(double)"/>
        public static Information Tebibits(this float value) => (Information)Information.FromTebibits(value);

        /// <inheritdoc cref="Information.FromTebibits(double)"/>
        public static Information Tebibits(this decimal value) => (Information)Information.FromTebibits(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Tebibyte

        /// <inheritdoc cref="Information.FromTebibytes(double)"/>
        public static Information Tebibytes(this int value) => (Information)Information.FromTebibytes(value);
	
        /// <inheritdoc cref="Information.FromTebibytes(double)"/>
        public static Information Tebibytes(this long value) => (Information)Information.FromTebibytes(value);

        /// <inheritdoc cref="Information.FromTebibytes(double)"/>
        public static Information Tebibytes(this double value) => (Information)Information.FromTebibytes(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromTebibytes(double)"/>
        public static Information Tebibytes(this float value) => (Information)Information.FromTebibytes(value);

        /// <inheritdoc cref="Information.FromTebibytes(double)"/>
        public static Information Tebibytes(this decimal value) => (Information)Information.FromTebibytes(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Terabit

        /// <inheritdoc cref="Information.FromTerabits(double)"/>
        public static Information Terabits(this int value) => (Information)Information.FromTerabits(value);
	
        /// <inheritdoc cref="Information.FromTerabits(double)"/>
        public static Information Terabits(this long value) => (Information)Information.FromTerabits(value);

        /// <inheritdoc cref="Information.FromTerabits(double)"/>
        public static Information Terabits(this double value) => (Information)Information.FromTerabits(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromTerabits(double)"/>
        public static Information Terabits(this float value) => (Information)Information.FromTerabits(value);

        /// <inheritdoc cref="Information.FromTerabits(double)"/>
        public static Information Terabits(this decimal value) => (Information)Information.FromTerabits(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Terabyte

        /// <inheritdoc cref="Information.FromTerabytes(double)"/>
        public static Information Terabytes(this int value) => (Information)Information.FromTerabytes(value);
	
        /// <inheritdoc cref="Information.FromTerabytes(double)"/>
        public static Information Terabytes(this long value) => (Information)Information.FromTerabytes(value);

        /// <inheritdoc cref="Information.FromTerabytes(double)"/>
        public static Information Terabytes(this double value) => (Information)Information.FromTerabytes(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Information.FromTerabytes(double)"/>
        public static Information Terabytes(this float value) => (Information)Information.FromTerabytes(value);

        /// <inheritdoc cref="Information.FromTerabytes(double)"/>
        public static Information Terabytes(this decimal value) => (Information)Information.FromTerabytes(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

    }
}
#endif
