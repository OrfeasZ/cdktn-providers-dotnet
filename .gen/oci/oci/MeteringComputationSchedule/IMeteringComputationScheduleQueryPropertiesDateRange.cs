using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationSchedule
{
    [JsiiInterface(nativeType: typeof(IMeteringComputationScheduleQueryPropertiesDateRange), fullyQualifiedName: "oci.meteringComputationSchedule.MeteringComputationScheduleQueryPropertiesDateRange")]
    public interface IMeteringComputationScheduleQueryPropertiesDateRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#date_range_type MeteringComputationSchedule#date_range_type}.</summary>
        [JsiiProperty(name: "dateRangeType", typeJson: "{\"primitive\":\"string\"}")]
        string DateRangeType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#dynamic_date_range_type MeteringComputationSchedule#dynamic_date_range_type}.</summary>
        [JsiiProperty(name: "dynamicDateRangeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DynamicDateRangeType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#time_usage_ended MeteringComputationSchedule#time_usage_ended}.</summary>
        [JsiiProperty(name: "timeUsageEnded", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeUsageEnded
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#time_usage_started MeteringComputationSchedule#time_usage_started}.</summary>
        [JsiiProperty(name: "timeUsageStarted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeUsageStarted
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMeteringComputationScheduleQueryPropertiesDateRange), fullyQualifiedName: "oci.meteringComputationSchedule.MeteringComputationScheduleQueryPropertiesDateRange")]
        internal sealed class _Proxy : DeputyBase, oci.MeteringComputationSchedule.IMeteringComputationScheduleQueryPropertiesDateRange
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#date_range_type MeteringComputationSchedule#date_range_type}.</summary>
            [JsiiProperty(name: "dateRangeType", typeJson: "{\"primitive\":\"string\"}")]
            public string DateRangeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#dynamic_date_range_type MeteringComputationSchedule#dynamic_date_range_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dynamicDateRangeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DynamicDateRangeType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#time_usage_ended MeteringComputationSchedule#time_usage_ended}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeUsageEnded", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeUsageEnded
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#time_usage_started MeteringComputationSchedule#time_usage_started}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeUsageStarted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeUsageStarted
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
