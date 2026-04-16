using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationPoliciesInclude), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesInclude")]
    public interface IZeroTrustAccessApplicationPoliciesInclude
    {
        /// <summary>An empty object which matches on all service tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#any_valid_service_token ZeroTrustAccessApplication#any_valid_service_token}
        /// </remarks>
        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAnyValidServiceToken\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAnyValidServiceToken? AnyValidServiceToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#auth_context ZeroTrustAccessApplication#auth_context}.</summary>
        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAuthContext\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAuthContext? AuthContext
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#auth_method ZeroTrustAccessApplication#auth_method}.</summary>
        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAuthMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAuthMethod? AuthMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#azure_ad ZeroTrustAccessApplication#azure_ad}.</summary>
        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAzureAd\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAzureAd? AzureAd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#certificate ZeroTrustAccessApplication#certificate}.</summary>
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeCertificate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeCertificate? Certificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#common_name ZeroTrustAccessApplication#common_name}.</summary>
        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeCommonName\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeCommonName? CommonName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#device_posture ZeroTrustAccessApplication#device_posture}.</summary>
        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeDevicePosture\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeDevicePosture? DevicePosture
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#email ZeroTrustAccessApplication#email}.</summary>
        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmail\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEmail? Email
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#email_domain ZeroTrustAccessApplication#email_domain}.</summary>
        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmailDomain\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEmailDomain? EmailDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#email_list ZeroTrustAccessApplication#email_list}.</summary>
        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmailListStruct\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEmailListStruct? EmailList
        {
            get
            {
                return null;
            }
        }

        /// <summary>An empty object which matches on all users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#everyone ZeroTrustAccessApplication#everyone}
        /// </remarks>
        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEveryone\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEveryone? Everyone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#external_evaluation ZeroTrustAccessApplication#external_evaluation}.</summary>
        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeExternalEvaluation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeExternalEvaluation? ExternalEvaluation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#geo ZeroTrustAccessApplication#geo}.</summary>
        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGeo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGeo? Geo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#github_organization ZeroTrustAccessApplication#github_organization}.</summary>
        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGithubOrganization\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGithubOrganization? GithubOrganization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#group ZeroTrustAccessApplication#group}.</summary>
        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGroup\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGroup? Group
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#gsuite ZeroTrustAccessApplication#gsuite}.</summary>
        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGsuite\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGsuite? Gsuite
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#ip ZeroTrustAccessApplication#ip}.</summary>
        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeIp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeIp? Ip
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#ip_list ZeroTrustAccessApplication#ip_list}.</summary>
        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeIpListStruct\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeIpListStruct? IpList
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#linked_app_token ZeroTrustAccessApplication#linked_app_token}.</summary>
        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeLinkedAppToken\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeLinkedAppToken? LinkedAppToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#login_method ZeroTrustAccessApplication#login_method}.</summary>
        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeLoginMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeLoginMethod? LoginMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#oidc ZeroTrustAccessApplication#oidc}.</summary>
        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeOidc\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeOidc? Oidc
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#okta ZeroTrustAccessApplication#okta}.</summary>
        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeOkta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeOkta? Okta
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#saml ZeroTrustAccessApplication#saml}.</summary>
        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeSaml\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeSaml? Saml
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#service_token ZeroTrustAccessApplication#service_token}.</summary>
        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeServiceToken\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeServiceToken? ServiceToken
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationPoliciesInclude), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesInclude")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesInclude
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>An empty object which matches on all service tokens.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#any_valid_service_token ZeroTrustAccessApplication#any_valid_service_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAnyValidServiceToken\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAnyValidServiceToken? AnyValidServiceToken
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAnyValidServiceToken?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#auth_context ZeroTrustAccessApplication#auth_context}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAuthContext\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAuthContext? AuthContext
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAuthContext?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#auth_method ZeroTrustAccessApplication#auth_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAuthMethod\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAuthMethod? AuthMethod
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAuthMethod?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#azure_ad ZeroTrustAccessApplication#azure_ad}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAzureAd\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAzureAd? AzureAd
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAzureAd?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#certificate ZeroTrustAccessApplication#certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeCertificate\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeCertificate? Certificate
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeCertificate?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#common_name ZeroTrustAccessApplication#common_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeCommonName\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeCommonName? CommonName
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeCommonName?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#device_posture ZeroTrustAccessApplication#device_posture}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeDevicePosture\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeDevicePosture? DevicePosture
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeDevicePosture?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#email ZeroTrustAccessApplication#email}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmail\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEmail? Email
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEmail?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#email_domain ZeroTrustAccessApplication#email_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmailDomain\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEmailDomain? EmailDomain
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEmailDomain?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#email_list ZeroTrustAccessApplication#email_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmailListStruct\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEmailListStruct? EmailList
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEmailListStruct?>();
            }

            /// <summary>An empty object which matches on all users.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#everyone ZeroTrustAccessApplication#everyone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEveryone\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEveryone? Everyone
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEveryone?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#external_evaluation ZeroTrustAccessApplication#external_evaluation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeExternalEvaluation\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeExternalEvaluation? ExternalEvaluation
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeExternalEvaluation?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#geo ZeroTrustAccessApplication#geo}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGeo\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGeo? Geo
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGeo?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#github_organization ZeroTrustAccessApplication#github_organization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGithubOrganization\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGithubOrganization? GithubOrganization
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGithubOrganization?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#group ZeroTrustAccessApplication#group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGroup\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGroup? Group
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGroup?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#gsuite ZeroTrustAccessApplication#gsuite}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGsuite\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGsuite? Gsuite
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGsuite?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#ip ZeroTrustAccessApplication#ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeIp\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeIp? Ip
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeIp?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#ip_list ZeroTrustAccessApplication#ip_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeIpListStruct\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeIpListStruct? IpList
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeIpListStruct?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#linked_app_token ZeroTrustAccessApplication#linked_app_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeLinkedAppToken\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeLinkedAppToken? LinkedAppToken
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeLinkedAppToken?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#login_method ZeroTrustAccessApplication#login_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeLoginMethod\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeLoginMethod? LoginMethod
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeLoginMethod?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#oidc ZeroTrustAccessApplication#oidc}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeOidc\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeOidc? Oidc
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeOidc?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#okta ZeroTrustAccessApplication#okta}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeOkta\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeOkta? Okta
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeOkta?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#saml ZeroTrustAccessApplication#saml}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeSaml\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeSaml? Saml
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeSaml?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#service_token ZeroTrustAccessApplication#service_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeServiceToken\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeServiceToken? ServiceToken
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeServiceToken?>();
            }
        }
    }
}
