using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteLan
{
    [JsiiInterface(nativeType: typeof(IMagicTransitSiteLanConfig), fullyQualifiedName: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanConfig")]
    public interface IMagicTransitSiteLanConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#site_id MagicTransitSiteLan#site_id}
        /// </remarks>
        [JsiiProperty(name: "siteId", typeJson: "{\"primitive\":\"string\"}")]
        string SiteId
        {
            get;
        }

        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#account_id MagicTransitSiteLan#account_id}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#bond_id MagicTransitSiteLan#bond_id}.</summary>
        [JsiiProperty(name: "bondId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BondId
        {
            get
            {
                return null;
            }
        }

        /// <summary>mark true to use this LAN for HA probing.</summary>
        /// <remarks>
        /// only works for site with HA turned on. only one LAN can be set as the ha_link.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#ha_link MagicTransitSiteLan#ha_link}
        /// </remarks>
        [JsiiProperty(name: "haLink", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HaLink
        {
            get
            {
                return null;
            }
        }

        /// <summary>mark true to use this LAN for source-based breakout traffic.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#is_breakout MagicTransitSiteLan#is_breakout}
        /// </remarks>
        [JsiiProperty(name: "isBreakout", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsBreakout
        {
            get
            {
                return null;
            }
        }

        /// <summary>mark true to use this LAN for source-based prioritized traffic.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#is_prioritized MagicTransitSiteLan#is_prioritized}
        /// </remarks>
        [JsiiProperty(name: "isPrioritized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsPrioritized
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#name MagicTransitSiteLan#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#nat MagicTransitSiteLan#nat}.</summary>
        [JsiiProperty(name: "nat", typeJson: "{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanNat\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanNat? Nat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#physport MagicTransitSiteLan#physport}.</summary>
        [JsiiProperty(name: "physport", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Physport
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#routed_subnets MagicTransitSiteLan#routed_subnets}.</summary>
        [JsiiProperty(name: "routedSubnets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanRoutedSubnets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RoutedSubnets
        {
            get
            {
                return null;
            }
        }

        /// <summary>If the site is not configured in high availability mode, this configuration is optional (if omitted, use DHCP).</summary>
        /// <remarks>
        /// However, if in high availability mode, static_address is required along with secondary and virtual address.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#static_addressing MagicTransitSiteLan#static_addressing}
        /// </remarks>
        [JsiiProperty(name: "staticAddressing", typeJson: "{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressing\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressing? StaticAddressing
        {
            get
            {
                return null;
            }
        }

        /// <summary>VLAN ID. Use zero for untagged.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#vlan_tag MagicTransitSiteLan#vlan_tag}
        /// </remarks>
        [JsiiProperty(name: "vlanTag", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VlanTag
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicTransitSiteLanConfig), fullyQualifiedName: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#site_id MagicTransitSiteLan#site_id}
            /// </remarks>
            [JsiiProperty(name: "siteId", typeJson: "{\"primitive\":\"string\"}")]
            public string SiteId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#account_id MagicTransitSiteLan#account_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#bond_id MagicTransitSiteLan#bond_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bondId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BondId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>mark true to use this LAN for HA probing.</summary>
            /// <remarks>
            /// only works for site with HA turned on. only one LAN can be set as the ha_link.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#ha_link MagicTransitSiteLan#ha_link}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "haLink", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? HaLink
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>mark true to use this LAN for source-based breakout traffic.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#is_breakout MagicTransitSiteLan#is_breakout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isBreakout", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsBreakout
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>mark true to use this LAN for source-based prioritized traffic.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#is_prioritized MagicTransitSiteLan#is_prioritized}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isPrioritized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsPrioritized
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#name MagicTransitSiteLan#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#nat MagicTransitSiteLan#nat}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nat", typeJson: "{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanNat\"}", isOptional: true)]
            public cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanNat? Nat
            {
                get => GetInstanceProperty<cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanNat?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#physport MagicTransitSiteLan#physport}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "physport", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Physport
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#routed_subnets MagicTransitSiteLan#routed_subnets}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "routedSubnets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanRoutedSubnets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RoutedSubnets
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>If the site is not configured in high availability mode, this configuration is optional (if omitted, use DHCP).</summary>
            /// <remarks>
            /// However, if in high availability mode, static_address is required along with secondary and virtual address.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#static_addressing MagicTransitSiteLan#static_addressing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "staticAddressing", typeJson: "{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressing\"}", isOptional: true)]
            public cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressing? StaticAddressing
            {
                get => GetInstanceProperty<cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressing?>();
            }

            /// <summary>VLAN ID. Use zero for untagged.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#vlan_tag MagicTransitSiteLan#vlan_tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vlanTag", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VlanTag
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
