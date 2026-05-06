using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppAppOutputReference), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppAppOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppAppOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppAppOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppAppOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppAppOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMulticloudPlatformUrl")]
        public virtual void ResetMulticloudPlatformUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "multicloudPlatformUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MulticloudPlatformUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "multicloudServiceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MulticloudServiceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "multicloudPlatformUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MulticloudPlatformUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "multicloudServiceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MulticloudServiceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp? InternalValue
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp?>();
            set => SetInstanceProperty(value);
        }
    }
}
