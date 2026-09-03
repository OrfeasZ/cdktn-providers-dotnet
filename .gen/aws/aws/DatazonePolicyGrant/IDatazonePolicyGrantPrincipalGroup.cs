using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazonePolicyGrant
{
    [JsiiInterface(nativeType: typeof(IDatazonePolicyGrantPrincipalGroup), fullyQualifiedName: "aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalGroup")]
    public interface IDatazonePolicyGrantPrincipalGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#group_identifier DatazonePolicyGrant#group_identifier}.</summary>
        [JsiiProperty(name: "groupIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string GroupIdentifier
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatazonePolicyGrantPrincipalGroup), fullyQualifiedName: "aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalGroup")]
        internal sealed class _Proxy : DeputyBase, aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#group_identifier DatazonePolicyGrant#group_identifier}.</summary>
            [JsiiProperty(name: "groupIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string GroupIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
