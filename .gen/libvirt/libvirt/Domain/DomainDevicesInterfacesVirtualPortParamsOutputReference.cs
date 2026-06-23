using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesInterfacesVirtualPortParamsOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesVirtualPortParamsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesInterfacesVirtualPortParamsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesInterfacesVirtualPortParamsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesInterfacesVirtualPortParamsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesInterfacesVirtualPortParamsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAny", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsAny\"}}]")]
        public virtual void PutAny(libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsAny @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsAny)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMidoNet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsMidoNet\"}}]")]
        public virtual void PutMidoNet(libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsMidoNet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsMidoNet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpenVSwitch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsOpenVSwitch\"}}]")]
        public virtual void PutOpenVSwitch(libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsOpenVSwitch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsOpenVSwitch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVepa8021Qbg", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsVepa8021Qbg\"}}]")]
        public virtual void PutVepa8021Qbg(libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsVepa8021Qbg @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsVepa8021Qbg)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVnTag8011Qbh", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsVnTag8011Qbh\"}}]")]
        public virtual void PutVnTag8011Qbh(libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsVnTag8011Qbh @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsVnTag8011Qbh)}, new object[]{@value});
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

        [JsiiProperty(name: "any", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsAnyOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesVirtualPortParamsAnyOutputReference Any
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesVirtualPortParamsAnyOutputReference>()!;
        }

        [JsiiProperty(name: "midoNet", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsMidoNetOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesVirtualPortParamsMidoNetOutputReference MidoNet
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesVirtualPortParamsMidoNetOutputReference>()!;
        }

        [JsiiProperty(name: "openVSwitch", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsOpenVSwitchOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesVirtualPortParamsOpenVSwitchOutputReference OpenVSwitch
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesVirtualPortParamsOpenVSwitchOutputReference>()!;
        }

        [JsiiProperty(name: "vepa8021Qbg", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsVepa8021QbgOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesVirtualPortParamsVepa8021QbgOutputReference Vepa8021Qbg
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesVirtualPortParamsVepa8021QbgOutputReference>()!;
        }

        [JsiiProperty(name: "vnTag8011Qbh", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsVnTag8011QbhOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesVirtualPortParamsVnTag8011QbhOutputReference VnTag8011Qbh
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesVirtualPortParamsVnTag8011QbhOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "anyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsAny\"}]}}", isOptional: true)]
        public virtual object? AnyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "midoNetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsMidoNet\"}]}}", isOptional: true)]
        public virtual object? MidoNetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "openVSwitchInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsOpenVSwitch\"}]}}", isOptional: true)]
        public virtual object? OpenVSwitchInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vepa8021QbgInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsVepa8021Qbg\"}]}}", isOptional: true)]
        public virtual object? Vepa8021QbgInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vnTag8011QbhInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsVnTag8011Qbh\"}]}}", isOptional: true)]
        public virtual object? VnTag8011QbhInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParams\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesInterfacesVirtualPortParams cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfacesVirtualPortParams).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
