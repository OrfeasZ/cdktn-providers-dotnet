using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailDistribution
{
    [JsiiInterface(nativeType: typeof(ILightsailDistributionConfig), fullyQualifiedName: "aws.lightsailDistribution.LightsailDistributionConfig")]
    public interface ILightsailDistributionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The bundle ID to use for the distribution.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#bundle_id LightsailDistribution#bundle_id}
        /// </remarks>
        [JsiiProperty(name: "bundleId", typeJson: "{\"primitive\":\"string\"}")]
        string BundleId
        {
            get;
        }

        /// <summary>default_cache_behavior block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#default_cache_behavior LightsailDistribution#default_cache_behavior}
        /// </remarks>
        [JsiiProperty(name: "defaultCacheBehavior", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionDefaultCacheBehavior\"}")]
        aws.LightsailDistribution.ILightsailDistributionDefaultCacheBehavior DefaultCacheBehavior
        {
            get;
        }

        /// <summary>The name of the distribution.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#name LightsailDistribution#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>origin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#origin LightsailDistribution#origin}
        /// </remarks>
        [JsiiProperty(name: "origin", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionOrigin\"}")]
        aws.LightsailDistribution.ILightsailDistributionOrigin Origin
        {
            get;
        }

        /// <summary>cache_behavior block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#cache_behavior LightsailDistribution#cache_behavior}
        /// </remarks>
        [JsiiProperty(name: "cacheBehavior", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehavior\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CacheBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>cache_behavior_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#cache_behavior_settings LightsailDistribution#cache_behavior_settings}
        /// </remarks>
        [JsiiProperty(name: "cacheBehaviorSettings", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettings? CacheBehaviorSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the SSL/TLS certificate attached to the distribution, if any.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#certificate_name LightsailDistribution#certificate_name}
        /// </remarks>
        [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#id LightsailDistribution#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>The IP address type of the distribution.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#ip_address_type LightsailDistribution#ip_address_type}
        /// </remarks>
        [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpAddressType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates whether the distribution is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#is_enabled LightsailDistribution#is_enabled}
        /// </remarks>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#region LightsailDistribution#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#tags LightsailDistribution#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#tags_all LightsailDistribution#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#timeouts LightsailDistribution#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LightsailDistribution.ILightsailDistributionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILightsailDistributionConfig), fullyQualifiedName: "aws.lightsailDistribution.LightsailDistributionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LightsailDistribution.ILightsailDistributionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The bundle ID to use for the distribution.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#bundle_id LightsailDistribution#bundle_id}
            /// </remarks>
            [JsiiProperty(name: "bundleId", typeJson: "{\"primitive\":\"string\"}")]
            public string BundleId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>default_cache_behavior block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#default_cache_behavior LightsailDistribution#default_cache_behavior}
            /// </remarks>
            [JsiiProperty(name: "defaultCacheBehavior", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionDefaultCacheBehavior\"}")]
            public aws.LightsailDistribution.ILightsailDistributionDefaultCacheBehavior DefaultCacheBehavior
            {
                get => GetInstanceProperty<aws.LightsailDistribution.ILightsailDistributionDefaultCacheBehavior>()!;
            }

            /// <summary>The name of the distribution.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#name LightsailDistribution#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>origin block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#origin LightsailDistribution#origin}
            /// </remarks>
            [JsiiProperty(name: "origin", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionOrigin\"}")]
            public aws.LightsailDistribution.ILightsailDistributionOrigin Origin
            {
                get => GetInstanceProperty<aws.LightsailDistribution.ILightsailDistributionOrigin>()!;
            }

            /// <summary>cache_behavior block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#cache_behavior LightsailDistribution#cache_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cacheBehavior", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehavior\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CacheBehavior
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>cache_behavior_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#cache_behavior_settings LightsailDistribution#cache_behavior_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cacheBehaviorSettings", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettings\"}", isOptional: true)]
            public aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettings? CacheBehaviorSettings
            {
                get => GetInstanceProperty<aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettings?>();
            }

            /// <summary>The name of the SSL/TLS certificate attached to the distribution, if any.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#certificate_name LightsailDistribution#certificate_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#id LightsailDistribution#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The IP address type of the distribution.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#ip_address_type LightsailDistribution#ip_address_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpAddressType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicates whether the distribution is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#is_enabled LightsailDistribution#is_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#region LightsailDistribution#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#tags LightsailDistribution#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#tags_all LightsailDistribution#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsAll
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lightsail_distribution#timeouts LightsailDistribution#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionTimeouts\"}", isOptional: true)]
            public aws.LightsailDistribution.ILightsailDistributionTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.LightsailDistribution.ILightsailDistributionTimeouts?>();
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
