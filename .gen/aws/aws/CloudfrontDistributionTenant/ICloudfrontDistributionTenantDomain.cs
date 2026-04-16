using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistributionTenant
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionTenantDomain), fullyQualifiedName: "aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantDomain")]
    public interface ICloudfrontDistributionTenantDomain
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_distribution_tenant#domain CloudfrontDistributionTenant#domain}.</summary>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        string Domain
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionTenantDomain), fullyQualifiedName: "aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantDomain")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantDomain
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_distribution_tenant#domain CloudfrontDistributionTenant#domain}.</summary>
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
            public string Domain
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
