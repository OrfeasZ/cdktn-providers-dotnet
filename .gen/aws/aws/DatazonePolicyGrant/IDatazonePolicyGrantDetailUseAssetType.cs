using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazonePolicyGrant
{
    [JsiiInterface(nativeType: typeof(IDatazonePolicyGrantDetailUseAssetType), fullyQualifiedName: "aws.datazonePolicyGrant.DatazonePolicyGrantDetailUseAssetType")]
    public interface IDatazonePolicyGrantDetailUseAssetType
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#domain_unit_id DatazonePolicyGrant#domain_unit_id}.</summary>
        [JsiiProperty(name: "domainUnitId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DomainUnitId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatazonePolicyGrantDetailUseAssetType), fullyQualifiedName: "aws.datazonePolicyGrant.DatazonePolicyGrantDetailUseAssetType")]
        internal sealed class _Proxy : DeputyBase, aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailUseAssetType
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#domain_unit_id DatazonePolicyGrant#domain_unit_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domainUnitId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DomainUnitId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
