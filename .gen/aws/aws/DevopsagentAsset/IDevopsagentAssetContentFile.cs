using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsagentAsset
{
    [JsiiInterface(nativeType: typeof(IDevopsagentAssetContentFile), fullyQualifiedName: "aws.devopsagentAsset.DevopsagentAssetContentFile")]
    public interface IDevopsagentAssetContentFile
    {
        /// <summary>Path of the file within the asset.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#path DevopsagentAsset#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>body block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#body DevopsagentAsset#body}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DevopsagentAsset.IDevopsagentAssetContentFileBody" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "body", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsagentAsset.DevopsagentAssetContentFileBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Body
        {
            get
            {
                return null;
            }
        }

        /// <summary>JSON metadata for the file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#metadata DevopsagentAsset#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Metadata
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsagentAssetContentFile), fullyQualifiedName: "aws.devopsagentAsset.DevopsagentAssetContentFile")]
        internal sealed class _Proxy : DeputyBase, aws.DevopsagentAsset.IDevopsagentAssetContentFile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Path of the file within the asset.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#path DevopsagentAsset#path}
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>body block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#body DevopsagentAsset#body}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DevopsagentAsset.IDevopsagentAssetContentFileBody" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsagentAsset.DevopsagentAssetContentFileBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Body
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>JSON metadata for the file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#metadata DevopsagentAsset#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Metadata
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
