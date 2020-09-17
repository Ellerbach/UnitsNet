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
    ///     In telecommunications and computing, bit rate is the number of bits that are conveyed or processed per unit of time.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Bit_rate
    /// </remarks>
    public struct  BitRate
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly decimal _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly BitRateUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public decimal Value => _value;

        /// <inheritdoc />
        public BitRateUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public BitRate(decimal value, BitRateUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static BitRateUnit BaseUnit { get; } = BitRateUnit.BitPerSecond;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static BitRate MaxValue { get; } = new BitRate(79228162514264337593543950335M, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static BitRate MinValue { get; } = new BitRate(-79228162514264337593543950335M, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static BitRate Zero { get; } = new BitRate(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get BitRate in BitsPerSecond.
        /// </summary>
        public decimal BitsPerSecond => As(BitRateUnit.BitPerSecond);

        /// <summary>
        ///     Get BitRate in BytesPerSecond.
        /// </summary>
        public decimal BytesPerSecond => As(BitRateUnit.BytePerSecond);

        /// <summary>
        ///     Get BitRate in ExabitsPerSecond.
        /// </summary>
        public decimal ExabitsPerSecond => As(BitRateUnit.ExabitPerSecond);

        /// <summary>
        ///     Get BitRate in ExabytesPerSecond.
        /// </summary>
        public decimal ExabytesPerSecond => As(BitRateUnit.ExabytePerSecond);

        /// <summary>
        ///     Get BitRate in ExbibitsPerSecond.
        /// </summary>
        public decimal ExbibitsPerSecond => As(BitRateUnit.ExbibitPerSecond);

        /// <summary>
        ///     Get BitRate in ExbibytesPerSecond.
        /// </summary>
        public decimal ExbibytesPerSecond => As(BitRateUnit.ExbibytePerSecond);

        /// <summary>
        ///     Get BitRate in GibibitsPerSecond.
        /// </summary>
        public decimal GibibitsPerSecond => As(BitRateUnit.GibibitPerSecond);

        /// <summary>
        ///     Get BitRate in GibibytesPerSecond.
        /// </summary>
        public decimal GibibytesPerSecond => As(BitRateUnit.GibibytePerSecond);

        /// <summary>
        ///     Get BitRate in GigabitsPerSecond.
        /// </summary>
        public decimal GigabitsPerSecond => As(BitRateUnit.GigabitPerSecond);

        /// <summary>
        ///     Get BitRate in GigabytesPerSecond.
        /// </summary>
        public decimal GigabytesPerSecond => As(BitRateUnit.GigabytePerSecond);

        /// <summary>
        ///     Get BitRate in KibibitsPerSecond.
        /// </summary>
        public decimal KibibitsPerSecond => As(BitRateUnit.KibibitPerSecond);

        /// <summary>
        ///     Get BitRate in KibibytesPerSecond.
        /// </summary>
        public decimal KibibytesPerSecond => As(BitRateUnit.KibibytePerSecond);

        /// <summary>
        ///     Get BitRate in KilobitsPerSecond.
        /// </summary>
        public decimal KilobitsPerSecond => As(BitRateUnit.KilobitPerSecond);

        /// <summary>
        ///     Get BitRate in KilobytesPerSecond.
        /// </summary>
        public decimal KilobytesPerSecond => As(BitRateUnit.KilobytePerSecond);

        /// <summary>
        ///     Get BitRate in MebibitsPerSecond.
        /// </summary>
        public decimal MebibitsPerSecond => As(BitRateUnit.MebibitPerSecond);

        /// <summary>
        ///     Get BitRate in MebibytesPerSecond.
        /// </summary>
        public decimal MebibytesPerSecond => As(BitRateUnit.MebibytePerSecond);

        /// <summary>
        ///     Get BitRate in MegabitsPerSecond.
        /// </summary>
        public decimal MegabitsPerSecond => As(BitRateUnit.MegabitPerSecond);

        /// <summary>
        ///     Get BitRate in MegabytesPerSecond.
        /// </summary>
        public decimal MegabytesPerSecond => As(BitRateUnit.MegabytePerSecond);

        /// <summary>
        ///     Get BitRate in PebibitsPerSecond.
        /// </summary>
        public decimal PebibitsPerSecond => As(BitRateUnit.PebibitPerSecond);

        /// <summary>
        ///     Get BitRate in PebibytesPerSecond.
        /// </summary>
        public decimal PebibytesPerSecond => As(BitRateUnit.PebibytePerSecond);

        /// <summary>
        ///     Get BitRate in PetabitsPerSecond.
        /// </summary>
        public decimal PetabitsPerSecond => As(BitRateUnit.PetabitPerSecond);

        /// <summary>
        ///     Get BitRate in PetabytesPerSecond.
        /// </summary>
        public decimal PetabytesPerSecond => As(BitRateUnit.PetabytePerSecond);

        /// <summary>
        ///     Get BitRate in TebibitsPerSecond.
        /// </summary>
        public decimal TebibitsPerSecond => As(BitRateUnit.TebibitPerSecond);

        /// <summary>
        ///     Get BitRate in TebibytesPerSecond.
        /// </summary>
        public decimal TebibytesPerSecond => As(BitRateUnit.TebibytePerSecond);

        /// <summary>
        ///     Get BitRate in TerabitsPerSecond.
        /// </summary>
        public decimal TerabitsPerSecond => As(BitRateUnit.TerabitPerSecond);

        /// <summary>
        ///     Get BitRate in TerabytesPerSecond.
        /// </summary>
        public decimal TerabytesPerSecond => As(BitRateUnit.TerabytePerSecond);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get BitRate from BitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromBitsPerSecond(decimal bitspersecond) => new BitRate(bitspersecond, BitRateUnit.BitPerSecond);

        /// <summary>
        ///     Get BitRate from BytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromBytesPerSecond(decimal bytespersecond) => new BitRate(bytespersecond, BitRateUnit.BytePerSecond);

        /// <summary>
        ///     Get BitRate from ExabitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromExabitsPerSecond(decimal exabitspersecond) => new BitRate(exabitspersecond, BitRateUnit.ExabitPerSecond);

        /// <summary>
        ///     Get BitRate from ExabytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromExabytesPerSecond(decimal exabytespersecond) => new BitRate(exabytespersecond, BitRateUnit.ExabytePerSecond);

        /// <summary>
        ///     Get BitRate from ExbibitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromExbibitsPerSecond(decimal exbibitspersecond) => new BitRate(exbibitspersecond, BitRateUnit.ExbibitPerSecond);

        /// <summary>
        ///     Get BitRate from ExbibytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromExbibytesPerSecond(decimal exbibytespersecond) => new BitRate(exbibytespersecond, BitRateUnit.ExbibytePerSecond);

        /// <summary>
        ///     Get BitRate from GibibitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromGibibitsPerSecond(decimal gibibitspersecond) => new BitRate(gibibitspersecond, BitRateUnit.GibibitPerSecond);

        /// <summary>
        ///     Get BitRate from GibibytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromGibibytesPerSecond(decimal gibibytespersecond) => new BitRate(gibibytespersecond, BitRateUnit.GibibytePerSecond);

        /// <summary>
        ///     Get BitRate from GigabitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromGigabitsPerSecond(decimal gigabitspersecond) => new BitRate(gigabitspersecond, BitRateUnit.GigabitPerSecond);

        /// <summary>
        ///     Get BitRate from GigabytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromGigabytesPerSecond(decimal gigabytespersecond) => new BitRate(gigabytespersecond, BitRateUnit.GigabytePerSecond);

        /// <summary>
        ///     Get BitRate from KibibitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromKibibitsPerSecond(decimal kibibitspersecond) => new BitRate(kibibitspersecond, BitRateUnit.KibibitPerSecond);

        /// <summary>
        ///     Get BitRate from KibibytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromKibibytesPerSecond(decimal kibibytespersecond) => new BitRate(kibibytespersecond, BitRateUnit.KibibytePerSecond);

        /// <summary>
        ///     Get BitRate from KilobitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromKilobitsPerSecond(decimal kilobitspersecond) => new BitRate(kilobitspersecond, BitRateUnit.KilobitPerSecond);

        /// <summary>
        ///     Get BitRate from KilobytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromKilobytesPerSecond(decimal kilobytespersecond) => new BitRate(kilobytespersecond, BitRateUnit.KilobytePerSecond);

        /// <summary>
        ///     Get BitRate from MebibitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromMebibitsPerSecond(decimal mebibitspersecond) => new BitRate(mebibitspersecond, BitRateUnit.MebibitPerSecond);

        /// <summary>
        ///     Get BitRate from MebibytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromMebibytesPerSecond(decimal mebibytespersecond) => new BitRate(mebibytespersecond, BitRateUnit.MebibytePerSecond);

        /// <summary>
        ///     Get BitRate from MegabitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromMegabitsPerSecond(decimal megabitspersecond) => new BitRate(megabitspersecond, BitRateUnit.MegabitPerSecond);

        /// <summary>
        ///     Get BitRate from MegabytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromMegabytesPerSecond(decimal megabytespersecond) => new BitRate(megabytespersecond, BitRateUnit.MegabytePerSecond);

        /// <summary>
        ///     Get BitRate from PebibitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromPebibitsPerSecond(decimal pebibitspersecond) => new BitRate(pebibitspersecond, BitRateUnit.PebibitPerSecond);

        /// <summary>
        ///     Get BitRate from PebibytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromPebibytesPerSecond(decimal pebibytespersecond) => new BitRate(pebibytespersecond, BitRateUnit.PebibytePerSecond);

        /// <summary>
        ///     Get BitRate from PetabitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromPetabitsPerSecond(decimal petabitspersecond) => new BitRate(petabitspersecond, BitRateUnit.PetabitPerSecond);

        /// <summary>
        ///     Get BitRate from PetabytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromPetabytesPerSecond(decimal petabytespersecond) => new BitRate(petabytespersecond, BitRateUnit.PetabytePerSecond);

        /// <summary>
        ///     Get BitRate from TebibitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromTebibitsPerSecond(decimal tebibitspersecond) => new BitRate(tebibitspersecond, BitRateUnit.TebibitPerSecond);

        /// <summary>
        ///     Get BitRate from TebibytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromTebibytesPerSecond(decimal tebibytespersecond) => new BitRate(tebibytespersecond, BitRateUnit.TebibytePerSecond);

        /// <summary>
        ///     Get BitRate from TerabitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromTerabitsPerSecond(decimal terabitspersecond) => new BitRate(terabitspersecond, BitRateUnit.TerabitPerSecond);

        /// <summary>
        ///     Get BitRate from TerabytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BitRate FromTerabytesPerSecond(decimal terabytespersecond) => new BitRate(terabytespersecond, BitRateUnit.TerabytePerSecond);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="BitRateUnit" /> to <see cref="BitRate" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>BitRate unit value.</returns>
        public static BitRate From(decimal value, BitRateUnit fromUnit)
        {
            return new BitRate(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public decimal As(BitRateUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public BitRate ToUnit(BitRateUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new BitRate(convertedValue, unit);
        }


        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private decimal GetValueInBaseUnit()
        {
            switch(Unit)
            {
                case BitRateUnit.BitPerSecond: return _value;
                case BitRateUnit.BytePerSecond: return _value*8m;
                case BitRateUnit.ExabitPerSecond: return (_value) * 1e18m;
                case BitRateUnit.ExabytePerSecond: return (_value*8m) * 1e18m;
                case BitRateUnit.ExbibitPerSecond: return (_value) * (1024m * 1024 * 1024 * 1024 * 1024 * 1024);
                case BitRateUnit.ExbibytePerSecond: return (_value*8m) * (1024m * 1024 * 1024 * 1024 * 1024 * 1024);
                case BitRateUnit.GibibitPerSecond: return (_value) * (1024m * 1024 * 1024);
                case BitRateUnit.GibibytePerSecond: return (_value*8m) * (1024m * 1024 * 1024);
                case BitRateUnit.GigabitPerSecond: return (_value) * 1e9m;
                case BitRateUnit.GigabytePerSecond: return (_value*8m) * 1e9m;
                case BitRateUnit.KibibitPerSecond: return (_value) * 1024m;
                case BitRateUnit.KibibytePerSecond: return (_value*8m) * 1024m;
                case BitRateUnit.KilobitPerSecond: return (_value) * 1e3m;
                case BitRateUnit.KilobytePerSecond: return (_value*8m) * 1e3m;
                case BitRateUnit.MebibitPerSecond: return (_value) * (1024m * 1024);
                case BitRateUnit.MebibytePerSecond: return (_value*8m) * (1024m * 1024);
                case BitRateUnit.MegabitPerSecond: return (_value) * 1e6m;
                case BitRateUnit.MegabytePerSecond: return (_value*8m) * 1e6m;
                case BitRateUnit.PebibitPerSecond: return (_value) * (1024m * 1024 * 1024 * 1024 * 1024);
                case BitRateUnit.PebibytePerSecond: return (_value*8m) * (1024m * 1024 * 1024 * 1024 * 1024);
                case BitRateUnit.PetabitPerSecond: return (_value) * 1e15m;
                case BitRateUnit.PetabytePerSecond: return (_value*8m) * 1e15m;
                case BitRateUnit.TebibitPerSecond: return (_value) * (1024m * 1024 * 1024 * 1024);
                case BitRateUnit.TebibytePerSecond: return (_value*8m) * (1024m * 1024 * 1024 * 1024);
                case BitRateUnit.TerabitPerSecond: return (_value) * 1e12m;
                case BitRateUnit.TerabytePerSecond: return (_value*8m) * 1e12m;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private decimal GetValueAs(BitRateUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case BitRateUnit.BitPerSecond: return baseUnitValue;
                case BitRateUnit.BytePerSecond: return baseUnitValue/8m;
                case BitRateUnit.ExabitPerSecond: return (baseUnitValue) / 1e18m;
                case BitRateUnit.ExabytePerSecond: return (baseUnitValue/8m) / 1e18m;
                case BitRateUnit.ExbibitPerSecond: return (baseUnitValue) / (1024m * 1024 * 1024 * 1024 * 1024 * 1024);
                case BitRateUnit.ExbibytePerSecond: return (baseUnitValue/8m) / (1024m * 1024 * 1024 * 1024 * 1024 * 1024);
                case BitRateUnit.GibibitPerSecond: return (baseUnitValue) / (1024m * 1024 * 1024);
                case BitRateUnit.GibibytePerSecond: return (baseUnitValue/8m) / (1024m * 1024 * 1024);
                case BitRateUnit.GigabitPerSecond: return (baseUnitValue) / 1e9m;
                case BitRateUnit.GigabytePerSecond: return (baseUnitValue/8m) / 1e9m;
                case BitRateUnit.KibibitPerSecond: return (baseUnitValue) / 1024m;
                case BitRateUnit.KibibytePerSecond: return (baseUnitValue/8m) / 1024m;
                case BitRateUnit.KilobitPerSecond: return (baseUnitValue) / 1e3m;
                case BitRateUnit.KilobytePerSecond: return (baseUnitValue/8m) / 1e3m;
                case BitRateUnit.MebibitPerSecond: return (baseUnitValue) / (1024m * 1024);
                case BitRateUnit.MebibytePerSecond: return (baseUnitValue/8m) / (1024m * 1024);
                case BitRateUnit.MegabitPerSecond: return (baseUnitValue) / 1e6m;
                case BitRateUnit.MegabytePerSecond: return (baseUnitValue/8m) / 1e6m;
                case BitRateUnit.PebibitPerSecond: return (baseUnitValue) / (1024m * 1024 * 1024 * 1024 * 1024);
                case BitRateUnit.PebibytePerSecond: return (baseUnitValue/8m) / (1024m * 1024 * 1024 * 1024 * 1024);
                case BitRateUnit.PetabitPerSecond: return (baseUnitValue) / 1e15m;
                case BitRateUnit.PetabytePerSecond: return (baseUnitValue/8m) / 1e15m;
                case BitRateUnit.TebibitPerSecond: return (baseUnitValue) / (1024m * 1024 * 1024 * 1024);
                case BitRateUnit.TebibytePerSecond: return (baseUnitValue/8m) / (1024m * 1024 * 1024 * 1024);
                case BitRateUnit.TerabitPerSecond: return (baseUnitValue) / 1e12m;
                case BitRateUnit.TerabytePerSecond: return (baseUnitValue/8m) / 1e12m;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

