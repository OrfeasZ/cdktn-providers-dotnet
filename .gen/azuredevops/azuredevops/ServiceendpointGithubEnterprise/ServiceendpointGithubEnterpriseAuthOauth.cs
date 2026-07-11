using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointGithubEnterprise
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointGithubEnterprise.ServiceendpointGithubEnterpriseAuthOauth")]
    public class ServiceendpointGithubEnterpriseAuthOauth : azuredevops.ServiceendpointGithubEnterprise.IServiceendpointGithubEnterpriseAuthOauth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_github_enterprise#oauth_configuration_id ServiceendpointGithubEnterprise#oauth_configuration_id}.</summary>
        [JsiiProperty(name: "oauthConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        public string OauthConfigurationId
        {
            get;
            set;
        }
    }
}
