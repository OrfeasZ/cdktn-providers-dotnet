using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster oci_opensearch_opensearch_cluster}.</summary>
    [JsiiClass(nativeType: typeof(oci.OpensearchOpensearchCluster.OpensearchOpensearchCluster), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterConfig\"}}]")]
    public class OpensearchOpensearchCluster : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster oci_opensearch_opensearch_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OpensearchOpensearchCluster(Constructs.Construct scope, string id, oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchOpensearchCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchOpensearchCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OpensearchOpensearchCluster resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OpensearchOpensearchCluster to import.</param>
        /// <param name="importFromId">The id of the existing OpensearchOpensearchCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OpensearchOpensearchCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OpensearchOpensearchCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OpensearchOpensearchCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OpensearchOpensearchCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.OpensearchOpensearchCluster.OpensearchOpensearchCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCertificateConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterCertificateConfig\"}}]")]
        public virtual void PutCertificateConfig(oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterCertificateConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterCertificateConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMaintenanceDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterMaintenanceDetails\"}}]")]
        public virtual void PutMaintenanceDetails(oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterMaintenanceDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterMaintenanceDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutboundClusterConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfig\"}}]")]
        public virtual void PutOutboundClusterConfig(oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterOutboundClusterConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterOutboundClusterConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecuritySamlConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecuritySamlConfig\"}}]")]
        public virtual void PutSecuritySamlConfig(oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecuritySamlConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecuritySamlConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCertificateConfig")]
        public virtual void ResetCertificateConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigureOutboundClusterTrigger")]
        public virtual void ResetConfigureOutboundClusterTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataNodeHostBareMetalShape")]
        public virtual void ResetDataNodeHostBareMetalShape()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataNodeHostShape")]
        public virtual void ResetDataNodeHostShape()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInboundClusterIds")]
        public virtual void ResetInboundClusterIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceDetails")]
        public virtual void ResetMaintenanceDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMasterNodeHostBareMetalShape")]
        public virtual void ResetMasterNodeHostBareMetalShape()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMasterNodeHostShape")]
        public virtual void ResetMasterNodeHostShape()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNsgId")]
        public virtual void ResetNsgId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpendashboardNodeHostShape")]
        public virtual void ResetOpendashboardNodeHostShape()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutboundClusterConfig")]
        public virtual void ResetOutboundClusterConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReverseConnectionEndpointCustomerIps")]
        public virtual void ResetReverseConnectionEndpointCustomerIps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSearchNodeCount")]
        public virtual void ResetSearchNodeCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSearchNodeHostMemoryGb")]
        public virtual void ResetSearchNodeHostMemoryGb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSearchNodeHostOcpuCount")]
        public virtual void ResetSearchNodeHostOcpuCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSearchNodeHostShape")]
        public virtual void ResetSearchNodeHostShape()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSearchNodeHostType")]
        public virtual void ResetSearchNodeHostType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSearchNodeStorageGb")]
        public virtual void ResetSearchNodeStorageGb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityAttributes")]
        public virtual void ResetSecurityAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityMasterUserName")]
        public virtual void ResetSecurityMasterUserName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityMasterUserPasswordHash")]
        public virtual void ResetSecurityMasterUserPasswordHash()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityMode")]
        public virtual void ResetSecurityMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecuritySamlConfig")]
        public virtual void ResetSecuritySamlConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSystemTags")]
        public virtual void ResetSystemTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpgradeMajorVersionTrigger")]
        public virtual void ResetUpgradeMajorVersionTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(oci.OpensearchOpensearchCluster.OpensearchOpensearchCluster))!;

        [JsiiProperty(name: "availabilityDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AvailabilityDomains
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "certificateConfig", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterCertificateConfigOutputReference\"}")]
        public virtual oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterCertificateConfigOutputReference CertificateConfig
        {
            get => GetInstanceProperty<oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterCertificateConfigOutputReference>()!;
        }

        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceDetails", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterMaintenanceDetailsOutputReference\"}")]
        public virtual oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterMaintenanceDetailsOutputReference MaintenanceDetails
        {
            get => GetInstanceProperty<oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterMaintenanceDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "opendashboardFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpendashboardFqdn
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

        [JsiiProperty(name: "outboundClusterConfig", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfigOutputReference\"}")]
        public virtual oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfigOutputReference OutboundClusterConfig
        {
            get => GetInstanceProperty<oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfigOutputReference>()!;
        }

        [JsiiProperty(name: "reverseConnectionEndpoints", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterReverseConnectionEndpointsList\"}")]
        public virtual oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterReverseConnectionEndpointsList ReverseConnectionEndpoints
        {
            get => GetInstanceProperty<oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterReverseConnectionEndpointsList>()!;
        }

        [JsiiProperty(name: "securitySamlConfig", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecuritySamlConfigOutputReference\"}")]
        public virtual oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterSecuritySamlConfigOutputReference SecuritySamlConfig
        {
            get => GetInstanceProperty<oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterSecuritySamlConfigOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterTimeoutsOutputReference\"}")]
        public virtual oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterTimeoutsOutputReference>()!;
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

        [JsiiOptional]
        [JsiiProperty(name: "certificateConfigInput", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterCertificateConfig\"}", isOptional: true)]
        public virtual oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterCertificateConfig? CertificateConfigInput
        {
            get => GetInstanceProperty<oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterCertificateConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configureOutboundClusterTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConfigureOutboundClusterTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataNodeCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DataNodeCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataNodeHostBareMetalShapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataNodeHostBareMetalShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataNodeHostMemoryGbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DataNodeHostMemoryGbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataNodeHostOcpuCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DataNodeHostOcpuCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataNodeHostShapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataNodeHostShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataNodeHostTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataNodeHostTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataNodeStorageGbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DataNodeStorageGbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inboundClusterIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? InboundClusterIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceDetailsInput", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterMaintenanceDetails\"}", isOptional: true)]
        public virtual oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterMaintenanceDetails? MaintenanceDetailsInput
        {
            get => GetInstanceProperty<oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterMaintenanceDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterNodeCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MasterNodeCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterNodeHostBareMetalShapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MasterNodeHostBareMetalShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterNodeHostMemoryGbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MasterNodeHostMemoryGbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterNodeHostOcpuCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MasterNodeHostOcpuCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterNodeHostShapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MasterNodeHostShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterNodeHostTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MasterNodeHostTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nsgIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NsgIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "opendashboardNodeCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OpendashboardNodeCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "opendashboardNodeHostMemoryGbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OpendashboardNodeHostMemoryGbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "opendashboardNodeHostOcpuCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OpendashboardNodeHostOcpuCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "opendashboardNodeHostShapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OpendashboardNodeHostShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outboundClusterConfigInput", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfig\"}", isOptional: true)]
        public virtual oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterOutboundClusterConfig? OutboundClusterConfigInput
        {
            get => GetInstanceProperty<oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterOutboundClusterConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reverseConnectionEndpointCustomerIpsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ReverseConnectionEndpointCustomerIpsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "searchNodeCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SearchNodeCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "searchNodeHostMemoryGbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SearchNodeHostMemoryGbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "searchNodeHostOcpuCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SearchNodeHostOcpuCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "searchNodeHostShapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SearchNodeHostShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "searchNodeHostTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SearchNodeHostTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "searchNodeStorageGbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SearchNodeStorageGbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityAttributesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? SecurityAttributesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityMasterUserNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityMasterUserNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityMasterUserPasswordHashInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityMasterUserPasswordHashInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securitySamlConfigInput", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecuritySamlConfig\"}", isOptional: true)]
        public virtual oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecuritySamlConfig? SecuritySamlConfigInput
        {
            get => GetInstanceProperty<oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecuritySamlConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "softwareVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SoftwareVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetCompartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetCompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "systemTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? SystemTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upgradeMajorVersionTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? UpgradeMajorVersionTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcnCompartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VcnCompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcnIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VcnIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configureOutboundClusterTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConfigureOutboundClusterTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataNodeCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataNodeHostBareMetalShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataNodeHostBareMetalShape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataNodeHostMemoryGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataNodeHostMemoryGb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataNodeHostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataNodeHostOcpuCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataNodeHostShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataNodeHostShape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataNodeHostType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataNodeHostType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataNodeStorageGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataNodeStorageGb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inboundClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InboundClusterIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "masterNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MasterNodeCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "masterNodeHostBareMetalShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterNodeHostBareMetalShape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "masterNodeHostMemoryGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MasterNodeHostMemoryGb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "masterNodeHostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MasterNodeHostOcpuCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "masterNodeHostShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterNodeHostShape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "masterNodeHostType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterNodeHostType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nsgId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsgId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "opendashboardNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OpendashboardNodeCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "opendashboardNodeHostMemoryGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OpendashboardNodeHostMemoryGb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "opendashboardNodeHostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OpendashboardNodeHostOcpuCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "opendashboardNodeHostShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpendashboardNodeHostShape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reverseConnectionEndpointCustomerIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ReverseConnectionEndpointCustomerIps
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "searchNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SearchNodeCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "searchNodeHostMemoryGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SearchNodeHostMemoryGb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "searchNodeHostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SearchNodeHostOcpuCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "searchNodeHostShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SearchNodeHostShape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "searchNodeHostType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SearchNodeHostType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "searchNodeStorageGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SearchNodeStorageGb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> SecurityAttributes
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityMasterUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityMasterUserName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityMasterUserPasswordHash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityMasterUserPasswordHash
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "softwareVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftwareVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetCompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> SystemTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "upgradeMajorVersionTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UpgradeMajorVersionTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vcnCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcnCompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcnId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
