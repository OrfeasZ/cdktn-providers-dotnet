using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaWorkgroup
{
    [JsiiClass(nativeType: typeof(aws.AthenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationOutputReference), fullyQualifiedName: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AthenaWorkgroupConfigurationMonitoringConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AthenaWorkgroupConfigurationMonitoringConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AthenaWorkgroupConfigurationMonitoringConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AthenaWorkgroupConfigurationMonitoringConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudWatchLoggingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration\"}}]")]
        public virtual void PutCloudWatchLoggingConfiguration(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putManagedLoggingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationManagedLoggingConfiguration\"}}]")]
        public virtual void PutManagedLoggingConfiguration(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationManagedLoggingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationManagedLoggingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3LoggingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationS3LoggingConfiguration\"}}]")]
        public virtual void PutS3LoggingConfiguration(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationS3LoggingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationS3LoggingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudWatchLoggingConfiguration")]
        public virtual void ResetCloudWatchLoggingConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedLoggingConfiguration")]
        public virtual void ResetManagedLoggingConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3LoggingConfiguration")]
        public virtual void ResetS3LoggingConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudWatchLoggingConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationOutputReference\"}")]
        public virtual aws.AthenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationOutputReference CloudWatchLoggingConfiguration
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "managedLoggingConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationManagedLoggingConfigurationOutputReference\"}")]
        public virtual aws.AthenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationManagedLoggingConfigurationOutputReference ManagedLoggingConfiguration
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationManagedLoggingConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "s3LoggingConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationS3LoggingConfigurationOutputReference\"}")]
        public virtual aws.AthenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationS3LoggingConfigurationOutputReference S3LoggingConfiguration
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationS3LoggingConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudWatchLoggingConfigurationInput", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration\"}", isOptional: true)]
        public virtual aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration? CloudWatchLoggingConfigurationInput
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedLoggingConfigurationInput", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationManagedLoggingConfiguration\"}", isOptional: true)]
        public virtual aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationManagedLoggingConfiguration? ManagedLoggingConfigurationInput
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationManagedLoggingConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3LoggingConfigurationInput", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationS3LoggingConfiguration\"}", isOptional: true)]
        public virtual aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationS3LoggingConfiguration? S3LoggingConfigurationInput
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationS3LoggingConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfiguration\"}", isOptional: true)]
        public virtual aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
