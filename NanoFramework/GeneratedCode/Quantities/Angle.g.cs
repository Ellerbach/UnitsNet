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
    ///     In geometry, an angle is the figure formed by two rays, called the sides of the angle, sharing a common endpoint, called the vertex of the angle.
    /// </summary>
    public struct  Angle
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly AngleUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public AngleUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Angle(double value, AngleUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static AngleUnit BaseUnit { get; } = AngleUnit.Degree;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Angle MaxValue { get; } = new Angle(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Angle MinValue { get; } = new Angle(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Angle Zero { get; } = new Angle(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get Angle in Arcminutes.
        /// </summary>
        public double Arcminutes => As(AngleUnit.Arcminute);

        /// <summary>
        ///     Get Angle in Arcseconds.
        /// </summary>
        public double Arcseconds => As(AngleUnit.Arcsecond);

        /// <summary>
        ///     Get Angle in Centiradians.
        /// </summary>
        public double Centiradians => As(AngleUnit.Centiradian);

        /// <summary>
        ///     Get Angle in Deciradians.
        /// </summary>
        public double Deciradians => As(AngleUnit.Deciradian);

        /// <summary>
        ///     Get Angle in Degrees.
        /// </summary>
        public double Degrees => As(AngleUnit.Degree);

        /// <summary>
        ///     Get Angle in Gradians.
        /// </summary>
        public double Gradians => As(AngleUnit.Gradian);

        /// <summary>
        ///     Get Angle in Microdegrees.
        /// </summary>
        public double Microdegrees => As(AngleUnit.Microdegree);

        /// <summary>
        ///     Get Angle in Microradians.
        /// </summary>
        public double Microradians => As(AngleUnit.Microradian);

        /// <summary>
        ///     Get Angle in Millidegrees.
        /// </summary>
        public double Millidegrees => As(AngleUnit.Millidegree);

        /// <summary>
        ///     Get Angle in Milliradians.
        /// </summary>
        public double Milliradians => As(AngleUnit.Milliradian);

        /// <summary>
        ///     Get Angle in Nanodegrees.
        /// </summary>
        public double Nanodegrees => As(AngleUnit.Nanodegree);

        /// <summary>
        ///     Get Angle in Nanoradians.
        /// </summary>
        public double Nanoradians => As(AngleUnit.Nanoradian);

        /// <summary>
        ///     Get Angle in Radians.
        /// </summary>
        public double Radians => As(AngleUnit.Radian);

        /// <summary>
        ///     Get Angle in Revolutions.
        /// </summary>
        public double Revolutions => As(AngleUnit.Revolution);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get Angle from Arcminutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromArcminutes(double arcminutes) => new Angle(arcminutes, AngleUnit.Arcminute);

        /// <summary>
        ///     Get Angle from Arcseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromArcseconds(double arcseconds) => new Angle(arcseconds, AngleUnit.Arcsecond);

        /// <summary>
        ///     Get Angle from Centiradians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromCentiradians(double centiradians) => new Angle(centiradians, AngleUnit.Centiradian);

        /// <summary>
        ///     Get Angle from Deciradians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromDeciradians(double deciradians) => new Angle(deciradians, AngleUnit.Deciradian);

        /// <summary>
        ///     Get Angle from Degrees.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromDegrees(double degrees) => new Angle(degrees, AngleUnit.Degree);

        /// <summary>
        ///     Get Angle from Gradians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromGradians(double gradians) => new Angle(gradians, AngleUnit.Gradian);

        /// <summary>
        ///     Get Angle from Microdegrees.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromMicrodegrees(double microdegrees) => new Angle(microdegrees, AngleUnit.Microdegree);

        /// <summary>
        ///     Get Angle from Microradians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromMicroradians(double microradians) => new Angle(microradians, AngleUnit.Microradian);

        /// <summary>
        ///     Get Angle from Millidegrees.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromMillidegrees(double millidegrees) => new Angle(millidegrees, AngleUnit.Millidegree);

        /// <summary>
        ///     Get Angle from Milliradians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromMilliradians(double milliradians) => new Angle(milliradians, AngleUnit.Milliradian);

        /// <summary>
        ///     Get Angle from Nanodegrees.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromNanodegrees(double nanodegrees) => new Angle(nanodegrees, AngleUnit.Nanodegree);

        /// <summary>
        ///     Get Angle from Nanoradians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromNanoradians(double nanoradians) => new Angle(nanoradians, AngleUnit.Nanoradian);

        /// <summary>
        ///     Get Angle from Radians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromRadians(double radians) => new Angle(radians, AngleUnit.Radian);

        /// <summary>
        ///     Get Angle from Revolutions.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromRevolutions(double revolutions) => new Angle(revolutions, AngleUnit.Revolution);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="AngleUnit" /> to <see cref="Angle" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Angle unit value.</returns>
        public static Angle From(double value, AngleUnit fromUnit)
        {
            return new Angle(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(AngleUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Angle ToUnit(AngleUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new Angle(convertedValue, unit);
        }


        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            switch(Unit)
            {
                case AngleUnit.Arcminute: return _value/60;
                case AngleUnit.Arcsecond: return _value/3600;
                case AngleUnit.Centiradian: return (_value*180/3.1415926535897931) * 1e-2d;
                case AngleUnit.Deciradian: return (_value*180/3.1415926535897931) * 1e-1d;
                case AngleUnit.Degree: return _value;
                case AngleUnit.Gradian: return _value*0.9;
                case AngleUnit.Microdegree: return (_value) * 1e-6d;
                case AngleUnit.Microradian: return (_value*180/3.1415926535897931) * 1e-6d;
                case AngleUnit.Millidegree: return (_value) * 1e-3d;
                case AngleUnit.Milliradian: return (_value*180/3.1415926535897931) * 1e-3d;
                case AngleUnit.Nanodegree: return (_value) * 1e-9d;
                case AngleUnit.Nanoradian: return (_value*180/3.1415926535897931) * 1e-9d;
                case AngleUnit.Radian: return _value*180/3.1415926535897931;
                case AngleUnit.Revolution: return _value*360;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(AngleUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case AngleUnit.Arcminute: return baseUnitValue*60;
                case AngleUnit.Arcsecond: return baseUnitValue*3600;
                case AngleUnit.Centiradian: return (baseUnitValue/180*3.1415926535897931) / 1e-2d;
                case AngleUnit.Deciradian: return (baseUnitValue/180*3.1415926535897931) / 1e-1d;
                case AngleUnit.Degree: return baseUnitValue;
                case AngleUnit.Gradian: return baseUnitValue/0.9;
                case AngleUnit.Microdegree: return (baseUnitValue) / 1e-6d;
                case AngleUnit.Microradian: return (baseUnitValue/180*3.1415926535897931) / 1e-6d;
                case AngleUnit.Millidegree: return (baseUnitValue) / 1e-3d;
                case AngleUnit.Milliradian: return (baseUnitValue/180*3.1415926535897931) / 1e-3d;
                case AngleUnit.Nanodegree: return (baseUnitValue) / 1e-9d;
                case AngleUnit.Nanoradian: return (baseUnitValue/180*3.1415926535897931) / 1e-9d;
                case AngleUnit.Radian: return baseUnitValue/180*3.1415926535897931;
                case AngleUnit.Revolution: return baseUnitValue/360;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

