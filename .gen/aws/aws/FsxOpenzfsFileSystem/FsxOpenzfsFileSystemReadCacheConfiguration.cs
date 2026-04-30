using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOpenzfsFileSystem
{
    [JsiiByValue(fqn: "aws.fsxOpenzfsFileSystem.FsxOpenzfsFileSystemReadCacheConfiguration")]
    public class FsxOpenzfsFileSystemReadCacheConfiguration : aws.FsxOpenzfsFileSystem.IFsxOpenzfsFileSystemReadCacheConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/fsx_openzfs_file_system#size FsxOpenzfsFileSystem#size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Size
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/fsx_openzfs_file_system#sizing_mode FsxOpenzfsFileSystem#sizing_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sizingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SizingMode
        {
            get;
            set;
        }
    }
}
