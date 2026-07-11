using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Invitation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/invitation azuread_invitation}.</summary>
    [JsiiClass(nativeType: typeof(azuread.Invitation.Invitation), fullyQualifiedName: "azuread.invitation.Invitation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuread.invitation.InvitationConfig\"}}]")]
    public class Invitation : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/invitation azuread_invitation} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Invitation(Constructs.Construct scope, string id, azuread.Invitation.IInvitationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuread.Invitation.IInvitationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Invitation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Invitation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Invitation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Invitation to import.</param>
        /// <param name="importFromId">The id of the existing Invitation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Invitation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Invitation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/invitation#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Invitation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Invitation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuread.Invitation.Invitation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putMessage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.invitation.InvitationMessage\"}}]")]
        public virtual void PutMessage(azuread.Invitation.IInvitationMessage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.Invitation.IInvitationMessage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.invitation.InvitationTimeouts\"}}]")]
        public virtual void PutTimeouts(azuread.Invitation.IInvitationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.Invitation.IInvitationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMessage")]
        public virtual void ResetMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserDisplayName")]
        public virtual void ResetUserDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserType")]
        public virtual void ResetUserType()
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
        = GetStaticProperty<string>(typeof(azuread.Invitation.Invitation))!;

        [JsiiProperty(name: "message", typeJson: "{\"fqn\":\"azuread.invitation.InvitationMessageOutputReference\"}")]
        public virtual azuread.Invitation.InvitationMessageOutputReference Message
        {
            get => GetInstanceProperty<azuread.Invitation.InvitationMessageOutputReference>()!;
        }

        [JsiiProperty(name: "redeemUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedeemUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.invitation.InvitationTimeoutsOutputReference\"}")]
        public virtual azuread.Invitation.InvitationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuread.Invitation.InvitationTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "messageInput", typeJson: "{\"fqn\":\"azuread.invitation.InvitationMessage\"}", isOptional: true)]
        public virtual azuread.Invitation.IInvitationMessage? MessageInput
        {
            get => GetInstanceProperty<azuread.Invitation.IInvitationMessage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redirectUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RedirectUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuread.Invitation.IInvitationTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuread.invitation.InvitationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userDisplayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserDisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userEmailAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserEmailAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "redirectUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedirectUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserDisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userEmailAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserEmailAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
