using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontMultitenantDistributionOriginGroupFailoverCriteria), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginGroupFailoverCriteria")]
    public interface ICloudfrontMultitenantDistributionOriginGroupFailoverCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#status_codes CloudfrontMultitenantDistribution#status_codes}.</summary>
        [JsiiProperty(name: "statusCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        double[] StatusCodes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontMultitenantDistributionOriginGroupFailoverCriteria), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginGroupFailoverCriteria")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginGroupFailoverCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#status_codes CloudfrontMultitenantDistribution#status_codes}.</summary>
            [JsiiProperty(name: "statusCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
            public double[] StatusCodes
            {
                get => GetInstanceProperty<double[]>()!;
            }
        }
    }
}
