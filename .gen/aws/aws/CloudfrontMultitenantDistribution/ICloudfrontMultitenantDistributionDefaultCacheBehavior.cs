using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontMultitenantDistributionDefaultCacheBehavior), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionDefaultCacheBehavior")]
    public interface ICloudfrontMultitenantDistributionDefaultCacheBehavior
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#target_origin_id CloudfrontMultitenantDistribution#target_origin_id}.</summary>
        [JsiiProperty(name: "targetOriginId", typeJson: "{\"primitive\":\"string\"}")]
        string TargetOriginId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#viewer_protocol_policy CloudfrontMultitenantDistribution#viewer_protocol_policy}.</summary>
        [JsiiProperty(name: "viewerProtocolPolicy", typeJson: "{\"primitive\":\"string\"}")]
        string ViewerProtocolPolicy
        {
            get;
        }

        /// <summary>allowed_methods block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#allowed_methods CloudfrontMultitenantDistribution#allowed_methods}
        /// </remarks>
        [JsiiProperty(name: "allowedMethods", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionDefaultCacheBehaviorAllowedMethods\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowedMethods
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#cache_policy_id CloudfrontMultitenantDistribution#cache_policy_id}.</summary>
        [JsiiProperty(name: "cachePolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CachePolicyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#compress CloudfrontMultitenantDistribution#compress}.</summary>
        [JsiiProperty(name: "compress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Compress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#field_level_encryption_id CloudfrontMultitenantDistribution#field_level_encryption_id}.</summary>
        [JsiiProperty(name: "fieldLevelEncryptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FieldLevelEncryptionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>function_association block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#function_association CloudfrontMultitenantDistribution#function_association}
        /// </remarks>
        [JsiiProperty(name: "functionAssociation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionDefaultCacheBehaviorFunctionAssociation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FunctionAssociation
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_function_association block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#lambda_function_association CloudfrontMultitenantDistribution#lambda_function_association}
        /// </remarks>
        [JsiiProperty(name: "lambdaFunctionAssociation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionDefaultCacheBehaviorLambdaFunctionAssociation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LambdaFunctionAssociation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#origin_request_policy_id CloudfrontMultitenantDistribution#origin_request_policy_id}.</summary>
        [JsiiProperty(name: "originRequestPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OriginRequestPolicyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#realtime_log_config_arn CloudfrontMultitenantDistribution#realtime_log_config_arn}.</summary>
        [JsiiProperty(name: "realtimeLogConfigArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RealtimeLogConfigArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#response_headers_policy_id CloudfrontMultitenantDistribution#response_headers_policy_id}.</summary>
        [JsiiProperty(name: "responseHeadersPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResponseHeadersPolicyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>trusted_key_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#trusted_key_groups CloudfrontMultitenantDistribution#trusted_key_groups}
        /// </remarks>
        [JsiiProperty(name: "trustedKeyGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionDefaultCacheBehaviorTrustedKeyGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TrustedKeyGroups
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontMultitenantDistributionDefaultCacheBehavior), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionDefaultCacheBehavior")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionDefaultCacheBehavior
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#target_origin_id CloudfrontMultitenantDistribution#target_origin_id}.</summary>
            [JsiiProperty(name: "targetOriginId", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetOriginId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#viewer_protocol_policy CloudfrontMultitenantDistribution#viewer_protocol_policy}.</summary>
            [JsiiProperty(name: "viewerProtocolPolicy", typeJson: "{\"primitive\":\"string\"}")]
            public string ViewerProtocolPolicy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>allowed_methods block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#allowed_methods CloudfrontMultitenantDistribution#allowed_methods}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedMethods", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionDefaultCacheBehaviorAllowedMethods\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AllowedMethods
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#cache_policy_id CloudfrontMultitenantDistribution#cache_policy_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cachePolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CachePolicyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#compress CloudfrontMultitenantDistribution#compress}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Compress
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#field_level_encryption_id CloudfrontMultitenantDistribution#field_level_encryption_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fieldLevelEncryptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FieldLevelEncryptionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>function_association block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#function_association CloudfrontMultitenantDistribution#function_association}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "functionAssociation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionDefaultCacheBehaviorFunctionAssociation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FunctionAssociation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>lambda_function_association block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#lambda_function_association CloudfrontMultitenantDistribution#lambda_function_association}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaFunctionAssociation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionDefaultCacheBehaviorLambdaFunctionAssociation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LambdaFunctionAssociation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#origin_request_policy_id CloudfrontMultitenantDistribution#origin_request_policy_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "originRequestPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OriginRequestPolicyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#realtime_log_config_arn CloudfrontMultitenantDistribution#realtime_log_config_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "realtimeLogConfigArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RealtimeLogConfigArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#response_headers_policy_id CloudfrontMultitenantDistribution#response_headers_policy_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "responseHeadersPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResponseHeadersPolicyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>trusted_key_groups block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#trusted_key_groups CloudfrontMultitenantDistribution#trusted_key_groups}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trustedKeyGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionDefaultCacheBehaviorTrustedKeyGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TrustedKeyGroups
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
