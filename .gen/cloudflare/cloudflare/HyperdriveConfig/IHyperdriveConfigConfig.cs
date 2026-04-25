using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.HyperdriveConfig
{
    [JsiiInterface(nativeType: typeof(IHyperdriveConfigConfig), fullyQualifiedName: "cloudflare.hyperdriveConfig.HyperdriveConfigConfig")]
    public interface IHyperdriveConfigConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The name of the Hyperdrive configuration. Used to identify the configuration in the Cloudflare dashboard and API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#name HyperdriveConfig#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#origin HyperdriveConfig#origin}.</summary>
        [JsiiProperty(name: "origin", typeJson: "{\"fqn\":\"cloudflare.hyperdriveConfig.HyperdriveConfigOrigin\"}")]
        cloudflare.HyperdriveConfig.IHyperdriveConfigOrigin Origin
        {
            get;
        }

        /// <summary>Define configurations using a unique string identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#account_id HyperdriveConfig#account_id}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#caching HyperdriveConfig#caching}.</summary>
        [JsiiProperty(name: "caching", typeJson: "{\"fqn\":\"cloudflare.hyperdriveConfig.HyperdriveConfigCaching\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.HyperdriveConfig.IHyperdriveConfigCaching? Caching
        {
            get
            {
                return null;
            }
        }

        /// <summary>mTLS configuration for the origin connection.</summary>
        /// <remarks>
        /// Cannot be used with VPC Service origins; TLS must be managed on the VPC Service.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#mtls HyperdriveConfig#mtls}
        /// </remarks>
        [JsiiProperty(name: "mtls", typeJson: "{\"fqn\":\"cloudflare.hyperdriveConfig.HyperdriveConfigMtls\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.HyperdriveConfig.IHyperdriveConfigMtls? Mtls
        {
            get
            {
                return null;
            }
        }

        /// <summary>The (soft) maximum number of connections the Hyperdrive is allowed to make to the origin database.</summary>
        /// <remarks>
        /// Maximum allowed: 20 for free tier accounts, 100 for paid tier accounts.
        /// If not specified, defaults to 20 for free tier and 60 for paid tier.
        /// Contact Cloudflare if you need a higher limit.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#origin_connection_limit HyperdriveConfig#origin_connection_limit}
        /// </remarks>
        [JsiiProperty(name: "originConnectionLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OriginConnectionLimit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHyperdriveConfigConfig), fullyQualifiedName: "cloudflare.hyperdriveConfig.HyperdriveConfigConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.HyperdriveConfig.IHyperdriveConfigConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the Hyperdrive configuration. Used to identify the configuration in the Cloudflare dashboard and API.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#name HyperdriveConfig#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#origin HyperdriveConfig#origin}.</summary>
            [JsiiProperty(name: "origin", typeJson: "{\"fqn\":\"cloudflare.hyperdriveConfig.HyperdriveConfigOrigin\"}")]
            public cloudflare.HyperdriveConfig.IHyperdriveConfigOrigin Origin
            {
                get => GetInstanceProperty<cloudflare.HyperdriveConfig.IHyperdriveConfigOrigin>()!;
            }

            /// <summary>Define configurations using a unique string identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#account_id HyperdriveConfig#account_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#caching HyperdriveConfig#caching}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "caching", typeJson: "{\"fqn\":\"cloudflare.hyperdriveConfig.HyperdriveConfigCaching\"}", isOptional: true)]
            public cloudflare.HyperdriveConfig.IHyperdriveConfigCaching? Caching
            {
                get => GetInstanceProperty<cloudflare.HyperdriveConfig.IHyperdriveConfigCaching?>();
            }

            /// <summary>mTLS configuration for the origin connection.</summary>
            /// <remarks>
            /// Cannot be used with VPC Service origins; TLS must be managed on the VPC Service.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#mtls HyperdriveConfig#mtls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mtls", typeJson: "{\"fqn\":\"cloudflare.hyperdriveConfig.HyperdriveConfigMtls\"}", isOptional: true)]
            public cloudflare.HyperdriveConfig.IHyperdriveConfigMtls? Mtls
            {
                get => GetInstanceProperty<cloudflare.HyperdriveConfig.IHyperdriveConfigMtls?>();
            }

            /// <summary>The (soft) maximum number of connections the Hyperdrive is allowed to make to the origin database.</summary>
            /// <remarks>
            /// Maximum allowed: 20 for free tier accounts, 100 for paid tier accounts.
            /// If not specified, defaults to 20 for free tier and 60 for paid tier.
            /// Contact Cloudflare if you need a higher limit.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#origin_connection_limit HyperdriveConfig#origin_connection_limit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "originConnectionLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OriginConnectionLimit
            {
                get => GetInstanceProperty<double?>();
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
