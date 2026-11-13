using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    [JsiiClass(nativeType: typeof(stripe.TaxRegistration.TaxRegistrationCountryOptionsUsOutputReference), fullyQualifiedName: "stripe.taxRegistration.TaxRegistrationCountryOptionsUsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TaxRegistrationCountryOptionsUsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TaxRegistrationCountryOptionsUsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TaxRegistrationCountryOptionsUsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TaxRegistrationCountryOptionsUsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdmissionsTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsAdmissionsTax\"}}]")]
        public virtual void PutAdmissionsTax(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsAdmissionsTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsAdmissionsTax)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAttendanceTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsAttendanceTax\"}}]")]
        public virtual void PutAttendanceTax(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsAttendanceTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsAttendanceTax)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEntertainmentTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsEntertainmentTax\"}}]")]
        public virtual void PutEntertainmentTax(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsEntertainmentTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsEntertainmentTax)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGrossReceiptsTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsGrossReceiptsTax\"}}]")]
        public virtual void PutGrossReceiptsTax(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsGrossReceiptsTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsGrossReceiptsTax)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHospitalityTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsHospitalityTax\"}}]")]
        public virtual void PutHospitalityTax(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsHospitalityTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsHospitalityTax)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLocalAmusementTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalAmusementTax\"}}]")]
        public virtual void PutLocalAmusementTax(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalAmusementTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalAmusementTax)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLocalLeaseTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalLeaseTax\"}}]")]
        public virtual void PutLocalLeaseTax(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalLeaseTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalLeaseTax)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLuxuryTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLuxuryTax\"}}]")]
        public virtual void PutLuxuryTax(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLuxuryTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLuxuryTax)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMassTransitParkingTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsMassTransitParkingTax\"}}]")]
        public virtual void PutMassTransitParkingTax(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsMassTransitParkingTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsMassTransitParkingTax)}, new object[]{@value});
        }

        [JsiiMethod(name: "putParkingTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsParkingTax\"}}]")]
        public virtual void PutParkingTax(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsParkingTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsParkingTax)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResortTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsResortTax\"}}]")]
        public virtual void PutResortTax(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsResortTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsResortTax)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStateSalesTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTax\"}}]")]
        public virtual void PutStateSalesTax(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTax)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTourismTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsTourismTax\"}}]")]
        public virtual void PutTourismTax(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsTourismTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsTourismTax)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUtilityUsersTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsUtilityUsersTax\"}}]")]
        public virtual void PutUtilityUsersTax(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsUtilityUsersTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsUtilityUsersTax)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdmissionsTax")]
        public virtual void ResetAdmissionsTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAttendanceTax")]
        public virtual void ResetAttendanceTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEntertainmentTax")]
        public virtual void ResetEntertainmentTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGrossReceiptsTax")]
        public virtual void ResetGrossReceiptsTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHospitalityTax")]
        public virtual void ResetHospitalityTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalAmusementTax")]
        public virtual void ResetLocalAmusementTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalLeaseTax")]
        public virtual void ResetLocalLeaseTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLuxuryTax")]
        public virtual void ResetLuxuryTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMassTransitParkingTax")]
        public virtual void ResetMassTransitParkingTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParkingTax")]
        public virtual void ResetParkingTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResortTax")]
        public virtual void ResetResortTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStateSalesTax")]
        public virtual void ResetStateSalesTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTourismTax")]
        public virtual void ResetTourismTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUtilityUsersTax")]
        public virtual void ResetUtilityUsersTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "admissionsTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsAdmissionsTaxOutputReference\"}")]
        public virtual stripe.TaxRegistration.TaxRegistrationCountryOptionsUsAdmissionsTaxOutputReference AdmissionsTax
        {
            get => GetInstanceProperty<stripe.TaxRegistration.TaxRegistrationCountryOptionsUsAdmissionsTaxOutputReference>()!;
        }

        [JsiiProperty(name: "attendanceTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsAttendanceTaxOutputReference\"}")]
        public virtual stripe.TaxRegistration.TaxRegistrationCountryOptionsUsAttendanceTaxOutputReference AttendanceTax
        {
            get => GetInstanceProperty<stripe.TaxRegistration.TaxRegistrationCountryOptionsUsAttendanceTaxOutputReference>()!;
        }

        [JsiiProperty(name: "entertainmentTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsEntertainmentTaxOutputReference\"}")]
        public virtual stripe.TaxRegistration.TaxRegistrationCountryOptionsUsEntertainmentTaxOutputReference EntertainmentTax
        {
            get => GetInstanceProperty<stripe.TaxRegistration.TaxRegistrationCountryOptionsUsEntertainmentTaxOutputReference>()!;
        }

        [JsiiProperty(name: "grossReceiptsTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsGrossReceiptsTaxOutputReference\"}")]
        public virtual stripe.TaxRegistration.TaxRegistrationCountryOptionsUsGrossReceiptsTaxOutputReference GrossReceiptsTax
        {
            get => GetInstanceProperty<stripe.TaxRegistration.TaxRegistrationCountryOptionsUsGrossReceiptsTaxOutputReference>()!;
        }

        [JsiiProperty(name: "hospitalityTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsHospitalityTaxOutputReference\"}")]
        public virtual stripe.TaxRegistration.TaxRegistrationCountryOptionsUsHospitalityTaxOutputReference HospitalityTax
        {
            get => GetInstanceProperty<stripe.TaxRegistration.TaxRegistrationCountryOptionsUsHospitalityTaxOutputReference>()!;
        }

        [JsiiProperty(name: "localAmusementTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalAmusementTaxOutputReference\"}")]
        public virtual stripe.TaxRegistration.TaxRegistrationCountryOptionsUsLocalAmusementTaxOutputReference LocalAmusementTax
        {
            get => GetInstanceProperty<stripe.TaxRegistration.TaxRegistrationCountryOptionsUsLocalAmusementTaxOutputReference>()!;
        }

        [JsiiProperty(name: "localLeaseTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalLeaseTaxOutputReference\"}")]
        public virtual stripe.TaxRegistration.TaxRegistrationCountryOptionsUsLocalLeaseTaxOutputReference LocalLeaseTax
        {
            get => GetInstanceProperty<stripe.TaxRegistration.TaxRegistrationCountryOptionsUsLocalLeaseTaxOutputReference>()!;
        }

        [JsiiProperty(name: "luxuryTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLuxuryTaxOutputReference\"}")]
        public virtual stripe.TaxRegistration.TaxRegistrationCountryOptionsUsLuxuryTaxOutputReference LuxuryTax
        {
            get => GetInstanceProperty<stripe.TaxRegistration.TaxRegistrationCountryOptionsUsLuxuryTaxOutputReference>()!;
        }

        [JsiiProperty(name: "massTransitParkingTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsMassTransitParkingTaxOutputReference\"}")]
        public virtual stripe.TaxRegistration.TaxRegistrationCountryOptionsUsMassTransitParkingTaxOutputReference MassTransitParkingTax
        {
            get => GetInstanceProperty<stripe.TaxRegistration.TaxRegistrationCountryOptionsUsMassTransitParkingTaxOutputReference>()!;
        }

        [JsiiProperty(name: "parkingTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsParkingTaxOutputReference\"}")]
        public virtual stripe.TaxRegistration.TaxRegistrationCountryOptionsUsParkingTaxOutputReference ParkingTax
        {
            get => GetInstanceProperty<stripe.TaxRegistration.TaxRegistrationCountryOptionsUsParkingTaxOutputReference>()!;
        }

        [JsiiProperty(name: "resortTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsResortTaxOutputReference\"}")]
        public virtual stripe.TaxRegistration.TaxRegistrationCountryOptionsUsResortTaxOutputReference ResortTax
        {
            get => GetInstanceProperty<stripe.TaxRegistration.TaxRegistrationCountryOptionsUsResortTaxOutputReference>()!;
        }

        [JsiiProperty(name: "stateSalesTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTaxOutputReference\"}")]
        public virtual stripe.TaxRegistration.TaxRegistrationCountryOptionsUsStateSalesTaxOutputReference StateSalesTax
        {
            get => GetInstanceProperty<stripe.TaxRegistration.TaxRegistrationCountryOptionsUsStateSalesTaxOutputReference>()!;
        }

        [JsiiProperty(name: "tourismTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsTourismTaxOutputReference\"}")]
        public virtual stripe.TaxRegistration.TaxRegistrationCountryOptionsUsTourismTaxOutputReference TourismTax
        {
            get => GetInstanceProperty<stripe.TaxRegistration.TaxRegistrationCountryOptionsUsTourismTaxOutputReference>()!;
        }

        [JsiiProperty(name: "utilityUsersTax", typeJson: "{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsUtilityUsersTaxOutputReference\"}")]
        public virtual stripe.TaxRegistration.TaxRegistrationCountryOptionsUsUtilityUsersTaxOutputReference UtilityUsersTax
        {
            get => GetInstanceProperty<stripe.TaxRegistration.TaxRegistrationCountryOptionsUsUtilityUsersTaxOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsAdmissionsTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "admissionsTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsAdmissionsTax\"}]}}", isOptional: true)]
        public virtual object? AdmissionsTaxInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsAttendanceTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "attendanceTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsAttendanceTax\"}]}}", isOptional: true)]
        public virtual object? AttendanceTaxInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsEntertainmentTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "entertainmentTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsEntertainmentTax\"}]}}", isOptional: true)]
        public virtual object? EntertainmentTaxInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsGrossReceiptsTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grossReceiptsTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsGrossReceiptsTax\"}]}}", isOptional: true)]
        public virtual object? GrossReceiptsTaxInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsHospitalityTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hospitalityTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsHospitalityTax\"}]}}", isOptional: true)]
        public virtual object? HospitalityTaxInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalAmusementTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "localAmusementTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalAmusementTax\"}]}}", isOptional: true)]
        public virtual object? LocalAmusementTaxInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLocalLeaseTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "localLeaseTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLocalLeaseTax\"}]}}", isOptional: true)]
        public virtual object? LocalLeaseTaxInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsLuxuryTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "luxuryTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsLuxuryTax\"}]}}", isOptional: true)]
        public virtual object? LuxuryTaxInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsMassTransitParkingTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "massTransitParkingTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsMassTransitParkingTax\"}]}}", isOptional: true)]
        public virtual object? MassTransitParkingTaxInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsParkingTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parkingTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsParkingTax\"}]}}", isOptional: true)]
        public virtual object? ParkingTaxInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsResortTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resortTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsResortTax\"}]}}", isOptional: true)]
        public virtual object? ResortTaxInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stateSalesTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTax\"}]}}", isOptional: true)]
        public virtual object? StateSalesTaxInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsTourismTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tourismTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsTourismTax\"}]}}", isOptional: true)]
        public virtual object? TourismTaxInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsUtilityUsersTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "utilityUsersTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsUtilityUsersTax\"}]}}", isOptional: true)]
        public virtual object? UtilityUsersTaxInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUs" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUs\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.TaxRegistration.ITaxRegistrationCountryOptionsUs cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUs).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
