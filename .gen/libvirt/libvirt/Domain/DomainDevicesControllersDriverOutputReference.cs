using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesControllersDriverOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesControllersDriverOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesControllersDriverOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesControllersDriverOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesControllersDriverOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesControllersDriverOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIoThreads", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesControllersDriverIoThreads\"}}]")]
        public virtual void PutIoThreads(libvirt.Domain.IDomainDevicesControllersDriverIoThreads @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesControllersDriverIoThreads)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAts")]
        public virtual void ResetAts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCmdPerLun")]
        public virtual void ResetCmdPerLun()
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

        [JsiiMethod(name: "resetMaxSectors")]
        public virtual void ResetMaxSectors()
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

        [JsiiProperty(name: "ioThreads", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersDriverIoThreadsOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesControllersDriverIoThreadsOutputReference IoThreads
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesControllersDriverIoThreadsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "atsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AtsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cmdPerLunInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CmdPerLunInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ioEventFdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IoEventFdInput
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

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesControllersDriverIoThreads" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ioThreadsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesControllersDriverIoThreads\"}]}}", isOptional: true)]
        public virtual object? IoThreadsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxSectorsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxSectorsInput
        {
            get => GetInstanceProperty<double?>();
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

        [JsiiProperty(name: "ats", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ats
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cmdPerLun", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CmdPerLun
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "maxSectors", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSectors
        {
            get => GetInstanceProperty<double>()!;
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

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesControllersDriver" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesControllersDriver\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesControllersDriver cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesControllersDriver).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
