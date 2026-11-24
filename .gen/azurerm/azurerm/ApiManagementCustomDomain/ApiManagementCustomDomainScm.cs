using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementCustomDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementCustomDomain.ApiManagementCustomDomainScm")]
    public class ApiManagementCustomDomainScm : azurerm.ApiManagementCustomDomain.IApiManagementCustomDomainScm
    {
        /// <summary>The host name to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_custom_domain#host_name ApiManagementCustomDomain#host_name}
        /// </remarks>
        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public string HostName
        {
            get;
            set;
        }

        /// <summary>The Base64-encoded certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_custom_domain#certificate ApiManagementCustomDomain#certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Certificate
        {
            get;
            set;
        }

        /// <summary>The password associated with the certificate provided above.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_custom_domain#certificate_password ApiManagementCustomDomain#certificate_password}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificatePassword
        {
            get;
            set;
        }

        /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type `application/x-pkcs12`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_custom_domain#key_vault_certificate_id ApiManagementCustomDomain#key_vault_certificate_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyVaultCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyVaultCertificateId
        {
            get;
            set;
        }

        private object? _negotiateClientCertificate;

        /// <summary>Should Client Certificate Negotiation be enabled for this Hostname?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_custom_domain#negotiate_client_certificate ApiManagementCustomDomain#negotiate_client_certificate}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "negotiateClientCertificate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? NegotiateClientCertificate
        {
            get => _negotiateClientCertificate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _negotiateClientCertificate = value;
            }
        }

        /// <summary>The Managed Service Identity Client ID, which has `GET` access to the Key Vault containing the SSL certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_custom_domain#ssl_keyvault_identity_client_id ApiManagementCustomDomain#ssl_keyvault_identity_client_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sslKeyvaultIdentityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslKeyvaultIdentityClientId
        {
            get;
            set;
        }
    }
}
