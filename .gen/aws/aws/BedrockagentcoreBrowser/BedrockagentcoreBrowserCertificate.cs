using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreBrowser
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserCertificate")]
    public class BedrockagentcoreBrowserCertificate : aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserCertificate
    {
        private object? _location;

        /// <summary>location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_browser#location BedrockagentcoreBrowser#location}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserCertificateLocation" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "location", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserCertificateLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Location
        {
            get => _location;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserCertificateLocation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserCertificateLocation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _location = value;
            }
        }
    }
}
