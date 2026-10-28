using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsagentAsset
{
    [JsiiInterface(nativeType: typeof(IDevopsagentAssetContentSourceUrl), fullyQualifiedName: "aws.devopsagentAsset.DevopsagentAssetContentSourceUrl")]
    public interface IDevopsagentAssetContentSourceUrl
    {
        /// <summary>Source URL from which to import asset content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#url DevopsagentAsset#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        string Url
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsagentAssetContentSourceUrl), fullyQualifiedName: "aws.devopsagentAsset.DevopsagentAssetContentSourceUrl")]
        internal sealed class _Proxy : DeputyBase, aws.DevopsagentAsset.IDevopsagentAssetContentSourceUrl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Source URL from which to import asset content.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#url DevopsagentAsset#url}
            /// </remarks>
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
            public string Url
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
