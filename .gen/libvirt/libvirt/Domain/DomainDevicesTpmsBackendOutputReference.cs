using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesTpmsBackendOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesTpmsBackendOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesTpmsBackendOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesTpmsBackendOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesTpmsBackendOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEmulator", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulator\"}}]")]
        public virtual void PutEmulator(libvirt.Domain.IDomainDevicesTpmsBackendEmulator @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendEmulator)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExternal", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternal\"}}]")]
        public virtual void PutExternal(libvirt.Domain.IDomainDevicesTpmsBackendExternal @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendExternal)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPassthrough", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendPassthrough\"}}]")]
        public virtual void PutPassthrough(libvirt.Domain.IDomainDevicesTpmsBackendPassthrough @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendPassthrough)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEmulator")]
        public virtual void ResetEmulator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExternal")]
        public virtual void ResetExternal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPassthrough")]
        public virtual void ResetPassthrough()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "emulator", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendEmulatorOutputReference Emulator
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendEmulatorOutputReference>()!;
        }

        [JsiiProperty(name: "external", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendExternalOutputReference External
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendExternalOutputReference>()!;
        }

        [JsiiProperty(name: "passthrough", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendPassthroughOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendPassthroughOutputReference Passthrough
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendPassthroughOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesTpmsBackendEmulator" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "emulatorInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulator\"}]}}", isOptional: true)]
        public virtual object? EmulatorInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesTpmsBackendExternal" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "externalInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternal\"}]}}", isOptional: true)]
        public virtual object? ExternalInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesTpmsBackendPassthrough" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "passthroughInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendPassthrough\"}]}}", isOptional: true)]
        public virtual object? PassthroughInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesTpmsBackend" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackend\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesTpmsBackend cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesTpmsBackend).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
