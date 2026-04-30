using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOpenzfsFileSystem
{
    [JsiiInterface(nativeType: typeof(IFsxOpenzfsFileSystemReadCacheConfiguration), fullyQualifiedName: "aws.fsxOpenzfsFileSystem.FsxOpenzfsFileSystemReadCacheConfiguration")]
    public interface IFsxOpenzfsFileSystemReadCacheConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/fsx_openzfs_file_system#size FsxOpenzfsFileSystem#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Size
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/fsx_openzfs_file_system#sizing_mode FsxOpenzfsFileSystem#sizing_mode}.</summary>
        [JsiiProperty(name: "sizingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SizingMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxOpenzfsFileSystemReadCacheConfiguration), fullyQualifiedName: "aws.fsxOpenzfsFileSystem.FsxOpenzfsFileSystemReadCacheConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.FsxOpenzfsFileSystem.IFsxOpenzfsFileSystemReadCacheConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/fsx_openzfs_file_system#size FsxOpenzfsFileSystem#size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Size
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/fsx_openzfs_file_system#sizing_mode FsxOpenzfsFileSystem#sizing_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sizingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SizingMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
