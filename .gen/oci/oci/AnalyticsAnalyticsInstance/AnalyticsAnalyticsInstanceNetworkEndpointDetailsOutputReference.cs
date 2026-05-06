using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnalyticsAnalyticsInstance
{
    [JsiiClass(nativeType: typeof(oci.AnalyticsAnalyticsInstance.AnalyticsAnalyticsInstanceNetworkEndpointDetailsOutputReference), fullyQualifiedName: "oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceNetworkEndpointDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AnalyticsAnalyticsInstanceNetworkEndpointDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AnalyticsAnalyticsInstanceNetworkEndpointDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AnalyticsAnalyticsInstanceNetworkEndpointDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AnalyticsAnalyticsInstanceNetworkEndpointDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putWhitelistedVcns", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceNetworkEndpointDetailsWhitelistedVcns\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutWhitelistedVcns(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceNetworkEndpointDetailsWhitelistedVcns[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceNetworkEndpointDetailsWhitelistedVcns).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceNetworkEndpointDetailsWhitelistedVcns).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetNetworkSecurityGroupIds")]
        public virtual void ResetNetworkSecurityGroupIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetId")]
        public virtual void ResetSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVcnId")]
        public virtual void ResetVcnId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWhitelistedIps")]
        public virtual void ResetWhitelistedIps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWhitelistedServices")]
        public virtual void ResetWhitelistedServices()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWhitelistedVcns")]
        public virtual void ResetWhitelistedVcns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "whitelistedVcns", typeJson: "{\"fqn\":\"oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceNetworkEndpointDetailsWhitelistedVcnsList\"}")]
        public virtual oci.AnalyticsAnalyticsInstance.AnalyticsAnalyticsInstanceNetworkEndpointDetailsWhitelistedVcnsList WhitelistedVcns
        {
            get => GetInstanceProperty<oci.AnalyticsAnalyticsInstance.AnalyticsAnalyticsInstanceNetworkEndpointDetailsWhitelistedVcnsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkEndpointTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkEndpointTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkSecurityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? NetworkSecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcnIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VcnIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "whitelistedIpsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? WhitelistedIpsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "whitelistedServicesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? WhitelistedServicesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "whitelistedVcnsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceNetworkEndpointDetailsWhitelistedVcns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? WhitelistedVcnsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "networkEndpointType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkEndpointType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NetworkSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcnId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "whitelistedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] WhitelistedIps
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "whitelistedServices", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] WhitelistedServices
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceNetworkEndpointDetails\"}", isOptional: true)]
        public virtual oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceNetworkEndpointDetails? InternalValue
        {
            get => GetInstanceProperty<oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceNetworkEndpointDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
