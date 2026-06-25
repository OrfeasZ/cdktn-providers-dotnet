using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificateAuthority
{
    [JsiiClass(nativeType: typeof(oci.CertificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigActionDetailsOutputReference), fullyQualifiedName: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigActionDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CertificatesManagementCertificateAuthorityCertificateAuthorityConfigActionDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CertificatesManagementCertificateAuthorityCertificateAuthorityConfigActionDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CertificatesManagementCertificateAuthorityCertificateAuthorityConfigActionDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CertificatesManagementCertificateAuthorityCertificateAuthorityConfigActionDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetActionType")]
        public virtual void ResetActionType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificatePem")]
        public virtual void ResetCertificatePem()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificatePemInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificatePemInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificatePem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificatePem
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigActionDetails\"}", isOptional: true)]
        public virtual oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigActionDetails? InternalValue
        {
            get => GetInstanceProperty<oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigActionDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
