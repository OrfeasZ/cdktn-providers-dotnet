using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessApplication
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareZeroTrustAccessApplicationPoliciesIncludeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareZeroTrustAccessApplicationPoliciesIncludeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessApplicationPoliciesIncludeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessApplicationPoliciesIncludeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeAnyValidServiceTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeAnyValidServiceTokenOutputReference AnyValidServiceToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeAnyValidServiceTokenOutputReference>()!;
        }

        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeAuthContextOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeAuthContextOutputReference AuthContext
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeAuthContextOutputReference>()!;
        }

        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeAuthMethodOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeAuthMethodOutputReference AuthMethod
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeAuthMethodOutputReference>()!;
        }

        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeAzureAdOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeAzureAdOutputReference AzureAd
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeAzureAdOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeCertificateOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeCertificateOutputReference Certificate
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeCommonNameOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeCommonNameOutputReference CommonName
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeCommonNameOutputReference>()!;
        }

        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeDevicePostureOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeDevicePostureOutputReference DevicePosture
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeDevicePostureOutputReference>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeEmailOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeEmailOutputReference Email
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeEmailOutputReference>()!;
        }

        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeEmailDomainOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeEmailDomainOutputReference EmailDomain
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeEmailDomainOutputReference>()!;
        }

        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeEmailListStructOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeEmailListStructOutputReference EmailList
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeEmailListStructOutputReference>()!;
        }

        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeEveryoneOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeEveryoneOutputReference Everyone
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeEveryoneOutputReference>()!;
        }

        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeExternalEvaluationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeExternalEvaluationOutputReference ExternalEvaluation
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeExternalEvaluationOutputReference>()!;
        }

        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeGeoOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeGeoOutputReference Geo
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeGeoOutputReference>()!;
        }

        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeGithubOrganizationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeGithubOrganizationOutputReference GithubOrganization
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeGithubOrganizationOutputReference>()!;
        }

        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeGroupOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeGroupOutputReference Group
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeGroupOutputReference>()!;
        }

        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeGsuiteOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeGsuiteOutputReference Gsuite
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeGsuiteOutputReference>()!;
        }

        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeIpOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeIpOutputReference Ip
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeIpOutputReference>()!;
        }

        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeIpListStructOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeIpListStructOutputReference IpList
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeIpListStructOutputReference>()!;
        }

        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeLinkedAppTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeLinkedAppTokenOutputReference LinkedAppToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeLinkedAppTokenOutputReference>()!;
        }

        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeLoginMethodOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeLoginMethodOutputReference LoginMethod
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeLoginMethodOutputReference>()!;
        }

        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeOidcOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeOidcOutputReference Oidc
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeOidcOutputReference>()!;
        }

        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeOktaOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeOktaOutputReference Okta
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeOktaOutputReference>()!;
        }

        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeSamlOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeSamlOutputReference Saml
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeSamlOutputReference>()!;
        }

        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeServiceTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeServiceTokenOutputReference ServiceToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesIncludeServiceTokenOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesInclude\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.IDataCloudflareZeroTrustAccessApplicationPoliciesInclude? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.IDataCloudflareZeroTrustAccessApplicationPoliciesInclude?>();
            set => SetInstanceProperty(value);
        }
    }
}
