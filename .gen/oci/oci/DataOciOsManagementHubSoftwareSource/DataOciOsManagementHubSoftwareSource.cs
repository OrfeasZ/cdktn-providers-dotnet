using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsManagementHubSoftwareSource
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_software_source oci_os_management_hub_software_source}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOsManagementHubSoftwareSource.DataOciOsManagementHubSoftwareSource), fullyQualifiedName: "oci.dataOciOsManagementHubSoftwareSource.DataOciOsManagementHubSoftwareSource", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOsManagementHubSoftwareSource.DataOciOsManagementHubSoftwareSourceConfig\"}}]")]
    public class DataOciOsManagementHubSoftwareSource : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_software_source oci_os_management_hub_software_source} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOsManagementHubSoftwareSource(Constructs.Construct scope, string id, oci.DataOciOsManagementHubSoftwareSource.IDataOciOsManagementHubSoftwareSourceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOsManagementHubSoftwareSource.IDataOciOsManagementHubSoftwareSourceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubSoftwareSource(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubSoftwareSource(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOsManagementHubSoftwareSource resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOsManagementHubSoftwareSource to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOsManagementHubSoftwareSource that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOsManagementHubSoftwareSource to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOsManagementHubSoftwareSource to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_software_source#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOsManagementHubSoftwareSource that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOsManagementHubSoftwareSource to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOsManagementHubSoftwareSource.DataOciOsManagementHubSoftwareSource), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciOsManagementHubSoftwareSource.DataOciOsManagementHubSoftwareSource))!;

        [JsiiProperty(name: "advancedRepoOptions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdvancedRepoOptions
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "archType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArchType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availability", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Availability
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityAtOci", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityAtOci
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "checksumType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChecksumType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customSoftwareSourceFilter", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubSoftwareSource.DataOciOsManagementHubSoftwareSourceCustomSoftwareSourceFilterList\"}")]
        public virtual oci.DataOciOsManagementHubSoftwareSource.DataOciOsManagementHubSoftwareSourceCustomSoftwareSourceFilterList CustomSoftwareSourceFilter
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubSoftwareSource.DataOciOsManagementHubSoftwareSourceCustomSoftwareSourceFilterList>()!;
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

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "gpgKeyFingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GpgKeyFingerprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gpgKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GpgKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gpgKeyUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GpgKeyUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAutomaticallyUpdated", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutomaticallyUpdated
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isAutoResolveDependencies", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoResolveDependencies
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isCreatedFromPackageList", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCreatedFromPackageList
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isGpgCheckEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsGpgCheckEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isLatestContentOnly", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLatestContentOnly
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isMandatoryForAutonomousLinux", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMandatoryForAutonomousLinux
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isMirrorSyncAllowed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMirrorSyncAllowed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSslVerifyEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSslVerifyEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "originSoftwareSourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginSoftwareSourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsFamily
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageCount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Packages
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "repoId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepoId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Size
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "softwareSourceSubType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftwareSourceSubType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "softwareSourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftwareSourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "softwareSourceVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftwareSourceVersion
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

        [JsiiProperty(name: "timeMetadataUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMetadataUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vendorName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VendorName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vendorSoftwareSources", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubSoftwareSource.DataOciOsManagementHubSoftwareSourceVendorSoftwareSourcesList\"}")]
        public virtual oci.DataOciOsManagementHubSoftwareSource.DataOciOsManagementHubSoftwareSourceVendorSoftwareSourcesList VendorSoftwareSources
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubSoftwareSource.DataOciOsManagementHubSoftwareSourceVendorSoftwareSourcesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "softwareSourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SoftwareSourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "softwareSourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftwareSourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
