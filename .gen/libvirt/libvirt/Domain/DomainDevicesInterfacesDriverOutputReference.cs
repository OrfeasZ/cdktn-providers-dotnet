using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesInterfacesDriverOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesDriverOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesInterfacesDriverOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesInterfacesDriverOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesInterfacesDriverOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesInterfacesDriverOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGuest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDriverGuest\"}}]")]
        public virtual void PutGuest(libvirt.Domain.IDomainDevicesInterfacesDriverGuest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesDriverGuest)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHost", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDriverHost\"}}]")]
        public virtual void PutHost(libvirt.Domain.IDomainDevicesInterfacesDriverHost @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesDriverHost)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAts")]
        public virtual void ResetAts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventIdx")]
        public virtual void ResetEventIdx()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGuest")]
        public virtual void ResetGuest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHost")]
        public virtual void ResetHost()
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

        [JsiiMethod(name: "resetRss")]
        public virtual void ResetRss()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRssHashReport")]
        public virtual void ResetRssHashReport()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRxQueueSize")]
        public virtual void ResetRxQueueSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTxMode")]
        public virtual void ResetTxMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTxQueueSize")]
        public virtual void ResetTxQueueSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "guest", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDriverGuestOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesDriverGuestOutputReference Guest
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesDriverGuestOutputReference>()!;
        }

        [JsiiProperty(name: "host", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDriverHostOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesDriverHostOutputReference Host
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesDriverHostOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "atsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AtsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventIdxInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventIdxInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesDriverGuest" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "guestInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDriverGuest\"}]}}", isOptional: true)]
        public virtual object? GuestInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesDriverHost" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDriverHost\"}]}}", isOptional: true)]
        public virtual object? HostInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "rssHashReportInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RssHashReportInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rssInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RssInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rxQueueSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RxQueueSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "txModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TxModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "txQueueSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TxQueueSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "ats", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ats
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

        [JsiiProperty(name: "rss", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Rss
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rssHashReport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RssHashReport
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rxQueueSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RxQueueSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "txMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TxMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "txQueueSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TxQueueSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesDriver" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDriver\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesInterfacesDriver cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfacesDriver).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
