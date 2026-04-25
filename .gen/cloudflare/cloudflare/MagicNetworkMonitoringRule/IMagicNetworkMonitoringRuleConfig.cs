using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicNetworkMonitoringRule
{
    [JsiiInterface(nativeType: typeof(IMagicNetworkMonitoringRuleConfig), fullyQualifiedName: "cloudflare.magicNetworkMonitoringRule.MagicNetworkMonitoringRuleConfig")]
    public interface IMagicNetworkMonitoringRuleConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Toggle on if you would like Cloudflare to automatically advertise the IP Prefixes within the rule via Magic Transit when the rule is triggered.</summary>
        /// <remarks>
        /// Only available for users of Magic Transit.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#automatic_advertisement MagicNetworkMonitoringRule#automatic_advertisement}
        /// </remarks>
        [JsiiProperty(name: "automaticAdvertisement", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object AutomaticAdvertisement
        {
            get;
        }

        /// <summary>The name of the rule.</summary>
        /// <remarks>
        /// Must be unique. Supports characters A-Z, a-z, 0-9, underscore (_), dash (-), period (.), and tilde (~). You can’t have a space in the rule name. Max 256 characters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#name MagicNetworkMonitoringRule#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#prefixes MagicNetworkMonitoringRule#prefixes}.</summary>
        [JsiiProperty(name: "prefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Prefixes
        {
            get;
        }

        /// <summary>MNM rule type. Available values: "threshold", "zscore", "advanced_ddos".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#type MagicNetworkMonitoringRule#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#account_id MagicNetworkMonitoringRule#account_id}.</summary>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of bits per second for the rule.</summary>
        /// <remarks>
        /// When this value is exceeded for the set duration, an alert notification is sent. Minimum of 1 and no maximum.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#bandwidth_threshold MagicNetworkMonitoringRule#bandwidth_threshold}
        /// </remarks>
        [JsiiProperty(name: "bandwidthThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BandwidthThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>The amount of time that the rule threshold must be exceeded to send an alert notification.</summary>
        /// <remarks>
        /// The final value must be equivalent to one of the following 8 values ["1m","5m","10m","15m","20m","30m","45m","60m"].
        /// Available values: "1m", "5m", "10m", "15m", "20m", "30m", "45m", "60m".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#duration MagicNetworkMonitoringRule#duration}
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

        /// <summary>The number of packets per second for the rule.</summary>
        /// <remarks>
        /// When this value is exceeded for the set duration, an alert notification is sent. Minimum of 1 and no maximum.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#packet_threshold MagicNetworkMonitoringRule#packet_threshold}
        /// </remarks>
        [JsiiProperty(name: "packetThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PacketThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Prefix match type to be applied for a prefix auto advertisement when using an advanced_ddos rule.</summary>
        /// <remarks>
        /// Available values: "exact", "subnet", "supernet".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#prefix_match MagicNetworkMonitoringRule#prefix_match}
        /// </remarks>
        [JsiiProperty(name: "prefixMatch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrefixMatch
        {
            get
            {
                return null;
            }
        }

        /// <summary>Level of sensitivity set for zscore rules. Available values: "low", "medium", "high".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#zscore_sensitivity MagicNetworkMonitoringRule#zscore_sensitivity}
        /// </remarks>
        [JsiiProperty(name: "zscoreSensitivity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZscoreSensitivity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Target of the zscore rule analysis. Available values: "bits", "packets".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#zscore_target MagicNetworkMonitoringRule#zscore_target}
        /// </remarks>
        [JsiiProperty(name: "zscoreTarget", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZscoreTarget
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicNetworkMonitoringRuleConfig), fullyQualifiedName: "cloudflare.magicNetworkMonitoringRule.MagicNetworkMonitoringRuleConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicNetworkMonitoringRule.IMagicNetworkMonitoringRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Toggle on if you would like Cloudflare to automatically advertise the IP Prefixes within the rule via Magic Transit when the rule is triggered.</summary>
            /// <remarks>
            /// Only available for users of Magic Transit.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#automatic_advertisement MagicNetworkMonitoringRule#automatic_advertisement}
            /// </remarks>
            [JsiiProperty(name: "automaticAdvertisement", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object AutomaticAdvertisement
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The name of the rule.</summary>
            /// <remarks>
            /// Must be unique. Supports characters A-Z, a-z, 0-9, underscore (_), dash (-), period (.), and tilde (~). You can’t have a space in the rule name. Max 256 characters.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#name MagicNetworkMonitoringRule#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#prefixes MagicNetworkMonitoringRule#prefixes}.</summary>
            [JsiiProperty(name: "prefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Prefixes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>MNM rule type. Available values: "threshold", "zscore", "advanced_ddos".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#type MagicNetworkMonitoringRule#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#account_id MagicNetworkMonitoringRule#account_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of bits per second for the rule.</summary>
            /// <remarks>
            /// When this value is exceeded for the set duration, an alert notification is sent. Minimum of 1 and no maximum.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#bandwidth_threshold MagicNetworkMonitoringRule#bandwidth_threshold}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bandwidthThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BandwidthThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The amount of time that the rule threshold must be exceeded to send an alert notification.</summary>
            /// <remarks>
            /// The final value must be equivalent to one of the following 8 values ["1m","5m","10m","15m","20m","30m","45m","60m"].
            /// Available values: "1m", "5m", "10m", "15m", "20m", "30m", "45m", "60m".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#duration MagicNetworkMonitoringRule#duration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Duration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of packets per second for the rule.</summary>
            /// <remarks>
            /// When this value is exceeded for the set duration, an alert notification is sent. Minimum of 1 and no maximum.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#packet_threshold MagicNetworkMonitoringRule#packet_threshold}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "packetThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PacketThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Prefix match type to be applied for a prefix auto advertisement when using an advanced_ddos rule.</summary>
            /// <remarks>
            /// Available values: "exact", "subnet", "supernet".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#prefix_match MagicNetworkMonitoringRule#prefix_match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prefixMatch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrefixMatch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Level of sensitivity set for zscore rules. Available values: "low", "medium", "high".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#zscore_sensitivity MagicNetworkMonitoringRule#zscore_sensitivity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zscoreSensitivity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZscoreSensitivity
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Target of the zscore rule analysis. Available values: "bits", "packets".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_network_monitoring_rule#zscore_target MagicNetworkMonitoringRule#zscore_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zscoreTarget", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZscoreTarget
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
