using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Provider
{
    [JsiiInterface(nativeType: typeof(IAzureadProviderConfig), fullyQualifiedName: "azuread.provider.AzureadProviderConfig")]
    public interface IAzureadProviderConfig
    {
        /// <summary>The Azure DevOps Pipeline Service Connection ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#ado_pipeline_service_connection_id AzureadProvider#ado_pipeline_service_connection_id}
        /// </remarks>
        [JsiiProperty(name: "adoPipelineServiceConnectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdoPipelineServiceConnectionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#alias AzureadProvider#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Base64 encoded PKCS#12 certificate bundle to use when authenticating as a Service Principal using a Client Certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#client_certificate AzureadProvider#client_certificate}
        /// </remarks>
        [JsiiProperty(name: "clientCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>The password to decrypt the Client Certificate. For use when authenticating as a Service Principal using a Client Certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#client_certificate_password AzureadProvider#client_certificate_password}
        /// </remarks>
        [JsiiProperty(name: "clientCertificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificatePassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to the Client Certificate associated with the Service Principal for use when authenticating as a Service Principal using a Client Certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#client_certificate_path AzureadProvider#client_certificate_path}
        /// </remarks>
        [JsiiProperty(name: "clientCertificatePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificatePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Client ID which should be used for service principal authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#client_id AzureadProvider#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to a file containing the Client ID which should be used for service principal authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#client_id_file_path AzureadProvider#client_id_file_path}
        /// </remarks>
        [JsiiProperty(name: "clientIdFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientIdFilePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>The application password to use when authenticating as a Service Principal using a Client Secret.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#client_secret AzureadProvider#client_secret}
        /// </remarks>
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to a file containing the application password to use when authenticating as a Service Principal using a Client Secret.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#client_secret_file_path AzureadProvider#client_secret_file_path}
        /// </remarks>
        [JsiiProperty(name: "clientSecretFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientSecretFilePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Disable the Terraform Partner ID, which is used if a custom `partner_id` isn't specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#disable_terraform_partner_id AzureadProvider#disable_terraform_partner_id}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "disableTerraformPartnerId", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableTerraformPartnerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The cloud environment which should be used.</summary>
        /// <remarks>
        /// Possible values are: <c>global</c> (also <c>public</c>), <c>usgovernmentl4</c> (also <c>usgovernment</c>), <c>usgovernmentl5</c> (also <c>dod</c>), and <c>china</c>. Defaults to <c>global</c>. Not used and should not be specified when <c>metadata_host</c> is specified.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#environment AzureadProvider#environment}
        /// </remarks>
        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Environment
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Hostname which should be used for the Azure Metadata Service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#metadata_host AzureadProvider#metadata_host}
        /// </remarks>
        [JsiiProperty(name: "metadataHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetadataHost
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to a custom endpoint for Managed Identity - in most circumstances this should be detected automatically.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#msi_endpoint AzureadProvider#msi_endpoint}
        /// </remarks>
        [JsiiProperty(name: "msiEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MsiEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>The bearer token for the request to the OIDC provider.</summary>
        /// <remarks>
        /// For use when authenticating as a Service Principal using OpenID Connect.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#oidc_request_token AzureadProvider#oidc_request_token}
        /// </remarks>
        [JsiiProperty(name: "oidcRequestToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OidcRequestToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>The URL for the OIDC provider from which to request an ID token.</summary>
        /// <remarks>
        /// For use when authenticating as a Service Principal using OpenID Connect.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#oidc_request_url AzureadProvider#oidc_request_url}
        /// </remarks>
        [JsiiProperty(name: "oidcRequestUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OidcRequestUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID token for use when authenticating as a Service Principal using OpenID Connect.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#oidc_token AzureadProvider#oidc_token}
        /// </remarks>
        [JsiiProperty(name: "oidcToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OidcToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to a file containing an ID token for use when authenticating as a Service Principal using OpenID Connect.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#oidc_token_file_path AzureadProvider#oidc_token_file_path}
        /// </remarks>
        [JsiiProperty(name: "oidcTokenFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OidcTokenFilePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>A GUID/UUID that is registered with Microsoft to facilitate partner resource usage attribution.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#partner_id AzureadProvider#partner_id}
        /// </remarks>
        [JsiiProperty(name: "partnerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PartnerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Tenant ID which should be used. Works with all authentication methods except Managed Identity.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#tenant_id AzureadProvider#tenant_id}
        /// </remarks>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TenantId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allow Azure AKS Workload Identity to be used for Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#use_aks_workload_identity AzureadProvider#use_aks_workload_identity}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "useAksWorkloadIdentity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseAksWorkloadIdentity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allow Azure CLI to be used for Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#use_cli AzureadProvider#use_cli}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "useCli", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseCli
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allow Managed Identity to be used for Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#use_msi AzureadProvider#use_msi}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "useMsi", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseMsi
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allow OpenID Connect to be used for authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#use_oidc AzureadProvider#use_oidc}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "useOidc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseOidc
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzureadProviderConfig), fullyQualifiedName: "azuread.provider.AzureadProviderConfig")]
        internal sealed class _Proxy : DeputyBase, azuread.Provider.IAzureadProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Azure DevOps Pipeline Service Connection ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#ado_pipeline_service_connection_id AzureadProvider#ado_pipeline_service_connection_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "adoPipelineServiceConnectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdoPipelineServiceConnectionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Alias name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#alias AzureadProvider#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Base64 encoded PKCS#12 certificate bundle to use when authenticating as a Service Principal using a Client Certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#client_certificate AzureadProvider#client_certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The password to decrypt the Client Certificate. For use when authenticating as a Service Principal using a Client Certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#client_certificate_password AzureadProvider#client_certificate_password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificatePassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The path to the Client Certificate associated with the Service Principal for use when authenticating as a Service Principal using a Client Certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#client_certificate_path AzureadProvider#client_certificate_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificatePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificatePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Client ID which should be used for service principal authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#client_id AzureadProvider#client_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The path to a file containing the Client ID which should be used for service principal authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#client_id_file_path AzureadProvider#client_id_file_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientIdFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientIdFilePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The application password to use when authenticating as a Service Principal using a Client Secret.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#client_secret AzureadProvider#client_secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientSecret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The path to a file containing the application password to use when authenticating as a Service Principal using a Client Secret.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#client_secret_file_path AzureadProvider#client_secret_file_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientSecretFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientSecretFilePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Disable the Terraform Partner ID, which is used if a custom `partner_id` isn't specified.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#disable_terraform_partner_id AzureadProvider#disable_terraform_partner_id}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableTerraformPartnerId", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableTerraformPartnerId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The cloud environment which should be used.</summary>
            /// <remarks>
            /// Possible values are: <c>global</c> (also <c>public</c>), <c>usgovernmentl4</c> (also <c>usgovernment</c>), <c>usgovernmentl5</c> (also <c>dod</c>), and <c>china</c>. Defaults to <c>global</c>. Not used and should not be specified when <c>metadata_host</c> is specified.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#environment AzureadProvider#environment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Environment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Hostname which should be used for the Azure Metadata Service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#metadata_host AzureadProvider#metadata_host}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadataHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetadataHost
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The path to a custom endpoint for Managed Identity - in most circumstances this should be detected automatically.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#msi_endpoint AzureadProvider#msi_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "msiEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MsiEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The bearer token for the request to the OIDC provider.</summary>
            /// <remarks>
            /// For use when authenticating as a Service Principal using OpenID Connect.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#oidc_request_token AzureadProvider#oidc_request_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oidcRequestToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OidcRequestToken
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The URL for the OIDC provider from which to request an ID token.</summary>
            /// <remarks>
            /// For use when authenticating as a Service Principal using OpenID Connect.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#oidc_request_url AzureadProvider#oidc_request_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oidcRequestUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OidcRequestUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ID token for use when authenticating as a Service Principal using OpenID Connect.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#oidc_token AzureadProvider#oidc_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oidcToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OidcToken
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The path to a file containing an ID token for use when authenticating as a Service Principal using OpenID Connect.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#oidc_token_file_path AzureadProvider#oidc_token_file_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oidcTokenFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OidcTokenFilePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A GUID/UUID that is registered with Microsoft to facilitate partner resource usage attribution.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#partner_id AzureadProvider#partner_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "partnerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PartnerId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Tenant ID which should be used. Works with all authentication methods except Managed Identity.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#tenant_id AzureadProvider#tenant_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TenantId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Allow Azure AKS Workload Identity to be used for Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#use_aks_workload_identity AzureadProvider#use_aks_workload_identity}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useAksWorkloadIdentity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UseAksWorkloadIdentity
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Allow Azure CLI to be used for Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#use_cli AzureadProvider#use_cli}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useCli", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UseCli
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Allow Managed Identity to be used for Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#use_msi AzureadProvider#use_msi}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useMsi", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UseMsi
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Allow OpenID Connect to be used for authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs#use_oidc AzureadProvider#use_oidc}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useOidc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UseOidc
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
