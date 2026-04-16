using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiClass(nativeType: typeof(digitalocean.App.AppSpecIngressRuleMatchOutputReference), fullyQualifiedName: "digitalocean.app.AppSpecIngressRuleMatchOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppSpecIngressRuleMatchOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppSpecIngressRuleMatchOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppSpecIngressRuleMatchOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppSpecIngressRuleMatchOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuthority", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecIngressRuleMatchAuthority\"}}]")]
        public virtual void PutAuthority(digitalocean.App.IAppSpecIngressRuleMatchAuthority @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecIngressRuleMatchAuthority)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPath", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecIngressRuleMatchPath\"}}]")]
        public virtual void PutPath(digitalocean.App.IAppSpecIngressRuleMatchPath @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecIngressRuleMatchPath)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthority")]
        public virtual void ResetAuthority()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPath")]
        public virtual void ResetPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "authority", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleMatchAuthorityOutputReference\"}")]
        public virtual digitalocean.App.AppSpecIngressRuleMatchAuthorityOutputReference Authority
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecIngressRuleMatchAuthorityOutputReference>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleMatchPathOutputReference\"}")]
        public virtual digitalocean.App.AppSpecIngressRuleMatchPathOutputReference Path
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecIngressRuleMatchPathOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorityInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleMatchAuthority\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecIngressRuleMatchAuthority? AuthorityInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecIngressRuleMatchAuthority?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleMatchPath\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecIngressRuleMatchPath? PathInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecIngressRuleMatchPath?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleMatch\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecIngressRuleMatch? InternalValue
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecIngressRuleMatch?>();
            set => SetInstanceProperty(value);
        }
    }
}
