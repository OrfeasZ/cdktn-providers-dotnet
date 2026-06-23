using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesDisksDriverOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksDriverOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesDisksDriverOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesDisksDriverOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesDisksDriverOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesDisksDriverOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIoThreads", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverIoThreads\"}}]")]
        public virtual void PutIoThreads(libvirt.Domain.IDomainDevicesDisksDriverIoThreads @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksDriverIoThreads)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMetadataCache", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverMetadataCache\"}}]")]
        public virtual void PutMetadataCache(libvirt.Domain.IDomainDevicesDisksDriverMetadataCache @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksDriverMetadataCache)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAts")]
        public virtual void ResetAts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCache")]
        public virtual void ResetCache()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCopyOnRead")]
        public virtual void ResetCopyOnRead()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDetectZeros")]
        public virtual void ResetDetectZeros()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDiscard")]
        public virtual void ResetDiscard()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDiscardNoUnref")]
        public virtual void ResetDiscardNoUnref()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetErrorPolicy")]
        public virtual void ResetErrorPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventIdx")]
        public virtual void ResetEventIdx()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIo")]
        public virtual void ResetIo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIoEventFd")]
        public virtual void ResetIoEventFd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIommu")]
        public virtual void ResetIommu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIoThread")]
        public virtual void ResetIoThread()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIoThreads")]
        public virtual void ResetIoThreads()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadataCache")]
        public virtual void ResetMetadataCache()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPacked")]
        public virtual void ResetPacked()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPagePerVq")]
        public virtual void ResetPagePerVq()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueues")]
        public virtual void ResetQueues()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueueSize")]
        public virtual void ResetQueueSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRerrorPolicy")]
        public virtual void ResetRerrorPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "ioThreads", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverIoThreadsOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksDriverIoThreadsOutputReference IoThreads
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksDriverIoThreadsOutputReference>()!;
        }

        [JsiiProperty(name: "metadataCache", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverMetadataCacheOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksDriverMetadataCacheOutputReference MetadataCache
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksDriverMetadataCacheOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "atsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AtsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CacheInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "copyOnReadInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CopyOnReadInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "detectZerosInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DetectZerosInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "discardInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DiscardInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "discardNoUnrefInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DiscardNoUnrefInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ErrorPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventIdxInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventIdxInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ioEventFdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IoEventFdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ioInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IoInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iommuInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IommuInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ioThreadInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IoThreadInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ioThreadsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverIoThreads\"}]}}", isOptional: true)]
        public virtual object? IoThreadsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataCacheInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverMetadataCache\"}]}}", isOptional: true)]
        public virtual object? MetadataCacheInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "packedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PackedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pagePerVqInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PagePerVqInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queuesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? QueuesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queueSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? QueueSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rerrorPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RerrorPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "ats", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ats
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cache", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cache
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "copyOnRead", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CopyOnRead
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "detectZeros", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DetectZeros
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "discard", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Discard
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "discardNoUnref", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiscardNoUnref
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "errorPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventIdx", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventIdx
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "io", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Io
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ioEventFd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IoEventFd
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iommu", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Iommu
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ioThread", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IoThread
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "packed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Packed
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pagePerVq", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PagePerVq
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queues", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Queues
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queueSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QueueSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rerrorPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RerrorPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriver\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesDisksDriver cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksDriver).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
