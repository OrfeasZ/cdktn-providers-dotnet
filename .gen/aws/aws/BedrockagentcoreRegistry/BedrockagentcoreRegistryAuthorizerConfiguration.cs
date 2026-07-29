using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreRegistry
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreRegistry.BedrockagentcoreRegistryAuthorizerConfiguration")]
    public class BedrockagentcoreRegistryAuthorizerConfiguration : aws.BedrockagentcoreRegistry.IBedrockagentcoreRegistryAuthorizerConfiguration
    {
        private object? _customJwtAuthorizer;

        /// <summary>custom_jwt_authorizer block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_registry#custom_jwt_authorizer BedrockagentcoreRegistry#custom_jwt_authorizer}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreRegistry.IBedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizer" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customJwtAuthorizer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreRegistry.BedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomJwtAuthorizer
        {
            get => _customJwtAuthorizer;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreRegistry.IBedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizer[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreRegistry.IBedrockagentcoreRegistryAuthorizerConfigurationCustomJwtAuthorizer).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customJwtAuthorizer = value;
            }
        }
    }
}
