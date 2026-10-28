using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchResourceMetricsConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatch_resource_metrics_configuration aws_cloudwatch_resource_metrics_configuration}.</summary>
    [JsiiClass(nativeType: typeof(aws.CloudwatchResourceMetricsConfiguration.CloudwatchResourceMetricsConfiguration), fullyQualifiedName: "aws.cloudwatchResourceMetricsConfiguration.CloudwatchResourceMetricsConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudwatchResourceMetricsConfiguration.CloudwatchResourceMetricsConfigurationConfig\"}}]")]
    public class CloudwatchResourceMetricsConfiguration : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatch_resource_metrics_configuration aws_cloudwatch_resource_metrics_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudwatchResourceMetricsConfiguration(Constructs.Construct scope, string id, aws.CloudwatchResourceMetricsConfiguration.ICloudwatchResourceMetricsConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.CloudwatchResourceMetricsConfiguration.ICloudwatchResourceMetricsConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchResourceMetricsConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchResourceMetricsConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a CloudwatchResourceMetricsConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CloudwatchResourceMetricsConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing CloudwatchResourceMetricsConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CloudwatchResourceMetricsConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CloudwatchResourceMetricsConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatch_resource_metrics_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CloudwatchResourceMetricsConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CloudwatchResourceMetricsConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.CloudwatchResourceMetricsConfiguration.CloudwatchResourceMetricsConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchResourceMetricsConfiguration.ICloudwatchResourceMetricsConfigurationMetricSelection" />)[]</param>
        [JsiiMethod(name: "putMetricSelection", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchResourceMetricsConfiguration.CloudwatchResourceMetricsConfigurationMetricSelection\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMetricSelection(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudwatchResourceMetricsConfiguration.ICloudwatchResourceMetricsConfigurationMetricSelection[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchResourceMetricsConfiguration.ICloudwatchResourceMetricsConfigurationMetricSelection).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchResourceMetricsConfiguration.ICloudwatchResourceMetricsConfigurationMetricSelection).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMetricSelection")]
        public virtual void ResetMetricSelection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
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
        = GetStaticProperty<string>(typeof(aws.CloudwatchResourceMetricsConfiguration.CloudwatchResourceMetricsConfiguration))!;

        [JsiiProperty(name: "metricSelection", typeJson: "{\"fqn\":\"aws.cloudwatchResourceMetricsConfiguration.CloudwatchResourceMetricsConfigurationMetricSelectionList\"}")]
        public virtual aws.CloudwatchResourceMetricsConfiguration.CloudwatchResourceMetricsConfigurationMetricSelectionList MetricSelection
        {
            get => GetInstanceProperty<aws.CloudwatchResourceMetricsConfiguration.CloudwatchResourceMetricsConfigurationMetricSelectionList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchResourceMetricsConfiguration.ICloudwatchResourceMetricsConfigurationMetricSelection" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metricSelectionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchResourceMetricsConfiguration.CloudwatchResourceMetricsConfigurationMetricSelection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MetricSelectionInput
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
        [JsiiProperty(name: "resourceArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
