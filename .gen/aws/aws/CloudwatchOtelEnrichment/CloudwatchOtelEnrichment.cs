using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchOtelEnrichment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/cloudwatch_otel_enrichment aws_cloudwatch_otel_enrichment}.</summary>
    [JsiiClass(nativeType: typeof(aws.CloudwatchOtelEnrichment.CloudwatchOtelEnrichment), fullyQualifiedName: "aws.cloudwatchOtelEnrichment.CloudwatchOtelEnrichment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.cloudwatchOtelEnrichment.CloudwatchOtelEnrichmentConfig\"}}]")]
    public class CloudwatchOtelEnrichment : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/cloudwatch_otel_enrichment aws_cloudwatch_otel_enrichment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudwatchOtelEnrichment(Constructs.Construct scope, string id, aws.CloudwatchOtelEnrichment.ICloudwatchOtelEnrichmentConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.CloudwatchOtelEnrichment.ICloudwatchOtelEnrichmentConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchOtelEnrichment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchOtelEnrichment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a CloudwatchOtelEnrichment resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CloudwatchOtelEnrichment to import.</param>
        /// <param name="importFromId">The id of the existing CloudwatchOtelEnrichment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CloudwatchOtelEnrichment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CloudwatchOtelEnrichment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/cloudwatch_otel_enrichment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CloudwatchOtelEnrichment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CloudwatchOtelEnrichment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.CloudwatchOtelEnrichment.CloudwatchOtelEnrichment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchOtelEnrichment.ICloudwatchOtelEnrichmentExcludeFilter" />)[]</param>
        [JsiiMethod(name: "putExcludeFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchOtelEnrichment.CloudwatchOtelEnrichmentExcludeFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutExcludeFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudwatchOtelEnrichment.ICloudwatchOtelEnrichmentExcludeFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchOtelEnrichment.ICloudwatchOtelEnrichmentExcludeFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchOtelEnrichment.ICloudwatchOtelEnrichmentExcludeFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchOtelEnrichment.ICloudwatchOtelEnrichmentIncludeFilter" />)[]</param>
        [JsiiMethod(name: "putIncludeFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchOtelEnrichment.CloudwatchOtelEnrichmentIncludeFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIncludeFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudwatchOtelEnrichment.ICloudwatchOtelEnrichmentIncludeFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchOtelEnrichment.ICloudwatchOtelEnrichmentIncludeFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchOtelEnrichment.ICloudwatchOtelEnrichmentIncludeFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchOtelEnrichment.CloudwatchOtelEnrichmentTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.CloudwatchOtelEnrichment.ICloudwatchOtelEnrichmentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchOtelEnrichment.ICloudwatchOtelEnrichmentTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExcludeFilter")]
        public virtual void ResetExcludeFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludeFilter")]
        public virtual void ResetIncludeFilter()
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
        = GetStaticProperty<string>(typeof(aws.CloudwatchOtelEnrichment.CloudwatchOtelEnrichment))!;

        [JsiiProperty(name: "excludeFilter", typeJson: "{\"fqn\":\"aws.cloudwatchOtelEnrichment.CloudwatchOtelEnrichmentExcludeFilterList\"}")]
        public virtual aws.CloudwatchOtelEnrichment.CloudwatchOtelEnrichmentExcludeFilterList ExcludeFilter
        {
            get => GetInstanceProperty<aws.CloudwatchOtelEnrichment.CloudwatchOtelEnrichmentExcludeFilterList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "includeFilter", typeJson: "{\"fqn\":\"aws.cloudwatchOtelEnrichment.CloudwatchOtelEnrichmentIncludeFilterList\"}")]
        public virtual aws.CloudwatchOtelEnrichment.CloudwatchOtelEnrichmentIncludeFilterList IncludeFilter
        {
            get => GetInstanceProperty<aws.CloudwatchOtelEnrichment.CloudwatchOtelEnrichmentIncludeFilterList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.cloudwatchOtelEnrichment.CloudwatchOtelEnrichmentTimeoutsOutputReference\"}")]
        public virtual aws.CloudwatchOtelEnrichment.CloudwatchOtelEnrichmentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.CloudwatchOtelEnrichment.CloudwatchOtelEnrichmentTimeoutsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchOtelEnrichment.ICloudwatchOtelEnrichmentExcludeFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "excludeFilterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchOtelEnrichment.CloudwatchOtelEnrichmentExcludeFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ExcludeFilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchOtelEnrichment.ICloudwatchOtelEnrichmentIncludeFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "includeFilterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchOtelEnrichment.CloudwatchOtelEnrichmentIncludeFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IncludeFilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.CloudwatchOtelEnrichment.ICloudwatchOtelEnrichmentTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.cloudwatchOtelEnrichment.CloudwatchOtelEnrichmentTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
