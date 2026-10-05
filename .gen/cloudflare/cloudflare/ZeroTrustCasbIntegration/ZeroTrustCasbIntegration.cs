using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration cloudflare_zero_trust_casb_integration}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegration), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationConfig\"}}]")]
    public class ZeroTrustCasbIntegration : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration cloudflare_zero_trust_casb_integration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ZeroTrustCasbIntegration(Constructs.Construct scope, string id, cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustCasbIntegration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustCasbIntegration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ZeroTrustCasbIntegration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ZeroTrustCasbIntegration to import.</param>
        /// <param name="importFromId">The id of the existing ZeroTrustCasbIntegration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ZeroTrustCasbIntegration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ZeroTrustCasbIntegration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ZeroTrustCasbIntegration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ZeroTrustCasbIntegration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAnthropic", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropic\"}}]")]
        public virtual void PutAnthropic(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropic @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropic)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAws", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAws\"}}]")]
        public virtual void PutAws(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAws @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAws)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBox", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationBox\"}}]")]
        public virtual void PutBox(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationBox @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationBox)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGoogleCloudPlatform", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleCloudPlatform\"}}]")]
        public virtual void PutGoogleCloudPlatform(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleCloudPlatform @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleCloudPlatform)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGoogleWorkspace", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleWorkspace\"}}]")]
        public virtual void PutGoogleWorkspace(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleWorkspace @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleWorkspace)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpenai", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenai\"}}]")]
        public virtual void PutOpenai(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationOpenai @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationOpenai)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAnthropic")]
        public virtual void ResetAnthropic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAws")]
        public virtual void ResetAws()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBox")]
        public virtual void ResetBox()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDlpProfiles")]
        public virtual void ResetDlpProfiles()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGoogleCloudPlatform")]
        public virtual void ResetGoogleCloudPlatform()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGoogleWorkspace")]
        public virtual void ResetGoogleWorkspace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpenai")]
        public virtual void ResetOpenai()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPermissions")]
        public virtual void ResetPermissions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUseCases")]
        public virtual void ResetUseCases()
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
        = GetStaticProperty<string>(typeof(cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegration))!;

        [JsiiProperty(name: "anthropic", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropicOutputReference\"}")]
        public virtual cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropicOutputReference Anthropic
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropicOutputReference>()!;
        }

        [JsiiProperty(name: "aws", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAwsOutputReference\"}")]
        public virtual cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationAwsOutputReference Aws
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationAwsOutputReference>()!;
        }

        [JsiiProperty(name: "box", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationBoxOutputReference\"}")]
        public virtual cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationBoxOutputReference Box
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationBoxOutputReference>()!;
        }

        [JsiiProperty(name: "googleCloudPlatform", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleCloudPlatformOutputReference\"}")]
        public virtual cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleCloudPlatformOutputReference GoogleCloudPlatform
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleCloudPlatformOutputReference>()!;
        }

        [JsiiProperty(name: "googleWorkspace", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleWorkspaceOutputReference\"}")]
        public virtual cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleWorkspaceOutputReference GoogleWorkspace
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleWorkspaceOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "openai", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiOutputReference\"}")]
        public virtual cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiOutputReference Openai
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiOutputReference>()!;
        }

        [JsiiProperty(name: "secretsDigest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretsDigest
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAnthropic" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "anthropicInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAnthropic\"}]}}", isOptional: true)]
        public virtual object? AnthropicInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAws" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAws\"}]}}", isOptional: true)]
        public virtual object? AwsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationBox" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationBox\"}]}}", isOptional: true)]
        public virtual object? BoxInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dlpProfilesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DlpProfilesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleCloudPlatform" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "googleCloudPlatformInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleCloudPlatform\"}]}}", isOptional: true)]
        public virtual object? GoogleCloudPlatformInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleWorkspace" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "googleWorkspaceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleWorkspace\"}]}}", isOptional: true)]
        public virtual object? GoogleWorkspaceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationOpenai" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openaiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenai\"}]}}", isOptional: true)]
        public virtual object? OpenaiInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pausedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PausedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "permissionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PermissionsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "useCasesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? UseCasesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dlpProfiles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DlpProfiles
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "paused", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Paused
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Permissions
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "useCases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] UseCases
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
