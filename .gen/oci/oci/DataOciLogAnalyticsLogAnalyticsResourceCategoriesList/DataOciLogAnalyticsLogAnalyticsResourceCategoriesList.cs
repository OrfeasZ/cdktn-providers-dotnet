using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLogAnalyticsLogAnalyticsResourceCategoriesList
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/log_analytics_log_analytics_resource_categories_list oci_log_analytics_log_analytics_resource_categories_list}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciLogAnalyticsLogAnalyticsResourceCategoriesList.DataOciLogAnalyticsLogAnalyticsResourceCategoriesList), fullyQualifiedName: "oci.dataOciLogAnalyticsLogAnalyticsResourceCategoriesList.DataOciLogAnalyticsLogAnalyticsResourceCategoriesList", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciLogAnalyticsLogAnalyticsResourceCategoriesList.DataOciLogAnalyticsLogAnalyticsResourceCategoriesListConfig\"}}]")]
    public class DataOciLogAnalyticsLogAnalyticsResourceCategoriesList : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/log_analytics_log_analytics_resource_categories_list oci_log_analytics_log_analytics_resource_categories_list} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciLogAnalyticsLogAnalyticsResourceCategoriesList(Constructs.Construct scope, string id, oci.DataOciLogAnalyticsLogAnalyticsResourceCategoriesList.IDataOciLogAnalyticsLogAnalyticsResourceCategoriesListConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciLogAnalyticsLogAnalyticsResourceCategoriesList.IDataOciLogAnalyticsLogAnalyticsResourceCategoriesListConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLogAnalyticsLogAnalyticsResourceCategoriesList(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLogAnalyticsLogAnalyticsResourceCategoriesList(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciLogAnalyticsLogAnalyticsResourceCategoriesList resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciLogAnalyticsLogAnalyticsResourceCategoriesList to import.</param>
        /// <param name="importFromId">The id of the existing DataOciLogAnalyticsLogAnalyticsResourceCategoriesList that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciLogAnalyticsLogAnalyticsResourceCategoriesList to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciLogAnalyticsLogAnalyticsResourceCategoriesList to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/log_analytics_log_analytics_resource_categories_list#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciLogAnalyticsLogAnalyticsResourceCategoriesList that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciLogAnalyticsLogAnalyticsResourceCategoriesList to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciLogAnalyticsLogAnalyticsResourceCategoriesList.DataOciLogAnalyticsLogAnalyticsResourceCategoriesList), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceCategories")]
        public virtual void ResetResourceCategories()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceIds")]
        public virtual void ResetResourceIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceTypes")]
        public virtual void ResetResourceTypes()
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
        = GetStaticProperty<string>(typeof(oci.DataOciLogAnalyticsLogAnalyticsResourceCategoriesList.DataOciLogAnalyticsLogAnalyticsResourceCategoriesList))!;

        [JsiiProperty(name: "categories", typeJson: "{\"fqn\":\"oci.dataOciLogAnalyticsLogAnalyticsResourceCategoriesList.DataOciLogAnalyticsLogAnalyticsResourceCategoriesListCategoriesList\"}")]
        public virtual oci.DataOciLogAnalyticsLogAnalyticsResourceCategoriesList.DataOciLogAnalyticsLogAnalyticsResourceCategoriesListCategoriesList Categories
        {
            get => GetInstanceProperty<oci.DataOciLogAnalyticsLogAnalyticsResourceCategoriesList.DataOciLogAnalyticsLogAnalyticsResourceCategoriesListCategoriesList>()!;
        }

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.dataOciLogAnalyticsLogAnalyticsResourceCategoriesList.DataOciLogAnalyticsLogAnalyticsResourceCategoriesListItemsList\"}")]
        public virtual oci.DataOciLogAnalyticsLogAnalyticsResourceCategoriesList.DataOciLogAnalyticsLogAnalyticsResourceCategoriesListItemsList Items
        {
            get => GetInstanceProperty<oci.DataOciLogAnalyticsLogAnalyticsResourceCategoriesList.DataOciLogAnalyticsLogAnalyticsResourceCategoriesListItemsList>()!;
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

        [JsiiOptional]
        [JsiiProperty(name: "namespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceCategoriesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceCategoriesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceIdsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceIdsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceTypesInput
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

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceCategories", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceCategories
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceIds", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceIds
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceTypes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
