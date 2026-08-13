using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    [JsiiClass(nativeType: typeof(stripe.Source.SourceMultibancoOutputReference), fullyQualifiedName: "stripe.source.SourceMultibancoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SourceMultibancoOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SourceMultibancoOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SourceMultibancoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SourceMultibancoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "entity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Entity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Reference
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refundAccountHolderAddressCity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefundAccountHolderAddressCity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refundAccountHolderAddressCountry", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefundAccountHolderAddressCountry
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refundAccountHolderAddressLine1", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefundAccountHolderAddressLine1
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refundAccountHolderAddressLine2", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefundAccountHolderAddressLine2
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refundAccountHolderAddressPostalCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefundAccountHolderAddressPostalCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refundAccountHolderAddressState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefundAccountHolderAddressState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refundAccountHolderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefundAccountHolderName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refundIban", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefundIban
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.source.SourceMultibanco\"}", isOptional: true)]
        public virtual stripe.Source.ISourceMultibanco? InternalValue
        {
            get => GetInstanceProperty<stripe.Source.ISourceMultibanco?>();
            set => SetInstanceProperty(value);
        }
    }
}
