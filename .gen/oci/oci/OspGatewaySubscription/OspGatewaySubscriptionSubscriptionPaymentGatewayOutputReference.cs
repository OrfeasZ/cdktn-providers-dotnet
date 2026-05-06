using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OspGatewaySubscription
{
    [JsiiClass(nativeType: typeof(oci.OspGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGatewayOutputReference), fullyQualifiedName: "oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGatewayOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OspGatewaySubscriptionSubscriptionPaymentGatewayOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OspGatewaySubscriptionSubscriptionPaymentGatewayOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OspGatewaySubscriptionSubscriptionPaymentGatewayOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OspGatewaySubscriptionSubscriptionPaymentGatewayOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMerchantDefinedData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData\"}}]")]
        public virtual void PutMerchantDefinedData(oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMerchantDefinedData")]
        public virtual void ResetMerchantDefinedData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "merchantDefinedData", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedDataOutputReference\"}")]
        public virtual oci.OspGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedDataOutputReference MerchantDefinedData
        {
            get => GetInstanceProperty<oci.OspGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedDataOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "merchantDefinedDataInput", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData\"}", isOptional: true)]
        public virtual oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData? MerchantDefinedDataInput
        {
            get => GetInstanceProperty<oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGateway\"}", isOptional: true)]
        public virtual oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentGateway? InternalValue
        {
            get => GetInstanceProperty<oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentGateway?>();
            set => SetInstanceProperty(value);
        }
    }
}
