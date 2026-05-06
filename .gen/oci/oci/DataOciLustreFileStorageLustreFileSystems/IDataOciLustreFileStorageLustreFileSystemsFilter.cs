using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLustreFileStorageLustreFileSystems
{
    [JsiiInterface(nativeType: typeof(IDataOciLustreFileStorageLustreFileSystemsFilter), fullyQualifiedName: "oci.dataOciLustreFileStorageLustreFileSystems.DataOciLustreFileStorageLustreFileSystemsFilter")]
    public interface IDataOciLustreFileStorageLustreFileSystemsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/lustre_file_storage_lustre_file_systems#name DataOciLustreFileStorageLustreFileSystems#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/lustre_file_storage_lustre_file_systems#values DataOciLustreFileStorageLustreFileSystems#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/lustre_file_storage_lustre_file_systems#regex DataOciLustreFileStorageLustreFileSystems#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciLustreFileStorageLustreFileSystemsFilter), fullyQualifiedName: "oci.dataOciLustreFileStorageLustreFileSystems.DataOciLustreFileStorageLustreFileSystemsFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciLustreFileStorageLustreFileSystems.IDataOciLustreFileStorageLustreFileSystemsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/lustre_file_storage_lustre_file_systems#name DataOciLustreFileStorageLustreFileSystems#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/lustre_file_storage_lustre_file_systems#values DataOciLustreFileStorageLustreFileSystems#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/lustre_file_storage_lustre_file_systems#regex DataOciLustreFileStorageLustreFileSystems#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
