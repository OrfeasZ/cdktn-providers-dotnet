using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CognitiveAccountProject
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cognitive_account_project azurerm_cognitive_account_project}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.CognitiveAccountProject.CognitiveAccountProject), fullyQualifiedName: "azurerm.cognitiveAccountProject.CognitiveAccountProject", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.cognitiveAccountProject.CognitiveAccountProjectConfig\"}}]")]
    public class CognitiveAccountProject : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cognitive_account_project azurerm_cognitive_account_project} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CognitiveAccountProject(Constructs.Construct scope, string id, azurerm.CognitiveAccountProject.ICognitiveAccountProjectConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.CognitiveAccountProject.ICognitiveAccountProjectConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitiveAccountProject(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitiveAccountProject(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a CognitiveAccountProject resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CognitiveAccountProject to import.</param>
        /// <param name="importFromId">The id of the existing CognitiveAccountProject that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CognitiveAccountProject to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CognitiveAccountProject to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cognitive_account_project#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CognitiveAccountProject that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CognitiveAccountProject to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.CognitiveAccountProject.CognitiveAccountProject), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cognitiveAccountProject.CognitiveAccountProjectIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.CognitiveAccountProject.ICognitiveAccountProjectIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CognitiveAccountProject.ICognitiveAccountProjectIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cognitiveAccountProject.CognitiveAccountProjectTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.CognitiveAccountProject.ICognitiveAccountProjectTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CognitiveAccountProject.ICognitiveAccountProjectTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(azurerm.CognitiveAccountProject.CognitiveAccountProject))!;

        [JsiiProperty(name: "default", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Default
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "endpoints", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Endpoints
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.cognitiveAccountProject.CognitiveAccountProjectIdentityOutputReference\"}")]
        public virtual azurerm.CognitiveAccountProject.CognitiveAccountProjectIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.CognitiveAccountProject.CognitiveAccountProjectIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cognitiveAccountProject.CognitiveAccountProjectTimeoutsOutputReference\"}")]
        public virtual azurerm.CognitiveAccountProject.CognitiveAccountProjectTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.CognitiveAccountProject.CognitiveAccountProjectTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cognitiveAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CognitiveAccountIdInput
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
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.cognitiveAccountProject.CognitiveAccountProjectIdentity\"}", isOptional: true)]
        public virtual azurerm.CognitiveAccountProject.ICognitiveAccountProjectIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.CognitiveAccountProject.ICognitiveAccountProjectIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.CognitiveAccountProject.ICognitiveAccountProjectTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.cognitiveAccountProject.CognitiveAccountProjectTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "cognitiveAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CognitiveAccountId
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

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
