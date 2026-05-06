using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceIdentityConfiguration
{
    [JsiiInterface(nativeType: typeof(IBdsBdsInstanceIdentityConfigurationConfig), fullyQualifiedName: "oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationConfig")]
    public interface IBdsBdsInstanceIdentityConfigurationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#bds_instance_id BdsBdsInstanceIdentityConfiguration#bds_instance_id}.</summary>
        [JsiiProperty(name: "bdsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        string BdsInstanceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#cluster_admin_password BdsBdsInstanceIdentityConfiguration#cluster_admin_password}.</summary>
        [JsiiProperty(name: "clusterAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterAdminPassword
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#confidential_application_id BdsBdsInstanceIdentityConfiguration#confidential_application_id}.</summary>
        [JsiiProperty(name: "confidentialApplicationId", typeJson: "{\"primitive\":\"string\"}")]
        string ConfidentialApplicationId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#display_name BdsBdsInstanceIdentityConfiguration#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#identity_domain_id BdsBdsInstanceIdentityConfiguration#identity_domain_id}.</summary>
        [JsiiProperty(name: "identityDomainId", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityDomainId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#activate_iam_user_sync_configuration_trigger BdsBdsInstanceIdentityConfiguration#activate_iam_user_sync_configuration_trigger}.</summary>
        [JsiiProperty(name: "activateIamUserSyncConfigurationTrigger", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActivateIamUserSyncConfigurationTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#activate_upst_configuration_trigger BdsBdsInstanceIdentityConfiguration#activate_upst_configuration_trigger}.</summary>
        [JsiiProperty(name: "activateUpstConfigurationTrigger", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActivateUpstConfigurationTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>iam_user_sync_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#iam_user_sync_configuration_details BdsBdsInstanceIdentityConfiguration#iam_user_sync_configuration_details}
        /// </remarks>
        [JsiiProperty(name: "iamUserSyncConfigurationDetails", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails? IamUserSyncConfigurationDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#id BdsBdsInstanceIdentityConfiguration#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#refresh_confidential_application_trigger BdsBdsInstanceIdentityConfiguration#refresh_confidential_application_trigger}.</summary>
        [JsiiProperty(name: "refreshConfidentialApplicationTrigger", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RefreshConfidentialApplicationTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#refresh_upst_token_exchange_keytab_trigger BdsBdsInstanceIdentityConfiguration#refresh_upst_token_exchange_keytab_trigger}.</summary>
        [JsiiProperty(name: "refreshUpstTokenExchangeKeytabTrigger", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RefreshUpstTokenExchangeKeytabTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#timeouts BdsBdsInstanceIdentityConfiguration#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>upst_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#upst_configuration_details BdsBdsInstanceIdentityConfiguration#upst_configuration_details}
        /// </remarks>
        [JsiiProperty(name: "upstConfigurationDetails", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationUpstConfigurationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationUpstConfigurationDetails? UpstConfigurationDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsInstanceIdentityConfigurationConfig), fullyQualifiedName: "oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#bds_instance_id BdsBdsInstanceIdentityConfiguration#bds_instance_id}.</summary>
            [JsiiProperty(name: "bdsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string BdsInstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#cluster_admin_password BdsBdsInstanceIdentityConfiguration#cluster_admin_password}.</summary>
            [JsiiProperty(name: "clusterAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterAdminPassword
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#confidential_application_id BdsBdsInstanceIdentityConfiguration#confidential_application_id}.</summary>
            [JsiiProperty(name: "confidentialApplicationId", typeJson: "{\"primitive\":\"string\"}")]
            public string ConfidentialApplicationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#display_name BdsBdsInstanceIdentityConfiguration#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#identity_domain_id BdsBdsInstanceIdentityConfiguration#identity_domain_id}.</summary>
            [JsiiProperty(name: "identityDomainId", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityDomainId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#activate_iam_user_sync_configuration_trigger BdsBdsInstanceIdentityConfiguration#activate_iam_user_sync_configuration_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "activateIamUserSyncConfigurationTrigger", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActivateIamUserSyncConfigurationTrigger
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#activate_upst_configuration_trigger BdsBdsInstanceIdentityConfiguration#activate_upst_configuration_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "activateUpstConfigurationTrigger", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActivateUpstConfigurationTrigger
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>iam_user_sync_configuration_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#iam_user_sync_configuration_details BdsBdsInstanceIdentityConfiguration#iam_user_sync_configuration_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iamUserSyncConfigurationDetails", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails\"}", isOptional: true)]
            public oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails? IamUserSyncConfigurationDetails
            {
                get => GetInstanceProperty<oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationIamUserSyncConfigurationDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#id BdsBdsInstanceIdentityConfiguration#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#refresh_confidential_application_trigger BdsBdsInstanceIdentityConfiguration#refresh_confidential_application_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "refreshConfidentialApplicationTrigger", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RefreshConfidentialApplicationTrigger
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#refresh_upst_token_exchange_keytab_trigger BdsBdsInstanceIdentityConfiguration#refresh_upst_token_exchange_keytab_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "refreshUpstTokenExchangeKeytabTrigger", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RefreshUpstTokenExchangeKeytabTrigger
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#timeouts BdsBdsInstanceIdentityConfiguration#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationTimeouts\"}", isOptional: true)]
            public oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationTimeouts?>();
            }

            /// <summary>upst_configuration_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#upst_configuration_details BdsBdsInstanceIdentityConfiguration#upst_configuration_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upstConfigurationDetails", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationUpstConfigurationDetails\"}", isOptional: true)]
            public oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationUpstConfigurationDetails? UpstConfigurationDetails
            {
                get => GetInstanceProperty<oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationUpstConfigurationDetails?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
