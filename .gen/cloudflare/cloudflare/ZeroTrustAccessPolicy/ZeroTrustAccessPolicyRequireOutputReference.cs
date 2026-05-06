using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireOutputReference), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ZeroTrustAccessPolicyRequireOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ZeroTrustAccessPolicyRequireOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ZeroTrustAccessPolicyRequireOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustAccessPolicyRequireOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnyValidServiceToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAnyValidServiceToken\"}}]")]
        public virtual void PutAnyValidServiceToken(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireAnyValidServiceToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireAnyValidServiceToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthContext", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAuthContext\"}}]")]
        public virtual void PutAuthContext(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireAuthContext @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireAuthContext)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAuthMethod\"}}]")]
        public virtual void PutAuthMethod(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireAuthMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireAuthMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAzureAd", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAzureAd\"}}]")]
        public virtual void PutAzureAd(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireAzureAd @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireAzureAd)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireCertificate\"}}]")]
        public virtual void PutCertificate(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireCertificate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireCertificate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCommonName", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireCommonName\"}}]")]
        public virtual void PutCommonName(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireCommonName @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireCommonName)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDevicePosture", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireDevicePosture\"}}]")]
        public virtual void PutDevicePosture(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireDevicePosture @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireDevicePosture)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmail", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEmail\"}}]")]
        public virtual void PutEmail(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireEmail @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireEmail)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmailDomain", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEmailDomain\"}}]")]
        public virtual void PutEmailDomain(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireEmailDomain @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireEmailDomain)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmailList", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEmailListStruct\"}}]")]
        public virtual void PutEmailList(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireEmailListStruct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireEmailListStruct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEveryone", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEveryone\"}}]")]
        public virtual void PutEveryone(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireEveryone @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireEveryone)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExternalEvaluation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireExternalEvaluation\"}}]")]
        public virtual void PutExternalEvaluation(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireExternalEvaluation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireExternalEvaluation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGeo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGeo\"}}]")]
        public virtual void PutGeo(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireGeo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireGeo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGithubOrganization", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGithubOrganization\"}}]")]
        public virtual void PutGithubOrganization(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireGithubOrganization @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireGithubOrganization)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGroup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGroup\"}}]")]
        public virtual void PutGroup(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireGroup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireGroup)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGsuite", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGsuite\"}}]")]
        public virtual void PutGsuite(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireGsuite @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireGsuite)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireIp\"}}]")]
        public virtual void PutIp(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireIp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireIp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIpList", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireIpListStruct\"}}]")]
        public virtual void PutIpList(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireIpListStruct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireIpListStruct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLinkedAppToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireLinkedAppToken\"}}]")]
        public virtual void PutLinkedAppToken(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireLinkedAppToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireLinkedAppToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoginMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireLoginMethod\"}}]")]
        public virtual void PutLoginMethod(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireLoginMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireLoginMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOidc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireOidc\"}}]")]
        public virtual void PutOidc(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireOidc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireOidc)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOkta", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireOkta\"}}]")]
        public virtual void PutOkta(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireOkta @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireOkta)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSaml", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireSaml\"}}]")]
        public virtual void PutSaml(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireSaml @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireSaml)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireServiceToken\"}}]")]
        public virtual void PutServiceToken(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireServiceToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireServiceToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUserRiskScore", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireUserRiskScore\"}}]")]
        public virtual void PutUserRiskScore(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireUserRiskScore @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireUserRiskScore)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAnyValidServiceToken")]
        public virtual void ResetAnyValidServiceToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthContext")]
        public virtual void ResetAuthContext()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthMethod")]
        public virtual void ResetAuthMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzureAd")]
        public virtual void ResetAzureAd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificate")]
        public virtual void ResetCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCommonName")]
        public virtual void ResetCommonName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDevicePosture")]
        public virtual void ResetDevicePosture()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmail")]
        public virtual void ResetEmail()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailDomain")]
        public virtual void ResetEmailDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailList")]
        public virtual void ResetEmailList()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEveryone")]
        public virtual void ResetEveryone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExternalEvaluation")]
        public virtual void ResetExternalEvaluation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGeo")]
        public virtual void ResetGeo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGithubOrganization")]
        public virtual void ResetGithubOrganization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroup")]
        public virtual void ResetGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGsuite")]
        public virtual void ResetGsuite()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIp")]
        public virtual void ResetIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpList")]
        public virtual void ResetIpList()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLinkedAppToken")]
        public virtual void ResetLinkedAppToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoginMethod")]
        public virtual void ResetLoginMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOidc")]
        public virtual void ResetOidc()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOkta")]
        public virtual void ResetOkta()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSaml")]
        public virtual void ResetSaml()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceToken")]
        public virtual void ResetServiceToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserRiskScore")]
        public virtual void ResetUserRiskScore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAnyValidServiceTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAnyValidServiceTokenOutputReference AnyValidServiceToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAnyValidServiceTokenOutputReference>()!;
        }

        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAuthContextOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAuthContextOutputReference AuthContext
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAuthContextOutputReference>()!;
        }

        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAuthMethodOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAuthMethodOutputReference AuthMethod
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAuthMethodOutputReference>()!;
        }

        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAzureAdOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAzureAdOutputReference AzureAd
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAzureAdOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireCertificateOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireCertificateOutputReference Certificate
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireCommonNameOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireCommonNameOutputReference CommonName
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireCommonNameOutputReference>()!;
        }

        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireDevicePostureOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireDevicePostureOutputReference DevicePosture
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireDevicePostureOutputReference>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEmailOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEmailOutputReference Email
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEmailOutputReference>()!;
        }

        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEmailDomainOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEmailDomainOutputReference EmailDomain
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEmailDomainOutputReference>()!;
        }

        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEmailListStructOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEmailListStructOutputReference EmailList
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEmailListStructOutputReference>()!;
        }

        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEveryoneOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEveryoneOutputReference Everyone
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEveryoneOutputReference>()!;
        }

        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireExternalEvaluationOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireExternalEvaluationOutputReference ExternalEvaluation
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireExternalEvaluationOutputReference>()!;
        }

        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGeoOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGeoOutputReference Geo
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGeoOutputReference>()!;
        }

        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGithubOrganizationOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGithubOrganizationOutputReference GithubOrganization
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGithubOrganizationOutputReference>()!;
        }

        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGroupOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGroupOutputReference Group
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGroupOutputReference>()!;
        }

        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGsuiteOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGsuiteOutputReference Gsuite
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGsuiteOutputReference>()!;
        }

        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireIpOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireIpOutputReference Ip
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireIpOutputReference>()!;
        }

        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireIpListStructOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireIpListStructOutputReference IpList
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireIpListStructOutputReference>()!;
        }

        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireLinkedAppTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireLinkedAppTokenOutputReference LinkedAppToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireLinkedAppTokenOutputReference>()!;
        }

        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireLoginMethodOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireLoginMethodOutputReference LoginMethod
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireLoginMethodOutputReference>()!;
        }

        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireOidcOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireOidcOutputReference Oidc
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireOidcOutputReference>()!;
        }

        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireOktaOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireOktaOutputReference Okta
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireOktaOutputReference>()!;
        }

        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireSamlOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireSamlOutputReference Saml
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireSamlOutputReference>()!;
        }

        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireServiceTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireServiceTokenOutputReference ServiceToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireServiceTokenOutputReference>()!;
        }

        [JsiiProperty(name: "userRiskScore", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireUserRiskScoreOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireUserRiskScoreOutputReference UserRiskScore
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireUserRiskScoreOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "anyValidServiceTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAnyValidServiceToken\"}]}}", isOptional: true)]
        public virtual object? AnyValidServiceTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authContextInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAuthContext\"}]}}", isOptional: true)]
        public virtual object? AuthContextInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authMethodInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAuthMethod\"}]}}", isOptional: true)]
        public virtual object? AuthMethodInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureAdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireAzureAd\"}]}}", isOptional: true)]
        public virtual object? AzureAdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireCertificate\"}]}}", isOptional: true)]
        public virtual object? CertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commonNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireCommonName\"}]}}", isOptional: true)]
        public virtual object? CommonNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "devicePostureInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireDevicePosture\"}]}}", isOptional: true)]
        public virtual object? DevicePostureInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailDomainInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEmailDomain\"}]}}", isOptional: true)]
        public virtual object? EmailDomainInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEmail\"}]}}", isOptional: true)]
        public virtual object? EmailInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEmailListStruct\"}]}}", isOptional: true)]
        public virtual object? EmailListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "everyoneInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireEveryone\"}]}}", isOptional: true)]
        public virtual object? EveryoneInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalEvaluationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireExternalEvaluation\"}]}}", isOptional: true)]
        public virtual object? ExternalEvaluationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGeo\"}]}}", isOptional: true)]
        public virtual object? GeoInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "githubOrganizationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGithubOrganization\"}]}}", isOptional: true)]
        public virtual object? GithubOrganizationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGroup\"}]}}", isOptional: true)]
        public virtual object? GroupInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gsuiteInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireGsuite\"}]}}", isOptional: true)]
        public virtual object? GsuiteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireIp\"}]}}", isOptional: true)]
        public virtual object? IpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireIpListStruct\"}]}}", isOptional: true)]
        public virtual object? IpListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linkedAppTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireLinkedAppToken\"}]}}", isOptional: true)]
        public virtual object? LinkedAppTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loginMethodInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireLoginMethod\"}]}}", isOptional: true)]
        public virtual object? LoginMethodInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireOidc\"}]}}", isOptional: true)]
        public virtual object? OidcInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oktaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireOkta\"}]}}", isOptional: true)]
        public virtual object? OktaInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "samlInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireSaml\"}]}}", isOptional: true)]
        public virtual object? SamlInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireServiceToken\"}]}}", isOptional: true)]
        public virtual object? ServiceTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userRiskScoreInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireUserRiskScore\"}]}}", isOptional: true)]
        public virtual object? UserRiskScoreInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequire\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequire cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequire).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
