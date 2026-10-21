using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiInterface(nativeType: typeof(IWorkersScriptBindingsRetry), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptBindingsRetry")]
    public interface IWorkersScriptBindingsRetry
    {
        /// <summary>Maximum number of retries after the initial request, not the total number of attempts.</summary>
        /// <remarks>
        /// Defaults to 4. Zero disables retries.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/workers_script#max_attempts WorkersScript#max_attempts}
        /// </remarks>
        [JsiiProperty(name: "maxAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxAttempts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Retry timeout in milliseconds, measured from the start of the call.</summary>
        /// <remarks>
        /// No retry starts after it expires, and a retry still running when it expires is cancelled. This is not a request timeout; it does not limit the initial request, which is still subject to any timeouts set by your Worker. Defaults to 10000.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/workers_script#timeout_ms WorkersScript#timeout_ms}
        /// </remarks>
        [JsiiProperty(name: "timeoutMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeoutMs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkersScriptBindingsRetry), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptBindingsRetry")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersScript.IWorkersScriptBindingsRetry
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Maximum number of retries after the initial request, not the total number of attempts.</summary>
            /// <remarks>
            /// Defaults to 4. Zero disables retries.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/workers_script#max_attempts WorkersScript#max_attempts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxAttempts
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Retry timeout in milliseconds, measured from the start of the call.</summary>
            /// <remarks>
            /// No retry starts after it expires, and a retry still running when it expires is cancelled. This is not a request timeout; it does not limit the initial request, which is still subject to any timeouts set by your Worker. Defaults to 10000.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.1/docs/resources/workers_script#timeout_ms WorkersScript#timeout_ms}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimeoutMs
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
