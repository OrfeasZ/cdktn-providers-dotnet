using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkflowmonitorScope
{
    [JsiiInterface(nativeType: typeof(INetworkflowmonitorScopeTargetTargetIdentifierTargetId), fullyQualifiedName: "aws.networkflowmonitorScope.NetworkflowmonitorScopeTargetTargetIdentifierTargetId")]
    public interface INetworkflowmonitorScopeTargetTargetIdentifierTargetId
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkflowmonitor_scope#account_id NetworkflowmonitorScope#account_id}.</summary>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkflowmonitorScopeTargetTargetIdentifierTargetId), fullyQualifiedName: "aws.networkflowmonitorScope.NetworkflowmonitorScopeTargetTargetIdentifierTargetId")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkflowmonitorScope.INetworkflowmonitorScopeTargetTargetIdentifierTargetId
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkflowmonitor_scope#account_id NetworkflowmonitorScope#account_id}.</summary>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
