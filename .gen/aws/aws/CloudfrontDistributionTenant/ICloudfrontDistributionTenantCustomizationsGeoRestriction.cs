using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistributionTenant
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionTenantCustomizationsGeoRestriction), fullyQualifiedName: "aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsGeoRestriction")]
    public interface ICloudfrontDistributionTenantCustomizationsGeoRestriction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_distribution_tenant#locations CloudfrontDistributionTenant#locations}.</summary>
        [JsiiProperty(name: "locations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Locations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_distribution_tenant#restriction_type CloudfrontDistributionTenant#restriction_type}.</summary>
        [JsiiProperty(name: "restrictionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RestrictionType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionTenantCustomizationsGeoRestriction), fullyQualifiedName: "aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsGeoRestriction")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizationsGeoRestriction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_distribution_tenant#locations CloudfrontDistributionTenant#locations}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "locations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Locations
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_distribution_tenant#restriction_type CloudfrontDistributionTenant#restriction_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "restrictionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RestrictionType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
