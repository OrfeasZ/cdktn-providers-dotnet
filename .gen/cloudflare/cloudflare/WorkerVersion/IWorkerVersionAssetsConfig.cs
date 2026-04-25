using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiInterface(nativeType: typeof(IWorkerVersionAssetsConfig), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionAssetsConfig")]
    public interface IWorkerVersionAssetsConfig
    {
        /// <summary>Determines the redirects and rewrites of requests for HTML content. Available values: "auto-trailing-slash", "force-trailing-slash", "drop-trailing-slash", "none".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#html_handling WorkerVersion#html_handling}
        /// </remarks>
        [JsiiProperty(name: "htmlHandling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HtmlHandling
        {
            get
            {
                return null;
            }
        }

        /// <summary>Determines the response when a request does not match a static asset, and there is no Worker script.</summary>
        /// <remarks>
        /// Available values: "none", "404-page", "single-page-application".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#not_found_handling WorkerVersion#not_found_handling}
        /// </remarks>
        [JsiiProperty(name: "notFoundHandling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NotFoundHandling
        {
            get
            {
                return null;
            }
        }

        /// <summary>When a boolean true, requests will always invoke the Worker script.</summary>
        /// <remarks>
        /// Otherwise, attempt to serve an asset matching the request, falling back to the Worker script. When a list of strings, contains path rules to control routing to either the Worker or assets. Glob (*) and negative (!) rules are supported. Rules must start with either '/' or '!/'. At least one non-negative rule must be provided, and negative rules have higher precedence than non-negative rules.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#run_worker_first WorkerVersion#run_worker_first}
        /// </remarks>
        [JsiiProperty(name: "runWorkerFirst", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, object>? RunWorkerFirst
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerVersionAssetsConfig), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionAssetsConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkerVersion.IWorkerVersionAssetsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Determines the redirects and rewrites of requests for HTML content. Available values: "auto-trailing-slash", "force-trailing-slash", "drop-trailing-slash", "none".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#html_handling WorkerVersion#html_handling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "htmlHandling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HtmlHandling
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, object>?>();
            }
        }
    }
}
