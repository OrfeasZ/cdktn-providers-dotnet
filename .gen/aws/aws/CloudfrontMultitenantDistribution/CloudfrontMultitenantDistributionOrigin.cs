using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOrigin")]
    public class CloudfrontMultitenantDistributionOrigin : aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOrigin
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#domain_name CloudfrontMultitenantDistribution#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#id CloudfrontMultitenantDistribution#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#connection_attempts CloudfrontMultitenantDistribution#connection_attempts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConnectionAttempts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#connection_timeout CloudfrontMultitenantDistribution#connection_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConnectionTimeout
        {
            get;
            set;
        }

        private object? _customHeader;

        /// <summary>custom_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#custom_header CloudfrontMultitenantDistribution#custom_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginCustomHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomHeader
        {
            get => _customHeader;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginCustomHeader[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginCustomHeader).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customHeader = value;
            }
        }

        private object? _customOriginConfig;

        /// <summary>custom_origin_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#custom_origin_config CloudfrontMultitenantDistribution#custom_origin_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customOriginConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginCustomOriginConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomOriginConfig
        {
            get => _customOriginConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginCustomOriginConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginCustomOriginConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customOriginConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#origin_access_control_id CloudfrontMultitenantDistribution#origin_access_control_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originAccessControlId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OriginAccessControlId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#origin_path CloudfrontMultitenantDistribution#origin_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OriginPath
        {
            get;
            set;
        }

        private object? _originShield;

        /// <summary>origin_shield block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#origin_shield CloudfrontMultitenantDistribution#origin_shield}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "originShield", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginOriginShield\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OriginShield
        {
            get => _originShield;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginOriginShield[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginOriginShield).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _originShield = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#response_completion_timeout CloudfrontMultitenantDistribution#response_completion_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseCompletionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ResponseCompletionTimeout
        {
            get;
            set;
        }

        private object? _vpcOriginConfig;

        /// <summary>vpc_origin_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#vpc_origin_config CloudfrontMultitenantDistribution#vpc_origin_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcOriginConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginVpcOriginConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VpcOriginConfig
        {
            get => _vpcOriginConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginVpcOriginConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginVpcOriginConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vpcOriginConfig = value;
            }
        }
    }
}
