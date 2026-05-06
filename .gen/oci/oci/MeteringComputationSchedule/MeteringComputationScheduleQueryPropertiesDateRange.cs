using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.meteringComputationSchedule.MeteringComputationScheduleQueryPropertiesDateRange")]
    public class MeteringComputationScheduleQueryPropertiesDateRange : oci.MeteringComputationSchedule.IMeteringComputationScheduleQueryPropertiesDateRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#date_range_type MeteringComputationSchedule#date_range_type}.</summary>
        [JsiiProperty(name: "dateRangeType", typeJson: "{\"primitive\":\"string\"}")]
        public string DateRangeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#dynamic_date_range_type MeteringComputationSchedule#dynamic_date_range_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dynamicDateRangeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DynamicDateRangeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#time_usage_ended MeteringComputationSchedule#time_usage_ended}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeUsageEnded", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeUsageEnded
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#time_usage_started MeteringComputationSchedule#time_usage_started}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeUsageStarted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeUsageStarted
        {
            get;
            set;
        }
    }
}
