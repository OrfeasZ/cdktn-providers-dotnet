using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagement
{
    [JsiiInterface(nativeType: typeof(IApiManagementHostnameConfigurationManagement), fullyQualifiedName: "azurerm.apiManagement.ApiManagementHostnameConfigurationManagement")]
    public interface IApiManagementHostnameConfigurationManagement
    {
        /// <summary>The host name to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#host_name ApiManagement#host_name}
        /// </remarks>
        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        string HostName
        {
            get;
        }

        /// <summary>The Base64-encoded certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#certificate ApiManagement#certificate}
        /// </remarks>
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Certificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>The password associated with the certificate provided above.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#certificate_password ApiManagement#certificate_password}
        /// </remarks>
        [JsiiProperty(name: "certificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificatePassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type `application/x-pkcs12`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#key_vault_certificate_id ApiManagement#key_vault_certificate_id}
        /// </remarks>
        [JsiiProperty(name: "keyVaultCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyVaultCertificateId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should Client Certificate Negotiation be enabled for this Hostname?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#negotiate_client_certificate ApiManagement#negotiate_client_certificate}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "negotiateClientCertificate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NegotiateClientCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Managed Service Identity Client ID, which has `GET` access to the Key Vault containing the SSL certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#ssl_keyvault_identity_client_id ApiManagement#ssl_keyvault_identity_client_id}
        /// </remarks>
        [JsiiProperty(name: "sslKeyvaultIdentityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslKeyvaultIdentityClientId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementHostnameConfigurationManagement), fullyQualifiedName: "azurerm.apiManagement.ApiManagementHostnameConfigurationManagement")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagement.IApiManagementHostnameConfigurationManagement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The host name to use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#host_name ApiManagement#host_name}
            /// </remarks>
            [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
            public string HostName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The Base64-encoded certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#certificate ApiManagement#certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Certificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The password associated with the certificate provided above.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#certificate_password ApiManagement#certificate_password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificatePassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type `application/x-pkcs12`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#key_vault_certificate_id ApiManagement#key_vault_certificate_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyVaultCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyVaultCertificateId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Should Client Certificate Negotiation be enabled for this Hostname?</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#negotiate_client_certificate ApiManagement#negotiate_client_certificate}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "negotiateClientCertificate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? NegotiateClientCertificate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The Managed Service Identity Client ID, which has `GET` access to the Key Vault containing the SSL certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#ssl_keyvault_identity_client_id ApiManagement#ssl_keyvault_identity_client_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sslKeyvaultIdentityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslKeyvaultIdentityClientId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
