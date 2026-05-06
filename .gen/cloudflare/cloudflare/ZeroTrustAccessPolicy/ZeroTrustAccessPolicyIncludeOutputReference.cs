using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeOutputReference), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ZeroTrustAccessPolicyIncludeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ZeroTrustAccessPolicyIncludeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ZeroTrustAccessPolicyIncludeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustAccessPolicyIncludeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnyValidServiceToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAnyValidServiceToken\"}}]")]
        public virtual void PutAnyValidServiceToken(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAnyValidServiceToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAnyValidServiceToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthContext", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAuthContext\"}}]")]
        public virtual void PutAuthContext(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAuthContext @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAuthContext)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAuthMethod\"}}]")]
        public virtual void PutAuthMethod(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAuthMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAuthMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAzureAd", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAzureAd\"}}]")]
        public virtual void PutAzureAd(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAzureAd @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeAzureAd)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeCertificate\"}}]")]
        public virtual void PutCertificate(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeCertificate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeCertificate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCommonName", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeCommonName\"}}]")]
        public virtual void PutCommonName(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeCommonName @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeCommonName)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDevicePosture", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeDevicePosture\"}}]")]
        public virtual void PutDevicePosture(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeDevicePosture @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeDevicePosture)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmail", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmail\"}}]")]
        public virtual void PutEmail(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEmail @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEmail)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmailDomain", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmailDomain\"}}]")]
        public virtual void PutEmailDomain(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEmailDomain @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEmailDomain)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmailList", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmailListStruct\"}}]")]
        public virtual void PutEmailList(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEmailListStruct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEmailListStruct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEveryone", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEveryone\"}}]")]
        public virtual void PutEveryone(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEveryone @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeEveryone)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExternalEvaluation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeExternalEvaluation\"}}]")]
        public virtual void PutExternalEvaluation(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeExternalEvaluation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeExternalEvaluation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGeo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGeo\"}}]")]
        public virtual void PutGeo(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGeo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGeo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGithubOrganization", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGithubOrganization\"}}]")]
        public virtual void PutGithubOrganization(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGithubOrganization @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGithubOrganization)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGroup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGroup\"}}]")]
        public virtual void PutGroup(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGroup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGroup)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGsuite", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGsuite\"}}]")]
        public virtual void PutGsuite(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGsuite @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeGsuite)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeIp\"}}]")]
        public virtual void PutIp(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeIp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeIp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIpList", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeIpListStruct\"}}]")]
        public virtual void PutIpList(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeIpListStruct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeIpListStruct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLinkedAppToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeLinkedAppToken\"}}]")]
        public virtual void PutLinkedAppToken(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeLinkedAppToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeLinkedAppToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoginMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeLoginMethod\"}}]")]
        public virtual void PutLoginMethod(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeLoginMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeLoginMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOidc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeOidc\"}}]")]
        public virtual void PutOidc(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeOidc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeOidc)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOkta", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeOkta\"}}]")]
        public virtual void PutOkta(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeOkta @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeOkta)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSaml", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeSaml\"}}]")]
        public virtual void PutSaml(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeSaml @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeSaml)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeServiceToken\"}}]")]
        public virtual void PutServiceToken(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeServiceToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeServiceToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUserRiskScore", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeUserRiskScore\"}}]")]
        public virtual void PutUserRiskScore(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeUserRiskScore @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeUserRiskScore)}, new object[]{@value});
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

        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAnyValidServiceTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAnyValidServiceTokenOutputReference AnyValidServiceToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAnyValidServiceTokenOutputReference>()!;
        }

        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAuthContextOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAuthContextOutputReference AuthContext
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAuthContextOutputReference>()!;
        }

        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAuthMethodOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAuthMethodOutputReference AuthMethod
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAuthMethodOutputReference>()!;
        }

        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAzureAdOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAzureAdOutputReference AzureAd
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAzureAdOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeCertificateOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeCertificateOutputReference Certificate
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeCommonNameOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeCommonNameOutputReference CommonName
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeCommonNameOutputReference>()!;
        }

        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeDevicePostureOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeDevicePostureOutputReference DevicePosture
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeDevicePostureOutputReference>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmailOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmailOutputReference Email
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmailOutputReference>()!;
        }

        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmailDomainOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmailDomainOutputReference EmailDomain
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmailDomainOutputReference>()!;
        }

        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmailListStructOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmailListStructOutputReference EmailList
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmailListStructOutputReference>()!;
        }

        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEveryoneOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEveryoneOutputReference Everyone
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEveryoneOutputReference>()!;
        }

        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeExternalEvaluationOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeExternalEvaluationOutputReference ExternalEvaluation
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeExternalEvaluationOutputReference>()!;
        }

        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGeoOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGeoOutputReference Geo
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGeoOutputReference>()!;
        }

        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGithubOrganizationOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGithubOrganizationOutputReference GithubOrganization
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGithubOrganizationOutputReference>()!;
        }

        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGroupOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGroupOutputReference Group
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGroupOutputReference>()!;
        }

        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGsuiteOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGsuiteOutputReference Gsuite
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGsuiteOutputReference>()!;
        }

        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeIpOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeIpOutputReference Ip
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeIpOutputReference>()!;
        }

        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeIpListStructOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeIpListStructOutputReference IpList
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeIpListStructOutputReference>()!;
        }

        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeLinkedAppTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeLinkedAppTokenOutputReference LinkedAppToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeLinkedAppTokenOutputReference>()!;
        }

        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeLoginMethodOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeLoginMethodOutputReference LoginMethod
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeLoginMethodOutputReference>()!;
        }

        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeOidcOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeOidcOutputReference Oidc
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeOidcOutputReference>()!;
        }

        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeOktaOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeOktaOutputReference Okta
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeOktaOutputReference>()!;
        }

        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeSamlOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeSamlOutputReference Saml
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeSamlOutputReference>()!;
        }

        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeServiceTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeServiceTokenOutputReference ServiceToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeServiceTokenOutputReference>()!;
        }

        [JsiiProperty(name: "userRiskScore", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeUserRiskScoreOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeUserRiskScoreOutputReference UserRiskScore
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeUserRiskScoreOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "anyValidServiceTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAnyValidServiceToken\"}]}}", isOptional: true)]
        public virtual object? AnyValidServiceTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authContextInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAuthContext\"}]}}", isOptional: true)]
        public virtual object? AuthContextInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authMethodInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAuthMethod\"}]}}", isOptional: true)]
        public virtual object? AuthMethodInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureAdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeAzureAd\"}]}}", isOptional: true)]
        public virtual object? AzureAdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeCertificate\"}]}}", isOptional: true)]
        public virtual object? CertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commonNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeCommonName\"}]}}", isOptional: true)]
        public virtual object? CommonNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "devicePostureInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeDevicePosture\"}]}}", isOptional: true)]
        public virtual object? DevicePostureInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailDomainInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmailDomain\"}]}}", isOptional: true)]
        public virtual object? EmailDomainInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmail\"}]}}", isOptional: true)]
        public virtual object? EmailInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEmailListStruct\"}]}}", isOptional: true)]
        public virtual object? EmailListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "everyoneInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeEveryone\"}]}}", isOptional: true)]
        public virtual object? EveryoneInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalEvaluationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeExternalEvaluation\"}]}}", isOptional: true)]
        public virtual object? ExternalEvaluationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGeo\"}]}}", isOptional: true)]
        public virtual object? GeoInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "githubOrganizationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGithubOrganization\"}]}}", isOptional: true)]
        public virtual object? GithubOrganizationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGroup\"}]}}", isOptional: true)]
        public virtual object? GroupInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gsuiteInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeGsuite\"}]}}", isOptional: true)]
        public virtual object? GsuiteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeIp\"}]}}", isOptional: true)]
        public virtual object? IpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeIpListStruct\"}]}}", isOptional: true)]
        public virtual object? IpListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linkedAppTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeLinkedAppToken\"}]}}", isOptional: true)]
        public virtual object? LinkedAppTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loginMethodInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeLoginMethod\"}]}}", isOptional: true)]
        public virtual object? LoginMethodInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeOidc\"}]}}", isOptional: true)]
        public virtual object? OidcInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oktaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeOkta\"}]}}", isOptional: true)]
        public virtual object? OktaInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "samlInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeSaml\"}]}}", isOptional: true)]
        public virtual object? SamlInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeServiceToken\"}]}}", isOptional: true)]
        public virtual object? ServiceTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userRiskScoreInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeUserRiskScore\"}]}}", isOptional: true)]
        public virtual object? UserRiskScoreInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyInclude\"}]}}", isOptional: true)]
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
                        case cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyInclude cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyInclude).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
