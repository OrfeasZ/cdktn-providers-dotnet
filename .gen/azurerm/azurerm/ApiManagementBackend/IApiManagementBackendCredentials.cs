using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementBackend
{
    [JsiiInterface(nativeType: typeof(IApiManagementBackendCredentials), fullyQualifiedName: "azurerm.apiManagementBackend.ApiManagementBackendCredentials")]
    public interface IApiManagementBackendCredentials
    {
        /// <summary>authorization block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#authorization ApiManagementBackend#authorization}
        /// </remarks>
        [JsiiProperty(name: "authorization", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendCredentialsAuthorization\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementBackend.IApiManagementBackendCredentialsAuthorization? Authorization
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of client certificate thumbprints to present to the backend host.</summary>
        /// <remarks>
        /// The certificates must exist within the API Management Service.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#certificate ApiManagementBackend#certificate}
        /// </remarks>
        [JsiiProperty(name: "certificate", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Certificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>A mapping of header parameters to pass to the backend host.</summary>
        /// <remarks>
        /// The keys are the header names and the values are a comma separated string of header values. This is converted to a list before being passed to the API.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#header ApiManagementBackend#header}
        /// </remarks>
        [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Header
        {
            get
            {
                return null;
            }
        }

        /// <summary>A mapping of query parameters to pass to the backend host.</summary>
        /// <remarks>
        /// The keys are the query names and the values are a comma separated string of query values. This is converted to a list before being passed to the API.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#query ApiManagementBackend#query}
        /// </remarks>
        [JsiiProperty(name: "query", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Query
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementBackendCredentials), fullyQualifiedName: "azurerm.apiManagementBackend.ApiManagementBackendCredentials")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementBackend.IApiManagementBackendCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>authorization block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#authorization ApiManagementBackend#authorization}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authorization", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendCredentialsAuthorization\"}", isOptional: true)]
            public azurerm.ApiManagementBackend.IApiManagementBackendCredentialsAuthorization? Authorization
            {
                get => GetInstanceProperty<azurerm.ApiManagementBackend.IApiManagementBackendCredentialsAuthorization?>();
            }

            /// <summary>A list of client certificate thumbprints to present to the backend host.</summary>
            /// <remarks>
            /// The certificates must exist within the API Management Service.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#certificate ApiManagementBackend#certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificate", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Certificate
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A mapping of header parameters to pass to the backend host.</summary>
            /// <remarks>
            /// The keys are the header names and the values are a comma separated string of header values. This is converted to a list before being passed to the API.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#header ApiManagementBackend#header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Header
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>A mapping of query parameters to pass to the backend host.</summary>
            /// <remarks>
            /// The keys are the query names and the values are a comma separated string of query values. This is converted to a list before being passed to the API.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#query ApiManagementBackend#query}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "query", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Query
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
