using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCacheOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCacheOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCacheOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCacheOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCacheOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCacheOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMaxSize", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCacheMaxSize\"}}]")]
        public virtual void PutMaxSize(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCacheMaxSize @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCacheMaxSize)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMaxSize")]
        public virtual void ResetMaxSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "maxSize", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCacheMaxSizeOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCacheMaxSizeOutputReference MaxSize
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCacheMaxSizeOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCacheMaxSize" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxSizeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCacheMaxSize\"}]}}", isOptional: true)]
        public virtual object? MaxSizeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCache" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCache\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCache cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceDataStoreFormatMetadataCache).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
