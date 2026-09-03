using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSourceControl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfigurationContainerConfiguration")]
    public class AppServiceSourceControlGithubActionConfigurationContainerConfiguration : azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfigurationContainerConfiguration
    {
        /// <summary>The image name for the build.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/app_service_source_control#image_name AppServiceSourceControl#image_name}
        /// </remarks>
        [JsiiProperty(name: "imageName", typeJson: "{\"primitive\":\"string\"}")]
        public string ImageName
        {
            get;
            set;
        }

        /// <summary>The server URL for the container registry where the build will be hosted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/app_service_source_control#registry_url AppServiceSourceControl#registry_url}
        /// </remarks>
        [JsiiProperty(name: "registryUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string RegistryUrl
        {
            get;
            set;
        }

        /// <summary>The password used to upload the image to the container registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/app_service_source_control#registry_password AppServiceSourceControl#registry_password}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registryPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegistryPassword
        {
            get;
            set;
        }

        /// <summary>The username used to upload the image to the container registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/app_service_source_control#registry_username AppServiceSourceControl#registry_username}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registryUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegistryUsername
        {
            get;
            set;
        }
    }
}
