using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCertificatesManagementCertificateAuthority
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/certificates_management_certificate_authority oci_certificates_management_certificate_authority}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthority), fullyQualifiedName: "oci.dataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthority", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityConfig\"}}]")]
    public class DataOciCertificatesManagementCertificateAuthority : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/certificates_management_certificate_authority oci_certificates_management_certificate_authority} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciCertificatesManagementCertificateAuthority(Constructs.Construct scope, string id, oci.DataOciCertificatesManagementCertificateAuthority.IDataOciCertificatesManagementCertificateAuthorityConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciCertificatesManagementCertificateAuthority.IDataOciCertificatesManagementCertificateAuthorityConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCertificatesManagementCertificateAuthority(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCertificatesManagementCertificateAuthority(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciCertificatesManagementCertificateAuthority resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciCertificatesManagementCertificateAuthority to import.</param>
        /// <param name="importFromId">The id of the existing DataOciCertificatesManagementCertificateAuthority that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciCertificatesManagementCertificateAuthority to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciCertificatesManagementCertificateAuthority to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/certificates_management_certificate_authority#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciCertificatesManagementCertificateAuthority that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciCertificatesManagementCertificateAuthority to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthority), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthority))!;

        [JsiiProperty(name: "certificateAuthorityConfig", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCertificateAuthorityConfigList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCertificateAuthorityConfigList CertificateAuthorityConfig
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCertificateAuthorityConfigList>()!;
        }

        [JsiiProperty(name: "certificateAuthorityRules", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCertificateAuthorityRulesList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCertificateAuthorityRulesList CertificateAuthorityRules
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCertificateAuthorityRulesList>()!;
        }

        [JsiiProperty(name: "certificateRevocationListDetails", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCertificateRevocationListDetailsList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCertificateRevocationListDetailsList CertificateRevocationListDetails
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCertificateRevocationListDetailsList>()!;
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

        [JsiiProperty(name: "currentVersion", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCurrentVersionList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCurrentVersionList CurrentVersion
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCurrentVersionList>()!;
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

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
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

        [JsiiProperty(name: "signingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SigningAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subject", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthoritySubjectList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthoritySubjectList Subject
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthoritySubjectList>()!;
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
        [JsiiProperty(name: "certificateAuthorityIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateAuthorityIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "certificateAuthorityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateAuthorityId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
