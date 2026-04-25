using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiByValue(fqn: "cloudflare.workerVersion.WorkerVersionAssetsConfig")]
    public class WorkerVersionAssetsConfig : cloudflare.WorkerVersion.IWorkerVersionAssetsConfig
    {
        /// <summary>Determines the redirects and rewrites of requests for HTML content. Available values: "auto-trailing-slash", "force-trailing-slash", "drop-trailing-slash", "none".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#html_handling WorkerVersion#html_handling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "htmlHandling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HtmlHandling
        {
            get;
            set;
        }

        /// <summary>Determines the response when a request does not match a static asset, and there is no Worker script.</summary>
        /// <remarks>
        /// Available values: "none", "404-page", "single-page-application".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#not_found_handling WorkerVersion#not_found_handling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notFoundHandling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NotFoundHandling
        {
            get;
            set;
        }

        /// <summary>When a boolean true, requests will always invoke the Worker script.</summary>
        /// <remarks>
        /// Otherwise, attempt to serve an asset matching the request, falling back to the Worker script. When a list of strings, contains path rules to control routing to either the Worker or assets. Glob (*) and negative (!) rules are supported. Rules must start with either '/' or '!/'. At least one non-negative rule must be provided, and negative rules have higher precedence than non-negative rules.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#run_worker_first WorkerVersion#run_worker_first}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runWorkerFirst", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, object>? RunWorkerFirst
        {
            get;
            set;
        }
    }
}
