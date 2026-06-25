using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMaxSize", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheMaxSize\"}}]")]
        public virtual void PutMaxSize(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheMaxSize @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheMaxSize)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMaxSize")]
        public virtual void ResetMaxSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "maxSize", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheMaxSizeOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheMaxSizeOutputReference MaxSize
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheMaxSizeOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheMaxSize" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxSizeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCacheMaxSize\"}]}}", isOptional: true)]
        public virtual object? MaxSizeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCache" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCache\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCache cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDataStoreFormatMetadataCache).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
