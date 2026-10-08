using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/data_safe_subsetting_policy_subsetting_schema_relation oci_data_safe_subsetting_policy_subsetting_schema_relation}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelation.DataOciDataSafeSubsettingPolicySubsettingSchemaRelation), fullyQualifiedName: "oci.dataOciDataSafeSubsettingPolicySubsettingSchemaRelation.DataOciDataSafeSubsettingPolicySubsettingSchemaRelation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataSafeSubsettingPolicySubsettingSchemaRelation.DataOciDataSafeSubsettingPolicySubsettingSchemaRelationConfig\"}}]")]
    public class DataOciDataSafeSubsettingPolicySubsettingSchemaRelation : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/data_safe_subsetting_policy_subsetting_schema_relation oci_data_safe_subsetting_policy_subsetting_schema_relation} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataSafeSubsettingPolicySubsettingSchemaRelation(Constructs.Construct scope, string id, oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelation.IDataOciDataSafeSubsettingPolicySubsettingSchemaRelationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelation.IDataOciDataSafeSubsettingPolicySubsettingSchemaRelationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSubsettingPolicySubsettingSchemaRelation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSubsettingPolicySubsettingSchemaRelation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataSafeSubsettingPolicySubsettingSchemaRelation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataSafeSubsettingPolicySubsettingSchemaRelation to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataSafeSubsettingPolicySubsettingSchemaRelation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataSafeSubsettingPolicySubsettingSchemaRelation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataSafeSubsettingPolicySubsettingSchemaRelation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/data_safe_subsetting_policy_subsetting_schema_relation#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataSafeSubsettingPolicySubsettingSchemaRelation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataSafeSubsettingPolicySubsettingSchemaRelation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelation.DataOciDataSafeSubsettingPolicySubsettingSchemaRelation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelation.DataOciDataSafeSubsettingPolicySubsettingSchemaRelation))!;

        [JsiiProperty(name: "childColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ChildColumns
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "childObjectKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChildObjectKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "childObjectName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChildObjectName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "childSchemaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChildSchemaName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ParentColumns
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "parentObjectKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentObjectKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentObjectName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentObjectName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentSchemaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentSchemaName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "relationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RelationType
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

        [JsiiOptional]
        [JsiiProperty(name: "subsettingPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubsettingPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subsettingSchemaRelationKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubsettingSchemaRelationKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "subsettingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubsettingPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subsettingSchemaRelationKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubsettingSchemaRelationKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
