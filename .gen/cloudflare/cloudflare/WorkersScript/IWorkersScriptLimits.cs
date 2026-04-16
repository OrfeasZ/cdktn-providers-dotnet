using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiInterface(nativeType: typeof(IWorkersScriptLimits), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptLimits")]
    public interface IWorkersScriptLimits
    {
        /// <summary>The amount of CPU time this Worker can use in milliseconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#cpu_ms WorkersScript#cpu_ms}
        /// </remarks>
        [JsiiProperty(name: "cpuMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CpuMs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkersScriptLimits), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptLimits")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersScript.IWorkersScriptLimits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The amount of CPU time this Worker can use in milliseconds.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#cpu_ms WorkersScript#cpu_ms}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cpuMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CpuMs
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
