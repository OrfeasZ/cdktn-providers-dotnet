using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApmTracesScheduledQuery
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_scheduled_query oci_apm_traces_scheduled_query}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciApmTracesScheduledQuery.DataOciApmTracesScheduledQuery), fullyQualifiedName: "oci.dataOciApmTracesScheduledQuery.DataOciApmTracesScheduledQuery", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciApmTracesScheduledQuery.DataOciApmTracesScheduledQueryConfig\"}}]")]
    public class DataOciApmTracesScheduledQuery : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_scheduled_query oci_apm_traces_scheduled_query} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciApmTracesScheduledQuery(Constructs.Construct scope, string id, oci.DataOciApmTracesScheduledQuery.IDataOciApmTracesScheduledQueryConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciApmTracesScheduledQuery.IDataOciApmTracesScheduledQueryConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmTracesScheduledQuery(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmTracesScheduledQuery(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciApmTracesScheduledQuery resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciApmTracesScheduledQuery to import.</param>
        /// <param name="importFromId">The id of the existing DataOciApmTracesScheduledQuery that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciApmTracesScheduledQuery to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciApmTracesScheduledQuery to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_traces_scheduled_query#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciApmTracesScheduledQuery that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciApmTracesScheduledQuery to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciApmTracesScheduledQuery.DataOciApmTracesScheduledQuery), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciApmTracesScheduledQuery.DataOciApmTracesScheduledQuery))!;

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "opcDryRun", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpcDryRun
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryInstances", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryInstances
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryMaximumRuntimeInSeconds", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryMaximumRuntimeInSeconds
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryNextRunInMs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryNextRunInMs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryProcessingConfiguration", typeJson: "{\"fqn\":\"oci.dataOciApmTracesScheduledQuery.DataOciApmTracesScheduledQueryScheduledQueryProcessingConfigurationList\"}")]
        public virtual oci.DataOciApmTracesScheduledQuery.DataOciApmTracesScheduledQueryScheduledQueryProcessingConfigurationList ScheduledQueryProcessingConfiguration
        {
            get => GetInstanceProperty<oci.DataOciApmTracesScheduledQuery.DataOciApmTracesScheduledQueryScheduledQueryProcessingConfigurationList>()!;
        }

        [JsiiProperty(name: "scheduledQueryProcessingSubType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryProcessingSubType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryProcessingType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryProcessingType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryRetentionCriteria", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryRetentionCriteria
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryRetentionPeriodInMs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryRetentionPeriodInMs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQuerySchedule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQuerySchedule
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryText
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

        [JsiiOptional]
        [JsiiProperty(name: "apmDomainIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApmDomainIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduledQueryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScheduledQueryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "apmDomainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApmDomainId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scheduledQueryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
