using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiClass(nativeType: typeof(libvirt.Network.NetworkBandwidthOutputReference), fullyQualifiedName: "libvirt.network.NetworkBandwidthOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetworkBandwidthOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetworkBandwidthOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NetworkBandwidthOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkBandwidthOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInbound", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkBandwidthInbound\"}}]")]
        public virtual void PutInbound(libvirt.Network.INetworkBandwidthInbound @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkBandwidthInbound)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutbound", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkBandwidthOutbound\"}}]")]
        public virtual void PutOutbound(libvirt.Network.INetworkBandwidthOutbound @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkBandwidthOutbound)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClassId")]
        public virtual void ResetClassId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInbound")]
        public virtual void ResetInbound()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutbound")]
        public virtual void ResetOutbound()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "inbound", typeJson: "{\"fqn\":\"libvirt.network.NetworkBandwidthInboundOutputReference\"}")]
        public virtual libvirt.Network.NetworkBandwidthInboundOutputReference Inbound
        {
            get => GetInstanceProperty<libvirt.Network.NetworkBandwidthInboundOutputReference>()!;
        }

        [JsiiProperty(name: "outbound", typeJson: "{\"fqn\":\"libvirt.network.NetworkBandwidthOutboundOutputReference\"}")]
        public virtual libvirt.Network.NetworkBandwidthOutboundOutputReference Outbound
        {
            get => GetInstanceProperty<libvirt.Network.NetworkBandwidthOutboundOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "classIdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ClassIdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inboundInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkBandwidthInbound\"}]}}", isOptional: true)]
        public virtual object? InboundInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outboundInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkBandwidthOutbound\"}]}}", isOptional: true)]
        public virtual object? OutboundInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "classId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ClassId
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkBandwidth\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Network.INetworkBandwidth cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkBandwidth).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
