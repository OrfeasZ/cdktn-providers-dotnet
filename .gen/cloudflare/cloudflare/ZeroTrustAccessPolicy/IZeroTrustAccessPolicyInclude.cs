using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessPolicyInclude), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyInclude")]
    public interface IZeroTrustAccessPolicyInclude
    {
        /// <summary>An empty object which matches on all service tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#any_valid_service_token ZeroTrustAccessPolicy#any_valid_service_token}
        /// </remarks>
        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAnyValidServiceToken\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAnyValidServiceToken? AnyValidServiceToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#auth_context ZeroTrustAccessPolicy#auth_context}.</summary>
        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAuthContext\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAuthContext? AuthContext
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#auth_method ZeroTrustAccessPolicy#auth_method}.</summary>
        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAuthMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAuthMethod? AuthMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#azure_ad ZeroTrustAccessPolicy#azure_ad}.</summary>
        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAzureAd\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAzureAd? AzureAd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#certificate ZeroTrustAccessPolicy#certificate}.</summary>
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeCertificate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeCertificate? Certificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#common_name ZeroTrustAccessPolicy#common_name}.</summary>
        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeCommonName\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeCommonName? CommonName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#device_posture ZeroTrustAccessPolicy#device_posture}.</summary>
        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeDevicePosture\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeDevicePosture? DevicePosture
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#email ZeroTrustAccessPolicy#email}.</summary>
        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmail\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEmail? Email
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#email_domain ZeroTrustAccessPolicy#email_domain}.</summary>
        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmailDomain\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEmailDomain? EmailDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#email_list ZeroTrustAccessPolicy#email_list}.</summary>
        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmailListStruct\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEmailListStruct? EmailList
        {
            get
            {
                return null;
            }
        }

        /// <summary>An empty object which matches on all users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#everyone ZeroTrustAccessPolicy#everyone}
        /// </remarks>
        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEveryone\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEveryone? Everyone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#external_evaluation ZeroTrustAccessPolicy#external_evaluation}.</summary>
        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeExternalEvaluation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeExternalEvaluation? ExternalEvaluation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#geo ZeroTrustAccessPolicy#geo}.</summary>
        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGeo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGeo? Geo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#github_organization ZeroTrustAccessPolicy#github_organization}.</summary>
        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGithubOrganization\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGithubOrganization? GithubOrganization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#group ZeroTrustAccessPolicy#group}.</summary>
        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGroup\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGroup? Group
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#gsuite ZeroTrustAccessPolicy#gsuite}.</summary>
        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGsuite\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGsuite? Gsuite
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#ip ZeroTrustAccessPolicy#ip}.</summary>
        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeIp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeIp? Ip
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#ip_list ZeroTrustAccessPolicy#ip_list}.</summary>
        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeIpListStruct\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeIpListStruct? IpList
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#linked_app_token ZeroTrustAccessPolicy#linked_app_token}.</summary>
        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeLinkedAppToken\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeLinkedAppToken? LinkedAppToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#login_method ZeroTrustAccessPolicy#login_method}.</summary>
        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeLoginMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeLoginMethod? LoginMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#oidc ZeroTrustAccessPolicy#oidc}.</summary>
        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeOidc\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeOidc? Oidc
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#okta ZeroTrustAccessPolicy#okta}.</summary>
        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeOkta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeOkta? Okta
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#saml ZeroTrustAccessPolicy#saml}.</summary>
        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeSaml\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeSaml? Saml
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#service_token ZeroTrustAccessPolicy#service_token}.</summary>
        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeServiceToken\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeServiceToken? ServiceToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#user_risk_score ZeroTrustAccessPolicy#user_risk_score}.</summary>
        [JsiiProperty(name: "userRiskScore", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeUserRiskScore\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeUserRiskScore? UserRiskScore
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessPolicyInclude), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyInclude")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyInclude
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>An empty object which matches on all service tokens.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#any_valid_service_token ZeroTrustAccessPolicy#any_valid_service_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAnyValidServiceToken\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAnyValidServiceToken? AnyValidServiceToken
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAnyValidServiceToken?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#auth_context ZeroTrustAccessPolicy#auth_context}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAuthContext\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAuthContext? AuthContext
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAuthContext?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#auth_method ZeroTrustAccessPolicy#auth_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAuthMethod\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAuthMethod? AuthMethod
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAuthMethod?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#azure_ad ZeroTrustAccessPolicy#azure_ad}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAzureAd\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAzureAd? AzureAd
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAzureAd?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#certificate ZeroTrustAccessPolicy#certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeCertificate\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeCertificate? Certificate
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeCertificate?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#common_name ZeroTrustAccessPolicy#common_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeCommonName\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeCommonName? CommonName
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeCommonName?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#device_posture ZeroTrustAccessPolicy#device_posture}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeDevicePosture\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeDevicePosture? DevicePosture
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeDevicePosture?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#email ZeroTrustAccessPolicy#email}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmail\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEmail? Email
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEmail?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#email_domain ZeroTrustAccessPolicy#email_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmailDomain\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEmailDomain? EmailDomain
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEmailDomain?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#email_list ZeroTrustAccessPolicy#email_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmailListStruct\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEmailListStruct? EmailList
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEmailListStruct?>();
            }

            /// <summary>An empty object which matches on all users.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#everyone ZeroTrustAccessPolicy#everyone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEveryone\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEveryone? Everyone
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEveryone?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#external_evaluation ZeroTrustAccessPolicy#external_evaluation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeExternalEvaluation\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeExternalEvaluation? ExternalEvaluation
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeExternalEvaluation?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#geo ZeroTrustAccessPolicy#geo}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGeo\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGeo? Geo
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGeo?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#github_organization ZeroTrustAccessPolicy#github_organization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGithubOrganization\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGithubOrganization? GithubOrganization
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGithubOrganization?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#group ZeroTrustAccessPolicy#group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGroup\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGroup? Group
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGroup?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#gsuite ZeroTrustAccessPolicy#gsuite}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGsuite\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGsuite? Gsuite
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGsuite?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#ip ZeroTrustAccessPolicy#ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeIp\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeIp? Ip
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeIp?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#ip_list ZeroTrustAccessPolicy#ip_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeIpListStruct\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeIpListStruct? IpList
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeIpListStruct?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#linked_app_token ZeroTrustAccessPolicy#linked_app_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeLinkedAppToken\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeLinkedAppToken? LinkedAppToken
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeLinkedAppToken?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#login_method ZeroTrustAccessPolicy#login_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeLoginMethod\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeLoginMethod? LoginMethod
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeLoginMethod?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#oidc ZeroTrustAccessPolicy#oidc}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeOidc\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeOidc? Oidc
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeOidc?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#okta ZeroTrustAccessPolicy#okta}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeOkta\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeOkta? Okta
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeOkta?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#saml ZeroTrustAccessPolicy#saml}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeSaml\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeSaml? Saml
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeSaml?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#service_token ZeroTrustAccessPolicy#service_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeServiceToken\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeServiceToken? ServiceToken
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeServiceToken?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#user_risk_score ZeroTrustAccessPolicy#user_risk_score}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userRiskScore", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeUserRiskScore\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeUserRiskScore? UserRiskScore
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeUserRiskScore?>();
            }
        }
    }
}
