using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsElasticacheReservedCacheNodeOffering
{
    [JsiiInterface(nativeType: typeof(IDataAwsElasticacheReservedCacheNodeOfferingConfig), fullyQualifiedName: "aws.dataAwsElasticacheReservedCacheNodeOffering.DataAwsElasticacheReservedCacheNodeOfferingConfig")]
    public interface IDataAwsElasticacheReservedCacheNodeOfferingConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/elasticache_reserved_cache_node_offering#cache_node_type DataAwsElasticacheReservedCacheNodeOffering#cache_node_type}.</summary>
        [JsiiProperty(name: "cacheNodeType", typeJson: "{\"primitive\":\"string\"}")]
        string CacheNodeType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/elasticache_reserved_cache_node_offering#duration DataAwsElasticacheReservedCacheNodeOffering#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
        string Duration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/elasticache_reserved_cache_node_offering#offering_type DataAwsElasticacheReservedCacheNodeOffering#offering_type}.</summary>
        [JsiiProperty(name: "offeringType", typeJson: "{\"primitive\":\"string\"}")]
        string OfferingType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/elasticache_reserved_cache_node_offering#product_description DataAwsElasticacheReservedCacheNodeOffering#product_description}.</summary>
        [JsiiProperty(name: "productDescription", typeJson: "{\"primitive\":\"string\"}")]
        string ProductDescription
        {
            get;
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/elasticache_reserved_cache_node_offering#region DataAwsElasticacheReservedCacheNodeOffering#region}
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

        [JsiiTypeProxy(nativeType: typeof(IDataAwsElasticacheReservedCacheNodeOfferingConfig), fullyQualifiedName: "aws.dataAwsElasticacheReservedCacheNodeOffering.DataAwsElasticacheReservedCacheNodeOfferingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsElasticacheReservedCacheNodeOffering.IDataAwsElasticacheReservedCacheNodeOfferingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/elasticache_reserved_cache_node_offering#cache_node_type DataAwsElasticacheReservedCacheNodeOffering#cache_node_type}.</summary>
            [JsiiProperty(name: "cacheNodeType", typeJson: "{\"primitive\":\"string\"}")]
            public string CacheNodeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/elasticache_reserved_cache_node_offering#duration DataAwsElasticacheReservedCacheNodeOffering#duration}.</summary>
            [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
            public string Duration
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/elasticache_reserved_cache_node_offering#offering_type DataAwsElasticacheReservedCacheNodeOffering#offering_type}.</summary>
            [JsiiProperty(name: "offeringType", typeJson: "{\"primitive\":\"string\"}")]
            public string OfferingType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/elasticache_reserved_cache_node_offering#product_description DataAwsElasticacheReservedCacheNodeOffering#product_description}.</summary>
            [JsiiProperty(name: "productDescription", typeJson: "{\"primitive\":\"string\"}")]
            public string ProductDescription
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/elasticache_reserved_cache_node_offering#region DataAwsElasticacheReservedCacheNodeOffering#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
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
