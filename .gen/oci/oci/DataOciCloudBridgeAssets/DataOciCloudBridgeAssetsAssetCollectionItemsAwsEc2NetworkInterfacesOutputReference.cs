using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCloudBridgeAssets
{
    [JsiiClass(nativeType: typeof(oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesOutputReference), fullyQualifiedName: "oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "association", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesAssociationList\"}")]
        public virtual oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesAssociationList Association
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesAssociationList>()!;
        }

        [JsiiProperty(name: "attachment", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesAttachmentList\"}")]
        public virtual oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesAttachmentList Attachment
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesAttachmentList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "interfaceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InterfaceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipv4Prefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Ipv4Prefixes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "ipv6Addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Ipv6Addresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "ipv6Prefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Ipv6Prefixes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "isSourceDestCheck", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSourceDestCheck
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "macAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MacAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkInterfaceKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkInterfaceKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ownerKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateIpAddresses", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesPrivateIpAddressesList\"}")]
        public virtual oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesPrivateIpAddressesList PrivateIpAddresses
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesPrivateIpAddressesList>()!;
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesSecurityGroupsList\"}")]
        public virtual oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesSecurityGroupsList SecurityGroups
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesSecurityGroupsList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfaces\"}", isOptional: true)]
        public virtual oci.DataOciCloudBridgeAssets.IDataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfaces? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.IDataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfaces?>();
            set => SetInstanceProperty(value);
        }
    }
}
