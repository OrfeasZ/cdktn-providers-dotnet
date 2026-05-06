using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceIdentityConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration oci_bds_bds_instance_identity_configuration}.</summary>
    [JsiiClass(nativeType: typeof(oci.BdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfiguration), fullyQualifiedName: "oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationConfig\"}}]")]
    public class BdsBdsInstanceIdentityConfiguration : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration oci_bds_bds_instance_identity_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BdsBdsInstanceIdentityConfiguration(Constructs.Construct scope, string id, oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BdsBdsInstanceIdentityConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BdsBdsInstanceIdentityConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a BdsBdsInstanceIdentityConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the BdsBdsInstanceIdentityConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing BdsBdsInstanceIdentityConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the BdsBdsInstanceIdentityConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the BdsBdsInstanceIdentityConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing BdsBdsInstanceIdentityConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the BdsBdsInstanceIdentityConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.BdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putIamUserSyncConfigurationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails\"}}]")]
        public virtual void PutIamUserSyncConfigurationDetails(oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpstConfigurationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationUpstConfigurationDetails\"}}]")]
        public virtual void PutUpstConfigurationDetails(oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationUpstConfigurationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationUpstConfigurationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActivateIamUserSyncConfigurationTrigger")]
        public virtual void ResetActivateIamUserSyncConfigurationTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetActivateUpstConfigurationTrigger")]
        public virtual void ResetActivateUpstConfigurationTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIamUserSyncConfigurationDetails")]
        public virtual void ResetIamUserSyncConfigurationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRefreshConfidentialApplicationTrigger")]
        public virtual void ResetRefreshConfidentialApplicationTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRefreshUpstTokenExchangeKeytabTrigger")]
        public virtual void ResetRefreshUpstTokenExchangeKeytabTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpstConfigurationDetails")]
        public virtual void ResetUpstConfigurationDetails()
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
        = GetStaticProperty<string>(typeof(oci.BdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfiguration))!;

        [JsiiProperty(name: "iamUserSyncConfiguration", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationList\"}")]
        public virtual oci.BdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationList IamUserSyncConfiguration
        {
            get => GetInstanceProperty<oci.BdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationList>()!;
        }

        [JsiiProperty(name: "iamUserSyncConfigurationDetails", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetailsOutputReference\"}")]
        public virtual oci.BdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetailsOutputReference IamUserSyncConfigurationDetails
        {
            get => GetInstanceProperty<oci.BdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetailsOutputReference>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationTimeoutsOutputReference\"}")]
        public virtual oci.BdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.BdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upstConfiguration", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationUpstConfigurationList\"}")]
        public virtual oci.BdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationUpstConfigurationList UpstConfiguration
        {
            get => GetInstanceProperty<oci.BdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationUpstConfigurationList>()!;
        }

        [JsiiProperty(name: "upstConfigurationDetails", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationUpstConfigurationDetailsOutputReference\"}")]
        public virtual oci.BdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationUpstConfigurationDetailsOutputReference UpstConfigurationDetails
        {
            get => GetInstanceProperty<oci.BdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationUpstConfigurationDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activateIamUserSyncConfigurationTriggerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActivateIamUserSyncConfigurationTriggerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "activateUpstConfigurationTriggerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActivateUpstConfigurationTriggerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bdsInstanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BdsInstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterAdminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterAdminPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "confidentialApplicationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfidentialApplicationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamUserSyncConfigurationDetailsInput", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails\"}", isOptional: true)]
        public virtual oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails? IamUserSyncConfigurationDetailsInput
        {
            get => GetInstanceProperty<oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityDomainIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentityDomainIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "refreshConfidentialApplicationTriggerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RefreshConfidentialApplicationTriggerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "refreshUpstTokenExchangeKeytabTriggerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RefreshUpstTokenExchangeKeytabTriggerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upstConfigurationDetailsInput", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationUpstConfigurationDetails\"}", isOptional: true)]
        public virtual oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationUpstConfigurationDetails? UpstConfigurationDetailsInput
        {
            get => GetInstanceProperty<oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationUpstConfigurationDetails?>();
        }

        [JsiiProperty(name: "activateIamUserSyncConfigurationTrigger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActivateIamUserSyncConfigurationTrigger
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "activateUpstConfigurationTrigger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActivateUpstConfigurationTrigger
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

        [JsiiProperty(name: "clusterAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterAdminPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "confidentialApplicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfidentialApplicationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "identityDomainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityDomainId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "refreshConfidentialApplicationTrigger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefreshConfidentialApplicationTrigger
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "refreshUpstTokenExchangeKeytabTrigger", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefreshUpstTokenExchangeKeytabTrigger
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
