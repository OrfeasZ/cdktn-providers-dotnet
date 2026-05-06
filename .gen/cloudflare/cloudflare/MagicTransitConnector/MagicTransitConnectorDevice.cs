using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitConnector
{
    [JsiiByValue(fqn: "cloudflare.magicTransitConnector.MagicTransitConnectorDevice")]
    public class MagicTransitConnectorDevice : cloudflare.MagicTransitConnector.IMagicTransitConnectorDevice
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/magic_transit_connector#id MagicTransitConnector#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/magic_transit_connector#serial_number MagicTransitConnector#serial_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serialNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SerialNumber
        {
            get;
            set;
        }
    }
}
