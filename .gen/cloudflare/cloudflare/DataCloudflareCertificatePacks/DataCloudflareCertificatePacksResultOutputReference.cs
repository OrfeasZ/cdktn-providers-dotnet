using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCertificatePacks
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareCertificatePacks.DataCloudflareCertificatePacksResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareCertificatePacks.DataCloudflareCertificatePacksResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareCertificatePacksResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareCertificatePacksResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareCertificatePacksResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareCertificatePacksResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "certificateAuthority", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateAuthority
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificates", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCertificatePacks.DataCloudflareCertificatePacksResultCertificatesList\"}")]
        public virtual cloudflare.DataCloudflareCertificatePacks.DataCloudflareCertificatePacksResultCertificatesList Certificates
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCertificatePacks.DataCloudflareCertificatePacksResultCertificatesList>()!;
        }

        [JsiiProperty(name: "cloudflareBranding", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CloudflareBranding
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "dcvDelegationRecords", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCertificatePacks.DataCloudflareCertificatePacksResultDcvDelegationRecordsList\"}")]
        public virtual cloudflare.DataCloudflareCertificatePacks.DataCloudflareCertificatePacksResultDcvDelegationRecordsList DcvDelegationRecords
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCertificatePacks.DataCloudflareCertificatePacksResultDcvDelegationRecordsList>()!;
        }

        [JsiiProperty(name: "hosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Hosts
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "validationErrors", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCertificatePacks.DataCloudflareCertificatePacksResultValidationErrorsList\"}")]
        public virtual cloudflare.DataCloudflareCertificatePacks.DataCloudflareCertificatePacksResultValidationErrorsList ValidationErrors
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCertificatePacks.DataCloudflareCertificatePacksResultValidationErrorsList>()!;
        }

        [JsiiProperty(name: "validationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ValidationMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "validationRecords", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCertificatePacks.DataCloudflareCertificatePacksResultValidationRecordsList\"}")]
        public virtual cloudflare.DataCloudflareCertificatePacks.DataCloudflareCertificatePacksResultValidationRecordsList ValidationRecords
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCertificatePacks.DataCloudflareCertificatePacksResultValidationRecordsList>()!;
        }

        [JsiiProperty(name: "validityDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ValidityDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCertificatePacks.DataCloudflareCertificatePacksResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareCertificatePacks.IDataCloudflareCertificatePacksResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCertificatePacks.IDataCloudflareCertificatePacksResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
