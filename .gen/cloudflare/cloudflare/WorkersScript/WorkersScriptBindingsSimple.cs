using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.workersScript.WorkersScriptBindingsSimple")]
    public class WorkersScriptBindingsSimple : cloudflare.WorkersScript.IWorkersScriptBindingsSimple
    {
        /// <summary>The rate limit value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#limit WorkersScript#limit}
        /// </remarks>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
        public double Limit
        {
            get;
            set;
        }

        /// <summary>The rate limit period in seconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#period WorkersScript#period}
        /// </remarks>
        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}")]
        public double Period
        {
            get;
            set;
        }
    }
}
