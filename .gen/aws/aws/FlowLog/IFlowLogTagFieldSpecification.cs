using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FlowLog
{
    [JsiiInterface(nativeType: typeof(IFlowLogTagFieldSpecification), fullyQualifiedName: "aws.flowLog.FlowLogTagFieldSpecification")]
    public interface IFlowLogTagFieldSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/flow_log#resource_type FlowLog#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/flow_log#tag_keys FlowLog#tag_keys}.</summary>
        [JsiiProperty(name: "tagKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] TagKeys
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFlowLogTagFieldSpecification), fullyQualifiedName: "aws.flowLog.FlowLogTagFieldSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.FlowLog.IFlowLogTagFieldSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/flow_log#resource_type FlowLog#resource_type}.</summary>
            [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/flow_log#tag_keys FlowLog#tag_keys}.</summary>
            [JsiiProperty(name: "tagKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] TagKeys
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
