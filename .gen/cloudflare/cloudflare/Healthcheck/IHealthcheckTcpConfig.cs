using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Healthcheck
{
    [JsiiInterface(nativeType: typeof(IHealthcheckTcpConfig), fullyQualifiedName: "cloudflare.healthcheck.HealthcheckTcpConfig")]
    public interface IHealthcheckTcpConfig
    {
        /// <summary>The TCP connection method to use for the health check. Available values: "connection_established".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/healthcheck#method Healthcheck#method}
        /// </remarks>
        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Method
        {
            get
            {
                return null;
            }
        }

        /// <summary>Port number to connect to for the health check. Defaults to 80.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/healthcheck#port Healthcheck#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHealthcheckTcpConfig), fullyQualifiedName: "cloudflare.healthcheck.HealthcheckTcpConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Healthcheck.IHealthcheckTcpConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The TCP connection method to use for the health check. Available values: "connection_established".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/healthcheck#method Healthcheck#method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Method
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Port number to connect to for the health check. Defaults to 80.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/healthcheck#port Healthcheck#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
