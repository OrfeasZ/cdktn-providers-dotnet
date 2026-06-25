using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "canAllowViewState", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CanAllowViewState
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "groupings", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentGroupingsList\"}")]
        public virtual oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentGroupingsList Groupings
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentGroupingsList>()!;
        }

        [JsiiProperty(name: "informationalText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InformationalText
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instructions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Instructions
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Locale
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logoUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outputGroups", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentOutputGroupsList\"}")]
        public virtual oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentOutputGroupsList OutputGroups
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentOutputGroupsList>()!;
        }

        [JsiiProperty(name: "outputs", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentOutputsList\"}")]
        public virtual oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentOutputsList Outputs
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentOutputsList>()!;
        }

        [JsiiProperty(name: "packageVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryOutputButton", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryOutputButton
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchemaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentSourceList\"}")]
        public virtual oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentSourceList Source
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentSourceList>()!;
        }

        [JsiiProperty(name: "stackDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StackDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Title
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "troubleshooting", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Troubleshooting
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "variableGroups", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentVariableGroupsList\"}")]
        public virtual oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentVariableGroupsList VariableGroups
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocumentVariableGroupsList>()!;
        }

        [JsiiProperty(name: "variables", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Variables
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementCatalogItemVariablesDefinition.DataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocument\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.IDataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocument? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementCatalogItemVariablesDefinition.IDataOciFleetAppsManagementCatalogItemVariablesDefinitionSchemaDocument?>();
            set => SetInstanceProperty(value);
        }
    }
}
