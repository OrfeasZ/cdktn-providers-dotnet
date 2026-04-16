using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.MnqSqsQueue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.mnqSqsQueue.MnqSqsQueueDeadLetterQueue")]
    public class MnqSqsQueueDeadLetterQueue : scaleway.MnqSqsQueue.IMnqSqsQueueDeadLetterQueue
    {
        /// <summary>The ID or ARN of the dead-letter queue where messages are sent after the maximum receive count is exceeded.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#id MnqSqsQueue#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>The number of times a message is delivered to the source queue before being sent to the dead-letter queue.</summary>
        /// <remarks>
        /// Must be between 1 and 1,000.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_queue#max_receive_count MnqSqsQueue#max_receive_count}
        /// </remarks>
        [JsiiProperty(name: "maxReceiveCount", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxReceiveCount
        {
            get;
            set;
        }
    }
}
