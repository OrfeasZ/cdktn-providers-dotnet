using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOpsiDatabaseInsight
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_database_insight oci_opsi_database_insight}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOpsiDatabaseInsight.DataOciOpsiDatabaseInsight), fullyQualifiedName: "oci.dataOciOpsiDatabaseInsight.DataOciOpsiDatabaseInsight", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOpsiDatabaseInsight.DataOciOpsiDatabaseInsightConfig\"}}]")]
    public class DataOciOpsiDatabaseInsight : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_database_insight oci_opsi_database_insight} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOpsiDatabaseInsight(Constructs.Construct scope, string id, oci.DataOciOpsiDatabaseInsight.IDataOciOpsiDatabaseInsightConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOpsiDatabaseInsight.IDataOciOpsiDatabaseInsightConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpsiDatabaseInsight(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpsiDatabaseInsight(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOpsiDatabaseInsight resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOpsiDatabaseInsight to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOpsiDatabaseInsight that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOpsiDatabaseInsight to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOpsiDatabaseInsight to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_database_insight#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOpsiDatabaseInsight that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOpsiDatabaseInsight to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOpsiDatabaseInsight.DataOciOpsiDatabaseInsight), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciOpsiDatabaseInsight.DataOciOpsiDatabaseInsight))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionCredentialDetails", typeJson: "{\"fqn\":\"oci.dataOciOpsiDatabaseInsight.DataOciOpsiDatabaseInsightConnectionCredentialDetailsList\"}")]
        public virtual oci.DataOciOpsiDatabaseInsight.DataOciOpsiDatabaseInsightConnectionCredentialDetailsList ConnectionCredentialDetails
        {
            get => GetInstanceProperty<oci.DataOciOpsiDatabaseInsight.DataOciOpsiDatabaseInsightConnectionCredentialDetailsList>()!;
        }

        [JsiiProperty(name: "connectionDetails", typeJson: "{\"fqn\":\"oci.dataOciOpsiDatabaseInsight.DataOciOpsiDatabaseInsightConnectionDetailsList\"}")]
        public virtual oci.DataOciOpsiDatabaseInsight.DataOciOpsiDatabaseInsightConnectionDetailsList ConnectionDetails
        {
            get => GetInstanceProperty<oci.DataOciOpsiDatabaseInsight.DataOciOpsiDatabaseInsightConnectionDetailsList>()!;
        }

        [JsiiProperty(name: "connectorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectorId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "credentialDetails", typeJson: "{\"fqn\":\"oci.dataOciOpsiDatabaseInsight.DataOciOpsiDatabaseInsightCredentialDetailsList\"}")]
        public virtual oci.DataOciOpsiDatabaseInsight.DataOciOpsiDatabaseInsightCredentialDetailsList CredentialDetails
        {
            get => GetInstanceProperty<oci.DataOciOpsiDatabaseInsight.DataOciOpsiDatabaseInsightCredentialDetailsList>()!;
        }

        [JsiiProperty(name: "databaseConnectionStatusDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseConnectionStatusDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseConnectorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseConnectorId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseResourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbmPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbmPrivateEndpointId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enterpriseManagerBridgeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterpriseManagerBridgeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enterpriseManagerEntityDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterpriseManagerEntityDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enterpriseManagerEntityIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterpriseManagerEntityIdentifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enterpriseManagerEntityName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterpriseManagerEntityName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enterpriseManagerEntityType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterpriseManagerEntityType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enterpriseManagerIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterpriseManagerIdentifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entitySource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntitySource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exadataInsightId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExadataInsightId
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

        [JsiiProperty(name: "isAdvancedFeaturesEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAdvancedFeaturesEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isHeatWaveClusterAttached", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHeatWaveClusterAttached
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isHighlyAvailable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHighlyAvailable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementAgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "opsiPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpsiPrivateEndpointId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "processorCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProcessorCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rootId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
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

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseInsightIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseInsightIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "databaseInsightId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseInsightId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
