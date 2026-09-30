using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelations
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/data-sources/data_safe_subsetting_policy_subsetting_schema_relations oci_data_safe_subsetting_policy_subsetting_schema_relations}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelations.DataOciDataSafeSubsettingPolicySubsettingSchemaRelations), fullyQualifiedName: "oci.dataOciDataSafeSubsettingPolicySubsettingSchemaRelations.DataOciDataSafeSubsettingPolicySubsettingSchemaRelations", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataSafeSubsettingPolicySubsettingSchemaRelations.DataOciDataSafeSubsettingPolicySubsettingSchemaRelationsConfig\"}}]")]
    public class DataOciDataSafeSubsettingPolicySubsettingSchemaRelations : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/data-sources/data_safe_subsetting_policy_subsetting_schema_relations oci_data_safe_subsetting_policy_subsetting_schema_relations} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataSafeSubsettingPolicySubsettingSchemaRelations(Constructs.Construct scope, string id, oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelations.IDataOciDataSafeSubsettingPolicySubsettingSchemaRelationsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelations.IDataOciDataSafeSubsettingPolicySubsettingSchemaRelationsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSubsettingPolicySubsettingSchemaRelations(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSubsettingPolicySubsettingSchemaRelations(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataSafeSubsettingPolicySubsettingSchemaRelations resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataSafeSubsettingPolicySubsettingSchemaRelations to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataSafeSubsettingPolicySubsettingSchemaRelations that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataSafeSubsettingPolicySubsettingSchemaRelations to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataSafeSubsettingPolicySubsettingSchemaRelations to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/data-sources/data_safe_subsetting_policy_subsetting_schema_relations#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataSafeSubsettingPolicySubsettingSchemaRelations that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataSafeSubsettingPolicySubsettingSchemaRelations to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelations.DataOciDataSafeSubsettingPolicySubsettingSchemaRelations), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelations.IDataOciDataSafeSubsettingPolicySubsettingSchemaRelationsFilter" />)[]</param>
        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeSubsettingPolicySubsettingSchemaRelations.DataOciDataSafeSubsettingPolicySubsettingSchemaRelationsFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelations.IDataOciDataSafeSubsettingPolicySubsettingSchemaRelationsFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelations.IDataOciDataSafeSubsettingPolicySubsettingSchemaRelationsFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelations.IDataOciDataSafeSubsettingPolicySubsettingSchemaRelationsFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObject")]
        public virtual void ResetObject()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRelationType")]
        public virtual void ResetRelationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchemaName")]
        public virtual void ResetSchemaName()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelations.DataOciDataSafeSubsettingPolicySubsettingSchemaRelations))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSubsettingPolicySubsettingSchemaRelations.DataOciDataSafeSubsettingPolicySubsettingSchemaRelationsFilterList\"}")]
        public virtual oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelations.DataOciDataSafeSubsettingPolicySubsettingSchemaRelationsFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelations.DataOciDataSafeSubsettingPolicySubsettingSchemaRelationsFilterList>()!;
        }

        [JsiiProperty(name: "subsettingSchemaRelationCollection", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSubsettingPolicySubsettingSchemaRelations.DataOciDataSafeSubsettingPolicySubsettingSchemaRelationsSubsettingSchemaRelationCollectionList\"}")]
        public virtual oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelations.DataOciDataSafeSubsettingPolicySubsettingSchemaRelationsSubsettingSchemaRelationCollectionList SubsettingSchemaRelationCollection
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelations.DataOciDataSafeSubsettingPolicySubsettingSchemaRelationsSubsettingSchemaRelationCollectionList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciDataSafeSubsettingPolicySubsettingSchemaRelations.IDataOciDataSafeSubsettingPolicySubsettingSchemaRelationsFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeSubsettingPolicySubsettingSchemaRelations.DataOciDataSafeSubsettingPolicySubsettingSchemaRelationsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ObjectInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "relationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RelationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaNameInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SchemaNameInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subsettingPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubsettingPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "object", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Object
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "relationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RelationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schemaName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SchemaName
        {
            get => GetInstanceProperty<string[]>()!;
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
