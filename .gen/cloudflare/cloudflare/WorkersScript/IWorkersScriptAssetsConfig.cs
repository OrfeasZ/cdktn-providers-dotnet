using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiInterface(nativeType: typeof(IWorkersScriptAssetsConfig), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptAssetsConfig")]
    public interface IWorkersScriptAssetsConfig
    {
        /// <summary>The contents of a _headers file (used to attach custom headers on asset responses).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#_headers WorkersScript#_headers}
        /// </remarks>
        [JsiiProperty(name: "headers", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Headers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Determines the redirects and rewrites of requests for HTML content. Available values: "auto-trailing-slash", "force-trailing-slash", "drop-trailing-slash", "none".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#html_handling WorkersScript#html_handling}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#not_found_handling WorkersScript#not_found_handling}
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

        /// <summary>The contents of a _redirects file (used to apply redirects or proxy paths ahead of asset serving).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#_redirects WorkersScript#_redirects}
        /// </remarks>
        [JsiiProperty(name: "redirects", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Redirects
        {
            get
            {
                return null;
            }
        }

        /// <summary>When true, requests will always invoke the Worker script.</summary>
        /// <remarks>
        /// Otherwise, attempt to serve an asset matching the request, falling back to the Worker script.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#run_worker_first WorkersScript#run_worker_first}
        /// </remarks>
        [JsiiProperty(name: "runWorkerFirst", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RunWorkerFirst
        {
            get
            {
                return null;
            }
        }

        /// <summary>When true and the incoming request matches an asset, that will be served instead of invoking the Worker script.</summary>
        /// <remarks>
        /// When false, requests will always invoke the Worker script.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#serve_directly WorkersScript#serve_directly}
        /// </remarks>
        [JsiiProperty(name: "serveDirectly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ServeDirectly
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkersScriptAssetsConfig), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptAssetsConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersScript.IWorkersScriptAssetsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The contents of a _headers file (used to attach custom headers on asset responses).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#_headers WorkersScript#_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headers", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Headers
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Determines the redirects and rewrites of requests for HTML content. Available values: "auto-trailing-slash", "force-trailing-slash", "drop-trailing-slash", "none".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#html_handling WorkersScript#html_handling}
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#not_found_handling WorkersScript#not_found_handling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notFoundHandling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NotFoundHandling
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The contents of a _redirects file (used to apply redirects or proxy paths ahead of asset serving).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#_redirects WorkersScript#_redirects}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirects", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Redirects
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>When true, requests will always invoke the Worker script.</summary>
            /// <remarks>
            /// Otherwise, attempt to serve an asset matching the request, falling back to the Worker script.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#run_worker_first WorkersScript#run_worker_first}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runWorkerFirst", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RunWorkerFirst
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When true and the incoming request matches an asset, that will be served instead of invoking the Worker script.</summary>
            /// <remarks>
            /// When false, requests will always invoke the Worker script.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#serve_directly WorkersScript#serve_directly}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serveDirectly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ServeDirectly
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
