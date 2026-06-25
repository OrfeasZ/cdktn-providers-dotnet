using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainLaunchSecurityTdxOutputReference), fullyQualifiedName: "libvirt.domain.DomainLaunchSecurityTdxOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainLaunchSecurityTdxOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainLaunchSecurityTdxOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainLaunchSecurityTdxOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainLaunchSecurityTdxOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putQuoteGenerationService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainLaunchSecurityTdxQuoteGenerationService\"}}]")]
        public virtual void PutQuoteGenerationService(libvirt.Domain.IDomainLaunchSecurityTdxQuoteGenerationService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainLaunchSecurityTdxQuoteGenerationService)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMrConfigId")]
        public virtual void ResetMrConfigId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMrOwner")]
        public virtual void ResetMrOwner()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMrOwnerConfig")]
        public virtual void ResetMrOwnerConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicy")]
        public virtual void ResetPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuoteGenerationService")]
        public virtual void ResetQuoteGenerationService()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "quoteGenerationService", typeJson: "{\"fqn\":\"libvirt.domain.DomainLaunchSecurityTdxQuoteGenerationServiceOutputReference\"}")]
        public virtual libvirt.Domain.DomainLaunchSecurityTdxQuoteGenerationServiceOutputReference QuoteGenerationService
        {
            get => GetInstanceProperty<libvirt.Domain.DomainLaunchSecurityTdxQuoteGenerationServiceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "mrConfigIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MrConfigIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mrOwnerConfigInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MrOwnerConfigInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mrOwnerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MrOwnerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PolicyInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainLaunchSecurityTdxQuoteGenerationService" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "quoteGenerationServiceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainLaunchSecurityTdxQuoteGenerationService\"}]}}", isOptional: true)]
        public virtual object? QuoteGenerationServiceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "mrConfigId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MrConfigId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mrOwner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MrOwner
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mrOwnerConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MrOwnerConfig
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

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainLaunchSecurityTdx" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainLaunchSecurityTdx\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainLaunchSecurityTdx cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainLaunchSecurityTdx).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
