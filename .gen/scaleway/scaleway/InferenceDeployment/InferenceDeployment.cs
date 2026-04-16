using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InferenceDeployment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment scaleway_inference_deployment}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.InferenceDeployment.InferenceDeployment), fullyQualifiedName: "scaleway.inferenceDeployment.InferenceDeployment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentConfig\"}}]")]
    public class InferenceDeployment : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment scaleway_inference_deployment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public InferenceDeployment(Constructs.Construct scope, string id, scaleway.InferenceDeployment.IInferenceDeploymentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.InferenceDeployment.IInferenceDeploymentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InferenceDeployment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InferenceDeployment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a InferenceDeployment resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the InferenceDeployment to import.</param>
        /// <param name="importFromId">The id of the existing InferenceDeployment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the InferenceDeployment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the InferenceDeployment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing InferenceDeployment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the InferenceDeployment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.InferenceDeployment.InferenceDeployment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putPrivateEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentPrivateEndpoint\"}}]")]
        public virtual void PutPrivateEndpoint(scaleway.InferenceDeployment.IInferenceDeploymentPrivateEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.InferenceDeployment.IInferenceDeploymentPrivateEndpoint)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPrivateIp", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentPrivateIp\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPrivateIp(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case scaleway.InferenceDeployment.IInferenceDeploymentPrivateIp[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.InferenceDeployment.IInferenceDeploymentPrivateIp).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.InferenceDeployment.IInferenceDeploymentPrivateIp).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPublicEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentPublicEndpoint\"}}]")]
        public virtual void PutPublicEndpoint(scaleway.InferenceDeployment.IInferenceDeploymentPublicEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.InferenceDeployment.IInferenceDeploymentPublicEndpoint)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentTimeouts\"}}]")]
        public virtual void PutTimeouts(scaleway.InferenceDeployment.IInferenceDeploymentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.InferenceDeployment.IInferenceDeploymentTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcceptEula")]
        public virtual void ResetAcceptEula()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxSize")]
        public virtual void ResetMaxSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinSize")]
        public virtual void ResetMinSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateEndpoint")]
        public virtual void ResetPrivateEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateIp")]
        public virtual void ResetPrivateIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProjectId")]
        public virtual void ResetProjectId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicEndpoint")]
        public virtual void ResetPublicEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuantization")]
        public virtual void ResetQuantization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
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
        = GetStaticProperty<string>(typeof(scaleway.InferenceDeployment.InferenceDeployment))!;

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateEndpoint", typeJson: "{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentPrivateEndpointOutputReference\"}")]
        public virtual scaleway.InferenceDeployment.InferenceDeploymentPrivateEndpointOutputReference PrivateEndpoint
        {
            get => GetInstanceProperty<scaleway.InferenceDeployment.InferenceDeploymentPrivateEndpointOutputReference>()!;
        }

        [JsiiProperty(name: "privateIp", typeJson: "{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentPrivateIpList\"}")]
        public virtual scaleway.InferenceDeployment.InferenceDeploymentPrivateIpList PrivateIp
        {
            get => GetInstanceProperty<scaleway.InferenceDeployment.InferenceDeploymentPrivateIpList>()!;
        }

        [JsiiProperty(name: "publicEndpoint", typeJson: "{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentPublicEndpointOutputReference\"}")]
        public virtual scaleway.InferenceDeployment.InferenceDeploymentPublicEndpointOutputReference PublicEndpoint
        {
            get => GetInstanceProperty<scaleway.InferenceDeployment.InferenceDeploymentPublicEndpointOutputReference>()!;
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Size
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentTimeoutsOutputReference\"}")]
        public virtual scaleway.InferenceDeployment.InferenceDeploymentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<scaleway.InferenceDeployment.InferenceDeploymentTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceptEulaInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AcceptEulaInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelIdInput
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
        [JsiiProperty(name: "nodeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateEndpointInput", typeJson: "{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentPrivateEndpoint\"}", isOptional: true)]
        public virtual scaleway.InferenceDeployment.IInferenceDeploymentPrivateEndpoint? PrivateEndpointInput
        {
            get => GetInstanceProperty<scaleway.InferenceDeployment.IInferenceDeploymentPrivateEndpoint?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateIpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentPrivateIp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PrivateIpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicEndpointInput", typeJson: "{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentPublicEndpoint\"}", isOptional: true)]
        public virtual scaleway.InferenceDeployment.IInferenceDeploymentPublicEndpoint? PublicEndpointInput
        {
            get => GetInstanceProperty<scaleway.InferenceDeployment.IInferenceDeploymentPublicEndpoint?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "quantizationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? QuantizationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TagsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.inferenceDeployment.InferenceDeploymentTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "acceptEula", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AcceptEula
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelId
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

        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "quantization", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Quantization
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
