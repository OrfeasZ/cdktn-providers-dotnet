using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCloudBridgeAssets
{
    [JsiiClass(nativeType: typeof(oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeOutputReference), fullyQualifiedName: "oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCloudBridgeAssetsAssetCollectionItemsComputeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCloudBridgeAssetsAssetCollectionItemsComputeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCloudBridgeAssetsAssetCollectionItemsComputeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudBridgeAssetsAssetCollectionItemsComputeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "connectedNetworks", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectedNetworks
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "coresCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CoresCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cpuModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CpuModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disks", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeDisksList\"}")]
        public virtual oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeDisksList Disks
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeDisksList>()!;
        }

        [JsiiProperty(name: "disksCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DisksCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dnsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "firmware", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Firmware
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gpuDevices", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeGpuDevicesList\"}")]
        public virtual oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeGpuDevicesList GpuDevices
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeGpuDevicesList>()!;
        }

        [JsiiProperty(name: "gpuDevicesCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GpuDevicesCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "guestState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GuestState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hardwareVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HardwareVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isPmemEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPmemEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isTpmEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsTpmEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "latencySensitivity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LatencySensitivity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "memoryInMbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MemoryInMbs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nics", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeNicsList\"}")]
        public virtual oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeNicsList Nics
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeNicsList>()!;
        }

        [JsiiProperty(name: "nicsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NicsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nvdimmController", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeNvdimmControllerList\"}")]
        public virtual oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeNvdimmControllerList NvdimmController
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeNvdimmControllerList>()!;
        }

        [JsiiProperty(name: "nvdimms", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeNvdimmsList\"}")]
        public virtual oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeNvdimmsList Nvdimms
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeNvdimmsList>()!;
        }

        [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperatingSystem
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operatingSystemVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperatingSystemVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pmemInMbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PmemInMbs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "powerState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PowerState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scsiController", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeScsiControllerList\"}")]
        public virtual oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeScsiControllerList ScsiController
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsComputeScsiControllerList>()!;
        }

        [JsiiProperty(name: "storageProvisionedInMbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageProvisionedInMbs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "threadsPerCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThreadsPerCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsCompute\"}", isOptional: true)]
        public virtual oci.DataOciCloudBridgeAssets.IDataOciCloudBridgeAssetsAssetCollectionItemsCompute? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.IDataOciCloudBridgeAssetsAssetCollectionItemsCompute?>();
            set => SetInstanceProperty(value);
        }
    }
}
