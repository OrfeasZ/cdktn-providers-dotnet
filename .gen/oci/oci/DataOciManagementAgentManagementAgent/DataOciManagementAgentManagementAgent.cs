using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciManagementAgentManagementAgent
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/management_agent_management_agent oci_management_agent_management_agent}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciManagementAgentManagementAgent.DataOciManagementAgentManagementAgent), fullyQualifiedName: "oci.dataOciManagementAgentManagementAgent.DataOciManagementAgentManagementAgent", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciManagementAgentManagementAgent.DataOciManagementAgentManagementAgentConfig\"}}]")]
    public class DataOciManagementAgentManagementAgent : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/management_agent_management_agent oci_management_agent_management_agent} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciManagementAgentManagementAgent(Constructs.Construct scope, string id, oci.DataOciManagementAgentManagementAgent.IDataOciManagementAgentManagementAgentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciManagementAgentManagementAgent.IDataOciManagementAgentManagementAgentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciManagementAgentManagementAgent(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciManagementAgentManagementAgent(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciManagementAgentManagementAgent resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciManagementAgentManagementAgent to import.</param>
        /// <param name="importFromId">The id of the existing DataOciManagementAgentManagementAgent that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciManagementAgentManagementAgent to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciManagementAgentManagementAgent to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/management_agent_management_agent#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciManagementAgentManagementAgent that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciManagementAgentManagementAgent to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciManagementAgentManagementAgent.DataOciManagementAgentManagementAgent), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciManagementAgentManagementAgent.DataOciManagementAgentManagementAgent))!;

        [JsiiProperty(name: "availabilityStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataSourceList", typeJson: "{\"fqn\":\"oci.dataOciManagementAgentManagementAgent.DataOciManagementAgentManagementAgentDataSourceListStructList\"}")]
        public virtual oci.DataOciManagementAgentManagementAgent.DataOciManagementAgentManagementAgentDataSourceListStructList DataSourceList
        {
            get => GetInstanceProperty<oci.DataOciManagementAgentManagementAgent.DataOciManagementAgentManagementAgentDataSourceListStructList>()!;
        }

        [JsiiProperty(name: "dataSourceSummaryList", typeJson: "{\"fqn\":\"oci.dataOciManagementAgentManagementAgent.DataOciManagementAgentManagementAgentDataSourceSummaryListStructList\"}")]
        public virtual oci.DataOciManagementAgentManagementAgent.DataOciManagementAgentManagementAgentDataSourceSummaryListStructList DataSourceSummaryList
        {
            get => GetInstanceProperty<oci.DataOciManagementAgentManagementAgent.DataOciManagementAgentManagementAgentDataSourceSummaryListStructList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "deployPluginsId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DeployPluginsId
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Host
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "installKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstallKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "installPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstallPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "installType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstallType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAgentAutoUpgradable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAgentAutoUpgradable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isCustomerDeployed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCustomerDeployed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "latestSupportedVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LatestSupportedVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedAgentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedAgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementAgentProperties", typeJson: "{\"fqn\":\"oci.dataOciManagementAgentManagementAgent.DataOciManagementAgentManagementAgentManagementAgentPropertiesList\"}")]
        public virtual oci.DataOciManagementAgentManagementAgent.DataOciManagementAgentManagementAgentManagementAgentPropertiesList ManagementAgentProperties
        {
            get => GetInstanceProperty<oci.DataOciManagementAgentManagementAgent.DataOciManagementAgentManagementAgentManagementAgentPropertiesList>()!;
        }

        [JsiiProperty(name: "platformName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platformType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pluginList", typeJson: "{\"fqn\":\"oci.dataOciManagementAgentManagementAgent.DataOciManagementAgentManagementAgentPluginListStructList\"}")]
        public virtual oci.DataOciManagementAgentManagementAgent.DataOciManagementAgentManagementAgentPluginListStructList PluginList
        {
            get => GetInstanceProperty<oci.DataOciManagementAgentManagementAgent.DataOciManagementAgentManagementAgentPluginListStructList>()!;
        }

        [JsiiProperty(name: "resourceArtifactVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceArtifactVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
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

        [JsiiProperty(name: "timeLastHeartbeat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastHeartbeat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "managementAgentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagementAgentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementAgentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
