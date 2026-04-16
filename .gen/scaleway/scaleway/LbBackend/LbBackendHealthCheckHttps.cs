using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbBackend
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.lbBackend.LbBackendHealthCheckHttps")]
    public class LbBackendHealthCheckHttps : scaleway.LbBackend.ILbBackendHealthCheckHttps
    {
        /// <summary>The HTTPS endpoint URL to call for HC requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#uri LbBackend#uri}
        /// </remarks>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public string Uri
        {
            get;
            set;
        }

        /// <summary>The expected HTTP status code.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#code LbBackend#code}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Code
        {
            get;
            set;
        }

        /// <summary>The HTTP host header to use for HC requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#host_header LbBackend#host_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostHeader
        {
            get;
            set;
        }

        /// <summary>The HTTP method to use for HC requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#method LbBackend#method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Method
        {
            get;
            set;
        }

        /// <summary>The SNI to use for HC requests over SSL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_backend#sni LbBackend#sni}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sni", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Sni
        {
            get;
            set;
        }
    }
}
