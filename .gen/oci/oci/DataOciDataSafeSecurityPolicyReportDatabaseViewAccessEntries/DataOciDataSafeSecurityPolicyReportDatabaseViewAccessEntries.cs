using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_security_policy_report_database_view_access_entries oci_data_safe_security_policy_report_database_view_access_entries}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries), fullyQualifiedName: "oci.dataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesConfig\"}}]")]
    public class DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_security_policy_report_database_view_access_entries oci_data_safe_security_policy_report_database_view_access_entries} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries(Constructs.Construct scope, string id, oci.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.IDataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.IDataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_security_policy_report_database_view_access_entries#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.IDataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.IDataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.IDataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
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

        [JsiiMethod(name: "resetScimQuery")]
        public virtual void ResetScimQuery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetId")]
        public virtual void ResetTargetId()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries))!;

        [JsiiProperty(name: "databaseViewAccessEntryCollection", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesDatabaseViewAccessEntryCollectionList\"}")]
        public virtual oci.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesDatabaseViewAccessEntryCollectionList DatabaseViewAccessEntryCollection
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesDatabaseViewAccessEntryCollectionList>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesFilterList\"}")]
        public virtual oci.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesFilterList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntries.DataOciDataSafeSecurityPolicyReportDatabaseViewAccessEntriesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "scimQueryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScimQueryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityPolicyReportIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityPolicyReportIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scimQuery", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScimQuery
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityPolicyReportId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityPolicyReportId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
