using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOcvpClusters
{
    [JsiiClass(nativeType: typeof(oci.DataOciOcvpClusters.DataOciOcvpClustersClusterCollectionItemsNetworkConfigurationOutputReference), fullyQualifiedName: "oci.dataOciOcvpClusters.DataOciOcvpClustersClusterCollectionItemsNetworkConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOcvpClustersClusterCollectionItemsNetworkConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOcvpClustersClusterCollectionItemsNetworkConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOcvpClustersClusterCollectionItemsNetworkConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOcvpClustersClusterCollectionItemsNetworkConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "hcxVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HcxVlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsxEdgeUplink1VlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsxEdgeUplink1VlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsxEdgeUplink2VlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsxEdgeUplink2VlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsxEdgeVtepVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsxEdgeVtepVlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsxVtepVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsxVtepVlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provisioningSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvisioningSubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provisioningVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvisioningVlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicationVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationVlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vmotionVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmotionVlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vsanVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VsanVlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vsphereVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VsphereVlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOcvpClusters.DataOciOcvpClustersClusterCollectionItemsNetworkConfiguration\"}", isOptional: true)]
        public virtual oci.DataOciOcvpClusters.IDataOciOcvpClustersClusterCollectionItemsNetworkConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOcvpClusters.IDataOciOcvpClustersClusterCollectionItemsNetworkConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
