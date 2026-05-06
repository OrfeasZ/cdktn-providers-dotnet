using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataintegrationWorkspaceApplicationSchedule
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/dataintegration_workspace_application_schedule oci_dataintegration_workspace_application_schedule}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataintegrationWorkspaceApplicationSchedule.DataOciDataintegrationWorkspaceApplicationSchedule), fullyQualifiedName: "oci.dataOciDataintegrationWorkspaceApplicationSchedule.DataOciDataintegrationWorkspaceApplicationSchedule", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationSchedule.DataOciDataintegrationWorkspaceApplicationScheduleConfig\"}}]")]
    public class DataOciDataintegrationWorkspaceApplicationSchedule : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/dataintegration_workspace_application_schedule oci_dataintegration_workspace_application_schedule} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataintegrationWorkspaceApplicationSchedule(Constructs.Construct scope, string id, oci.DataOciDataintegrationWorkspaceApplicationSchedule.IDataOciDataintegrationWorkspaceApplicationScheduleConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataintegrationWorkspaceApplicationSchedule.IDataOciDataintegrationWorkspaceApplicationScheduleConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataintegrationWorkspaceApplicationSchedule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataintegrationWorkspaceApplicationSchedule(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataintegrationWorkspaceApplicationSchedule resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataintegrationWorkspaceApplicationSchedule to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataintegrationWorkspaceApplicationSchedule that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataintegrationWorkspaceApplicationSchedule to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataintegrationWorkspaceApplicationSchedule to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/dataintegration_workspace_application_schedule#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataintegrationWorkspaceApplicationSchedule that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataintegrationWorkspaceApplicationSchedule to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataintegrationWorkspaceApplicationSchedule.DataOciDataintegrationWorkspaceApplicationSchedule), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataintegrationWorkspaceApplicationSchedule.DataOciDataintegrationWorkspaceApplicationSchedule))!;

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "frequencyDetails", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationSchedule.DataOciDataintegrationWorkspaceApplicationScheduleFrequencyDetailsList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplicationSchedule.DataOciDataintegrationWorkspaceApplicationScheduleFrequencyDetailsList FrequencyDetails
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplicationSchedule.DataOciDataintegrationWorkspaceApplicationScheduleFrequencyDetailsList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Identifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isDaylightAdjustmentEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDaylightAdjustmentEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationSchedule.DataOciDataintegrationWorkspaceApplicationScheduleMetadataList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplicationSchedule.DataOciDataintegrationWorkspaceApplicationScheduleMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplicationSchedule.DataOciDataintegrationWorkspaceApplicationScheduleMetadataList>()!;
        }

        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectStatus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ObjectStatus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "objectVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ObjectVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationSchedule.DataOciDataintegrationWorkspaceApplicationScheduleParentRefList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplicationSchedule.DataOciDataintegrationWorkspaceApplicationScheduleParentRefList ParentRef
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplicationSchedule.DataOciDataintegrationWorkspaceApplicationScheduleParentRefList>()!;
        }

        [JsiiProperty(name: "registryMetadata", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationSchedule.DataOciDataintegrationWorkspaceApplicationScheduleRegistryMetadataList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplicationSchedule.DataOciDataintegrationWorkspaceApplicationScheduleRegistryMetadataList RegistryMetadata
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplicationSchedule.DataOciDataintegrationWorkspaceApplicationScheduleRegistryMetadataList>()!;
        }

        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timezone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplicationKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScheduleKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workspaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkspaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "applicationKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scheduleKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduleKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
