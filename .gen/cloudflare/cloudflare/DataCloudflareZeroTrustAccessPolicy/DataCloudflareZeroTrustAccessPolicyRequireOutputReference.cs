using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessPolicy
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareZeroTrustAccessPolicyRequireOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareZeroTrustAccessPolicyRequireOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareZeroTrustAccessPolicyRequireOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessPolicyRequireOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireAnyValidServiceTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireAnyValidServiceTokenOutputReference AnyValidServiceToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireAnyValidServiceTokenOutputReference>()!;
        }

        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireAuthContextOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireAuthContextOutputReference AuthContext
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireAuthContextOutputReference>()!;
        }

        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireAuthMethodOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireAuthMethodOutputReference AuthMethod
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireAuthMethodOutputReference>()!;
        }

        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireAzureAdOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireAzureAdOutputReference AzureAd
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireAzureAdOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireCertificateOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireCertificateOutputReference Certificate
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireCommonNameOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireCommonNameOutputReference CommonName
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireCommonNameOutputReference>()!;
        }

        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireDevicePostureOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireDevicePostureOutputReference DevicePosture
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireDevicePostureOutputReference>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireEmailOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireEmailOutputReference Email
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireEmailOutputReference>()!;
        }

        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireEmailDomainOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireEmailDomainOutputReference EmailDomain
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireEmailDomainOutputReference>()!;
        }

        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireEmailListStructOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireEmailListStructOutputReference EmailList
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireEmailListStructOutputReference>()!;
        }

        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireEveryoneOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireEveryoneOutputReference Everyone
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireEveryoneOutputReference>()!;
        }

        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireExternalEvaluationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireExternalEvaluationOutputReference ExternalEvaluation
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireExternalEvaluationOutputReference>()!;
        }

        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireGeoOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireGeoOutputReference Geo
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireGeoOutputReference>()!;
        }

        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireGithubOrganizationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireGithubOrganizationOutputReference GithubOrganization
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireGithubOrganizationOutputReference>()!;
        }

        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireGroupOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireGroupOutputReference Group
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireGroupOutputReference>()!;
        }

        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireGsuiteOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireGsuiteOutputReference Gsuite
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireGsuiteOutputReference>()!;
        }

        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireIpOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireIpOutputReference Ip
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireIpOutputReference>()!;
        }

        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireIpListStructOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireIpListStructOutputReference IpList
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireIpListStructOutputReference>()!;
        }

        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireLinkedAppTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireLinkedAppTokenOutputReference LinkedAppToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireLinkedAppTokenOutputReference>()!;
        }

        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireLoginMethodOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireLoginMethodOutputReference LoginMethod
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireLoginMethodOutputReference>()!;
        }

        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireOidcOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireOidcOutputReference Oidc
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireOidcOutputReference>()!;
        }

        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireOktaOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireOktaOutputReference Okta
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireOktaOutputReference>()!;
        }

        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireSamlOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireSamlOutputReference Saml
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireSamlOutputReference>()!;
        }

        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireServiceTokenOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireServiceTokenOutputReference ServiceToken
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireServiceTokenOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequire\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.IDataCloudflareZeroTrustAccessPolicyRequire? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.IDataCloudflareZeroTrustAccessPolicyRequire?>();
            set => SetInstanceProperty(value);
        }
    }
}
