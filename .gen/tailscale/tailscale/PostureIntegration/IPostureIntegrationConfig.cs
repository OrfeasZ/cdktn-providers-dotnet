using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace tailscale.PostureIntegration
{
    [JsiiInterface(nativeType: typeof(IPostureIntegrationConfig), fullyQualifiedName: "tailscale.postureIntegration.PostureIntegrationConfig")]
    public interface IPostureIntegrationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The secret (auth key, token, etc.) used to authenticate with the provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/posture_integration#client_secret PostureIntegration#client_secret}
        /// </remarks>
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}")]
        string ClientSecret
        {
            get;
        }

        /// <summary>The third-party provider for posture data. Valid values are `falcon`, `fleet`, `huntress`, `intune`, `jamfpro`, `kandji`, `kolide`, and `sentinelone`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/posture_integration#posture_provider PostureIntegration#posture_provider}
        /// </remarks>
        [JsiiProperty(name: "postureProvider", typeJson: "{\"primitive\":\"string\"}")]
        string PostureProvider
        {
            get;
        }

        /// <summary>Unique identifier for your client.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/posture_integration#client_id PostureIntegration#client_id}
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

        /// <summary>Identifies which of the provider's clouds to integrate with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/posture_integration#cloud_id PostureIntegration#cloud_id}
        /// </remarks>
        [JsiiProperty(name: "cloudId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Microsoft Intune directory (tenant) ID. For other providers, this is left blank.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/posture_integration#tenant_id PostureIntegration#tenant_id}
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

        [JsiiTypeProxy(nativeType: typeof(IPostureIntegrationConfig), fullyQualifiedName: "tailscale.postureIntegration.PostureIntegrationConfig")]
        internal sealed class _Proxy : DeputyBase, tailscale.PostureIntegration.IPostureIntegrationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The secret (auth key, token, etc.) used to authenticate with the provider.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/posture_integration#client_secret PostureIntegration#client_secret}
            /// </remarks>
            [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientSecret
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The third-party provider for posture data. Valid values are `falcon`, `fleet`, `huntress`, `intune`, `jamfpro`, `kandji`, `kolide`, and `sentinelone`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/posture_integration#posture_provider PostureIntegration#posture_provider}
            /// </remarks>
            [JsiiProperty(name: "postureProvider", typeJson: "{\"primitive\":\"string\"}")]
            public string PostureProvider
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Unique identifier for your client.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/posture_integration#client_id PostureIntegration#client_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Identifies which of the provider's clouds to integrate with.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/posture_integration#cloud_id PostureIntegration#cloud_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Microsoft Intune directory (tenant) ID. For other providers, this is left blank.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/posture_integration#tenant_id PostureIntegration#tenant_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TenantId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
