using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesFilesystemsSourceOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesFilesystemsSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesFilesystemsSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesFilesystemsSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesFilesystemsSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBind", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceBind\"}}]")]
        public virtual void PutBind(libvirt.Domain.IDomainDevicesFilesystemsSourceBind @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsSourceBind)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlock", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceBlock\"}}]")]
        public virtual void PutBlock(libvirt.Domain.IDomainDevicesFilesystemsSourceBlock @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsSourceBlock)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceFile\"}}]")]
        public virtual void PutFile(libvirt.Domain.IDomainDevicesFilesystemsSourceFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsSourceFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceMount\"}}]")]
        public virtual void PutMount(libvirt.Domain.IDomainDevicesFilesystemsSourceMount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsSourceMount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRam", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceRam\"}}]")]
        public virtual void PutRam(libvirt.Domain.IDomainDevicesFilesystemsSourceRam @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsSourceRam)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceTemplate\"}}]")]
        public virtual void PutTemplate(libvirt.Domain.IDomainDevicesFilesystemsSourceTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsSourceTemplate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVolume", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceVolume\"}}]")]
        public virtual void PutVolume(libvirt.Domain.IDomainDevicesFilesystemsSourceVolume @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsSourceVolume)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBind")]
        public virtual void ResetBind()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlock")]
        public virtual void ResetBlock()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFile")]
        public virtual void ResetFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMount")]
        public virtual void ResetMount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRam")]
        public virtual void ResetRam()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTemplate")]
        public virtual void ResetTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVolume")]
        public virtual void ResetVolume()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "bind", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceBindOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsSourceBindOutputReference Bind
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsSourceBindOutputReference>()!;
        }

        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceBlockOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsSourceBlockOutputReference Block
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsSourceBlockOutputReference>()!;
        }

        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceFileOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsSourceFileOutputReference File
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsSourceFileOutputReference>()!;
        }

        [JsiiProperty(name: "mount", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceMountOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsSourceMountOutputReference Mount
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsSourceMountOutputReference>()!;
        }

        [JsiiProperty(name: "ram", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceRamOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsSourceRamOutputReference Ram
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsSourceRamOutputReference>()!;
        }

        [JsiiProperty(name: "template", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceTemplateOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsSourceTemplateOutputReference Template
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsSourceTemplateOutputReference>()!;
        }

        [JsiiProperty(name: "volume", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceVolumeOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsSourceVolumeOutputReference Volume
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsSourceVolumeOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsSourceBind" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bindInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceBind\"}]}}", isOptional: true)]
        public virtual object? BindInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsSourceBlock" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceBlock\"}]}}", isOptional: true)]
        public virtual object? BlockInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsSourceFile" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceFile\"}]}}", isOptional: true)]
        public virtual object? FileInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsSourceMount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceMount\"}]}}", isOptional: true)]
        public virtual object? MountInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsSourceRam" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ramInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceRam\"}]}}", isOptional: true)]
        public virtual object? RamInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsSourceTemplate" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "templateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceTemplate\"}]}}", isOptional: true)]
        public virtual object? TemplateInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsSourceVolume" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volumeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceVolume\"}]}}", isOptional: true)]
        public virtual object? VolumeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsSource" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSource\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesFilesystemsSource cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesFilesystemsSource).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
