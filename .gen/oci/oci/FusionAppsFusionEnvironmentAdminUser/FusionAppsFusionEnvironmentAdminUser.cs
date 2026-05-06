using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FusionAppsFusionEnvironmentAdminUser
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_admin_user oci_fusion_apps_fusion_environment_admin_user}.</summary>
    [JsiiClass(nativeType: typeof(oci.FusionAppsFusionEnvironmentAdminUser.FusionAppsFusionEnvironmentAdminUser), fullyQualifiedName: "oci.fusionAppsFusionEnvironmentAdminUser.FusionAppsFusionEnvironmentAdminUser", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.fusionAppsFusionEnvironmentAdminUser.FusionAppsFusionEnvironmentAdminUserConfig\"}}]")]
    public class FusionAppsFusionEnvironmentAdminUser : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_admin_user oci_fusion_apps_fusion_environment_admin_user} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FusionAppsFusionEnvironmentAdminUser(Constructs.Construct scope, string id, oci.FusionAppsFusionEnvironmentAdminUser.IFusionAppsFusionEnvironmentAdminUserConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.FusionAppsFusionEnvironmentAdminUser.IFusionAppsFusionEnvironmentAdminUserConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FusionAppsFusionEnvironmentAdminUser(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FusionAppsFusionEnvironmentAdminUser(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a FusionAppsFusionEnvironmentAdminUser resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the FusionAppsFusionEnvironmentAdminUser to import.</param>
        /// <param name="importFromId">The id of the existing FusionAppsFusionEnvironmentAdminUser that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the FusionAppsFusionEnvironmentAdminUser to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the FusionAppsFusionEnvironmentAdminUser to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_admin_user#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing FusionAppsFusionEnvironmentAdminUser that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the FusionAppsFusionEnvironmentAdminUser to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.FusionAppsFusionEnvironmentAdminUser.FusionAppsFusionEnvironmentAdminUser), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fusionAppsFusionEnvironmentAdminUser.FusionAppsFusionEnvironmentAdminUserTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.FusionAppsFusionEnvironmentAdminUser.IFusionAppsFusionEnvironmentAdminUserTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FusionAppsFusionEnvironmentAdminUser.IFusionAppsFusionEnvironmentAdminUserTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPassword")]
        public virtual void ResetPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(oci.FusionAppsFusionEnvironmentAdminUser.FusionAppsFusionEnvironmentAdminUser))!;

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.fusionAppsFusionEnvironmentAdminUser.FusionAppsFusionEnvironmentAdminUserItemsList\"}")]
        public virtual oci.FusionAppsFusionEnvironmentAdminUser.FusionAppsFusionEnvironmentAdminUserItemsList Items
        {
            get => GetInstanceProperty<oci.FusionAppsFusionEnvironmentAdminUser.FusionAppsFusionEnvironmentAdminUserItemsList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.fusionAppsFusionEnvironmentAdminUser.FusionAppsFusionEnvironmentAdminUserTimeoutsOutputReference\"}")]
        public virtual oci.FusionAppsFusionEnvironmentAdminUser.FusionAppsFusionEnvironmentAdminUserTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.FusionAppsFusionEnvironmentAdminUser.FusionAppsFusionEnvironmentAdminUserTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firstNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FirstNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fusionEnvironmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FusionEnvironmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LastNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.fusionAppsFusionEnvironmentAdminUser.FusionAppsFusionEnvironmentAdminUserTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "emailAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirstName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fusionEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FusionEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Username
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
