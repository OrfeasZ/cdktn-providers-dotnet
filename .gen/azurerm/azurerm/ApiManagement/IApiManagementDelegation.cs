using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagement
{
    [JsiiInterface(nativeType: typeof(IApiManagementDelegation), fullyQualifiedName: "azurerm.apiManagement.ApiManagementDelegation")]
    public interface IApiManagementDelegation
    {
        /// <summary>Should subscription requests be delegated to an external URL?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#subscriptions_enabled ApiManagement#subscriptions_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "subscriptionsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SubscriptionsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The delegation URL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#url ApiManagement#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Url
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should user registration requests be delegated to an external URL?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#user_registration_enabled ApiManagement#user_registration_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "userRegistrationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UserRegistrationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>A base64-encoded validation key to validate, that a request is coming from Azure API Management.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#validation_key ApiManagement#validation_key}
        /// </remarks>
        [JsiiProperty(name: "validationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ValidationKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementDelegation), fullyQualifiedName: "azurerm.apiManagement.ApiManagementDelegation")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagement.IApiManagementDelegation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Should subscription requests be delegated to an external URL?</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#subscriptions_enabled ApiManagement#subscriptions_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subscriptionsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SubscriptionsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The delegation URL.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#url ApiManagement#url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Url
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Should user registration requests be delegated to an external URL?</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#user_registration_enabled ApiManagement#user_registration_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userRegistrationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UserRegistrationEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A base64-encoded validation key to validate, that a request is coming from Azure API Management.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#validation_key ApiManagement#validation_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ValidationKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
