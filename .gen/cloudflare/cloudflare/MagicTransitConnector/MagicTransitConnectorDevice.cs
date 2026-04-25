using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitConnector
{
    [JsiiByValue(fqn: "cloudflare.magicTransitConnector.MagicTransitConnectorDevice")]
    public class MagicTransitConnectorDevice : cloudflare.MagicTransitConnector.IMagicTransitConnectorDevice
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_connector#id MagicTransitConnector#id}.</summary>
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

        private object? _provisionLicense;

        /// <summary>Set to true to provision a license key for this connector.</summary>
        /// <remarks>
        /// Only used during resource creation. This is a write-only field that will not be stored in state.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_connector#provision_license MagicTransitConnector#provision_license}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisionLicense", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ProvisionLicense
        {
            get => _provisionLicense;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _provisionLicense = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_connector#serial_number MagicTransitConnector#serial_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serialNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SerialNumber
        {
            get;
            set;
        }
    }
}
