using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsagentAssetFile
{
    [JsiiInterface(nativeType: typeof(IDevopsagentAssetFileContent), fullyQualifiedName: "aws.devopsagentAssetFile.DevopsagentAssetFileContent")]
    public interface IDevopsagentAssetFileContent
    {
        /// <summary>Base64-encoded binary file content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/devopsagent_asset_file#bytes DevopsagentAssetFile#bytes}
        /// </remarks>
        [JsiiProperty(name: "bytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Text file content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/devopsagent_asset_file#text DevopsagentAssetFile#text}
        /// </remarks>
        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Text
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsagentAssetFileContent), fullyQualifiedName: "aws.devopsagentAssetFile.DevopsagentAssetFileContent")]
        internal sealed class _Proxy : DeputyBase, aws.DevopsagentAssetFile.IDevopsagentAssetFileContent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Base64-encoded binary file content.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/devopsagent_asset_file#bytes DevopsagentAssetFile#bytes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Bytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Text file content.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/devopsagent_asset_file#text DevopsagentAssetFile#text}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Text
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
