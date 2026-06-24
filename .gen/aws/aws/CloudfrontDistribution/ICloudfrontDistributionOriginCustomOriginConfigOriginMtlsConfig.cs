using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionOriginCustomOriginConfigOriginMtlsConfig), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionOriginCustomOriginConfigOriginMtlsConfig")]
    public interface ICloudfrontDistributionOriginCustomOriginConfigOriginMtlsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/cloudfront_distribution#client_certificate_arn CloudfrontDistribution#client_certificate_arn}.</summary>
        [JsiiProperty(name: "clientCertificateArn", typeJson: "{\"primitive\":\"string\"}")]
        string ClientCertificateArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionOriginCustomOriginConfigOriginMtlsConfig), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionOriginCustomOriginConfigOriginMtlsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontDistribution.ICloudfrontDistributionOriginCustomOriginConfigOriginMtlsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/cloudfront_distribution#client_certificate_arn CloudfrontDistribution#client_certificate_arn}.</summary>
            [JsiiProperty(name: "clientCertificateArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientCertificateArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
