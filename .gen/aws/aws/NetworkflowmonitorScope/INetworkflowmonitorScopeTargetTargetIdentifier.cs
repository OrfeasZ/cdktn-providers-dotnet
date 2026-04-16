using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkflowmonitorScope
{
    [JsiiInterface(nativeType: typeof(INetworkflowmonitorScopeTargetTargetIdentifier), fullyQualifiedName: "aws.networkflowmonitorScope.NetworkflowmonitorScopeTargetTargetIdentifier")]
    public interface INetworkflowmonitorScopeTargetTargetIdentifier
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/networkflowmonitor_scope#target_type NetworkflowmonitorScope#target_type}.</summary>
        [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}")]
        string TargetType
        {
            get;
        }

        /// <summary>target_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/networkflowmonitor_scope#target_id NetworkflowmonitorScope#target_id}
        /// </remarks>
        [JsiiProperty(name: "targetId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkflowmonitorScope.NetworkflowmonitorScopeTargetTargetIdentifierTargetId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TargetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkflowmonitorScopeTargetTargetIdentifier), fullyQualifiedName: "aws.networkflowmonitorScope.NetworkflowmonitorScopeTargetTargetIdentifier")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkflowmonitorScope.INetworkflowmonitorScopeTargetTargetIdentifier
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/networkflowmonitor_scope#target_type NetworkflowmonitorScope#target_type}.</summary>
            [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>target_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/networkflowmonitor_scope#target_id NetworkflowmonitorScope#target_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkflowmonitorScope.NetworkflowmonitorScopeTargetTargetIdentifierTargetId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TargetId
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
