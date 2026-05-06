using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OspGatewaySubscription
{
    [JsiiClass(nativeType: typeof(oci.OspGatewaySubscription.OspGatewaySubscriptionSubscriptionTaxInfoOutputReference), fullyQualifiedName: "oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionTaxInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OspGatewaySubscriptionSubscriptionTaxInfoOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OspGatewaySubscriptionSubscriptionTaxInfoOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OspGatewaySubscriptionSubscriptionTaxInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OspGatewaySubscriptionSubscriptionTaxInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetNoTaxReasonCode")]
        public virtual void ResetNoTaxReasonCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNoTaxReasonCodeDetails")]
        public virtual void ResetNoTaxReasonCodeDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaxCnpj")]
        public virtual void ResetTaxCnpj()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaxPayerId")]
        public virtual void ResetTaxPayerId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaxRegNumber")]
        public virtual void ResetTaxRegNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "noTaxReasonCodeDetailsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NoTaxReasonCodeDetailsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "noTaxReasonCodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NoTaxReasonCodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taxCnpjInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaxCnpjInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taxPayerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaxPayerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taxRegNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaxRegNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "noTaxReasonCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NoTaxReasonCode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "noTaxReasonCodeDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NoTaxReasonCodeDetails
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taxCnpj", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaxCnpj
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taxPayerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaxPayerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taxRegNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaxRegNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionTaxInfo\"}", isOptional: true)]
        public virtual oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionTaxInfo? InternalValue
        {
            get => GetInstanceProperty<oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionTaxInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
