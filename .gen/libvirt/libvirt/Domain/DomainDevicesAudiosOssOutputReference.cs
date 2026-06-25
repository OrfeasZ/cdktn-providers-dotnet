using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesAudiosOssOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosOssOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesAudiosOssOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesAudiosOssOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesAudiosOssOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesAudiosOssOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInput", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOssInput\"}}]")]
        public virtual void PutInput(libvirt.Domain.IDomainDevicesAudiosOssInput @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesAudiosOssInput)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutput", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOssOutput\"}}]")]
        public virtual void PutOutput(libvirt.Domain.IDomainDevicesAudiosOssOutput @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesAudiosOssOutput)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDspPolicy")]
        public virtual void ResetDspPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExclusive")]
        public virtual void ResetExclusive()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInput")]
        public virtual void ResetInput()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutput")]
        public virtual void ResetOutput()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTryMMap")]
        public virtual void ResetTryMMap()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOssInputOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesAudiosOssInputOutputReference Input
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesAudiosOssInputOutputReference>()!;
        }

        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOssOutputOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesAudiosOssOutputOutputReference Output
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesAudiosOssOutputOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dspPolicyInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DspPolicyInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exclusiveInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExclusiveInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosOssInput" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inputInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOssInput\"}]}}", isOptional: true)]
        public virtual object? InputInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosOssOutput" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outputInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOssOutput\"}]}}", isOptional: true)]
        public virtual object? OutputInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tryMMapInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TryMMapInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dspPolicy", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DspPolicy
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "exclusive", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Exclusive
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tryMMap", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TryMMap
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosOss" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOss\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesAudiosOss cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesAudiosOss).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
