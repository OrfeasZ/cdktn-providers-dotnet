using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainFeaturesHyperVTlbFlushOutputReference), fullyQualifiedName: "libvirt.domain.DomainFeaturesHyperVTlbFlushOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainFeaturesHyperVTlbFlushOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainFeaturesHyperVTlbFlushOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainFeaturesHyperVTlbFlushOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainFeaturesHyperVTlbFlushOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDirect", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVTlbFlushDirect\"}}]")]
        public virtual void PutDirect(libvirt.Domain.IDomainFeaturesHyperVTlbFlushDirect @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperVTlbFlushDirect)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExtended", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVTlbFlushExtended\"}}]")]
        public virtual void PutExtended(libvirt.Domain.IDomainFeaturesHyperVTlbFlushExtended @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperVTlbFlushExtended)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDirect")]
        public virtual void ResetDirect()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtended")]
        public virtual void ResetExtended()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "direct", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVTlbFlushDirectOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVTlbFlushDirectOutputReference Direct
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVTlbFlushDirectOutputReference>()!;
        }

        [JsiiProperty(name: "extended", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVTlbFlushExtendedOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVTlbFlushExtendedOutputReference Extended
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVTlbFlushExtendedOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "directInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVTlbFlushDirect\"}]}}", isOptional: true)]
        public virtual object? DirectInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extendedInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVTlbFlushExtended\"}]}}", isOptional: true)]
        public virtual object? ExtendedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVTlbFlush\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainFeaturesHyperVTlbFlush cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainFeaturesHyperVTlbFlush).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
