using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OsisPipelineEndpoint
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/osis_pipeline_endpoint aws_osis_pipeline_endpoint}.</summary>
    [JsiiClass(nativeType: typeof(aws.OsisPipelineEndpoint.OsisPipelineEndpoint), fullyQualifiedName: "aws.osisPipelineEndpoint.OsisPipelineEndpoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.osisPipelineEndpoint.OsisPipelineEndpointConfig\"}}]")]
    public class OsisPipelineEndpoint : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/osis_pipeline_endpoint aws_osis_pipeline_endpoint} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OsisPipelineEndpoint(Constructs.Construct scope, string id, aws.OsisPipelineEndpoint.IOsisPipelineEndpointConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.OsisPipelineEndpoint.IOsisPipelineEndpointConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsisPipelineEndpoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsisPipelineEndpoint(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OsisPipelineEndpoint resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OsisPipelineEndpoint to import.</param>
        /// <param name="importFromId">The id of the existing OsisPipelineEndpoint that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OsisPipelineEndpoint to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OsisPipelineEndpoint to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/osis_pipeline_endpoint#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OsisPipelineEndpoint that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OsisPipelineEndpoint to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.OsisPipelineEndpoint.OsisPipelineEndpoint), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.osisPipelineEndpoint.OsisPipelineEndpointTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.OsisPipelineEndpoint.IOsisPipelineEndpointTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OsisPipelineEndpoint.IOsisPipelineEndpointTimeouts)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OsisPipelineEndpoint.IOsisPipelineEndpointVpcOptions" />)[]</param>
        [JsiiMethod(name: "putVpcOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.osisPipelineEndpoint.OsisPipelineEndpointVpcOptions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVpcOptions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.OsisPipelineEndpoint.IOsisPipelineEndpointVpcOptions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.OsisPipelineEndpoint.IOsisPipelineEndpointVpcOptions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.OsisPipelineEndpoint.IOsisPipelineEndpointVpcOptions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
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

        [JsiiMethod(name: "resetVpcOptions")]
        public virtual void ResetVpcOptions()
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
        = GetStaticProperty<string>(typeof(aws.OsisPipelineEndpoint.OsisPipelineEndpoint))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.osisPipelineEndpoint.OsisPipelineEndpointTimeoutsOutputReference\"}")]
        public virtual aws.OsisPipelineEndpoint.OsisPipelineEndpointTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.OsisPipelineEndpoint.OsisPipelineEndpointTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcOptions", typeJson: "{\"fqn\":\"aws.osisPipelineEndpoint.OsisPipelineEndpointVpcOptionsList\"}")]
        public virtual aws.OsisPipelineEndpoint.OsisPipelineEndpointVpcOptionsList VpcOptions
        {
            get => GetInstanceProperty<aws.OsisPipelineEndpoint.OsisPipelineEndpointVpcOptionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "pipelineArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PipelineArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.OsisPipelineEndpoint.IOsisPipelineEndpointTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.osisPipelineEndpoint.OsisPipelineEndpointTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OsisPipelineEndpoint.IOsisPipelineEndpointVpcOptions" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.osisPipelineEndpoint.OsisPipelineEndpointVpcOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VpcOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "pipelineArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PipelineArn
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
    }
}
