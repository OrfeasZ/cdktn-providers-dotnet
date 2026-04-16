using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketWebsiteConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketWebsiteConfigurationConfig), fullyQualifiedName: "aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationConfig")]
    public interface IS3BucketWebsiteConfigurationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3_bucket_website_configuration#bucket S3BucketWebsiteConfiguration#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>error_document block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3_bucket_website_configuration#error_document S3BucketWebsiteConfiguration#error_document}
        /// </remarks>
        [JsiiProperty(name: "errorDocument", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationErrorDocument\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationErrorDocument? ErrorDocument
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3_bucket_website_configuration#expected_bucket_owner S3BucketWebsiteConfiguration#expected_bucket_owner}.</summary>
        [JsiiProperty(name: "expectedBucketOwner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExpectedBucketOwner
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3_bucket_website_configuration#id S3BucketWebsiteConfiguration#id}.</summary>
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

        /// <summary>index_document block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3_bucket_website_configuration#index_document S3BucketWebsiteConfiguration#index_document}
        /// </remarks>
        [JsiiProperty(name: "indexDocument", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationIndexDocument\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationIndexDocument? IndexDocument
        {
            get
            {
                return null;
            }
        }

        /// <summary>redirect_all_requests_to block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3_bucket_website_configuration#redirect_all_requests_to S3BucketWebsiteConfiguration#redirect_all_requests_to}
        /// </remarks>
        [JsiiProperty(name: "redirectAllRequestsTo", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRedirectAllRequestsTo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRedirectAllRequestsTo? RedirectAllRequestsTo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3_bucket_website_configuration#region S3BucketWebsiteConfiguration#region}
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

        /// <summary>routing_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3_bucket_website_configuration#routing_rule S3BucketWebsiteConfiguration#routing_rule}
        /// </remarks>
        [JsiiProperty(name: "routingRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RoutingRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3_bucket_website_configuration#routing_rules S3BucketWebsiteConfiguration#routing_rules}.</summary>
        [JsiiProperty(name: "routingRules", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoutingRules
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketWebsiteConfigurationConfig), fullyQualifiedName: "aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3_bucket_website_configuration#bucket S3BucketWebsiteConfiguration#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>error_document block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3_bucket_website_configuration#error_document S3BucketWebsiteConfiguration#error_document}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "errorDocument", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationErrorDocument\"}", isOptional: true)]
            public aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationErrorDocument? ErrorDocument
            {
                get => GetInstanceProperty<aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationErrorDocument?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3_bucket_website_configuration#expected_bucket_owner S3BucketWebsiteConfiguration#expected_bucket_owner}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expectedBucketOwner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExpectedBucketOwner
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3_bucket_website_configuration#id S3BucketWebsiteConfiguration#id}.</summary>
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

            /// <summary>index_document block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3_bucket_website_configuration#index_document S3BucketWebsiteConfiguration#index_document}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "indexDocument", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationIndexDocument\"}", isOptional: true)]
            public aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationIndexDocument? IndexDocument
            {
                get => GetInstanceProperty<aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationIndexDocument?>();
            }

            /// <summary>redirect_all_requests_to block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3_bucket_website_configuration#redirect_all_requests_to S3BucketWebsiteConfiguration#redirect_all_requests_to}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirectAllRequestsTo", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRedirectAllRequestsTo\"}", isOptional: true)]
            public aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRedirectAllRequestsTo? RedirectAllRequestsTo
            {
                get => GetInstanceProperty<aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRedirectAllRequestsTo?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3_bucket_website_configuration#region S3BucketWebsiteConfiguration#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>routing_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3_bucket_website_configuration#routing_rule S3BucketWebsiteConfiguration#routing_rule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routingRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RoutingRule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3_bucket_website_configuration#routing_rules S3BucketWebsiteConfiguration#routing_rules}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "routingRules", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoutingRules
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
