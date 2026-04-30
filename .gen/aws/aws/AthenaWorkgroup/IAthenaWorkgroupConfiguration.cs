using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaWorkgroup
{
    [JsiiInterface(nativeType: typeof(IAthenaWorkgroupConfiguration), fullyQualifiedName: "aws.athenaWorkgroup.AthenaWorkgroupConfiguration")]
    public interface IAthenaWorkgroupConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#bytes_scanned_cutoff_per_query AthenaWorkgroup#bytes_scanned_cutoff_per_query}.</summary>
        [JsiiProperty(name: "bytesScannedCutoffPerQuery", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BytesScannedCutoffPerQuery
        {
            get
            {
                return null;
            }
        }

        /// <summary>customer_content_encryption_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#customer_content_encryption_configuration AthenaWorkgroup#customer_content_encryption_configuration}
        /// </remarks>
        [JsiiProperty(name: "customerContentEncryptionConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration? CustomerContentEncryptionConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#enable_minimum_encryption_configuration AthenaWorkgroup#enable_minimum_encryption_configuration}.</summary>
        [JsiiProperty(name: "enableMinimumEncryptionConfiguration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableMinimumEncryptionConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#enforce_workgroup_configuration AthenaWorkgroup#enforce_workgroup_configuration}.</summary>
        [JsiiProperty(name: "enforceWorkgroupConfiguration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnforceWorkgroupConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>engine_version block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#engine_version AthenaWorkgroup#engine_version}
        /// </remarks>
        [JsiiProperty(name: "engineVersion", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationEngineVersion\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationEngineVersion? EngineVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#execution_role AthenaWorkgroup#execution_role}.</summary>
        [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExecutionRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>identity_center_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#identity_center_configuration AthenaWorkgroup#identity_center_configuration}
        /// </remarks>
        [JsiiProperty(name: "identityCenterConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationIdentityCenterConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationIdentityCenterConfiguration? IdentityCenterConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>managed_query_results_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#managed_query_results_configuration AthenaWorkgroup#managed_query_results_configuration}
        /// </remarks>
        [JsiiProperty(name: "managedQueryResultsConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationManagedQueryResultsConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationManagedQueryResultsConfiguration? ManagedQueryResultsConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>monitoring_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#monitoring_configuration AthenaWorkgroup#monitoring_configuration}
        /// </remarks>
        [JsiiProperty(name: "monitoringConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfiguration? MonitoringConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#publish_cloudwatch_metrics_enabled AthenaWorkgroup#publish_cloudwatch_metrics_enabled}.</summary>
        [JsiiProperty(name: "publishCloudwatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PublishCloudwatchMetricsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_results_s3_access_grants_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#query_results_s3_access_grants_configuration AthenaWorkgroup#query_results_s3_access_grants_configuration}
        /// </remarks>
        [JsiiProperty(name: "queryResultsS3AccessGrantsConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationQueryResultsS3AccessGrantsConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationQueryResultsS3AccessGrantsConfiguration? QueryResultsS3AccessGrantsConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#requester_pays_enabled AthenaWorkgroup#requester_pays_enabled}.</summary>
        [JsiiProperty(name: "requesterPaysEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequesterPaysEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>result_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#result_configuration AthenaWorkgroup#result_configuration}
        /// </remarks>
        [JsiiProperty(name: "resultConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationResultConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationResultConfiguration? ResultConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAthenaWorkgroupConfiguration), fullyQualifiedName: "aws.athenaWorkgroup.AthenaWorkgroupConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.AthenaWorkgroup.IAthenaWorkgroupConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#bytes_scanned_cutoff_per_query AthenaWorkgroup#bytes_scanned_cutoff_per_query}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bytesScannedCutoffPerQuery", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BytesScannedCutoffPerQuery
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>customer_content_encryption_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#customer_content_encryption_configuration AthenaWorkgroup#customer_content_encryption_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customerContentEncryptionConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration\"}", isOptional: true)]
            public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration? CustomerContentEncryptionConfiguration
            {
                get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#enable_minimum_encryption_configuration AthenaWorkgroup#enable_minimum_encryption_configuration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableMinimumEncryptionConfiguration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableMinimumEncryptionConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#enforce_workgroup_configuration AthenaWorkgroup#enforce_workgroup_configuration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enforceWorkgroupConfiguration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnforceWorkgroupConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>engine_version block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#engine_version AthenaWorkgroup#engine_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "engineVersion", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationEngineVersion\"}", isOptional: true)]
            public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationEngineVersion? EngineVersion
            {
                get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationEngineVersion?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#execution_role AthenaWorkgroup#execution_role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExecutionRole
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>identity_center_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#identity_center_configuration AthenaWorkgroup#identity_center_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identityCenterConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationIdentityCenterConfiguration\"}", isOptional: true)]
            public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationIdentityCenterConfiguration? IdentityCenterConfiguration
            {
                get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationIdentityCenterConfiguration?>();
            }

            /// <summary>managed_query_results_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#managed_query_results_configuration AthenaWorkgroup#managed_query_results_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedQueryResultsConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationManagedQueryResultsConfiguration\"}", isOptional: true)]
            public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationManagedQueryResultsConfiguration? ManagedQueryResultsConfiguration
            {
                get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationManagedQueryResultsConfiguration?>();
            }

            /// <summary>monitoring_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#monitoring_configuration AthenaWorkgroup#monitoring_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monitoringConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfiguration\"}", isOptional: true)]
            public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfiguration? MonitoringConfiguration
            {
                get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#publish_cloudwatch_metrics_enabled AthenaWorkgroup#publish_cloudwatch_metrics_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publishCloudwatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PublishCloudwatchMetricsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>query_results_s3_access_grants_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#query_results_s3_access_grants_configuration AthenaWorkgroup#query_results_s3_access_grants_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryResultsS3AccessGrantsConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationQueryResultsS3AccessGrantsConfiguration\"}", isOptional: true)]
            public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationQueryResultsS3AccessGrantsConfiguration? QueryResultsS3AccessGrantsConfiguration
            {
                get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationQueryResultsS3AccessGrantsConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#requester_pays_enabled AthenaWorkgroup#requester_pays_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requesterPaysEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequesterPaysEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>result_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#result_configuration AthenaWorkgroup#result_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resultConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationResultConfiguration\"}", isOptional: true)]
            public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationResultConfiguration? ResultConfiguration
            {
                get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationResultConfiguration?>();
            }
        }
    }
}
