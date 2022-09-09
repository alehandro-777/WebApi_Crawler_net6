using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NetCoreCraw.SemPortalJson.Instant
{
        public class PowerStMonitorRes
        {
            [JsonProperty("language")]
            public string Language { get; set; }

            [JsonProperty("function")]
            public string[] Function { get; set; }

            [JsonProperty("hasError")]
            public bool HasError { get; set; }

            [JsonProperty("msg")]
            public string Msg { get; set; }

            [JsonProperty("code")]   
            public string Code { get; set; }

            [JsonProperty("data")]
            public Data Data { get; set; }

        }

        public class Data
        {
            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("kpi")]
            public Kpi Kpi { get; set; }

            [JsonProperty("powercontrol_status")]
            public long PowercontrolStatus { get; set; }


            [JsonProperty("inverter")]
            public Inverter[] Inverter { get; set; }

            [JsonProperty("powerflow")]
            public Powerflow Powerflow { get; set; }

            [JsonProperty("soc")]
            public Soc Soc { get; set; }
        }


        public class Info
        {
            [JsonProperty("powerstation_id")]
            public Guid PowerstationId { get; set; }

            [JsonProperty("time")]
            public string Time { get; set; }

            [JsonProperty("date_format")]
            public string DateFormat { get; set; }

            [JsonProperty("date_format_ym")]
            public string DateFormatYm { get; set; }

            [JsonProperty("stationname")]
            public string Stationname { get; set; }

            [JsonProperty("address")]
            public string Address { get; set; }

            [JsonProperty("owner_name")]
            public string OwnerName { get; set; }

            [JsonProperty("owner_phone")]
            public string OwnerPhone { get; set; }

            [JsonProperty("owner_email")]
            public string OwnerEmail { get; set; }

            [JsonProperty("battery_capacity")]
            public long BatteryCapacity { get; set; }

            [JsonProperty("turnon_time")]
            public string TurnonTime { get; set; }

            [JsonProperty("create_time")]
            public string CreateTime { get; set; }

            [JsonProperty("capacity")]
            public double Capacity { get; set; }

            [JsonProperty("longitude")]
            public double Longitude { get; set; }

            [JsonProperty("latitude")]
            public double Latitude { get; set; }

            [JsonProperty("powerstation_type")]
            public string PowerstationType { get; set; }

            [JsonProperty("status")]
            public long Status { get; set; }

            [JsonProperty("is_stored")]
            public bool IsStored { get; set; }

            [JsonProperty("is_powerflow")]
            public bool IsPowerflow { get; set; }

            [JsonProperty("charts_type")]
            public long ChartsType { get; set; }

            [JsonProperty("has_pv")]
            public bool HasPv { get; set; }

            [JsonProperty("has_statistics_charts")]
            public bool HasStatisticsCharts { get; set; }

            [JsonProperty("only_bps")]
            public bool OnlyBps { get; set; }

            [JsonProperty("only_bpu")]
            public bool OnlyBpu { get; set; }

            [JsonProperty("time_span")]
            public long TimeSpan { get; set; }

            [JsonProperty("pr_value")]
            public string PrValue { get; set; }

            [JsonProperty("org_code")]
            public object OrgCode { get; set; }

            [JsonProperty("org_name")]
            public object OrgName { get; set; }
        }

        public class Inverter
        {
            [JsonProperty("sn")]
            public string Sn { get; set; }

            [JsonProperty("dict")]
            public Dict Dict { get; set; }

            [JsonProperty("is_stored")]
            public bool IsStored { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("in_pac")]
            public double InPac { get; set; }

            [JsonProperty("out_pac")]
            public long OutPac { get; set; }

            [JsonProperty("eday")]
            public double Eday { get; set; }

            [JsonProperty("emonth")]
            public long Emonth { get; set; }

            [JsonProperty("etotal")]
            public double Etotal { get; set; }

            [JsonProperty("status")]
            public long Status { get; set; }

            [JsonProperty("turnon_time")]
            public string TurnonTime { get; set; }

            [JsonProperty("releation_id")]
            public Guid ReleationId { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("capacity")]
            public long Capacity { get; set; }

            [JsonProperty("d")]
            public D D { get; set; }

            [JsonProperty("it_change_flag")]
            public bool ItChangeFlag { get; set; }

            [JsonProperty("tempperature")]
            public double Tempperature { get; set; }

            [JsonProperty("check_code")]
            public string CheckCode { get; set; }

            [JsonProperty("next")]
            public object Next { get; set; }

            [JsonProperty("prev")]
            public object Prev { get; set; }

            [JsonProperty("next_device")]
            public Device NextDevice { get; set; }

            [JsonProperty("prev_device")]
            public Device PrevDevice { get; set; }

            [JsonProperty("invert_full")]
            public InvertFull InvertFull { get; set; }

            [JsonProperty("time")]
            public string Time { get; set; }

            [JsonProperty("battery")]
            public string Battery { get; set; }

            [JsonProperty("firmware_version")]
            public long FirmwareVersion { get; set; }

            [JsonProperty("warning_bms")]
            public string WarningBms { get; set; }

            [JsonProperty("soh")]
            public string Soh { get; set; }

            [JsonProperty("discharge_current_limit_bms")]
            public string DischargeCurrentLimitBms { get; set; }

            [JsonProperty("charge_current_limit_bms")]
            public string ChargeCurrentLimitBms { get; set; }

            [JsonProperty("soc")]
            public string Soc { get; set; }

            [JsonProperty("pv_input_2")]
            public string PvInput2 { get; set; }

            [JsonProperty("pv_input_1")]
            public string PvInput1 { get; set; }

            [JsonProperty("back_up_output")]
            public string BackUpOutput { get; set; }

            [JsonProperty("output_voltage")]
            public string OutputVoltage { get; set; }

            [JsonProperty("backup_voltage")]
            public string BackupVoltage { get; set; }

            [JsonProperty("output_current")]
            public string OutputCurrent { get; set; }

            [JsonProperty("output_power")]
            public string OutputPower { get; set; }

            [JsonProperty("total_generation")]
            public string TotalGeneration { get; set; }

            [JsonProperty("daily_generation")]
            public string DailyGeneration { get; set; }

            [JsonProperty("battery_charging")]
            public string BatteryCharging { get; set; }

            [JsonProperty("last_refresh_time")]
            public string LastRefreshTime { get; set; }

            [JsonProperty("bms_status")]
            public string BmsStatus { get; set; }

            [JsonProperty("pw_id")]
            public Guid PwId { get; set; }

            [JsonProperty("fault_message")]
            public string FaultMessage { get; set; }

            [JsonProperty("warning_code")]
            public object WarningCode { get; set; }

            [JsonProperty("battery_power")]
            public double BatteryPower { get; set; }

            [JsonProperty("point_index")]
            public long PointIndex { get; set; }

            [JsonProperty("points")]
            public Point[] Points { get; set; }

            [JsonProperty("backup_pload_s")]
            public long BackupPloadS { get; set; }

            [JsonProperty("backup_vload_s")]
            public long BackupVloadS { get; set; }

            [JsonProperty("backup_iload_s")]
            public long BackupIloadS { get; set; }

            [JsonProperty("backup_pload_t")]
            public long BackupPloadT { get; set; }

            [JsonProperty("backup_vload_t")]
            public long BackupVloadT { get; set; }

            [JsonProperty("backup_iload_t")]
            public long BackupIloadT { get; set; }

            [JsonProperty("etotal_buy")]
            public object EtotalBuy { get; set; }

            [JsonProperty("eday_buy")]
            public long EdayBuy { get; set; }

            [JsonProperty("ebattery_charge")]
            public object EbatteryCharge { get; set; }

            [JsonProperty("echarge_day")]
            public long EchargeDay { get; set; }

            [JsonProperty("ebattery_discharge")]
            public object EbatteryDischarge { get; set; }

            [JsonProperty("edischarge_day")]
            public long EdischargeDay { get; set; }

            [JsonProperty("batt_strings")]
            public double BattStrings { get; set; }

            [JsonProperty("meter_connect_status")]
            public object MeterConnectStatus { get; set; }

            [JsonProperty("mtactivepower_r")]
            public long MtactivepowerR { get; set; }

            [JsonProperty("mtactivepower_s")]
            public long MtactivepowerS { get; set; }

            [JsonProperty("mtactivepower_t")]
            public long MtactivepowerT { get; set; }

            [JsonProperty("has_tigo")]
            public bool HasTigo { get; set; }

            [JsonProperty("canStartIV")]
            public bool CanStartIv { get; set; }
        }

        public class D
        {
            [JsonProperty("pw_id")]
            public Guid PwId { get; set; }

            [JsonProperty("capacity")]
            public string Capacity { get; set; }

            [JsonProperty("model")]
            public string Model { get; set; }

            [JsonProperty("output_power")]
            public string OutputPower { get; set; }

            [JsonProperty("output_current")]
            public string OutputCurrent { get; set; }

            [JsonProperty("grid_voltage")]
            public string GridVoltage { get; set; }

            [JsonProperty("backup_output")]
            public string BackupOutput { get; set; }

            [JsonProperty("soc")]
            public string Soc { get; set; }

            [JsonProperty("soh")]
            public string Soh { get; set; }

            [JsonProperty("last_refresh_time")]
            public string LastRefreshTime { get; set; }

            [JsonProperty("work_mode")]
            public string WorkMode { get; set; }

            [JsonProperty("dc_input1")]
            public string DcInput1 { get; set; }

            [JsonProperty("dc_input2")]
            public string DcInput2 { get; set; }

            [JsonProperty("battery")]
            public string Battery { get; set; }

            [JsonProperty("bms_status")]
            public string BmsStatus { get; set; }

            [JsonProperty("warning")]
            public string Warning { get; set; }

            [JsonProperty("charge_current_limit")]
            public string ChargeCurrentLimit { get; set; }

            [JsonProperty("discharge_current_limit")]
            public string DischargeCurrentLimit { get; set; }

            [JsonProperty("firmware_version")]
            public long FirmwareVersion { get; set; }

            [JsonProperty("creationDate")]
            public string CreationDate { get; set; }

            [JsonProperty("eDay")]
            public double EDay { get; set; }

            [JsonProperty("eTotal")]
            public double ETotal { get; set; }

            [JsonProperty("pac")]
            public long Pac { get; set; }

            [JsonProperty("hTotal")]
            public long HTotal { get; set; }

            [JsonProperty("vpv1")]
            public double Vpv1 { get; set; }

            [JsonProperty("vpv2")]
            public double Vpv2 { get; set; }

            [JsonProperty("vpv3")]
            public long Vpv3 { get; set; }

            [JsonProperty("vpv4")]
            public long Vpv4 { get; set; }

            [JsonProperty("ipv1")]
            public double Ipv1 { get; set; }

            [JsonProperty("ipv2")]
            public double Ipv2 { get; set; }

            [JsonProperty("ipv3")]
            public long Ipv3 { get; set; }

            [JsonProperty("ipv4")]
            public long Ipv4 { get; set; }

            [JsonProperty("vac1")]
            public long Vac1 { get; set; }

            [JsonProperty("vac2")]
            public double Vac2 { get; set; }

            [JsonProperty("vac3")]
            public double Vac3 { get; set; }

            [JsonProperty("iac1")]
            public double Iac1 { get; set; }

            [JsonProperty("iac2")]
            public double Iac2 { get; set; }

            [JsonProperty("iac3")]
            public double Iac3 { get; set; }

            [JsonProperty("fac1")]
            public long Fac1 { get; set; }

            [JsonProperty("fac2")]
            public double Fac2 { get; set; }

            [JsonProperty("fac3")]
            public double Fac3 { get; set; }

            [JsonProperty("istr1")]
            public long Istr1 { get; set; }

            [JsonProperty("istr2")]
            public long Istr2 { get; set; }

            [JsonProperty("istr3")]
            public long Istr3 { get; set; }

            [JsonProperty("istr4")]
            public long Istr4 { get; set; }

            [JsonProperty("istr5")]
            public long Istr5 { get; set; }

            [JsonProperty("istr6")]
            public long Istr6 { get; set; }

            [JsonProperty("istr7")]
            public long Istr7 { get; set; }

            [JsonProperty("istr8")]
            public long Istr8 { get; set; }

            [JsonProperty("istr9")]
            public long Istr9 { get; set; }

            [JsonProperty("istr10")]
            public long Istr10 { get; set; }

            [JsonProperty("istr11")]
            public long Istr11 { get; set; }

            [JsonProperty("istr12")]
            public long Istr12 { get; set; }

            [JsonProperty("istr13")]
            public long Istr13 { get; set; }

            [JsonProperty("istr14")]
            public long Istr14 { get; set; }

            [JsonProperty("istr15")]
            public long Istr15 { get; set; }

            [JsonProperty("istr16")]
            public long Istr16 { get; set; }
        }

        public class Dict
        {
            [JsonProperty("left")]
            public Left[] Left { get; set; }

            [JsonProperty("right")]
            public Left[] Right { get; set; }
        }

        public class Left
        {
            [JsonProperty("isHT")]
            public bool IsHt { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("value")]
            public string Value { get; set; }

            [JsonProperty("unit")]
            public string Unit { get; set; }

            [JsonProperty("isFaultMsg")]
            public long IsFaultMsg { get; set; }

            [JsonProperty("faultMsgCode")]
            public long FaultMsgCode { get; set; }
        }

        public class InvertFull
        {
            [JsonProperty("ct_solution_type")]
            public long CtSolutionType { get; set; }

            [JsonProperty("cts")]
            public object Cts { get; set; }

            [JsonProperty("sn")]
            public string Sn { get; set; }

            [JsonProperty("check_code")]
            public string CheckCode { get; set; }

            [JsonProperty("powerstation_id")]
            public Guid PowerstationId { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("model_type")]
            public string ModelType { get; set; }

            [JsonProperty("change_type")]
            public long ChangeType { get; set; }

            [JsonProperty("change_time")]
            public long ChangeTime { get; set; }

            [JsonProperty("capacity")]
            public long Capacity { get; set; }

            [JsonProperty("eday")]
            public double Eday { get; set; }

            [JsonProperty("iday")]
            public double Iday { get; set; }

            [JsonProperty("etotal")]
            public double Etotal { get; set; }

            [JsonProperty("itotal")]
            public double Itotal { get; set; }

            [JsonProperty("hour_total")]
            public long HourTotal { get; set; }

            [JsonProperty("status")]
            public long Status { get; set; }

            [JsonProperty("turnon_time")]
            public long TurnonTime { get; set; }

            [JsonProperty("pac")]
            public long Pac { get; set; }

            [JsonProperty("tempperature")]
            public double Tempperature { get; set; }

            [JsonProperty("vpv1")]
            public double Vpv1 { get; set; }

            [JsonProperty("vpv2")]
            public double Vpv2 { get; set; }

            [JsonProperty("vpv3")]
            public long Vpv3 { get; set; }

            [JsonProperty("vpv4")]
            public long Vpv4 { get; set; }

            [JsonProperty("ipv1")]
            public double Ipv1 { get; set; }

            [JsonProperty("ipv2")]
            public double Ipv2 { get; set; }

            [JsonProperty("ipv3")]
            public long Ipv3 { get; set; }

            [JsonProperty("ipv4")]
            public long Ipv4 { get; set; }

            [JsonProperty("vac1")]
            public long Vac1 { get; set; }

            [JsonProperty("vac2")]
            public double Vac2 { get; set; }

            [JsonProperty("vac3")]
            public double Vac3 { get; set; }

            [JsonProperty("iac1")]
            public double Iac1 { get; set; }

            [JsonProperty("iac2")]
            public double Iac2 { get; set; }

            [JsonProperty("iac3")]
            public double Iac3 { get; set; }

            [JsonProperty("fac1")]
            public long Fac1 { get; set; }

            [JsonProperty("fac2")]
            public double Fac2 { get; set; }

            [JsonProperty("fac3")]
            public double Fac3 { get; set; }

            [JsonProperty("istr1")]
            public long Istr1 { get; set; }

            [JsonProperty("istr2")]
            public long Istr2 { get; set; }

            [JsonProperty("istr3")]
            public long Istr3 { get; set; }

            [JsonProperty("istr4")]
            public long Istr4 { get; set; }

            [JsonProperty("istr5")]
            public long Istr5 { get; set; }

            [JsonProperty("istr6")]
            public long Istr6 { get; set; }

            [JsonProperty("istr7")]
            public long Istr7 { get; set; }

            [JsonProperty("istr8")]
            public long Istr8 { get; set; }

            [JsonProperty("istr9")]
            public long Istr9 { get; set; }

            [JsonProperty("istr10")]
            public long Istr10 { get; set; }

            [JsonProperty("istr11")]
            public long Istr11 { get; set; }

            [JsonProperty("istr12")]
            public long Istr12 { get; set; }

            [JsonProperty("istr13")]
            public long Istr13 { get; set; }

            [JsonProperty("istr14")]
            public long Istr14 { get; set; }

            [JsonProperty("istr15")]
            public long Istr15 { get; set; }

            [JsonProperty("istr16")]
            public long Istr16 { get; set; }

            [JsonProperty("last_time")]
            public long LastTime { get; set; }

            [JsonProperty("vbattery1")]
            public long Vbattery1 { get; set; }

            [JsonProperty("ibattery1")]
            public double Ibattery1 { get; set; }

            [JsonProperty("pmeter")]
            public long Pmeter { get; set; }

            [JsonProperty("soc")]
            public long Soc { get; set; }

            [JsonProperty("soh")]
            public double Soh { get; set; }

            [JsonProperty("bms_discharge_i_max")]
            public object BmsDischargeIMax { get; set; }

            [JsonProperty("bms_charge_i_max")]
            public long BmsChargeIMax { get; set; }

            [JsonProperty("bms_warning")]
            public long BmsWarning { get; set; }

            [JsonProperty("bms_alarm")]
            public long BmsAlarm { get; set; }

            [JsonProperty("battary_work_mode")]
            public long BattaryWorkMode { get; set; }

            [JsonProperty("workmode")]
            public long Workmode { get; set; }

            [JsonProperty("vload")]
            public double Vload { get; set; }

            [JsonProperty("iload")]
            public double Iload { get; set; }

            [JsonProperty("firmwareversion")]
            public long Firmwareversion { get; set; }

            [JsonProperty("bmssoftwareversion")]
            public object Bmssoftwareversion { get; set; }

            [JsonProperty("pbackup")]
            public long Pbackup { get; set; }

            [JsonProperty("seller")]
            public long Seller { get; set; }

            [JsonProperty("buy")]
            public long Buy { get; set; }

            [JsonProperty("yesterdaybuytotal")]
            public object Yesterdaybuytotal { get; set; }

            [JsonProperty("yesterdaysellertotal")]
            public object Yesterdaysellertotal { get; set; }

            [JsonProperty("yesterdayct2sellertotal")]
            public object Yesterdayct2Sellertotal { get; set; }

            [JsonProperty("yesterdayetotal")]
            public object Yesterdayetotal { get; set; }

            [JsonProperty("yesterdayetotalload")]
            public object Yesterdayetotalload { get; set; }

            [JsonProperty("yesterdaylastime")]
            public long Yesterdaylastime { get; set; }

            [JsonProperty("thismonthetotle")]
            public long Thismonthetotle { get; set; }

            [JsonProperty("lastmonthetotle")]
            public double Lastmonthetotle { get; set; }

            [JsonProperty("ram")]
            public long Ram { get; set; }

            [JsonProperty("outputpower")]
            public long Outputpower { get; set; }

            [JsonProperty("fault_messge")]
            public long FaultMessge { get; set; }

            [JsonProperty("battery1sn")]
            public object Battery1Sn { get; set; }

            [JsonProperty("battery2sn")]
            public object Battery2Sn { get; set; }

            [JsonProperty("battery3sn")]
            public object Battery3Sn { get; set; }

            [JsonProperty("battery4sn")]
            public object Battery4Sn { get; set; }

            [JsonProperty("battery5sn")]
            public object Battery5Sn { get; set; }

            [JsonProperty("battery6sn")]
            public object Battery6Sn { get; set; }

            [JsonProperty("battery7sn")]
            public object Battery7Sn { get; set; }

            [JsonProperty("battery8sn")]
            public object Battery8Sn { get; set; }

            [JsonProperty("pf")]
            public double Pf { get; set; }

            [JsonProperty("pv_power")]
            public long PvPower { get; set; }

            [JsonProperty("reactive_power")]
            public long ReactivePower { get; set; }

            [JsonProperty("leakage_current")]
            public object LeakageCurrent { get; set; }

            [JsonProperty("isoLimit")]
            public long IsoLimit { get; set; }

            [JsonProperty("isbuettey")]
            public bool Isbuettey { get; set; }

            [JsonProperty("isbuetteybps")]
            public bool Isbuetteybps { get; set; }

            [JsonProperty("isbuetteybpu")]
            public bool Isbuetteybpu { get; set; }

            [JsonProperty("isESUOREMU")]
            public bool IsEsuoremu { get; set; }

            [JsonProperty("backUpPload_S")]
            public long BackUpPloadS { get; set; }

            [JsonProperty("backUpVload_S")]
            public long BackUpVloadS { get; set; }

            [JsonProperty("backUpIload_S")]
            public long BackUpIloadS { get; set; }

            [JsonProperty("backUpPload_T")]
            public long BackUpPloadT { get; set; }

            [JsonProperty("backUpVload_T")]
            public long BackUpVloadT { get; set; }

            [JsonProperty("backUpIload_T")]
            public long BackUpIloadT { get; set; }

            [JsonProperty("eTotalBuy")]
            public object ETotalBuy { get; set; }

            [JsonProperty("eDayBuy")]
            public long EDayBuy { get; set; }

            [JsonProperty("eBatteryCharge")]
            public object EBatteryCharge { get; set; }

            [JsonProperty("eChargeDay")]
            public long EChargeDay { get; set; }

            [JsonProperty("eBatteryDischarge")]
            public object EBatteryDischarge { get; set; }

            [JsonProperty("eDischargeDay")]
            public long EDischargeDay { get; set; }

            [JsonProperty("battStrings")]
            public double BattStrings { get; set; }

            [JsonProperty("meterConnectStatus")]
            public object MeterConnectStatus { get; set; }

            [JsonProperty("mtActivepowerR")]
            public long MtActivepowerR { get; set; }

            [JsonProperty("mtActivepowerS")]
            public long MtActivepowerS { get; set; }

            [JsonProperty("mtActivepowerT")]
            public long MtActivepowerT { get; set; }

            [JsonProperty("ezPro_connect_status")]
            public object EzProConnectStatus { get; set; }

            [JsonProperty("dataloggersn")]
            public string Dataloggersn { get; set; }

            [JsonProperty("equipment_name")]
            public object EquipmentName { get; set; }

            [JsonProperty("hasmeter")]
            public bool Hasmeter { get; set; }

            [JsonProperty("meter_type")]
            public object MeterType { get; set; }

            [JsonProperty("pre_hour_lasttotal")]
            public object PreHourLasttotal { get; set; }

            [JsonProperty("pre_hour_time")]
            public object PreHourTime { get; set; }

            [JsonProperty("current_hour_pv")]
            public long CurrentHourPv { get; set; }

            [JsonProperty("extend_properties")]
            public object ExtendProperties { get; set; }

            [JsonProperty("eP_connect_status_happen")]
            public object EPConnectStatusHappen { get; set; }

            [JsonProperty("eP_connect_status_recover")]
            public object EPConnectStatusRecover { get; set; }

            [JsonProperty("total_sell")]
            public long TotalSell { get; set; }

            [JsonProperty("total_buy")]
            public long TotalBuy { get; set; }

            [JsonProperty("errors")]
            public object[] Errors { get; set; }

            [JsonProperty("safetyConutry")]
            public long SafetyConutry { get; set; }

            [JsonProperty("deratingMode")]
            public object DeratingMode { get; set; }

            [JsonProperty("master")]
            public object Master { get; set; }

            [JsonProperty("parallel_code")]
            public object ParallelCode { get; set; }
        }

        public class Device
        {
            [JsonProperty("sn")]
            public object Sn { get; set; }

            [JsonProperty("isStored")]
            public bool IsStored { get; set; }
        }

        public class Point
        {
            [JsonProperty("target_index")]
            public long TargetIndex { get; set; }

            [JsonProperty("target_name")]
            public string TargetName { get; set; }

            [JsonProperty("display")]
            public string Display { get; set; }

            [JsonProperty("unit")]
            public string Unit { get; set; }

            [JsonProperty("target_key")]
            public string TargetKey { get; set; }

            [JsonProperty("text_cn")]
            public string TextCn { get; set; }

            [JsonProperty("target_sn_six")]
            public object TargetSnSix { get; set; }

            [JsonProperty("target_sn_seven")]
            public object TargetSnSeven { get; set; }

            [JsonProperty("target_type")]
            public object TargetType { get; set; }

            [JsonProperty("storage_name")]
            public object StorageName { get; set; }
        }

        public class Kpi
        {
            [JsonProperty("month_generation")]
            public double MonthGeneration { get; set; }

            [JsonProperty("pac")]
            public long Pac { get; set; }

            [JsonProperty("power")]
            public double Power { get; set; }

            [JsonProperty("total_power")]
            public double TotalPower { get; set; }

            [JsonProperty("day_income")]
            public double DayIncome { get; set; }

            [JsonProperty("total_income")]
            public double TotalIncome { get; set; }

            [JsonProperty("yield_rate")]
            public double YieldRate { get; set; }

            [JsonProperty("currency")]
            public string Currency { get; set; }
        }

        public class Powerflow
        {
            [JsonProperty("pv")]
            public string Pv { get; set; }

            [JsonProperty("pvStatus")]
            public long PvStatus { get; set; }

            [JsonProperty("bettery")]
            public string Bettery { get; set; }

            [JsonProperty("betteryStatus")]
            public long BetteryStatus { get; set; }

            [JsonProperty("betteryStatusStr")]
            public object BetteryStatusStr { get; set; }

            [JsonProperty("load")]
            public string Load { get; set; }

            [JsonProperty("loadStatus")]
            public long LoadStatus { get; set; }

            [JsonProperty("grid")]
            public string Grid { get; set; }

            [JsonProperty("soc")]
            public long Soc { get; set; }

            [JsonProperty("socText")]
            public string SocText { get; set; }

            [JsonProperty("hasEquipment")]
            public bool HasEquipment { get; set; }

            [JsonProperty("gridStatus")]
            public long GridStatus { get; set; }

            [JsonProperty("isHomKit")]
            public bool IsHomKit { get; set; }

            [JsonProperty("isBpuAndInverterNoBattery")]
            public bool IsBpuAndInverterNoBattery { get; set; }

            [JsonProperty("isMoreBettery")]
            public bool IsMoreBettery { get; set; }
        }

        public class Soc
        {
            [JsonProperty("power")]
            public long Power { get; set; }

            [JsonProperty("status")]
            public long Status { get; set; }
        }

    }

