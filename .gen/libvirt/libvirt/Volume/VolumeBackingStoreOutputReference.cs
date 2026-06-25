using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Volume
{
    [JsiiClass(nativeType: typeof(libvirt.Volume.VolumeBackingStoreOutputReference), fullyQualifiedName: "libvirt.volume.VolumeBackingStoreOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VolumeBackingStoreOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VolumeBackingStoreOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VolumeBackingStoreOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VolumeBackingStoreOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFormat", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.volume.VolumeBackingStoreFormat\"}}]")]
        public virtual void PutFormat(libvirt.Volume.IVolumeBackingStoreFormat @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Volume.IVolumeBackingStoreFormat)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPermissions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.volume.VolumeBackingStorePermissions\"}}]")]
        public virtual void PutPermissions(libvirt.Volume.IVolumeBackingStorePermissions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Volume.IVolumeBackingStorePermissions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFormat")]
        public virtual void ResetFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPermissions")]
        public virtual void ResetPermissions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"libvirt.volume.VolumeBackingStoreFormatOutputReference\"}")]
        public virtual libvirt.Volume.VolumeBackingStoreFormatOutputReference Format
        {
            get => GetInstanceProperty<libvirt.Volume.VolumeBackingStoreFormatOutputReference>()!;
        }

        [JsiiProperty(name: "permissions", typeJson: "{\"fqn\":\"libvirt.volume.VolumeBackingStorePermissionsOutputReference\"}")]
        public virtual libvirt.Volume.VolumeBackingStorePermissionsOutputReference Permissions
        {
            get => GetInstanceProperty<libvirt.Volume.VolumeBackingStorePermissionsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Volume.IVolumeBackingStoreFormat" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "formatInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.volume.VolumeBackingStoreFormat\"}]}}", isOptional: true)]
        public virtual object? FormatInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PathInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Volume.IVolumeBackingStorePermissions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "permissionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.volume.VolumeBackingStorePermissions\"}]}}", isOptional: true)]
        public virtual object? PermissionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Volume.IVolumeBackingStore" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.volume.VolumeBackingStore\"}]}}", isOptional: true)]
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
                        case libvirt.Volume.IVolumeBackingStore cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Volume.IVolumeBackingStore).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
