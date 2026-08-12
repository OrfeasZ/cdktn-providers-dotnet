using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_catalog_item_variables_definition oci_fleet_apps_management_catalog_item_variables_definition}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinition), fullyQualifiedName: "oci.dataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinition", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionConfig\"}}]")]
    public class DataOciFleetAppsManagementCatalogItemVariablesDefinition : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_catalog_item_variables_definition oci_fleet_apps_management_catalog_item_variables_definition} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciFleetAppsManagementCatalogItemVariablesDefinition(Constructs.Construct scope, string id, oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.IDataOciFleetAppsManagementCatalogItemVariablesDefinitionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.IDataOciFleetAppsManagementCatalogItemVariablesDefinitionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementCatalogItemVariablesDefinition(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementCatalogItemVariablesDefinition(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciFleetAppsManagementCatalogItemVariablesDefinition resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciFleetAppsManagementCatalogItemVariablesDefinition to import.</param>
        /// <param name="importFromId">The id of the existing DataOciFleetAppsManagementCatalogItemVariablesDefinition that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciFleetAppsManagementCatalogItemVariablesDefinition to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciFleetAppsManagementCatalogItemVariablesDefinition to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/fleet_apps_management_catalog_item_variables_definition#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciFleetAppsManagementCatalogItemVariablesDefinition that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciFleetAppsManagementCatalogItemVariablesDefinition to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinition), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinition))!;

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "schemaDocument", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentList\"}")]
        public virtual oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentList SchemaDocument
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentList>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogItemIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CatalogItemIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "catalogItemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CatalogItemId
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
