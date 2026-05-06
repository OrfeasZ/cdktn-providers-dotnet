using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkLoadBalancerBackendSet
{
    [JsiiClass(nativeType: typeof(oci.NetworkLoadBalancerBackendSet.NetworkLoadBalancerBackendSetHealthCheckerOutputReference), fullyQualifiedName: "oci.networkLoadBalancerBackendSet.NetworkLoadBalancerBackendSetHealthCheckerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetworkLoadBalancerBackendSetHealthCheckerOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetworkLoadBalancerBackendSetHealthCheckerOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NetworkLoadBalancerBackendSetHealthCheckerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkLoadBalancerBackendSetHealthCheckerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDns", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.networkLoadBalancerBackendSet.NetworkLoadBalancerBackendSetHealthCheckerDns\"}}]")]
        public virtual void PutDns(oci.NetworkLoadBalancerBackendSet.INetworkLoadBalancerBackendSetHealthCheckerDns @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.NetworkLoadBalancerBackendSet.INetworkLoadBalancerBackendSetHealthCheckerDns)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDns")]
        public virtual void ResetDns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIntervalInMillis")]
        public virtual void ResetIntervalInMillis()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPort")]
        public virtual void ResetPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestData")]
        public virtual void ResetRequestData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResponseBodyRegex")]
        public virtual void ResetResponseBodyRegex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResponseData")]
        public virtual void ResetResponseData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetries")]
        public virtual void ResetRetries()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReturnCode")]
        public virtual void ResetReturnCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeoutInMillis")]
        public virtual void ResetTimeoutInMillis()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrlPath")]
        public virtual void ResetUrlPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"oci.networkLoadBalancerBackendSet.NetworkLoadBalancerBackendSetHealthCheckerDnsOutputReference\"}")]
        public virtual oci.NetworkLoadBalancerBackendSet.NetworkLoadBalancerBackendSetHealthCheckerDnsOutputReference Dns
        {
            get => GetInstanceProperty<oci.NetworkLoadBalancerBackendSet.NetworkLoadBalancerBackendSetHealthCheckerDnsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsInput", typeJson: "{\"fqn\":\"oci.networkLoadBalancerBackendSet.NetworkLoadBalancerBackendSetHealthCheckerDns\"}", isOptional: true)]
        public virtual oci.NetworkLoadBalancerBackendSet.INetworkLoadBalancerBackendSetHealthCheckerDns? DnsInput
        {
            get => GetInstanceProperty<oci.NetworkLoadBalancerBackendSet.INetworkLoadBalancerBackendSetHealthCheckerDns?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "intervalInMillisInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IntervalInMillisInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestDataInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequestDataInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseBodyRegexInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResponseBodyRegexInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseDataInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResponseDataInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retriesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetriesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "returnCodeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReturnCodeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInMillisInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimeoutInMillisInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UrlPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "intervalInMillis", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IntervalInMillis
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestData
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "responseBodyRegex", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseBodyRegex
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "responseData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseData
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Retries
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "returnCode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReturnCode
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeoutInMillis", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeoutInMillis
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "urlPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UrlPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.networkLoadBalancerBackendSet.NetworkLoadBalancerBackendSetHealthChecker\"}", isOptional: true)]
        public virtual oci.NetworkLoadBalancerBackendSet.INetworkLoadBalancerBackendSetHealthChecker? InternalValue
        {
            get => GetInstanceProperty<oci.NetworkLoadBalancerBackendSet.INetworkLoadBalancerBackendSetHealthChecker?>();
            set => SetInstanceProperty(value);
        }
    }
}
