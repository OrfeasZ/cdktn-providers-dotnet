using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessGroupInclude), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupInclude")]
    public interface IZeroTrustAccessGroupInclude
    {
        /// <summary>An empty object which matches on all service tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#any_valid_service_token ZeroTrustAccessGroup#any_valid_service_token}
        /// </remarks>
        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAnyValidServiceToken\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAnyValidServiceToken? AnyValidServiceToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#auth_context ZeroTrustAccessGroup#auth_context}.</summary>
        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAuthContext\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAuthContext? AuthContext
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#auth_method ZeroTrustAccessGroup#auth_method}.</summary>
        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAuthMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAuthMethod? AuthMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#azure_ad ZeroTrustAccessGroup#azure_ad}.</summary>
        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAzureAd\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAzureAd? AzureAd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#certificate ZeroTrustAccessGroup#certificate}.</summary>
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeCertificate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeCertificate? Certificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#common_name ZeroTrustAccessGroup#common_name}.</summary>
        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeCommonName\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeCommonName? CommonName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#device_posture ZeroTrustAccessGroup#device_posture}.</summary>
        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeDevicePosture\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeDevicePosture? DevicePosture
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#email ZeroTrustAccessGroup#email}.</summary>
        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmail\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEmail? Email
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#email_domain ZeroTrustAccessGroup#email_domain}.</summary>
        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmailDomain\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEmailDomain? EmailDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#email_list ZeroTrustAccessGroup#email_list}.</summary>
        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmailListStruct\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEmailListStruct? EmailList
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
        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEveryone\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEveryone? Everyone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#external_evaluation ZeroTrustAccessGroup#external_evaluation}.</summary>
        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeExternalEvaluation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeExternalEvaluation? ExternalEvaluation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#geo ZeroTrustAccessGroup#geo}.</summary>
        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGeo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGeo? Geo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#github_organization ZeroTrustAccessGroup#github_organization}.</summary>
        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGithubOrganization\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGithubOrganization? GithubOrganization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#group ZeroTrustAccessGroup#group}.</summary>
        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGroup\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGroup? Group
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#gsuite ZeroTrustAccessGroup#gsuite}.</summary>
        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGsuite\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGsuite? Gsuite
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#ip ZeroTrustAccessGroup#ip}.</summary>
        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeIp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeIp? Ip
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#ip_list ZeroTrustAccessGroup#ip_list}.</summary>
        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeIpListStruct\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeIpListStruct? IpList
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#linked_app_token ZeroTrustAccessGroup#linked_app_token}.</summary>
        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeLinkedAppToken\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeLinkedAppToken? LinkedAppToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#login_method ZeroTrustAccessGroup#login_method}.</summary>
        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeLoginMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeLoginMethod? LoginMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#oidc ZeroTrustAccessGroup#oidc}.</summary>
        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeOidc\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeOidc? Oidc
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#okta ZeroTrustAccessGroup#okta}.</summary>
        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeOkta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeOkta? Okta
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#saml ZeroTrustAccessGroup#saml}.</summary>
        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeSaml\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeSaml? Saml
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#service_token ZeroTrustAccessGroup#service_token}.</summary>
        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeServiceToken\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeServiceToken? ServiceToken
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessGroupInclude), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupInclude")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupInclude
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>An empty object which matches on all service tokens.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#any_valid_service_token ZeroTrustAccessGroup#any_valid_service_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAnyValidServiceToken\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAnyValidServiceToken? AnyValidServiceToken
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAnyValidServiceToken?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#auth_context ZeroTrustAccessGroup#auth_context}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAuthContext\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAuthContext? AuthContext
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAuthContext?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#auth_method ZeroTrustAccessGroup#auth_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAuthMethod\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAuthMethod? AuthMethod
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAuthMethod?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#azure_ad ZeroTrustAccessGroup#azure_ad}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAzureAd\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAzureAd? AzureAd
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAzureAd?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#certificate ZeroTrustAccessGroup#certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeCertificate\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeCertificate? Certificate
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeCertificate?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#common_name ZeroTrustAccessGroup#common_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeCommonName\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeCommonName? CommonName
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeCommonName?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#device_posture ZeroTrustAccessGroup#device_posture}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeDevicePosture\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeDevicePosture? DevicePosture
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeDevicePosture?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#email ZeroTrustAccessGroup#email}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmail\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEmail? Email
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEmail?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#email_domain ZeroTrustAccessGroup#email_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmailDomain\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEmailDomain? EmailDomain
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEmailDomain?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#email_list ZeroTrustAccessGroup#email_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmailListStruct\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEmailListStruct? EmailList
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEmailListStruct?>();
            }

            /// <summary>An empty object which matches on all users.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#everyone ZeroTrustAccessGroup#everyone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEveryone\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEveryone? Everyone
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEveryone?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#external_evaluation ZeroTrustAccessGroup#external_evaluation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeExternalEvaluation\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeExternalEvaluation? ExternalEvaluation
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeExternalEvaluation?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#geo ZeroTrustAccessGroup#geo}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGeo\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGeo? Geo
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGeo?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#github_organization ZeroTrustAccessGroup#github_organization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGithubOrganization\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGithubOrganization? GithubOrganization
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGithubOrganization?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#group ZeroTrustAccessGroup#group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGroup\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGroup? Group
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGroup?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#gsuite ZeroTrustAccessGroup#gsuite}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGsuite\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGsuite? Gsuite
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGsuite?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#ip ZeroTrustAccessGroup#ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeIp\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeIp? Ip
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeIp?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#ip_list ZeroTrustAccessGroup#ip_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeIpListStruct\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeIpListStruct? IpList
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeIpListStruct?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#linked_app_token ZeroTrustAccessGroup#linked_app_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeLinkedAppToken\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeLinkedAppToken? LinkedAppToken
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeLinkedAppToken?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#login_method ZeroTrustAccessGroup#login_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeLoginMethod\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeLoginMethod? LoginMethod
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeLoginMethod?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#oidc ZeroTrustAccessGroup#oidc}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeOidc\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeOidc? Oidc
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeOidc?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#okta ZeroTrustAccessGroup#okta}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeOkta\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeOkta? Okta
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeOkta?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#saml ZeroTrustAccessGroup#saml}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeSaml\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeSaml? Saml
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeSaml?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#service_token ZeroTrustAccessGroup#service_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeServiceToken\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeServiceToken? ServiceToken
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeServiceToken?>();
            }
        }
    }
}
