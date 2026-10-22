using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/data-sources/database_migration_migration_data_verification_object_type_counts oci_database_migration_migration_data_verification_object_type_counts}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts), fullyQualifiedName: "oci.dataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCountsConfig\"}}]")]
    public class DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/data-sources/database_migration_migration_data_verification_object_type_counts oci_database_migration_migration_data_verification_object_type_counts} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts(Constructs.Construct scope, string id, oci.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.IDataOciDatabaseMigrationMigrationDataVerificationObjectTypeCountsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.IDataOciDatabaseMigrationMigrationDataVerificationObjectTypeCountsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/data-sources/database_migration_migration_data_verification_object_type_counts#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.IDataOciDatabaseMigrationMigrationDataVerificationObjectTypeCountsFilter" />)[]</param>
        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCountsFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.IDataOciDatabaseMigrationMigrationDataVerificationObjectTypeCountsFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.IDataOciDatabaseMigrationMigrationDataVerificationObjectTypeCountsFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.IDataOciDatabaseMigrationMigrationDataVerificationObjectTypeCountsFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
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

        [JsiiMethod(name: "resetMigrationDataVerificationObjectTypeCountFilter")]
        public virtual void ResetMigrationDataVerificationObjectTypeCountFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinAbsDeltaPercent")]
        public virtual void ResetMinAbsDeltaPercent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectType")]
        public virtual void ResetObjectType()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts))!;

        [JsiiProperty(name: "dataVerificationObjectTypeCountCollection", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCountsDataVerificationObjectTypeCountCollectionList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCountsDataVerificationObjectTypeCountCollectionList DataVerificationObjectTypeCountCollection
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCountsDataVerificationObjectTypeCountCollectionList>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCountsFilterList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCountsFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCountsFilterList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.IDataOciDatabaseMigrationMigrationDataVerificationObjectTypeCountsFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDatabaseMigrationMigrationDataVerificationObjectTypeCounts.DataOciDatabaseMigrationMigrationDataVerificationObjectTypeCountsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "migrationDataVerificationObjectTypeCountFilterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MigrationDataVerificationObjectTypeCountFilterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "migrationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MigrationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minAbsDeltaPercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinAbsDeltaPercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SchemaNameInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "migrationDataVerificationObjectTypeCountFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MigrationDataVerificationObjectTypeCountFilter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "migrationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MigrationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minAbsDeltaPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinAbsDeltaPercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchemaName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
