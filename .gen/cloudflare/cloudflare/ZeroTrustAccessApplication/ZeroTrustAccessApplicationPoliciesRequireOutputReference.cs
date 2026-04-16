using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireOutputReference), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ZeroTrustAccessApplicationPoliciesRequireOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ZeroTrustAccessApplicationPoliciesRequireOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ZeroTrustAccessApplicationPoliciesRequireOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustAccessApplicationPoliciesRequireOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnyValidServiceToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAnyValidServiceToken\"}}]")]
        public virtual void PutAnyValidServiceToken(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireAnyValidServiceToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireAnyValidServiceToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthContext", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAuthContext\"}}]")]
        public virtual void PutAuthContext(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireAuthContext @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireAuthContext)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAuthMethod\"}}]")]
        public virtual void PutAuthMethod(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireAuthMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireAuthMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAzureAd", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAzureAd\"}}]")]
        public virtual void PutAzureAd(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireAzureAd @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireAzureAd)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireCertificate\"}}]")]
        public virtual void PutCertificate(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireCertificate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireCertificate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCommonName", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireCommonName\"}}]")]
        public virtual void PutCommonName(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireCommonName @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireCommonName)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDevicePosture", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireDevicePosture\"}}]")]
        public virtual void PutDevicePosture(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireDevicePosture @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireDevicePosture)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmail", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEmail\"}}]")]
        public virtual void PutEmail(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireEmail @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireEmail)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmailDomain", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEmailDomain\"}}]")]
        public virtual void PutEmailDomain(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireEmailDomain @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireEmailDomain)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmailList", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEmailListStruct\"}}]")]
        public virtual void PutEmailList(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireEmailListStruct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireEmailListStruct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEveryone", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEveryone\"}}]")]
        public virtual void PutEveryone(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireEveryone @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireEveryone)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExternalEvaluation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireExternalEvaluation\"}}]")]
        public virtual void PutExternalEvaluation(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireExternalEvaluation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireExternalEvaluation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGeo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGeo\"}}]")]
        public virtual void PutGeo(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireGeo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireGeo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGithubOrganization", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGithubOrganization\"}}]")]
        public virtual void PutGithubOrganization(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireGithubOrganization @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireGithubOrganization)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGroup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGroup\"}}]")]
        public virtual void PutGroup(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireGroup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireGroup)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGsuite", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGsuite\"}}]")]
        public virtual void PutGsuite(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireGsuite @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireGsuite)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireIp\"}}]")]
        public virtual void PutIp(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireIp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireIp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIpList", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireIpListStruct\"}}]")]
        public virtual void PutIpList(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireIpListStruct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireIpListStruct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLinkedAppToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireLinkedAppToken\"}}]")]
        public virtual void PutLinkedAppToken(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireLinkedAppToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireLinkedAppToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoginMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireLoginMethod\"}}]")]
        public virtual void PutLoginMethod(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireLoginMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireLoginMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOidc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireOidc\"}}]")]
        public virtual void PutOidc(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireOidc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireOidc)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOkta", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireOkta\"}}]")]
        public virtual void PutOkta(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireOkta @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireOkta)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSaml", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireSaml\"}}]")]
        public virtual void PutSaml(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireSaml @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireSaml)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireServiceToken\"}}]")]
        public virtual void PutServiceToken(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireServiceToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireServiceToken)}, new object[]{@value});
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

        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAnyValidServiceTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAnyValidServiceTokenOutputReference AnyValidServiceToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAnyValidServiceTokenOutputReference>()!;
        }

        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAuthContextOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAuthContextOutputReference AuthContext
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAuthContextOutputReference>()!;
        }

        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAuthMethodOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAuthMethodOutputReference AuthMethod
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAuthMethodOutputReference>()!;
        }

        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAzureAdOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAzureAdOutputReference AzureAd
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAzureAdOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireCertificateOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireCertificateOutputReference Certificate
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireCommonNameOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireCommonNameOutputReference CommonName
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireCommonNameOutputReference>()!;
        }

        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireDevicePostureOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireDevicePostureOutputReference DevicePosture
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireDevicePostureOutputReference>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEmailOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEmailOutputReference Email
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEmailOutputReference>()!;
        }

        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEmailDomainOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEmailDomainOutputReference EmailDomain
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEmailDomainOutputReference>()!;
        }

        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEmailListStructOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEmailListStructOutputReference EmailList
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEmailListStructOutputReference>()!;
        }

        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEveryoneOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEveryoneOutputReference Everyone
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEveryoneOutputReference>()!;
        }

        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireExternalEvaluationOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireExternalEvaluationOutputReference ExternalEvaluation
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireExternalEvaluationOutputReference>()!;
        }

        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGeoOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGeoOutputReference Geo
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGeoOutputReference>()!;
        }

        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGithubOrganizationOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGithubOrganizationOutputReference GithubOrganization
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGithubOrganizationOutputReference>()!;
        }

        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGroupOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGroupOutputReference Group
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGroupOutputReference>()!;
        }

        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGsuiteOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGsuiteOutputReference Gsuite
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGsuiteOutputReference>()!;
        }

        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireIpOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireIpOutputReference Ip
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireIpOutputReference>()!;
        }

        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireIpListStructOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireIpListStructOutputReference IpList
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireIpListStructOutputReference>()!;
        }

        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireLinkedAppTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireLinkedAppTokenOutputReference LinkedAppToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireLinkedAppTokenOutputReference>()!;
        }

        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireLoginMethodOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireLoginMethodOutputReference LoginMethod
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireLoginMethodOutputReference>()!;
        }

        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireOidcOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireOidcOutputReference Oidc
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireOidcOutputReference>()!;
        }

        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireOktaOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireOktaOutputReference Okta
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireOktaOutputReference>()!;
        }

        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireSamlOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireSamlOutputReference Saml
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireSamlOutputReference>()!;
        }

        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireServiceTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireServiceTokenOutputReference ServiceToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireServiceTokenOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "anyValidServiceTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAnyValidServiceToken\"}]}}", isOptional: true)]
        public virtual object? AnyValidServiceTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authContextInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAuthContext\"}]}}", isOptional: true)]
        public virtual object? AuthContextInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authMethodInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAuthMethod\"}]}}", isOptional: true)]
        public virtual object? AuthMethodInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureAdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireAzureAd\"}]}}", isOptional: true)]
        public virtual object? AzureAdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireCertificate\"}]}}", isOptional: true)]
        public virtual object? CertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commonNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireCommonName\"}]}}", isOptional: true)]
        public virtual object? CommonNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "devicePostureInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireDevicePosture\"}]}}", isOptional: true)]
        public virtual object? DevicePostureInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailDomainInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEmailDomain\"}]}}", isOptional: true)]
        public virtual object? EmailDomainInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEmail\"}]}}", isOptional: true)]
        public virtual object? EmailInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEmailListStruct\"}]}}", isOptional: true)]
        public virtual object? EmailListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "everyoneInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireEveryone\"}]}}", isOptional: true)]
        public virtual object? EveryoneInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalEvaluationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireExternalEvaluation\"}]}}", isOptional: true)]
        public virtual object? ExternalEvaluationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGeo\"}]}}", isOptional: true)]
        public virtual object? GeoInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "githubOrganizationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGithubOrganization\"}]}}", isOptional: true)]
        public virtual object? GithubOrganizationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGroup\"}]}}", isOptional: true)]
        public virtual object? GroupInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gsuiteInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireGsuite\"}]}}", isOptional: true)]
        public virtual object? GsuiteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireIp\"}]}}", isOptional: true)]
        public virtual object? IpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireIpListStruct\"}]}}", isOptional: true)]
        public virtual object? IpListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linkedAppTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireLinkedAppToken\"}]}}", isOptional: true)]
        public virtual object? LinkedAppTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loginMethodInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireLoginMethod\"}]}}", isOptional: true)]
        public virtual object? LoginMethodInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireOidc\"}]}}", isOptional: true)]
        public virtual object? OidcInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oktaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireOkta\"}]}}", isOptional: true)]
        public virtual object? OktaInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "samlInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireSaml\"}]}}", isOptional: true)]
        public virtual object? SamlInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireServiceToken\"}]}}", isOptional: true)]
        public virtual object? ServiceTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequire\"}]}}", isOptional: true)]
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
                        case cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequire cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequire).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
