using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontMultitenantDistributionConfig), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionConfig")]
    public interface ICloudfrontMultitenantDistributionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#comment CloudfrontMultitenantDistribution#comment}.</summary>
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}")]
        string Comment
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#enabled CloudfrontMultitenantDistribution#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>active_trusted_key_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#active_trusted_key_groups CloudfrontMultitenantDistribution#active_trusted_key_groups}
        /// </remarks>
        [JsiiProperty(name: "activeTrustedKeyGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionActiveTrustedKeyGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ActiveTrustedKeyGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>cache_behavior block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#cache_behavior CloudfrontMultitenantDistribution#cache_behavior}
        /// </remarks>
        [JsiiProperty(name: "cacheBehavior", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehavior\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CacheBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_error_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#custom_error_response CloudfrontMultitenantDistribution#custom_error_response}
        /// </remarks>
        [JsiiProperty(name: "customErrorResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCustomErrorResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomErrorResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>default_cache_behavior block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#default_cache_behavior CloudfrontMultitenantDistribution#default_cache_behavior}
        /// </remarks>
        [JsiiProperty(name: "defaultCacheBehavior", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionDefaultCacheBehavior\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DefaultCacheBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#default_root_object CloudfrontMultitenantDistribution#default_root_object}.</summary>
        [JsiiProperty(name: "defaultRootObject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultRootObject
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#http_version CloudfrontMultitenantDistribution#http_version}.</summary>
        [JsiiProperty(name: "httpVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>origin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#origin CloudfrontMultitenantDistribution#origin}
        /// </remarks>
        [JsiiProperty(name: "origin", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOrigin\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Origin
        {
            get
            {
                return null;
            }
        }

        /// <summary>origin_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#origin_group CloudfrontMultitenantDistribution#origin_group}
        /// </remarks>
        [JsiiProperty(name: "originGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OriginGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>restrictions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#restrictions CloudfrontMultitenantDistribution#restrictions}
        /// </remarks>
        [JsiiProperty(name: "restrictions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionRestrictions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Restrictions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#tags CloudfrontMultitenantDistribution#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>tenant_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#tenant_config CloudfrontMultitenantDistribution#tenant_config}
        /// </remarks>
        [JsiiProperty(name: "tenantConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionTenantConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TenantConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#timeouts CloudfrontMultitenantDistribution#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>viewer_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#viewer_certificate CloudfrontMultitenantDistribution#viewer_certificate}
        /// </remarks>
        [JsiiProperty(name: "viewerCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionViewerCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ViewerCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#web_acl_id CloudfrontMultitenantDistribution#web_acl_id}.</summary>
        [JsiiProperty(name: "webAclId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WebAclId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontMultitenantDistributionConfig), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#comment CloudfrontMultitenantDistribution#comment}.</summary>
            [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}")]
            public string Comment
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#enabled CloudfrontMultitenantDistribution#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>active_trusted_key_groups block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#active_trusted_key_groups CloudfrontMultitenantDistribution#active_trusted_key_groups}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "activeTrustedKeyGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionActiveTrustedKeyGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ActiveTrustedKeyGroups
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>cache_behavior block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#cache_behavior CloudfrontMultitenantDistribution#cache_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cacheBehavior", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehavior\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CacheBehavior
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>custom_error_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#custom_error_response CloudfrontMultitenantDistribution#custom_error_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customErrorResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCustomErrorResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomErrorResponse
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>default_cache_behavior block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#default_cache_behavior CloudfrontMultitenantDistribution#default_cache_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultCacheBehavior", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionDefaultCacheBehavior\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DefaultCacheBehavior
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#default_root_object CloudfrontMultitenantDistribution#default_root_object}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultRootObject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultRootObject
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#http_version CloudfrontMultitenantDistribution#http_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>origin block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#origin CloudfrontMultitenantDistribution#origin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "origin", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOrigin\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Origin
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>origin_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#origin_group CloudfrontMultitenantDistribution#origin_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "originGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OriginGroup
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>restrictions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#restrictions CloudfrontMultitenantDistribution#restrictions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "restrictions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionRestrictions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Restrictions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#tags CloudfrontMultitenantDistribution#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>tenant_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#tenant_config CloudfrontMultitenantDistribution#tenant_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tenantConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionTenantConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TenantConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#timeouts CloudfrontMultitenantDistribution#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionTimeouts\"}", isOptional: true)]
            public aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionTimeouts?>();
            }

            /// <summary>viewer_certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#viewer_certificate CloudfrontMultitenantDistribution#viewer_certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "viewerCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionViewerCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ViewerCertificate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#web_acl_id CloudfrontMultitenantDistribution#web_acl_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "webAclId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WebAclId
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
