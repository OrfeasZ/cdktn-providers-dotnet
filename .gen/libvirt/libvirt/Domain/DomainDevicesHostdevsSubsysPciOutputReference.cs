using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesHostdevsSubsysPciOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysPciOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesHostdevsSubsysPciOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesHostdevsSubsysPciOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesHostdevsSubsysPciOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesHostdevsSubsysPciOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDriver", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPciDriver\"}}]")]
        public virtual void PutDriver(libvirt.Domain.IDomainDevicesHostdevsSubsysPciDriver @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsSubsysPciDriver)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPciSource\"}}]")]
        public virtual void PutSource(libvirt.Domain.IDomainDevicesHostdevsSubsysPciSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsSubsysPciSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTeaming", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPciTeaming\"}}]")]
        public virtual void PutTeaming(libvirt.Domain.IDomainDevicesHostdevsSubsysPciTeaming @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsSubsysPciTeaming)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDisplay")]
        public virtual void ResetDisplay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDriver")]
        public virtual void ResetDriver()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRamFb")]
        public virtual void ResetRamFb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSource")]
        public virtual void ResetSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTeaming")]
        public virtual void ResetTeaming()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPciDriverOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsSubsysPciDriverOutputReference Driver
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsSubsysPciDriverOutputReference>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPciSourceOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsSubsysPciSourceOutputReference Source
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsSubsysPciSourceOutputReference>()!;
        }

        [JsiiProperty(name: "teaming", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPciTeamingOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsSubsysPciTeamingOutputReference Teaming
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsSubsysPciTeamingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesHostdevsSubsysPciDriver" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPciDriver\"}]}}", isOptional: true)]
        public virtual object? DriverInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ramFbInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RamFbInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesHostdevsSubsysPciSource" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPciSource\"}]}}", isOptional: true)]
        public virtual object? SourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesHostdevsSubsysPciTeaming" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "teamingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPciTeaming\"}]}}", isOptional: true)]
        public virtual object? TeamingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "display", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Display
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ramFb", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RamFb
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesHostdevsSubsysPci" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPci\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesHostdevsSubsysPci cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesHostdevsSubsysPci).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
