using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOpensearchOpensearchCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opensearch_opensearch_cluster oci_opensearch_opensearch_cluster}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchCluster), fullyQualifiedName: "oci.dataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchClusterConfig\"}}]")]
    public class DataOciOpensearchOpensearchCluster : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opensearch_opensearch_cluster oci_opensearch_opensearch_cluster} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOpensearchOpensearchCluster(Constructs.Construct scope, string id, oci.DataOciOpensearchOpensearchCluster.IDataOciOpensearchOpensearchClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOpensearchOpensearchCluster.IDataOciOpensearchOpensearchClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpensearchOpensearchCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpensearchOpensearchCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOpensearchOpensearchCluster resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOpensearchOpensearchCluster to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOpensearchOpensearchCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOpensearchOpensearchCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOpensearchOpensearchCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opensearch_opensearch_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOpensearchOpensearchCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOpensearchOpensearchCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchCluster))!;

        [JsiiProperty(name: "availabilityDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AvailabilityDomains
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "certificateConfig", typeJson: "{\"fqn\":\"oci.dataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchClusterCertificateConfigList\"}")]
        public virtual oci.DataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchClusterCertificateConfigList CertificateConfig
        {
            get => GetInstanceProperty<oci.DataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchClusterCertificateConfigList>()!;
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

        [JsiiProperty(name: "maintenanceDetails", typeJson: "{\"fqn\":\"oci.dataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchClusterMaintenanceDetailsList\"}")]
        public virtual oci.DataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchClusterMaintenanceDetailsList MaintenanceDetails
        {
            get => GetInstanceProperty<oci.DataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchClusterMaintenanceDetailsList>()!;
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

        [JsiiProperty(name: "outboundClusterConfig", typeJson: "{\"fqn\":\"oci.dataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchClusterOutboundClusterConfigList\"}")]
        public virtual oci.DataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchClusterOutboundClusterConfigList OutboundClusterConfig
        {
            get => GetInstanceProperty<oci.DataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchClusterOutboundClusterConfigList>()!;
        }

        [JsiiProperty(name: "reverseConnectionEndpointCustomerIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ReverseConnectionEndpointCustomerIps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "reverseConnectionEndpoints", typeJson: "{\"fqn\":\"oci.dataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchClusterReverseConnectionEndpointsList\"}")]
        public virtual oci.DataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchClusterReverseConnectionEndpointsList ReverseConnectionEndpoints
        {
            get => GetInstanceProperty<oci.DataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchClusterReverseConnectionEndpointsList>()!;
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

        [JsiiProperty(name: "securitySamlConfig", typeJson: "{\"fqn\":\"oci.dataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchClusterSecuritySamlConfigList\"}")]
        public virtual oci.DataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchClusterSecuritySamlConfigList SecuritySamlConfig
        {
            get => GetInstanceProperty<oci.DataOciOpensearchOpensearchCluster.DataOciOpensearchOpensearchClusterSecuritySamlConfigList>()!;
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
        [JsiiProperty(name: "opensearchClusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OpensearchClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "opensearchClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpensearchClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
