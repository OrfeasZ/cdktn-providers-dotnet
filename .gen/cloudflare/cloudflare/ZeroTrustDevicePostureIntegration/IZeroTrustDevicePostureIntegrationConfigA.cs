using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDevicePostureIntegration
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDevicePostureIntegrationConfigA), fullyQualifiedName: "cloudflare.zeroTrustDevicePostureIntegration.ZeroTrustDevicePostureIntegrationConfigA")]
    public interface IZeroTrustDevicePostureIntegrationConfigA
    {
        /// <summary>If present, this id will be passed in the `CF-Access-Client-ID` header when hitting the `api_url`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_integration#access_client_id ZeroTrustDevicePostureIntegration#access_client_id}
        /// </remarks>
        [JsiiProperty(name: "accessClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessClientId
        {
            get
            {
                return null;
            }
        }

        /// <summary>If present, this secret will be passed in the `CF-Access-Client-Secret` header when hitting the `api_url`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_integration#access_client_secret ZeroTrustDevicePostureIntegration#access_client_secret}
        /// </remarks>
        [JsiiProperty(name: "accessClientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessClientSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Workspace One API URL provided in the Workspace One Admin Dashboard.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_integration#api_url ZeroTrustDevicePostureIntegration#api_url}
        /// </remarks>
        [JsiiProperty(name: "apiUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Workspace One Authorization URL depending on your region.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_integration#auth_url ZeroTrustDevicePostureIntegration#auth_url}
        /// </remarks>
        [JsiiProperty(name: "authUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Workspace One client ID provided in the Workspace One Admin Dashboard.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_integration#client_id ZeroTrustDevicePostureIntegration#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Uptycs client secret.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_integration#client_key ZeroTrustDevicePostureIntegration#client_key}
        /// </remarks>
        [JsiiProperty(name: "clientKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Workspace One client secret provided in the Workspace One Admin Dashboard.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_integration#client_secret ZeroTrustDevicePostureIntegration#client_secret}
        /// </remarks>
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Crowdstrike customer ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_integration#customer_id ZeroTrustDevicePostureIntegration#customer_id}
        /// </remarks>
        [JsiiProperty(name: "customerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomerId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDevicePostureIntegrationConfigA), fullyQualifiedName: "cloudflare.zeroTrustDevicePostureIntegration.ZeroTrustDevicePostureIntegrationConfigA")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDevicePostureIntegration.IZeroTrustDevicePostureIntegrationConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>If present, this id will be passed in the `CF-Access-Client-ID` header when hitting the `api_url`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_integration#access_client_id ZeroTrustDevicePostureIntegration#access_client_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If present, this secret will be passed in the `CF-Access-Client-Secret` header when hitting the `api_url`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_integration#access_client_secret ZeroTrustDevicePostureIntegration#access_client_secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessClientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessClientSecret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Workspace One API URL provided in the Workspace One Admin Dashboard.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_integration#api_url ZeroTrustDevicePostureIntegration#api_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Workspace One Authorization URL depending on your region.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_integration#auth_url ZeroTrustDevicePostureIntegration#auth_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Workspace One client ID provided in the Workspace One Admin Dashboard.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_integration#client_id ZeroTrustDevicePostureIntegration#client_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Uptycs client secret.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_integration#client_key ZeroTrustDevicePostureIntegration#client_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Workspace One client secret provided in the Workspace One Admin Dashboard.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_integration#client_secret ZeroTrustDevicePostureIntegration#client_secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientSecret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Crowdstrike customer ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_device_posture_integration#customer_id ZeroTrustDevicePostureIntegration#customer_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
