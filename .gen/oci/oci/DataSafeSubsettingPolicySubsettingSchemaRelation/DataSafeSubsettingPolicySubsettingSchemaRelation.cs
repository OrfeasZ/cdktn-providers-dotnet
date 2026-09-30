using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingPolicySubsettingSchemaRelation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation oci_data_safe_subsetting_policy_subsetting_schema_relation}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataSafeSubsettingPolicySubsettingSchemaRelation.DataSafeSubsettingPolicySubsettingSchemaRelation), fullyQualifiedName: "oci.dataSafeSubsettingPolicySubsettingSchemaRelation.DataSafeSubsettingPolicySubsettingSchemaRelation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingSchemaRelation.DataSafeSubsettingPolicySubsettingSchemaRelationConfig\"}}]")]
    public class DataSafeSubsettingPolicySubsettingSchemaRelation : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation oci_data_safe_subsetting_policy_subsetting_schema_relation} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataSafeSubsettingPolicySubsettingSchemaRelation(Constructs.Construct scope, string id, oci.DataSafeSubsettingPolicySubsettingSchemaRelation.IDataSafeSubsettingPolicySubsettingSchemaRelationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataSafeSubsettingPolicySubsettingSchemaRelation.IDataSafeSubsettingPolicySubsettingSchemaRelationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeSubsettingPolicySubsettingSchemaRelation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeSubsettingPolicySubsettingSchemaRelation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataSafeSubsettingPolicySubsettingSchemaRelation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataSafeSubsettingPolicySubsettingSchemaRelation to import.</param>
        /// <param name="importFromId">The id of the existing DataSafeSubsettingPolicySubsettingSchemaRelation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataSafeSubsettingPolicySubsettingSchemaRelation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataSafeSubsettingPolicySubsettingSchemaRelation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_subsetting_schema_relation#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataSafeSubsettingPolicySubsettingSchemaRelation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataSafeSubsettingPolicySubsettingSchemaRelation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataSafeSubsettingPolicySubsettingSchemaRelation.DataSafeSubsettingPolicySubsettingSchemaRelation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingSchemaRelation.DataSafeSubsettingPolicySubsettingSchemaRelationTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DataSafeSubsettingPolicySubsettingSchemaRelation.IDataSafeSubsettingPolicySubsettingSchemaRelationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeSubsettingPolicySubsettingSchemaRelation.IDataSafeSubsettingPolicySubsettingSchemaRelationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetChildObjectKey")]
        public virtual void ResetChildObjectKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParentObjectKey")]
        public virtual void ResetParentObjectKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(oci.DataSafeSubsettingPolicySubsettingSchemaRelation.DataSafeSubsettingPolicySubsettingSchemaRelation))!;

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingSchemaRelation.DataSafeSubsettingPolicySubsettingSchemaRelationTimeoutsOutputReference\"}")]
        public virtual oci.DataSafeSubsettingPolicySubsettingSchemaRelation.DataSafeSubsettingPolicySubsettingSchemaRelationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DataSafeSubsettingPolicySubsettingSchemaRelation.DataSafeSubsettingPolicySubsettingSchemaRelationTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "childColumnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ChildColumnsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "childObjectKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ChildObjectKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "childObjectNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ChildObjectNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "childSchemaNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ChildSchemaNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parentColumnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ParentColumnsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parentObjectKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParentObjectKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parentObjectNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParentObjectNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parentSchemaNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParentSchemaNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subsettingPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubsettingPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DataSafeSubsettingPolicySubsettingSchemaRelation.IDataSafeSubsettingPolicySubsettingSchemaRelationTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dataSafeSubsettingPolicySubsettingSchemaRelation.DataSafeSubsettingPolicySubsettingSchemaRelationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "childColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ChildColumns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "childObjectKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChildObjectKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "childObjectName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChildObjectName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "childSchemaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChildSchemaName
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

        [JsiiProperty(name: "parentColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ParentColumns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parentObjectKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentObjectKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parentObjectName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentObjectName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parentSchemaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentSchemaName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subsettingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubsettingPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
