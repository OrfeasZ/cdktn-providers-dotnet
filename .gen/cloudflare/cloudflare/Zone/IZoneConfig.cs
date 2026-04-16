using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Zone
{
    [JsiiInterface(nativeType: typeof(IZoneConfig), fullyQualifiedName: "cloudflare.zone.ZoneConfig")]
    public interface IZoneConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone#account Zone#account}.</summary>
        [JsiiProperty(name: "account", typeJson: "{\"fqn\":\"cloudflare.zone.ZoneAccount\"}")]
        cloudflare.Zone.IZoneAccount Account
        {
            get;
        }

        /// <summary>The domain name.</summary>
        /// <remarks>
        /// Per <a href="https://datatracker.ietf.org/doc/html/rfc1035#section-2.3.4">RFC 1035</a> the overall zone name can be up to 253 characters, with each segment ("label") not exceeding 63 characters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone#name Zone#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Indicates whether the zone is only using Cloudflare DNS services.</summary>
        /// <remarks>
        /// A
        /// true value means the zone will not receive security or performance
        /// benefits.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone#paused Zone#paused}
        /// </remarks>
        [JsiiProperty(name: "paused", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Paused
        {
            get
            {
                return null;
            }
        }

        /// <summary>A full zone implies that DNS is hosted with Cloudflare.</summary>
        /// <remarks>
        /// A partial zone is
        /// typically a partner-hosted zone or a CNAME setup.
        /// Available values: "full", "partial", "secondary", "internal".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone#type Zone#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>An array of domains used for custom name servers. This is only available for Business and Enterprise plans.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone#vanity_name_servers Zone#vanity_name_servers}
        /// </remarks>
        [JsiiProperty(name: "vanityNameServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? VanityNameServers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZoneConfig), fullyQualifiedName: "cloudflare.zone.ZoneConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Zone.IZoneConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone#account Zone#account}.</summary>
            [JsiiProperty(name: "account", typeJson: "{\"fqn\":\"cloudflare.zone.ZoneAccount\"}")]
            public cloudflare.Zone.IZoneAccount Account
            {
                get => GetInstanceProperty<cloudflare.Zone.IZoneAccount>()!;
            }

            /// <summary>The domain name.</summary>
            /// <remarks>
            /// Per <a href="https://datatracker.ietf.org/doc/html/rfc1035#section-2.3.4">RFC 1035</a> the overall zone name can be up to 253 characters, with each segment ("label") not exceeding 63 characters.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone#name Zone#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Indicates whether the zone is only using Cloudflare DNS services.</summary>
            /// <remarks>
            /// A
            /// true value means the zone will not receive security or performance
            /// benefits.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone#paused Zone#paused}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paused", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Paused
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A full zone implies that DNS is hosted with Cloudflare.</summary>
            /// <remarks>
            /// A partial zone is
            /// typically a partner-hosted zone or a CNAME setup.
            /// Available values: "full", "partial", "secondary", "internal".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone#type Zone#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>An array of domains used for custom name servers. This is only available for Business and Enterprise plans.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone#vanity_name_servers Zone#vanity_name_servers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vanityNameServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? VanityNameServers
            {
                get => GetInstanceProperty<string[]?>();
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
