using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    [JsiiClass(nativeType: typeof(stripe.Source.SourceAchCreditTransferOutputReference), fullyQualifiedName: "stripe.source.SourceAchCreditTransferOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SourceAchCreditTransferOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SourceAchCreditTransferOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SourceAchCreditTransferOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SourceAchCreditTransferOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bankName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BankName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fingerprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refundAccountHolderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefundAccountHolderName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refundAccountHolderType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefundAccountHolderType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refundRoutingNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefundRoutingNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routingNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "swiftCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SwiftCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.source.SourceAchCreditTransfer\"}", isOptional: true)]
        public virtual stripe.Source.ISourceAchCreditTransfer? InternalValue
        {
            get => GetInstanceProperty<stripe.Source.ISourceAchCreditTransfer?>();
            set => SetInstanceProperty(value);
        }
    }
}
