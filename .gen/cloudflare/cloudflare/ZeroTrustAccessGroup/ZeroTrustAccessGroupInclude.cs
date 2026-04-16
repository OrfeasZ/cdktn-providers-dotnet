using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupInclude")]
    public class ZeroTrustAccessGroupInclude : cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupInclude
    {
        /// <summary>An empty object which matches on all service tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#any_valid_service_token ZeroTrustAccessGroup#any_valid_service_token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAnyValidServiceToken\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAnyValidServiceToken? AnyValidServiceToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#auth_context ZeroTrustAccessGroup#auth_context}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAuthContext\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAuthContext? AuthContext
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#auth_method ZeroTrustAccessGroup#auth_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAuthMethod\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAuthMethod? AuthMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#azure_ad ZeroTrustAccessGroup#azure_ad}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeAzureAd\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeAzureAd? AzureAd
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#certificate ZeroTrustAccessGroup#certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeCertificate\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeCertificate? Certificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#common_name ZeroTrustAccessGroup#common_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeCommonName\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeCommonName? CommonName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#device_posture ZeroTrustAccessGroup#device_posture}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeDevicePosture\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeDevicePosture? DevicePosture
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#email ZeroTrustAccessGroup#email}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmail\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEmail? Email
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#email_domain ZeroTrustAccessGroup#email_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmailDomain\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEmailDomain? EmailDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#email_list ZeroTrustAccessGroup#email_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEmailListStruct\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEmailListStruct? EmailList
        {
            get;
            set;
        }

        /// <summary>An empty object which matches on all users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#everyone ZeroTrustAccessGroup#everyone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeEveryone\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeEveryone? Everyone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#external_evaluation ZeroTrustAccessGroup#external_evaluation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeExternalEvaluation\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeExternalEvaluation? ExternalEvaluation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#geo ZeroTrustAccessGroup#geo}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGeo\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGeo? Geo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#github_organization ZeroTrustAccessGroup#github_organization}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGithubOrganization\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGithubOrganization? GithubOrganization
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#group ZeroTrustAccessGroup#group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGroup\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGroup? Group
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#gsuite ZeroTrustAccessGroup#gsuite}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeGsuite\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeGsuite? Gsuite
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#ip ZeroTrustAccessGroup#ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeIp\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeIp? Ip
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#ip_list ZeroTrustAccessGroup#ip_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeIpListStruct\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeIpListStruct? IpList
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#linked_app_token ZeroTrustAccessGroup#linked_app_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeLinkedAppToken\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeLinkedAppToken? LinkedAppToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#login_method ZeroTrustAccessGroup#login_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeLoginMethod\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeLoginMethod? LoginMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#oidc ZeroTrustAccessGroup#oidc}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeOidc\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeOidc? Oidc
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#okta ZeroTrustAccessGroup#okta}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeOkta\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeOkta? Okta
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#saml ZeroTrustAccessGroup#saml}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeSaml\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeSaml? Saml
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#service_token ZeroTrustAccessGroup#service_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeServiceToken\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeServiceToken? ServiceToken
        {
            get;
            set;
        }
    }
}
