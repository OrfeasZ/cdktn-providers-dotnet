using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails")]
    public interface ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#registered_address Subscription#registered_address}.</summary>
        [JsiiProperty(name: "registeredAddress", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress? RegisteredAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Company or entity name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#registered_name Subscription#registered_name}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#registration_number Subscription#registration_number}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#registration_type Subscription#registration_type}
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

        /// <summary>VAT ID number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#vat Subscription#vat}
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

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#registered_address Subscription#registered_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "registeredAddress", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress? RegisteredAddress
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress?>();
            }

            /// <summary>Company or entity name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#registered_name Subscription#registered_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "registeredName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegisteredName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The official registration number for the given registration type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#registration_number Subscription#registration_number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "registrationNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegistrationNumber
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Type of registration the company or entity holds in their registered country.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#registration_type Subscription#registration_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "registrationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegistrationType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>VAT ID number.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#vat Subscription#vat}
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
