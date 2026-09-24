using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AuthenticationStrengthPolicyFido2CombinationConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_fido2_combination_configuration azuread_authentication_strength_policy_fido2_combination_configuration}.</summary>
    [JsiiClass(nativeType: typeof(azuread.AuthenticationStrengthPolicyFido2CombinationConfiguration.AuthenticationStrengthPolicyFido2CombinationConfiguration), fullyQualifiedName: "azuread.authenticationStrengthPolicyFido2CombinationConfiguration.AuthenticationStrengthPolicyFido2CombinationConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuread.authenticationStrengthPolicyFido2CombinationConfiguration.AuthenticationStrengthPolicyFido2CombinationConfigurationConfig\"}}]")]
    public class AuthenticationStrengthPolicyFido2CombinationConfiguration : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_fido2_combination_configuration azuread_authentication_strength_policy_fido2_combination_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AuthenticationStrengthPolicyFido2CombinationConfiguration(Constructs.Construct scope, string id, azuread.AuthenticationStrengthPolicyFido2CombinationConfiguration.IAuthenticationStrengthPolicyFido2CombinationConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuread.AuthenticationStrengthPolicyFido2CombinationConfiguration.IAuthenticationStrengthPolicyFido2CombinationConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AuthenticationStrengthPolicyFido2CombinationConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AuthenticationStrengthPolicyFido2CombinationConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a AuthenticationStrengthPolicyFido2CombinationConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the AuthenticationStrengthPolicyFido2CombinationConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing AuthenticationStrengthPolicyFido2CombinationConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the AuthenticationStrengthPolicyFido2CombinationConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the AuthenticationStrengthPolicyFido2CombinationConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_fido2_combination_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing AuthenticationStrengthPolicyFido2CombinationConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the AuthenticationStrengthPolicyFido2CombinationConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuread.AuthenticationStrengthPolicyFido2CombinationConfiguration.AuthenticationStrengthPolicyFido2CombinationConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.authenticationStrengthPolicyFido2CombinationConfiguration.AuthenticationStrengthPolicyFido2CombinationConfigurationTimeouts\"}}]")]
        public virtual void PutTimeouts(azuread.AuthenticationStrengthPolicyFido2CombinationConfiguration.IAuthenticationStrengthPolicyFido2CombinationConfigurationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.AuthenticationStrengthPolicyFido2CombinationConfiguration.IAuthenticationStrengthPolicyFido2CombinationConfigurationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(azuread.AuthenticationStrengthPolicyFido2CombinationConfiguration.AuthenticationStrengthPolicyFido2CombinationConfiguration))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.authenticationStrengthPolicyFido2CombinationConfiguration.AuthenticationStrengthPolicyFido2CombinationConfigurationTimeoutsOutputReference\"}")]
        public virtual azuread.AuthenticationStrengthPolicyFido2CombinationConfiguration.AuthenticationStrengthPolicyFido2CombinationConfigurationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuread.AuthenticationStrengthPolicyFido2CombinationConfiguration.AuthenticationStrengthPolicyFido2CombinationConfigurationTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedAaguidsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowedAaguidsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationStrengthPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthenticationStrengthPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuread.AuthenticationStrengthPolicyFido2CombinationConfiguration.IAuthenticationStrengthPolicyFido2CombinationConfigurationTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuread.authenticationStrengthPolicyFido2CombinationConfiguration.AuthenticationStrengthPolicyFido2CombinationConfigurationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "allowedAaguids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedAaguids
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authenticationStrengthPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationStrengthPolicyId
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
    }
}
