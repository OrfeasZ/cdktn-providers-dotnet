using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseMigrationAssessmentAssessorCheck
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/database_migration_assessment_assessor_check oci_database_migration_assessment_assessor_check}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheck), fullyQualifiedName: "oci.dataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheck", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheckConfig\"}}]")]
    public class DataOciDatabaseMigrationAssessmentAssessorCheck : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/database_migration_assessment_assessor_check oci_database_migration_assessment_assessor_check} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseMigrationAssessmentAssessorCheck(Constructs.Construct scope, string id, oci.DataOciDatabaseMigrationAssessmentAssessorCheck.IDataOciDatabaseMigrationAssessmentAssessorCheckConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseMigrationAssessmentAssessorCheck.IDataOciDatabaseMigrationAssessmentAssessorCheckConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMigrationAssessmentAssessorCheck(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMigrationAssessmentAssessorCheck(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseMigrationAssessmentAssessorCheck resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseMigrationAssessmentAssessorCheck to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseMigrationAssessmentAssessorCheck that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseMigrationAssessmentAssessorCheck to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseMigrationAssessmentAssessorCheck to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/data-sources/database_migration_assessment_assessor_check#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseMigrationAssessmentAssessorCheck that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseMigrationAssessmentAssessorCheck to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheck), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheck))!;

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "assessorCheckGroup", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheckAssessorCheckGroupList\"}")]
        public virtual oci.DataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheckAssessorCheckGroupList AssessorCheckGroup
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheckAssessorCheckGroupList>()!;
        }

        [JsiiProperty(name: "assessorCheckState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessorCheckState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "checkAction", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheckCheckActionList\"}")]
        public virtual oci.DataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheckCheckActionList CheckAction
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheckCheckActionList>()!;
        }

        [JsiiProperty(name: "columns", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheckColumnsList\"}")]
        public virtual oci.DataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheckColumnsList Columns
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheckColumnsList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fixupScriptLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FixupScriptLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "helpLinkText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HelpLinkText
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "helpLinkUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HelpLinkUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "impact", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Impact
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isExclusionAllowed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsExclusionAllowed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "issue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logLocation", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheckLogLocationList\"}")]
        public virtual oci.DataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheckLogLocationList LogLocation
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheckLogLocationList>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheckMetadataList\"}")]
        public virtual oci.DataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheckMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationAssessmentAssessorCheck.DataOciDatabaseMigrationAssessmentAssessorCheckMetadataList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ObjectCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "objectsDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectsDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "assessmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssessmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "assessorNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssessorNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "checkNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CheckNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "assessmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "assessorName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessorName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "checkName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CheckName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
