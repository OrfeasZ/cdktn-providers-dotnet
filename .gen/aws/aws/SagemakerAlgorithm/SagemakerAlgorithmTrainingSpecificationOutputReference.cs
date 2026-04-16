using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiClass(nativeType: typeof(aws.SagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationOutputReference), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerAlgorithmTrainingSpecificationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public SagemakerAlgorithmTrainingSpecificationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerAlgorithmTrainingSpecificationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerAlgorithmTrainingSpecificationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdditionalS3DataSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationAdditionalS3DataSource\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAdditionalS3DataSource(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationAdditionalS3DataSource[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationAdditionalS3DataSource).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationAdditionalS3DataSource).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMetricDefinitions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationMetricDefinitions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMetricDefinitions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationMetricDefinitions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationMetricDefinitions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationMetricDefinitions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSupportedHyperParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationSupportedHyperParameters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSupportedHyperParameters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationSupportedHyperParameters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationSupportedHyperParameters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationSupportedHyperParameters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSupportedTuningJobObjectiveMetrics", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationSupportedTuningJobObjectiveMetrics\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSupportedTuningJobObjectiveMetrics(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationSupportedTuningJobObjectiveMetrics[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationSupportedTuningJobObjectiveMetrics).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationSupportedTuningJobObjectiveMetrics).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrainingChannels", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationTrainingChannels\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTrainingChannels(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationTrainingChannels[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationTrainingChannels).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationTrainingChannels).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalS3DataSource")]
        public virtual void ResetAdditionalS3DataSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetricDefinitions")]
        public virtual void ResetMetricDefinitions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSupportedHyperParameters")]
        public virtual void ResetSupportedHyperParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSupportedTuningJobObjectiveMetrics")]
        public virtual void ResetSupportedTuningJobObjectiveMetrics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSupportsDistributedTraining")]
        public virtual void ResetSupportsDistributedTraining()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrainingChannels")]
        public virtual void ResetTrainingChannels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrainingImageDigest")]
        public virtual void ResetTrainingImageDigest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "additionalS3DataSource", typeJson: "{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationAdditionalS3DataSourceList\"}")]
        public virtual aws.SagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationAdditionalS3DataSourceList AdditionalS3DataSource
        {
            get => GetInstanceProperty<aws.SagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationAdditionalS3DataSourceList>()!;
        }

        [JsiiProperty(name: "metricDefinitions", typeJson: "{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationMetricDefinitionsList\"}")]
        public virtual aws.SagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationMetricDefinitionsList MetricDefinitions
        {
            get => GetInstanceProperty<aws.SagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationMetricDefinitionsList>()!;
        }

        [JsiiProperty(name: "supportedHyperParameters", typeJson: "{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationSupportedHyperParametersList\"}")]
        public virtual aws.SagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationSupportedHyperParametersList SupportedHyperParameters
        {
            get => GetInstanceProperty<aws.SagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationSupportedHyperParametersList>()!;
        }

        [JsiiProperty(name: "supportedTuningJobObjectiveMetrics", typeJson: "{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationSupportedTuningJobObjectiveMetricsList\"}")]
        public virtual aws.SagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationSupportedTuningJobObjectiveMetricsList SupportedTuningJobObjectiveMetrics
        {
            get => GetInstanceProperty<aws.SagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationSupportedTuningJobObjectiveMetricsList>()!;
        }

        [JsiiProperty(name: "trainingChannels", typeJson: "{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationTrainingChannelsList\"}")]
        public virtual aws.SagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationTrainingChannelsList TrainingChannels
        {
            get => GetInstanceProperty<aws.SagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationTrainingChannelsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalS3DataSourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationAdditionalS3DataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AdditionalS3DataSourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricDefinitionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationMetricDefinitions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MetricDefinitionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "supportedHyperParametersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationSupportedHyperParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SupportedHyperParametersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "supportedTrainingInstanceTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SupportedTrainingInstanceTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "supportedTuningJobObjectiveMetricsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationSupportedTuningJobObjectiveMetrics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SupportedTuningJobObjectiveMetricsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "supportsDistributedTrainingInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SupportsDistributedTrainingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trainingChannelsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationTrainingChannels\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TrainingChannelsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trainingImageDigestInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrainingImageDigestInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trainingImageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrainingImageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "supportedTrainingInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportedTrainingInstanceTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "supportsDistributedTraining", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object SupportsDistributedTraining
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

        [JsiiProperty(name: "trainingImage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrainingImage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trainingImageDigest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrainingImageDigest
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecification\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecification cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecification).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
