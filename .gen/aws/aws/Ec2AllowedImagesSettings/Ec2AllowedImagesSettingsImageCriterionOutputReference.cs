using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2AllowedImagesSettings
{
    [JsiiClass(nativeType: typeof(aws.Ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionOutputReference), fullyQualifiedName: "aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Ec2AllowedImagesSettingsImageCriterionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public Ec2AllowedImagesSettingsImageCriterionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected Ec2AllowedImagesSettingsImageCriterionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2AllowedImagesSettingsImageCriterionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCreationDateCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionCreationDateCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCreationDateCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Ec2AllowedImagesSettings.IEc2AllowedImagesSettingsImageCriterionCreationDateCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Ec2AllowedImagesSettings.IEc2AllowedImagesSettingsImageCriterionCreationDateCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Ec2AllowedImagesSettings.IEc2AllowedImagesSettingsImageCriterionCreationDateCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeprecationTimeCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionDeprecationTimeCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDeprecationTimeCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Ec2AllowedImagesSettings.IEc2AllowedImagesSettingsImageCriterionDeprecationTimeCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Ec2AllowedImagesSettings.IEc2AllowedImagesSettingsImageCriterionDeprecationTimeCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Ec2AllowedImagesSettings.IEc2AllowedImagesSettingsImageCriterionDeprecationTimeCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCreationDateCondition")]
        public virtual void ResetCreationDateCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeprecationTimeCondition")]
        public virtual void ResetDeprecationTimeCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageNames")]
        public virtual void ResetImageNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageProviders")]
        public virtual void ResetImageProviders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMarketplaceProductCodes")]
        public virtual void ResetMarketplaceProductCodes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "creationDateCondition", typeJson: "{\"fqn\":\"aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionCreationDateConditionList\"}")]
        public virtual aws.Ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionCreationDateConditionList CreationDateCondition
        {
            get => GetInstanceProperty<aws.Ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionCreationDateConditionList>()!;
        }

        [JsiiProperty(name: "deprecationTimeCondition", typeJson: "{\"fqn\":\"aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionDeprecationTimeConditionList\"}")]
        public virtual aws.Ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionDeprecationTimeConditionList DeprecationTimeCondition
        {
            get => GetInstanceProperty<aws.Ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionDeprecationTimeConditionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "creationDateConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionCreationDateCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CreationDateConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deprecationTimeConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterionDeprecationTimeCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DeprecationTimeConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ImageNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageProvidersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ImageProvidersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "marketplaceProductCodesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? MarketplaceProductCodesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "imageNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ImageNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageProviders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ImageProviders
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "marketplaceProductCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MarketplaceProductCodes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.ec2AllowedImagesSettings.Ec2AllowedImagesSettingsImageCriterion\"}]}}", isOptional: true)]
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
                        case aws.Ec2AllowedImagesSettings.IEc2AllowedImagesSettingsImageCriterion cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Ec2AllowedImagesSettings.IEc2AllowedImagesSettingsImageCriterion).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
