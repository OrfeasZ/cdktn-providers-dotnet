using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreOauth2CredentialProvider
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpointSelfManagedLatticeResource")]
    public class BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpointSelfManagedLatticeResource : aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpointSelfManagedLatticeResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/bedrockagentcore_oauth2_credential_provider#resource_configuration_identifier BedrockagentcoreOauth2CredentialProvider#resource_configuration_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceConfigurationIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceConfigurationIdentifier
        {
            get;
            set;
        }
    }
}
