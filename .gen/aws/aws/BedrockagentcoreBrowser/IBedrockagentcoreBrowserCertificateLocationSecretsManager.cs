using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreBrowser
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreBrowserCertificateLocationSecretsManager), fullyQualifiedName: "aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserCertificateLocationSecretsManager")]
    public interface IBedrockagentcoreBrowserCertificateLocationSecretsManager
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_browser#secret_arn BedrockagentcoreBrowser#secret_arn}.</summary>
        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}")]
        string SecretArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreBrowserCertificateLocationSecretsManager), fullyQualifiedName: "aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserCertificateLocationSecretsManager")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserCertificateLocationSecretsManager
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_browser#secret_arn BedrockagentcoreBrowser#secret_arn}.</summary>
            [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
