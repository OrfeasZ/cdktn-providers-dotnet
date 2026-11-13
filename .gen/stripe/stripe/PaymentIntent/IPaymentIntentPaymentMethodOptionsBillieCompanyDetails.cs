using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodOptionsBillieCompanyDetails), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBillieCompanyDetails")]
    public interface IPaymentIntentPaymentMethodOptionsBillieCompanyDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#registered_address PaymentIntent#registered_address}.</summary>
        [JsiiProperty(name: "registeredAddress", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress? RegisteredAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Company or entity name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#registered_name PaymentIntent#registered_name}
        /// </remarks>
        [JsiiProperty(name: "registeredName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RegisteredName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The official registration number for the given registration type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#registration_number PaymentIntent#registration_number}
        /// </remarks>
        [JsiiProperty(name: "registrationNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RegistrationNumber
        {
            get
            {
                return null;
            }
        }

        /// <summary>Type of registration the company or entity holds in their registered country.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#registration_type PaymentIntent#registration_type}
        /// </remarks>
        [JsiiProperty(name: "registrationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RegistrationType
        {
            get
            {
                return null;
            }
        }

        /// <summary>VAT id number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#vat PaymentIntent#vat}
        /// </remarks>
        [JsiiProperty(name: "vat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Vat
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodOptionsBillieCompanyDetails), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBillieCompanyDetails")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBillieCompanyDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#registered_address PaymentIntent#registered_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "registeredAddress", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress? RegisteredAddress
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress?>();
            }

            /// <summary>Company or entity name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#registered_name PaymentIntent#registered_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "registeredName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegisteredName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The official registration number for the given registration type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#registration_number PaymentIntent#registration_number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "registrationNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegistrationNumber
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Type of registration the company or entity holds in their registered country.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#registration_type PaymentIntent#registration_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "registrationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegistrationType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>VAT id number.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#vat PaymentIntent#vat}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Vat
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
