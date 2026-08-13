using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    [JsiiInterface(nativeType: typeof(ITaxRegistrationCountryOptionsUs), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsUs")]
    public interface ITaxRegistrationCountryOptionsUs
    {
        /// <summary>Two-letter US state code ([ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2)).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#state TaxRegistration#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        string State
        {
            get;
        }

        /// <summary>Type of registration in the US.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#type TaxRegistration#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#local_amusement_tax TaxRegistration#local_amusement_tax}.</summary>
        [JsiiProperty(name: "localAmusementTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalAmusementTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalAmusementTax? LocalAmusementTax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#local_lease_tax TaxRegistration#local_lease_tax}.</summary>
        [JsiiProperty(name: "localLeaseTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalLeaseTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalLeaseTax? LocalLeaseTax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#state_sales_tax TaxRegistration#state_sales_tax}.</summary>
        [JsiiProperty(name: "stateSalesTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTax? StateSalesTax
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITaxRegistrationCountryOptionsUs), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsUs")]
        internal sealed class _Proxy : DeputyBase, stripe.TaxRegistration.ITaxRegistrationCountryOptionsUs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Two-letter US state code ([ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2)).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#state TaxRegistration#state}
            /// </remarks>
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
            public string State
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Type of registration in the US.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#type TaxRegistration#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#local_amusement_tax TaxRegistration#local_amusement_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localAmusementTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalAmusementTax\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalAmusementTax? LocalAmusementTax
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalAmusementTax?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#local_lease_tax TaxRegistration#local_lease_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localLeaseTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalLeaseTax\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalLeaseTax? LocalLeaseTax
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalLeaseTax?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#state_sales_tax TaxRegistration#state_sales_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stateSalesTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTax\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTax? StateSalesTax
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTax?>();
            }
        }
    }
}
