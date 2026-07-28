using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.applicationGateway.ApplicationGatewaySslProfile")]
    public class ApplicationGatewaySslProfile : azurerm.ApplicationGateway.IApplicationGatewaySslProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>ssl_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#ssl_policy ApplicationGateway#ssl_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sslPolicy", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewaySslProfileSslPolicy\"}", isOptional: true)]
        public azurerm.ApplicationGateway.IApplicationGatewaySslProfileSslPolicy? SslPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#trusted_client_certificate_names ApplicationGateway#trusted_client_certificate_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustedClientCertificateNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TrustedClientCertificateNames
        {
            get;
            set;
        }

        private object? _verifyClientCertificateIssuerDn;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#verify_client_certificate_issuer_dn ApplicationGateway#verify_client_certificate_issuer_dn}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verifyClientCertificateIssuerDn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? VerifyClientCertificateIssuerDn
        {
            get => _verifyClientCertificateIssuerDn;
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
                _verifyClientCertificateIssuerDn = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#verify_client_certificate_revocation ApplicationGateway#verify_client_certificate_revocation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verifyClientCertificateRevocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VerifyClientCertificateRevocation
        {
            get;
            set;
        }
    }
}
