using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetails")]
    public class CloudGuardDataSourceDataSourceDetails : oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#data_source_feed_provider CloudGuardDataSource#data_source_feed_provider}.</summary>
        [JsiiProperty(name: "dataSourceFeedProvider", typeJson: "{\"primitive\":\"string\"}")]
        public string DataSourceFeedProvider
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#additional_entities_count CloudGuardDataSource#additional_entities_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalEntitiesCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AdditionalEntitiesCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#description CloudGuardDataSource#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#interval_in_minutes CloudGuardDataSource#interval_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "intervalInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IntervalInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#interval_in_seconds CloudGuardDataSource#interval_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "intervalInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IntervalInSeconds
        {
            get;
            set;
        }

        /// <summary>logging_query_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#logging_query_details CloudGuardDataSource#logging_query_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loggingQueryDetails", typeJson: "{\"fqn\":\"oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsLoggingQueryDetails\"}", isOptional: true)]
        public oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetailsLoggingQueryDetails? LoggingQueryDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#logging_query_type CloudGuardDataSource#logging_query_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loggingQueryType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LoggingQueryType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#operator CloudGuardDataSource#operator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Operator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#query CloudGuardDataSource#query}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Query
        {
            get;
            set;
        }

        /// <summary>query_start_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#query_start_time CloudGuardDataSource#query_start_time}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryStartTime", typeJson: "{\"fqn\":\"oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsQueryStartTime\"}", isOptional: true)]
        public oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetailsQueryStartTime? QueryStartTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#regions CloudGuardDataSource#regions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Regions
        {
            get;
            set;
        }

        private object? _scheduledQueryScopeDetails;

        /// <summary>scheduled_query_scope_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#scheduled_query_scope_details CloudGuardDataSource#scheduled_query_scope_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scheduledQueryScopeDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsScheduledQueryScopeDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ScheduledQueryScopeDetails
        {
            get => _scheduledQueryScopeDetails;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetailsScheduledQueryScopeDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetailsScheduledQueryScopeDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scheduledQueryScopeDetails = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#threshold CloudGuardDataSource#threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Threshold
        {
            get;
            set;
        }
    }
}
