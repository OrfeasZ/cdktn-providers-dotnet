using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOpenzfsFileSystem
{
    [JsiiInterface(nativeType: typeof(IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports), fullyQualifiedName: "aws.fsxOpenzfsFileSystem.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExports")]
    public interface IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports
    {
        /// <summary>client_configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/fsx_openzfs_file_system#client_configurations FsxOpenzfsFileSystem#client_configurations}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.FsxOpenzfsFileSystem.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "clientConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxOpenzfsFileSystem.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations\"},\"kind\":\"array\"}}]}}")]
        object ClientConfigurations
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports), fullyQualifiedName: "aws.fsxOpenzfsFileSystem.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExports")]
        internal sealed class _Proxy : DeputyBase, aws.FsxOpenzfsFileSystem.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>client_configurations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/fsx_openzfs_file_system#client_configurations FsxOpenzfsFileSystem#client_configurations}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.FsxOpenzfsFileSystem.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "clientConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxOpenzfsFileSystem.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations\"},\"kind\":\"array\"}}]}}")]
            public object ClientConfigurations
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
