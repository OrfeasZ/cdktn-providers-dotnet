using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiClass(nativeType: typeof(aws.EmrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationOutputReference), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EmrserverlessApplicationMonitoringConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EmrserverlessApplicationMonitoringConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrserverlessApplicationMonitoringConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrserverlessApplicationMonitoringConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchLoggingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration\"}}]")]
        public virtual void PutCloudwatchLoggingConfiguration(aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putManagedPersistenceMonitoringConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfiguration\"}}]")]
        public virtual void PutManagedPersistenceMonitoringConfiguration(aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPrometheusMonitoringConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration\"}}]")]
        public virtual void PutPrometheusMonitoringConfiguration(aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3MonitoringConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration\"}}]")]
        public virtual void PutS3MonitoringConfiguration(aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchLoggingConfiguration")]
        public virtual void ResetCloudwatchLoggingConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedPersistenceMonitoringConfiguration")]
        public virtual void ResetManagedPersistenceMonitoringConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrometheusMonitoringConfiguration")]
        public virtual void ResetPrometheusMonitoringConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3MonitoringConfiguration")]
        public virtual void ResetS3MonitoringConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudwatchLoggingConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationOutputReference\"}")]
        public virtual aws.EmrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationOutputReference CloudwatchLoggingConfiguration
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "managedPersistenceMonitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfigurationOutputReference\"}")]
        public virtual aws.EmrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfigurationOutputReference ManagedPersistenceMonitoringConfiguration
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "prometheusMonitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfigurationOutputReference\"}")]
        public virtual aws.EmrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfigurationOutputReference PrometheusMonitoringConfiguration
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "s3MonitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationS3MonitoringConfigurationOutputReference\"}")]
        public virtual aws.EmrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationS3MonitoringConfigurationOutputReference S3MonitoringConfiguration
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationS3MonitoringConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLoggingConfigurationInput", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration\"}", isOptional: true)]
        public virtual aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration? CloudwatchLoggingConfigurationInput
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedPersistenceMonitoringConfigurationInput", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfiguration\"}", isOptional: true)]
        public virtual aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfiguration? ManagedPersistenceMonitoringConfigurationInput
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prometheusMonitoringConfigurationInput", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration\"}", isOptional: true)]
        public virtual aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration? PrometheusMonitoringConfigurationInput
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3MonitoringConfigurationInput", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration\"}", isOptional: true)]
        public virtual aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration? S3MonitoringConfigurationInput
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfiguration\"}", isOptional: true)]
        public virtual aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
