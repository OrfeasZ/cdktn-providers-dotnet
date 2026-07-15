using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataccVmClusterNetwork
{
    [JsiiClass(nativeType: typeof(oci.DataccVmClusterNetwork.DataccVmClusterNetworkVmNetworksOutputReference), fullyQualifiedName: "oci.dataccVmClusterNetwork.DataccVmClusterNetworkVmNetworksOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataccVmClusterNetworkVmNetworksOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataccVmClusterNetworkVmNetworksOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataccVmClusterNetworkVmNetworksOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataccVmClusterNetworkVmNetworksOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworksNodes" />)[]</param>
        [JsiiMethod(name: "putNodes", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataccVmClusterNetwork.DataccVmClusterNetworkVmNetworksNodes\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNodes(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworksNodes[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworksNodes).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworksNodes).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPrefix")]
        public virtual void ResetPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVlanId")]
        public virtual void ResetVlanId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "nodes", typeJson: "{\"fqn\":\"oci.dataccVmClusterNetwork.DataccVmClusterNetworkVmNetworksNodesList\"}")]
        public virtual oci.DataccVmClusterNetwork.DataccVmClusterNetworkVmNetworksNodesList Nodes
        {
            get => GetInstanceProperty<oci.DataccVmClusterNetwork.DataccVmClusterNetworkVmNetworksNodesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GatewayInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netmaskInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetmaskInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworksNodes" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataccVmClusterNetwork.DataccVmClusterNetworkVmNetworksNodes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NodesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vlanIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VlanIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Gateway
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Netmask
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VlanId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworks" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dataccVmClusterNetwork.DataccVmClusterNetworkVmNetworks\"}]}}", isOptional: true)]
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
                        case oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworks cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataccVmClusterNetwork.IDataccVmClusterNetworkVmNetworks).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
