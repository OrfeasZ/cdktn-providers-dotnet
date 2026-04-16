using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessGroupExclude), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExclude")]
    public interface IZeroTrustAccessGroupExclude
    {
        /// <summary>An empty object which matches on all service tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#any_valid_service_token ZeroTrustAccessGroup#any_valid_service_token}
        /// </remarks>
        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAnyValidServiceToken\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAnyValidServiceToken? AnyValidServiceToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#auth_context ZeroTrustAccessGroup#auth_context}.</summary>
        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAuthContext\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAuthContext? AuthContext
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#auth_method ZeroTrustAccessGroup#auth_method}.</summary>
        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAuthMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAuthMethod? AuthMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#azure_ad ZeroTrustAccessGroup#azure_ad}.</summary>
        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAzureAd\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAzureAd? AzureAd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#certificate ZeroTrustAccessGroup#certificate}.</summary>
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeCertificate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeCertificate? Certificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#common_name ZeroTrustAccessGroup#common_name}.</summary>
        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeCommonName\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeCommonName? CommonName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#device_posture ZeroTrustAccessGroup#device_posture}.</summary>
        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeDevicePosture\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeDevicePosture? DevicePosture
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#email ZeroTrustAccessGroup#email}.</summary>
        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmail\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEmail? Email
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#email_domain ZeroTrustAccessGroup#email_domain}.</summary>
        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmailDomain\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEmailDomain? EmailDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#email_list ZeroTrustAccessGroup#email_list}.</summary>
        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmailListStruct\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEmailListStruct? EmailList
        {
            get
            {
                return null;
            }
        }

        /// <summary>An empty object which matches on all users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#everyone ZeroTrustAccessGroup#everyone}
        /// </remarks>
        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEveryone\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEveryone? Everyone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#external_evaluation ZeroTrustAccessGroup#external_evaluation}.</summary>
        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeExternalEvaluation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeExternalEvaluation? ExternalEvaluation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#geo ZeroTrustAccessGroup#geo}.</summary>
        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGeo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGeo? Geo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#github_organization ZeroTrustAccessGroup#github_organization}.</summary>
        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGithubOrganization\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGithubOrganization? GithubOrganization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#group ZeroTrustAccessGroup#group}.</summary>
        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGroup\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGroup? Group
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#gsuite ZeroTrustAccessGroup#gsuite}.</summary>
        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGsuite\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGsuite? Gsuite
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#ip ZeroTrustAccessGroup#ip}.</summary>
        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeIp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeIp? Ip
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#ip_list ZeroTrustAccessGroup#ip_list}.</summary>
        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeIpListStruct\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeIpListStruct? IpList
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#linked_app_token ZeroTrustAccessGroup#linked_app_token}.</summary>
        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeLinkedAppToken\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeLinkedAppToken? LinkedAppToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#login_method ZeroTrustAccessGroup#login_method}.</summary>
        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeLoginMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeLoginMethod? LoginMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#oidc ZeroTrustAccessGroup#oidc}.</summary>
        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeOidc\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeOidc? Oidc
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#okta ZeroTrustAccessGroup#okta}.</summary>
        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeOkta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeOkta? Okta
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#saml ZeroTrustAccessGroup#saml}.</summary>
        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeSaml\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeSaml? Saml
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#service_token ZeroTrustAccessGroup#service_token}.</summary>
        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeServiceToken\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeServiceToken? ServiceToken
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessGroupExclude), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExclude")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExclude
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>An empty object which matches on all service tokens.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#any_valid_service_token ZeroTrustAccessGroup#any_valid_service_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAnyValidServiceToken\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAnyValidServiceToken? AnyValidServiceToken
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAnyValidServiceToken?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#auth_context ZeroTrustAccessGroup#auth_context}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAuthContext\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAuthContext? AuthContext
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAuthContext?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#auth_method ZeroTrustAccessGroup#auth_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAuthMethod\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAuthMethod? AuthMethod
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAuthMethod?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#azure_ad ZeroTrustAccessGroup#azure_ad}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeAzureAd\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAzureAd? AzureAd
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeAzureAd?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#certificate ZeroTrustAccessGroup#certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeCertificate\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeCertificate? Certificate
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeCertificate?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#common_name ZeroTrustAccessGroup#common_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeCommonName\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeCommonName? CommonName
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeCommonName?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#device_posture ZeroTrustAccessGroup#device_posture}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeDevicePosture\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeDevicePosture? DevicePosture
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeDevicePosture?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#email ZeroTrustAccessGroup#email}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmail\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEmail? Email
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEmail?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#email_domain ZeroTrustAccessGroup#email_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmailDomain\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEmailDomain? EmailDomain
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEmailDomain?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#email_list ZeroTrustAccessGroup#email_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEmailListStruct\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEmailListStruct? EmailList
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEmailListStruct?>();
            }

            /// <summary>An empty object which matches on all users.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#everyone ZeroTrustAccessGroup#everyone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeEveryone\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEveryone? Everyone
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeEveryone?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#external_evaluation ZeroTrustAccessGroup#external_evaluation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeExternalEvaluation\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeExternalEvaluation? ExternalEvaluation
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeExternalEvaluation?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#geo ZeroTrustAccessGroup#geo}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGeo\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGeo? Geo
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGeo?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#github_organization ZeroTrustAccessGroup#github_organization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGithubOrganization\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGithubOrganization? GithubOrganization
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGithubOrganization?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#group ZeroTrustAccessGroup#group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGroup\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGroup? Group
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGroup?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#gsuite ZeroTrustAccessGroup#gsuite}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeGsuite\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGsuite? Gsuite
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeGsuite?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#ip ZeroTrustAccessGroup#ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeIp\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeIp? Ip
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeIp?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#ip_list ZeroTrustAccessGroup#ip_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeIpListStruct\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeIpListStruct? IpList
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeIpListStruct?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#linked_app_token ZeroTrustAccessGroup#linked_app_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeLinkedAppToken\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeLinkedAppToken? LinkedAppToken
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeLinkedAppToken?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#login_method ZeroTrustAccessGroup#login_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeLoginMethod\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeLoginMethod? LoginMethod
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeLoginMethod?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#oidc ZeroTrustAccessGroup#oidc}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeOidc\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeOidc? Oidc
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeOidc?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#okta ZeroTrustAccessGroup#okta}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeOkta\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeOkta? Okta
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeOkta?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#saml ZeroTrustAccessGroup#saml}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeSaml\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeSaml? Saml
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeSaml?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#service_token ZeroTrustAccessGroup#service_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeServiceToken\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeServiceToken? ServiceToken
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeServiceToken?>();
            }
        }
    }
}
