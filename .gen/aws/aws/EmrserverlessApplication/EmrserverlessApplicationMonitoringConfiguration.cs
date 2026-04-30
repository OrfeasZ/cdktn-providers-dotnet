using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiByValue(fqn: "aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfiguration")]
    public class EmrserverlessApplicationMonitoringConfiguration : aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfiguration
    {
        /// <summary>cloudwatch_logging_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#cloudwatch_logging_configuration EmrserverlessApplication#cloudwatch_logging_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLoggingConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration\"}", isOptional: true)]
        public aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration? CloudwatchLoggingConfiguration
        {
            get;
            set;
        }

        /// <summary>managed_persistence_monitoring_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#managed_persistence_monitoring_configuration EmrserverlessApplication#managed_persistence_monitoring_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedPersistenceMonitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfiguration\"}", isOptional: true)]
        public aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfiguration? ManagedPersistenceMonitoringConfiguration
        {
            get;
            set;
        }

        /// <summary>prometheus_monitoring_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#prometheus_monitoring_configuration EmrserverlessApplication#prometheus_monitoring_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "prometheusMonitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration\"}", isOptional: true)]
        public aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration? PrometheusMonitoringConfiguration
        {
            get;
            set;
        }

        /// <summary>s3_monitoring_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#s3_monitoring_configuration EmrserverlessApplication#s3_monitoring_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3MonitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration\"}", isOptional: true)]
        public aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration? S3MonitoringConfiguration
        {
            get;
            set;
        }
    }
}
