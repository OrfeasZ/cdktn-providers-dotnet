using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApiOperation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementApiOperation.ApiManagementApiOperationResponseRepresentationExample")]
    public class ApiManagementApiOperationResponseRepresentationExample : azurerm.ApiManagementApiOperation.IApiManagementApiOperationResponseRepresentationExample
    {
        /// <summary>The name of this example.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_operation#name ApiManagementApiOperation#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>A long description for this example.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_operation#description ApiManagementApiOperation#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>A URL that points to the literal example.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_operation#external_value ApiManagementApiOperation#external_value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "externalValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExternalValue
        {
            get;
            set;
        }

        /// <summary>A short description for this example.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_operation#summary ApiManagementApiOperation#summary}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "summary", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Summary
        {
            get;
            set;
        }

        /// <summary>The example of the representation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_operation#value ApiManagementApiOperation#value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
