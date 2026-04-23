using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontMultitenantDistributionOrigin), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOrigin")]
    public interface ICloudfrontMultitenantDistributionOrigin
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#domain_name CloudfrontMultitenantDistribution#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        string DomainName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#id CloudfrontMultitenantDistribution#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#connection_attempts CloudfrontMultitenantDistribution#connection_attempts}.</summary>
        [JsiiProperty(name: "connectionAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConnectionAttempts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#connection_timeout CloudfrontMultitenantDistribution#connection_timeout}.</summary>
        [JsiiProperty(name: "connectionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConnectionTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#custom_header CloudfrontMultitenantDistribution#custom_header}
        /// </remarks>
        [JsiiProperty(name: "customHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginCustomHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_origin_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#custom_origin_config CloudfrontMultitenantDistribution#custom_origin_config}
        /// </remarks>
        [JsiiProperty(name: "customOriginConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginCustomOriginConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomOriginConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#origin_access_control_id CloudfrontMultitenantDistribution#origin_access_control_id}.</summary>
        [JsiiProperty(name: "originAccessControlId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OriginAccessControlId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#origin_path CloudfrontMultitenantDistribution#origin_path}.</summary>
        [JsiiProperty(name: "originPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OriginPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>origin_shield block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#origin_shield CloudfrontMultitenantDistribution#origin_shield}
        /// </remarks>
        [JsiiProperty(name: "originShield", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginOriginShield\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OriginShield
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#response_completion_timeout CloudfrontMultitenantDistribution#response_completion_timeout}.</summary>
        [JsiiProperty(name: "responseCompletionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ResponseCompletionTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc_origin_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#vpc_origin_config CloudfrontMultitenantDistribution#vpc_origin_config}
        /// </remarks>
        [JsiiProperty(name: "vpcOriginConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginVpcOriginConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VpcOriginConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontMultitenantDistributionOrigin), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOrigin")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOrigin
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#domain_name CloudfrontMultitenantDistribution#domain_name}.</summary>
            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#id CloudfrontMultitenantDistribution#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#connection_attempts CloudfrontMultitenantDistribution#connection_attempts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConnectionAttempts
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#connection_timeout CloudfrontMultitenantDistribution#connection_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConnectionTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>custom_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#custom_header CloudfrontMultitenantDistribution#custom_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginCustomHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomHeader
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>custom_origin_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#custom_origin_config CloudfrontMultitenantDistribution#custom_origin_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customOriginConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginCustomOriginConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomOriginConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#origin_access_control_id CloudfrontMultitenantDistribution#origin_access_control_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "originAccessControlId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OriginAccessControlId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#origin_path CloudfrontMultitenantDistribution#origin_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "originPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OriginPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>origin_shield block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#origin_shield CloudfrontMultitenantDistribution#origin_shield}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "originShield", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginOriginShield\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OriginShield
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#response_completion_timeout CloudfrontMultitenantDistribution#response_completion_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "responseCompletionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ResponseCompletionTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>vpc_origin_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#vpc_origin_config CloudfrontMultitenantDistribution#vpc_origin_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpcOriginConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginVpcOriginConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VpcOriginConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
