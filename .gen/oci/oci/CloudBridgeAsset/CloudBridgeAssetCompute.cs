using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetCompute")]
    public class CloudBridgeAssetCompute : oci.CloudBridgeAsset.ICloudBridgeAssetCompute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#connected_networks CloudBridgeAsset#connected_networks}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectedNetworks", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConnectedNetworks
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#cores_count CloudBridgeAsset#cores_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "coresCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CoresCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#cpu_model CloudBridgeAsset#cpu_model}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CpuModel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#description CloudBridgeAsset#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        private object? _disks;

        /// <summary>disks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#disks CloudBridgeAsset#disks}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeDisks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Disks
        {
            get => _disks;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudBridgeAsset.ICloudBridgeAssetComputeDisks[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetComputeDisks).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _disks = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#disks_count CloudBridgeAsset#disks_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disksCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DisksCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#dns_name CloudBridgeAsset#dns_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dnsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DnsName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#firmware CloudBridgeAsset#firmware}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "firmware", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Firmware
        {
            get;
            set;
        }

        private object? _gpuDevices;

        /// <summary>gpu_devices block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#gpu_devices CloudBridgeAsset#gpu_devices}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gpuDevices", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeGpuDevices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GpuDevices
        {
            get => _gpuDevices;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudBridgeAsset.ICloudBridgeAssetComputeGpuDevices[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetComputeGpuDevices).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _gpuDevices = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#gpu_devices_count CloudBridgeAsset#gpu_devices_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gpuDevicesCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GpuDevicesCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#guest_state CloudBridgeAsset#guest_state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "guestState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GuestState
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#hardware_version CloudBridgeAsset#hardware_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hardwareVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HardwareVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#host_name CloudBridgeAsset#host_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostName
        {
            get;
            set;
        }

        private object? _isPmemEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#is_pmem_enabled CloudBridgeAsset#is_pmem_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isPmemEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsPmemEnabled
        {
            get => _isPmemEnabled;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isPmemEnabled = value;
            }
        }

        private object? _isTpmEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#is_tpm_enabled CloudBridgeAsset#is_tpm_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isTpmEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsTpmEnabled
        {
            get => _isTpmEnabled;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isTpmEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#latency_sensitivity CloudBridgeAsset#latency_sensitivity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "latencySensitivity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LatencySensitivity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#memory_in_mbs CloudBridgeAsset#memory_in_mbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryInMbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MemoryInMbs
        {
            get;
            set;
        }

        private object? _nics;

        /// <summary>nics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#nics CloudBridgeAsset#nics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nics", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeNics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Nics
        {
            get => _nics;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudBridgeAsset.ICloudBridgeAssetComputeNics[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetComputeNics).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _nics = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#nics_count CloudBridgeAsset#nics_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nicsCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NicsCount
        {
            get;
            set;
        }

        /// <summary>nvdimm_controller block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#nvdimm_controller CloudBridgeAsset#nvdimm_controller}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nvdimmController", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeNvdimmController\"}", isOptional: true)]
        public oci.CloudBridgeAsset.ICloudBridgeAssetComputeNvdimmController? NvdimmController
        {
            get;
            set;
        }

        private object? _nvdimms;

        /// <summary>nvdimms block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#nvdimms CloudBridgeAsset#nvdimms}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nvdimms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeNvdimms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Nvdimms
        {
            get => _nvdimms;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudBridgeAsset.ICloudBridgeAssetComputeNvdimms[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetComputeNvdimms).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _nvdimms = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#operating_system CloudBridgeAsset#operating_system}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OperatingSystem
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#operating_system_version CloudBridgeAsset#operating_system_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operatingSystemVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OperatingSystemVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#pmem_in_mbs CloudBridgeAsset#pmem_in_mbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pmemInMbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PmemInMbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#power_state CloudBridgeAsset#power_state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "powerState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PowerState
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#primary_ip CloudBridgeAsset#primary_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "primaryIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrimaryIp
        {
            get;
            set;
        }

        /// <summary>scsi_controller block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#scsi_controller CloudBridgeAsset#scsi_controller}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scsiController", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeScsiController\"}", isOptional: true)]
        public oci.CloudBridgeAsset.ICloudBridgeAssetComputeScsiController? ScsiController
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#storage_provisioned_in_mbs CloudBridgeAsset#storage_provisioned_in_mbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageProvisionedInMbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageProvisionedInMbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#threads_per_core_count CloudBridgeAsset#threads_per_core_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadsPerCoreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadsPerCoreCount
        {
            get;
            set;
        }
    }
}
