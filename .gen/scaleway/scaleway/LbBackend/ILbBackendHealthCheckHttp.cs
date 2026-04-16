using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbBackend
{
    [JsiiInterface(nativeType: typeof(ILbBackendHealthCheckHttp), fullyQualifiedName: "scaleway.lbBackend.LbBackendHealthCheckHttp")]
    public interface ILbBackendHealthCheckHttp
    {
        /// <summary>The HTTP endpoint URL to call for HC requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#uri LbBackend#uri}
        /// </remarks>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        string Uri
        {
            get;
        }

        /// <summary>The expected HTTP status code.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#code LbBackend#code}
        /// </remarks>
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Code
        {
            get
            {
                return null;
            }
        }

        /// <summary>The HTTP host header to use for HC requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#host_header LbBackend#host_header}
        /// </remarks>
        [JsiiProperty(name: "hostHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>The HTTP method to use for HC requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#method LbBackend#method}
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

        [JsiiTypeProxy(nativeType: typeof(ILbBackendHealthCheckHttp), fullyQualifiedName: "scaleway.lbBackend.LbBackendHealthCheckHttp")]
        internal sealed class _Proxy : DeputyBase, scaleway.LbBackend.ILbBackendHealthCheckHttp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The HTTP endpoint URL to call for HC requests.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#uri LbBackend#uri}
            /// </remarks>
            [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
            public string Uri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The expected HTTP status code.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#code LbBackend#code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Code
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The HTTP host header to use for HC requests.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#host_header LbBackend#host_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostHeader
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The HTTP method to use for HC requests.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#method LbBackend#method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Method
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
