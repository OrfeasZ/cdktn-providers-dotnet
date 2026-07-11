using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointGithubEnterprise
{
    [JsiiInterface(nativeType: typeof(IServiceendpointGithubEnterpriseAuthOauth), fullyQualifiedName: "azuredevops.serviceendpointGithubEnterprise.ServiceendpointGithubEnterpriseAuthOauth")]
    public interface IServiceendpointGithubEnterpriseAuthOauth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_github_enterprise#oauth_configuration_id ServiceendpointGithubEnterprise#oauth_configuration_id}.</summary>
        [JsiiProperty(name: "oauthConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        string OauthConfigurationId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointGithubEnterpriseAuthOauth), fullyQualifiedName: "azuredevops.serviceendpointGithubEnterprise.ServiceendpointGithubEnterpriseAuthOauth")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointGithubEnterprise.IServiceendpointGithubEnterpriseAuthOauth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_github_enterprise#oauth_configuration_id ServiceendpointGithubEnterprise#oauth_configuration_id}.</summary>
            [JsiiProperty(name: "oauthConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
            public string OauthConfigurationId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
