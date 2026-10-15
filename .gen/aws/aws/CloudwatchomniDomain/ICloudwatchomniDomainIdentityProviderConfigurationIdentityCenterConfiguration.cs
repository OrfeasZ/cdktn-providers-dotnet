using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniDomain
{
    [JsiiInterface(nativeType: typeof(ICloudwatchomniDomainIdentityProviderConfigurationIdentityCenterConfiguration), fullyQualifiedName: "aws.cloudwatchomniDomain.CloudwatchomniDomainIdentityProviderConfigurationIdentityCenterConfiguration")]
    public interface ICloudwatchomniDomainIdentityProviderConfigurationIdentityCenterConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.1/docs/resources/cloudwatchomni_domain#identity_center_instance_arn CloudwatchomniDomain#identity_center_instance_arn}.</summary>
        [JsiiProperty(name: "identityCenterInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityCenterInstanceArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchomniDomainIdentityProviderConfigurationIdentityCenterConfiguration), fullyQualifiedName: "aws.cloudwatchomniDomain.CloudwatchomniDomainIdentityProviderConfigurationIdentityCenterConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchomniDomain.ICloudwatchomniDomainIdentityProviderConfigurationIdentityCenterConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.1/docs/resources/cloudwatchomni_domain#identity_center_instance_arn CloudwatchomniDomain#identity_center_instance_arn}.</summary>
            [JsiiProperty(name: "identityCenterInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityCenterInstanceArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
