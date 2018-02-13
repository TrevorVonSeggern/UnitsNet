using System;

namespace UnitsNet.Generic
{
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class Molarity
#else
    public partial class Molarity<T, C>
            where T : struct
            where C : InternalHelpers.Calculators.INumberCalculator<T>, new()
#endif
    {
        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
            Molarity(Density<T, C> density, Mass<T, C> molecularWeight)
            : this()
        {
            _molesPerCubicMeter = density.KilogramsPerCubicMeter / molecularWeight.Kilograms;
        }

        /// <summary>
        ///     Get <see cref="Molarity"/> from <see cref="Density"/>.
        /// </summary>
        /// <param name="density"></param>
        /// <param name="molecularWeight"></param>
        public static Molarity<T, C> FromDensity(Density<T, C> density, Mass<T, C> molecularWeight)
        {
            return new Molarity<T, C>(density, molecularWeight);
        }

        /// <summary>
        ///     Get <see cref="Density"/> from <see cref="Molarity"/>.
        /// </summary>
        /// <param name="molarity"></param>
        /// <param name="molecularWeight"></param>
        /// <returns></returns>
        public static Density<T, C> ToDensity(Molarity<T, C> molarity, Mass<T, C> molecularWeight)
        {
            return Density<T, C>.FromKilogramsPerCubicMeter(molarity.MolesPerCubicMeter * molecularWeight.Kilograms);
        }
    }
}
