using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    [JsiiInterface(nativeType: typeof(ITaxRegistrationCountryOptionsUs), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsUs")]
    public interface ITaxRegistrationCountryOptionsUs
    {
        /// <summary>Two-letter US state code ([ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2)).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#state TaxRegistration#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        string State
        {
            get;
        }

        /// <summary>Type of registration in the US.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#type TaxRegistration#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#admissions_tax TaxRegistration#admissions_tax}.</summary>
        [JsiiProperty(name: "admissionsTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsAdmissionsTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsAdmissionsTax? AdmissionsTax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#attendance_tax TaxRegistration#attendance_tax}.</summary>
        [JsiiProperty(name: "attendanceTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsAttendanceTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsAttendanceTax? AttendanceTax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#entertainment_tax TaxRegistration#entertainment_tax}.</summary>
        [JsiiProperty(name: "entertainmentTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsEntertainmentTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsEntertainmentTax? EntertainmentTax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#gross_receipts_tax TaxRegistration#gross_receipts_tax}.</summary>
        [JsiiProperty(name: "grossReceiptsTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsGrossReceiptsTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsGrossReceiptsTax? GrossReceiptsTax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#hospitality_tax TaxRegistration#hospitality_tax}.</summary>
        [JsiiProperty(name: "hospitalityTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsHospitalityTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsHospitalityTax? HospitalityTax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#local_amusement_tax TaxRegistration#local_amusement_tax}.</summary>
        [JsiiProperty(name: "localAmusementTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalAmusementTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalAmusementTax? LocalAmusementTax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#local_lease_tax TaxRegistration#local_lease_tax}.</summary>
        [JsiiProperty(name: "localLeaseTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalLeaseTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalLeaseTax? LocalLeaseTax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#luxury_tax TaxRegistration#luxury_tax}.</summary>
        [JsiiProperty(name: "luxuryTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLuxuryTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLuxuryTax? LuxuryTax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#mass_transit_parking_tax TaxRegistration#mass_transit_parking_tax}.</summary>
        [JsiiProperty(name: "massTransitParkingTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsMassTransitParkingTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsMassTransitParkingTax? MassTransitParkingTax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#parking_tax TaxRegistration#parking_tax}.</summary>
        [JsiiProperty(name: "parkingTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsParkingTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsParkingTax? ParkingTax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#resort_tax TaxRegistration#resort_tax}.</summary>
        [JsiiProperty(name: "resortTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsResortTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsResortTax? ResortTax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#state_sales_tax TaxRegistration#state_sales_tax}.</summary>
        [JsiiProperty(name: "stateSalesTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTax? StateSalesTax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#tourism_tax TaxRegistration#tourism_tax}.</summary>
        [JsiiProperty(name: "tourismTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsTourismTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsTourismTax? TourismTax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#utility_users_tax TaxRegistration#utility_users_tax}.</summary>
        [JsiiProperty(name: "utilityUsersTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsUtilityUsersTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsUtilityUsersTax? UtilityUsersTax
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#state TaxRegistration#state}
            /// </remarks>
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
            public string State
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Type of registration in the US.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#type TaxRegistration#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#admissions_tax TaxRegistration#admissions_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "admissionsTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsAdmissionsTax\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsAdmissionsTax? AdmissionsTax
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsAdmissionsTax?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#attendance_tax TaxRegistration#attendance_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attendanceTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsAttendanceTax\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsAttendanceTax? AttendanceTax
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsAttendanceTax?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#entertainment_tax TaxRegistration#entertainment_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "entertainmentTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsEntertainmentTax\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsEntertainmentTax? EntertainmentTax
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsEntertainmentTax?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#gross_receipts_tax TaxRegistration#gross_receipts_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "grossReceiptsTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsGrossReceiptsTax\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsGrossReceiptsTax? GrossReceiptsTax
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsGrossReceiptsTax?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#hospitality_tax TaxRegistration#hospitality_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hospitalityTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsHospitalityTax\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsHospitalityTax? HospitalityTax
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsHospitalityTax?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#local_amusement_tax TaxRegistration#local_amusement_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localAmusementTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalAmusementTax\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalAmusementTax? LocalAmusementTax
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalAmusementTax?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#local_lease_tax TaxRegistration#local_lease_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localLeaseTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalLeaseTax\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalLeaseTax? LocalLeaseTax
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalLeaseTax?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#luxury_tax TaxRegistration#luxury_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "luxuryTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLuxuryTax\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLuxuryTax? LuxuryTax
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLuxuryTax?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#mass_transit_parking_tax TaxRegistration#mass_transit_parking_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "massTransitParkingTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsMassTransitParkingTax\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsMassTransitParkingTax? MassTransitParkingTax
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsMassTransitParkingTax?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#parking_tax TaxRegistration#parking_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parkingTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsParkingTax\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsParkingTax? ParkingTax
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsParkingTax?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#resort_tax TaxRegistration#resort_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resortTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsResortTax\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsResortTax? ResortTax
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsResortTax?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#state_sales_tax TaxRegistration#state_sales_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stateSalesTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTax\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTax? StateSalesTax
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTax?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#tourism_tax TaxRegistration#tourism_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tourismTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsTourismTax\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsTourismTax? TourismTax
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsTourismTax?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/tax_registration#utility_users_tax TaxRegistration#utility_users_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "utilityUsersTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsUtilityUsersTax\"}", isOptional: true)]
            public stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsUtilityUsersTax? UtilityUsersTax
            {
                get => GetInstanceProperty<stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsUtilityUsersTax?>();
            }
        }
    }
}
