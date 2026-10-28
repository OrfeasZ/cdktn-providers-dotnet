using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsagentAsset
{
    [JsiiInterface(nativeType: typeof(IDevopsagentAssetContentZip), fullyQualifiedName: "aws.devopsagentAsset.DevopsagentAssetContentZip")]
    public interface IDevopsagentAssetContentZip
    {
        /// <summary>Base64-encoded ZIP archive. Use filebase64() to load a local ZIP file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#zip_file DevopsagentAsset#zip_file}
        /// </remarks>
        [JsiiProperty(name: "zipFile", typeJson: "{\"primitive\":\"string\"}")]
        string ZipFile
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsagentAssetContentZip), fullyQualifiedName: "aws.devopsagentAsset.DevopsagentAssetContentZip")]
        internal sealed class _Proxy : DeputyBase, aws.DevopsagentAsset.IDevopsagentAssetContentZip
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Base64-encoded ZIP archive. Use filebase64() to load a local ZIP file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#zip_file DevopsagentAsset#zip_file}
            /// </remarks>
            [JsiiProperty(name: "zipFile", typeJson: "{\"primitive\":\"string\"}")]
            public string ZipFile
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
