using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiClass(nativeType: typeof(libvirt.Network.NetworkVirtualPortParamsOutputReference), fullyQualifiedName: "libvirt.network.NetworkVirtualPortParamsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetworkVirtualPortParamsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetworkVirtualPortParamsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NetworkVirtualPortParamsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkVirtualPortParamsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAny", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsAny\"}}]")]
        public virtual void PutAny(libvirt.Network.INetworkVirtualPortParamsAny @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkVirtualPortParamsAny)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMidoNet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsMidoNet\"}}]")]
        public virtual void PutMidoNet(libvirt.Network.INetworkVirtualPortParamsMidoNet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkVirtualPortParamsMidoNet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpenVSwitch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsOpenVSwitch\"}}]")]
        public virtual void PutOpenVSwitch(libvirt.Network.INetworkVirtualPortParamsOpenVSwitch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkVirtualPortParamsOpenVSwitch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVepa8021Qbg", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsVepa8021Qbg\"}}]")]
        public virtual void PutVepa8021Qbg(libvirt.Network.INetworkVirtualPortParamsVepa8021Qbg @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkVirtualPortParamsVepa8021Qbg)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVnTag8011Qbh", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsVnTag8011Qbh\"}}]")]
        public virtual void PutVnTag8011Qbh(libvirt.Network.INetworkVirtualPortParamsVnTag8011Qbh @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkVirtualPortParamsVnTag8011Qbh)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAny")]
        public virtual void ResetAny()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMidoNet")]
        public virtual void ResetMidoNet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpenVSwitch")]
        public virtual void ResetOpenVSwitch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVepa8021Qbg")]
        public virtual void ResetVepa8021Qbg()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVnTag8011Qbh")]
        public virtual void ResetVnTag8011Qbh()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "any", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsAnyOutputReference\"}")]
        public virtual libvirt.Network.NetworkVirtualPortParamsAnyOutputReference Any
        {
            get => GetInstanceProperty<libvirt.Network.NetworkVirtualPortParamsAnyOutputReference>()!;
        }

        [JsiiProperty(name: "midoNet", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsMidoNetOutputReference\"}")]
        public virtual libvirt.Network.NetworkVirtualPortParamsMidoNetOutputReference MidoNet
        {
            get => GetInstanceProperty<libvirt.Network.NetworkVirtualPortParamsMidoNetOutputReference>()!;
        }

        [JsiiProperty(name: "openVSwitch", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsOpenVSwitchOutputReference\"}")]
        public virtual libvirt.Network.NetworkVirtualPortParamsOpenVSwitchOutputReference OpenVSwitch
        {
            get => GetInstanceProperty<libvirt.Network.NetworkVirtualPortParamsOpenVSwitchOutputReference>()!;
        }

        [JsiiProperty(name: "vepa8021Qbg", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsVepa8021QbgOutputReference\"}")]
        public virtual libvirt.Network.NetworkVirtualPortParamsVepa8021QbgOutputReference Vepa8021Qbg
        {
            get => GetInstanceProperty<libvirt.Network.NetworkVirtualPortParamsVepa8021QbgOutputReference>()!;
        }

        [JsiiProperty(name: "vnTag8011Qbh", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsVnTag8011QbhOutputReference\"}")]
        public virtual libvirt.Network.NetworkVirtualPortParamsVnTag8011QbhOutputReference VnTag8011Qbh
        {
            get => GetInstanceProperty<libvirt.Network.NetworkVirtualPortParamsVnTag8011QbhOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Network.INetworkVirtualPortParamsAny" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "anyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsAny\"}]}}", isOptional: true)]
        public virtual object? AnyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Network.INetworkVirtualPortParamsMidoNet" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "midoNetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsMidoNet\"}]}}", isOptional: true)]
        public virtual object? MidoNetInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Network.INetworkVirtualPortParamsOpenVSwitch" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openVSwitchInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsOpenVSwitch\"}]}}", isOptional: true)]
        public virtual object? OpenVSwitchInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Network.INetworkVirtualPortParamsVepa8021Qbg" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vepa8021QbgInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsVepa8021Qbg\"}]}}", isOptional: true)]
        public virtual object? Vepa8021QbgInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Network.INetworkVirtualPortParamsVnTag8011Qbh" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vnTag8011QbhInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsVnTag8011Qbh\"}]}}", isOptional: true)]
        public virtual object? VnTag8011QbhInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Network.INetworkVirtualPortParams" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkVirtualPortParams\"}]}}", isOptional: true)]
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
                        case libvirt.Network.INetworkVirtualPortParams cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkVirtualPortParams).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
