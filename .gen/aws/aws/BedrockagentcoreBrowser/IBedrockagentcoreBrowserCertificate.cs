using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreBrowser
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreBrowserCertificate), fullyQualifiedName: "aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserCertificate")]
    public interface IBedrockagentcoreBrowserCertificate
    {
        /// <summary>location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_browser#location BedrockagentcoreBrowser#location}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserCertificateLocation" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "location", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserCertificateLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Location
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreBrowserCertificate), fullyQualifiedName: "aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserCertificate")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_browser#location BedrockagentcoreBrowser#location}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserCertificateLocation" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "location", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserCertificateLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Location
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
