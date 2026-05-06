using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationUsageCarbonEmission
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_carbon_emission oci_metering_computation_usage_carbon_emission}.</summary>
    [JsiiClass(nativeType: typeof(oci.MeteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmission), fullyQualifiedName: "oci.meteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmission", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.meteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionConfig\"}}]")]
    public class MeteringComputationUsageCarbonEmission : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_carbon_emission oci_metering_computation_usage_carbon_emission} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MeteringComputationUsageCarbonEmission(Constructs.Construct scope, string id, oci.MeteringComputationUsageCarbonEmission.IMeteringComputationUsageCarbonEmissionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.MeteringComputationUsageCarbonEmission.IMeteringComputationUsageCarbonEmissionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MeteringComputationUsageCarbonEmission(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MeteringComputationUsageCarbonEmission(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a MeteringComputationUsageCarbonEmission resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MeteringComputationUsageCarbonEmission to import.</param>
        /// <param name="importFromId">The id of the existing MeteringComputationUsageCarbonEmission that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MeteringComputationUsageCarbonEmission to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MeteringComputationUsageCarbonEmission to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_carbon_emission#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MeteringComputationUsageCarbonEmission that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MeteringComputationUsageCarbonEmission to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.MeteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmission), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putGroupByTag", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.meteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionGroupByTag\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGroupByTag(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.MeteringComputationUsageCarbonEmission.IMeteringComputationUsageCarbonEmissionGroupByTag[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MeteringComputationUsageCarbonEmission.IMeteringComputationUsageCarbonEmissionGroupByTag).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MeteringComputationUsageCarbonEmission.IMeteringComputationUsageCarbonEmissionGroupByTag).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.meteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.MeteringComputationUsageCarbonEmission.IMeteringComputationUsageCarbonEmissionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.MeteringComputationUsageCarbonEmission.IMeteringComputationUsageCarbonEmissionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCompartmentDepth")]
        public virtual void ResetCompartmentDepth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmissionCalculationMethod")]
        public virtual void ResetEmissionCalculationMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmissionType")]
        public virtual void ResetEmissionType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGranularity")]
        public virtual void ResetGranularity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroupBy")]
        public virtual void ResetGroupBy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroupByTag")]
        public virtual void ResetGroupByTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsAggregateByTime")]
        public virtual void ResetIsAggregateByTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsageCarbonEmissionFilter")]
        public virtual void ResetUsageCarbonEmissionFilter()
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
        = GetStaticProperty<string>(typeof(oci.MeteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmission))!;

        [JsiiProperty(name: "groupByTag", typeJson: "{\"fqn\":\"oci.meteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionGroupByTagList\"}")]
        public virtual oci.MeteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionGroupByTagList GroupByTag
        {
            get => GetInstanceProperty<oci.MeteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionGroupByTagList>()!;
        }

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.meteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionItemsList\"}")]
        public virtual oci.MeteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionItemsList Items
        {
            get => GetInstanceProperty<oci.MeteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionItemsList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.meteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionTimeoutsOutputReference\"}")]
        public virtual oci.MeteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.MeteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentDepthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CompartmentDepthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emissionCalculationMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmissionCalculationMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emissionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmissionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "granularityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GranularityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupByInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? GroupByInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupByTagInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.meteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionGroupByTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GroupByTagInput
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
        [JsiiProperty(name: "isAggregateByTimeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsAggregateByTimeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tenantIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TenantIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.meteringComputationUsageCarbonEmission.MeteringComputationUsageCarbonEmissionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeUsageEndedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeUsageEndedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeUsageStartedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeUsageStartedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usageCarbonEmissionFilterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsageCarbonEmissionFilterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "compartmentDepth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CompartmentDepth
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emissionCalculationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmissionCalculationMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emissionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmissionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "granularity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Granularity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "groupBy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GroupBy
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isAggregateByTime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsAggregateByTime
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

        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenantId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeUsageEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUsageEnded
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeUsageStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUsageStarted
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "usageCarbonEmissionFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageCarbonEmissionFilter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
