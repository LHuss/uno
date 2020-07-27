using System;
using UwpBatteryStatus = Windows.System.Power.BatteryStatus;
using UwpEnergySaverStatus = Windows.System.Power.EnergySaverStatus;
using UwpPowerSupplyStatus = Windows.System.Power.PowerSupplyStatus;
using Foundation;
using Uno.Helpers;

namespace Windows.System.Power
{
	public partial class PowerManager
	{     
		static PowerManager()
		{
            var x = IOKit.CopyPowerSourceInfo();
		}

        public static void Refresh()
        {
            var x = IOKit.CopyPowerSourceInfo();
        }

        private static void StartEnergySaverStatusMonitoring()
        {
			return;
        }

		private static void EndEnergySaverStatusMonitoring()
        {

        }

		private static void StartRemainingChargePercentMonitoring()
        {

        }

		private static void EndRemainingChargePercentMonitoring()
        {

        }

		private static void StartPowerSupplyStatusMonitoring()
        {

        }

		private static void EndPowerSupplyStatusMonitoring()
        {

        }

		private static void StartBatteryStatusMonitoring()
        {

        }

		private static void EndBatteryStatusMonitoring()
        {
            
        }
        
        private static UwpBatteryStatus GetBatteryStatus()
		{
            return UwpBatteryStatus.Discharging;
		}

		private static UwpEnergySaverStatus GetEnergySaverStatus() =>
			UwpEnergySaverStatus.Off;

		private static UwpPowerSupplyStatus GetPowerSupplyStatus() =>
			UwpPowerSupplyStatus.NotPresent;

		private static int GetRemainingChargePercent()
		{
			return 666;
		}
    }	   
}
