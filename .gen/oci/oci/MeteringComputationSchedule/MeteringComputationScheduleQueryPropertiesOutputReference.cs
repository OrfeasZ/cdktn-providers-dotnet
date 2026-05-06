using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationSchedule
{
    [JsiiClass(nativeType: typeof(oci.MeteringComputationSchedule.MeteringComputationScheduleQueryPropertiesOutputReference), fullyQualifiedName: "oci.meteringComputationSchedule.MeteringComputationScheduleQueryPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MeteringComputationScheduleQueryPropertiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MeteringComputationScheduleQueryPropertiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MeteringComputationScheduleQueryPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MeteringComputationScheduleQueryPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDateRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.meteringComputationSchedule.MeteringComputationScheduleQueryPropertiesDateRange\"}}]")]
        public virtual void PutDateRange(oci.MeteringComputationSchedule.IMeteringComputationScheduleQueryPropertiesDateRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.MeteringComputationSchedule.IMeteringComputationScheduleQueryPropertiesDateRange)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGroupByTag", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.meteringComputationSchedule.MeteringComputationScheduleQueryPropertiesGroupByTag\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGroupByTag(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.MeteringComputationSchedule.IMeteringComputationScheduleQueryPropertiesGroupByTag[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MeteringComputationSchedule.IMeteringComputationScheduleQueryPropertiesGroupByTag).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MeteringComputationSchedule.IMeteringComputationScheduleQueryPropertiesGroupByTag).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCompartmentDepth")]
        public virtual void ResetCompartmentDepth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
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

        [JsiiMethod(name: "resetIsAggregateByTime")]
        public virtual void ResetIsAggregateByTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryType")]
        public virtual void ResetQueryType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dateRange", typeJson: "{\"fqn\":\"oci.meteringComputationSchedule.MeteringComputationScheduleQueryPropertiesDateRangeOutputReference\"}")]
        public virtual oci.MeteringComputationSchedule.MeteringComputationScheduleQueryPropertiesDateRangeOutputReference DateRange
        {
            get => GetInstanceProperty<oci.MeteringComputationSchedule.MeteringComputationScheduleQueryPropertiesDateRangeOutputReference>()!;
        }

        [JsiiProperty(name: "groupByTag", typeJson: "{\"fqn\":\"oci.meteringComputationSchedule.MeteringComputationScheduleQueryPropertiesGroupByTagList\"}")]
        public virtual oci.MeteringComputationSchedule.MeteringComputationScheduleQueryPropertiesGroupByTagList GroupByTag
        {
            get => GetInstanceProperty<oci.MeteringComputationSchedule.MeteringComputationScheduleQueryPropertiesGroupByTagList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentDepthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CompartmentDepthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dateRangeInput", typeJson: "{\"fqn\":\"oci.meteringComputationSchedule.MeteringComputationScheduleQueryPropertiesDateRange\"}", isOptional: true)]
        public virtual oci.MeteringComputationSchedule.IMeteringComputationScheduleQueryPropertiesDateRange? DateRangeInput
        {
            get => GetInstanceProperty<oci.MeteringComputationSchedule.IMeteringComputationScheduleQueryPropertiesDateRange?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FilterInput
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
        [JsiiProperty(name: "groupByTagInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.meteringComputationSchedule.MeteringComputationScheduleQueryPropertiesGroupByTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GroupByTagInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isAggregateByTimeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsAggregateByTimeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueryTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "compartmentDepth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CompartmentDepth
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Filter
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

        [JsiiProperty(name: "queryType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueryType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.meteringComputationSchedule.MeteringComputationScheduleQueryProperties\"}", isOptional: true)]
        public virtual oci.MeteringComputationSchedule.IMeteringComputationScheduleQueryProperties? InternalValue
        {
            get => GetInstanceProperty<oci.MeteringComputationSchedule.IMeteringComputationScheduleQueryProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
