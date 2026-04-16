using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppautoscalingPolicy
{
    [JsiiClass(nativeType: typeof(aws.AppautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationOutputReference), fullyQualifiedName: "aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomizedCapacityMetricSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification\"}}]")]
        public virtual void PutCustomizedCapacityMetricSpecification(aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomizedLoadMetricSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification\"}}]")]
        public virtual void PutCustomizedLoadMetricSpecification(aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomizedScalingMetricSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification\"}}]")]
        public virtual void PutCustomizedScalingMetricSpecification(aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPredefinedLoadMetricSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification\"}}]")]
        public virtual void PutPredefinedLoadMetricSpecification(aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPredefinedMetricPairSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification\"}}]")]
        public virtual void PutPredefinedMetricPairSpecification(aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPredefinedScalingMetricSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification\"}}]")]
        public virtual void PutPredefinedScalingMetricSpecification(aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomizedCapacityMetricSpecification")]
        public virtual void ResetCustomizedCapacityMetricSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomizedLoadMetricSpecification")]
        public virtual void ResetCustomizedLoadMetricSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomizedScalingMetricSpecification")]
        public virtual void ResetCustomizedScalingMetricSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPredefinedLoadMetricSpecification")]
        public virtual void ResetPredefinedLoadMetricSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPredefinedMetricPairSpecification")]
        public virtual void ResetPredefinedMetricPairSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPredefinedScalingMetricSpecification")]
        public virtual void ResetPredefinedScalingMetricSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customizedCapacityMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationOutputReference\"}")]
        public virtual aws.AppautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationOutputReference CustomizedCapacityMetricSpecification
        {
            get => GetInstanceProperty<aws.AppautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationOutputReference>()!;
        }

        [JsiiProperty(name: "customizedLoadMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationOutputReference\"}")]
        public virtual aws.AppautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationOutputReference CustomizedLoadMetricSpecification
        {
            get => GetInstanceProperty<aws.AppautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationOutputReference>()!;
        }

        [JsiiProperty(name: "customizedScalingMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationOutputReference\"}")]
        public virtual aws.AppautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationOutputReference CustomizedScalingMetricSpecification
        {
            get => GetInstanceProperty<aws.AppautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationOutputReference>()!;
        }

        [JsiiProperty(name: "predefinedLoadMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecificationOutputReference\"}")]
        public virtual aws.AppautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecificationOutputReference PredefinedLoadMetricSpecification
        {
            get => GetInstanceProperty<aws.AppautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecificationOutputReference>()!;
        }

        [JsiiProperty(name: "predefinedMetricPairSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecificationOutputReference\"}")]
        public virtual aws.AppautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecificationOutputReference PredefinedMetricPairSpecification
        {
            get => GetInstanceProperty<aws.AppautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecificationOutputReference>()!;
        }

        [JsiiProperty(name: "predefinedScalingMetricSpecification", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecificationOutputReference\"}")]
        public virtual aws.AppautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecificationOutputReference PredefinedScalingMetricSpecification
        {
            get => GetInstanceProperty<aws.AppautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecificationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customizedCapacityMetricSpecificationInput", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification\"}", isOptional: true)]
        public virtual aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification? CustomizedCapacityMetricSpecificationInput
        {
            get => GetInstanceProperty<aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customizedLoadMetricSpecificationInput", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification\"}", isOptional: true)]
        public virtual aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecificationInput
        {
            get => GetInstanceProperty<aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customizedScalingMetricSpecificationInput", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification\"}", isOptional: true)]
        public virtual aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecificationInput
        {
            get => GetInstanceProperty<aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "predefinedLoadMetricSpecificationInput", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification\"}", isOptional: true)]
        public virtual aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecificationInput
        {
            get => GetInstanceProperty<aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "predefinedMetricPairSpecificationInput", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification\"}", isOptional: true)]
        public virtual aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecificationInput
        {
            get => GetInstanceProperty<aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "predefinedScalingMetricSpecificationInput", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification\"}", isOptional: true)]
        public virtual aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecificationInput
        {
            get => GetInstanceProperty<aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecification\"}]}}", isOptional: true)]
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
                        case aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecification cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfigurationMetricSpecification).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
