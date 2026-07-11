using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AccessPackageAssignmentPolicy
{
    [JsiiClass(nativeType: typeof(azuread.AccessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionOutputReference), fullyQualifiedName: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AccessPackageAssignmentPolicyQuestionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AccessPackageAssignmentPolicyQuestionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AccessPackageAssignmentPolicyQuestionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AccessPackageAssignmentPolicyQuestionOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoice" />)[]</param>
        [JsiiMethod(name: "putChoice", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoice\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutChoice(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoice[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoice).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoice).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putText", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionText\"}}]")]
        public virtual void PutText(azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionText @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionText)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetChoice")]
        public virtual void ResetChoice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequired")]
        public virtual void ResetRequired()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSequence")]
        public virtual void ResetSequence()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "choice", typeJson: "{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoiceList\"}")]
        public virtual azuread.AccessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoiceList Choice
        {
            get => GetInstanceProperty<azuread.AccessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoiceList>()!;
        }

        [JsiiProperty(name: "text", typeJson: "{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionTextOutputReference\"}")]
        public virtual azuread.AccessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionTextOutputReference Text
        {
            get => GetInstanceProperty<azuread.AccessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionTextOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoice" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "choiceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ChoiceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requiredInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RequiredInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sequenceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SequenceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "textInput", typeJson: "{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionText\"}", isOptional: true)]
        public virtual azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionText? TextInput
        {
            get => GetInstanceProperty<azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionText?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Required
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

        [JsiiProperty(name: "sequence", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Sequence
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestion" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestion\"}]}}", isOptional: true)]
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
                        case azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestion cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestion).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
