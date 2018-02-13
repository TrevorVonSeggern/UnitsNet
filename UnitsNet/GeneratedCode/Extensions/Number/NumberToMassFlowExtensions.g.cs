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
namespace UnitsNet.Extensions.NumberToMassFlow
{
    public static class NumberToMassFlowExtensions
    {
        #region CentigramPerSecond

        /// <inheritdoc cref="MassFlow.FromCentigramsPerSecond(double)"/>
        public static MassFlow CentigramsPerSecond(this int value) => (MassFlow)MassFlow.FromCentigramsPerSecond(value);
	
        /// <inheritdoc cref="MassFlow.FromCentigramsPerSecond(double)"/>
        public static MassFlow CentigramsPerSecond(this long value) => (MassFlow)MassFlow.FromCentigramsPerSecond(value);

        /// <inheritdoc cref="MassFlow.FromCentigramsPerSecond(double)"/>
        public static MassFlow CentigramsPerSecond(this double value) => (MassFlow)MassFlow.FromCentigramsPerSecond(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="MassFlow.FromCentigramsPerSecond(double)"/>
        public static MassFlow CentigramsPerSecond(this float value) => (MassFlow)MassFlow.FromCentigramsPerSecond(value);

        /// <inheritdoc cref="MassFlow.FromCentigramsPerSecond(double)"/>
        public static MassFlow CentigramsPerSecond(this decimal value) => (MassFlow)MassFlow.FromCentigramsPerSecond(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region DecagramPerSecond

        /// <inheritdoc cref="MassFlow.FromDecagramsPerSecond(double)"/>
        public static MassFlow DecagramsPerSecond(this int value) => (MassFlow)MassFlow.FromDecagramsPerSecond(value);
	
        /// <inheritdoc cref="MassFlow.FromDecagramsPerSecond(double)"/>
        public static MassFlow DecagramsPerSecond(this long value) => (MassFlow)MassFlow.FromDecagramsPerSecond(value);

        /// <inheritdoc cref="MassFlow.FromDecagramsPerSecond(double)"/>
        public static MassFlow DecagramsPerSecond(this double value) => (MassFlow)MassFlow.FromDecagramsPerSecond(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="MassFlow.FromDecagramsPerSecond(double)"/>
        public static MassFlow DecagramsPerSecond(this float value) => (MassFlow)MassFlow.FromDecagramsPerSecond(value);

        /// <inheritdoc cref="MassFlow.FromDecagramsPerSecond(double)"/>
        public static MassFlow DecagramsPerSecond(this decimal value) => (MassFlow)MassFlow.FromDecagramsPerSecond(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region DecigramPerSecond

        /// <inheritdoc cref="MassFlow.FromDecigramsPerSecond(double)"/>
        public static MassFlow DecigramsPerSecond(this int value) => (MassFlow)MassFlow.FromDecigramsPerSecond(value);
	
        /// <inheritdoc cref="MassFlow.FromDecigramsPerSecond(double)"/>
        public static MassFlow DecigramsPerSecond(this long value) => (MassFlow)MassFlow.FromDecigramsPerSecond(value);

        /// <inheritdoc cref="MassFlow.FromDecigramsPerSecond(double)"/>
        public static MassFlow DecigramsPerSecond(this double value) => (MassFlow)MassFlow.FromDecigramsPerSecond(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="MassFlow.FromDecigramsPerSecond(double)"/>
        public static MassFlow DecigramsPerSecond(this float value) => (MassFlow)MassFlow.FromDecigramsPerSecond(value);

        /// <inheritdoc cref="MassFlow.FromDecigramsPerSecond(double)"/>
        public static MassFlow DecigramsPerSecond(this decimal value) => (MassFlow)MassFlow.FromDecigramsPerSecond(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region GramPerSecond

        /// <inheritdoc cref="MassFlow.FromGramsPerSecond(double)"/>
        public static MassFlow GramsPerSecond(this int value) => (MassFlow)MassFlow.FromGramsPerSecond(value);
	
        /// <inheritdoc cref="MassFlow.FromGramsPerSecond(double)"/>
        public static MassFlow GramsPerSecond(this long value) => (MassFlow)MassFlow.FromGramsPerSecond(value);

        /// <inheritdoc cref="MassFlow.FromGramsPerSecond(double)"/>
        public static MassFlow GramsPerSecond(this double value) => (MassFlow)MassFlow.FromGramsPerSecond(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="MassFlow.FromGramsPerSecond(double)"/>
        public static MassFlow GramsPerSecond(this float value) => (MassFlow)MassFlow.FromGramsPerSecond(value);

        /// <inheritdoc cref="MassFlow.FromGramsPerSecond(double)"/>
        public static MassFlow GramsPerSecond(this decimal value) => (MassFlow)MassFlow.FromGramsPerSecond(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region HectogramPerSecond

        /// <inheritdoc cref="MassFlow.FromHectogramsPerSecond(double)"/>
        public static MassFlow HectogramsPerSecond(this int value) => (MassFlow)MassFlow.FromHectogramsPerSecond(value);
	
        /// <inheritdoc cref="MassFlow.FromHectogramsPerSecond(double)"/>
        public static MassFlow HectogramsPerSecond(this long value) => (MassFlow)MassFlow.FromHectogramsPerSecond(value);

        /// <inheritdoc cref="MassFlow.FromHectogramsPerSecond(double)"/>
        public static MassFlow HectogramsPerSecond(this double value) => (MassFlow)MassFlow.FromHectogramsPerSecond(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="MassFlow.FromHectogramsPerSecond(double)"/>
        public static MassFlow HectogramsPerSecond(this float value) => (MassFlow)MassFlow.FromHectogramsPerSecond(value);

        /// <inheritdoc cref="MassFlow.FromHectogramsPerSecond(double)"/>
        public static MassFlow HectogramsPerSecond(this decimal value) => (MassFlow)MassFlow.FromHectogramsPerSecond(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region KilogramPerHour

        /// <inheritdoc cref="MassFlow.FromKilogramsPerHour(double)"/>
        public static MassFlow KilogramsPerHour(this int value) => (MassFlow)MassFlow.FromKilogramsPerHour(value);
	
        /// <inheritdoc cref="MassFlow.FromKilogramsPerHour(double)"/>
        public static MassFlow KilogramsPerHour(this long value) => (MassFlow)MassFlow.FromKilogramsPerHour(value);

        /// <inheritdoc cref="MassFlow.FromKilogramsPerHour(double)"/>
        public static MassFlow KilogramsPerHour(this double value) => (MassFlow)MassFlow.FromKilogramsPerHour(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="MassFlow.FromKilogramsPerHour(double)"/>
        public static MassFlow KilogramsPerHour(this float value) => (MassFlow)MassFlow.FromKilogramsPerHour(value);

        /// <inheritdoc cref="MassFlow.FromKilogramsPerHour(double)"/>
        public static MassFlow KilogramsPerHour(this decimal value) => (MassFlow)MassFlow.FromKilogramsPerHour(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region KilogramPerSecond

        /// <inheritdoc cref="MassFlow.FromKilogramsPerSecond(double)"/>
        public static MassFlow KilogramsPerSecond(this int value) => (MassFlow)MassFlow.FromKilogramsPerSecond(value);
	
        /// <inheritdoc cref="MassFlow.FromKilogramsPerSecond(double)"/>
        public static MassFlow KilogramsPerSecond(this long value) => (MassFlow)MassFlow.FromKilogramsPerSecond(value);

        /// <inheritdoc cref="MassFlow.FromKilogramsPerSecond(double)"/>
        public static MassFlow KilogramsPerSecond(this double value) => (MassFlow)MassFlow.FromKilogramsPerSecond(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="MassFlow.FromKilogramsPerSecond(double)"/>
        public static MassFlow KilogramsPerSecond(this float value) => (MassFlow)MassFlow.FromKilogramsPerSecond(value);

        /// <inheritdoc cref="MassFlow.FromKilogramsPerSecond(double)"/>
        public static MassFlow KilogramsPerSecond(this decimal value) => (MassFlow)MassFlow.FromKilogramsPerSecond(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region MegapoundPerHour

        /// <inheritdoc cref="MassFlow.FromMegapoundsPerHour(double)"/>
        public static MassFlow MegapoundsPerHour(this int value) => (MassFlow)MassFlow.FromMegapoundsPerHour(value);
	
        /// <inheritdoc cref="MassFlow.FromMegapoundsPerHour(double)"/>
        public static MassFlow MegapoundsPerHour(this long value) => (MassFlow)MassFlow.FromMegapoundsPerHour(value);

        /// <inheritdoc cref="MassFlow.FromMegapoundsPerHour(double)"/>
        public static MassFlow MegapoundsPerHour(this double value) => (MassFlow)MassFlow.FromMegapoundsPerHour(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="MassFlow.FromMegapoundsPerHour(double)"/>
        public static MassFlow MegapoundsPerHour(this float value) => (MassFlow)MassFlow.FromMegapoundsPerHour(value);

        /// <inheritdoc cref="MassFlow.FromMegapoundsPerHour(double)"/>
        public static MassFlow MegapoundsPerHour(this decimal value) => (MassFlow)MassFlow.FromMegapoundsPerHour(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region MicrogramPerSecond

        /// <inheritdoc cref="MassFlow.FromMicrogramsPerSecond(double)"/>
        public static MassFlow MicrogramsPerSecond(this int value) => (MassFlow)MassFlow.FromMicrogramsPerSecond(value);
	
        /// <inheritdoc cref="MassFlow.FromMicrogramsPerSecond(double)"/>
        public static MassFlow MicrogramsPerSecond(this long value) => (MassFlow)MassFlow.FromMicrogramsPerSecond(value);

        /// <inheritdoc cref="MassFlow.FromMicrogramsPerSecond(double)"/>
        public static MassFlow MicrogramsPerSecond(this double value) => (MassFlow)MassFlow.FromMicrogramsPerSecond(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="MassFlow.FromMicrogramsPerSecond(double)"/>
        public static MassFlow MicrogramsPerSecond(this float value) => (MassFlow)MassFlow.FromMicrogramsPerSecond(value);

        /// <inheritdoc cref="MassFlow.FromMicrogramsPerSecond(double)"/>
        public static MassFlow MicrogramsPerSecond(this decimal value) => (MassFlow)MassFlow.FromMicrogramsPerSecond(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region MilligramPerSecond

        /// <inheritdoc cref="MassFlow.FromMilligramsPerSecond(double)"/>
        public static MassFlow MilligramsPerSecond(this int value) => (MassFlow)MassFlow.FromMilligramsPerSecond(value);
	
        /// <inheritdoc cref="MassFlow.FromMilligramsPerSecond(double)"/>
        public static MassFlow MilligramsPerSecond(this long value) => (MassFlow)MassFlow.FromMilligramsPerSecond(value);

        /// <inheritdoc cref="MassFlow.FromMilligramsPerSecond(double)"/>
        public static MassFlow MilligramsPerSecond(this double value) => (MassFlow)MassFlow.FromMilligramsPerSecond(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="MassFlow.FromMilligramsPerSecond(double)"/>
        public static MassFlow MilligramsPerSecond(this float value) => (MassFlow)MassFlow.FromMilligramsPerSecond(value);

        /// <inheritdoc cref="MassFlow.FromMilligramsPerSecond(double)"/>
        public static MassFlow MilligramsPerSecond(this decimal value) => (MassFlow)MassFlow.FromMilligramsPerSecond(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region NanogramPerSecond

        /// <inheritdoc cref="MassFlow.FromNanogramsPerSecond(double)"/>
        public static MassFlow NanogramsPerSecond(this int value) => (MassFlow)MassFlow.FromNanogramsPerSecond(value);
	
        /// <inheritdoc cref="MassFlow.FromNanogramsPerSecond(double)"/>
        public static MassFlow NanogramsPerSecond(this long value) => (MassFlow)MassFlow.FromNanogramsPerSecond(value);

        /// <inheritdoc cref="MassFlow.FromNanogramsPerSecond(double)"/>
        public static MassFlow NanogramsPerSecond(this double value) => (MassFlow)MassFlow.FromNanogramsPerSecond(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="MassFlow.FromNanogramsPerSecond(double)"/>
        public static MassFlow NanogramsPerSecond(this float value) => (MassFlow)MassFlow.FromNanogramsPerSecond(value);

        /// <inheritdoc cref="MassFlow.FromNanogramsPerSecond(double)"/>
        public static MassFlow NanogramsPerSecond(this decimal value) => (MassFlow)MassFlow.FromNanogramsPerSecond(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region PoundPerHour

        /// <inheritdoc cref="MassFlow.FromPoundsPerHour(double)"/>
        public static MassFlow PoundsPerHour(this int value) => (MassFlow)MassFlow.FromPoundsPerHour(value);
	
        /// <inheritdoc cref="MassFlow.FromPoundsPerHour(double)"/>
        public static MassFlow PoundsPerHour(this long value) => (MassFlow)MassFlow.FromPoundsPerHour(value);

        /// <inheritdoc cref="MassFlow.FromPoundsPerHour(double)"/>
        public static MassFlow PoundsPerHour(this double value) => (MassFlow)MassFlow.FromPoundsPerHour(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="MassFlow.FromPoundsPerHour(double)"/>
        public static MassFlow PoundsPerHour(this float value) => (MassFlow)MassFlow.FromPoundsPerHour(value);

        /// <inheritdoc cref="MassFlow.FromPoundsPerHour(double)"/>
        public static MassFlow PoundsPerHour(this decimal value) => (MassFlow)MassFlow.FromPoundsPerHour(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region ShortTonPerHour

        /// <inheritdoc cref="MassFlow.FromShortTonsPerHour(double)"/>
        public static MassFlow ShortTonsPerHour(this int value) => (MassFlow)MassFlow.FromShortTonsPerHour(value);
	
        /// <inheritdoc cref="MassFlow.FromShortTonsPerHour(double)"/>
        public static MassFlow ShortTonsPerHour(this long value) => (MassFlow)MassFlow.FromShortTonsPerHour(value);

        /// <inheritdoc cref="MassFlow.FromShortTonsPerHour(double)"/>
        public static MassFlow ShortTonsPerHour(this double value) => (MassFlow)MassFlow.FromShortTonsPerHour(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="MassFlow.FromShortTonsPerHour(double)"/>
        public static MassFlow ShortTonsPerHour(this float value) => (MassFlow)MassFlow.FromShortTonsPerHour(value);

        /// <inheritdoc cref="MassFlow.FromShortTonsPerHour(double)"/>
        public static MassFlow ShortTonsPerHour(this decimal value) => (MassFlow)MassFlow.FromShortTonsPerHour(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

        #region TonnePerDay

        /// <inheritdoc cref="MassFlow.FromTonnesPerDay(double)"/>
        public static MassFlow TonnesPerDay(this int value) => (MassFlow)MassFlow.FromTonnesPerDay(value);
	
        /// <inheritdoc cref="MassFlow.FromTonnesPerDay(double)"/>
        public static MassFlow TonnesPerDay(this long value) => (MassFlow)MassFlow.FromTonnesPerDay(value);

        /// <inheritdoc cref="MassFlow.FromTonnesPerDay(double)"/>
        public static MassFlow TonnesPerDay(this double value) => (MassFlow)MassFlow.FromTonnesPerDay(new Number<double, DoubleCalculator>(value));

        /// <inheritdoc cref="MassFlow.FromTonnesPerDay(double)"/>
        public static MassFlow TonnesPerDay(this float value) => (MassFlow)MassFlow.FromTonnesPerDay(value);

        /// <inheritdoc cref="MassFlow.FromTonnesPerDay(double)"/>
        public static MassFlow TonnesPerDay(this decimal value) => (MassFlow)MassFlow.FromTonnesPerDay(new Number<double, DoubleCalculator>(Decimal.ToDouble(value)));

        #endregion

    }
}
#endif
