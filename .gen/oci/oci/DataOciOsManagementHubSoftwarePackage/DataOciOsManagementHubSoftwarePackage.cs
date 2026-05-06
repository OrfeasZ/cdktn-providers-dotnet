using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsManagementHubSoftwarePackage
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_software_package oci_os_management_hub_software_package}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOsManagementHubSoftwarePackage.DataOciOsManagementHubSoftwarePackage), fullyQualifiedName: "oci.dataOciOsManagementHubSoftwarePackage.DataOciOsManagementHubSoftwarePackage", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOsManagementHubSoftwarePackage.DataOciOsManagementHubSoftwarePackageConfig\"}}]")]
    public class DataOciOsManagementHubSoftwarePackage : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_software_package oci_os_management_hub_software_package} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOsManagementHubSoftwarePackage(Constructs.Construct scope, string id, oci.DataOciOsManagementHubSoftwarePackage.IDataOciOsManagementHubSoftwarePackageConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOsManagementHubSoftwarePackage.IDataOciOsManagementHubSoftwarePackageConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubSoftwarePackage(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubSoftwarePackage(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOsManagementHubSoftwarePackage resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOsManagementHubSoftwarePackage to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOsManagementHubSoftwarePackage that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOsManagementHubSoftwarePackage to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOsManagementHubSoftwarePackage to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_software_package#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOsManagementHubSoftwarePackage that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOsManagementHubSoftwarePackage to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOsManagementHubSoftwarePackage.DataOciOsManagementHubSoftwarePackage), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciOsManagementHubSoftwarePackage.DataOciOsManagementHubSoftwarePackage))!;

        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Architecture
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "checksum", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Checksum
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "checksumType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChecksumType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dependencies", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubSoftwarePackage.DataOciOsManagementHubSoftwarePackageDependenciesList\"}")]
        public virtual oci.DataOciOsManagementHubSoftwarePackage.DataOciOsManagementHubSoftwarePackageDependenciesList Dependencies
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubSoftwarePackage.DataOciOsManagementHubSoftwarePackageDependenciesList>()!;
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

        [JsiiProperty(name: "files", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubSoftwarePackage.DataOciOsManagementHubSoftwarePackageFilesList\"}")]
        public virtual oci.DataOciOsManagementHubSoftwarePackage.DataOciOsManagementHubSoftwarePackageFilesList Files
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubSoftwarePackage.DataOciOsManagementHubSoftwarePackageFilesList>()!;
        }

        [JsiiProperty(name: "isLatest", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLatest
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lastModifiedDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModifiedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osFamilies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OsFamilies
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sizeInBytes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SizeInBytes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "softwareSources", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubSoftwarePackage.DataOciOsManagementHubSoftwarePackageSoftwareSourcesList\"}")]
        public virtual oci.DataOciOsManagementHubSoftwarePackage.DataOciOsManagementHubSoftwarePackageSoftwareSourcesList SoftwareSources
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubSoftwarePackage.DataOciOsManagementHubSoftwarePackageSoftwareSourcesList>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "softwarePackageNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SoftwarePackageNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "softwarePackageName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftwarePackageName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
