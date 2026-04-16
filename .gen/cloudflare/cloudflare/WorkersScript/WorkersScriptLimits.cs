using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiByValue(fqn: "cloudflare.workersScript.WorkersScriptLimits")]
    public class WorkersScriptLimits : cloudflare.WorkersScript.IWorkersScriptLimits
    {
        /// <summary>The amount of CPU time this Worker can use in milliseconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#cpu_ms WorkersScript#cpu_ms}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cpuMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CpuMs
        {
            get;
            set;
        }
    }
}
