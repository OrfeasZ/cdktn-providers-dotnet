using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainFeaturesKvmOutputReference), fullyQualifiedName: "libvirt.domain.DomainFeaturesKvmOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainFeaturesKvmOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainFeaturesKvmOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainFeaturesKvmOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainFeaturesKvmOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDirtyRing", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesKvmDirtyRing\"}}]")]
        public virtual void PutDirtyRing(libvirt.Domain.IDomainFeaturesKvmDirtyRing @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesKvmDirtyRing)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHidden", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesKvmHidden\"}}]")]
        public virtual void PutHidden(libvirt.Domain.IDomainFeaturesKvmHidden @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesKvmHidden)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHintDedicated", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesKvmHintDedicated\"}}]")]
        public virtual void PutHintDedicated(libvirt.Domain.IDomainFeaturesKvmHintDedicated @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesKvmHintDedicated)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPollControl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesKvmPollControl\"}}]")]
        public virtual void PutPollControl(libvirt.Domain.IDomainFeaturesKvmPollControl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesKvmPollControl)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPvipi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesKvmPvipi\"}}]")]
        public virtual void PutPvipi(libvirt.Domain.IDomainFeaturesKvmPvipi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesKvmPvipi)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDirtyRing")]
        public virtual void ResetDirtyRing()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHidden")]
        public virtual void ResetHidden()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHintDedicated")]
        public virtual void ResetHintDedicated()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPollControl")]
        public virtual void ResetPollControl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPvipi")]
        public virtual void ResetPvipi()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dirtyRing", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmDirtyRingOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesKvmDirtyRingOutputReference DirtyRing
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesKvmDirtyRingOutputReference>()!;
        }

        [JsiiProperty(name: "hidden", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmHiddenOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesKvmHiddenOutputReference Hidden
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesKvmHiddenOutputReference>()!;
        }

        [JsiiProperty(name: "hintDedicated", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmHintDedicatedOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesKvmHintDedicatedOutputReference HintDedicated
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesKvmHintDedicatedOutputReference>()!;
        }

        [JsiiProperty(name: "pollControl", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmPollControlOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesKvmPollControlOutputReference PollControl
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesKvmPollControlOutputReference>()!;
        }

        [JsiiProperty(name: "pvipi", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmPvipiOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesKvmPvipiOutputReference Pvipi
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesKvmPvipiOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dirtyRingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesKvmDirtyRing\"}]}}", isOptional: true)]
        public virtual object? DirtyRingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hiddenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesKvmHidden\"}]}}", isOptional: true)]
        public virtual object? HiddenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hintDedicatedInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesKvmHintDedicated\"}]}}", isOptional: true)]
        public virtual object? HintDedicatedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pollControlInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesKvmPollControl\"}]}}", isOptional: true)]
        public virtual object? PollControlInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pvipiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesKvmPvipi\"}]}}", isOptional: true)]
        public virtual object? PvipiInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesKvm\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainFeaturesKvm cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainFeaturesKvm).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
