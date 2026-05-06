using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayGateway
{
    [JsiiInterface(nativeType: typeof(IApigatewayGatewayCaBundles), fullyQualifiedName: "oci.apigatewayGateway.ApigatewayGatewayCaBundles")]
    public interface IApigatewayGatewayCaBundles
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_gateway#type ApigatewayGateway#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_gateway#ca_bundle_id ApigatewayGateway#ca_bundle_id}.</summary>
        [JsiiProperty(name: "caBundleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaBundleId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_gateway#certificate_authority_id ApigatewayGateway#certificate_authority_id}.</summary>
        [JsiiProperty(name: "certificateAuthorityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateAuthorityId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayGatewayCaBundles), fullyQualifiedName: "oci.apigatewayGateway.ApigatewayGatewayCaBundles")]
        internal sealed class _Proxy : DeputyBase, oci.ApigatewayGateway.IApigatewayGatewayCaBundles
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_gateway#type ApigatewayGateway#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_gateway#ca_bundle_id ApigatewayGateway#ca_bundle_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "caBundleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaBundleId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_gateway#certificate_authority_id ApigatewayGateway#certificate_authority_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateAuthorityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateAuthorityId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
