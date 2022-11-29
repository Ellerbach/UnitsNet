//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     An electric field is a force field that surrounds electric charges that attracts or repels other electric charges.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Electric_field
    /// </remarks>
    public struct  ElectricField
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricFieldUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ElectricFieldUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ElectricField(double value, ElectricFieldUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricFieldUnit BaseUnit { get; } = ElectricFieldUnit.VoltPerMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ElectricField MaxValue { get; } = new ElectricField(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ElectricField MinValue { get; } = new ElectricField(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricField Zero { get; } = new ElectricField(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricFieldUnit.VoltPerMeter"/>
        /// </summary>
        public double VoltsPerMeter => As(ElectricFieldUnit.VoltPerMeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ElectricField"/> from <see cref="ElectricFieldUnit.VoltPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricField FromVoltsPerMeter(double voltspermeter) => new ElectricField(voltspermeter, ElectricFieldUnit.VoltPerMeter);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricFieldUnit" /> to <see cref="ElectricField" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricField unit value.</returns>
        public static ElectricField From(double value, ElectricFieldUnit fromUnit)
        {
            return new ElectricField(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(ElectricFieldUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A Duration with the specified unit.</returns>
                public ElectricField ToUnit(ElectricFieldUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new ElectricField(convertedValue, unit);
                }

                /// <summary>
                ///     Converts the current value + unit to the base unit.
                ///     This is typically the first step in converting from one unit to another.
                /// </summary>
                /// <returns>The value in the base unit representation.</returns>
                private double GetValueInBaseUnit()
                {
                    return Unit switch
                    {
                        ElectricFieldUnit.VoltPerMeter => _value,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(ElectricFieldUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        ElectricFieldUnit.VoltPerMeter => baseUnitValue,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

