using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiClass(nativeType: typeof(aws.EmrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfigurationOutputReference), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetRemoteWriteUrl")]
        public virtual void ResetRemoteWriteUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "remoteWriteUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RemoteWriteUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "remoteWriteUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemoteWriteUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration\"}", isOptional: true)]
        public virtual aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
