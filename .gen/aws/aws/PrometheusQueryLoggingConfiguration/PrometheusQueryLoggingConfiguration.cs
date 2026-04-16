using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusQueryLoggingConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/prometheus_query_logging_configuration aws_prometheus_query_logging_configuration}.</summary>
    [JsiiClass(nativeType: typeof(aws.PrometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfiguration), fullyQualifiedName: "aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationConfig\"}}]")]
    public class PrometheusQueryLoggingConfiguration : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/prometheus_query_logging_configuration aws_prometheus_query_logging_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public PrometheusQueryLoggingConfiguration(Constructs.Construct scope, string id, aws.PrometheusQueryLoggingConfiguration.IPrometheusQueryLoggingConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.PrometheusQueryLoggingConfiguration.IPrometheusQueryLoggingConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PrometheusQueryLoggingConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PrometheusQueryLoggingConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a PrometheusQueryLoggingConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the PrometheusQueryLoggingConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing PrometheusQueryLoggingConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the PrometheusQueryLoggingConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the PrometheusQueryLoggingConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/prometheus_query_logging_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing PrometheusQueryLoggingConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the PrometheusQueryLoggingConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.PrometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationDestination\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDestination(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.PrometheusQueryLoggingConfiguration.IPrometheusQueryLoggingConfigurationDestination[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.PrometheusQueryLoggingConfiguration.IPrometheusQueryLoggingConfigurationDestination).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.PrometheusQueryLoggingConfiguration.IPrometheusQueryLoggingConfigurationDestination).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.PrometheusQueryLoggingConfiguration.IPrometheusQueryLoggingConfigurationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PrometheusQueryLoggingConfiguration.IPrometheusQueryLoggingConfigurationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDestination")]
        public virtual void ResetDestination()
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
        = GetStaticProperty<string>(typeof(aws.PrometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfiguration))!;

        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationDestinationList\"}")]
        public virtual aws.PrometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationDestinationList Destination
        {
            get => GetInstanceProperty<aws.PrometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationDestinationList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationTimeoutsOutputReference\"}")]
        public virtual aws.PrometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.PrometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DestinationInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workspaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkspaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
