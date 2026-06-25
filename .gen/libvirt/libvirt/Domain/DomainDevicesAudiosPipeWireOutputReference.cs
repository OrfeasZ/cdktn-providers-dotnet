using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesAudiosPipeWireOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosPipeWireOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesAudiosPipeWireOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesAudiosPipeWireOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesAudiosPipeWireOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesAudiosPipeWireOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInput", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWireInput\"}}]")]
        public virtual void PutInput(libvirt.Domain.IDomainDevicesAudiosPipeWireInput @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesAudiosPipeWireInput)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutput", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWireOutput\"}}]")]
        public virtual void PutOutput(libvirt.Domain.IDomainDevicesAudiosPipeWireOutput @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesAudiosPipeWireOutput)}, new object[]{@value});
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

        [JsiiMethod(name: "resetRuntimeDir")]
        public virtual void ResetRuntimeDir()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWireInputOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesAudiosPipeWireInputOutputReference Input
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesAudiosPipeWireInputOutputReference>()!;
        }

        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWireOutputOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesAudiosPipeWireOutputOutputReference Output
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesAudiosPipeWireOutputOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosPipeWireInput" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inputInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWireInput\"}]}}", isOptional: true)]
        public virtual object? InputInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosPipeWireOutput" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outputInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWireOutput\"}]}}", isOptional: true)]
        public virtual object? OutputInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimeDirInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuntimeDirInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "runtimeDir", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuntimeDir
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosPipeWire" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWire\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesAudiosPipeWire cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesAudiosPipeWire).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
