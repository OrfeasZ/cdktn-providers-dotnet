using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiByValue(fqn: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUser")]
    public class IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUser : oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUser
    {
        private object? _accountRecoveryRequired;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#account_recovery_required IdentityDomainsUser#account_recovery_required}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountRecoveryRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AccountRecoveryRequired
        {
            get => _accountRecoveryRequired;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _accountRecoveryRequired = value;
            }
        }

        private object? _bypassNotification;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#bypass_notification IdentityDomainsUser#bypass_notification}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bypassNotification", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? BypassNotification
        {
            get => _bypassNotification;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _bypassNotification = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#creation_mechanism IdentityDomainsUser#creation_mechanism}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "creationMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CreationMechanism
        {
            get;
            set;
        }

        /// <summary>delegated_authentication_target_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#delegated_authentication_target_app IdentityDomainsUser#delegated_authentication_target_app}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "delegatedAuthenticationTargetApp", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserDelegatedAuthenticationTargetApp\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserDelegatedAuthenticationTargetApp? DelegatedAuthenticationTargetApp
        {
            get;
            set;
        }

        private object? _doNotShowGettingStarted;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#do_not_show_getting_started IdentityDomainsUser#do_not_show_getting_started}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "doNotShowGettingStarted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DoNotShowGettingStarted
        {
            get => _doNotShowGettingStarted;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _doNotShowGettingStarted = value;
            }
        }

        private object? _isAuthenticationDelegated;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#is_authentication_delegated IdentityDomainsUser#is_authentication_delegated}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isAuthenticationDelegated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsAuthenticationDelegated
        {
            get => _isAuthenticationDelegated;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isAuthenticationDelegated = value;
            }
        }

        private object? _isFederatedUser;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#is_federated_user IdentityDomainsUser#is_federated_user}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isFederatedUser", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsFederatedUser
        {
            get => _isFederatedUser;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isFederatedUser = value;
            }
        }

        private object? _isGroupMembershipNormalized;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#is_group_membership_normalized IdentityDomainsUser#is_group_membership_normalized}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isGroupMembershipNormalized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsGroupMembershipNormalized
        {
            get => _isGroupMembershipNormalized;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isGroupMembershipNormalized = value;
            }
        }

        private object? _isGroupMembershipSyncedToUsersGroups;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#is_group_membership_synced_to_users_groups IdentityDomainsUser#is_group_membership_synced_to_users_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isGroupMembershipSyncedToUsersGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsGroupMembershipSyncedToUsersGroups
        {
            get => _isGroupMembershipSyncedToUsersGroups;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isGroupMembershipSyncedToUsersGroups = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#notification_email_template_id IdentityDomainsUser#notification_email_template_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notificationEmailTemplateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NotificationEmailTemplateId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#preferred_ui_landing_page IdentityDomainsUser#preferred_ui_landing_page}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preferredUiLandingPage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreferredUiLandingPage
        {
            get;
            set;
        }

        private object? _serviceUser;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#service_user IdentityDomainsUser#service_user}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceUser", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ServiceUser
        {
            get => _serviceUser;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _serviceUser = value;
            }
        }

        /// <summary>synced_from_app block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#synced_from_app IdentityDomainsUser#synced_from_app}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "syncedFromApp", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserSyncedFromApp\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserSyncedFromApp? SyncedFromApp
        {
            get;
            set;
        }

        private object? _userFlowControlledByExternalClient;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#user_flow_controlled_by_external_client IdentityDomainsUser#user_flow_controlled_by_external_client}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userFlowControlledByExternalClient", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? UserFlowControlledByExternalClient
        {
            get => _userFlowControlledByExternalClient;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _userFlowControlledByExternalClient = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#user_provider IdentityDomainsUser#user_provider}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserProvider
        {
            get;
            set;
        }
    }
}
