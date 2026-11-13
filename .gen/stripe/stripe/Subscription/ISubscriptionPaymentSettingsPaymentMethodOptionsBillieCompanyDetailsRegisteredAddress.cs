using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress")]
    public interface ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress
    {
        /// <summary>City, district, suburb, town, or village.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#city Subscription#city}
        /// </remarks>
        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? City
        {
            get
            {
                return null;
            }
        }

        /// <summary>Two-letter country code.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#country Subscription#country}
        /// </remarks>
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Country
        {
            get
            {
                return null;
            }
        }

        /// <summary>Address line 1 (for example, street, PO Box, or company name).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#line1 Subscription#line1}
        /// </remarks>
        [JsiiProperty(name: "line1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Line1
        {
            get
            {
                return null;
            }
        }

        /// <summary>Address line 2 (for example, apartment, suite, unit, or building).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#line2 Subscription#line2}
        /// </remarks>
        [JsiiProperty(name: "line2", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Line2
        {
            get
            {
                return null;
            }
        }

        /// <summary>ZIP or postal code.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#postal_code Subscription#postal_code}
        /// </remarks>
        [JsiiProperty(name: "postalCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PostalCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>State, county, province, or region.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#state Subscription#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>City, district, suburb, town, or village.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#city Subscription#city}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? City
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Two-letter country code.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#country Subscription#country}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Country
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Address line 1 (for example, street, PO Box, or company name).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#line1 Subscription#line1}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "line1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Line1
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Address line 2 (for example, apartment, suite, unit, or building).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#line2 Subscription#line2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "line2", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Line2
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ZIP or postal code.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#postal_code Subscription#postal_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postalCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PostalCode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>State, county, province, or region.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#state Subscription#state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
