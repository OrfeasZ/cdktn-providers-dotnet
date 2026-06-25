using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesVideosModelOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesVideosModelOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesVideosModelOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesVideosModelOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesVideosModelOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesVideosModelOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccel", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesVideosModelAccel\"}}]")]
        public virtual void PutAccel(libvirt.Domain.IDomainDevicesVideosModelAccel @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesVideosModelAccel)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResolution", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesVideosModelResolution\"}}]")]
        public virtual void PutResolution(libvirt.Domain.IDomainDevicesVideosModelResolution @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesVideosModelResolution)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccel")]
        public virtual void ResetAccel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlob")]
        public virtual void ResetBlob()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEdid")]
        public virtual void ResetEdid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHeads")]
        public virtual void ResetHeads()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrimary")]
        public virtual void ResetPrimary()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRam")]
        public virtual void ResetRam()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResolution")]
        public virtual void ResetResolution()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVgaMem")]
        public virtual void ResetVgaMem()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVram")]
        public virtual void ResetVram()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVram64")]
        public virtual void ResetVram64()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "accel", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVideosModelAccelOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesVideosModelAccelOutputReference Accel
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesVideosModelAccelOutputReference>()!;
        }

        [JsiiProperty(name: "resolution", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVideosModelResolutionOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesVideosModelResolutionOutputReference Resolution
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesVideosModelResolutionOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesVideosModelAccel" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accelInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesVideosModelAccel\"}]}}", isOptional: true)]
        public virtual object? AccelInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blobInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BlobInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "edidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EdidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "headsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HeadsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primaryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrimaryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ramInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RamInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesVideosModelResolution" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resolutionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesVideosModelResolution\"}]}}", isOptional: true)]
        public virtual object? ResolutionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vgaMemInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VgaMemInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vram64Input", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? Vram64Input
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vramInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VramInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "blob", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Blob
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "edid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Edid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "heads", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Heads
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "primary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Primary
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ram", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ram
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vgaMem", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VgaMem
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vram", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Vram
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vram64", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Vram64
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesVideosModel" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesVideosModel\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesVideosModel cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesVideosModel).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
