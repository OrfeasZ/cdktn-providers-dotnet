using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointVisualstudiomarketplace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointVisualstudiomarketplace.ServiceendpointVisualstudiomarketplaceAuthenticationBasic")]
    public class ServiceendpointVisualstudiomarketplaceAuthenticationBasic : azuredevops.ServiceendpointVisualstudiomarketplace.IServiceendpointVisualstudiomarketplaceAuthenticationBasic
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_visualstudiomarketplace#password ServiceendpointVisualstudiomarketplace#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_visualstudiomarketplace#username ServiceendpointVisualstudiomarketplace#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }
    }
}
