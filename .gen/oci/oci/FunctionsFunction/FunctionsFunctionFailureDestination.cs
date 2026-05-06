using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsFunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.functionsFunction.FunctionsFunctionFailureDestination")]
    public class FunctionsFunctionFailureDestination : oci.FunctionsFunction.IFunctionsFunctionFailureDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#kind FunctionsFunction#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#channel_id FunctionsFunction#channel_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "channelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ChannelId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#queue_id FunctionsFunction#queue_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queueId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QueueId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#stream_id FunctionsFunction#stream_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "streamId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StreamId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#topic_id FunctionsFunction#topic_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "topicId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TopicId
        {
            get;
            set;
        }
    }
}
