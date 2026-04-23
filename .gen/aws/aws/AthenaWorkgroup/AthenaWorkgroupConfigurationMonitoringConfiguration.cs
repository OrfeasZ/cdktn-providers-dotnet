using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaWorkgroup
{
    [JsiiByValue(fqn: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfiguration")]
    public class AthenaWorkgroupConfigurationMonitoringConfiguration : aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfiguration
    {
        /// <summary>cloud_watch_logging_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/athena_workgroup#cloud_watch_logging_configuration AthenaWorkgroup#cloud_watch_logging_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudWatchLoggingConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration\"}", isOptional: true)]
        public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration? CloudWatchLoggingConfiguration
        {
            get;
            set;
        }

        /// <summary>managed_logging_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/athena_workgroup#managed_logging_configuration AthenaWorkgroup#managed_logging_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedLoggingConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationManagedLoggingConfiguration\"}", isOptional: true)]
        public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationManagedLoggingConfiguration? ManagedLoggingConfiguration
        {
            get;
            set;
        }

        /// <summary>s3_logging_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/athena_workgroup#s3_logging_configuration AthenaWorkgroup#s3_logging_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3LoggingConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationS3LoggingConfiguration\"}", isOptional: true)]
        public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationS3LoggingConfiguration? S3LoggingConfiguration
        {
            get;
            set;
        }
    }
}
