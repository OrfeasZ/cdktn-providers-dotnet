using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeOutputReference), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ZeroTrustAccessApplicationPoliciesIncludeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ZeroTrustAccessApplicationPoliciesIncludeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ZeroTrustAccessApplicationPoliciesIncludeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustAccessApplicationPoliciesIncludeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnyValidServiceToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAnyValidServiceToken\"}}]")]
        public virtual void PutAnyValidServiceToken(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAnyValidServiceToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAnyValidServiceToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthContext", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAuthContext\"}}]")]
        public virtual void PutAuthContext(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAuthContext @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAuthContext)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAuthMethod\"}}]")]
        public virtual void PutAuthMethod(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAuthMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAuthMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAzureAd", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAzureAd\"}}]")]
        public virtual void PutAzureAd(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAzureAd @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeAzureAd)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeCertificate\"}}]")]
        public virtual void PutCertificate(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeCertificate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeCertificate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCommonName", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeCommonName\"}}]")]
        public virtual void PutCommonName(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeCommonName @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeCommonName)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDevicePosture", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeDevicePosture\"}}]")]
        public virtual void PutDevicePosture(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeDevicePosture @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeDevicePosture)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmail", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmail\"}}]")]
        public virtual void PutEmail(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEmail @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEmail)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmailDomain", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmailDomain\"}}]")]
        public virtual void PutEmailDomain(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEmailDomain @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEmailDomain)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmailList", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmailListStruct\"}}]")]
        public virtual void PutEmailList(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEmailListStruct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEmailListStruct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEveryone", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEveryone\"}}]")]
        public virtual void PutEveryone(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEveryone @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeEveryone)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExternalEvaluation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeExternalEvaluation\"}}]")]
        public virtual void PutExternalEvaluation(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeExternalEvaluation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeExternalEvaluation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGeo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGeo\"}}]")]
        public virtual void PutGeo(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGeo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGeo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGithubOrganization", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGithubOrganization\"}}]")]
        public virtual void PutGithubOrganization(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGithubOrganization @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGithubOrganization)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGroup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGroup\"}}]")]
        public virtual void PutGroup(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGroup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGroup)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGsuite", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGsuite\"}}]")]
        public virtual void PutGsuite(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGsuite @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeGsuite)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeIp\"}}]")]
        public virtual void PutIp(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeIp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeIp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIpList", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeIpListStruct\"}}]")]
        public virtual void PutIpList(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeIpListStruct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeIpListStruct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLinkedAppToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeLinkedAppToken\"}}]")]
        public virtual void PutLinkedAppToken(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeLinkedAppToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeLinkedAppToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoginMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeLoginMethod\"}}]")]
        public virtual void PutLoginMethod(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeLoginMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeLoginMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOidc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeOidc\"}}]")]
        public virtual void PutOidc(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeOidc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeOidc)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOkta", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeOkta\"}}]")]
        public virtual void PutOkta(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeOkta @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeOkta)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSaml", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeSaml\"}}]")]
        public virtual void PutSaml(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeSaml @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeSaml)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeServiceToken\"}}]")]
        public virtual void PutServiceToken(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeServiceToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesIncludeServiceToken)}, new object[]{@value});
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

        [JsiiProperty(name: "anyValidServiceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAnyValidServiceTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAnyValidServiceTokenOutputReference AnyValidServiceToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAnyValidServiceTokenOutputReference>()!;
        }

        [JsiiProperty(name: "authContext", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAuthContextOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAuthContextOutputReference AuthContext
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAuthContextOutputReference>()!;
        }

        [JsiiProperty(name: "authMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAuthMethodOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAuthMethodOutputReference AuthMethod
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAuthMethodOutputReference>()!;
        }

        [JsiiProperty(name: "azureAd", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAzureAdOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAzureAdOutputReference AzureAd
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAzureAdOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeCertificateOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeCertificateOutputReference Certificate
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "commonName", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeCommonNameOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeCommonNameOutputReference CommonName
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeCommonNameOutputReference>()!;
        }

        [JsiiProperty(name: "devicePosture", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeDevicePostureOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeDevicePostureOutputReference DevicePosture
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeDevicePostureOutputReference>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmailOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmailOutputReference Email
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmailOutputReference>()!;
        }

        [JsiiProperty(name: "emailDomain", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmailDomainOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmailDomainOutputReference EmailDomain
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmailDomainOutputReference>()!;
        }

        [JsiiProperty(name: "emailList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmailListStructOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmailListStructOutputReference EmailList
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmailListStructOutputReference>()!;
        }

        [JsiiProperty(name: "everyone", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEveryoneOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEveryoneOutputReference Everyone
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEveryoneOutputReference>()!;
        }

        [JsiiProperty(name: "externalEvaluation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeExternalEvaluationOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeExternalEvaluationOutputReference ExternalEvaluation
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeExternalEvaluationOutputReference>()!;
        }

        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGeoOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGeoOutputReference Geo
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGeoOutputReference>()!;
        }

        [JsiiProperty(name: "githubOrganization", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGithubOrganizationOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGithubOrganizationOutputReference GithubOrganization
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGithubOrganizationOutputReference>()!;
        }

        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGroupOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGroupOutputReference Group
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGroupOutputReference>()!;
        }

        [JsiiProperty(name: "gsuite", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGsuiteOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGsuiteOutputReference Gsuite
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGsuiteOutputReference>()!;
        }

        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeIpOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeIpOutputReference Ip
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeIpOutputReference>()!;
        }

        [JsiiProperty(name: "ipList", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeIpListStructOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeIpListStructOutputReference IpList
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeIpListStructOutputReference>()!;
        }

        [JsiiProperty(name: "linkedAppToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeLinkedAppTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeLinkedAppTokenOutputReference LinkedAppToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeLinkedAppTokenOutputReference>()!;
        }

        [JsiiProperty(name: "loginMethod", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeLoginMethodOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeLoginMethodOutputReference LoginMethod
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeLoginMethodOutputReference>()!;
        }

        [JsiiProperty(name: "oidc", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeOidcOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeOidcOutputReference Oidc
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeOidcOutputReference>()!;
        }

        [JsiiProperty(name: "okta", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeOktaOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeOktaOutputReference Okta
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeOktaOutputReference>()!;
        }

        [JsiiProperty(name: "saml", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeSamlOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeSamlOutputReference Saml
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeSamlOutputReference>()!;
        }

        [JsiiProperty(name: "serviceToken", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeServiceTokenOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeServiceTokenOutputReference ServiceToken
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeServiceTokenOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "anyValidServiceTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAnyValidServiceToken\"}]}}", isOptional: true)]
        public virtual object? AnyValidServiceTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authContextInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAuthContext\"}]}}", isOptional: true)]
        public virtual object? AuthContextInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authMethodInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAuthMethod\"}]}}", isOptional: true)]
        public virtual object? AuthMethodInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureAdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeAzureAd\"}]}}", isOptional: true)]
        public virtual object? AzureAdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeCertificate\"}]}}", isOptional: true)]
        public virtual object? CertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commonNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeCommonName\"}]}}", isOptional: true)]
        public virtual object? CommonNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "devicePostureInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeDevicePosture\"}]}}", isOptional: true)]
        public virtual object? DevicePostureInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailDomainInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmailDomain\"}]}}", isOptional: true)]
        public virtual object? EmailDomainInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmail\"}]}}", isOptional: true)]
        public virtual object? EmailInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEmailListStruct\"}]}}", isOptional: true)]
        public virtual object? EmailListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "everyoneInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeEveryone\"}]}}", isOptional: true)]
        public virtual object? EveryoneInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalEvaluationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeExternalEvaluation\"}]}}", isOptional: true)]
        public virtual object? ExternalEvaluationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGeo\"}]}}", isOptional: true)]
        public virtual object? GeoInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "githubOrganizationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGithubOrganization\"}]}}", isOptional: true)]
        public virtual object? GithubOrganizationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGroup\"}]}}", isOptional: true)]
        public virtual object? GroupInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gsuiteInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeGsuite\"}]}}", isOptional: true)]
        public virtual object? GsuiteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeIp\"}]}}", isOptional: true)]
        public virtual object? IpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeIpListStruct\"}]}}", isOptional: true)]
        public virtual object? IpListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linkedAppTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeLinkedAppToken\"}]}}", isOptional: true)]
        public virtual object? LinkedAppTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loginMethodInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeLoginMethod\"}]}}", isOptional: true)]
        public virtual object? LoginMethodInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeOidc\"}]}}", isOptional: true)]
        public virtual object? OidcInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oktaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeOkta\"}]}}", isOptional: true)]
        public virtual object? OktaInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "samlInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeSaml\"}]}}", isOptional: true)]
        public virtual object? SamlInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesIncludeServiceToken\"}]}}", isOptional: true)]
        public virtual object? ServiceTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesInclude\"}]}}", isOptional: true)]
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
                        case cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesInclude cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesInclude).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
