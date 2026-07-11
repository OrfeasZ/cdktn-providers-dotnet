using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurestackProviderConfig), fullyQualifiedName: "azurestack.provider.AzurestackProviderConfig")]
    public interface IAzurestackProviderConfig
    {
        /// <summary>features block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#features AzurestackProvider#features}
        /// </remarks>
        [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"azurestack.provider.AzurestackProviderFeatures\"}")]
        azurestack.Provider.IAzurestackProviderFeatures Features
        {
            get;
        }

        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#alias AzurestackProvider#alias}
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

        /// <summary>The Hostname which should be used for the Azure Metadata Service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#arm_endpoint AzurestackProvider#arm_endpoint}
        /// </remarks>
        [JsiiProperty(name: "armEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ArmEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#auxiliary_tenant_ids AzurestackProvider#auxiliary_tenant_ids}.</summary>
        [JsiiProperty(name: "auxiliaryTenantIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AuxiliaryTenantIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>The password associated with the Client Certificate. For use when authenticating as a Service Principal using a Client Certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#client_certificate_password AzurestackProvider#client_certificate_password}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#client_certificate_path AzurestackProvider#client_certificate_path}
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

        /// <summary>The Client ID which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#client_id AzurestackProvider#client_id}
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

        /// <summary>The Client Secret which should be used. For use When authenticating as a Service Principal using a Client Secret.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#client_secret AzurestackProvider#client_secret}
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

        /// <summary>This will disable the x-ms-correlation-request-id header.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#disable_correlation_request_id AzurestackProvider#disable_correlation_request_id}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "disableCorrelationRequestId", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableCorrelationRequestId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Cloud Environment which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#environment AzurestackProvider#environment}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#metadata_host AzurestackProvider#metadata_host}
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

        /// <summary>The path to a custom endpoint for Managed Service Identity - in most circumstances this should be detected automatically.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#msi_endpoint AzurestackProvider#msi_endpoint}
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

        /// <summary>Should the AzureStack Provider skip registering all of the Resource Providers that it supports, if they're not already registered?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#skip_provider_registration AzurestackProvider#skip_provider_registration}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "skipProviderRegistration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipProviderRegistration
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Subscription ID which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#subscription_id AzurestackProvider#subscription_id}
        /// </remarks>
        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubscriptionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Tenant ID which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#tenant_id AzurestackProvider#tenant_id}
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

        /// <summary>Allowed Managed Service Identity be used for Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#use_msi AzurestackProvider#use_msi}
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

        [JsiiTypeProxy(nativeType: typeof(IAzurestackProviderConfig), fullyQualifiedName: "azurestack.provider.AzurestackProviderConfig")]
        internal sealed class _Proxy : DeputyBase, azurestack.Provider.IAzurestackProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>features block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#features AzurestackProvider#features}
            /// </remarks>
            [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"azurestack.provider.AzurestackProviderFeatures\"}")]
            public azurestack.Provider.IAzurestackProviderFeatures Features
            {
                get => GetInstanceProperty<azurestack.Provider.IAzurestackProviderFeatures>()!;
            }

            /// <summary>Alias name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#alias AzurestackProvider#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Hostname which should be used for the Azure Metadata Service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#arm_endpoint AzurestackProvider#arm_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "armEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ArmEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#auxiliary_tenant_ids AzurestackProvider#auxiliary_tenant_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "auxiliaryTenantIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AuxiliaryTenantIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The password associated with the Client Certificate. For use when authenticating as a Service Principal using a Client Certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#client_certificate_password AzurestackProvider#client_certificate_password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificatePassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The path to the Client Certificate associated with the Service Principal for use when authenticating as a Service Principal using a Client Certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#client_certificate_path AzurestackProvider#client_certificate_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificatePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificatePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Client ID which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#client_id AzurestackProvider#client_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Client Secret which should be used. For use When authenticating as a Service Principal using a Client Secret.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#client_secret AzurestackProvider#client_secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientSecret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>This will disable the x-ms-correlation-request-id header.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#disable_correlation_request_id AzurestackProvider#disable_correlation_request_id}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableCorrelationRequestId", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableCorrelationRequestId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The Cloud Environment which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#environment AzurestackProvider#environment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Environment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Hostname which should be used for the Azure Metadata Service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#metadata_host AzurestackProvider#metadata_host}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadataHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetadataHost
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The path to a custom endpoint for Managed Service Identity - in most circumstances this should be detected automatically.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#msi_endpoint AzurestackProvider#msi_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "msiEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MsiEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Should the AzureStack Provider skip registering all of the Resource Providers that it supports, if they're not already registered?</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#skip_provider_registration AzurestackProvider#skip_provider_registration}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipProviderRegistration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SkipProviderRegistration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The Subscription ID which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#subscription_id AzurestackProvider#subscription_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubscriptionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Tenant ID which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#tenant_id AzurestackProvider#tenant_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TenantId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Allowed Managed Service Identity be used for Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs#use_msi AzurestackProvider#use_msi}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useMsi", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UseMsi
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
