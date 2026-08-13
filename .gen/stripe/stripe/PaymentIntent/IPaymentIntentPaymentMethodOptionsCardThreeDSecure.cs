using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodOptionsCardThreeDSecure), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardThreeDSecure")]
    public interface IPaymentIntentPaymentMethodOptionsCardThreeDSecure
    {
        /// <summary>The cryptogram, also known as the "authentication value" (AAV, CAVV or AEVV).</summary>
        /// <remarks>
        /// This value is 20 bytes, base64-encoded into a 28-character string.
        /// (Most 3D Secure providers will return the base64-encoded version, which
        /// is what you should specify here.)
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#cryptogram PaymentIntent#cryptogram}
        /// </remarks>
        [JsiiProperty(name: "cryptogram", typeJson: "{\"primitive\":\"string\"}")]
        string Cryptogram
        {
            get;
        }

        /// <summary>For 3D Secure 1, the XID. For 3D Secure 2, the Directory Server Transaction ID (dsTransID).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#transaction_id PaymentIntent#transaction_id}
        /// </remarks>
        [JsiiProperty(name: "transactionId", typeJson: "{\"primitive\":\"string\"}")]
        string TransactionId
        {
            get;
        }

        /// <summary>The version of 3D Secure that was performed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#version PaymentIntent#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        /// <summary>The `transStatus` returned from the card Issuer’s ACS in the ARes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#ares_trans_status PaymentIntent#ares_trans_status}
        /// </remarks>
        [JsiiProperty(name: "aresTransStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AresTransStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Electronic Commerce Indicator (ECI) is returned by your 3D Secure provider and indicates what degree of authentication was performed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#electronic_commerce_indicator PaymentIntent#electronic_commerce_indicator}
        /// </remarks>
        [JsiiProperty(name: "electronicCommerceIndicator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ElectronicCommerceIndicator
        {
            get
            {
                return null;
            }
        }

        /// <summary>The exemption requested via 3DS and accepted by the issuer at authentication time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#exemption_indicator PaymentIntent#exemption_indicator}
        /// </remarks>
        [JsiiProperty(name: "exemptionIndicator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExemptionIndicator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Network specific 3DS fields. Network specific arguments require an explicit card brand choice. The parameter `payment_method_options.card.network`` must be populated accordingly.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#network_options PaymentIntent#network_options}
        /// </remarks>
        [JsiiProperty(name: "networkOptions", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions? NetworkOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>The challenge indicator (`threeDSRequestorChallengeInd`) which was requested in the AReq sent to the card Issuer's ACS.</summary>
        /// <remarks>
        /// A string containing 2 digits from 01-99.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#requestor_challenge_indicator PaymentIntent#requestor_challenge_indicator}
        /// </remarks>
        [JsiiProperty(name: "requestorChallengeIndicator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RequestorChallengeIndicator
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodOptionsCardThreeDSecure), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardThreeDSecure")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardThreeDSecure
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The cryptogram, also known as the "authentication value" (AAV, CAVV or AEVV).</summary>
            /// <remarks>
            /// This value is 20 bytes, base64-encoded into a 28-character string.
            /// (Most 3D Secure providers will return the base64-encoded version, which
            /// is what you should specify here.)
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#cryptogram PaymentIntent#cryptogram}
            /// </remarks>
            [JsiiProperty(name: "cryptogram", typeJson: "{\"primitive\":\"string\"}")]
            public string Cryptogram
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>For 3D Secure 1, the XID. For 3D Secure 2, the Directory Server Transaction ID (dsTransID).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#transaction_id PaymentIntent#transaction_id}
            /// </remarks>
            [JsiiProperty(name: "transactionId", typeJson: "{\"primitive\":\"string\"}")]
            public string TransactionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The version of 3D Secure that was performed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#version PaymentIntent#version}
            /// </remarks>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The `transStatus` returned from the card Issuer’s ACS in the ARes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#ares_trans_status PaymentIntent#ares_trans_status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aresTransStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AresTransStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Electronic Commerce Indicator (ECI) is returned by your 3D Secure provider and indicates what degree of authentication was performed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#electronic_commerce_indicator PaymentIntent#electronic_commerce_indicator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "electronicCommerceIndicator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ElectronicCommerceIndicator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The exemption requested via 3DS and accepted by the issuer at authentication time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#exemption_indicator PaymentIntent#exemption_indicator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exemptionIndicator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExemptionIndicator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Network specific 3DS fields. Network specific arguments require an explicit card brand choice. The parameter `payment_method_options.card.network`` must be populated accordingly.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#network_options PaymentIntent#network_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkOptions", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions? NetworkOptions
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions?>();
            }

            /// <summary>The challenge indicator (`threeDSRequestorChallengeInd`) which was requested in the AReq sent to the card Issuer's ACS.</summary>
            /// <remarks>
            /// A string containing 2 digits from 01-99.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#requestor_challenge_indicator PaymentIntent#requestor_challenge_indicator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestorChallengeIndicator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequestorChallengeIndicator
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
