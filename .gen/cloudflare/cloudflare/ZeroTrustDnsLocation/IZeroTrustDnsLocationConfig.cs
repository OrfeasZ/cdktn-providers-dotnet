using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDnsLocation
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDnsLocationConfig), fullyQualifiedName: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationConfig")]
    public interface IZeroTrustDnsLocationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#account_id ZeroTrustDnsLocation#account_id}.</summary>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>The name of the location.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#name ZeroTrustDnsLocation#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>True if the location is the default location.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#client_default ZeroTrustDnsLocation#client_default}
        /// </remarks>
        [JsiiProperty(name: "clientDefault", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ClientDefault
        {
            get
            {
                return null;
            }
        }

        /// <summary>The identifier of the pair of IPv4 addresses assigned to this location.</summary>
        /// <remarks>
        /// When creating a location, if this field is absent or set with null, the pair of shared IPv4 addresses (0e4a32c6-6fb8-4858-9296-98f51631e8e6) is auto-assigned. When updating a location, if the field is absent or set with null, the pre-assigned pair remains unchanged.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#dns_destination_ips_id ZeroTrustDnsLocation#dns_destination_ips_id}
        /// </remarks>
        [JsiiProperty(name: "dnsDestinationIpsId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DnsDestinationIpsId
        {
            get
            {
                return null;
            }
        }

        /// <summary>True if the location needs to resolve EDNS queries.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#ecs_support ZeroTrustDnsLocation#ecs_support}
        /// </remarks>
        [JsiiProperty(name: "ecsSupport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EcsSupport
        {
            get
            {
                return null;
            }
        }

        /// <summary>The destination endpoints configured for this location.</summary>
        /// <remarks>
        /// When updating a location, if this field is absent or set with null, the endpoints configuration remains unchanged.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#endpoints ZeroTrustDnsLocation#endpoints}
        /// </remarks>
        [JsiiProperty(name: "endpoints", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpoints\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpoints? Endpoints
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of network ranges that requests from this location would originate from.</summary>
        /// <remarks>
        /// A non-empty list is only effective if the ipv4 endpoint is enabled for this location.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#networks ZeroTrustDnsLocation#networks}
        /// </remarks>
        [JsiiProperty(name: "networks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationNetworks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Networks
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDnsLocationConfig), fullyQualifiedName: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#account_id ZeroTrustDnsLocation#account_id}.</summary>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the location.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#name ZeroTrustDnsLocation#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>True if the location is the default location.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#client_default ZeroTrustDnsLocation#client_default}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientDefault", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ClientDefault
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The identifier of the pair of IPv4 addresses assigned to this location.</summary>
            /// <remarks>
            /// When creating a location, if this field is absent or set with null, the pair of shared IPv4 addresses (0e4a32c6-6fb8-4858-9296-98f51631e8e6) is auto-assigned. When updating a location, if the field is absent or set with null, the pre-assigned pair remains unchanged.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#dns_destination_ips_id ZeroTrustDnsLocation#dns_destination_ips_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dnsDestinationIpsId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DnsDestinationIpsId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>True if the location needs to resolve EDNS queries.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#ecs_support ZeroTrustDnsLocation#ecs_support}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecsSupport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EcsSupport
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The destination endpoints configured for this location.</summary>
            /// <remarks>
            /// When updating a location, if this field is absent or set with null, the endpoints configuration remains unchanged.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#endpoints ZeroTrustDnsLocation#endpoints}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endpoints", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpoints\"}", isOptional: true)]
            public cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpoints? Endpoints
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpoints?>();
            }

            /// <summary>A list of network ranges that requests from this location would originate from.</summary>
            /// <remarks>
            /// A non-empty list is only effective if the ipv4 endpoint is enabled for this location.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#networks ZeroTrustDnsLocation#networks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationNetworks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Networks
            {
                get => GetInstanceProperty<object?>();
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
