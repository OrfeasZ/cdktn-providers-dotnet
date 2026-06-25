using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiClass(nativeType: typeof(libvirt.Network.NetworkIpsOutputReference), fullyQualifiedName: "libvirt.network.NetworkIpsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class NetworkIpsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public NetworkIpsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected NetworkIpsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkIpsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDhcp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkIpsDhcp\"}}]")]
        public virtual void PutDhcp(libvirt.Network.INetworkIpsDhcp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkIpsDhcp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTftp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkIpsTftp\"}}]")]
        public virtual void PutTftp(libvirt.Network.INetworkIpsTftp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkIpsTftp)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAddress")]
        public virtual void ResetAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDhcp")]
        public virtual void ResetDhcp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFamily")]
        public virtual void ResetFamily()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalPtr")]
        public virtual void ResetLocalPtr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetmask")]
        public virtual void ResetNetmask()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrefix")]
        public virtual void ResetPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTftp")]
        public virtual void ResetTftp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dhcp", typeJson: "{\"fqn\":\"libvirt.network.NetworkIpsDhcpOutputReference\"}")]
        public virtual libvirt.Network.NetworkIpsDhcpOutputReference Dhcp
        {
            get => GetInstanceProperty<libvirt.Network.NetworkIpsDhcpOutputReference>()!;
        }

        [JsiiProperty(name: "tftp", typeJson: "{\"fqn\":\"libvirt.network.NetworkIpsTftpOutputReference\"}")]
        public virtual libvirt.Network.NetworkIpsTftpOutputReference Tftp
        {
            get => GetInstanceProperty<libvirt.Network.NetworkIpsTftpOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "addressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Network.INetworkIpsDhcp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dhcpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkIpsDhcp\"}]}}", isOptional: true)]
        public virtual object? DhcpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "familyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FamilyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localPtrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocalPtrInput
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
        [JsiiProperty(name: "prefixInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PrefixInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Network.INetworkIpsTftp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tftpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkIpsTftp\"}]}}", isOptional: true)]
        public virtual object? TftpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Address
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "family", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Family
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localPtr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalPtr
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

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Prefix
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Network.INetworkIps" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkIps\"}]}}", isOptional: true)]
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
                        case libvirt.Network.INetworkIps cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkIps).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
