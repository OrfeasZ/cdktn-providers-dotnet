using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Application
{
    [JsiiClass(nativeType: typeof(azuread.Application.ApplicationWebOutputReference), fullyQualifiedName: "azuread.application.ApplicationWebOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApplicationWebOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApplicationWebOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApplicationWebOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApplicationWebOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putImplicitGrant", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.application.ApplicationWebImplicitGrant\"}}]")]
        public virtual void PutImplicitGrant(azuread.Application.IApplicationWebImplicitGrant @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.Application.IApplicationWebImplicitGrant)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHomepageUrl")]
        public virtual void ResetHomepageUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImplicitGrant")]
        public virtual void ResetImplicitGrant()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogoutUrl")]
        public virtual void ResetLogoutUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedirectUris")]
        public virtual void ResetRedirectUris()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "implicitGrant", typeJson: "{\"fqn\":\"azuread.application.ApplicationWebImplicitGrantOutputReference\"}")]
        public virtual azuread.Application.ApplicationWebImplicitGrantOutputReference ImplicitGrant
        {
            get => GetInstanceProperty<azuread.Application.ApplicationWebImplicitGrantOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "homepageUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HomepageUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "implicitGrantInput", typeJson: "{\"fqn\":\"azuread.application.ApplicationWebImplicitGrant\"}", isOptional: true)]
        public virtual azuread.Application.IApplicationWebImplicitGrant? ImplicitGrantInput
        {
            get => GetInstanceProperty<azuread.Application.IApplicationWebImplicitGrant?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logoutUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogoutUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redirectUrisInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? RedirectUrisInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "homepageUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HomepageUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logoutUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoutUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RedirectUris
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuread.application.ApplicationWeb\"}", isOptional: true)]
        public virtual azuread.Application.IApplicationWeb? InternalValue
        {
            get => GetInstanceProperty<azuread.Application.IApplicationWeb?>();
            set => SetInstanceProperty(value);
        }
    }
}
