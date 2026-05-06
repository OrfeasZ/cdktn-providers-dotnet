using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificate
{
    [JsiiClass(nativeType: typeof(oci.CertificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigValidityOutputReference), fullyQualifiedName: "oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigValidityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CertificatesManagementCertificateCertificateConfigValidityOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CertificatesManagementCertificateCertificateConfigValidityOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CertificatesManagementCertificateCertificateConfigValidityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CertificatesManagementCertificateCertificateConfigValidityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTimeOfValidityNotBefore")]
        public virtual void ResetTimeOfValidityNotBefore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeOfValidityNotAfterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeOfValidityNotAfterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeOfValidityNotBeforeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeOfValidityNotBeforeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "timeOfValidityNotAfter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfValidityNotAfter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeOfValidityNotBefore", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfValidityNotBefore
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigValidity\"}", isOptional: true)]
        public virtual oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfigValidity? InternalValue
        {
            get => GetInstanceProperty<oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfigValidity?>();
            set => SetInstanceProperty(value);
        }
    }
}
