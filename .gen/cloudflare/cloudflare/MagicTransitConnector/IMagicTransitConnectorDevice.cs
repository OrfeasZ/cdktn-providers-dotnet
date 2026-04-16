using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitConnector
{
    [JsiiInterface(nativeType: typeof(IMagicTransitConnectorDevice), fullyQualifiedName: "cloudflare.magicTransitConnector.MagicTransitConnectorDevice")]
    public interface IMagicTransitConnectorDevice
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_connector#id MagicTransitConnector#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set to true to provision a license key for this connector.</summary>
        /// <remarks>
        /// Only used during resource creation. This is a write-only field that will not be stored in state.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_connector#provision_license MagicTransitConnector#provision_license}
        /// </remarks>
        [JsiiProperty(name: "provisionLicense", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProvisionLicense
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_connector#serial_number MagicTransitConnector#serial_number}.</summary>
        [JsiiProperty(name: "serialNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SerialNumber
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicTransitConnectorDevice), fullyQualifiedName: "cloudflare.magicTransitConnector.MagicTransitConnectorDevice")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicTransitConnector.IMagicTransitConnectorDevice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_connector#id MagicTransitConnector#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set to true to provision a license key for this connector.</summary>
            /// <remarks>
            /// Only used during resource creation. This is a write-only field that will not be stored in state.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_connector#provision_license MagicTransitConnector#provision_license}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisionLicense", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ProvisionLicense
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_connector#serial_number MagicTransitConnector#serial_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serialNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SerialNumber
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
