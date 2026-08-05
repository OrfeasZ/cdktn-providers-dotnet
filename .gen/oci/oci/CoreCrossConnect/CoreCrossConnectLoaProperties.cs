using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCrossConnect
{
    [JsiiByValue(fqn: "oci.coreCrossConnect.CoreCrossConnectLoaProperties")]
    public class CoreCrossConnectLoaProperties : oci.CoreCrossConnect.ICoreCrossConnectLoaProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/core_cross_connect#authorized_agent CoreCrossConnect#authorized_agent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authorizedAgent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthorizedAgent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/core_cross_connect#expiry_extension_count CoreCrossConnect#expiry_extension_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expiryExtensionCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExpiryExtensionCount
        {
            get;
            set;
        }
    }
}
