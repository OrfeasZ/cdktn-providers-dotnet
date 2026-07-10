using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.workersScript.WorkersScriptExports")]
    public class WorkersScriptExports : cloudflare.WorkersScript.IWorkersScriptExports
    {
        /// <summary>The kind of entrypoint. A `type: worker` entry overrides the top-level `cache_options` for this specific entrypoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/workers_script#type WorkersScript#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Per-entrypoint cache override. When present, this overrides the top-level `cache_options` for this specific entrypoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/workers_script#cache WorkersScript#cache}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptExportsCache\"}", isOptional: true)]
        public cloudflare.WorkersScript.IWorkersScriptExportsCache? Cache
        {
            get;
            set;
        }
    }
}
