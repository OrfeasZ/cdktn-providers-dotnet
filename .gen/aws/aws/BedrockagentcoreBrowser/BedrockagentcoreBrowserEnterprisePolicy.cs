using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreBrowser
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserEnterprisePolicy")]
    public class BedrockagentcoreBrowserEnterprisePolicy : aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserEnterprisePolicy
    {
        private object? _location;

        /// <summary>location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.53.0/docs/resources/bedrockagentcore_browser#location BedrockagentcoreBrowser#location}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserEnterprisePolicyLocation" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "location", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserEnterprisePolicyLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserEnterprisePolicyLocation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserEnterprisePolicyLocation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _location = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.53.0/docs/resources/bedrockagentcore_browser#type BedrockagentcoreBrowser#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
