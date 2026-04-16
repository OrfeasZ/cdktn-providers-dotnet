using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiClass(nativeType: typeof(aws.SagemakerLabelingJob.SagemakerLabelingJobLabelingJobAlgorithmsConfigOutputReference), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobLabelingJobAlgorithmsConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerLabelingJobLabelingJobAlgorithmsConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public SagemakerLabelingJobLabelingJobAlgorithmsConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected SagemakerLabelingJobLabelingJobAlgorithmsConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerLabelingJobLabelingJobAlgorithmsConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLabelingJobResourceConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLabelingJobResourceConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerLabelingJob.ISagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerLabelingJob.ISagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerLabelingJob.ISagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInitialActiveLearningModelArn")]
        public virtual void ResetInitialActiveLearningModelArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLabelingJobResourceConfig")]
        public virtual void ResetLabelingJobResourceConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "labelingJobResourceConfig", typeJson: "{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfigList\"}")]
        public virtual aws.SagemakerLabelingJob.SagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfigList LabelingJobResourceConfig
        {
            get => GetInstanceProperty<aws.SagemakerLabelingJob.SagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfigList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialActiveLearningModelArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InitialActiveLearningModelArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelingJobAlgorithmSpecificationArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LabelingJobAlgorithmSpecificationArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelingJobResourceConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LabelingJobResourceConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "initialActiveLearningModelArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InitialActiveLearningModelArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "labelingJobAlgorithmSpecificationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LabelingJobAlgorithmSpecificationArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobLabelingJobAlgorithmsConfig\"}]}}", isOptional: true)]
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
                        case aws.SagemakerLabelingJob.ISagemakerLabelingJobLabelingJobAlgorithmsConfig cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerLabelingJob.ISagemakerLabelingJobLabelingJobAlgorithmsConfig).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
