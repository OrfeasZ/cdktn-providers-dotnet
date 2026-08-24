using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiInterface(nativeType: typeof(IWorkersScriptBindingsSimple), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptBindingsSimple")]
    public interface IWorkersScriptBindingsSimple
    {
        /// <summary>The rate limit value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/workers_script#limit WorkersScript#limit}
        /// </remarks>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
        double Limit
        {
            get;
        }

        /// <summary>The rate limit period in seconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/workers_script#period WorkersScript#period}
        /// </remarks>
        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}")]
        double Period
        {
            get;
        }

        /// <summary>Duration in seconds to apply the mitigation action after the rate limit is exceeded.</summary>
        /// <remarks>
        /// Valid values are 0 (disabled), 10, or multiples of 60 up to 86400. Must be greater than or equal to the period when non-zero.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/workers_script#mitigation_timeout WorkersScript#mitigation_timeout}
        /// </remarks>
        [JsiiProperty(name: "mitigationTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MitigationTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkersScriptBindingsSimple), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptBindingsSimple")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersScript.IWorkersScriptBindingsSimple
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The rate limit value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/workers_script#limit WorkersScript#limit}
            /// </remarks>
            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
            public double Limit
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The rate limit period in seconds.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/workers_script#period WorkersScript#period}
            /// </remarks>
            [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}")]
            public double Period
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Duration in seconds to apply the mitigation action after the rate limit is exceeded.</summary>
            /// <remarks>
            /// Valid values are 0 (disabled), 10, or multiples of 60 up to 86400. Must be greater than or equal to the period when non-zero.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/workers_script#mitigation_timeout WorkersScript#mitigation_timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mitigationTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MitigationTimeout
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
