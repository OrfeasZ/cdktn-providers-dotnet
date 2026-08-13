using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodOptionsCard), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsCard")]
    public interface ISetupIntentPaymentMethodOptionsCard
    {
        /// <summary>Configuration options for setting up an eMandate for cards issued in India.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#mandate_options SetupIntent#mandate_options}
        /// </remarks>
        [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsCardMandateOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardMandateOptions? MandateOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>When specified, this parameter signals that a card has been collected as MOTO (Mail Order Telephone Order) and thus out of scope for SCA.</summary>
        /// <remarks>
        /// This
        /// parameter can only be provided during confirmation.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#moto SetupIntent#moto}
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

        /// <summary>Selected network to process this SetupIntent on.</summary>
        /// <remarks>
        /// Depends on the available networks of the card attached to the setup intent. Can be only set confirm-time.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#network SetupIntent#network}
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

        /// <summary>We strongly recommend that you rely on our SCA Engine to automatically prompt your customers for authentication based on risk level and [other requirements](https://docs.stripe.com/strong-customer-authentication). However, if you wish to request 3D Secure based on logic from your own fraud engine, provide this option. If not provided, this value defaults to `automatic`. Read our guide on [manually requesting 3D Secure](https://docs.stripe.com/payments/3d-secure/authentication-flow#manual-three-ds) for more information on how this configuration interacts with Radar and our SCA Engine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#request_three_d_secure SetupIntent#request_three_d_secure}
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

        /// <summary>If 3D Secure authentication was performed with a third-party provider, the authentication details to use for this setup.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#three_d_secure SetupIntent#three_d_secure}
        /// </remarks>
        [JsiiProperty(name: "threeDSecure", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsCardThreeDSecure\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardThreeDSecure? ThreeDSecure
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodOptionsCard), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsCard")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCard
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configuration options for setting up an eMandate for cards issued in India.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#mandate_options SetupIntent#mandate_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsCardMandateOptions\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardMandateOptions? MandateOptions
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardMandateOptions?>();
            }

            /// <summary>When specified, this parameter signals that a card has been collected as MOTO (Mail Order Telephone Order) and thus out of scope for SCA.</summary>
            /// <remarks>
            /// This
            /// parameter can only be provided during confirmation.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#moto SetupIntent#moto}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "moto", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Moto
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Selected network to process this SetupIntent on.</summary>
            /// <remarks>
            /// Depends on the available networks of the card attached to the setup intent. Can be only set confirm-time.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#network SetupIntent#network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "network", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Network
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>We strongly recommend that you rely on our SCA Engine to automatically prompt your customers for authentication based on risk level and [other requirements](https://docs.stripe.com/strong-customer-authentication). However, if you wish to request 3D Secure based on logic from your own fraud engine, provide this option. If not provided, this value defaults to `automatic`. Read our guide on [manually requesting 3D Secure](https://docs.stripe.com/payments/3d-secure/authentication-flow#manual-three-ds) for more information on how this configuration interacts with Radar and our SCA Engine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#request_three_d_secure SetupIntent#request_three_d_secure}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestThreeDSecure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequestThreeDSecure
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If 3D Secure authentication was performed with a third-party provider, the authentication details to use for this setup.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#three_d_secure SetupIntent#three_d_secure}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "threeDSecure", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsCardThreeDSecure\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardThreeDSecure? ThreeDSecure
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardThreeDSecure?>();
            }
        }
    }
}
