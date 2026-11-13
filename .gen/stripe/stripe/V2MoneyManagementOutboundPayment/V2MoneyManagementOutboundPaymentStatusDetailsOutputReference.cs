using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementOutboundPayment
{
    [JsiiClass(nativeType: typeof(stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentStatusDetailsOutputReference), fullyQualifiedName: "stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentStatusDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class V2MoneyManagementOutboundPaymentStatusDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public V2MoneyManagementOutboundPaymentStatusDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected V2MoneyManagementOutboundPaymentStatusDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2MoneyManagementOutboundPaymentStatusDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "failed", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentStatusDetailsFailedOutputReference\"}")]
        public virtual stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentStatusDetailsFailedOutputReference Failed
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentStatusDetailsFailedOutputReference>()!;
        }

        [JsiiProperty(name: "processing", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentStatusDetailsProcessingOutputReference\"}")]
        public virtual stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentStatusDetailsProcessingOutputReference Processing
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentStatusDetailsProcessingOutputReference>()!;
        }

        [JsiiProperty(name: "returned", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentStatusDetailsReturnedOutputReference\"}")]
        public virtual stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentStatusDetailsReturnedOutputReference Returned
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentStatusDetailsReturnedOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentStatusDetails\"}", isOptional: true)]
        public virtual stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentStatusDetails? InternalValue
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentStatusDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
