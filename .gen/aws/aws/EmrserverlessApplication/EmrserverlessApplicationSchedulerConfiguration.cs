using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiByValue(fqn: "aws.emrserverlessApplication.EmrserverlessApplicationSchedulerConfiguration")]
    public class EmrserverlessApplicationSchedulerConfiguration : aws.EmrserverlessApplication.IEmrserverlessApplicationSchedulerConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#max_concurrent_runs EmrserverlessApplication#max_concurrent_runs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentRuns", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConcurrentRuns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#queue_timeout_minutes EmrserverlessApplication#queue_timeout_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queueTimeoutMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? QueueTimeoutMinutes
        {
            get;
            set;
        }
    }
}
