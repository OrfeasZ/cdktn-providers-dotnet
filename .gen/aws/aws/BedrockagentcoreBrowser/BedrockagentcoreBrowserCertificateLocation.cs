using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreBrowser
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserCertificateLocation")]
    public class BedrockagentcoreBrowserCertificateLocation : aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserCertificateLocation
    {
        private object? _secretsManager;

        /// <summary>secrets_manager block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_browser#secrets_manager BedrockagentcoreBrowser#secrets_manager}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserCertificateLocationSecretsManager" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretsManager", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserCertificateLocationSecretsManager\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SecretsManager
        {
            get => _secretsManager;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserCertificateLocationSecretsManager[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserCertificateLocationSecretsManager).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secretsManager = value;
            }
        }
    }
}
