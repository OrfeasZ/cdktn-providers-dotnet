using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementProvision
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_provision oci_fleet_apps_management_provision}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementProvision.DataOciFleetAppsManagementProvision), fullyQualifiedName: "oci.dataOciFleetAppsManagementProvision.DataOciFleetAppsManagementProvision", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciFleetAppsManagementProvision.DataOciFleetAppsManagementProvisionConfig\"}}]")]
    public class DataOciFleetAppsManagementProvision : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_provision oci_fleet_apps_management_provision} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciFleetAppsManagementProvision(Constructs.Construct scope, string id, oci.DataOciFleetAppsManagementProvision.IDataOciFleetAppsManagementProvisionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciFleetAppsManagementProvision.IDataOciFleetAppsManagementProvisionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementProvision(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementProvision(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciFleetAppsManagementProvision resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciFleetAppsManagementProvision to import.</param>
        /// <param name="importFromId">The id of the existing DataOciFleetAppsManagementProvision that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciFleetAppsManagementProvision to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciFleetAppsManagementProvision to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_provision#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciFleetAppsManagementProvision that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciFleetAppsManagementProvision to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciFleetAppsManagementProvision.DataOciFleetAppsManagementProvision), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciFleetAppsManagementProvision.DataOciFleetAppsManagementProvision))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configCatalogItemDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigCatalogItemDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configCatalogItemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigCatalogItemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configCatalogItemListingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigCatalogItemListingId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configCatalogItemListingVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigCatalogItemListingVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "deployedResources", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementProvision.DataOciFleetAppsManagementProvisionDeployedResourcesList\"}")]
        public virtual oci.DataOciFleetAppsManagementProvision.DataOciFleetAppsManagementProvisionDeployedResourcesList DeployedResources
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementProvision.DataOciFleetAppsManagementProvisionDeployedResourcesList>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FleetId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageCatalogItemDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageCatalogItemDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageCatalogItemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageCatalogItemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageCatalogItemListingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageCatalogItemListingId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageCatalogItemListingVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageCatalogItemListingVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provisionDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvisionDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rmsApplyJobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RmsApplyJobId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StackId
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

        [JsiiProperty(name: "tfOutputs", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementProvision.DataOciFleetAppsManagementProvisionTfOutputsList\"}")]
        public virtual oci.DataOciFleetAppsManagementProvision.DataOciFleetAppsManagementProvisionTfOutputsList TfOutputs
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementProvision.DataOciFleetAppsManagementProvisionTfOutputsList>()!;
        }

        [JsiiProperty(name: "tfVariableCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TfVariableCompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tfVariableCurrentUserId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TfVariableCurrentUserId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tfVariableRegionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TfVariableRegionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tfVariableTenancyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TfVariableTenancyId
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
        [JsiiProperty(name: "provisionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProvisionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "provisionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvisionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
