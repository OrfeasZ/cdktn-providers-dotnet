using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistributionTenant
{
    [JsiiByValue(fqn: "aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsGeoRestriction")]
    public class CloudfrontDistributionTenantCustomizationsGeoRestriction : aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizationsGeoRestriction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution_tenant#locations CloudfrontDistributionTenant#locations}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "locations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Locations
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution_tenant#restriction_type CloudfrontDistributionTenant#restriction_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "restrictionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RestrictionType
        {
            get;
            set;
        }
    }
}
