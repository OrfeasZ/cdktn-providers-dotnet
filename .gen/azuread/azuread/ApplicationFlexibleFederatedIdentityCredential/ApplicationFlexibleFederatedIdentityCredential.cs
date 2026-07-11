using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ApplicationFlexibleFederatedIdentityCredential
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential azuread_application_flexible_federated_identity_credential}.</summary>
    [JsiiClass(nativeType: typeof(azuread.ApplicationFlexibleFederatedIdentityCredential.ApplicationFlexibleFederatedIdentityCredential), fullyQualifiedName: "azuread.applicationFlexibleFederatedIdentityCredential.ApplicationFlexibleFederatedIdentityCredential", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuread.applicationFlexibleFederatedIdentityCredential.ApplicationFlexibleFederatedIdentityCredentialConfig\"}}]")]
    public class ApplicationFlexibleFederatedIdentityCredential : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential azuread_application_flexible_federated_identity_credential} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ApplicationFlexibleFederatedIdentityCredential(Constructs.Construct scope, string id, azuread.ApplicationFlexibleFederatedIdentityCredential.IApplicationFlexibleFederatedIdentityCredentialConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuread.ApplicationFlexibleFederatedIdentityCredential.IApplicationFlexibleFederatedIdentityCredentialConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApplicationFlexibleFederatedIdentityCredential(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApplicationFlexibleFederatedIdentityCredential(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ApplicationFlexibleFederatedIdentityCredential resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ApplicationFlexibleFederatedIdentityCredential to import.</param>
        /// <param name="importFromId">The id of the existing ApplicationFlexibleFederatedIdentityCredential that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ApplicationFlexibleFederatedIdentityCredential to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ApplicationFlexibleFederatedIdentityCredential to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ApplicationFlexibleFederatedIdentityCredential that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ApplicationFlexibleFederatedIdentityCredential to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuread.ApplicationFlexibleFederatedIdentityCredential.ApplicationFlexibleFederatedIdentityCredential), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.applicationFlexibleFederatedIdentityCredential.ApplicationFlexibleFederatedIdentityCredentialTimeouts\"}}]")]
        public virtual void PutTimeouts(azuread.ApplicationFlexibleFederatedIdentityCredential.IApplicationFlexibleFederatedIdentityCredentialTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.ApplicationFlexibleFederatedIdentityCredential.IApplicationFlexibleFederatedIdentityCredentialTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(azuread.ApplicationFlexibleFederatedIdentityCredential.ApplicationFlexibleFederatedIdentityCredential))!;

        [JsiiProperty(name: "credentialId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CredentialId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.applicationFlexibleFederatedIdentityCredential.ApplicationFlexibleFederatedIdentityCredentialTimeoutsOutputReference\"}")]
        public virtual azuread.ApplicationFlexibleFederatedIdentityCredential.ApplicationFlexibleFederatedIdentityCredentialTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuread.ApplicationFlexibleFederatedIdentityCredential.ApplicationFlexibleFederatedIdentityCredentialTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplicationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "audienceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AudienceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "claimsMatchingExpressionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClaimsMatchingExpressionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
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
        [JsiiProperty(name: "issuerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IssuerInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuread.ApplicationFlexibleFederatedIdentityCredential.IApplicationFlexibleFederatedIdentityCredentialTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuread.applicationFlexibleFederatedIdentityCredential.ApplicationFlexibleFederatedIdentityCredentialTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Audience
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "claimsMatchingExpression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClaimsMatchingExpression
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issuer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
