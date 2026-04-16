using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiByValue(fqn: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionRestrictions")]
    public class CloudfrontMultitenantDistributionRestrictions : aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionRestrictions
    {
        private object? _geoRestriction;

        /// <summary>geo_restriction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_multitenant_distribution#geo_restriction CloudfrontMultitenantDistribution#geo_restriction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "geoRestriction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionRestrictionsGeoRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GeoRestriction
        {
            get => _geoRestriction;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionRestrictionsGeoRestriction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionRestrictionsGeoRestriction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _geoRestriction = value;
            }
        }
    }
}
