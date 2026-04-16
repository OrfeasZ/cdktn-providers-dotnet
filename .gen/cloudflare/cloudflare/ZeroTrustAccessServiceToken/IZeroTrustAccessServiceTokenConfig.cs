using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessServiceToken
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessServiceTokenConfig), fullyQualifiedName: "cloudflare.zeroTrustAccessServiceToken.ZeroTrustAccessServiceTokenConfig")]
    public interface IZeroTrustAccessServiceTokenConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The name of the service token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_service_token#name ZeroTrustAccessServiceToken#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The Account ID to use for this endpoint. Mutually exclusive with the Zone ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_service_token#account_id ZeroTrustAccessServiceToken#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>A version number identifying the current `client_secret` associated with the service token.</summary>
        /// <remarks>
        /// Incrementing it triggers a rotation; the previous secret will still be accepted until the time indicated by <c>previous_client_secret_expires_at</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_service_token#client_secret_version ZeroTrustAccessServiceToken#client_secret_version}
        /// </remarks>
        [JsiiProperty(name: "clientSecretVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ClientSecretVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>The duration for how long the service token will be valid.</summary>
        /// <remarks>
        /// Must be in the format <c>300ms</c> or <c>2h45m</c>. Valid time units are: ns, us (or µs), ms, s, m, h. The default is 1 year in hours (8760h).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_service_token#duration ZeroTrustAccessServiceToken#duration}
        /// </remarks>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Duration
        {
            get
            {
                return null;
            }
        }

        /// <summary>The expiration of the previous `client_secret`.</summary>
        /// <remarks>
        /// This can be modified at any point after a rotation. For example, you may extend it further into the future if you need more time to update services with the new secret; or move it into the past to immediately invalidate the previous token in case of compromise.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_service_token#previous_client_secret_expires_at ZeroTrustAccessServiceToken#previous_client_secret_expires_at}
        /// </remarks>
        [JsiiProperty(name: "previousClientSecretExpiresAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreviousClientSecretExpiresAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Zone ID to use for this endpoint. Mutually exclusive with the Account ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_service_token#zone_id ZeroTrustAccessServiceToken#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZoneId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessServiceTokenConfig), fullyQualifiedName: "cloudflare.zeroTrustAccessServiceToken.ZeroTrustAccessServiceTokenConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessServiceToken.IZeroTrustAccessServiceTokenConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the service token.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_service_token#name ZeroTrustAccessServiceToken#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The Account ID to use for this endpoint. Mutually exclusive with the Zone ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_service_token#account_id ZeroTrustAccessServiceToken#account_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A version number identifying the current `client_secret` associated with the service token.</summary>
            /// <remarks>
            /// Incrementing it triggers a rotation; the previous secret will still be accepted until the time indicated by <c>previous_client_secret_expires_at</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_service_token#client_secret_version ZeroTrustAccessServiceToken#client_secret_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientSecretVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ClientSecretVersion
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The duration for how long the service token will be valid.</summary>
            /// <remarks>
            /// Must be in the format <c>300ms</c> or <c>2h45m</c>. Valid time units are: ns, us (or µs), ms, s, m, h. The default is 1 year in hours (8760h).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_service_token#duration ZeroTrustAccessServiceToken#duration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Duration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The expiration of the previous `client_secret`.</summary>
            /// <remarks>
            /// This can be modified at any point after a rotation. For example, you may extend it further into the future if you need more time to update services with the new secret; or move it into the past to immediately invalidate the previous token in case of compromise.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_service_token#previous_client_secret_expires_at ZeroTrustAccessServiceToken#previous_client_secret_expires_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "previousClientSecretExpiresAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreviousClientSecretExpiresAt
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Zone ID to use for this endpoint. Mutually exclusive with the Account ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_service_token#zone_id ZeroTrustAccessServiceToken#zone_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZoneId
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
