using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdamicrovmsImage
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_image aws_lambdamicrovms_image}.</summary>
    [JsiiClass(nativeType: typeof(aws.LambdamicrovmsImage.LambdamicrovmsImage), fullyQualifiedName: "aws.lambdamicrovmsImage.LambdamicrovmsImage", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lambdamicrovmsImage.LambdamicrovmsImageConfig\"}}]")]
    public class LambdamicrovmsImage : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_image aws_lambdamicrovms_image} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LambdamicrovmsImage(Constructs.Construct scope, string id, aws.LambdamicrovmsImage.ILambdamicrovmsImageConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.LambdamicrovmsImage.ILambdamicrovmsImageConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdamicrovmsImage(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdamicrovmsImage(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a LambdamicrovmsImage resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LambdamicrovmsImage to import.</param>
        /// <param name="importFromId">The id of the existing LambdamicrovmsImage that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LambdamicrovmsImage to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LambdamicrovmsImage to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_image#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LambdamicrovmsImage that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LambdamicrovmsImage to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.LambdamicrovmsImage.LambdamicrovmsImage), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdamicrovmsImage.ILambdamicrovmsImageCodeArtifact" />)[]</param>
        [JsiiMethod(name: "putCodeArtifact", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdamicrovmsImage.LambdamicrovmsImageCodeArtifact\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCodeArtifact(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.LambdamicrovmsImage.ILambdamicrovmsImageCodeArtifact[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdamicrovmsImage.ILambdamicrovmsImageCodeArtifact).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdamicrovmsImage.ILambdamicrovmsImageCodeArtifact).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdamicrovmsImage.ILambdamicrovmsImageCpuConfiguration" />)[]</param>
        [JsiiMethod(name: "putCpuConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdamicrovmsImage.LambdamicrovmsImageCpuConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCpuConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.LambdamicrovmsImage.ILambdamicrovmsImageCpuConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdamicrovmsImage.ILambdamicrovmsImageCpuConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdamicrovmsImage.ILambdamicrovmsImageCpuConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdamicrovmsImage.LambdamicrovmsImageTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.LambdamicrovmsImage.ILambdamicrovmsImageTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdamicrovmsImage.ILambdamicrovmsImageTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalOsCapabilities")]
        public virtual void ResetAdditionalOsCapabilities()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBaseImageVersion")]
        public virtual void ResetBaseImageVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCodeArtifact")]
        public virtual void ResetCodeArtifact()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpuConfiguration")]
        public virtual void ResetCpuConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEgressNetworkConnectors")]
        public virtual void ResetEgressNetworkConnectors()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironmentVariables")]
        public virtual void ResetEnvironmentVariables()
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
        = GetStaticProperty<string>(typeof(aws.LambdamicrovmsImage.LambdamicrovmsImage))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "codeArtifact", typeJson: "{\"fqn\":\"aws.lambdamicrovmsImage.LambdamicrovmsImageCodeArtifactList\"}")]
        public virtual aws.LambdamicrovmsImage.LambdamicrovmsImageCodeArtifactList CodeArtifact
        {
            get => GetInstanceProperty<aws.LambdamicrovmsImage.LambdamicrovmsImageCodeArtifactList>()!;
        }

        [JsiiProperty(name: "cpuConfiguration", typeJson: "{\"fqn\":\"aws.lambdamicrovmsImage.LambdamicrovmsImageCpuConfigurationList\"}")]
        public virtual aws.LambdamicrovmsImage.LambdamicrovmsImageCpuConfigurationList CpuConfiguration
        {
            get => GetInstanceProperty<aws.LambdamicrovmsImage.LambdamicrovmsImageCpuConfigurationList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "latestActiveImageVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LatestActiveImageVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "latestFailedImageVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LatestFailedImageVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap TagsAll
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lambdamicrovmsImage.LambdamicrovmsImageTimeoutsOutputReference\"}")]
        public virtual aws.LambdamicrovmsImage.LambdamicrovmsImageTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.LambdamicrovmsImage.LambdamicrovmsImageTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalOsCapabilitiesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AdditionalOsCapabilitiesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "baseImageArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BaseImageArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "baseImageVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BaseImageVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BuildRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdamicrovmsImage.ILambdamicrovmsImageCodeArtifact" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeArtifactInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdamicrovmsImage.LambdamicrovmsImageCodeArtifact\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CodeArtifactInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdamicrovmsImage.ILambdamicrovmsImageCpuConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cpuConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdamicrovmsImage.LambdamicrovmsImageCpuConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CpuConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "egressNetworkConnectorsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? EgressNetworkConnectorsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentVariablesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? EnvironmentVariablesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.LambdamicrovmsImage.ILambdamicrovmsImageTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.lambdamicrovmsImage.LambdamicrovmsImageTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "additionalOsCapabilities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AdditionalOsCapabilities
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "baseImageArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaseImageArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "baseImageVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaseImageVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "buildRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildRoleArn
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

        [JsiiProperty(name: "egressNetworkConnectors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EgressNetworkConnectors
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> EnvironmentVariables
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
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
