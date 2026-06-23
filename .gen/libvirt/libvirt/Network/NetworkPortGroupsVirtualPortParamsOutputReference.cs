using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiClass(nativeType: typeof(libvirt.Network.NetworkPortGroupsVirtualPortParamsOutputReference), fullyQualifiedName: "libvirt.network.NetworkPortGroupsVirtualPortParamsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetworkPortGroupsVirtualPortParamsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetworkPortGroupsVirtualPortParamsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NetworkPortGroupsVirtualPortParamsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkPortGroupsVirtualPortParamsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAny", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPortParamsAny\"}}]")]
        public virtual void PutAny(libvirt.Network.INetworkPortGroupsVirtualPortParamsAny @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkPortGroupsVirtualPortParamsAny)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMidoNet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPortParamsMidoNet\"}}]")]
        public virtual void PutMidoNet(libvirt.Network.INetworkPortGroupsVirtualPortParamsMidoNet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkPortGroupsVirtualPortParamsMidoNet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpenVSwitch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPortParamsOpenVSwitch\"}}]")]
        public virtual void PutOpenVSwitch(libvirt.Network.INetworkPortGroupsVirtualPortParamsOpenVSwitch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkPortGroupsVirtualPortParamsOpenVSwitch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVepa8021Qbg", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPortParamsVepa8021Qbg\"}}]")]
        public virtual void PutVepa8021Qbg(libvirt.Network.INetworkPortGroupsVirtualPortParamsVepa8021Qbg @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkPortGroupsVirtualPortParamsVepa8021Qbg)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVnTag8011Qbh", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPortParamsVnTag8011Qbh\"}}]")]
        public virtual void PutVnTag8011Qbh(libvirt.Network.INetworkPortGroupsVirtualPortParamsVnTag8011Qbh @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Network.INetworkPortGroupsVirtualPortParamsVnTag8011Qbh)}, new object[]{@value});
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

        [JsiiProperty(name: "any", typeJson: "{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPortParamsAnyOutputReference\"}")]
        public virtual libvirt.Network.NetworkPortGroupsVirtualPortParamsAnyOutputReference Any
        {
            get => GetInstanceProperty<libvirt.Network.NetworkPortGroupsVirtualPortParamsAnyOutputReference>()!;
        }

        [JsiiProperty(name: "midoNet", typeJson: "{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPortParamsMidoNetOutputReference\"}")]
        public virtual libvirt.Network.NetworkPortGroupsVirtualPortParamsMidoNetOutputReference MidoNet
        {
            get => GetInstanceProperty<libvirt.Network.NetworkPortGroupsVirtualPortParamsMidoNetOutputReference>()!;
        }

        [JsiiProperty(name: "openVSwitch", typeJson: "{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPortParamsOpenVSwitchOutputReference\"}")]
        public virtual libvirt.Network.NetworkPortGroupsVirtualPortParamsOpenVSwitchOutputReference OpenVSwitch
        {
            get => GetInstanceProperty<libvirt.Network.NetworkPortGroupsVirtualPortParamsOpenVSwitchOutputReference>()!;
        }

        [JsiiProperty(name: "vepa8021Qbg", typeJson: "{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPortParamsVepa8021QbgOutputReference\"}")]
        public virtual libvirt.Network.NetworkPortGroupsVirtualPortParamsVepa8021QbgOutputReference Vepa8021Qbg
        {
            get => GetInstanceProperty<libvirt.Network.NetworkPortGroupsVirtualPortParamsVepa8021QbgOutputReference>()!;
        }

        [JsiiProperty(name: "vnTag8011Qbh", typeJson: "{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPortParamsVnTag8011QbhOutputReference\"}")]
        public virtual libvirt.Network.NetworkPortGroupsVirtualPortParamsVnTag8011QbhOutputReference VnTag8011Qbh
        {
            get => GetInstanceProperty<libvirt.Network.NetworkPortGroupsVirtualPortParamsVnTag8011QbhOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "anyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPortParamsAny\"}]}}", isOptional: true)]
        public virtual object? AnyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "midoNetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPortParamsMidoNet\"}]}}", isOptional: true)]
        public virtual object? MidoNetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "openVSwitchInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPortParamsOpenVSwitch\"}]}}", isOptional: true)]
        public virtual object? OpenVSwitchInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vepa8021QbgInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPortParamsVepa8021Qbg\"}]}}", isOptional: true)]
        public virtual object? Vepa8021QbgInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vnTag8011QbhInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPortParamsVnTag8011Qbh\"}]}}", isOptional: true)]
        public virtual object? VnTag8011QbhInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPortParams\"}]}}", isOptional: true)]
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
                        case libvirt.Network.INetworkPortGroupsVirtualPortParams cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkPortGroupsVirtualPortParams).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
