using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataccVmClusterNetwork
{
    [JsiiClass(nativeType: typeof(oci.DataccVmClusterNetwork.DataccVmClusterNetworkVmNetworksNodesOutputReference), fullyQualifiedName: "oci.dataccVmClusterNetwork.DataccVmClusterNetworkVmNetworksNodesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataccVmClusterNetworkVmNetworksNodesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataccVmClusterNetworkVmNetworksNodesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataccVmClusterNetworkVmNetworksNodesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataccVmClusterNetworkVmNetworksNodesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetVip")]
        public virtual void ResetVip()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVipHostname")]
        public virtual void ResetVipHostname()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vipHostnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VipHostnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vipInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VipInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ip
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vip", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Vip
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vipHostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VipHostname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworksNodes" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dataccVmClusterNetwork.DataccVmClusterNetworkVmNetworksNodes\"}]}}", isOptional: true)]
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
                        case oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworksNodes cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworksNodes).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
