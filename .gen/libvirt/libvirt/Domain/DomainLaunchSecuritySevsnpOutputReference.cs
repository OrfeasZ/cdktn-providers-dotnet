using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainLaunchSecuritySevsnpOutputReference), fullyQualifiedName: "libvirt.domain.DomainLaunchSecuritySevsnpOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainLaunchSecuritySevsnpOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainLaunchSecuritySevsnpOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainLaunchSecuritySevsnpOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainLaunchSecuritySevsnpOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAuthorKey")]
        public virtual void ResetAuthorKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCbitPos")]
        public virtual void ResetCbitPos()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGuestVisibleWorkarounds")]
        public virtual void ResetGuestVisibleWorkarounds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostData")]
        public virtual void ResetHostData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdAuth")]
        public virtual void ResetIdAuth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdBlock")]
        public virtual void ResetIdBlock()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKernelHashes")]
        public virtual void ResetKernelHashes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicy")]
        public virtual void ResetPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReducedPhysBits")]
        public virtual void ResetReducedPhysBits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVcek")]
        public virtual void ResetVcek()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cbitPosInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CbitPosInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "guestVisibleWorkaroundsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GuestVisibleWorkaroundsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostDataInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostDataInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idAuthInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdAuthInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idBlockInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdBlockInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kernelHashesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KernelHashesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PolicyInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reducedPhysBitsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReducedPhysBitsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcekInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VcekInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "authorKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cbitPos", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CbitPos
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "guestVisibleWorkarounds", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GuestVisibleWorkarounds
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostData
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "idAuth", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdAuth
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "idBlock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdBlock
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kernelHashes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KernelHashes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Policy
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reducedPhysBits", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReducedPhysBits
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vcek", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Vcek
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainLaunchSecuritySevsnp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainLaunchSecuritySevsnp\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainLaunchSecuritySevsnp cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainLaunchSecuritySevsnp).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
