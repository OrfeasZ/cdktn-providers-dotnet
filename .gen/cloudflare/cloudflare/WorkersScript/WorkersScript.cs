using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script cloudflare_workers_script}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.WorkersScript.WorkersScript), fullyQualifiedName: "cloudflare.workersScript.WorkersScript", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptConfig\"}}]")]
    public class WorkersScript : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script cloudflare_workers_script} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public WorkersScript(Constructs.Construct scope, string id, cloudflare.WorkersScript.IWorkersScriptConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.WorkersScript.IWorkersScriptConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkersScript(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkersScript(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a WorkersScript resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the WorkersScript to import.</param>
        /// <param name="importFromId">The id of the existing WorkersScript that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the WorkersScript to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the WorkersScript to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing WorkersScript that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the WorkersScript to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.WorkersScript.WorkersScript), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAnnotations", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptAnnotations\"}}]")]
        public virtual void PutAnnotations(cloudflare.WorkersScript.IWorkersScriptAnnotations @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.WorkersScript.IWorkersScriptAnnotations)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAssets", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptAssets\"}}]")]
        public virtual void PutAssets(cloudflare.WorkersScript.IWorkersScriptAssets @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.WorkersScript.IWorkersScriptAssets)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBindings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptBindings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutBindings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case cloudflare.WorkersScript.IWorkersScriptBindings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkersScript.IWorkersScriptBindings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkersScript.IWorkersScriptBindings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLimits", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptLimits\"}}]")]
        public virtual void PutLimits(cloudflare.WorkersScript.IWorkersScriptLimits @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.WorkersScript.IWorkersScriptLimits)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMigrations", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptMigrations\"}}]")]
        public virtual void PutMigrations(cloudflare.WorkersScript.IWorkersScriptMigrations @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.WorkersScript.IWorkersScriptMigrations)}, new object[]{@value});
        }

        [JsiiMethod(name: "putObservability", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptObservability\"}}]")]
        public virtual void PutObservability(cloudflare.WorkersScript.IWorkersScriptObservability @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.WorkersScript.IWorkersScriptObservability)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlacement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptPlacement\"}}]")]
        public virtual void PutPlacement(cloudflare.WorkersScript.IWorkersScriptPlacement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.WorkersScript.IWorkersScriptPlacement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTailConsumers", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptTailConsumers\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTailConsumers(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case cloudflare.WorkersScript.IWorkersScriptTailConsumers[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkersScript.IWorkersScriptTailConsumers).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkersScript.IWorkersScriptTailConsumers).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountId")]
        public virtual void ResetAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAnnotations")]
        public virtual void ResetAnnotations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAssets")]
        public virtual void ResetAssets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBindings")]
        public virtual void ResetBindings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBodyPart")]
        public virtual void ResetBodyPart()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompatibilityDate")]
        public virtual void ResetCompatibilityDate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompatibilityFlags")]
        public virtual void ResetCompatibilityFlags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContent")]
        public virtual void ResetContent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContentFile")]
        public virtual void ResetContentFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContentSha256")]
        public virtual void ResetContentSha256()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContentType")]
        public virtual void ResetContentType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeepAssets")]
        public virtual void ResetKeepAssets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeepBindings")]
        public virtual void ResetKeepBindings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLimits")]
        public virtual void ResetLimits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogpush")]
        public virtual void ResetLogpush()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMainModule")]
        public virtual void ResetMainModule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMigrations")]
        public virtual void ResetMigrations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObservability")]
        public virtual void ResetObservability()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacement")]
        public virtual void ResetPlacement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTailConsumers")]
        public virtual void ResetTailConsumers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsageModel")]
        public virtual void ResetUsageModel()
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
        = GetStaticProperty<string>(typeof(cloudflare.WorkersScript.WorkersScript))!;

        [JsiiProperty(name: "annotations", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptAnnotationsOutputReference\"}")]
        public virtual cloudflare.WorkersScript.WorkersScriptAnnotationsOutputReference Annotations
        {
            get => GetInstanceProperty<cloudflare.WorkersScript.WorkersScriptAnnotationsOutputReference>()!;
        }

        [JsiiProperty(name: "assets", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptAssetsOutputReference\"}")]
        public virtual cloudflare.WorkersScript.WorkersScriptAssetsOutputReference Assets
        {
            get => GetInstanceProperty<cloudflare.WorkersScript.WorkersScriptAssetsOutputReference>()!;
        }

        [JsiiProperty(name: "bindings", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptBindingsList\"}")]
        public virtual cloudflare.WorkersScript.WorkersScriptBindingsList Bindings
        {
            get => GetInstanceProperty<cloudflare.WorkersScript.WorkersScriptBindingsList>()!;
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Etag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "handlers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Handlers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "hasAssets", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HasAssets
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "hasModules", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HasModules
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastDeployedFrom", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastDeployedFrom
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptLimitsOutputReference\"}")]
        public virtual cloudflare.WorkersScript.WorkersScriptLimitsOutputReference Limits
        {
            get => GetInstanceProperty<cloudflare.WorkersScript.WorkersScriptLimitsOutputReference>()!;
        }

        [JsiiProperty(name: "migrations", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptMigrationsOutputReference\"}")]
        public virtual cloudflare.WorkersScript.WorkersScriptMigrationsOutputReference Migrations
        {
            get => GetInstanceProperty<cloudflare.WorkersScript.WorkersScriptMigrationsOutputReference>()!;
        }

        [JsiiProperty(name: "migrationTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MigrationTag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modifiedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "namedHandlers", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptNamedHandlersList\"}")]
        public virtual cloudflare.WorkersScript.WorkersScriptNamedHandlersList NamedHandlers
        {
            get => GetInstanceProperty<cloudflare.WorkersScript.WorkersScriptNamedHandlersList>()!;
        }

        [JsiiProperty(name: "observability", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptObservabilityOutputReference\"}")]
        public virtual cloudflare.WorkersScript.WorkersScriptObservabilityOutputReference Observability
        {
            get => GetInstanceProperty<cloudflare.WorkersScript.WorkersScriptObservabilityOutputReference>()!;
        }

        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptPlacementOutputReference\"}")]
        public virtual cloudflare.WorkersScript.WorkersScriptPlacementOutputReference Placement
        {
            get => GetInstanceProperty<cloudflare.WorkersScript.WorkersScriptPlacementOutputReference>()!;
        }

        [JsiiProperty(name: "placementMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlacementMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "placementStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlacementStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startupTimeMs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartupTimeMs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tailConsumers", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptTailConsumersList\"}")]
        public virtual cloudflare.WorkersScript.WorkersScriptTailConsumersList TailConsumers
        {
            get => GetInstanceProperty<cloudflare.WorkersScript.WorkersScriptTailConsumersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "annotationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.workersScript.WorkersScriptAnnotations\"}]}}", isOptional: true)]
        public virtual object? AnnotationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "assetsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.workersScript.WorkersScriptAssets\"}]}}", isOptional: true)]
        public virtual object? AssetsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bindingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptBindings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? BindingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bodyPartInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BodyPartInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compatibilityDateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompatibilityDateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compatibilityFlagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? CompatibilityFlagsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentFileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContentFileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentSha256Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContentSha256Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keepAssetsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? KeepAssetsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keepBindingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? KeepBindingsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "limitsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.workersScript.WorkersScriptLimits\"}]}}", isOptional: true)]
        public virtual object? LimitsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logpushInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? LogpushInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mainModuleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MainModuleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "migrationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.workersScript.WorkersScriptMigrations\"}]}}", isOptional: true)]
        public virtual object? MigrationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "observabilityInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.workersScript.WorkersScriptObservability\"}]}}", isOptional: true)]
        public virtual object? ObservabilityInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.workersScript.WorkersScriptPlacement\"}]}}", isOptional: true)]
        public virtual object? PlacementInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scriptNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScriptNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tailConsumersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptTailConsumers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TailConsumersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usageModelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsageModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bodyPart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BodyPart
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compatibilityDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompatibilityDate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compatibilityFlags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CompatibilityFlags
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Content
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "contentFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContentFile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "contentSha256", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContentSha256
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keepAssets", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object KeepAssets
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

        [JsiiProperty(name: "keepBindings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] KeepBindings
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logpush", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Logpush
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

        [JsiiProperty(name: "mainModule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MainModule
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scriptName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScriptName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "usageModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageModel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
