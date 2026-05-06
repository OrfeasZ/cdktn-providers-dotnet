using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUser")]
    public interface IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#account_recovery_required IdentityDomainsUser#account_recovery_required}.</summary>
        [JsiiProperty(name: "accountRecoveryRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AccountRecoveryRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#bypass_notification IdentityDomainsUser#bypass_notification}.</summary>
        [JsiiProperty(name: "bypassNotification", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BypassNotification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#creation_mechanism IdentityDomainsUser#creation_mechanism}.</summary>
        [JsiiProperty(name: "creationMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreationMechanism
        {
            get
            {
                return null;
            }
        }

        /// <summary>delegated_authentication_target_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#delegated_authentication_target_app IdentityDomainsUser#delegated_authentication_target_app}
        /// </remarks>
        [JsiiProperty(name: "delegatedAuthenticationTargetApp", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserDelegatedAuthenticationTargetApp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserDelegatedAuthenticationTargetApp? DelegatedAuthenticationTargetApp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#do_not_show_getting_started IdentityDomainsUser#do_not_show_getting_started}.</summary>
        [JsiiProperty(name: "doNotShowGettingStarted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DoNotShowGettingStarted
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#is_authentication_delegated IdentityDomainsUser#is_authentication_delegated}.</summary>
        [JsiiProperty(name: "isAuthenticationDelegated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAuthenticationDelegated
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#is_federated_user IdentityDomainsUser#is_federated_user}.</summary>
        [JsiiProperty(name: "isFederatedUser", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsFederatedUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#is_group_membership_normalized IdentityDomainsUser#is_group_membership_normalized}.</summary>
        [JsiiProperty(name: "isGroupMembershipNormalized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsGroupMembershipNormalized
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#is_group_membership_synced_to_users_groups IdentityDomainsUser#is_group_membership_synced_to_users_groups}.</summary>
        [JsiiProperty(name: "isGroupMembershipSyncedToUsersGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsGroupMembershipSyncedToUsersGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#notification_email_template_id IdentityDomainsUser#notification_email_template_id}.</summary>
        [JsiiProperty(name: "notificationEmailTemplateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NotificationEmailTemplateId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#preferred_ui_landing_page IdentityDomainsUser#preferred_ui_landing_page}.</summary>
        [JsiiProperty(name: "preferredUiLandingPage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredUiLandingPage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#service_user IdentityDomainsUser#service_user}.</summary>
        [JsiiProperty(name: "serviceUser", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ServiceUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>synced_from_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#synced_from_app IdentityDomainsUser#synced_from_app}
        /// </remarks>
        [JsiiProperty(name: "syncedFromApp", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserSyncedFromApp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserSyncedFromApp? SyncedFromApp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#user_flow_controlled_by_external_client IdentityDomainsUser#user_flow_controlled_by_external_client}.</summary>
        [JsiiProperty(name: "userFlowControlledByExternalClient", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UserFlowControlledByExternalClient
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#user_provider IdentityDomainsUser#user_provider}.</summary>
        [JsiiProperty(name: "userProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserProvider
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUser")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#account_recovery_required IdentityDomainsUser#account_recovery_required}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountRecoveryRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AccountRecoveryRequired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#bypass_notification IdentityDomainsUser#bypass_notification}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bypassNotification", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? BypassNotification
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#creation_mechanism IdentityDomainsUser#creation_mechanism}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "creationMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreationMechanism
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>delegated_authentication_target_app block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#delegated_authentication_target_app IdentityDomainsUser#delegated_authentication_target_app}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "delegatedAuthenticationTargetApp", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserDelegatedAuthenticationTargetApp\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserDelegatedAuthenticationTargetApp? DelegatedAuthenticationTargetApp
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserDelegatedAuthenticationTargetApp?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#do_not_show_getting_started IdentityDomainsUser#do_not_show_getting_started}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "doNotShowGettingStarted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DoNotShowGettingStarted
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#is_authentication_delegated IdentityDomainsUser#is_authentication_delegated}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isAuthenticationDelegated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAuthenticationDelegated
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#is_federated_user IdentityDomainsUser#is_federated_user}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isFederatedUser", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsFederatedUser
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#is_group_membership_normalized IdentityDomainsUser#is_group_membership_normalized}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isGroupMembershipNormalized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsGroupMembershipNormalized
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#is_group_membership_synced_to_users_groups IdentityDomainsUser#is_group_membership_synced_to_users_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isGroupMembershipSyncedToUsersGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsGroupMembershipSyncedToUsersGroups
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#notification_email_template_id IdentityDomainsUser#notification_email_template_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notificationEmailTemplateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NotificationEmailTemplateId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#preferred_ui_landing_page IdentityDomainsUser#preferred_ui_landing_page}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preferredUiLandingPage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredUiLandingPage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#service_user IdentityDomainsUser#service_user}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceUser", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ServiceUser
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>synced_from_app block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#synced_from_app IdentityDomainsUser#synced_from_app}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "syncedFromApp", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserSyncedFromApp\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserSyncedFromApp? SyncedFromApp
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserSyncedFromApp?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#user_flow_controlled_by_external_client IdentityDomainsUser#user_flow_controlled_by_external_client}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userFlowControlledByExternalClient", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UserFlowControlledByExternalClient
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#user_provider IdentityDomainsUser#user_provider}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserProvider
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
