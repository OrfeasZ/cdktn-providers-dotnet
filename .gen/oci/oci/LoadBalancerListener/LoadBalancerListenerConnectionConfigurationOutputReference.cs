using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerListener
{
    [JsiiClass(nativeType: typeof(oci.LoadBalancerListener.LoadBalancerListenerConnectionConfigurationOutputReference), fullyQualifiedName: "oci.loadBalancerListener.LoadBalancerListenerConnectionConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LoadBalancerListenerConnectionConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LoadBalancerListenerConnectionConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LoadBalancerListenerConnectionConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadBalancerListenerConnectionConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBackendTcpProxyProtocolOptions")]
        public virtual void ResetBackendTcpProxyProtocolOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackendTcpProxyProtocolVersion")]
        public virtual void ResetBackendTcpProxyProtocolVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "backendTcpProxyProtocolOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? BackendTcpProxyProtocolOptionsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backendTcpProxyProtocolVersionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BackendTcpProxyProtocolVersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idleTimeoutInSecondsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdleTimeoutInSecondsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "backendTcpProxyProtocolOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] BackendTcpProxyProtocolOptions
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "backendTcpProxyProtocolVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackendTcpProxyProtocolVersion
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "idleTimeoutInSeconds", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdleTimeoutInSeconds
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.loadBalancerListener.LoadBalancerListenerConnectionConfiguration\"}", isOptional: true)]
        public virtual oci.LoadBalancerListener.ILoadBalancerListenerConnectionConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.LoadBalancerListener.ILoadBalancerListenerConnectionConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
