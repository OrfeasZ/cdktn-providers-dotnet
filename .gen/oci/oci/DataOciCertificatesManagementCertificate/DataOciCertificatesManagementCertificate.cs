using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCertificatesManagementCertificate
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/certificates_management_certificate oci_certificates_management_certificate}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificate), fullyQualifiedName: "oci.dataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificate", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateConfig\"}}]")]
    public class DataOciCertificatesManagementCertificate : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/certificates_management_certificate oci_certificates_management_certificate} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciCertificatesManagementCertificate(Constructs.Construct scope, string id, oci.DataOciCertificatesManagementCertificate.IDataOciCertificatesManagementCertificateConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciCertificatesManagementCertificate.IDataOciCertificatesManagementCertificateConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCertificatesManagementCertificate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCertificatesManagementCertificate(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciCertificatesManagementCertificate resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciCertificatesManagementCertificate to import.</param>
        /// <param name="importFromId">The id of the existing DataOciCertificatesManagementCertificate that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciCertificatesManagementCertificate to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciCertificatesManagementCertificate to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/certificates_management_certificate#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciCertificatesManagementCertificate that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciCertificatesManagementCertificate to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificate), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificate))!;

        [JsiiProperty(name: "certificateConfig", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCertificateConfigList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCertificateConfigList CertificateConfig
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCertificateConfigList>()!;
        }

        [JsiiProperty(name: "certificateProfileType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateProfileType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateRevocationListDetails", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCertificateRevocationListDetailsList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCertificateRevocationListDetailsList CertificateRevocationListDetails
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCertificateRevocationListDetailsList>()!;
        }

        [JsiiProperty(name: "certificateRules", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCertificateRulesList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCertificateRulesList CertificateRules
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCertificateRulesList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentVersion", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCurrentVersionList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCurrentVersionList CurrentVersion
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCurrentVersionList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "issuerCertificateAuthorityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssuerCertificateAuthorityId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
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

        [JsiiProperty(name: "subject", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateSubjectList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateSubjectList Subject
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateSubjectList>()!;
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
