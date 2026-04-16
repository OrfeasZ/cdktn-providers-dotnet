using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaCapacityProvider
{
    [JsiiClass(nativeType: typeof(aws.LambdaCapacityProvider.LambdaCapacityProviderCapacityProviderScalingConfigOutputReference), fullyQualifiedName: "aws.lambdaCapacityProvider.LambdaCapacityProviderCapacityProviderScalingConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LambdaCapacityProviderCapacityProviderScalingConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public LambdaCapacityProviderCapacityProviderScalingConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected LambdaCapacityProviderCapacityProviderScalingConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaCapacityProviderCapacityProviderScalingConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putScalingPolicies", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdaCapacityProvider.LambdaCapacityProviderCapacityProviderScalingConfigScalingPolicies\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutScalingPolicies(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.LambdaCapacityProvider.ILambdaCapacityProviderCapacityProviderScalingConfigScalingPolicies[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdaCapacityProvider.ILambdaCapacityProviderCapacityProviderScalingConfigScalingPolicies).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdaCapacityProvider.ILambdaCapacityProviderCapacityProviderScalingConfigScalingPolicies).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMaxVcpuCount")]
        public virtual void ResetMaxVcpuCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScalingMode")]
        public virtual void ResetScalingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScalingPolicies")]
        public virtual void ResetScalingPolicies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "scalingPolicies", typeJson: "{\"fqn\":\"aws.lambdaCapacityProvider.LambdaCapacityProviderCapacityProviderScalingConfigScalingPoliciesList\"}")]
        public virtual aws.LambdaCapacityProvider.LambdaCapacityProviderCapacityProviderScalingConfigScalingPoliciesList ScalingPolicies
        {
            get => GetInstanceProperty<aws.LambdaCapacityProvider.LambdaCapacityProviderCapacityProviderScalingConfigScalingPoliciesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxVcpuCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxVcpuCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scalingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScalingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scalingPoliciesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdaCapacityProvider.LambdaCapacityProviderCapacityProviderScalingConfigScalingPolicies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ScalingPoliciesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "maxVcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxVcpuCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scalingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScalingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.lambdaCapacityProvider.LambdaCapacityProviderCapacityProviderScalingConfig\"}]}}", isOptional: true)]
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
                        case aws.LambdaCapacityProvider.ILambdaCapacityProviderCapacityProviderScalingConfig cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdaCapacityProvider.ILambdaCapacityProviderCapacityProviderScalingConfig).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
