using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.workersDeployment.WorkersDeploymentCodeUpdateStrategy")]
    public class WorkersDeploymentCodeUpdateStrategy : cloudflare.WorkersDeployment.IWorkersDeploymentCodeUpdateStrategy
    {
        /// <summary>For `mode: immediate`: Apply Durable Object code updates immediately.</summary>
        /// <remarks>
        /// For <c>mode: deferred</c>: Allow active Durable Objects to hibernate before updating their code.
        /// Available values: "immediate", "deferred".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/workers_deployment#mode WorkersDeployment#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>For `mode: deferred`: Set the maximum number of seconds to wait before forcing the update.</summary>
        /// <remarks>
        /// When omitted, the default maximum delay applies.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/workers_deployment#max_delay WorkersDeployment#max_delay}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxDelay
        {
            get;
            set;
        }
    }
}
