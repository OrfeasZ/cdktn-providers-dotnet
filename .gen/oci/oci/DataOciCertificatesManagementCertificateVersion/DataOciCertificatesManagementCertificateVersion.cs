using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCertificatesManagementCertificateVersion
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/certificates_management_certificate_version oci_certificates_management_certificate_version}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciCertificatesManagementCertificateVersion.DataOciCertificatesManagementCertificateVersion), fullyQualifiedName: "oci.dataOciCertificatesManagementCertificateVersion.DataOciCertificatesManagementCertificateVersion", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciCertificatesManagementCertificateVersion.DataOciCertificatesManagementCertificateVersionConfig\"}}]")]
    public class DataOciCertificatesManagementCertificateVersion : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/certificates_management_certificate_version oci_certificates_management_certificate_version} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciCertificatesManagementCertificateVersion(Constructs.Construct scope, string id, oci.DataOciCertificatesManagementCertificateVersion.IDataOciCertificatesManagementCertificateVersionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciCertificatesManagementCertificateVersion.IDataOciCertificatesManagementCertificateVersionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCertificatesManagementCertificateVersion(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCertificatesManagementCertificateVersion(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciCertificatesManagementCertificateVersion resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciCertificatesManagementCertificateVersion to import.</param>
        /// <param name="importFromId">The id of the existing DataOciCertificatesManagementCertificateVersion that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciCertificatesManagementCertificateVersion to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciCertificatesManagementCertificateVersion to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/certificates_management_certificate_version#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciCertificatesManagementCertificateVersion that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciCertificatesManagementCertificateVersion to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciCertificatesManagementCertificateVersion.DataOciCertificatesManagementCertificateVersion), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(oci.DataOciCertificatesManagementCertificateVersion.DataOciCertificatesManagementCertificateVersion))!;

        [JsiiProperty(name: "issuerCaVersionNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssuerCaVersionNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "revocationStatus", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificateVersion.DataOciCertificatesManagementCertificateVersionRevocationStatusList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificateVersion.DataOciCertificatesManagementCertificateVersionRevocationStatusList RevocationStatus
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificateVersion.DataOciCertificatesManagementCertificateVersionRevocationStatusList>()!;
        }

        [JsiiProperty(name: "serialNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SerialNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Stages
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificateVersion.DataOciCertificatesManagementCertificateVersionSubjectAlternativeNamesList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificateVersion.DataOciCertificatesManagementCertificateVersionSubjectAlternativeNamesList SubjectAlternativeNames
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificateVersion.DataOciCertificatesManagementCertificateVersionSubjectAlternativeNamesList>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfDeletion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfDeletion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "validity", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificateVersion.DataOciCertificatesManagementCertificateVersionValidityList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificateVersion.DataOciCertificatesManagementCertificateVersionValidityList Validity
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificateVersion.DataOciCertificatesManagementCertificateVersionValidityList>()!;
        }

        [JsiiProperty(name: "versionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versionNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateVersionNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateVersionNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateVersionNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateVersionNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
