using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LustreFileStorageLustreFileSystem
{
    [JsiiInterface(nativeType: typeof(ILustreFileStorageLustreFileSystemTimeouts), fullyQualifiedName: "oci.lustreFileStorageLustreFileSystem.LustreFileStorageLustreFileSystemTimeouts")]
    public interface ILustreFileStorageLustreFileSystemTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/lustre_file_storage_lustre_file_system#create LustreFileStorageLustreFileSystem#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/lustre_file_storage_lustre_file_system#delete LustreFileStorageLustreFileSystem#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/lustre_file_storage_lustre_file_system#update LustreFileStorageLustreFileSystem#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILustreFileStorageLustreFileSystemTimeouts), fullyQualifiedName: "oci.lustreFileStorageLustreFileSystem.LustreFileStorageLustreFileSystemTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.LustreFileStorageLustreFileSystem.ILustreFileStorageLustreFileSystemTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/lustre_file_storage_lustre_file_system#create LustreFileStorageLustreFileSystem#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/lustre_file_storage_lustre_file_system#delete LustreFileStorageLustreFileSystem#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/lustre_file_storage_lustre_file_system#update LustreFileStorageLustreFileSystem#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
