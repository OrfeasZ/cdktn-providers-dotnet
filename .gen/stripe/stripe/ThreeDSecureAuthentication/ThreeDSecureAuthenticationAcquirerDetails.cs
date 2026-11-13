using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationAcquirerDetails")]
    public class ThreeDSecureAuthenticationAcquirerDetails : stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationAcquirerDetails
    {
        /// <summary>The Acquirer BIN (specific to the directory_server).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#acquirer_bin ThreeDSecureAuthentication#acquirer_bin}
        /// </remarks>
        [JsiiProperty(name: "acquirerBin", typeJson: "{\"primitive\":\"string\"}")]
        public string AcquirerBin
        {
            get;
            set;
        }

        /// <summary>The two-letter country code of the acquirer ([ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2)).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#acquirer_country ThreeDSecureAuthentication#acquirer_country}
        /// </remarks>
        [JsiiProperty(name: "acquirerCountry", typeJson: "{\"primitive\":\"string\"}")]
        public string AcquirerCountry
        {
            get;
            set;
        }

        /// <summary>The Merchant ID (or Card Acceptor ID) that your acquirer assigned you (specific to the directory_server).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#acquirer_merchant_id ThreeDSecureAuthentication#acquirer_merchant_id}
        /// </remarks>
        [JsiiProperty(name: "acquirerMerchantId", typeJson: "{\"primitive\":\"string\"}")]
        public string AcquirerMerchantId
        {
            get;
            set;
        }

        /// <summary>The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) as defined by each payment system or directory server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#mcc ThreeDSecureAuthentication#mcc}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mcc", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mcc
        {
            get;
            set;
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
            get;
            set;
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
            get;
            set;
        }
    }
}
