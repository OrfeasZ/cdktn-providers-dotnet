using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaWorkgroup
{
    [JsiiInterface(nativeType: typeof(IAthenaWorkgroupConfigurationMonitoringConfiguration), fullyQualifiedName: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfiguration")]
    public interface IAthenaWorkgroupConfigurationMonitoringConfiguration
    {
        /// <summary>cloud_watch_logging_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/athena_workgroup#cloud_watch_logging_configuration AthenaWorkgroup#cloud_watch_logging_configuration}
        /// </remarks>
        [JsiiProperty(name: "cloudWatchLoggingConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration? CloudWatchLoggingConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>managed_logging_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/athena_workgroup#managed_logging_configuration AthenaWorkgroup#managed_logging_configuration}
        /// </remarks>
        [JsiiProperty(name: "managedLoggingConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationManagedLoggingConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationManagedLoggingConfiguration? ManagedLoggingConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_logging_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/athena_workgroup#s3_logging_configuration AthenaWorkgroup#s3_logging_configuration}
        /// </remarks>
        [JsiiProperty(name: "s3LoggingConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationS3LoggingConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationS3LoggingConfiguration? S3LoggingConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAthenaWorkgroupConfigurationMonitoringConfiguration), fullyQualifiedName: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloud_watch_logging_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/athena_workgroup#cloud_watch_logging_configuration AthenaWorkgroup#cloud_watch_logging_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudWatchLoggingConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration\"}", isOptional: true)]
            public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration? CloudWatchLoggingConfiguration
            {
                get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration?>();
            }

            /// <summary>managed_logging_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/athena_workgroup#managed_logging_configuration AthenaWorkgroup#managed_logging_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedLoggingConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationManagedLoggingConfiguration\"}", isOptional: true)]
            public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationManagedLoggingConfiguration? ManagedLoggingConfiguration
            {
                get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationManagedLoggingConfiguration?>();
            }

            /// <summary>s3_logging_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/athena_workgroup#s3_logging_configuration AthenaWorkgroup#s3_logging_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3LoggingConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationS3LoggingConfiguration\"}", isOptional: true)]
            public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationS3LoggingConfiguration? S3LoggingConfiguration
            {
                get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationS3LoggingConfiguration?>();
            }
        }
    }
}
