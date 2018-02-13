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
namespace UnitsNet.Extensions.NumberToMass
{
    public static class NumberToMassExtensions
    {
        #region Centigram

        /// <inheritdoc cref="Mass.FromCentigrams(double)"/>
        public static Mass Centigrams(this int value) => (Mass)Mass.FromCentigrams(value);
	
        /// <inheritdoc cref="Mass.FromCentigrams(double)"/>
        public static Mass Centigrams(this long value) => (Mass)Mass.FromCentigrams(value);

        /// <inheritdoc cref="Mass.FromCentigrams(double)"/>
        public static Mass Centigrams(this double value) => (Mass)Mass.FromCentigrams(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromCentigrams(double)"/>
        public static Mass Centigrams(this float value) => (Mass)Mass.FromCentigrams(value);

        /// <inheritdoc cref="Mass.FromCentigrams(double)"/>
        public static Mass Centigrams(this decimal value) => (Mass)Mass.FromCentigrams(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Decagram

        /// <inheritdoc cref="Mass.FromDecagrams(double)"/>
        public static Mass Decagrams(this int value) => (Mass)Mass.FromDecagrams(value);
	
        /// <inheritdoc cref="Mass.FromDecagrams(double)"/>
        public static Mass Decagrams(this long value) => (Mass)Mass.FromDecagrams(value);

        /// <inheritdoc cref="Mass.FromDecagrams(double)"/>
        public static Mass Decagrams(this double value) => (Mass)Mass.FromDecagrams(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromDecagrams(double)"/>
        public static Mass Decagrams(this float value) => (Mass)Mass.FromDecagrams(value);

        /// <inheritdoc cref="Mass.FromDecagrams(double)"/>
        public static Mass Decagrams(this decimal value) => (Mass)Mass.FromDecagrams(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Decigram

        /// <inheritdoc cref="Mass.FromDecigrams(double)"/>
        public static Mass Decigrams(this int value) => (Mass)Mass.FromDecigrams(value);
	
        /// <inheritdoc cref="Mass.FromDecigrams(double)"/>
        public static Mass Decigrams(this long value) => (Mass)Mass.FromDecigrams(value);

        /// <inheritdoc cref="Mass.FromDecigrams(double)"/>
        public static Mass Decigrams(this double value) => (Mass)Mass.FromDecigrams(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromDecigrams(double)"/>
        public static Mass Decigrams(this float value) => (Mass)Mass.FromDecigrams(value);

        /// <inheritdoc cref="Mass.FromDecigrams(double)"/>
        public static Mass Decigrams(this decimal value) => (Mass)Mass.FromDecigrams(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Gram

        /// <inheritdoc cref="Mass.FromGrams(double)"/>
        public static Mass Grams(this int value) => (Mass)Mass.FromGrams(value);
	
        /// <inheritdoc cref="Mass.FromGrams(double)"/>
        public static Mass Grams(this long value) => (Mass)Mass.FromGrams(value);

        /// <inheritdoc cref="Mass.FromGrams(double)"/>
        public static Mass Grams(this double value) => (Mass)Mass.FromGrams(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromGrams(double)"/>
        public static Mass Grams(this float value) => (Mass)Mass.FromGrams(value);

        /// <inheritdoc cref="Mass.FromGrams(double)"/>
        public static Mass Grams(this decimal value) => (Mass)Mass.FromGrams(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Hectogram

        /// <inheritdoc cref="Mass.FromHectograms(double)"/>
        public static Mass Hectograms(this int value) => (Mass)Mass.FromHectograms(value);
	
        /// <inheritdoc cref="Mass.FromHectograms(double)"/>
        public static Mass Hectograms(this long value) => (Mass)Mass.FromHectograms(value);

        /// <inheritdoc cref="Mass.FromHectograms(double)"/>
        public static Mass Hectograms(this double value) => (Mass)Mass.FromHectograms(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromHectograms(double)"/>
        public static Mass Hectograms(this float value) => (Mass)Mass.FromHectograms(value);

        /// <inheritdoc cref="Mass.FromHectograms(double)"/>
        public static Mass Hectograms(this decimal value) => (Mass)Mass.FromHectograms(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Kilogram

        /// <inheritdoc cref="Mass.FromKilograms(double)"/>
        public static Mass Kilograms(this int value) => (Mass)Mass.FromKilograms(value);
	
        /// <inheritdoc cref="Mass.FromKilograms(double)"/>
        public static Mass Kilograms(this long value) => (Mass)Mass.FromKilograms(value);

        /// <inheritdoc cref="Mass.FromKilograms(double)"/>
        public static Mass Kilograms(this double value) => (Mass)Mass.FromKilograms(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromKilograms(double)"/>
        public static Mass Kilograms(this float value) => (Mass)Mass.FromKilograms(value);

        /// <inheritdoc cref="Mass.FromKilograms(double)"/>
        public static Mass Kilograms(this decimal value) => (Mass)Mass.FromKilograms(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Kilopound

        /// <inheritdoc cref="Mass.FromKilopounds(double)"/>
        public static Mass Kilopounds(this int value) => (Mass)Mass.FromKilopounds(value);
	
        /// <inheritdoc cref="Mass.FromKilopounds(double)"/>
        public static Mass Kilopounds(this long value) => (Mass)Mass.FromKilopounds(value);

        /// <inheritdoc cref="Mass.FromKilopounds(double)"/>
        public static Mass Kilopounds(this double value) => (Mass)Mass.FromKilopounds(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromKilopounds(double)"/>
        public static Mass Kilopounds(this float value) => (Mass)Mass.FromKilopounds(value);

        /// <inheritdoc cref="Mass.FromKilopounds(double)"/>
        public static Mass Kilopounds(this decimal value) => (Mass)Mass.FromKilopounds(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Kilotonne

        /// <inheritdoc cref="Mass.FromKilotonnes(double)"/>
        public static Mass Kilotonnes(this int value) => (Mass)Mass.FromKilotonnes(value);
	
        /// <inheritdoc cref="Mass.FromKilotonnes(double)"/>
        public static Mass Kilotonnes(this long value) => (Mass)Mass.FromKilotonnes(value);

        /// <inheritdoc cref="Mass.FromKilotonnes(double)"/>
        public static Mass Kilotonnes(this double value) => (Mass)Mass.FromKilotonnes(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromKilotonnes(double)"/>
        public static Mass Kilotonnes(this float value) => (Mass)Mass.FromKilotonnes(value);

        /// <inheritdoc cref="Mass.FromKilotonnes(double)"/>
        public static Mass Kilotonnes(this decimal value) => (Mass)Mass.FromKilotonnes(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region LongHundredweight

        /// <inheritdoc cref="Mass.FromLongHundredweight(double)"/>
        public static Mass LongHundredweight(this int value) => (Mass)Mass.FromLongHundredweight(value);
	
        /// <inheritdoc cref="Mass.FromLongHundredweight(double)"/>
        public static Mass LongHundredweight(this long value) => (Mass)Mass.FromLongHundredweight(value);

        /// <inheritdoc cref="Mass.FromLongHundredweight(double)"/>
        public static Mass LongHundredweight(this double value) => (Mass)Mass.FromLongHundredweight(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromLongHundredweight(double)"/>
        public static Mass LongHundredweight(this float value) => (Mass)Mass.FromLongHundredweight(value);

        /// <inheritdoc cref="Mass.FromLongHundredweight(double)"/>
        public static Mass LongHundredweight(this decimal value) => (Mass)Mass.FromLongHundredweight(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region LongTon

        /// <inheritdoc cref="Mass.FromLongTons(double)"/>
        public static Mass LongTons(this int value) => (Mass)Mass.FromLongTons(value);
	
        /// <inheritdoc cref="Mass.FromLongTons(double)"/>
        public static Mass LongTons(this long value) => (Mass)Mass.FromLongTons(value);

        /// <inheritdoc cref="Mass.FromLongTons(double)"/>
        public static Mass LongTons(this double value) => (Mass)Mass.FromLongTons(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromLongTons(double)"/>
        public static Mass LongTons(this float value) => (Mass)Mass.FromLongTons(value);

        /// <inheritdoc cref="Mass.FromLongTons(double)"/>
        public static Mass LongTons(this decimal value) => (Mass)Mass.FromLongTons(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Megapound

        /// <inheritdoc cref="Mass.FromMegapounds(double)"/>
        public static Mass Megapounds(this int value) => (Mass)Mass.FromMegapounds(value);
	
        /// <inheritdoc cref="Mass.FromMegapounds(double)"/>
        public static Mass Megapounds(this long value) => (Mass)Mass.FromMegapounds(value);

        /// <inheritdoc cref="Mass.FromMegapounds(double)"/>
        public static Mass Megapounds(this double value) => (Mass)Mass.FromMegapounds(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromMegapounds(double)"/>
        public static Mass Megapounds(this float value) => (Mass)Mass.FromMegapounds(value);

        /// <inheritdoc cref="Mass.FromMegapounds(double)"/>
        public static Mass Megapounds(this decimal value) => (Mass)Mass.FromMegapounds(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Megatonne

        /// <inheritdoc cref="Mass.FromMegatonnes(double)"/>
        public static Mass Megatonnes(this int value) => (Mass)Mass.FromMegatonnes(value);
	
        /// <inheritdoc cref="Mass.FromMegatonnes(double)"/>
        public static Mass Megatonnes(this long value) => (Mass)Mass.FromMegatonnes(value);

        /// <inheritdoc cref="Mass.FromMegatonnes(double)"/>
        public static Mass Megatonnes(this double value) => (Mass)Mass.FromMegatonnes(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromMegatonnes(double)"/>
        public static Mass Megatonnes(this float value) => (Mass)Mass.FromMegatonnes(value);

        /// <inheritdoc cref="Mass.FromMegatonnes(double)"/>
        public static Mass Megatonnes(this decimal value) => (Mass)Mass.FromMegatonnes(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Microgram

        /// <inheritdoc cref="Mass.FromMicrograms(double)"/>
        public static Mass Micrograms(this int value) => (Mass)Mass.FromMicrograms(value);
	
        /// <inheritdoc cref="Mass.FromMicrograms(double)"/>
        public static Mass Micrograms(this long value) => (Mass)Mass.FromMicrograms(value);

        /// <inheritdoc cref="Mass.FromMicrograms(double)"/>
        public static Mass Micrograms(this double value) => (Mass)Mass.FromMicrograms(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromMicrograms(double)"/>
        public static Mass Micrograms(this float value) => (Mass)Mass.FromMicrograms(value);

        /// <inheritdoc cref="Mass.FromMicrograms(double)"/>
        public static Mass Micrograms(this decimal value) => (Mass)Mass.FromMicrograms(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Milligram

        /// <inheritdoc cref="Mass.FromMilligrams(double)"/>
        public static Mass Milligrams(this int value) => (Mass)Mass.FromMilligrams(value);
	
        /// <inheritdoc cref="Mass.FromMilligrams(double)"/>
        public static Mass Milligrams(this long value) => (Mass)Mass.FromMilligrams(value);

        /// <inheritdoc cref="Mass.FromMilligrams(double)"/>
        public static Mass Milligrams(this double value) => (Mass)Mass.FromMilligrams(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromMilligrams(double)"/>
        public static Mass Milligrams(this float value) => (Mass)Mass.FromMilligrams(value);

        /// <inheritdoc cref="Mass.FromMilligrams(double)"/>
        public static Mass Milligrams(this decimal value) => (Mass)Mass.FromMilligrams(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Nanogram

        /// <inheritdoc cref="Mass.FromNanograms(double)"/>
        public static Mass Nanograms(this int value) => (Mass)Mass.FromNanograms(value);
	
        /// <inheritdoc cref="Mass.FromNanograms(double)"/>
        public static Mass Nanograms(this long value) => (Mass)Mass.FromNanograms(value);

        /// <inheritdoc cref="Mass.FromNanograms(double)"/>
        public static Mass Nanograms(this double value) => (Mass)Mass.FromNanograms(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromNanograms(double)"/>
        public static Mass Nanograms(this float value) => (Mass)Mass.FromNanograms(value);

        /// <inheritdoc cref="Mass.FromNanograms(double)"/>
        public static Mass Nanograms(this decimal value) => (Mass)Mass.FromNanograms(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Ounce

        /// <inheritdoc cref="Mass.FromOunces(double)"/>
        public static Mass Ounces(this int value) => (Mass)Mass.FromOunces(value);
	
        /// <inheritdoc cref="Mass.FromOunces(double)"/>
        public static Mass Ounces(this long value) => (Mass)Mass.FromOunces(value);

        /// <inheritdoc cref="Mass.FromOunces(double)"/>
        public static Mass Ounces(this double value) => (Mass)Mass.FromOunces(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromOunces(double)"/>
        public static Mass Ounces(this float value) => (Mass)Mass.FromOunces(value);

        /// <inheritdoc cref="Mass.FromOunces(double)"/>
        public static Mass Ounces(this decimal value) => (Mass)Mass.FromOunces(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Pound

        /// <inheritdoc cref="Mass.FromPounds(double)"/>
        public static Mass Pounds(this int value) => (Mass)Mass.FromPounds(value);
	
        /// <inheritdoc cref="Mass.FromPounds(double)"/>
        public static Mass Pounds(this long value) => (Mass)Mass.FromPounds(value);

        /// <inheritdoc cref="Mass.FromPounds(double)"/>
        public static Mass Pounds(this double value) => (Mass)Mass.FromPounds(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromPounds(double)"/>
        public static Mass Pounds(this float value) => (Mass)Mass.FromPounds(value);

        /// <inheritdoc cref="Mass.FromPounds(double)"/>
        public static Mass Pounds(this decimal value) => (Mass)Mass.FromPounds(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region ShortHundredweight

        /// <inheritdoc cref="Mass.FromShortHundredweight(double)"/>
        public static Mass ShortHundredweight(this int value) => (Mass)Mass.FromShortHundredweight(value);
	
        /// <inheritdoc cref="Mass.FromShortHundredweight(double)"/>
        public static Mass ShortHundredweight(this long value) => (Mass)Mass.FromShortHundredweight(value);

        /// <inheritdoc cref="Mass.FromShortHundredweight(double)"/>
        public static Mass ShortHundredweight(this double value) => (Mass)Mass.FromShortHundredweight(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromShortHundredweight(double)"/>
        public static Mass ShortHundredweight(this float value) => (Mass)Mass.FromShortHundredweight(value);

        /// <inheritdoc cref="Mass.FromShortHundredweight(double)"/>
        public static Mass ShortHundredweight(this decimal value) => (Mass)Mass.FromShortHundredweight(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region ShortTon

        /// <inheritdoc cref="Mass.FromShortTons(double)"/>
        public static Mass ShortTons(this int value) => (Mass)Mass.FromShortTons(value);
	
        /// <inheritdoc cref="Mass.FromShortTons(double)"/>
        public static Mass ShortTons(this long value) => (Mass)Mass.FromShortTons(value);

        /// <inheritdoc cref="Mass.FromShortTons(double)"/>
        public static Mass ShortTons(this double value) => (Mass)Mass.FromShortTons(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromShortTons(double)"/>
        public static Mass ShortTons(this float value) => (Mass)Mass.FromShortTons(value);

        /// <inheritdoc cref="Mass.FromShortTons(double)"/>
        public static Mass ShortTons(this decimal value) => (Mass)Mass.FromShortTons(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Stone

        /// <inheritdoc cref="Mass.FromStone(double)"/>
        public static Mass Stone(this int value) => (Mass)Mass.FromStone(value);
	
        /// <inheritdoc cref="Mass.FromStone(double)"/>
        public static Mass Stone(this long value) => (Mass)Mass.FromStone(value);

        /// <inheritdoc cref="Mass.FromStone(double)"/>
        public static Mass Stone(this double value) => (Mass)Mass.FromStone(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromStone(double)"/>
        public static Mass Stone(this float value) => (Mass)Mass.FromStone(value);

        /// <inheritdoc cref="Mass.FromStone(double)"/>
        public static Mass Stone(this decimal value) => (Mass)Mass.FromStone(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region Tonne

        /// <inheritdoc cref="Mass.FromTonnes(double)"/>
        public static Mass Tonnes(this int value) => (Mass)Mass.FromTonnes(value);
	
        /// <inheritdoc cref="Mass.FromTonnes(double)"/>
        public static Mass Tonnes(this long value) => (Mass)Mass.FromTonnes(value);

        /// <inheritdoc cref="Mass.FromTonnes(double)"/>
        public static Mass Tonnes(this double value) => (Mass)Mass.FromTonnes(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="Mass.FromTonnes(double)"/>
        public static Mass Tonnes(this float value) => (Mass)Mass.FromTonnes(value);

        /// <inheritdoc cref="Mass.FromTonnes(double)"/>
        public static Mass Tonnes(this decimal value) => (Mass)Mass.FromTonnes(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

    }
}
#endif
