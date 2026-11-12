using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.workersScript.WorkersScriptCodeUpdateStrategy")]
    public class WorkersScriptCodeUpdateStrategy : cloudflare.WorkersScript.IWorkersScriptCodeUpdateStrategy
    {
        /// <summary>Apply Durable Object code updates immediately. Available values: "immediate", "deferred".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/workers_script#mode WorkersScript#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>Set the maximum number of seconds to wait before forcing the update. When omitted, the default maximum delay applies.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/workers_script#max_delay WorkersScript#max_delay}
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
