using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreBrowser
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserNetworkConfiguration")]
    public class BedrockagentcoreBrowserNetworkConfiguration : aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserNetworkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_browser#network_mode BedrockagentcoreBrowser#network_mode}.</summary>
        [JsiiProperty(name: "networkMode", typeJson: "{\"primitive\":\"string\"}")]
        public string NetworkMode
        {
            get;
            set;
        }

        private object? _vpcConfig;

        /// <summary>vpc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_browser#vpc_config BedrockagentcoreBrowser#vpc_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserNetworkConfigurationVpcConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VpcConfig
        {
            get => _vpcConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserNetworkConfigurationVpcConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserNetworkConfigurationVpcConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vpcConfig = value;
            }
        }
    }
}
