using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityAuthenticationPolicy
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_authentication_policy oci_identity_authentication_policy}.</summary>
    [JsiiClass(nativeType: typeof(oci.IdentityAuthenticationPolicy.IdentityAuthenticationPolicy), fullyQualifiedName: "oci.identityAuthenticationPolicy.IdentityAuthenticationPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.identityAuthenticationPolicy.IdentityAuthenticationPolicyConfig\"}}]")]
    public class IdentityAuthenticationPolicy : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_authentication_policy oci_identity_authentication_policy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IdentityAuthenticationPolicy(Constructs.Construct scope, string id, oci.IdentityAuthenticationPolicy.IIdentityAuthenticationPolicyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.IdentityAuthenticationPolicy.IIdentityAuthenticationPolicyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityAuthenticationPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityAuthenticationPolicy(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IdentityAuthenticationPolicy resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IdentityAuthenticationPolicy to import.</param>
        /// <param name="importFromId">The id of the existing IdentityAuthenticationPolicy that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IdentityAuthenticationPolicy to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IdentityAuthenticationPolicy to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_authentication_policy#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IdentityAuthenticationPolicy that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IdentityAuthenticationPolicy to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.IdentityAuthenticationPolicy.IdentityAuthenticationPolicy), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putNetworkPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityAuthenticationPolicy.IdentityAuthenticationPolicyNetworkPolicy\"}}]")]
        public virtual void PutNetworkPolicy(oci.IdentityAuthenticationPolicy.IIdentityAuthenticationPolicyNetworkPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityAuthenticationPolicy.IIdentityAuthenticationPolicyNetworkPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPasswordPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityAuthenticationPolicy.IdentityAuthenticationPolicyPasswordPolicy\"}}]")]
        public virtual void PutPasswordPolicy(oci.IdentityAuthenticationPolicy.IIdentityAuthenticationPolicyPasswordPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityAuthenticationPolicy.IIdentityAuthenticationPolicyPasswordPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityAuthenticationPolicy.IdentityAuthenticationPolicyTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.IdentityAuthenticationPolicy.IIdentityAuthenticationPolicyTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityAuthenticationPolicy.IIdentityAuthenticationPolicyTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkPolicy")]
        public virtual void ResetNetworkPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPasswordPolicy")]
        public virtual void ResetPasswordPolicy()
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
        = GetStaticProperty<string>(typeof(oci.IdentityAuthenticationPolicy.IdentityAuthenticationPolicy))!;

        [JsiiProperty(name: "networkPolicy", typeJson: "{\"fqn\":\"oci.identityAuthenticationPolicy.IdentityAuthenticationPolicyNetworkPolicyOutputReference\"}")]
        public virtual oci.IdentityAuthenticationPolicy.IdentityAuthenticationPolicyNetworkPolicyOutputReference NetworkPolicy
        {
            get => GetInstanceProperty<oci.IdentityAuthenticationPolicy.IdentityAuthenticationPolicyNetworkPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "passwordPolicy", typeJson: "{\"fqn\":\"oci.identityAuthenticationPolicy.IdentityAuthenticationPolicyPasswordPolicyOutputReference\"}")]
        public virtual oci.IdentityAuthenticationPolicy.IdentityAuthenticationPolicyPasswordPolicyOutputReference PasswordPolicy
        {
            get => GetInstanceProperty<oci.IdentityAuthenticationPolicy.IdentityAuthenticationPolicyPasswordPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityAuthenticationPolicy.IdentityAuthenticationPolicyTimeoutsOutputReference\"}")]
        public virtual oci.IdentityAuthenticationPolicy.IdentityAuthenticationPolicyTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.IdentityAuthenticationPolicy.IdentityAuthenticationPolicyTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
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
        [JsiiProperty(name: "networkPolicyInput", typeJson: "{\"fqn\":\"oci.identityAuthenticationPolicy.IdentityAuthenticationPolicyNetworkPolicy\"}", isOptional: true)]
        public virtual oci.IdentityAuthenticationPolicy.IIdentityAuthenticationPolicyNetworkPolicy? NetworkPolicyInput
        {
            get => GetInstanceProperty<oci.IdentityAuthenticationPolicy.IIdentityAuthenticationPolicyNetworkPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordPolicyInput", typeJson: "{\"fqn\":\"oci.identityAuthenticationPolicy.IdentityAuthenticationPolicyPasswordPolicy\"}", isOptional: true)]
        public virtual oci.IdentityAuthenticationPolicy.IIdentityAuthenticationPolicyPasswordPolicy? PasswordPolicyInput
        {
            get => GetInstanceProperty<oci.IdentityAuthenticationPolicy.IIdentityAuthenticationPolicyPasswordPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.identityAuthenticationPolicy.IdentityAuthenticationPolicyTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
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
