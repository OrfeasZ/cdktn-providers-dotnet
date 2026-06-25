using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesDisksOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DomainDevicesDisksOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DomainDevicesDisksOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesDisksOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesDisksOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAcpi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksAcpi\"}}]")]
        public virtual void PutAcpi(libvirt.Domain.IDomainDevicesDisksAcpi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksAcpi)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksAddress\"}}]")]
        public virtual void PutAddress(libvirt.Domain.IDomainDevicesDisksAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAlias", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksAlias\"}}]")]
        public virtual void PutAlias(libvirt.Domain.IDomainDevicesDisksAlias @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksAlias)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksAuth\"}}]")]
        public virtual void PutAuth(libvirt.Domain.IDomainDevicesDisksAuth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksAuth)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBackendDomain", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackendDomain\"}}]")]
        public virtual void PutBackendDomain(libvirt.Domain.IDomainDevicesDisksBackendDomain @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksBackendDomain)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBackingStore", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStore\"}}]")]
        public virtual void PutBackingStore(libvirt.Domain.IDomainDevicesDisksBackingStore @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksBackingStore)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlockIo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBlockIo\"}}]")]
        public virtual void PutBlockIo(libvirt.Domain.IDomainDevicesDisksBlockIo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksBlockIo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBoot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBoot\"}}]")]
        public virtual void PutBoot(libvirt.Domain.IDomainDevicesDisksBoot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksBoot)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDriver", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriver\"}}]")]
        public virtual void PutDriver(libvirt.Domain.IDomainDevicesDisksDriver @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksDriver)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksEncryption\"}}]")]
        public virtual void PutEncryption(libvirt.Domain.IDomainDevicesDisksEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGeometry", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksGeometry\"}}]")]
        public virtual void PutGeometry(libvirt.Domain.IDomainDevicesDisksGeometry @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksGeometry)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIoTune", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksIoTune\"}}]")]
        public virtual void PutIoTune(libvirt.Domain.IDomainDevicesDisksIoTune @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksIoTune)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMirror", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirror\"}}]")]
        public virtual void PutMirror(libvirt.Domain.IDomainDevicesDisksMirror @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirror)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSource\"}}]")]
        public virtual void PutSource(libvirt.Domain.IDomainDevicesDisksSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksTarget\"}}]")]
        public virtual void PutTarget(libvirt.Domain.IDomainDevicesDisksTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThrottleFilters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksThrottleFilters\"}}]")]
        public virtual void PutThrottleFilters(libvirt.Domain.IDomainDevicesDisksThrottleFilters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksThrottleFilters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTransient", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksTransient\"}}]")]
        public virtual void PutTransient(libvirt.Domain.IDomainDevicesDisksTransient @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksTransient)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcpi")]
        public virtual void ResetAcpi()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAddress")]
        public virtual void ResetAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAlias")]
        public virtual void ResetAlias()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuth")]
        public virtual void ResetAuth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackendDomain")]
        public virtual void ResetBackendDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackingStore")]
        public virtual void ResetBackingStore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlockIo")]
        public virtual void ResetBlockIo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBoot")]
        public virtual void ResetBoot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDevice")]
        public virtual void ResetDevice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDriver")]
        public virtual void ResetDriver()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryption")]
        public virtual void ResetEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGeometry")]
        public virtual void ResetGeometry()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIoTune")]
        public virtual void ResetIoTune()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMirror")]
        public virtual void ResetMirror()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModel")]
        public virtual void ResetModel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProduct")]
        public virtual void ResetProduct()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRawIo")]
        public virtual void ResetRawIo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReadOnly")]
        public virtual void ResetReadOnly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSerial")]
        public virtual void ResetSerial()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSgio")]
        public virtual void ResetSgio()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShareable")]
        public virtual void ResetShareable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshot")]
        public virtual void ResetSnapshot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSource")]
        public virtual void ResetSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTarget")]
        public virtual void ResetTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThrottleFilters")]
        public virtual void ResetThrottleFilters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransient")]
        public virtual void ResetTransient()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVendor")]
        public virtual void ResetVendor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWwn")]
        public virtual void ResetWwn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksAcpiOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksAcpiOutputReference Acpi
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksAcpiOutputReference>()!;
        }

        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksAddressOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksAddressOutputReference Address
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksAddressOutputReference>()!;
        }

        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksAliasOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksAliasOutputReference Alias
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksAliasOutputReference>()!;
        }

        [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksAuthOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksAuthOutputReference Auth
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksAuthOutputReference>()!;
        }

        [JsiiProperty(name: "backendDomain", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackendDomainOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksBackendDomainOutputReference BackendDomain
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksBackendDomainOutputReference>()!;
        }

        [JsiiProperty(name: "backingStore", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksBackingStoreOutputReference BackingStore
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksBackingStoreOutputReference>()!;
        }

        [JsiiProperty(name: "blockIo", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBlockIoOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksBlockIoOutputReference BlockIo
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksBlockIoOutputReference>()!;
        }

        [JsiiProperty(name: "boot", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBootOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksBootOutputReference Boot
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksBootOutputReference>()!;
        }

        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriverOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksDriverOutputReference Driver
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksDriverOutputReference>()!;
        }

        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksEncryptionOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksEncryptionOutputReference Encryption
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "geometry", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksGeometryOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksGeometryOutputReference Geometry
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksGeometryOutputReference>()!;
        }

        [JsiiProperty(name: "ioTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksIoTuneOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksIoTuneOutputReference IoTune
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksIoTuneOutputReference>()!;
        }

        [JsiiProperty(name: "mirror", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorOutputReference Mirror
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorOutputReference>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceOutputReference Source
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceOutputReference>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksTargetOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksTargetOutputReference Target
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksTargetOutputReference>()!;
        }

        [JsiiProperty(name: "throttleFilters", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksThrottleFiltersOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksThrottleFiltersOutputReference ThrottleFilters
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksThrottleFiltersOutputReference>()!;
        }

        [JsiiProperty(name: "transient", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksTransientOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksTransientOutputReference Transient
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksTransientOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksAcpi" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksAcpi\"}]}}", isOptional: true)]
        public virtual object? AcpiInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksAddress" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksAddress\"}]}}", isOptional: true)]
        public virtual object? AddressInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksAlias" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aliasInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksAlias\"}]}}", isOptional: true)]
        public virtual object? AliasInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksAuth" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksAuth\"}]}}", isOptional: true)]
        public virtual object? AuthInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksBackendDomain" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backendDomainInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackendDomain\"}]}}", isOptional: true)]
        public virtual object? BackendDomainInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksBackingStore" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backingStoreInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStore\"}]}}", isOptional: true)]
        public virtual object? BackingStoreInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksBlockIo" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockIoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksBlockIo\"}]}}", isOptional: true)]
        public virtual object? BlockIoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksBoot" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bootInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksBoot\"}]}}", isOptional: true)]
        public virtual object? BootInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeviceInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksDriver" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksDriver\"}]}}", isOptional: true)]
        public virtual object? DriverInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksEncryption" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksEncryption\"}]}}", isOptional: true)]
        public virtual object? EncryptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksGeometry" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "geometryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksGeometry\"}]}}", isOptional: true)]
        public virtual object? GeometryInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksIoTune" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ioTuneInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksIoTune\"}]}}", isOptional: true)]
        public virtual object? IoTuneInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirror" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mirrorInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirror\"}]}}", isOptional: true)]
        public virtual object? MirrorInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "productInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProductInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rawIoInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RawIoInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readOnlyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ReadOnlyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serialInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SerialInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sgioInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SgioInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shareableInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ShareableInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SnapshotInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSource" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSource\"}]}}", isOptional: true)]
        public virtual object? SourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksTarget" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksTarget\"}]}}", isOptional: true)]
        public virtual object? TargetInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksThrottleFilters" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "throttleFiltersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksThrottleFilters\"}]}}", isOptional: true)]
        public virtual object? ThrottleFiltersInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksTransient" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transientInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksTransient\"}]}}", isOptional: true)]
        public virtual object? TransientInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vendorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VendorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "wwnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WwnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "device", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Device
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Model
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Product
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rawIo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RawIo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "readOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ReadOnly
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "serial", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Serial
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sgio", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sgio
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "shareable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Shareable
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "snapshot", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Snapshot
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vendor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Vendor
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "wwn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Wwn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisks" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisks\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesDisks cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisks).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
