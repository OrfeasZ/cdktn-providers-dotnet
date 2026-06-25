using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCloudBridgeAssets
{
    [JsiiClass(nativeType: typeof(oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2OutputReference), fullyQualifiedName: "oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2OutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2OutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Architecture
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "areElasticInferenceAcceleratorsPresent", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AreElasticInferenceAcceleratorsPresent
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "bootMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "capacityReservationKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityReservationKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceLifecycle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceLifecycle
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipv6Address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv6Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isEnclaveOptions", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEnclaveOptions
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isHibernationOptions", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHibernationOptions
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSourceDestCheck", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSourceDestCheck
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSpotInstance", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSpotInstance
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "kernelKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KernelKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "licenses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Licenses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "maintenanceOptions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceOptions
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "monitoring", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Monitoring
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkInterfaces", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesList\"}")]
        public virtual oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesList NetworkInterfaces
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesList>()!;
        }

        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2PlacementList\"}")]
        public virtual oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2PlacementList Placement
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2PlacementList>()!;
        }

        [JsiiProperty(name: "privateDnsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateDnsName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateIpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rootDeviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootDeviceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rootDeviceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootDeviceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2SecurityGroupsList\"}")]
        public virtual oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2SecurityGroupsList SecurityGroups
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2SecurityGroupsList>()!;
        }

        [JsiiProperty(name: "sriovNetSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SriovNetSupport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2StateList\"}")]
        public virtual oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2StateList State
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2StateList>()!;
        }

        [JsiiProperty(name: "subnetKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2TagsList\"}")]
        public virtual oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2TagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2TagsList>()!;
        }

        [JsiiProperty(name: "timeLaunch", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLaunch
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tpmSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TpmSupport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "virtualizationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualizationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2\"}", isOptional: true)]
        public virtual oci.DataOciCloudBridgeAssets.IDataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.IDataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2?>();
            set => SetInstanceProperty(value);
        }
    }
}
