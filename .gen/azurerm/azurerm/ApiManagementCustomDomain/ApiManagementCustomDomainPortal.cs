using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementCustomDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementCustomDomain.ApiManagementCustomDomainPortal")]
    public class ApiManagementCustomDomainPortal : azurerm.ApiManagementCustomDomain.IApiManagementCustomDomainPortal
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/api_management_custom_domain#host_name ApiManagementCustomDomain#host_name}.</summary>
        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public string HostName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/api_management_custom_domain#certificate ApiManagementCustomDomain#certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Certificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/api_management_custom_domain#certificate_password ApiManagementCustomDomain#certificate_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificatePassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/api_management_custom_domain#key_vault_certificate_id ApiManagementCustomDomain#key_vault_certificate_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyVaultCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyVaultCertificateId
        {
            get;
            set;
        }

        private object? _negotiateClientCertificate;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/api_management_custom_domain#negotiate_client_certificate ApiManagementCustomDomain#negotiate_client_certificate}.</summary>
        /// <remarks>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/api_management_custom_domain#ssl_keyvault_identity_client_id ApiManagementCustomDomain#ssl_keyvault_identity_client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslKeyvaultIdentityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslKeyvaultIdentityClientId
        {
            get;
            set;
        }
    }
}
