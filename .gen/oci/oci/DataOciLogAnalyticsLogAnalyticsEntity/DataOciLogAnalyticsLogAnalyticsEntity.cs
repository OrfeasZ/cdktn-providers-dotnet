using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLogAnalyticsLogAnalyticsEntity
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/log_analytics_log_analytics_entity oci_log_analytics_log_analytics_entity}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciLogAnalyticsLogAnalyticsEntity.DataOciLogAnalyticsLogAnalyticsEntity), fullyQualifiedName: "oci.dataOciLogAnalyticsLogAnalyticsEntity.DataOciLogAnalyticsLogAnalyticsEntity", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciLogAnalyticsLogAnalyticsEntity.DataOciLogAnalyticsLogAnalyticsEntityConfig\"}}]")]
    public class DataOciLogAnalyticsLogAnalyticsEntity : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/log_analytics_log_analytics_entity oci_log_analytics_log_analytics_entity} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciLogAnalyticsLogAnalyticsEntity(Constructs.Construct scope, string id, oci.DataOciLogAnalyticsLogAnalyticsEntity.IDataOciLogAnalyticsLogAnalyticsEntityConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciLogAnalyticsLogAnalyticsEntity.IDataOciLogAnalyticsLogAnalyticsEntityConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLogAnalyticsLogAnalyticsEntity(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLogAnalyticsLogAnalyticsEntity(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciLogAnalyticsLogAnalyticsEntity resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciLogAnalyticsLogAnalyticsEntity to import.</param>
        /// <param name="importFromId">The id of the existing DataOciLogAnalyticsLogAnalyticsEntity that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciLogAnalyticsLogAnalyticsEntity to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciLogAnalyticsLogAnalyticsEntity to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/log_analytics_log_analytics_entity#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciLogAnalyticsLogAnalyticsEntity that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciLogAnalyticsLogAnalyticsEntity to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciLogAnalyticsLogAnalyticsEntity.DataOciLogAnalyticsLogAnalyticsEntity), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetIsShowAssociatedSourcesCount")]
        public virtual void ResetIsShowAssociatedSourcesCount()
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
        = GetStaticProperty<string>(typeof(oci.DataOciLogAnalyticsLogAnalyticsEntity.DataOciLogAnalyticsLogAnalyticsEntity))!;

        [JsiiProperty(name: "areLogsCollected", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AreLogsCollected
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "associatedSourcesCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AssociatedSourcesCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cloudResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "entityTypeInternalName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntityTypeInternalName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entityTypeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntityTypeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementAgentCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementAgentCompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementAgentDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementAgentDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementAgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciLogAnalyticsLogAnalyticsEntity.DataOciLogAnalyticsLogAnalyticsEntityMetadataList\"}")]
        public virtual oci.DataOciLogAnalyticsLogAnalyticsEntity.DataOciLogAnalyticsLogAnalyticsEntityMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciLogAnalyticsLogAnalyticsEntity.DataOciLogAnalyticsLogAnalyticsEntityMetadataList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Properties
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "timeLastDiscovered", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastDiscovered
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timezoneRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimezoneRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "isShowAssociatedSourcesCountInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IsShowAssociatedSourcesCountInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logAnalyticsEntityIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogAnalyticsEntityIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "isShowAssociatedSourcesCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IsShowAssociatedSourcesCount
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logAnalyticsEntityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogAnalyticsEntityId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
