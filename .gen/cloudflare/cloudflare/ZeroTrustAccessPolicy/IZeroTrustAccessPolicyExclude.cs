using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessPolicyExclude), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExclude")]
    public interface IZeroTrustAccessPolicyExclude
    {
        /// <summary>An empty object which matches on all service tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#any_valid_service_token ZeroTrustAccessPolicy#any_valid_service_token}
        /// </remarks>
        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeAnyValidServiceToken\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeAnyValidServiceToken? AnyValidServiceToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#auth_context ZeroTrustAccessPolicy#auth_context}.</summary>
        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeAuthContext\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeAuthContext? AuthContext
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#auth_method ZeroTrustAccessPolicy#auth_method}.</summary>
        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeAuthMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeAuthMethod? AuthMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#azure_ad ZeroTrustAccessPolicy#azure_ad}.</summary>
        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeAzureAd\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeAzureAd? AzureAd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#certificate ZeroTrustAccessPolicy#certificate}.</summary>
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeCertificate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeCertificate? Certificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#common_name ZeroTrustAccessPolicy#common_name}.</summary>
        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeCommonName\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeCommonName? CommonName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#device_posture ZeroTrustAccessPolicy#device_posture}.</summary>
        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeDevicePosture\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeDevicePosture? DevicePosture
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#email ZeroTrustAccessPolicy#email}.</summary>
        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeEmail\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeEmail? Email
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#email_domain ZeroTrustAccessPolicy#email_domain}.</summary>
        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeEmailDomain\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeEmailDomain? EmailDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#email_list ZeroTrustAccessPolicy#email_list}.</summary>
        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeEmailListStruct\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeEmailListStruct? EmailList
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
        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeEveryone\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeEveryone? Everyone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#external_evaluation ZeroTrustAccessPolicy#external_evaluation}.</summary>
        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeExternalEvaluation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeExternalEvaluation? ExternalEvaluation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#geo ZeroTrustAccessPolicy#geo}.</summary>
        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeGeo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeGeo? Geo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#github_organization ZeroTrustAccessPolicy#github_organization}.</summary>
        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeGithubOrganization\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeGithubOrganization? GithubOrganization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#group ZeroTrustAccessPolicy#group}.</summary>
        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeGroup\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeGroup? Group
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#gsuite ZeroTrustAccessPolicy#gsuite}.</summary>
        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeGsuite\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeGsuite? Gsuite
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#ip ZeroTrustAccessPolicy#ip}.</summary>
        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeIp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeIp? Ip
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#ip_list ZeroTrustAccessPolicy#ip_list}.</summary>
        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeIpListStruct\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeIpListStruct? IpList
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#linked_app_token ZeroTrustAccessPolicy#linked_app_token}.</summary>
        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeLinkedAppToken\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeLinkedAppToken? LinkedAppToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#login_method ZeroTrustAccessPolicy#login_method}.</summary>
        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeLoginMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeLoginMethod? LoginMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#oidc ZeroTrustAccessPolicy#oidc}.</summary>
        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeOidc\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeOidc? Oidc
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#okta ZeroTrustAccessPolicy#okta}.</summary>
        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeOkta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeOkta? Okta
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#saml ZeroTrustAccessPolicy#saml}.</summary>
        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeSaml\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeSaml? Saml
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#service_token ZeroTrustAccessPolicy#service_token}.</summary>
        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeServiceToken\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeServiceToken? ServiceToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#user_risk_score ZeroTrustAccessPolicy#user_risk_score}.</summary>
        [JsiiProperty(name: "userRiskScore", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeUserRiskScore\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeUserRiskScore? UserRiskScore
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessPolicyExclude), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExclude")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExclude
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>An empty object which matches on all service tokens.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#any_valid_service_token ZeroTrustAccessPolicy#any_valid_service_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeAnyValidServiceToken\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeAnyValidServiceToken? AnyValidServiceToken
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeAnyValidServiceToken?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#auth_context ZeroTrustAccessPolicy#auth_context}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeAuthContext\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeAuthContext? AuthContext
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeAuthContext?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#auth_method ZeroTrustAccessPolicy#auth_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeAuthMethod\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeAuthMethod? AuthMethod
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeAuthMethod?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#azure_ad ZeroTrustAccessPolicy#azure_ad}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeAzureAd\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeAzureAd? AzureAd
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeAzureAd?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#certificate ZeroTrustAccessPolicy#certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeCertificate\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeCertificate? Certificate
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeCertificate?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#common_name ZeroTrustAccessPolicy#common_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeCommonName\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeCommonName? CommonName
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeCommonName?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#device_posture ZeroTrustAccessPolicy#device_posture}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeDevicePosture\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeDevicePosture? DevicePosture
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeDevicePosture?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#email ZeroTrustAccessPolicy#email}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeEmail\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeEmail? Email
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeEmail?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#email_domain ZeroTrustAccessPolicy#email_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeEmailDomain\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeEmailDomain? EmailDomain
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeEmailDomain?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#email_list ZeroTrustAccessPolicy#email_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeEmailListStruct\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeEmailListStruct? EmailList
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeEmailListStruct?>();
            }

            /// <summary>An empty object which matches on all users.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#everyone ZeroTrustAccessPolicy#everyone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeEveryone\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeEveryone? Everyone
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeEveryone?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#external_evaluation ZeroTrustAccessPolicy#external_evaluation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeExternalEvaluation\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeExternalEvaluation? ExternalEvaluation
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeExternalEvaluation?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#geo ZeroTrustAccessPolicy#geo}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeGeo\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeGeo? Geo
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeGeo?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#github_organization ZeroTrustAccessPolicy#github_organization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeGithubOrganization\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeGithubOrganization? GithubOrganization
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeGithubOrganization?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#group ZeroTrustAccessPolicy#group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeGroup\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeGroup? Group
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeGroup?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#gsuite ZeroTrustAccessPolicy#gsuite}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeGsuite\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeGsuite? Gsuite
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeGsuite?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#ip ZeroTrustAccessPolicy#ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeIp\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeIp? Ip
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeIp?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#ip_list ZeroTrustAccessPolicy#ip_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeIpListStruct\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeIpListStruct? IpList
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeIpListStruct?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#linked_app_token ZeroTrustAccessPolicy#linked_app_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeLinkedAppToken\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeLinkedAppToken? LinkedAppToken
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeLinkedAppToken?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#login_method ZeroTrustAccessPolicy#login_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeLoginMethod\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeLoginMethod? LoginMethod
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeLoginMethod?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#oidc ZeroTrustAccessPolicy#oidc}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeOidc\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeOidc? Oidc
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeOidc?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#okta ZeroTrustAccessPolicy#okta}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeOkta\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeOkta? Okta
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeOkta?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#saml ZeroTrustAccessPolicy#saml}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeSaml\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeSaml? Saml
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeSaml?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#service_token ZeroTrustAccessPolicy#service_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeServiceToken\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeServiceToken? ServiceToken
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeServiceToken?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#user_risk_score ZeroTrustAccessPolicy#user_risk_score}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userRiskScore", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeUserRiskScore\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeUserRiskScore? UserRiskScore
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeUserRiskScore?>();
            }
        }
    }
}
