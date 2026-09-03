using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreBrowser
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreBrowserCertificateLocation), fullyQualifiedName: "aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserCertificateLocation")]
    public interface IBedrockagentcoreBrowserCertificateLocation
    {
        /// <summary>secrets_manager block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_browser#secrets_manager BedrockagentcoreBrowser#secrets_manager}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserCertificateLocationSecretsManager" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "secretsManager", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserCertificateLocationSecretsManager\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecretsManager
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreBrowserCertificateLocation), fullyQualifiedName: "aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserCertificateLocation")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserCertificateLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>secrets_manager block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_browser#secrets_manager BedrockagentcoreBrowser#secrets_manager}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserCertificateLocationSecretsManager" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretsManager", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserCertificateLocationSecretsManager\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SecretsManager
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
