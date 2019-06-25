// <copyright file="PresentationFormats.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//----------------------------------------------------------------------------------------------

namespace SDKTemplate
{
    /// <summary>
    /// Class containing the details of Gatt characteristics presentation formats
    /// </summary>
    public class PresentationFormats
    {
        /// <summary>
        /// Units are established international standards for the measurement of physical quantities.
        /// </summary>
        /// <remarks>Please refer https://www.bluetooth.com/specifications/assigned-numbers/units </remarks>
        public enum Units
        {
            Unitless = 0x2700,
            TimeSecond = 0x2703,
            AccelerationMetresPerSecondSquared = 0x2713,
            ForceNewton = 0x2723,
            AngularVelocityRadianPerSecond = 0x2743,
            AngularAccelerationRadianPerSecondSquared = 0x2744,
            TimeMinute = 0x2760,
            TimeHour = 0x2761,
            TimeDay = 0x2762,
            PressurePoundForcePerSquareinch = 0x27A5,
            VelocityKiloMetrePerHour = 0x27A6,
            VelocityMilePerHour = 0x27A7,
            AngularVelocityRevolutionPerminute = 0x27A8,
            EnergyGramcalorie = 0x27A9,
            EnergyKilogramcalorie = 0x27AA,
            EnergyKiloWattHour = 0x27AB,
            ThermodynamicTemperatureDegreeFahrenheit = 0x27AC,
            Percentage = 0x27AD,
            PerMille = 0x27AE,
            PeriodBeatsPerMinute = 0x27AF,
            ElectricchargeAmpereHours = 0x27B0,
            MassDensityMilligramPerdeciLitre = 0x27B1,
            MassDensityMillimolePerLitre = 0x27B2,
            TimeYear = 0x27B3,
            TimeMonth = 0x27B4,
        }

        /// <summary>
        /// The Name Space field is used to identify the organization that is responsible for defining the enumerations for the description field.
        /// </summary>
        /// <remarks>
        /// Please refer https://www.bluetooth.com/specifications/gatt/viewer?attributeXmlFile=org.bluetooth.descriptor.gatt.characteristic_presentation_format.xml
        /// </remarks>
        public enum NamespaceId
        {
            BluetoothSigAssignedNumber = 1,
            ReservedForFutureUse
        }

        /// <summary>
        /// The Description is an enumerated value from the organization identified by the Name Space field.
        /// </summary>
        /// <remarks>
        /// Please refer https://www.bluetooth.com/specifications/gatt/viewer?attributeXmlFile=org.bluetooth.descriptor.gatt.characteristic_presentation_format.xml
        /// </remarks>
        public const ushort Description = 0x0000;

        /// <summary>
        /// Exponent value for the characteristics
        /// </summary>
        public const int Exponent = 0;
    }
}
