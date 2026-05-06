using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiClass(nativeType: typeof(oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsOutputReference), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApmSyntheticsMonitorConfigurationClientCertificateDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApmSyntheticsMonitorConfigurationClientCertificateDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApmSyntheticsMonitorConfigurationClientCertificateDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApmSyntheticsMonitorConfigurationClientCertificateDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClientCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate\"}}]")]
        public virtual void PutClientCertificate(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPrivateKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsPrivateKey\"}}]")]
        public virtual void PutPrivateKey(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetailsPrivateKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetailsPrivateKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClientCertificate")]
        public virtual void ResetClientCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateKey")]
        public virtual void ResetPrivateKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "clientCertificate", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificateOutputReference\"}")]
        public virtual oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificateOutputReference ClientCertificate
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "privateKey", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsPrivateKeyOutputReference\"}")]
        public virtual oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsPrivateKeyOutputReference PrivateKey
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsPrivateKeyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateInput", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate\"}", isOptional: true)]
        public virtual oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate? ClientCertificateInput
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetailsClientCertificate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateKeyInput", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetailsPrivateKey\"}", isOptional: true)]
        public virtual oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetailsPrivateKey? PrivateKeyInput
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetailsPrivateKey?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationClientCertificateDetails\"}", isOptional: true)]
        public virtual oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetails? InternalValue
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationClientCertificateDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
