using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteAcl
{
    [JsiiInterface(nativeType: typeof(IMagicTransitSiteAclLan1), fullyQualifiedName: "cloudflare.magicTransitSiteAcl.MagicTransitSiteAclLan1")]
    public interface IMagicTransitSiteAclLan1
    {
        /// <summary>The identifier for the LAN you want to create an ACL policy with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_acl#lan_id MagicTransitSiteAcl#lan_id}
        /// </remarks>
        [JsiiProperty(name: "lanId", typeJson: "{\"primitive\":\"string\"}")]
        string LanId
        {
            get;
        }

        /// <summary>The name of the LAN based on the provided lan_id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_acl#lan_name MagicTransitSiteAcl#lan_name}
        /// </remarks>
        [JsiiProperty(name: "lanName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LanName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Array of port ranges on the provided LAN that will be included in the ACL.</summary>
        /// <remarks>
        /// If no ports or port rangess are provided, communication on any port on this LAN is allowed.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_acl#port_ranges MagicTransitSiteAcl#port_ranges}
        /// </remarks>
        [JsiiProperty(name: "portRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PortRanges
        {
            get
            {
                return null;
            }
        }

        /// <summary>Array of ports on the provided LAN that will be included in the ACL.</summary>
        /// <remarks>
        /// If no ports or port ranges are provided, communication on any port on this LAN is allowed.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_acl#ports MagicTransitSiteAcl#ports}
        /// </remarks>
        [JsiiProperty(name: "ports", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? Ports
        {
            get
            {
                return null;
            }
        }

        /// <summary>Array of subnet IPs within the LAN that will be included in the ACL.</summary>
        /// <remarks>
        /// If no subnets are provided, communication on any subnets on this LAN are allowed.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_acl#subnets MagicTransitSiteAcl#subnets}
        /// </remarks>
        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Subnets
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicTransitSiteAclLan1), fullyQualifiedName: "cloudflare.magicTransitSiteAcl.MagicTransitSiteAclLan1")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicTransitSiteAcl.IMagicTransitSiteAclLan1
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The identifier for the LAN you want to create an ACL policy with.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_acl#lan_id MagicTransitSiteAcl#lan_id}
            /// </remarks>
            [JsiiProperty(name: "lanId", typeJson: "{\"primitive\":\"string\"}")]
            public string LanId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the LAN based on the provided lan_id.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_acl#lan_name MagicTransitSiteAcl#lan_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lanName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LanName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Array of port ranges on the provided LAN that will be included in the ACL.</summary>
            /// <remarks>
            /// If no ports or port rangess are provided, communication on any port on this LAN is allowed.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_acl#port_ranges MagicTransitSiteAcl#port_ranges}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "portRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PortRanges
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Array of ports on the provided LAN that will be included in the ACL.</summary>
            /// <remarks>
            /// If no ports or port ranges are provided, communication on any port on this LAN is allowed.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_acl#ports MagicTransitSiteAcl#ports}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ports", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? Ports
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Array of subnet IPs within the LAN that will be included in the ACL.</summary>
            /// <remarks>
            /// If no subnets are provided, communication on any subnets on this LAN are allowed.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_acl#subnets MagicTransitSiteAcl#subnets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Subnets
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
