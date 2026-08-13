using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    [JsiiClass(nativeType: typeof(stripe.Source.SourceCardPresentOutputReference), fullyQualifiedName: "stripe.source.SourceCardPresentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SourceCardPresentOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SourceCardPresentOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SourceCardPresentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SourceCardPresentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "applicationCryptogram", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationCryptogram
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "applicationPreferredName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationPreferredName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authorizationCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizationCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authorizationResponseCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizationResponseCode
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

        [JsiiProperty(name: "cvmType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CvmType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dedicatedFileName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DedicatedFileName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emvAuthData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmvAuthData
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "evidenceCustomerSignature", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EvidenceCustomerSignature
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "evidenceTransactionCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EvidenceTransactionCertificate
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

        [JsiiProperty(name: "posDeviceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PosDeviceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "posEntryMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PosEntryMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reader", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Reader
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "readMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReadMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "terminalVerificationResults", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TerminalVerificationResults
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "transactionStatusInformation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransactionStatusInformation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.source.SourceCardPresent\"}", isOptional: true)]
        public virtual stripe.Source.ISourceCardPresent? InternalValue
        {
            get => GetInstanceProperty<stripe.Source.ISourceCardPresent?>();
            set => SetInstanceProperty(value);
        }
    }
}
