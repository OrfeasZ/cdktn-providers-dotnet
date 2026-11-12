using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiInterface(nativeType: typeof(IWorkersScriptCodeUpdateStrategy), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptCodeUpdateStrategy")]
    public interface IWorkersScriptCodeUpdateStrategy
    {
        /// <summary>Apply Durable Object code updates immediately. Available values: "immediate", "deferred".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/workers_script#mode WorkersScript#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>Set the maximum number of seconds to wait before forcing the update. When omitted, the default maximum delay applies.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/workers_script#max_delay WorkersScript#max_delay}
        /// </remarks>
        [JsiiProperty(name: "maxDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxDelay
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkersScriptCodeUpdateStrategy), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptCodeUpdateStrategy")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersScript.IWorkersScriptCodeUpdateStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Apply Durable Object code updates immediately. Available values: "immediate", "deferred".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/workers_script#mode WorkersScript#mode}
            /// </remarks>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Set the maximum number of seconds to wait before forcing the update. When omitted, the default maximum delay applies.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/workers_script#max_delay WorkersScript#max_delay}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxDelay
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
