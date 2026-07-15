using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LustreFileStorageLustreFileSystem
{
    [JsiiInterface(nativeType: typeof(ILustreFileStorageLustreFileSystemDateTimeDetails), fullyQualifiedName: "oci.lustreFileStorageLustreFileSystem.LustreFileStorageLustreFileSystemDateTimeDetails")]
    public interface ILustreFileStorageLustreFileSystemDateTimeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/lustre_file_storage_lustre_file_system#date LustreFileStorageLustreFileSystem#date}.</summary>
        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}")]
        string Date
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/lustre_file_storage_lustre_file_system#time LustreFileStorageLustreFileSystem#time}.</summary>
        [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}")]
        string Time
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILustreFileStorageLustreFileSystemDateTimeDetails), fullyQualifiedName: "oci.lustreFileStorageLustreFileSystem.LustreFileStorageLustreFileSystemDateTimeDetails")]
        internal sealed class _Proxy : DeputyBase, oci.LustreFileStorageLustreFileSystem.ILustreFileStorageLustreFileSystemDateTimeDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/lustre_file_storage_lustre_file_system#date LustreFileStorageLustreFileSystem#date}.</summary>
            [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}")]
            public string Date
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/lustre_file_storage_lustre_file_system#time LustreFileStorageLustreFileSystem#time}.</summary>
            [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}")]
            public string Time
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
