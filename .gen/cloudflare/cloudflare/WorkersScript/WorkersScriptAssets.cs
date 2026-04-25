using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiByValue(fqn: "cloudflare.workersScript.WorkersScriptAssets")]
    public class WorkersScriptAssets : cloudflare.WorkersScript.IWorkersScriptAssets
    {
        /// <summary>Configuration for assets within a Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#config WorkersScript#config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptAssetsConfig\"}", isOptional: true)]
        public cloudflare.WorkersScript.IWorkersScriptAssetsConfig? Config
        {
            get;
            set;
        }

        /// <summary>Path to the directory containing asset files to upload.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#directory WorkersScript#directory}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "directory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Directory
        {
            get;
            set;
        }

        /// <summary>Token provided upon successful upload of all files from a registered manifest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#jwt WorkersScript#jwt}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jwt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Jwt
        {
            get;
            set;
        }
    }
}
