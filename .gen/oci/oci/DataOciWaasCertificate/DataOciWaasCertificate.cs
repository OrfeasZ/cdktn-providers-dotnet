using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciWaasCertificate
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/waas_certificate oci_waas_certificate}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciWaasCertificate.DataOciWaasCertificate), fullyQualifiedName: "oci.dataOciWaasCertificate.DataOciWaasCertificate", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciWaasCertificate.DataOciWaasCertificateConfig\"}}]")]
    public class DataOciWaasCertificate : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/waas_certificate oci_waas_certificate} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciWaasCertificate(Constructs.Construct scope, string id, oci.DataOciWaasCertificate.IDataOciWaasCertificateConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciWaasCertificate.IDataOciWaasCertificateConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciWaasCertificate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciWaasCertificate(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciWaasCertificate resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciWaasCertificate to import.</param>
        /// <param name="importFromId">The id of the existing DataOciWaasCertificate that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciWaasCertificate to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciWaasCertificate to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/waas_certificate#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciWaasCertificate that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciWaasCertificate to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciWaasCertificate.DataOciWaasCertificate), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciWaasCertificate.DataOciWaasCertificate))!;

        [JsiiProperty(name: "certificateData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateData
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "extensions", typeJson: "{\"fqn\":\"oci.dataOciWaasCertificate.DataOciWaasCertificateExtensionsList\"}")]
        public virtual oci.DataOciWaasCertificate.DataOciWaasCertificateExtensionsList Extensions
        {
            get => GetInstanceProperty<oci.DataOciWaasCertificate.DataOciWaasCertificateExtensionsList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuedBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssuedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuerName", typeJson: "{\"fqn\":\"oci.dataOciWaasCertificate.DataOciWaasCertificateIssuerNameList\"}")]
        public virtual oci.DataOciWaasCertificate.DataOciWaasCertificateIssuerNameList IssuerName
        {
            get => GetInstanceProperty<oci.DataOciWaasCertificate.DataOciWaasCertificateIssuerNameList>()!;
        }

        [JsiiProperty(name: "isTrustVerificationDisabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsTrustVerificationDisabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "privateKeyData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateKeyData
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicKeyInfo", typeJson: "{\"fqn\":\"oci.dataOciWaasCertificate.DataOciWaasCertificatePublicKeyInfoList\"}")]
        public virtual oci.DataOciWaasCertificate.DataOciWaasCertificatePublicKeyInfoList PublicKeyInfo
        {
            get => GetInstanceProperty<oci.DataOciWaasCertificate.DataOciWaasCertificatePublicKeyInfoList>()!;
        }

        [JsiiProperty(name: "serialNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SerialNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signatureAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SignatureAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subjectName", typeJson: "{\"fqn\":\"oci.dataOciWaasCertificate.DataOciWaasCertificateSubjectNameList\"}")]
        public virtual oci.DataOciWaasCertificate.DataOciWaasCertificateSubjectNameList SubjectName
        {
            get => GetInstanceProperty<oci.DataOciWaasCertificate.DataOciWaasCertificateSubjectNameList>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeNotValidAfter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeNotValidAfter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeNotValidBefore", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeNotValidBefore
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Version
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
