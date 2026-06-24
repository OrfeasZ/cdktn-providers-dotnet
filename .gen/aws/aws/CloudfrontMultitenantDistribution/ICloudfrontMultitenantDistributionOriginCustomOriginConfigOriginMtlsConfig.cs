using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontMultitenantDistributionOriginCustomOriginConfigOriginMtlsConfig), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginCustomOriginConfigOriginMtlsConfig")]
    public interface ICloudfrontMultitenantDistributionOriginCustomOriginConfigOriginMtlsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/cloudfront_multitenant_distribution#client_certificate_arn CloudfrontMultitenantDistribution#client_certificate_arn}.</summary>
        [JsiiProperty(name: "clientCertificateArn", typeJson: "{\"primitive\":\"string\"}")]
        string ClientCertificateArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontMultitenantDistributionOriginCustomOriginConfigOriginMtlsConfig), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginCustomOriginConfigOriginMtlsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginCustomOriginConfigOriginMtlsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/cloudfront_multitenant_distribution#client_certificate_arn CloudfrontMultitenantDistribution#client_certificate_arn}.</summary>
            [JsiiProperty(name: "clientCertificateArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientCertificateArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
