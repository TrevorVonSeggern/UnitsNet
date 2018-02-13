<#
.SYNOPSIS
Generates the C# source code for logarithmic arithmetic operators.

.PARAMETER quantityName
The name of the unit.

.PARAMETER baseUnitFieldName
The name of the backing field used to store the unit's value.

.PARAMETER baseType
The data type of the backing field used to store the unit's value.

.PARAMETER scalingFactor
The scaling factor used in logarithmic calculations. In most cases this is equal to 1.
#>
function GenerateLogarithmicArithmeticOperators([string]$quantityName, [string]$baseUnitFieldName, [string]$baseType, [int]$scalingFactor)
{
    # Most logarithmic operators need a simple scaling factor of 10. However, certain units such as voltage ratio need to
    # use 20 instead of 10.
    $x = 10 * $scalingFactor;

@"

        #region Logarithmic Arithmetic Operators

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static $quantityName<T, C> operator -($quantityName<T, C> right)
        {
            return new $quantityName<T, C>(-right.$baseUnitFieldName);
        }

        public static $quantityName<T, C> operator +($quantityName<T, C> left, $quantityName<T, C> right)
        {
            // Logarithmic addition
            // Formula: $x*log10(10^(x/$x) + 10^(y/$x))
            return new $quantityName<T, C>($x*Math.Log10(Math.Pow(10, left.$baseUnitFieldName/$x) + Math.Pow(10, right.$baseUnitFieldName/$x)));
        }

        public static $quantityName<T, C> operator -($quantityName<T, C> left, $quantityName<T, C> right)
        {
            // Logarithmic subtraction
            // Formula: $x*log10(10^(x/$x) - 10^(y/$x))
            return new $quantityName<T, C>($x*Math.Log10(Math.Pow(10, left.$baseUnitFieldName/$x) - Math.Pow(10, right.$baseUnitFieldName/$x)));
        }

        public static $quantityName<T, C> operator *($baseType left, $quantityName<T, C> right)
        {
            // Logarithmic multiplication = addition
            return new $quantityName<T, C>(left + right.$baseUnitFieldName);
        }

        public static $quantityName<T, C> operator *($quantityName<T, C> left, double right)
        {
            // Logarithmic multiplication = addition
            return new $quantityName<T, C>(left.$baseUnitFieldName + ($baseType)right);
        }

        public static $quantityName<T, C> operator /($quantityName<T, C> left, double right)
        {
            // Logarithmic division = subtraction
            return new $quantityName<T, C>(left.$baseUnitFieldName - ($baseType)right);
        }

        public static double operator /($quantityName<T, C> left, $quantityName<T, C> right)
        {
            // Logarithmic division = subtraction
            return Convert.ToDouble(left.$baseUnitFieldName - right.$baseUnitFieldName);
        }
#endif

        #endregion
"@;
}
