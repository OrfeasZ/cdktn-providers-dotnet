using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiInterface(nativeType: typeof(IEmrserverlessApplicationMonitoringConfiguration), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfiguration")]
    public interface IEmrserverlessApplicationMonitoringConfiguration
    {
        /// <summary>cloudwatch_logging_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#cloudwatch_logging_configuration EmrserverlessApplication#cloudwatch_logging_configuration}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLoggingConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration? CloudwatchLoggingConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>managed_persistence_monitoring_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#managed_persistence_monitoring_configuration EmrserverlessApplication#managed_persistence_monitoring_configuration}
        /// </remarks>
        [JsiiProperty(name: "managedPersistenceMonitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfiguration? ManagedPersistenceMonitoringConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>prometheus_monitoring_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#prometheus_monitoring_configuration EmrserverlessApplication#prometheus_monitoring_configuration}
        /// </remarks>
        [JsiiProperty(name: "prometheusMonitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration? PrometheusMonitoringConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_monitoring_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#s3_monitoring_configuration EmrserverlessApplication#s3_monitoring_configuration}
        /// </remarks>
        [JsiiProperty(name: "s3MonitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration? S3MonitoringConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrserverlessApplicationMonitoringConfiguration), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_logging_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#cloudwatch_logging_configuration EmrserverlessApplication#cloudwatch_logging_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLoggingConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration\"}", isOptional: true)]
            public aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration? CloudwatchLoggingConfiguration
            {
                get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration?>();
            }

            /// <summary>managed_persistence_monitoring_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#managed_persistence_monitoring_configuration EmrserverlessApplication#managed_persistence_monitoring_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedPersistenceMonitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfiguration\"}", isOptional: true)]
            public aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfiguration? ManagedPersistenceMonitoringConfiguration
            {
                get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfiguration?>();
            }

            /// <summary>prometheus_monitoring_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#prometheus_monitoring_configuration EmrserverlessApplication#prometheus_monitoring_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prometheusMonitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration\"}", isOptional: true)]
            public aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration? PrometheusMonitoringConfiguration
            {
                get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration?>();
            }

            /// <summary>s3_monitoring_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#s3_monitoring_configuration EmrserverlessApplication#s3_monitoring_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3MonitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration\"}", isOptional: true)]
            public aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration? S3MonitoringConfiguration
            {
                get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration?>();
            }
        }
    }
}
