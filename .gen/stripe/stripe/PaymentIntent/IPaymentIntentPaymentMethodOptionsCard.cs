using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodOptionsCard), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCard")]
    public interface IPaymentIntentPaymentMethodOptionsCard
    {
        /// <summary>Controls when the funds will be captured from the customer's account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#capture_method PaymentIntent#capture_method}
        /// </remarks>
        [JsiiProperty(name: "captureMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaptureMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>A single-use `cvc_update` Token that represents a card CVC value.</summary>
        /// <remarks>
        /// When provided, the CVC value will be verified during the card payment attempt. This parameter can only be provided during confirmation.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#cvc_token PaymentIntent#cvc_token}
        /// </remarks>
        [JsiiProperty(name: "cvcToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CvcToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Installment details for this payment.</summary>
        /// <remarks>
        /// For more information, see the <a href="https://docs.stripe.com/payments/installments">installments integration guide</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#installments PaymentIntent#installments}
        /// </remarks>
        [JsiiProperty(name: "installments", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardInstallments\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardInstallments? Installments
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configuration options for setting up an eMandate for cards issued in India.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#mandate_options PaymentIntent#mandate_options}
        /// </remarks>
        [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardMandateOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardMandateOptions? MandateOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>When specified, this parameter indicates that a transaction will be marked as MOTO (Mail Order Telephone Order) and thus out of scope for SCA.</summary>
        /// <remarks>
        /// This
        /// parameter can only be provided during confirmation.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#moto PaymentIntent#moto}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "moto", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Moto
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selected network to process this payment intent on.</summary>
        /// <remarks>
        /// Depends on the available networks of the card attached to the payment intent. Can be only set confirm-time.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#network PaymentIntent#network}
        /// </remarks>
        [JsiiProperty(name: "network", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Network
        {
            get
            {
                return null;
            }
        }

        /// <summary>Request ability to [capture beyond the standard authorization validity window](https://docs.stripe.com/payments/extended-authorization) for this PaymentIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#request_extended_authorization PaymentIntent#request_extended_authorization}
        /// </remarks>
        [JsiiProperty(name: "requestExtendedAuthorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RequestExtendedAuthorization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Request ability to [increment the authorization](https://docs.stripe.com/payments/incremental-authorization) for this PaymentIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#request_incremental_authorization PaymentIntent#request_incremental_authorization}
        /// </remarks>
        [JsiiProperty(name: "requestIncrementalAuthorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RequestIncrementalAuthorization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Request ability to make [multiple captures](https://docs.stripe.com/payments/multicapture) for this PaymentIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#request_multicapture PaymentIntent#request_multicapture}
        /// </remarks>
        [JsiiProperty(name: "requestMulticapture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RequestMulticapture
        {
            get
            {
                return null;
            }
        }

        /// <summary>Request ability to [overcapture](https://docs.stripe.com/payments/overcapture) for this PaymentIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#request_overcapture PaymentIntent#request_overcapture}
        /// </remarks>
        [JsiiProperty(name: "requestOvercapture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RequestOvercapture
        {
            get
            {
                return null;
            }
        }

        /// <summary>We strongly recommend that you rely on our SCA Engine to automatically prompt your customers for authentication based on risk level and [other requirements](https://docs.stripe.com/strong-customer-authentication). However, if you wish to request 3D Secure based on logic from your own fraud engine, provide this option. If not provided, this value defaults to `automatic`. Read our guide on [manually requesting 3D Secure](https://docs.stripe.com/payments/3d-secure/authentication-flow#manual-three-ds) for more information on how this configuration interacts with Radar and our SCA Engine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#request_three_d_secure PaymentIntent#request_three_d_secure}
        /// </remarks>
        [JsiiProperty(name: "requestThreeDSecure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RequestThreeDSecure
        {
            get
            {
                return null;
            }
        }

        /// <summary>When enabled, using a card that is attached to a customer will require the CVC to be provided again (i.e. using the cvc_token parameter).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#require_cvc_recollection PaymentIntent#require_cvc_recollection}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "requireCvcRecollection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireCvcRecollection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates that you intend to make future payments with this PaymentIntent's payment method.</summary>
        /// <remarks>
        /// If you provide a Customer with the PaymentIntent, you can use this parameter to <a href="/payments/save-during-payment">attach the payment method</a> to the Customer after the PaymentIntent is confirmed and the customer completes any required actions. If you don't provide a Customer, you can still <a href="/api/payment_methods/attach">attach</a> the payment method to a Customer after the transaction completes.
        ///
        /// If the payment method is <c>card_present</c> and isn't a digital wallet, Stripe creates and attaches a <a href="/api/charges/object#charge_object-payment_method_details-card_present-generated_card">generated_card</a> payment method representing the card to the Customer instead.
        ///
        /// When processing card payments, Stripe uses <c>setup_future_usage</c> to help you comply with regional legislation and network rules, such as <a href="/strong-customer-authentication">SCA</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#setup_future_usage PaymentIntent#setup_future_usage}
        /// </remarks>
        [JsiiProperty(name: "setupFutureUsage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SetupFutureUsage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Provides information about a card payment that customers see on their statements.</summary>
        /// <remarks>
        /// Concatenated with the Kana prefix (shortened Kana descriptor) or Kana statement descriptor that’s set on the account to form the complete statement descriptor. Maximum 22 characters. On card statements, the <em>concatenation</em> of both prefix and suffix (including separators) will appear truncated to 22 characters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#statement_descriptor_suffix_kana PaymentIntent#statement_descriptor_suffix_kana}
        /// </remarks>
        [JsiiProperty(name: "statementDescriptorSuffixKana", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StatementDescriptorSuffixKana
        {
            get
            {
                return null;
            }
        }

        /// <summary>Provides information about a card payment that customers see on their statements.</summary>
        /// <remarks>
        /// Concatenated with the Kanji prefix (shortened Kanji descriptor) or Kanji statement descriptor that’s set on the account to form the complete statement descriptor. Maximum 17 characters. On card statements, the <em>concatenation</em> of both prefix and suffix (including separators) will appear truncated to 17 characters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#statement_descriptor_suffix_kanji PaymentIntent#statement_descriptor_suffix_kanji}
        /// </remarks>
        [JsiiProperty(name: "statementDescriptorSuffixKanji", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StatementDescriptorSuffixKanji
        {
            get
            {
                return null;
            }
        }

        /// <summary>If 3D Secure authentication was performed with a third-party provider, the authentication details to use for this payment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#three_d_secure PaymentIntent#three_d_secure}
        /// </remarks>
        [JsiiProperty(name: "threeDSecure", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardThreeDSecure\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardThreeDSecure? ThreeDSecure
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodOptionsCard), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCard")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCard
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls when the funds will be captured from the customer's account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#capture_method PaymentIntent#capture_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "captureMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaptureMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A single-use `cvc_update` Token that represents a card CVC value.</summary>
            /// <remarks>
            /// When provided, the CVC value will be verified during the card payment attempt. This parameter can only be provided during confirmation.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#cvc_token PaymentIntent#cvc_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cvcToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CvcToken
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Installment details for this payment.</summary>
            /// <remarks>
            /// For more information, see the <a href="https://docs.stripe.com/payments/installments">installments integration guide</a>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#installments PaymentIntent#installments}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "installments", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardInstallments\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardInstallments? Installments
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardInstallments?>();
            }

            /// <summary>Configuration options for setting up an eMandate for cards issued in India.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#mandate_options PaymentIntent#mandate_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardMandateOptions\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardMandateOptions? MandateOptions
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardMandateOptions?>();
            }

            /// <summary>When specified, this parameter indicates that a transaction will be marked as MOTO (Mail Order Telephone Order) and thus out of scope for SCA.</summary>
            /// <remarks>
            /// This
            /// parameter can only be provided during confirmation.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#moto PaymentIntent#moto}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "moto", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Moto
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Selected network to process this payment intent on.</summary>
            /// <remarks>
            /// Depends on the available networks of the card attached to the payment intent. Can be only set confirm-time.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#network PaymentIntent#network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "network", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Network
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Request ability to [capture beyond the standard authorization validity window](https://docs.stripe.com/payments/extended-authorization) for this PaymentIntent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#request_extended_authorization PaymentIntent#request_extended_authorization}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestExtendedAuthorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequestExtendedAuthorization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Request ability to [increment the authorization](https://docs.stripe.com/payments/incremental-authorization) for this PaymentIntent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#request_incremental_authorization PaymentIntent#request_incremental_authorization}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestIncrementalAuthorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequestIncrementalAuthorization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Request ability to make [multiple captures](https://docs.stripe.com/payments/multicapture) for this PaymentIntent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#request_multicapture PaymentIntent#request_multicapture}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestMulticapture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequestMulticapture
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Request ability to [overcapture](https://docs.stripe.com/payments/overcapture) for this PaymentIntent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#request_overcapture PaymentIntent#request_overcapture}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestOvercapture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequestOvercapture
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>We strongly recommend that you rely on our SCA Engine to automatically prompt your customers for authentication based on risk level and [other requirements](https://docs.stripe.com/strong-customer-authentication). However, if you wish to request 3D Secure based on logic from your own fraud engine, provide this option. If not provided, this value defaults to `automatic`. Read our guide on [manually requesting 3D Secure](https://docs.stripe.com/payments/3d-secure/authentication-flow#manual-three-ds) for more information on how this configuration interacts with Radar and our SCA Engine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#request_three_d_secure PaymentIntent#request_three_d_secure}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestThreeDSecure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequestThreeDSecure
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>When enabled, using a card that is attached to a customer will require the CVC to be provided again (i.e. using the cvc_token parameter).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#require_cvc_recollection PaymentIntent#require_cvc_recollection}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireCvcRecollection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequireCvcRecollection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Indicates that you intend to make future payments with this PaymentIntent's payment method.</summary>
            /// <remarks>
            /// If you provide a Customer with the PaymentIntent, you can use this parameter to <a href="/payments/save-during-payment">attach the payment method</a> to the Customer after the PaymentIntent is confirmed and the customer completes any required actions. If you don't provide a Customer, you can still <a href="/api/payment_methods/attach">attach</a> the payment method to a Customer after the transaction completes.
            ///
            /// If the payment method is <c>card_present</c> and isn't a digital wallet, Stripe creates and attaches a <a href="/api/charges/object#charge_object-payment_method_details-card_present-generated_card">generated_card</a> payment method representing the card to the Customer instead.
            ///
            /// When processing card payments, Stripe uses <c>setup_future_usage</c> to help you comply with regional legislation and network rules, such as <a href="/strong-customer-authentication">SCA</a>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#setup_future_usage PaymentIntent#setup_future_usage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "setupFutureUsage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SetupFutureUsage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Provides information about a card payment that customers see on their statements.</summary>
            /// <remarks>
            /// Concatenated with the Kana prefix (shortened Kana descriptor) or Kana statement descriptor that’s set on the account to form the complete statement descriptor. Maximum 22 characters. On card statements, the <em>concatenation</em> of both prefix and suffix (including separators) will appear truncated to 22 characters.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#statement_descriptor_suffix_kana PaymentIntent#statement_descriptor_suffix_kana}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statementDescriptorSuffixKana", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StatementDescriptorSuffixKana
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Provides information about a card payment that customers see on their statements.</summary>
            /// <remarks>
            /// Concatenated with the Kanji prefix (shortened Kanji descriptor) or Kanji statement descriptor that’s set on the account to form the complete statement descriptor. Maximum 17 characters. On card statements, the <em>concatenation</em> of both prefix and suffix (including separators) will appear truncated to 17 characters.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#statement_descriptor_suffix_kanji PaymentIntent#statement_descriptor_suffix_kanji}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statementDescriptorSuffixKanji", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StatementDescriptorSuffixKanji
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If 3D Secure authentication was performed with a third-party provider, the authentication details to use for this payment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#three_d_secure PaymentIntent#three_d_secure}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "threeDSecure", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardThreeDSecure\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardThreeDSecure? ThreeDSecure
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardThreeDSecure?>();
            }
        }
    }
}
