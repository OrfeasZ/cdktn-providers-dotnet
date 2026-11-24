using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementNamedValue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementNamedValue.ApiManagementNamedValueValueFromKeyVault")]
    public class ApiManagementNamedValueValueFromKeyVault : azurerm.ApiManagementNamedValue.IApiManagementNamedValueValueFromKeyVault
    {
        /// <summary>The resource ID of the Key Vault Secret.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_named_value#secret_id ApiManagementNamedValue#secret_id}
        /// </remarks>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretId
        {
            get;
            set;
        }

        /// <summary>The client ID of User Assigned Identity, for the API Management Service, which will be used to access the Key Vault Secret.</summary>
        /// <remarks>
        /// The System Assigned Identity will be used in absence.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_named_value#identity_client_id ApiManagementNamedValue#identity_client_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentityClientId
        {
            get;
            set;
        }
    }
}
