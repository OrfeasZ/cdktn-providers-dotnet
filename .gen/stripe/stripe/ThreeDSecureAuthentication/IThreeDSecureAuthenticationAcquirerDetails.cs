using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    [JsiiInterface(nativeType: typeof(IThreeDSecureAuthenticationAcquirerDetails), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationAcquirerDetails")]
    public interface IThreeDSecureAuthenticationAcquirerDetails
    {
        /// <summary>The Acquirer BIN (specific to the directory_server).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#acquirer_bin ThreeDSecureAuthentication#acquirer_bin}
        /// </remarks>
        [JsiiProperty(name: "acquirerBin", typeJson: "{\"primitive\":\"string\"}")]
        string AcquirerBin
        {
            get;
        }

        /// <summary>The two-letter country code of the acquirer ([ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2)).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#acquirer_country ThreeDSecureAuthentication#acquirer_country}
        /// </remarks>
        [JsiiProperty(name: "acquirerCountry", typeJson: "{\"primitive\":\"string\"}")]
        string AcquirerCountry
        {
            get;
        }

        /// <summary>The Merchant ID (or Card Acceptor ID) that your acquirer assigned you (specific to the directory_server).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#acquirer_merchant_id ThreeDSecureAuthentication#acquirer_merchant_id}
        /// </remarks>
        [JsiiProperty(name: "acquirerMerchantId", typeJson: "{\"primitive\":\"string\"}")]
        string AcquirerMerchantId
        {
            get;
        }

        /// <summary>The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) as defined by each payment system or directory server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#mcc ThreeDSecureAuthentication#mcc}
        /// </remarks>
        [JsiiProperty(name: "mcc", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mcc
        {
            get
            {
                return null;
            }
        }

        /// <summary>The merchant name assigned by the acquirer or payment system.</summary>
        /// <remarks>
        /// Same name used in the authorization message as defined in <a href="https://en.wikipedia.org/wiki/ISO_8583">ISO 8583</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#merchant_name ThreeDSecureAuthentication#merchant_name}
        /// </remarks>
        [JsiiProperty(name: "merchantName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MerchantName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Requestor ID if you’re enrolled in the card network’s 3DS program.</summary>
        /// <remarks>
        /// Otherwise, you can omit this field because Stripe assigns a Requestor ID with the card networks.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#requestor_id ThreeDSecureAuthentication#requestor_id}
        /// </remarks>
        [JsiiProperty(name: "requestorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RequestorId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IThreeDSecureAuthenticationAcquirerDetails), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationAcquirerDetails")]
        internal sealed class _Proxy : DeputyBase, stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationAcquirerDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Acquirer BIN (specific to the directory_server).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#acquirer_bin ThreeDSecureAuthentication#acquirer_bin}
            /// </remarks>
            [JsiiProperty(name: "acquirerBin", typeJson: "{\"primitive\":\"string\"}")]
            public string AcquirerBin
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The two-letter country code of the acquirer ([ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2)).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#acquirer_country ThreeDSecureAuthentication#acquirer_country}
            /// </remarks>
            [JsiiProperty(name: "acquirerCountry", typeJson: "{\"primitive\":\"string\"}")]
            public string AcquirerCountry
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The Merchant ID (or Card Acceptor ID) that your acquirer assigned you (specific to the directory_server).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#acquirer_merchant_id ThreeDSecureAuthentication#acquirer_merchant_id}
            /// </remarks>
            [JsiiProperty(name: "acquirerMerchantId", typeJson: "{\"primitive\":\"string\"}")]
            public string AcquirerMerchantId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) as defined by each payment system or directory server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#mcc ThreeDSecureAuthentication#mcc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mcc", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mcc
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The merchant name assigned by the acquirer or payment system.</summary>
            /// <remarks>
            /// Same name used in the authorization message as defined in <a href="https://en.wikipedia.org/wiki/ISO_8583">ISO 8583</a>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#merchant_name ThreeDSecureAuthentication#merchant_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "merchantName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MerchantName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Requestor ID if you’re enrolled in the card network’s 3DS program.</summary>
            /// <remarks>
            /// Otherwise, you can omit this field because Stripe assigns a Requestor ID with the card networks.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#requestor_id ThreeDSecureAuthentication#requestor_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequestorId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
