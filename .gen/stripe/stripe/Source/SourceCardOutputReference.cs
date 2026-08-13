using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    [JsiiClass(nativeType: typeof(stripe.Source.SourceCardOutputReference), fullyQualifiedName: "stripe.source.SourceCardOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SourceCardOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SourceCardOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SourceCardOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SourceCardOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addressLine1Check", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressLine1Check
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "addressZipCheck", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressZipCheck
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "brand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Brand
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Country
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cvcCheck", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CvcCheck
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dynamicLast4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DynamicLast4
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expMonth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExpMonth
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "expYear", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExpYear
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "fingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fingerprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "funding", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Funding
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "iin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Iin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issuer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "last4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Last4
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "threeDSecure", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ThreeDSecure
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tokenizationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TokenizationMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.source.SourceCard\"}", isOptional: true)]
        public virtual stripe.Source.ISourceCard? InternalValue
        {
            get => GetInstanceProperty<stripe.Source.ISourceCard?>();
            set => SetInstanceProperty(value);
        }
    }
}
