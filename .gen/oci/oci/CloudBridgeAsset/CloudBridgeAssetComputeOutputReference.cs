using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiClass(nativeType: typeof(oci.CloudBridgeAsset.CloudBridgeAssetComputeOutputReference), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetComputeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudBridgeAssetComputeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudBridgeAssetComputeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudBridgeAssetComputeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudBridgeAssetComputeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDisks", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeDisks\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDisks(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CloudBridgeAsset.ICloudBridgeAssetComputeDisks[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetComputeDisks).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetComputeDisks).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGpuDevices", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeGpuDevices\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGpuDevices(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CloudBridgeAsset.ICloudBridgeAssetComputeGpuDevices[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetComputeGpuDevices).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetComputeGpuDevices).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNics", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeNics\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNics(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CloudBridgeAsset.ICloudBridgeAssetComputeNics[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetComputeNics).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetComputeNics).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNvdimmController", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeNvdimmController\"}}]")]
        public virtual void PutNvdimmController(oci.CloudBridgeAsset.ICloudBridgeAssetComputeNvdimmController @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudBridgeAsset.ICloudBridgeAssetComputeNvdimmController)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNvdimms", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeNvdimms\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNvdimms(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CloudBridgeAsset.ICloudBridgeAssetComputeNvdimms[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetComputeNvdimms).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetComputeNvdimms).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScsiController", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeScsiController\"}}]")]
        public virtual void PutScsiController(oci.CloudBridgeAsset.ICloudBridgeAssetComputeScsiController @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudBridgeAsset.ICloudBridgeAssetComputeScsiController)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConnectedNetworks")]
        public virtual void ResetConnectedNetworks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCoresCount")]
        public virtual void ResetCoresCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpuModel")]
        public virtual void ResetCpuModel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisks")]
        public virtual void ResetDisks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisksCount")]
        public virtual void ResetDisksCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDnsName")]
        public virtual void ResetDnsName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirmware")]
        public virtual void ResetFirmware()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGpuDevices")]
        public virtual void ResetGpuDevices()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGpuDevicesCount")]
        public virtual void ResetGpuDevicesCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGuestState")]
        public virtual void ResetGuestState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHardwareVersion")]
        public virtual void ResetHardwareVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostName")]
        public virtual void ResetHostName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsPmemEnabled")]
        public virtual void ResetIsPmemEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsTpmEnabled")]
        public virtual void ResetIsTpmEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLatencySensitivity")]
        public virtual void ResetLatencySensitivity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemoryInMbs")]
        public virtual void ResetMemoryInMbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNics")]
        public virtual void ResetNics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNicsCount")]
        public virtual void ResetNicsCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNvdimmController")]
        public virtual void ResetNvdimmController()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNvdimms")]
        public virtual void ResetNvdimms()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOperatingSystem")]
        public virtual void ResetOperatingSystem()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOperatingSystemVersion")]
        public virtual void ResetOperatingSystemVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPmemInMbs")]
        public virtual void ResetPmemInMbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPowerState")]
        public virtual void ResetPowerState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrimaryIp")]
        public virtual void ResetPrimaryIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScsiController")]
        public virtual void ResetScsiController()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageProvisionedInMbs")]
        public virtual void ResetStorageProvisionedInMbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreadsPerCoreCount")]
        public virtual void ResetThreadsPerCoreCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "disks", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeDisksList\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetComputeDisksList Disks
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetComputeDisksList>()!;
        }

        [JsiiProperty(name: "gpuDevices", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeGpuDevicesList\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetComputeGpuDevicesList GpuDevices
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetComputeGpuDevicesList>()!;
        }

        [JsiiProperty(name: "nics", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeNicsList\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetComputeNicsList Nics
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetComputeNicsList>()!;
        }

        [JsiiProperty(name: "nvdimmController", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeNvdimmControllerOutputReference\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetComputeNvdimmControllerOutputReference NvdimmController
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetComputeNvdimmControllerOutputReference>()!;
        }

        [JsiiProperty(name: "nvdimms", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeNvdimmsList\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetComputeNvdimmsList Nvdimms
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetComputeNvdimmsList>()!;
        }

        [JsiiProperty(name: "scsiController", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeScsiControllerOutputReference\"}")]
        public virtual oci.CloudBridgeAsset.CloudBridgeAssetComputeScsiControllerOutputReference ScsiController
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.CloudBridgeAssetComputeScsiControllerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectedNetworksInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConnectedNetworksInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "coresCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CoresCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuModelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CpuModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disksCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DisksCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disksInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeDisks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DisksInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DnsNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firmwareInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FirmwareInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gpuDevicesCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GpuDevicesCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gpuDevicesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeGpuDevices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GpuDevicesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "guestStateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GuestStateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hardwareVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HardwareVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isPmemEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsPmemEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isTpmEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsTpmEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "latencySensitivityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LatencySensitivityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryInMbsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MemoryInMbsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nicsCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NicsCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nicsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeNics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NicsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nvdimmControllerInput", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeNvdimmController\"}", isOptional: true)]
        public virtual oci.CloudBridgeAsset.ICloudBridgeAssetComputeNvdimmController? NvdimmControllerInput
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetComputeNvdimmController?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nvdimmsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeNvdimms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NvdimmsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "operatingSystemInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OperatingSystemInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "operatingSystemVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OperatingSystemVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pmemInMbsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PmemInMbsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "powerStateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PowerStateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primaryIpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrimaryIpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scsiControllerInput", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeScsiController\"}", isOptional: true)]
        public virtual oci.CloudBridgeAsset.ICloudBridgeAssetComputeScsiController? ScsiControllerInput
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetComputeScsiController?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageProvisionedInMbsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageProvisionedInMbsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threadsPerCoreCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThreadsPerCoreCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "connectedNetworks", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectedNetworks
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "coresCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CoresCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cpuModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CpuModel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "disksCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DisksCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dnsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "firmware", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Firmware
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gpuDevicesCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GpuDevicesCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "guestState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GuestState
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hardwareVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HardwareVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isPmemEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsPmemEnabled
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

        [JsiiProperty(name: "isTpmEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsTpmEnabled
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

        [JsiiProperty(name: "latencySensitivity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LatencySensitivity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memoryInMbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MemoryInMbs
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nicsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NicsCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperatingSystem
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "operatingSystemVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperatingSystemVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pmemInMbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PmemInMbs
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "powerState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PowerState
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "primaryIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryIp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageProvisionedInMbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageProvisionedInMbs
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "threadsPerCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThreadsPerCoreCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetCompute\"}", isOptional: true)]
        public virtual oci.CloudBridgeAsset.ICloudBridgeAssetCompute? InternalValue
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetCompute?>();
            set => SetInstanceProperty(value);
        }
    }
}
