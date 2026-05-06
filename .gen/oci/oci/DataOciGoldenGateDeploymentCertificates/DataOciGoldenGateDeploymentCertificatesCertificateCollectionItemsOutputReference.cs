using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciGoldenGateDeploymentCertificates
{
    [JsiiClass(nativeType: typeof(oci.DataOciGoldenGateDeploymentCertificates.DataOciGoldenGateDeploymentCertificatesCertificateCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciGoldenGateDeploymentCertificates.DataOciGoldenGateDeploymentCertificatesCertificateCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciGoldenGateDeploymentCertificatesCertificateCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciGoldenGateDeploymentCertificatesCertificateCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciGoldenGateDeploymentCertificatesCertificateCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGoldenGateDeploymentCertificatesCertificateCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authorityKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorityKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateContent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateContent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isCa", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCa
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isLockOverride", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLockOverride
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSelfSigned", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSelfSigned
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issuer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "md5Hash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Md5Hash
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicKeyAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicKeyAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicKeySize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicKeySize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serial", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Serial
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sha1Hash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sha1Hash
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Subject
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subjectKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubjectKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeValidFrom", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeValidFrom
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeValidTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeValidTo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateDeploymentCertificates.DataOciGoldenGateDeploymentCertificatesCertificateCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciGoldenGateDeploymentCertificates.IDataOciGoldenGateDeploymentCertificatesCertificateCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateDeploymentCertificates.IDataOciGoldenGateDeploymentCertificatesCertificateCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
