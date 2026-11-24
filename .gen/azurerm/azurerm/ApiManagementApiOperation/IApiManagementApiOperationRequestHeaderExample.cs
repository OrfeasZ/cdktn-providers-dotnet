using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApiOperation
{
    [JsiiInterface(nativeType: typeof(IApiManagementApiOperationRequestHeaderExample), fullyQualifiedName: "azurerm.apiManagementApiOperation.ApiManagementApiOperationRequestHeaderExample")]
    public interface IApiManagementApiOperationRequestHeaderExample
    {
        /// <summary>The name of this example.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_operation#name ApiManagementApiOperation#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>A long description for this example.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_operation#description ApiManagementApiOperation#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>A URL that points to the literal example.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_operation#external_value ApiManagementApiOperation#external_value}
        /// </remarks>
        [JsiiProperty(name: "externalValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExternalValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>A short description for this example.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_operation#summary ApiManagementApiOperation#summary}
        /// </remarks>
        [JsiiProperty(name: "summary", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Summary
        {
            get
            {
                return null;
            }
        }

        /// <summary>The example of the representation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_operation#value ApiManagementApiOperation#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementApiOperationRequestHeaderExample), fullyQualifiedName: "azurerm.apiManagementApiOperation.ApiManagementApiOperationRequestHeaderExample")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementApiOperation.IApiManagementApiOperationRequestHeaderExample
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of this example.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_operation#name ApiManagementApiOperation#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A long description for this example.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_operation#description ApiManagementApiOperation#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A URL that points to the literal example.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_operation#external_value ApiManagementApiOperation#external_value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalValue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A short description for this example.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_operation#summary ApiManagementApiOperation#summary}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "summary", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Summary
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The example of the representation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_operation#value ApiManagementApiOperation#value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
