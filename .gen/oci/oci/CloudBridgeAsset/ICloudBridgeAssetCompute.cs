using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiInterface(nativeType: typeof(ICloudBridgeAssetCompute), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetCompute")]
    public interface ICloudBridgeAssetCompute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#connected_networks CloudBridgeAsset#connected_networks}.</summary>
        [JsiiProperty(name: "connectedNetworks", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConnectedNetworks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#cores_count CloudBridgeAsset#cores_count}.</summary>
        [JsiiProperty(name: "coresCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CoresCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#cpu_model CloudBridgeAsset#cpu_model}.</summary>
        [JsiiProperty(name: "cpuModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CpuModel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#description CloudBridgeAsset#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>disks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#disks CloudBridgeAsset#disks}
        /// </remarks>
        [JsiiProperty(name: "disks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeDisks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Disks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#disks_count CloudBridgeAsset#disks_count}.</summary>
        [JsiiProperty(name: "disksCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DisksCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#dns_name CloudBridgeAsset#dns_name}.</summary>
        [JsiiProperty(name: "dnsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DnsName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#firmware CloudBridgeAsset#firmware}.</summary>
        [JsiiProperty(name: "firmware", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Firmware
        {
            get
            {
                return null;
            }
        }

        /// <summary>gpu_devices block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#gpu_devices CloudBridgeAsset#gpu_devices}
        /// </remarks>
        [JsiiProperty(name: "gpuDevices", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeGpuDevices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GpuDevices
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#gpu_devices_count CloudBridgeAsset#gpu_devices_count}.</summary>
        [JsiiProperty(name: "gpuDevicesCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GpuDevicesCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#guest_state CloudBridgeAsset#guest_state}.</summary>
        [JsiiProperty(name: "guestState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GuestState
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#hardware_version CloudBridgeAsset#hardware_version}.</summary>
        [JsiiProperty(name: "hardwareVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HardwareVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#host_name CloudBridgeAsset#host_name}.</summary>
        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#is_pmem_enabled CloudBridgeAsset#is_pmem_enabled}.</summary>
        [JsiiProperty(name: "isPmemEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsPmemEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#is_tpm_enabled CloudBridgeAsset#is_tpm_enabled}.</summary>
        [JsiiProperty(name: "isTpmEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsTpmEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#latency_sensitivity CloudBridgeAsset#latency_sensitivity}.</summary>
        [JsiiProperty(name: "latencySensitivity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LatencySensitivity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#memory_in_mbs CloudBridgeAsset#memory_in_mbs}.</summary>
        [JsiiProperty(name: "memoryInMbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MemoryInMbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>nics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#nics CloudBridgeAsset#nics}
        /// </remarks>
        [JsiiProperty(name: "nics", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeNics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Nics
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#nics_count CloudBridgeAsset#nics_count}.</summary>
        [JsiiProperty(name: "nicsCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NicsCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>nvdimm_controller block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#nvdimm_controller CloudBridgeAsset#nvdimm_controller}
        /// </remarks>
        [JsiiProperty(name: "nvdimmController", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeNvdimmController\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CloudBridgeAsset.ICloudBridgeAssetComputeNvdimmController? NvdimmController
        {
            get
            {
                return null;
            }
        }

        /// <summary>nvdimms block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#nvdimms CloudBridgeAsset#nvdimms}
        /// </remarks>
        [JsiiProperty(name: "nvdimms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeNvdimms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Nvdimms
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#operating_system CloudBridgeAsset#operating_system}.</summary>
        [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OperatingSystem
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#operating_system_version CloudBridgeAsset#operating_system_version}.</summary>
        [JsiiProperty(name: "operatingSystemVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OperatingSystemVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#pmem_in_mbs CloudBridgeAsset#pmem_in_mbs}.</summary>
        [JsiiProperty(name: "pmemInMbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PmemInMbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#power_state CloudBridgeAsset#power_state}.</summary>
        [JsiiProperty(name: "powerState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PowerState
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#primary_ip CloudBridgeAsset#primary_ip}.</summary>
        [JsiiProperty(name: "primaryIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrimaryIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>scsi_controller block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#scsi_controller CloudBridgeAsset#scsi_controller}
        /// </remarks>
        [JsiiProperty(name: "scsiController", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeScsiController\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CloudBridgeAsset.ICloudBridgeAssetComputeScsiController? ScsiController
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#storage_provisioned_in_mbs CloudBridgeAsset#storage_provisioned_in_mbs}.</summary>
        [JsiiProperty(name: "storageProvisionedInMbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageProvisionedInMbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#threads_per_core_count CloudBridgeAsset#threads_per_core_count}.</summary>
        [JsiiProperty(name: "threadsPerCoreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThreadsPerCoreCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudBridgeAssetCompute), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetCompute")]
        internal sealed class _Proxy : DeputyBase, oci.CloudBridgeAsset.ICloudBridgeAssetCompute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#connected_networks CloudBridgeAsset#connected_networks}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectedNetworks", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConnectedNetworks
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#cores_count CloudBridgeAsset#cores_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "coresCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CoresCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#cpu_model CloudBridgeAsset#cpu_model}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CpuModel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#description CloudBridgeAsset#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>disks block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#disks CloudBridgeAsset#disks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeDisks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Disks
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#disks_count CloudBridgeAsset#disks_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disksCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DisksCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#dns_name CloudBridgeAsset#dns_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dnsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DnsName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#firmware CloudBridgeAsset#firmware}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "firmware", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Firmware
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>gpu_devices block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#gpu_devices CloudBridgeAsset#gpu_devices}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gpuDevices", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeGpuDevices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GpuDevices
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#gpu_devices_count CloudBridgeAsset#gpu_devices_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gpuDevicesCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GpuDevicesCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#guest_state CloudBridgeAsset#guest_state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "guestState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GuestState
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#hardware_version CloudBridgeAsset#hardware_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hardwareVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HardwareVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#host_name CloudBridgeAsset#host_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#is_pmem_enabled CloudBridgeAsset#is_pmem_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isPmemEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsPmemEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#is_tpm_enabled CloudBridgeAsset#is_tpm_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isTpmEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsTpmEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#latency_sensitivity CloudBridgeAsset#latency_sensitivity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "latencySensitivity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LatencySensitivity
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#memory_in_mbs CloudBridgeAsset#memory_in_mbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memoryInMbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MemoryInMbs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>nics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#nics CloudBridgeAsset#nics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nics", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeNics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Nics
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#nics_count CloudBridgeAsset#nics_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nicsCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NicsCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>nvdimm_controller block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#nvdimm_controller CloudBridgeAsset#nvdimm_controller}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nvdimmController", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeNvdimmController\"}", isOptional: true)]
            public oci.CloudBridgeAsset.ICloudBridgeAssetComputeNvdimmController? NvdimmController
            {
                get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetComputeNvdimmController?>();
            }

            /// <summary>nvdimms block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#nvdimms CloudBridgeAsset#nvdimms}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nvdimms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeNvdimms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Nvdimms
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#operating_system CloudBridgeAsset#operating_system}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OperatingSystem
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#operating_system_version CloudBridgeAsset#operating_system_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "operatingSystemVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OperatingSystemVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#pmem_in_mbs CloudBridgeAsset#pmem_in_mbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pmemInMbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PmemInMbs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#power_state CloudBridgeAsset#power_state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "powerState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PowerState
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#primary_ip CloudBridgeAsset#primary_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "primaryIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrimaryIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>scsi_controller block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#scsi_controller CloudBridgeAsset#scsi_controller}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scsiController", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetComputeScsiController\"}", isOptional: true)]
            public oci.CloudBridgeAsset.ICloudBridgeAssetComputeScsiController? ScsiController
            {
                get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetComputeScsiController?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#storage_provisioned_in_mbs CloudBridgeAsset#storage_provisioned_in_mbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageProvisionedInMbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageProvisionedInMbs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_bridge_asset#threads_per_core_count CloudBridgeAsset#threads_per_core_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "threadsPerCoreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThreadsPerCoreCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
