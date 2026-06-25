using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiClass(nativeType: typeof(libvirt.Network.NetworkIpsDhcpRangesOutputReference), fullyQualifiedName: "libvirt.network.NetworkIpsDhcpRangesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class NetworkIpsDhcpRangesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public NetworkIpsDhcpRangesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected NetworkIpsDhcpRangesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkIpsDhcpRangesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLease", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkIpsDhcpRangesLease\"}}]")]
        public virtual void PutLease(libvirt.Network.INetworkIpsDhcpRangesLease @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkIpsDhcpRangesLease)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnd")]
        public virtual void ResetEnd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLease")]
        public virtual void ResetLease()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStart")]
        public virtual void ResetStart()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "lease", typeJson: "{\"fqn\":\"libvirt.network.NetworkIpsDhcpRangesLeaseOutputReference\"}")]
        public virtual libvirt.Network.NetworkIpsDhcpRangesLeaseOutputReference Lease
        {
            get => GetInstanceProperty<libvirt.Network.NetworkIpsDhcpRangesLeaseOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "endInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Network.INetworkIpsDhcpRangesLease" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "leaseInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkIpsDhcpRangesLease\"}]}}", isOptional: true)]
        public virtual object? LeaseInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string End
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Start
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Network.INetworkIpsDhcpRanges" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkIpsDhcpRanges\"}]}}", isOptional: true)]
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
                        case libvirt.Network.INetworkIpsDhcpRanges cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkIpsDhcpRanges).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
