using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.JobDefinition
{
    [JsiiByValue(fqn: "scaleway.jobDefinition.JobDefinitionRetryPolicy")]
    public class JobDefinitionRetryPolicy : scaleway.JobDefinition.IJobDefinitionRetryPolicy
    {
        /// <summary>The maximum number of retries upon job failure.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.81.0/docs/resources/job_definition#max_retries JobDefinition#max_retries}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxRetries
        {
            get;
            set;
        }
    }
}
