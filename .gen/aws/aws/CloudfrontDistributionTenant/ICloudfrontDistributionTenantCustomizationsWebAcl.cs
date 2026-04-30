using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistributionTenant
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionTenantCustomizationsWebAcl), fullyQualifiedName: "aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsWebAcl")]
    public interface ICloudfrontDistributionTenantCustomizationsWebAcl
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_distribution_tenant#action CloudfrontDistributionTenant#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_distribution_tenant#arn CloudfrontDistributionTenant#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Arn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionTenantCustomizationsWebAcl), fullyQualifiedName: "aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsWebAcl")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizationsWebAcl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_distribution_tenant#action CloudfrontDistributionTenant#action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_distribution_tenant#arn CloudfrontDistributionTenant#arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Arn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
