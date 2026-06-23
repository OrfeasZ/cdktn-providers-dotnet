using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Volume
{
    [JsiiClass(nativeType: typeof(libvirt.Volume.VolumeTargetOutputReference), fullyQualifiedName: "libvirt.volume.VolumeTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VolumeTargetOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VolumeTargetOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VolumeTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VolumeTargetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.volume.VolumeTargetEncryption\"}}]")]
        public virtual void PutEncryption(libvirt.Volume.IVolumeTargetEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Volume.IVolumeTargetEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFeatures", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.volume.VolumeTargetFeatures\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFeatures(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Volume.IVolumeTargetFeatures[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Volume.IVolumeTargetFeatures).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Volume.IVolumeTargetFeatures).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFormat", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.volume.VolumeTargetFormat\"}}]")]
        public virtual void PutFormat(libvirt.Volume.IVolumeTargetFormat @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Volume.IVolumeTargetFormat)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPermissions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.volume.VolumeTargetPermissions\"}}]")]
        public virtual void PutPermissions(libvirt.Volume.IVolumeTargetPermissions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Volume.IVolumeTargetPermissions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimestamps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.volume.VolumeTargetTimestamps\"}}]")]
        public virtual void PutTimestamps(libvirt.Volume.IVolumeTargetTimestamps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Volume.IVolumeTargetTimestamps)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClusterSize")]
        public virtual void ResetClusterSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterSizeUnit")]
        public virtual void ResetClusterSizeUnit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompat")]
        public virtual void ResetCompat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryption")]
        public virtual void ResetEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFeatures")]
        public virtual void ResetFeatures()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiMethod(name: "resetTimestamps")]
        public virtual void ResetTimestamps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetEncryptionOutputReference\"}")]
        public virtual libvirt.Volume.VolumeTargetEncryptionOutputReference Encryption
        {
            get => GetInstanceProperty<libvirt.Volume.VolumeTargetEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetFeaturesList\"}")]
        public virtual libvirt.Volume.VolumeTargetFeaturesList Features
        {
            get => GetInstanceProperty<libvirt.Volume.VolumeTargetFeaturesList>()!;
        }

        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetFormatOutputReference\"}")]
        public virtual libvirt.Volume.VolumeTargetFormatOutputReference Format
        {
            get => GetInstanceProperty<libvirt.Volume.VolumeTargetFormatOutputReference>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "permissions", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetPermissionsOutputReference\"}")]
        public virtual libvirt.Volume.VolumeTargetPermissionsOutputReference Permissions
        {
            get => GetInstanceProperty<libvirt.Volume.VolumeTargetPermissionsOutputReference>()!;
        }

        [JsiiProperty(name: "timestamps", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetTimestampsOutputReference\"}")]
        public virtual libvirt.Volume.VolumeTargetTimestampsOutputReference Timestamps
        {
            get => GetInstanceProperty<libvirt.Volume.VolumeTargetTimestampsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ClusterSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterSizeUnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterSizeUnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.volume.VolumeTargetEncryption\"}]}}", isOptional: true)]
        public virtual object? EncryptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "featuresInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.volume.VolumeTargetFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FeaturesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "formatInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.volume.VolumeTargetFormat\"}]}}", isOptional: true)]
        public virtual object? FormatInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "permissionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.volume.VolumeTargetPermissions\"}]}}", isOptional: true)]
        public virtual object? PermissionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timestampsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.volume.VolumeTargetTimestamps\"}]}}", isOptional: true)]
        public virtual object? TimestampsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "clusterSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ClusterSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterSizeUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterSizeUnit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Compat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.volume.VolumeTarget\"}]}}", isOptional: true)]
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
                        case libvirt.Volume.IVolumeTarget cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Volume.IVolumeTarget).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
