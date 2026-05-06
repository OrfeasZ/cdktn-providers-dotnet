using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationSchedule
{
    [JsiiInterface(nativeType: typeof(IMeteringComputationScheduleQueryProperties), fullyQualifiedName: "oci.meteringComputationSchedule.MeteringComputationScheduleQueryProperties")]
    public interface IMeteringComputationScheduleQueryProperties
    {
        /// <summary>date_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#date_range MeteringComputationSchedule#date_range}
        /// </remarks>
        [JsiiProperty(name: "dateRange", typeJson: "{\"fqn\":\"oci.meteringComputationSchedule.MeteringComputationScheduleQueryPropertiesDateRange\"}")]
        oci.MeteringComputationSchedule.IMeteringComputationScheduleQueryPropertiesDateRange DateRange
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#granularity MeteringComputationSchedule#granularity}.</summary>
        [JsiiProperty(name: "granularity", typeJson: "{\"primitive\":\"string\"}")]
        string Granularity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#compartment_depth MeteringComputationSchedule#compartment_depth}.</summary>
        [JsiiProperty(name: "compartmentDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CompartmentDepth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#filter MeteringComputationSchedule#filter}.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#group_by MeteringComputationSchedule#group_by}.</summary>
        [JsiiProperty(name: "groupBy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? GroupBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>group_by_tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#group_by_tag MeteringComputationSchedule#group_by_tag}
        /// </remarks>
        [JsiiProperty(name: "groupByTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.meteringComputationSchedule.MeteringComputationScheduleQueryPropertiesGroupByTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GroupByTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#is_aggregate_by_time MeteringComputationSchedule#is_aggregate_by_time}.</summary>
        [JsiiProperty(name: "isAggregateByTime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAggregateByTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#query_type MeteringComputationSchedule#query_type}.</summary>
        [JsiiProperty(name: "queryType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueryType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMeteringComputationScheduleQueryProperties), fullyQualifiedName: "oci.meteringComputationSchedule.MeteringComputationScheduleQueryProperties")]
        internal sealed class _Proxy : DeputyBase, oci.MeteringComputationSchedule.IMeteringComputationScheduleQueryProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>date_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#date_range MeteringComputationSchedule#date_range}
            /// </remarks>
            [JsiiProperty(name: "dateRange", typeJson: "{\"fqn\":\"oci.meteringComputationSchedule.MeteringComputationScheduleQueryPropertiesDateRange\"}")]
            public oci.MeteringComputationSchedule.IMeteringComputationScheduleQueryPropertiesDateRange DateRange
            {
                get => GetInstanceProperty<oci.MeteringComputationSchedule.IMeteringComputationScheduleQueryPropertiesDateRange>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#granularity MeteringComputationSchedule#granularity}.</summary>
            [JsiiProperty(name: "granularity", typeJson: "{\"primitive\":\"string\"}")]
            public string Granularity
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#compartment_depth MeteringComputationSchedule#compartment_depth}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CompartmentDepth
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#filter MeteringComputationSchedule#filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Filter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#group_by MeteringComputationSchedule#group_by}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupBy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? GroupBy
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>group_by_tag block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#group_by_tag MeteringComputationSchedule#group_by_tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "groupByTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.meteringComputationSchedule.MeteringComputationScheduleQueryPropertiesGroupByTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GroupByTag
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#is_aggregate_by_time MeteringComputationSchedule#is_aggregate_by_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isAggregateByTime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAggregateByTime
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_schedule#query_type MeteringComputationSchedule#query_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueryType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
