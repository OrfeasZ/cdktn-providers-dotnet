using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLogAnalyticsNamespaceLookup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/log_analytics_namespace_lookup oci_log_analytics_namespace_lookup}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciLogAnalyticsNamespaceLookup.DataOciLogAnalyticsNamespaceLookup), fullyQualifiedName: "oci.dataOciLogAnalyticsNamespaceLookup.DataOciLogAnalyticsNamespaceLookup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciLogAnalyticsNamespaceLookup.DataOciLogAnalyticsNamespaceLookupConfig\"}}]")]
    public class DataOciLogAnalyticsNamespaceLookup : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/log_analytics_namespace_lookup oci_log_analytics_namespace_lookup} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciLogAnalyticsNamespaceLookup(Constructs.Construct scope, string id, oci.DataOciLogAnalyticsNamespaceLookup.IDataOciLogAnalyticsNamespaceLookupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciLogAnalyticsNamespaceLookup.IDataOciLogAnalyticsNamespaceLookupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLogAnalyticsNamespaceLookup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLogAnalyticsNamespaceLookup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciLogAnalyticsNamespaceLookup resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciLogAnalyticsNamespaceLookup to import.</param>
        /// <param name="importFromId">The id of the existing DataOciLogAnalyticsNamespaceLookup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciLogAnalyticsNamespaceLookup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciLogAnalyticsNamespaceLookup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/log_analytics_namespace_lookup#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciLogAnalyticsNamespaceLookup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciLogAnalyticsNamespaceLookup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciLogAnalyticsNamespaceLookup.DataOciLogAnalyticsNamespaceLookup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciLogAnalyticsNamespaceLookup.DataOciLogAnalyticsNamespaceLookup))!;

        [JsiiProperty(name: "activeEditVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActiveEditVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "canonicalLink", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CanonicalLink
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "categories", typeJson: "{\"fqn\":\"oci.dataOciLogAnalyticsNamespaceLookup.DataOciLogAnalyticsNamespaceLookupCategoriesList\"}")]
        public virtual oci.DataOciLogAnalyticsNamespaceLookup.DataOciLogAnalyticsNamespaceLookupCategoriesList Categories
        {
            get => GetInstanceProperty<oci.DataOciLogAnalyticsNamespaceLookup.DataOciLogAnalyticsNamespaceLookupCategoriesList>()!;
        }

        [JsiiProperty(name: "charEncoding", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CharEncoding
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultMatchValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultMatchValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "editVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EditVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fields", typeJson: "{\"fqn\":\"oci.dataOciLogAnalyticsNamespaceLookup.DataOciLogAnalyticsNamespaceLookupFieldsList\"}")]
        public virtual oci.DataOciLogAnalyticsNamespaceLookup.DataOciLogAnalyticsNamespaceLookupFieldsList Fields
        {
            get => GetInstanceProperty<oci.DataOciLogAnalyticsNamespaceLookup.DataOciLogAnalyticsNamespaceLookupFieldsList>()!;
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

        [JsiiProperty(name: "isBuiltIn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IsBuiltIn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isHidden", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHidden
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lookupDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LookupDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lookupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LookupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lookupReference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LookupReference
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lookupReferenceString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LookupReferenceString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxMatches", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxMatches
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "referringSources", typeJson: "{\"fqn\":\"oci.dataOciLogAnalyticsNamespaceLookup.DataOciLogAnalyticsNamespaceLookupReferringSourcesList\"}")]
        public virtual oci.DataOciLogAnalyticsNamespaceLookup.DataOciLogAnalyticsNamespaceLookupReferringSourcesList ReferringSources
        {
            get => GetInstanceProperty<oci.DataOciLogAnalyticsNamespaceLookup.DataOciLogAnalyticsNamespaceLookupReferringSourcesList>()!;
        }

        [JsiiProperty(name: "registerLookupFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegisterLookupFile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusSummary", typeJson: "{\"fqn\":\"oci.dataOciLogAnalyticsNamespaceLookup.DataOciLogAnalyticsNamespaceLookupStatusSummaryList\"}")]
        public virtual oci.DataOciLogAnalyticsNamespaceLookup.DataOciLogAnalyticsNamespaceLookupStatusSummaryList StatusSummary
        {
            get => GetInstanceProperty<oci.DataOciLogAnalyticsNamespaceLookup.DataOciLogAnalyticsNamespaceLookupStatusSummaryList>()!;
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

        [JsiiOptional]
        [JsiiProperty(name: "lookupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LookupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "lookupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LookupName
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
