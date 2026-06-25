using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCloudBridgeAssets
{
    [JsiiClass(nativeType: typeof(oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesPrivateIpAddressesOutputReference), fullyQualifiedName: "oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesPrivateIpAddressesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesPrivateIpAddressesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesPrivateIpAddressesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesPrivateIpAddressesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesPrivateIpAddressesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "association", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesPrivateIpAddressesAssociationList\"}")]
        public virtual oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesPrivateIpAddressesAssociationList Association
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesPrivateIpAddressesAssociationList>()!;
        }

        [JsiiProperty(name: "isPrimary", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPrimary
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssets.DataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesPrivateIpAddresses\"}", isOptional: true)]
        public virtual oci.DataOciCloudBridgeAssets.IDataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesPrivateIpAddresses? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssets.IDataOciCloudBridgeAssetsAssetCollectionItemsAwsEc2NetworkInterfacesPrivateIpAddresses?>();
            set => SetInstanceProperty(value);
        }
    }
}
