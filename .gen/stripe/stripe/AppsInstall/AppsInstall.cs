using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.AppsInstall
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/apps_install stripe_apps_install}.</summary>
    [JsiiClass(nativeType: typeof(stripe.AppsInstall.AppsInstall), fullyQualifiedName: "stripe.appsInstall.AppsInstall", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.appsInstall.AppsInstallConfig\"}}]")]
    public class AppsInstall : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/apps_install stripe_apps_install} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AppsInstall(Constructs.Construct scope, string id, stripe.AppsInstall.IAppsInstallConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.AppsInstall.IAppsInstallConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsInstall(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsInstall(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a AppsInstall resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the AppsInstall to import.</param>
        /// <param name="importFromId">The id of the existing AppsInstall that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the AppsInstall to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the AppsInstall to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/apps_install#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing AppsInstall that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the AppsInstall to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.AppsInstall.AppsInstall), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetChannel")]
        public virtual void ResetChannel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCodeChallenge")]
        public virtual void ResetCodeChallenge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCodeChallengeMethod")]
        public virtual void ResetCodeChallengeMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(stripe.AppsInstall.AppsInstall))!;

        [JsiiProperty(name: "account", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Account
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "approvalRequired", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ApprovalRequired
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "authCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "contentSecurityPolicyGranted", typeJson: "{\"fqn\":\"stripe.appsInstall.AppsInstallContentSecurityPolicyGrantedOutputReference\"}")]
        public virtual stripe.AppsInstall.AppsInstallContentSecurityPolicyGrantedOutputReference ContentSecurityPolicyGranted
        {
            get => GetInstanceProperty<stripe.AppsInstall.AppsInstallContentSecurityPolicyGrantedOutputReference>()!;
        }

        [JsiiProperty(name: "contentSecurityPolicyPending", typeJson: "{\"fqn\":\"stripe.appsInstall.AppsInstallContentSecurityPolicyPendingOutputReference\"}")]
        public virtual stripe.AppsInstall.AppsInstallContentSecurityPolicyPendingOutputReference ContentSecurityPolicyPending
        {
            get => GetInstanceProperty<stripe.AppsInstall.AppsInstallContentSecurityPolicyPendingOutputReference>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Created
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointsGranted", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EndpointsGranted
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "endpointsPending", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EndpointsPending
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "livemode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Livemode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "permissionsGranted", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PermissionsGranted
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "permissionsPending", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PermissionsPending
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "appInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "channelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ChannelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeChallengeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CodeChallengeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeChallengeMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CodeChallengeMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "app", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string App
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Channel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "codeChallenge", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CodeChallenge
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "codeChallengeMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CodeChallengeMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
