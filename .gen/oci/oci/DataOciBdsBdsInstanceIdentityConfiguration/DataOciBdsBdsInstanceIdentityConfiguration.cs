using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciBdsBdsInstanceIdentityConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/bds_bds_instance_identity_configuration oci_bds_bds_instance_identity_configuration}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciBdsBdsInstanceIdentityConfiguration.DataOciBdsBdsInstanceIdentityConfiguration), fullyQualifiedName: "oci.dataOciBdsBdsInstanceIdentityConfiguration.DataOciBdsBdsInstanceIdentityConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciBdsBdsInstanceIdentityConfiguration.DataOciBdsBdsInstanceIdentityConfigurationConfig\"}}]")]
    public class DataOciBdsBdsInstanceIdentityConfiguration : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/bds_bds_instance_identity_configuration oci_bds_bds_instance_identity_configuration} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciBdsBdsInstanceIdentityConfiguration(Constructs.Construct scope, string id, oci.DataOciBdsBdsInstanceIdentityConfiguration.IDataOciBdsBdsInstanceIdentityConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciBdsBdsInstanceIdentityConfiguration.IDataOciBdsBdsInstanceIdentityConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciBdsBdsInstanceIdentityConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciBdsBdsInstanceIdentityConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciBdsBdsInstanceIdentityConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciBdsBdsInstanceIdentityConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing DataOciBdsBdsInstanceIdentityConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciBdsBdsInstanceIdentityConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciBdsBdsInstanceIdentityConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/bds_bds_instance_identity_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciBdsBdsInstanceIdentityConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciBdsBdsInstanceIdentityConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciBdsBdsInstanceIdentityConfiguration.DataOciBdsBdsInstanceIdentityConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciBdsBdsInstanceIdentityConfiguration.DataOciBdsBdsInstanceIdentityConfiguration))!;

        [JsiiProperty(name: "activateIamUserSyncConfigurationTrigger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActivateIamUserSyncConfigurationTrigger
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "activateUpstConfigurationTrigger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActivateUpstConfigurationTrigger
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterAdminPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "confidentialApplicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfidentialApplicationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "iamUserSyncConfiguration", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstanceIdentityConfiguration.DataOciBdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationList\"}")]
        public virtual oci.DataOciBdsBdsInstanceIdentityConfiguration.DataOciBdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationList IamUserSyncConfiguration
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstanceIdentityConfiguration.DataOciBdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationList>()!;
        }

        [JsiiProperty(name: "iamUserSyncConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstanceIdentityConfiguration.DataOciBdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetailsList\"}")]
        public virtual oci.DataOciBdsBdsInstanceIdentityConfiguration.DataOciBdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetailsList IamUserSyncConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstanceIdentityConfiguration.DataOciBdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identityDomainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityDomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refreshConfidentialApplicationTrigger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefreshConfidentialApplicationTrigger
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refreshUpstTokenExchangeKeytabTrigger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefreshUpstTokenExchangeKeytabTrigger
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

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upstConfiguration", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstanceIdentityConfiguration.DataOciBdsBdsInstanceIdentityConfigurationUpstConfigurationList\"}")]
        public virtual oci.DataOciBdsBdsInstanceIdentityConfiguration.DataOciBdsBdsInstanceIdentityConfigurationUpstConfigurationList UpstConfiguration
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstanceIdentityConfiguration.DataOciBdsBdsInstanceIdentityConfigurationUpstConfigurationList>()!;
        }

        [JsiiProperty(name: "upstConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstanceIdentityConfiguration.DataOciBdsBdsInstanceIdentityConfigurationUpstConfigurationDetailsList\"}")]
        public virtual oci.DataOciBdsBdsInstanceIdentityConfiguration.DataOciBdsBdsInstanceIdentityConfigurationUpstConfigurationDetailsList UpstConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstanceIdentityConfiguration.DataOciBdsBdsInstanceIdentityConfigurationUpstConfigurationDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bdsInstanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BdsInstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityConfigurationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentityConfigurationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bdsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BdsInstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "identityConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityConfigurationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
