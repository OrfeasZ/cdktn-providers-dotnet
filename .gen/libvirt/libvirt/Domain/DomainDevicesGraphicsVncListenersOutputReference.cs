using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesGraphicsVncListenersOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsVncListenersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DomainDevicesGraphicsVncListenersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DomainDevicesGraphicsVncListenersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DomainDevicesGraphicsVncListenersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesGraphicsVncListenersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVncListenersAddress\"}}]")]
        public virtual void PutAddress(libvirt.Domain.IDomainDevicesGraphicsVncListenersAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsVncListenersAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVncListenersNetwork\"}}]")]
        public virtual void PutNetwork(libvirt.Domain.IDomainDevicesGraphicsVncListenersNetwork @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsVncListenersNetwork)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSocket", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVncListenersSocket\"}}]")]
        public virtual void PutSocket(libvirt.Domain.IDomainDevicesGraphicsVncListenersSocket @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsVncListenersSocket)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAddress")]
        public virtual void ResetAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetwork")]
        public virtual void ResetNetwork()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSocket")]
        public virtual void ResetSocket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVncListenersAddressOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsVncListenersAddressOutputReference Address
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsVncListenersAddressOutputReference>()!;
        }

        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVncListenersNetworkOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsVncListenersNetworkOutputReference Network
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsVncListenersNetworkOutputReference>()!;
        }

        [JsiiProperty(name: "socket", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVncListenersSocketOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsVncListenersSocketOutputReference Socket
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsVncListenersSocketOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesGraphicsVncListenersAddress" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVncListenersAddress\"}]}}", isOptional: true)]
        public virtual object? AddressInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesGraphicsVncListenersNetwork" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVncListenersNetwork\"}]}}", isOptional: true)]
        public virtual object? NetworkInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesGraphicsVncListenersSocket" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "socketInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVncListenersSocket\"}]}}", isOptional: true)]
        public virtual object? SocketInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesGraphicsVncListeners" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVncListeners\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesGraphicsVncListeners cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesGraphicsVncListeners).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
