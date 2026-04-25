using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version cloudflare_worker_version}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.WorkerVersion.WorkerVersion), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersion", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionConfig\"}}]")]
    public class WorkerVersion : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version cloudflare_worker_version} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public WorkerVersion(Constructs.Construct scope, string id, cloudflare.WorkerVersion.IWorkerVersionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.WorkerVersion.IWorkerVersionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkerVersion(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkerVersion(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a WorkerVersion resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the WorkerVersion to import.</param>
        /// <param name="importFromId">The id of the existing WorkerVersion that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the WorkerVersion to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the WorkerVersion to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing WorkerVersion that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the WorkerVersion to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.WorkerVersion.WorkerVersion), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAnnotations", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionAnnotations\"}}]")]
        public virtual void PutAnnotations(cloudflare.WorkerVersion.IWorkerVersionAnnotations @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.WorkerVersion.IWorkerVersionAnnotations)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAssets", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionAssets\"}}]")]
        public virtual void PutAssets(cloudflare.WorkerVersion.IWorkerVersionAssets @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.WorkerVersion.IWorkerVersionAssets)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBindings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionBindings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutBindings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case cloudflare.WorkerVersion.IWorkerVersionBindings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkerVersion.IWorkerVersionBindings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkerVersion.IWorkerVersionBindings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putContainers", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionContainers\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutContainers(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case cloudflare.WorkerVersion.IWorkerVersionContainers[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkerVersion.IWorkerVersionContainers).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkerVersion.IWorkerVersionContainers).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLimits", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionLimits\"}}]")]
        public virtual void PutLimits(cloudflare.WorkerVersion.IWorkerVersionLimits @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.WorkerVersion.IWorkerVersionLimits)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMigrations", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionMigrations\"}}]")]
        public virtual void PutMigrations(cloudflare.WorkerVersion.IWorkerVersionMigrations @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.WorkerVersion.IWorkerVersionMigrations)}, new object[]{@value});
        }

        [JsiiMethod(name: "putModules", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionModules\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutModules(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case cloudflare.WorkerVersion.IWorkerVersionModules[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkerVersion.IWorkerVersionModules).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkerVersion.IWorkerVersionModules).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlacement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionPlacement\"}}]")]
        public virtual void PutPlacement(cloudflare.WorkerVersion.IWorkerVersionPlacement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.WorkerVersion.IWorkerVersionPlacement)}, new object[]{@value});
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

        [JsiiMethod(name: "resetContainers")]
        public virtual void ResetContainers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLimits")]
        public virtual void ResetLimits()
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

        [JsiiMethod(name: "resetModules")]
        public virtual void ResetModules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacement")]
        public virtual void ResetPlacement()
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
        = GetStaticProperty<string>(typeof(cloudflare.WorkerVersion.WorkerVersion))!;

        [JsiiProperty(name: "annotations", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionAnnotationsOutputReference\"}")]
        public virtual cloudflare.WorkerVersion.WorkerVersionAnnotationsOutputReference Annotations
        {
            get => GetInstanceProperty<cloudflare.WorkerVersion.WorkerVersionAnnotationsOutputReference>()!;
        }

        [JsiiProperty(name: "assets", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionAssetsOutputReference\"}")]
        public virtual cloudflare.WorkerVersion.WorkerVersionAssetsOutputReference Assets
        {
            get => GetInstanceProperty<cloudflare.WorkerVersion.WorkerVersionAssetsOutputReference>()!;
        }

        [JsiiProperty(name: "bindings", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionBindingsList\"}")]
        public virtual cloudflare.WorkerVersion.WorkerVersionBindingsList Bindings
        {
            get => GetInstanceProperty<cloudflare.WorkerVersion.WorkerVersionBindingsList>()!;
        }

        [JsiiProperty(name: "containers", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionContainersList\"}")]
        public virtual cloudflare.WorkerVersion.WorkerVersionContainersList Containers
        {
            get => GetInstanceProperty<cloudflare.WorkerVersion.WorkerVersionContainersList>()!;
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionLimitsOutputReference\"}")]
        public virtual cloudflare.WorkerVersion.WorkerVersionLimitsOutputReference Limits
        {
            get => GetInstanceProperty<cloudflare.WorkerVersion.WorkerVersionLimitsOutputReference>()!;
        }

        [JsiiProperty(name: "mainScriptBase64", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MainScriptBase64
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "migrations", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionMigrationsOutputReference\"}")]
        public virtual cloudflare.WorkerVersion.WorkerVersionMigrationsOutputReference Migrations
        {
            get => GetInstanceProperty<cloudflare.WorkerVersion.WorkerVersionMigrationsOutputReference>()!;
        }

        [JsiiProperty(name: "migrationTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MigrationTag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modules", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionModulesList\"}")]
        public virtual cloudflare.WorkerVersion.WorkerVersionModulesList Modules
        {
            get => GetInstanceProperty<cloudflare.WorkerVersion.WorkerVersionModulesList>()!;
        }

        [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Number
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionPlacementOutputReference\"}")]
        public virtual cloudflare.WorkerVersion.WorkerVersionPlacementOutputReference Placement
        {
            get => GetInstanceProperty<cloudflare.WorkerVersion.WorkerVersionPlacementOutputReference>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Source
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startupTimeMs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartupTimeMs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "urls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Urls
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "annotationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.workerVersion.WorkerVersionAnnotations\"}]}}", isOptional: true)]
        public virtual object? AnnotationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "assetsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.workerVersion.WorkerVersionAssets\"}]}}", isOptional: true)]
        public virtual object? AssetsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bindingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionBindings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? BindingsInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "containersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionContainers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ContainersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "limitsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.workerVersion.WorkerVersionLimits\"}]}}", isOptional: true)]
        public virtual object? LimitsInput
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
        [JsiiProperty(name: "migrationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.workerVersion.WorkerVersionMigrations\"}]}}", isOptional: true)]
        public virtual object? MigrationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modulesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionModules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ModulesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.workerVersion.WorkerVersionPlacement\"}]}}", isOptional: true)]
        public virtual object? PlacementInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usageModelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsageModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
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

        [JsiiProperty(name: "mainModule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MainModule
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

        [JsiiProperty(name: "workerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
