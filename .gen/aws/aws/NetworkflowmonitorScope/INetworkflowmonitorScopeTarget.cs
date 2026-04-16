using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkflowmonitorScope
{
    [JsiiInterface(nativeType: typeof(INetworkflowmonitorScopeTarget), fullyQualifiedName: "aws.networkflowmonitorScope.NetworkflowmonitorScopeTarget")]
    public interface INetworkflowmonitorScopeTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/networkflowmonitor_scope#region NetworkflowmonitorScope#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        /// <summary>target_identifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/networkflowmonitor_scope#target_identifier NetworkflowmonitorScope#target_identifier}
        /// </remarks>
        [JsiiProperty(name: "targetIdentifier", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkflowmonitorScope.NetworkflowmonitorScopeTargetTargetIdentifier\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TargetIdentifier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkflowmonitorScopeTarget), fullyQualifiedName: "aws.networkflowmonitorScope.NetworkflowmonitorScopeTarget")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkflowmonitorScope.INetworkflowmonitorScopeTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/networkflowmonitor_scope#region NetworkflowmonitorScope#region}.</summary>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>target_identifier block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/networkflowmonitor_scope#target_identifier NetworkflowmonitorScope#target_identifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetIdentifier", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkflowmonitorScope.NetworkflowmonitorScopeTargetTargetIdentifier\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TargetIdentifier
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
