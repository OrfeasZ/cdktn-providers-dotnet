using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciManagementDashboardManagementSavedSearch
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/data-sources/management_dashboard_management_saved_search oci_management_dashboard_management_saved_search}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciManagementDashboardManagementSavedSearch.DataOciManagementDashboardManagementSavedSearch), fullyQualifiedName: "oci.dataOciManagementDashboardManagementSavedSearch.DataOciManagementDashboardManagementSavedSearch", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciManagementDashboardManagementSavedSearch.DataOciManagementDashboardManagementSavedSearchConfig\"}}]")]
    public class DataOciManagementDashboardManagementSavedSearch : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/data-sources/management_dashboard_management_saved_search oci_management_dashboard_management_saved_search} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciManagementDashboardManagementSavedSearch(Constructs.Construct scope, string id, oci.DataOciManagementDashboardManagementSavedSearch.IDataOciManagementDashboardManagementSavedSearchConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciManagementDashboardManagementSavedSearch.IDataOciManagementDashboardManagementSavedSearchConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciManagementDashboardManagementSavedSearch(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciManagementDashboardManagementSavedSearch(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciManagementDashboardManagementSavedSearch resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciManagementDashboardManagementSavedSearch to import.</param>
        /// <param name="importFromId">The id of the existing DataOciManagementDashboardManagementSavedSearch that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciManagementDashboardManagementSavedSearch to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciManagementDashboardManagementSavedSearch to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/data-sources/management_dashboard_management_saved_search#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciManagementDashboardManagementSavedSearch that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciManagementDashboardManagementSavedSearch to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciManagementDashboardManagementSavedSearch.DataOciManagementDashboardManagementSavedSearch), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciManagementDashboardManagementSavedSearch.DataOciManagementDashboardManagementSavedSearch))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataConfig
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

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "drilldownConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DrilldownConfig
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMapMap\"}")]
        public virtual Io.Cdktn.StringMapMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMapMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isOobSavedSearch", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsOobSavedSearch
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "metadataVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetadataVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nls", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Nls
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parametersConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParametersConfig
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "providerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProviderId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "providerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProviderName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "providerVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProviderVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "screenImage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScreenImage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uiConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UiConfig
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "widgetTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WidgetTemplate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "widgetVm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WidgetVm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "managementSavedSearchIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagementSavedSearchIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "managementSavedSearchId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementSavedSearchId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
