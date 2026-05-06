using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationQuery
{
    [JsiiInterface(nativeType: typeof(IMeteringComputationQueryQueryDefinitionReportQuery), fullyQualifiedName: "oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQuery")]
    public interface IMeteringComputationQueryQueryDefinitionReportQuery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#granularity MeteringComputationQuery#granularity}.</summary>
        [JsiiProperty(name: "granularity", typeJson: "{\"primitive\":\"string\"}")]
        string Granularity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#tenant_id MeteringComputationQuery#tenant_id}.</summary>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
        string TenantId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#compartment_depth MeteringComputationQuery#compartment_depth}.</summary>
        [JsiiProperty(name: "compartmentDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CompartmentDepth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#date_range_name MeteringComputationQuery#date_range_name}.</summary>
        [JsiiProperty(name: "dateRangeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DateRangeName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#filter MeteringComputationQuery#filter}.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>forecast block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#forecast MeteringComputationQuery#forecast}
        /// </remarks>
        [JsiiProperty(name: "forecast", typeJson: "{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQueryForecast\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionReportQueryForecast? Forecast
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#group_by MeteringComputationQuery#group_by}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#group_by_tag MeteringComputationQuery#group_by_tag}
        /// </remarks>
        [JsiiProperty(name: "groupByTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQueryGroupByTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GroupByTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#is_aggregate_by_time MeteringComputationQuery#is_aggregate_by_time}.</summary>
        [JsiiProperty(name: "isAggregateByTime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAggregateByTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#query_type MeteringComputationQuery#query_type}.</summary>
        [JsiiProperty(name: "queryType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueryType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#time_usage_ended MeteringComputationQuery#time_usage_ended}.</summary>
        [JsiiProperty(name: "timeUsageEnded", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeUsageEnded
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#time_usage_started MeteringComputationQuery#time_usage_started}.</summary>
        [JsiiProperty(name: "timeUsageStarted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeUsageStarted
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMeteringComputationQueryQueryDefinitionReportQuery), fullyQualifiedName: "oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQuery")]
        internal sealed class _Proxy : DeputyBase, oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionReportQuery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#granularity MeteringComputationQuery#granularity}.</summary>
            [JsiiProperty(name: "granularity", typeJson: "{\"primitive\":\"string\"}")]
            public string Granularity
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#tenant_id MeteringComputationQuery#tenant_id}.</summary>
            [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
            public string TenantId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#compartment_depth MeteringComputationQuery#compartment_depth}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CompartmentDepth
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#date_range_name MeteringComputationQuery#date_range_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dateRangeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DateRangeName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#filter MeteringComputationQuery#filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Filter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>forecast block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#forecast MeteringComputationQuery#forecast}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forecast", typeJson: "{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQueryForecast\"}", isOptional: true)]
            public oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionReportQueryForecast? Forecast
            {
                get => GetInstanceProperty<oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionReportQueryForecast?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#group_by MeteringComputationQuery#group_by}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupBy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? GroupBy
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>group_by_tag block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#group_by_tag MeteringComputationQuery#group_by_tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "groupByTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQueryGroupByTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GroupByTag
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#is_aggregate_by_time MeteringComputationQuery#is_aggregate_by_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isAggregateByTime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAggregateByTime
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#query_type MeteringComputationQuery#query_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueryType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#time_usage_ended MeteringComputationQuery#time_usage_ended}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeUsageEnded", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeUsageEnded
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#time_usage_started MeteringComputationQuery#time_usage_started}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeUsageStarted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeUsageStarted
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
