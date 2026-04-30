using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehavior")]
    public class CloudfrontMultitenantDistributionCacheBehavior : aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehavior
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#path_pattern CloudfrontMultitenantDistribution#path_pattern}.</summary>
        [JsiiProperty(name: "pathPattern", typeJson: "{\"primitive\":\"string\"}")]
        public string PathPattern
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#target_origin_id CloudfrontMultitenantDistribution#target_origin_id}.</summary>
        [JsiiProperty(name: "targetOriginId", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetOriginId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#viewer_protocol_policy CloudfrontMultitenantDistribution#viewer_protocol_policy}.</summary>
        [JsiiProperty(name: "viewerProtocolPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public string ViewerProtocolPolicy
        {
            get;
            set;
        }

        private object? _allowedMethods;

        /// <summary>allowed_methods block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#allowed_methods CloudfrontMultitenantDistribution#allowed_methods}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedMethods", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorAllowedMethods\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AllowedMethods
        {
            get => _allowedMethods;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorAllowedMethods[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorAllowedMethods).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allowedMethods = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#cache_policy_id CloudfrontMultitenantDistribution#cache_policy_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cachePolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CachePolicyId
        {
            get;
            set;
        }

        private object? _compress;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#compress CloudfrontMultitenantDistribution#compress}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Compress
        {
            get => _compress;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _compress = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#field_level_encryption_id CloudfrontMultitenantDistribution#field_level_encryption_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fieldLevelEncryptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FieldLevelEncryptionId
        {
            get;
            set;
        }

        private object? _functionAssociation;

        /// <summary>function_association block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#function_association CloudfrontMultitenantDistribution#function_association}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "functionAssociation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorFunctionAssociation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FunctionAssociation
        {
            get => _functionAssociation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorFunctionAssociation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorFunctionAssociation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _functionAssociation = value;
            }
        }

        private object? _lambdaFunctionAssociation;

        /// <summary>lambda_function_association block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#lambda_function_association CloudfrontMultitenantDistribution#lambda_function_association}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionAssociation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorLambdaFunctionAssociation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LambdaFunctionAssociation
        {
            get => _lambdaFunctionAssociation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorLambdaFunctionAssociation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorLambdaFunctionAssociation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lambdaFunctionAssociation = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#origin_request_policy_id CloudfrontMultitenantDistribution#origin_request_policy_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originRequestPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OriginRequestPolicyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#realtime_log_config_arn CloudfrontMultitenantDistribution#realtime_log_config_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "realtimeLogConfigArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RealtimeLogConfigArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#response_headers_policy_id CloudfrontMultitenantDistribution#response_headers_policy_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseHeadersPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResponseHeadersPolicyId
        {
            get;
            set;
        }

        private object? _trustedKeyGroups;

        /// <summary>trusted_key_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#trusted_key_groups CloudfrontMultitenantDistribution#trusted_key_groups}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trustedKeyGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorTrustedKeyGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TrustedKeyGroups
        {
            get => _trustedKeyGroups;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorTrustedKeyGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorTrustedKeyGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trustedKeyGroups = value;
            }
        }
    }
}
