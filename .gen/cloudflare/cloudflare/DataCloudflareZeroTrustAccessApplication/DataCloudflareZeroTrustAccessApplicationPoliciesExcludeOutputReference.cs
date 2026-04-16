using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessApplication
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareZeroTrustAccessApplicationPoliciesExcludeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareZeroTrustAccessApplicationPoliciesExcludeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareZeroTrustAccessApplicationPoliciesExcludeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessApplicationPoliciesExcludeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeAnyValidServiceTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeAnyValidServiceTokenOutputReference AnyValidServiceToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeAnyValidServiceTokenOutputReference>()!;
        }

        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeAuthContextOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeAuthContextOutputReference AuthContext
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeAuthContextOutputReference>()!;
        }

        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeAuthMethodOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeAuthMethodOutputReference AuthMethod
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeAuthMethodOutputReference>()!;
        }

        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeAzureAdOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeAzureAdOutputReference AzureAd
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeAzureAdOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeCertificateOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeCertificateOutputReference Certificate
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeCommonNameOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeCommonNameOutputReference CommonName
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeCommonNameOutputReference>()!;
        }

        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeDevicePostureOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeDevicePostureOutputReference DevicePosture
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeDevicePostureOutputReference>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeEmailOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeEmailOutputReference Email
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeEmailOutputReference>()!;
        }

        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeEmailDomainOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeEmailDomainOutputReference EmailDomain
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeEmailDomainOutputReference>()!;
        }

        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeEmailListStructOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeEmailListStructOutputReference EmailList
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeEmailListStructOutputReference>()!;
        }

        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeEveryoneOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeEveryoneOutputReference Everyone
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeEveryoneOutputReference>()!;
        }

        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeExternalEvaluationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeExternalEvaluationOutputReference ExternalEvaluation
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeExternalEvaluationOutputReference>()!;
        }

        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeGeoOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeGeoOutputReference Geo
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeGeoOutputReference>()!;
        }

        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeGithubOrganizationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeGithubOrganizationOutputReference GithubOrganization
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeGithubOrganizationOutputReference>()!;
        }

        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeGroupOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeGroupOutputReference Group
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeGroupOutputReference>()!;
        }

        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeGsuiteOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeGsuiteOutputReference Gsuite
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeGsuiteOutputReference>()!;
        }

        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeIpOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeIpOutputReference Ip
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeIpOutputReference>()!;
        }

        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeIpListStructOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeIpListStructOutputReference IpList
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeIpListStructOutputReference>()!;
        }

        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeLinkedAppTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeLinkedAppTokenOutputReference LinkedAppToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeLinkedAppTokenOutputReference>()!;
        }

        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeLoginMethodOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeLoginMethodOutputReference LoginMethod
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeLoginMethodOutputReference>()!;
        }

        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeOidcOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeOidcOutputReference Oidc
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeOidcOutputReference>()!;
        }

        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeOktaOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeOktaOutputReference Okta
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeOktaOutputReference>()!;
        }

        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeSamlOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeSamlOutputReference Saml
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeSamlOutputReference>()!;
        }

        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeServiceTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeServiceTokenOutputReference ServiceToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExcludeServiceTokenOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesExclude\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.IDataCloudflareZeroTrustAccessApplicationPoliciesExclude? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.IDataCloudflareZeroTrustAccessApplicationPoliciesExclude?>();
            set => SetInstanceProperty(value);
        }
    }
}
