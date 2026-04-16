using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZoneDnsSettings
{
    [JsiiInterface(nativeType: typeof(IZoneDnsSettingsConfig), fullyQualifiedName: "cloudflare.zoneDnsSettings.ZoneDnsSettingsConfig")]
    public interface IZoneDnsSettingsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#zone_id ZoneDnsSettings#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        /// <summary>Whether to flatten all CNAME records in the zone.</summary>
        /// <remarks>
        /// Note that, due to DNS limitations, a CNAME record at the zone apex will always be flattened.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#flatten_all_cnames ZoneDnsSettings#flatten_all_cnames}
        /// </remarks>
        [JsiiProperty(name: "flattenAllCnames", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FlattenAllCnames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to enable Foundation DNS Advanced Nameservers on the zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#foundation_dns ZoneDnsSettings#foundation_dns}
        /// </remarks>
        [JsiiProperty(name: "foundationDns", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FoundationDns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Settings for this internal zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#internal_dns ZoneDnsSettings#internal_dns}
        /// </remarks>
        [JsiiProperty(name: "internalDns", typeJson: "{\"fqn\":\"cloudflare.zoneDnsSettings.ZoneDnsSettingsInternalDns\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZoneDnsSettings.IZoneDnsSettingsInternalDns? InternalDns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to enable multi-provider DNS, which causes Cloudflare to activate the zone even when non-Cloudflare NS records exist, and to respect NS records at the zone apex during outbound zone transfers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#multi_provider ZoneDnsSettings#multi_provider}
        /// </remarks>
        [JsiiProperty(name: "multiProvider", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MultiProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>Settings determining the nameservers through which the zone should be available.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#nameservers ZoneDnsSettings#nameservers}
        /// </remarks>
        [JsiiProperty(name: "nameservers", typeJson: "{\"fqn\":\"cloudflare.zoneDnsSettings.ZoneDnsSettingsNameservers\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZoneDnsSettings.IZoneDnsSettingsNameservers? Nameservers
        {
            get
            {
                return null;
            }
        }

        /// <summary>The time to live (TTL) of the zone's nameserver (NS) records.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#ns_ttl ZoneDnsSettings#ns_ttl}
        /// </remarks>
        [JsiiProperty(name: "nsTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NsTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allows a Secondary DNS zone to use (proxied) override records and CNAME flattening at the zone apex.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#secondary_overrides ZoneDnsSettings#secondary_overrides}
        /// </remarks>
        [JsiiProperty(name: "secondaryOverrides", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecondaryOverrides
        {
            get
            {
                return null;
            }
        }

        /// <summary>Components of the zone's SOA record.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#soa ZoneDnsSettings#soa}
        /// </remarks>
        [JsiiProperty(name: "soa", typeJson: "{\"fqn\":\"cloudflare.zoneDnsSettings.ZoneDnsSettingsSoa\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZoneDnsSettings.IZoneDnsSettingsSoa? Soa
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the zone mode is a regular or CDN/DNS only zone. Available values: "standard", "cdn_only", "dns_only".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#zone_mode ZoneDnsSettings#zone_mode}
        /// </remarks>
        [JsiiProperty(name: "zoneMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZoneMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZoneDnsSettingsConfig), fullyQualifiedName: "cloudflare.zoneDnsSettings.ZoneDnsSettingsConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZoneDnsSettings.IZoneDnsSettingsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#zone_id ZoneDnsSettings#zone_id}
            /// </remarks>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether to flatten all CNAME records in the zone.</summary>
            /// <remarks>
            /// Note that, due to DNS limitations, a CNAME record at the zone apex will always be flattened.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#flatten_all_cnames ZoneDnsSettings#flatten_all_cnames}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flattenAllCnames", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FlattenAllCnames
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether to enable Foundation DNS Advanced Nameservers on the zone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#foundation_dns ZoneDnsSettings#foundation_dns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "foundationDns", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FoundationDns
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Settings for this internal zone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#internal_dns ZoneDnsSettings#internal_dns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "internalDns", typeJson: "{\"fqn\":\"cloudflare.zoneDnsSettings.ZoneDnsSettingsInternalDns\"}", isOptional: true)]
            public cloudflare.ZoneDnsSettings.IZoneDnsSettingsInternalDns? InternalDns
            {
                get => GetInstanceProperty<cloudflare.ZoneDnsSettings.IZoneDnsSettingsInternalDns?>();
            }

            /// <summary>Whether to enable multi-provider DNS, which causes Cloudflare to activate the zone even when non-Cloudflare NS records exist, and to respect NS records at the zone apex during outbound zone transfers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#multi_provider ZoneDnsSettings#multi_provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "multiProvider", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MultiProvider
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Settings determining the nameservers through which the zone should be available.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#nameservers ZoneDnsSettings#nameservers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nameservers", typeJson: "{\"fqn\":\"cloudflare.zoneDnsSettings.ZoneDnsSettingsNameservers\"}", isOptional: true)]
            public cloudflare.ZoneDnsSettings.IZoneDnsSettingsNameservers? Nameservers
            {
                get => GetInstanceProperty<cloudflare.ZoneDnsSettings.IZoneDnsSettingsNameservers?>();
            }

            /// <summary>The time to live (TTL) of the zone's nameserver (NS) records.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#ns_ttl ZoneDnsSettings#ns_ttl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nsTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NsTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Allows a Secondary DNS zone to use (proxied) override records and CNAME flattening at the zone apex.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#secondary_overrides ZoneDnsSettings#secondary_overrides}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secondaryOverrides", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SecondaryOverrides
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Components of the zone's SOA record.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#soa ZoneDnsSettings#soa}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "soa", typeJson: "{\"fqn\":\"cloudflare.zoneDnsSettings.ZoneDnsSettingsSoa\"}", isOptional: true)]
            public cloudflare.ZoneDnsSettings.IZoneDnsSettingsSoa? Soa
            {
                get => GetInstanceProperty<cloudflare.ZoneDnsSettings.IZoneDnsSettingsSoa?>();
            }

            /// <summary>Whether the zone mode is a regular or CDN/DNS only zone. Available values: "standard", "cdn_only", "dns_only".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#zone_mode ZoneDnsSettings#zone_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zoneMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZoneMode
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
