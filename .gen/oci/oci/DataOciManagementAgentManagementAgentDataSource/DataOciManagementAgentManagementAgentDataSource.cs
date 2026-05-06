using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciManagementAgentManagementAgentDataSource
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/management_agent_management_agent_data_source oci_management_agent_management_agent_data_source}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciManagementAgentManagementAgentDataSource.DataOciManagementAgentManagementAgentDataSource), fullyQualifiedName: "oci.dataOciManagementAgentManagementAgentDataSource.DataOciManagementAgentManagementAgentDataSource", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciManagementAgentManagementAgentDataSource.DataOciManagementAgentManagementAgentDataSourceConfig\"}}]")]
    public class DataOciManagementAgentManagementAgentDataSource : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/management_agent_management_agent_data_source oci_management_agent_management_agent_data_source} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciManagementAgentManagementAgentDataSource(Constructs.Construct scope, string id, oci.DataOciManagementAgentManagementAgentDataSource.IDataOciManagementAgentManagementAgentDataSourceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciManagementAgentManagementAgentDataSource.IDataOciManagementAgentManagementAgentDataSourceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciManagementAgentManagementAgentDataSource(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciManagementAgentManagementAgentDataSource(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciManagementAgentManagementAgentDataSource resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciManagementAgentManagementAgentDataSource to import.</param>
        /// <param name="importFromId">The id of the existing DataOciManagementAgentManagementAgentDataSource that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciManagementAgentManagementAgentDataSource to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciManagementAgentManagementAgentDataSource to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/management_agent_management_agent_data_source#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciManagementAgentManagementAgentDataSource that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciManagementAgentManagementAgentDataSource to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciManagementAgentManagementAgentDataSource.DataOciManagementAgentManagementAgentDataSource), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciManagementAgentManagementAgentDataSource.DataOciManagementAgentManagementAgentDataSource))!;

        [JsiiProperty(name: "allowMetrics", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllowMetrics
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectionTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isDaemonSet", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDaemonSet
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "metricDimensions", typeJson: "{\"fqn\":\"oci.dataOciManagementAgentManagementAgentDataSource.DataOciManagementAgentManagementAgentDataSourceMetricDimensionsList\"}")]
        public virtual oci.DataOciManagementAgentManagementAgentDataSource.DataOciManagementAgentManagementAgentDataSourceMetricDimensionsList MetricDimensions
        {
            get => GetInstanceProperty<oci.DataOciManagementAgentManagementAgentDataSource.DataOciManagementAgentManagementAgentDataSourceMetricDimensionsList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "proxyUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProxyUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "readDataLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReadDataLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "readDataLimitInKilobytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReadDataLimitInKilobytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "readTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReadTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "resourceGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduleMins", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScheduleMins
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSourceKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataSourceKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managementAgentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagementAgentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dataSourceKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSourceKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementAgentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
