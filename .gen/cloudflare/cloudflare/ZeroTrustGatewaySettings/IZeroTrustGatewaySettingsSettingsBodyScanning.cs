using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewaySettings
{
    [JsiiInterface(nativeType: typeof(IZeroTrustGatewaySettingsSettingsBodyScanning), fullyQualifiedName: "cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBodyScanning")]
    public interface IZeroTrustGatewaySettingsSettingsBodyScanning
    {
        /// <summary>Specify the inspection mode as either `deep` or `shallow`. Available values: "deep", "shallow".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_settings#inspection_mode ZeroTrustGatewaySettings#inspection_mode}
        /// </remarks>
        [JsiiProperty(name: "inspectionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InspectionMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustGatewaySettingsSettingsBodyScanning), fullyQualifiedName: "cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBodyScanning")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBodyScanning
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specify the inspection mode as either `deep` or `shallow`. Available values: "deep", "shallow".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_settings#inspection_mode ZeroTrustGatewaySettings#inspection_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inspectionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InspectionMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
