using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiInterface(nativeType: typeof(IWaasWaasPolicyOrigins), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyOrigins")]
    public interface IWaasWaasPolicyOrigins
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#label WaasWaasPolicy#label}.</summary>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}")]
        string Label
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#uri WaasWaasPolicy#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        string Uri
        {
            get;
        }

        /// <summary>custom_headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#custom_headers WaasWaasPolicy#custom_headers}
        /// </remarks>
        [JsiiProperty(name: "customHeaders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyOriginsCustomHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#http_port WaasWaasPolicy#http_port}.</summary>
        [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#https_port WaasWaasPolicy#https_port}.</summary>
        [JsiiProperty(name: "httpsPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpsPort
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWaasWaasPolicyOrigins), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyOrigins")]
        internal sealed class _Proxy : DeputyBase, oci.WaasWaasPolicy.IWaasWaasPolicyOrigins
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#label WaasWaasPolicy#label}.</summary>
            [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}")]
            public string Label
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#uri WaasWaasPolicy#uri}.</summary>
            [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
            public string Uri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>custom_headers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#custom_headers WaasWaasPolicy#custom_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customHeaders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyOriginsCustomHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomHeaders
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#http_port WaasWaasPolicy#http_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#https_port WaasWaasPolicy#https_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpsPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpsPort
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
