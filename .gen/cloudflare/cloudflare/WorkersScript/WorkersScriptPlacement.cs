using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiByValue(fqn: "cloudflare.workersScript.WorkersScriptPlacement")]
    public class WorkersScriptPlacement : cloudflare.WorkersScript.IWorkersScriptPlacement
    {
        /// <summary>Enables [Smart Placement](https://developers.cloudflare.com/workers/configuration/smart-placement).</summary>
        /// <remarks>
        /// Targeted placement mode.
        /// Available values: "smart", "targeted".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/workers_script#mode WorkersScript#mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }
    }
}
