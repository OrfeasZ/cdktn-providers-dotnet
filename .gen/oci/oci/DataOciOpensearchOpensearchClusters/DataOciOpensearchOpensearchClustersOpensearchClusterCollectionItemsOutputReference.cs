using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOpensearchOpensearchClusters
{
    [JsiiClass(nativeType: typeof(oci.DataOciOpensearchOpensearchClusters.DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciOpensearchOpensearchClusters.DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "availabilityDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AvailabilityDomains
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "certificateConfig", typeJson: "{\"fqn\":\"oci.dataOciOpensearchOpensearchClusters.DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsCertificateConfigList\"}")]
        public virtual oci.DataOciOpensearchOpensearchClusters.DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsCertificateConfigList CertificateConfig
        {
            get => GetInstanceProperty<oci.DataOciOpensearchOpensearchClusters.DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsCertificateConfigList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configureOutboundClusterTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConfigureOutboundClusterTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dataNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataNodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dataNodeHostBareMetalShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataNodeHostBareMetalShape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataNodeHostMemoryGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataNodeHostMemoryGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dataNodeHostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataNodeHostOcpuCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dataNodeHostShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataNodeHostShape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataNodeHostType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataNodeHostType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataNodeStorageGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataNodeStorageGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inboundClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InboundClusterIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceDetails", typeJson: "{\"fqn\":\"oci.dataOciOpensearchOpensearchClusters.DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsMaintenanceDetailsList\"}")]
        public virtual oci.DataOciOpensearchOpensearchClusters.DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsMaintenanceDetailsList MaintenanceDetails
        {
            get => GetInstanceProperty<oci.DataOciOpensearchOpensearchClusters.DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsMaintenanceDetailsList>()!;
        }

        [JsiiProperty(name: "masterNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MasterNodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "masterNodeHostBareMetalShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterNodeHostBareMetalShape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterNodeHostMemoryGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MasterNodeHostMemoryGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "masterNodeHostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MasterNodeHostOcpuCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "masterNodeHostShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterNodeHostShape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterNodeHostType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterNodeHostType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsgId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsgId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "opendashboardFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpendashboardFqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "opendashboardNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OpendashboardNodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "opendashboardNodeHostMemoryGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OpendashboardNodeHostMemoryGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "opendashboardNodeHostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OpendashboardNodeHostOcpuCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "opendashboardNodeHostShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpendashboardNodeHostShape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "opendashboardPrivateIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpendashboardPrivateIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "opensearchFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpensearchFqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "opensearchPrivateIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpensearchPrivateIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outboundClusterConfig", typeJson: "{\"fqn\":\"oci.dataOciOpensearchOpensearchClusters.DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsOutboundClusterConfigList\"}")]
        public virtual oci.DataOciOpensearchOpensearchClusters.DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsOutboundClusterConfigList OutboundClusterConfig
        {
            get => GetInstanceProperty<oci.DataOciOpensearchOpensearchClusters.DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsOutboundClusterConfigList>()!;
        }

        [JsiiProperty(name: "reverseConnectionEndpointCustomerIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ReverseConnectionEndpointCustomerIps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "reverseConnectionEndpoints", typeJson: "{\"fqn\":\"oci.dataOciOpensearchOpensearchClusters.DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsReverseConnectionEndpointsList\"}")]
        public virtual oci.DataOciOpensearchOpensearchClusters.DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsReverseConnectionEndpointsList ReverseConnectionEndpoints
        {
            get => GetInstanceProperty<oci.DataOciOpensearchOpensearchClusters.DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsReverseConnectionEndpointsList>()!;
        }

        [JsiiProperty(name: "searchNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SearchNodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "searchNodeHostMemoryGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SearchNodeHostMemoryGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "searchNodeHostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SearchNodeHostOcpuCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "searchNodeHostShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SearchNodeHostShape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "searchNodeHostType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SearchNodeHostType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "searchNodeStorageGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SearchNodeStorageGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "securityAttributes", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SecurityAttributes
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "securityMasterUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityMasterUserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityMasterUserPasswordHash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityMasterUserPasswordHash
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securitySamlConfig", typeJson: "{\"fqn\":\"oci.dataOciOpensearchOpensearchClusters.DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsSecuritySamlConfigList\"}")]
        public virtual oci.DataOciOpensearchOpensearchClusters.DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsSecuritySamlConfigList SecuritySamlConfig
        {
            get => GetInstanceProperty<oci.DataOciOpensearchOpensearchClusters.DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItemsSecuritySamlConfigList>()!;
        }

        [JsiiProperty(name: "softwareVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftwareVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetCompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeDeleted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeDeleted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalStorageGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalStorageGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "upgradeMajorVersionTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UpgradeMajorVersionTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "vcnCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcnCompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcnId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOpensearchOpensearchClusters.DataOciOpensearchOpensearchClustersOpensearchClusterCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciOpensearchOpensearchClusters.IDataOciOpensearchOpensearchClustersOpensearchClusterCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOpensearchOpensearchClusters.IDataOciOpensearchOpensearchClustersOpensearchClusterCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
