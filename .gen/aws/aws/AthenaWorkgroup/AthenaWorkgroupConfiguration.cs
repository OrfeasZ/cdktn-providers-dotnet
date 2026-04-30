using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaWorkgroup
{
    [JsiiByValue(fqn: "aws.athenaWorkgroup.AthenaWorkgroupConfiguration")]
    public class AthenaWorkgroupConfiguration : aws.AthenaWorkgroup.IAthenaWorkgroupConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#bytes_scanned_cutoff_per_query AthenaWorkgroup#bytes_scanned_cutoff_per_query}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bytesScannedCutoffPerQuery", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BytesScannedCutoffPerQuery
        {
            get;
            set;
        }

        /// <summary>customer_content_encryption_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#customer_content_encryption_configuration AthenaWorkgroup#customer_content_encryption_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customerContentEncryptionConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration\"}", isOptional: true)]
        public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration? CustomerContentEncryptionConfiguration
        {
            get;
            set;
        }

        private object? _enableMinimumEncryptionConfiguration;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#enable_minimum_encryption_configuration AthenaWorkgroup#enable_minimum_encryption_configuration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableMinimumEncryptionConfiguration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableMinimumEncryptionConfiguration
        {
            get => _enableMinimumEncryptionConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enableMinimumEncryptionConfiguration = value;
            }
        }

        private object? _enforceWorkgroupConfiguration;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#enforce_workgroup_configuration AthenaWorkgroup#enforce_workgroup_configuration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enforceWorkgroupConfiguration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnforceWorkgroupConfiguration
        {
            get => _enforceWorkgroupConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enforceWorkgroupConfiguration = value;
            }
        }

        /// <summary>engine_version block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#engine_version AthenaWorkgroup#engine_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "engineVersion", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationEngineVersion\"}", isOptional: true)]
        public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationEngineVersion? EngineVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#execution_role AthenaWorkgroup#execution_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExecutionRole
        {
            get;
            set;
        }

        /// <summary>identity_center_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#identity_center_configuration AthenaWorkgroup#identity_center_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityCenterConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationIdentityCenterConfiguration\"}", isOptional: true)]
        public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationIdentityCenterConfiguration? IdentityCenterConfiguration
        {
            get;
            set;
        }

        /// <summary>managed_query_results_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#managed_query_results_configuration AthenaWorkgroup#managed_query_results_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedQueryResultsConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationManagedQueryResultsConfiguration\"}", isOptional: true)]
        public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationManagedQueryResultsConfiguration? ManagedQueryResultsConfiguration
        {
            get;
            set;
        }

        /// <summary>monitoring_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#monitoring_configuration AthenaWorkgroup#monitoring_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monitoringConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfiguration\"}", isOptional: true)]
        public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfiguration? MonitoringConfiguration
        {
            get;
            set;
        }

        private object? _publishCloudwatchMetricsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#publish_cloudwatch_metrics_enabled AthenaWorkgroup#publish_cloudwatch_metrics_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publishCloudwatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? PublishCloudwatchMetricsEnabled
        {
            get => _publishCloudwatchMetricsEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _publishCloudwatchMetricsEnabled = value;
            }
        }

        /// <summary>query_results_s3_access_grants_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#query_results_s3_access_grants_configuration AthenaWorkgroup#query_results_s3_access_grants_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryResultsS3AccessGrantsConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationQueryResultsS3AccessGrantsConfiguration\"}", isOptional: true)]
        public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationQueryResultsS3AccessGrantsConfiguration? QueryResultsS3AccessGrantsConfiguration
        {
            get;
            set;
        }

        private object? _requesterPaysEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#requester_pays_enabled AthenaWorkgroup#requester_pays_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requesterPaysEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RequesterPaysEnabled
        {
            get => _requesterPaysEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requesterPaysEnabled = value;
            }
        }

        /// <summary>result_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#result_configuration AthenaWorkgroup#result_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resultConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationResultConfiguration\"}", isOptional: true)]
        public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationResultConfiguration? ResultConfiguration
        {
            get;
            set;
        }
    }
}
