using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsagentAsset
{
    [JsiiInterface(nativeType: typeof(IDevopsagentAssetContent), fullyQualifiedName: "aws.devopsagentAsset.DevopsagentAssetContent")]
    public interface IDevopsagentAssetContent
    {
        /// <summary>file block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#file DevopsagentAsset#file}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DevopsagentAsset.IDevopsagentAssetContentFile" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsagentAsset.DevopsagentAssetContentFile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? File
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_url block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#source_url DevopsagentAsset#source_url}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DevopsagentAsset.IDevopsagentAssetContentSourceUrl" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "sourceUrl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsagentAsset.DevopsagentAssetContentSourceUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SourceUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>zip block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#zip DevopsagentAsset#zip}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DevopsagentAsset.IDevopsagentAssetContentZip" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "zip", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsagentAsset.DevopsagentAssetContentZip\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Zip
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsagentAssetContent), fullyQualifiedName: "aws.devopsagentAsset.DevopsagentAssetContent")]
        internal sealed class _Proxy : DeputyBase, aws.DevopsagentAsset.IDevopsagentAssetContent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>file block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#file DevopsagentAsset#file}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DevopsagentAsset.IDevopsagentAssetContentFile" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "file", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsagentAsset.DevopsagentAssetContentFile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? File
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>source_url block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#source_url DevopsagentAsset#source_url}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DevopsagentAsset.IDevopsagentAssetContentSourceUrl" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceUrl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsagentAsset.DevopsagentAssetContentSourceUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SourceUrl
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>zip block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#zip DevopsagentAsset#zip}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DevopsagentAsset.IDevopsagentAssetContentZip" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zip", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsagentAsset.DevopsagentAssetContentZip\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Zip
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
