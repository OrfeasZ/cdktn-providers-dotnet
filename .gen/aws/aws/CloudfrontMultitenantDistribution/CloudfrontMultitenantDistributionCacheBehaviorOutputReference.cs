using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiClass(nativeType: typeof(aws.CloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorOutputReference), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudfrontMultitenantDistributionCacheBehaviorOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CloudfrontMultitenantDistributionCacheBehaviorOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CloudfrontMultitenantDistributionCacheBehaviorOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontMultitenantDistributionCacheBehaviorOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAllowedMethods", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorAllowedMethods\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAllowedMethods(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorAllowedMethods[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorAllowedMethods).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorAllowedMethods).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFunctionAssociation", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorFunctionAssociation\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFunctionAssociation(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorFunctionAssociation[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorFunctionAssociation).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorFunctionAssociation).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLambdaFunctionAssociation", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorLambdaFunctionAssociation\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLambdaFunctionAssociation(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorLambdaFunctionAssociation[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorLambdaFunctionAssociation).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorLambdaFunctionAssociation).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrustedKeyGroups", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorTrustedKeyGroups\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTrustedKeyGroups(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorTrustedKeyGroups[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorTrustedKeyGroups).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorTrustedKeyGroups).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllowedMethods")]
        public virtual void ResetAllowedMethods()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCachePolicyId")]
        public virtual void ResetCachePolicyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompress")]
        public virtual void ResetCompress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFieldLevelEncryptionId")]
        public virtual void ResetFieldLevelEncryptionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFunctionAssociation")]
        public virtual void ResetFunctionAssociation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaFunctionAssociation")]
        public virtual void ResetLambdaFunctionAssociation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginRequestPolicyId")]
        public virtual void ResetOriginRequestPolicyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRealtimeLogConfigArn")]
        public virtual void ResetRealtimeLogConfigArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResponseHeadersPolicyId")]
        public virtual void ResetResponseHeadersPolicyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrustedKeyGroups")]
        public virtual void ResetTrustedKeyGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "allowedMethods", typeJson: "{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorAllowedMethodsList\"}")]
        public virtual aws.CloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorAllowedMethodsList AllowedMethods
        {
            get => GetInstanceProperty<aws.CloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorAllowedMethodsList>()!;
        }

        [JsiiProperty(name: "functionAssociation", typeJson: "{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorFunctionAssociationList\"}")]
        public virtual aws.CloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorFunctionAssociationList FunctionAssociation
        {
            get => GetInstanceProperty<aws.CloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorFunctionAssociationList>()!;
        }

        [JsiiProperty(name: "lambdaFunctionAssociation", typeJson: "{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorLambdaFunctionAssociationList\"}")]
        public virtual aws.CloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorLambdaFunctionAssociationList LambdaFunctionAssociation
        {
            get => GetInstanceProperty<aws.CloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorLambdaFunctionAssociationList>()!;
        }

        [JsiiProperty(name: "trustedKeyGroups", typeJson: "{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorTrustedKeyGroupsList\"}")]
        public virtual aws.CloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorTrustedKeyGroupsList TrustedKeyGroups
        {
            get => GetInstanceProperty<aws.CloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorTrustedKeyGroupsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedMethodsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorAllowedMethods\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AllowedMethodsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cachePolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CachePolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compressInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CompressInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldLevelEncryptionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FieldLevelEncryptionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionAssociationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorFunctionAssociation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FunctionAssociationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionAssociationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorLambdaFunctionAssociation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LambdaFunctionAssociationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originRequestPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OriginRequestPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathPatternInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PathPatternInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "realtimeLogConfigArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RealtimeLogConfigArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseHeadersPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResponseHeadersPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetOriginIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetOriginIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trustedKeyGroupsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorTrustedKeyGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TrustedKeyGroupsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "viewerProtocolPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ViewerProtocolPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cachePolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CachePolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Compress
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

        [JsiiProperty(name: "fieldLevelEncryptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FieldLevelEncryptionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originRequestPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginRequestPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pathPattern", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PathPattern
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "realtimeLogConfigArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RealtimeLogConfigArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "responseHeadersPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseHeadersPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetOriginId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetOriginId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "viewerProtocolPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViewerProtocolPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehavior\"}]}}", isOptional: true)]
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
                        case aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehavior cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehavior).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
