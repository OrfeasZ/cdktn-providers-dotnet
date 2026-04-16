using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiByValue(fqn: "cloudflare.workersScript.WorkersScriptBindingsOutbound")]
    public class WorkersScriptBindingsOutbound : cloudflare.WorkersScript.IWorkersScriptBindingsOutbound
    {
        /// <summary>Pass information from the Dispatch Worker to the Outbound Worker through the parameters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#params WorkersScript#params}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "params", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Params
        {
            get;
            set;
        }

        /// <summary>Outbound worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#worker WorkersScript#worker}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "worker", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptBindingsOutboundWorker\"}", isOptional: true)]
        public cloudflare.WorkersScript.IWorkersScriptBindingsOutboundWorker? Worker
        {
            get;
            set;
        }
    }
}
