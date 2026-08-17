using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.JobDefinition
{
    [JsiiInterface(nativeType: typeof(IJobDefinitionRetryPolicy), fullyQualifiedName: "scaleway.jobDefinition.JobDefinitionRetryPolicy")]
    public interface IJobDefinitionRetryPolicy
    {
        /// <summary>The maximum number of retries upon job failure.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.81.0/docs/resources/job_definition#max_retries JobDefinition#max_retries}
        /// </remarks>
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxRetries
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJobDefinitionRetryPolicy), fullyQualifiedName: "scaleway.jobDefinition.JobDefinitionRetryPolicy")]
        internal sealed class _Proxy : DeputyBase, scaleway.JobDefinition.IJobDefinitionRetryPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The maximum number of retries upon job failure.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.81.0/docs/resources/job_definition#max_retries JobDefinition#max_retries}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxRetries
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
