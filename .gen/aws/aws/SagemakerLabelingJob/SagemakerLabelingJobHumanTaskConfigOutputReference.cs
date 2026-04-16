using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiClass(nativeType: typeof(aws.SagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigOutputReference), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerLabelingJobHumanTaskConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public SagemakerLabelingJobHumanTaskConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected SagemakerLabelingJobHumanTaskConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerLabelingJobHumanTaskConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnnotationConsolidationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAnnotationConsolidationConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPublicWorkforceTaskPrice", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPrice\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPublicWorkforceTaskPrice(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPrice[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPrice).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPrice).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUiConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigUiConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUiConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigUiConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigUiConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigUiConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAnnotationConsolidationConfig")]
        public virtual void ResetAnnotationConsolidationConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxConcurrentTaskCount")]
        public virtual void ResetMaxConcurrentTaskCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreHumanTaskLambdaArn")]
        public virtual void ResetPreHumanTaskLambdaArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicWorkforceTaskPrice")]
        public virtual void ResetPublicWorkforceTaskPrice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskAvailabilityLifetimeInSeconds")]
        public virtual void ResetTaskAvailabilityLifetimeInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskKeywords")]
        public virtual void ResetTaskKeywords()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUiConfig")]
        public virtual void ResetUiConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "annotationConsolidationConfig", typeJson: "{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfigList\"}")]
        public virtual aws.SagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfigList AnnotationConsolidationConfig
        {
            get => GetInstanceProperty<aws.SagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfigList>()!;
        }

        [JsiiProperty(name: "publicWorkforceTaskPrice", typeJson: "{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPriceList\"}")]
        public virtual aws.SagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPriceList PublicWorkforceTaskPrice
        {
            get => GetInstanceProperty<aws.SagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPriceList>()!;
        }

        [JsiiProperty(name: "uiConfig", typeJson: "{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigUiConfigList\"}")]
        public virtual aws.SagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigUiConfigList UiConfig
        {
            get => GetInstanceProperty<aws.SagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigUiConfigList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "annotationConsolidationConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AnnotationConsolidationConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentTaskCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxConcurrentTaskCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberOfHumanWorkersPerDataObjectInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumberOfHumanWorkersPerDataObjectInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preHumanTaskLambdaArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreHumanTaskLambdaArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicWorkforceTaskPriceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPrice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PublicWorkforceTaskPriceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskAvailabilityLifetimeInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TaskAvailabilityLifetimeInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskDescriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaskDescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskKeywordsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TaskKeywordsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskTimeLimitInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TaskTimeLimitInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskTitleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaskTitleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uiConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigUiConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UiConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workteamArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkteamArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "maxConcurrentTaskCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxConcurrentTaskCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "numberOfHumanWorkersPerDataObject", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfHumanWorkersPerDataObject
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preHumanTaskLambdaArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreHumanTaskLambdaArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskAvailabilityLifetimeInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TaskAvailabilityLifetimeInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskDescription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskKeywords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TaskKeywords
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskTimeLimitInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TaskTimeLimitInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskTitle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskTitle
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workteamArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkteamArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfig\"}]}}", isOptional: true)]
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
                        case aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfig cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfig).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
