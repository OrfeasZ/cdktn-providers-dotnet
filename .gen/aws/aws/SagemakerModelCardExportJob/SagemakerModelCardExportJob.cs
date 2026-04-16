using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModelCardExportJob
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_model_card_export_job aws_sagemaker_model_card_export_job}.</summary>
    [JsiiClass(nativeType: typeof(aws.SagemakerModelCardExportJob.SagemakerModelCardExportJob), fullyQualifiedName: "aws.sagemakerModelCardExportJob.SagemakerModelCardExportJob", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.sagemakerModelCardExportJob.SagemakerModelCardExportJobConfig\"}}]")]
    public class SagemakerModelCardExportJob : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_model_card_export_job aws_sagemaker_model_card_export_job} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SagemakerModelCardExportJob(Constructs.Construct scope, string id, aws.SagemakerModelCardExportJob.ISagemakerModelCardExportJobConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.SagemakerModelCardExportJob.ISagemakerModelCardExportJobConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerModelCardExportJob(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerModelCardExportJob(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a SagemakerModelCardExportJob resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SagemakerModelCardExportJob to import.</param>
        /// <param name="importFromId">The id of the existing SagemakerModelCardExportJob that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SagemakerModelCardExportJob to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SagemakerModelCardExportJob to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_model_card_export_job#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SagemakerModelCardExportJob that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SagemakerModelCardExportJob to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.SagemakerModelCardExportJob.SagemakerModelCardExportJob), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putOutputConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerModelCardExportJob.SagemakerModelCardExportJobOutputConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOutputConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerModelCardExportJob.ISagemakerModelCardExportJobOutputConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerModelCardExportJob.ISagemakerModelCardExportJobOutputConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerModelCardExportJob.ISagemakerModelCardExportJobOutputConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerModelCardExportJob.SagemakerModelCardExportJobTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.SagemakerModelCardExportJob.ISagemakerModelCardExportJobTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerModelCardExportJob.ISagemakerModelCardExportJobTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetModelCardVersion")]
        public virtual void ResetModelCardVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputConfig")]
        public virtual void ResetOutputConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
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
        = GetStaticProperty<string>(typeof(aws.SagemakerModelCardExportJob.SagemakerModelCardExportJob))!;

        [JsiiProperty(name: "exportArtifacts", typeJson: "{\"fqn\":\"aws.sagemakerModelCardExportJob.SagemakerModelCardExportJobExportArtifactsList\"}")]
        public virtual aws.SagemakerModelCardExportJob.SagemakerModelCardExportJobExportArtifactsList ExportArtifacts
        {
            get => GetInstanceProperty<aws.SagemakerModelCardExportJob.SagemakerModelCardExportJobExportArtifactsList>()!;
        }

        [JsiiProperty(name: "modelCardExportJobArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelCardExportJobArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outputConfig", typeJson: "{\"fqn\":\"aws.sagemakerModelCardExportJob.SagemakerModelCardExportJobOutputConfigList\"}")]
        public virtual aws.SagemakerModelCardExportJob.SagemakerModelCardExportJobOutputConfigList OutputConfig
        {
            get => GetInstanceProperty<aws.SagemakerModelCardExportJob.SagemakerModelCardExportJobOutputConfigList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.sagemakerModelCardExportJob.SagemakerModelCardExportJobTimeoutsOutputReference\"}")]
        public virtual aws.SagemakerModelCardExportJob.SagemakerModelCardExportJobTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.SagemakerModelCardExportJob.SagemakerModelCardExportJobTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelCardExportJobNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelCardExportJobNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelCardNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelCardNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelCardVersionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ModelCardVersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerModelCardExportJob.SagemakerModelCardExportJobOutputConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OutputConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.sagemakerModelCardExportJob.SagemakerModelCardExportJobTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "modelCardExportJobName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelCardExportJobName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelCardName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelCardName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelCardVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ModelCardVersion
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
    }
}
