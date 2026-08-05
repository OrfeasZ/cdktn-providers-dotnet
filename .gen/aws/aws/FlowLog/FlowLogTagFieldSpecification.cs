using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FlowLog
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.flowLog.FlowLogTagFieldSpecification")]
    public class FlowLogTagFieldSpecification : aws.FlowLog.IFlowLogTagFieldSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/flow_log#resource_type FlowLog#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/flow_log#tag_keys FlowLog#tag_keys}.</summary>
        [JsiiProperty(name: "tagKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] TagKeys
        {
            get;
            set;
        }
    }
}
