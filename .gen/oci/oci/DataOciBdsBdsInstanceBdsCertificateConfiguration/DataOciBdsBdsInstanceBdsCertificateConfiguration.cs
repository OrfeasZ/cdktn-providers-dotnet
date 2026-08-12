using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciBdsBdsInstanceBdsCertificateConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/bds_bds_instance_bds_certificate_configuration oci_bds_bds_instance_bds_certificate_configuration}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciBdsBdsInstanceBdsCertificateConfiguration.DataOciBdsBdsInstanceBdsCertificateConfiguration), fullyQualifiedName: "oci.dataOciBdsBdsInstanceBdsCertificateConfiguration.DataOciBdsBdsInstanceBdsCertificateConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciBdsBdsInstanceBdsCertificateConfiguration.DataOciBdsBdsInstanceBdsCertificateConfigurationConfig\"}}]")]
    public class DataOciBdsBdsInstanceBdsCertificateConfiguration : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/bds_bds_instance_bds_certificate_configuration oci_bds_bds_instance_bds_certificate_configuration} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciBdsBdsInstanceBdsCertificateConfiguration(Constructs.Construct scope, string id, oci.DataOciBdsBdsInstanceBdsCertificateConfiguration.IDataOciBdsBdsInstanceBdsCertificateConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciBdsBdsInstanceBdsCertificateConfiguration.IDataOciBdsBdsInstanceBdsCertificateConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciBdsBdsInstanceBdsCertificateConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciBdsBdsInstanceBdsCertificateConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciBdsBdsInstanceBdsCertificateConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciBdsBdsInstanceBdsCertificateConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing DataOciBdsBdsInstanceBdsCertificateConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciBdsBdsInstanceBdsCertificateConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciBdsBdsInstanceBdsCertificateConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/bds_bds_instance_bds_certificate_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciBdsBdsInstanceBdsCertificateConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciBdsBdsInstanceBdsCertificateConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciBdsBdsInstanceBdsCertificateConfiguration.DataOciBdsBdsInstanceBdsCertificateConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciBdsBdsInstanceBdsCertificateConfiguration.DataOciBdsBdsInstanceBdsCertificateConfiguration))!;

        [JsiiProperty(name: "certificateAuthorityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateAuthorityId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterAdminPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isDefaultConfiguration", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDefaultConfiguration
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isMissingNodesOnly", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMissingNodesOnly
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "issueCertificateTrigger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssueCertificateTrigger
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "renewCertificateTrigger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RenewCertificateTrigger
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "setDefaultTrigger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SetDefaultTrigger
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastRefreshedOrGenerated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastRefreshedOrGenerated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bdsCertificateConfigurationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BdsCertificateConfigurationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bdsInstanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BdsInstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bdsCertificateConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BdsCertificateConfigurationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bdsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BdsInstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
