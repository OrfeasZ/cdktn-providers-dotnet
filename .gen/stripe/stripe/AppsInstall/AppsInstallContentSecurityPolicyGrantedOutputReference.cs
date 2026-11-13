using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.AppsInstall
{
    [JsiiClass(nativeType: typeof(stripe.AppsInstall.AppsInstallContentSecurityPolicyGrantedOutputReference), fullyQualifiedName: "stripe.appsInstall.AppsInstallContentSecurityPolicyGrantedOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppsInstallContentSecurityPolicyGrantedOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppsInstallContentSecurityPolicyGrantedOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppsInstallContentSecurityPolicyGrantedOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsInstallContentSecurityPolicyGrantedOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "connectSrc", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ConnectSrc
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "imageSrc", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ImageSrc
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.appsInstall.AppsInstallContentSecurityPolicyGranted\"}", isOptional: true)]
        public virtual stripe.AppsInstall.IAppsInstallContentSecurityPolicyGranted? InternalValue
        {
            get => GetInstanceProperty<stripe.AppsInstall.IAppsInstallContentSecurityPolicyGranted?>();
            set => SetInstanceProperty(value);
        }
    }
}
