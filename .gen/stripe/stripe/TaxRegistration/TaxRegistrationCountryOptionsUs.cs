using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.taxRegistration.TaxRegistrationCountryOptionsUs")]
    public class TaxRegistrationCountryOptionsUs : stripe.TaxRegistration.ITaxRegistrationCountryOptionsUs
    {
        /// <summary>Two-letter US state code ([ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2)).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#state TaxRegistration#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public string State
        {
            get;
            set;
        }

        /// <summary>Type of registration in the US.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#type TaxRegistration#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#admissions_tax TaxRegistration#admissions_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "admissionsTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsAdmissionsTax\"}", isOptional: true)]
        public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsAdmissionsTax? AdmissionsTax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#attendance_tax TaxRegistration#attendance_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attendanceTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsAttendanceTax\"}", isOptional: true)]
        public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsAttendanceTax? AttendanceTax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#entertainment_tax TaxRegistration#entertainment_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "entertainmentTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsEntertainmentTax\"}", isOptional: true)]
        public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsEntertainmentTax? EntertainmentTax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#gross_receipts_tax TaxRegistration#gross_receipts_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "grossReceiptsTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsGrossReceiptsTax\"}", isOptional: true)]
        public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsGrossReceiptsTax? GrossReceiptsTax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#hospitality_tax TaxRegistration#hospitality_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hospitalityTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsHospitalityTax\"}", isOptional: true)]
        public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsHospitalityTax? HospitalityTax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#local_amusement_tax TaxRegistration#local_amusement_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localAmusementTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalAmusementTax\"}", isOptional: true)]
        public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalAmusementTax? LocalAmusementTax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#local_lease_tax TaxRegistration#local_lease_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localLeaseTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalLeaseTax\"}", isOptional: true)]
        public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalLeaseTax? LocalLeaseTax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#luxury_tax TaxRegistration#luxury_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "luxuryTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLuxuryTax\"}", isOptional: true)]
        public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLuxuryTax? LuxuryTax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#mass_transit_parking_tax TaxRegistration#mass_transit_parking_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "massTransitParkingTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsMassTransitParkingTax\"}", isOptional: true)]
        public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsMassTransitParkingTax? MassTransitParkingTax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#parking_tax TaxRegistration#parking_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parkingTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsParkingTax\"}", isOptional: true)]
        public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsParkingTax? ParkingTax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#resort_tax TaxRegistration#resort_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resortTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsResortTax\"}", isOptional: true)]
        public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsResortTax? ResortTax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#state_sales_tax TaxRegistration#state_sales_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stateSalesTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTax\"}", isOptional: true)]
        public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTax? StateSalesTax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#tourism_tax TaxRegistration#tourism_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tourismTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsTourismTax\"}", isOptional: true)]
        public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsTourismTax? TourismTax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#utility_users_tax TaxRegistration#utility_users_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "utilityUsersTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsUtilityUsersTax\"}", isOptional: true)]
        public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsUtilityUsersTax? UtilityUsersTax
        {
            get;
            set;
        }
    }
}
