using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDomainSettingsTrustedIdentityPropagationSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDomainSettingsTrustedIdentityPropagationSettings")]
    public interface ISagemakerDomainDomainSettingsTrustedIdentityPropagationSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#status SagemakerDomain#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDomainSettingsTrustedIdentityPropagationSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDomainSettingsTrustedIdentityPropagationSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDomain.ISagemakerDomainDomainSettingsTrustedIdentityPropagationSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_domain#status SagemakerDomain#status}.</summary>
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
            public string Status
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
