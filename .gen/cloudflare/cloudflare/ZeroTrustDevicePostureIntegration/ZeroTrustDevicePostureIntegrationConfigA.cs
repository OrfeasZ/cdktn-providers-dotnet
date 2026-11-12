using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDevicePostureIntegration
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustDevicePostureIntegration.ZeroTrustDevicePostureIntegrationConfigA")]
    public class ZeroTrustDevicePostureIntegrationConfigA : cloudflare.ZeroTrustDevicePostureIntegration.IZeroTrustDevicePostureIntegrationConfigA
    {
        /// <summary>If present, this id will be passed in the `CF-Access-Client-ID` header when hitting the `api_url`.</summary>
        /// <remarks>
        /// This id will be passed in the <c>CF-Access-Client-ID</c> header when hitting the <c>api_url</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_posture_integration#access_client_id ZeroTrustDevicePostureIntegration#access_client_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessClientId
        {
            get;
            set;
        }

        /// <summary>If present, this secret will be passed in the `CF-Access-Client-Secret` header when hitting the `api_url`.</summary>
        /// <remarks>
        /// This secret will be passed in the <c>CF-Access-Client-Secret</c> header when hitting the <c>api_url</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_posture_integration#access_client_secret ZeroTrustDevicePostureIntegration#access_client_secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessClientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessClientSecret
        {
            get;
            set;
        }

        /// <summary>The Workspace One API URL provided in the Workspace One Admin Dashboard.</summary>
        /// <remarks>
        /// The Crowdstrike API URL.
        ///
        /// The Uptycs API URL.
        ///
        /// The Tanium API URL.
        ///
        /// The SentinelOne S2S API URL.
        ///
        /// The Custom Device Posture Integration  API URL.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_posture_integration#api_url ZeroTrustDevicePostureIntegration#api_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiUrl
        {
            get;
            set;
        }

        /// <summary>The Workspace One Authorization URL depending on your region.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_posture_integration#auth_url ZeroTrustDevicePostureIntegration#auth_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthUrl
        {
            get;
            set;
        }

        /// <summary>The Workspace One client ID provided in the Workspace One Admin Dashboard.</summary>
        /// <remarks>
        /// The Crowdstrike client ID.
        ///
        /// The Intune client ID.
        ///
        /// The Kolide client ID.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_posture_integration#client_id ZeroTrustDevicePostureIntegration#client_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientId
        {
            get;
            set;
        }

        /// <summary>The Uptycs client secret.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_posture_integration#client_key ZeroTrustDevicePostureIntegration#client_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientKey
        {
            get;
            set;
        }

        /// <summary>The Workspace One client secret provided in the Workspace One Admin Dashboard.</summary>
        /// <remarks>
        /// The Crowdstrike client secret.
        ///
        /// The Uptycs client secret.
        ///
        /// The Intune client secret.
        ///
        /// The Kolide client secret.
        ///
        /// The Tanium client secret.
        ///
        /// The SentinelOne S2S client secret.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_posture_integration#client_secret ZeroTrustDevicePostureIntegration#client_secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientSecret
        {
            get;
            set;
        }

        /// <summary>The Crowdstrike customer ID.</summary>
        /// <remarks>
        /// The Uptycs customer ID.
        ///
        /// The Intune customer ID.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_device_posture_integration#customer_id ZeroTrustDevicePostureIntegration#customer_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomerId
        {
            get;
            set;
        }
    }
}
