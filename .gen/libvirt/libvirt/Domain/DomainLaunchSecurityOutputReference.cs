using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainLaunchSecurityOutputReference), fullyQualifiedName: "libvirt.domain.DomainLaunchSecurityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainLaunchSecurityOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainLaunchSecurityOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainLaunchSecurityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainLaunchSecurityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSev", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainLaunchSecuritySev\"}}]")]
        public virtual void PutSev(libvirt.Domain.IDomainLaunchSecuritySev @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainLaunchSecuritySev)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSevsnp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainLaunchSecuritySevsnp\"}}]")]
        public virtual void PutSevsnp(libvirt.Domain.IDomainLaunchSecuritySevsnp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainLaunchSecuritySevsnp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTdx", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainLaunchSecurityTdx\"}}]")]
        public virtual void PutTdx(libvirt.Domain.IDomainLaunchSecurityTdx @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainLaunchSecurityTdx)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetS390Pv")]
        public virtual void ResetS390Pv()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSev")]
        public virtual void ResetSev()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSevsnp")]
        public virtual void ResetSevsnp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTdx")]
        public virtual void ResetTdx()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "sev", typeJson: "{\"fqn\":\"libvirt.domain.DomainLaunchSecuritySevOutputReference\"}")]
        public virtual libvirt.Domain.DomainLaunchSecuritySevOutputReference Sev
        {
            get => GetInstanceProperty<libvirt.Domain.DomainLaunchSecuritySevOutputReference>()!;
        }

        [JsiiProperty(name: "sevsnp", typeJson: "{\"fqn\":\"libvirt.domain.DomainLaunchSecuritySevsnpOutputReference\"}")]
        public virtual libvirt.Domain.DomainLaunchSecuritySevsnpOutputReference Sevsnp
        {
            get => GetInstanceProperty<libvirt.Domain.DomainLaunchSecuritySevsnpOutputReference>()!;
        }

        [JsiiProperty(name: "tdx", typeJson: "{\"fqn\":\"libvirt.domain.DomainLaunchSecurityTdxOutputReference\"}")]
        public virtual libvirt.Domain.DomainLaunchSecurityTdxOutputReference Tdx
        {
            get => GetInstanceProperty<libvirt.Domain.DomainLaunchSecurityTdxOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s390PvInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? S390PvInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sevInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainLaunchSecuritySev\"}]}}", isOptional: true)]
        public virtual object? SevInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sevsnpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainLaunchSecuritySevsnp\"}]}}", isOptional: true)]
        public virtual object? SevsnpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tdxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainLaunchSecurityTdx\"}]}}", isOptional: true)]
        public virtual object? TdxInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "s390Pv", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object S390Pv
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainLaunchSecurity\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainLaunchSecurity cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainLaunchSecurity).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
