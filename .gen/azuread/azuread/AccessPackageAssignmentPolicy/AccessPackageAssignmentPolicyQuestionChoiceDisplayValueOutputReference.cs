using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AccessPackageAssignmentPolicy
{
    [JsiiClass(nativeType: typeof(azuread.AccessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoiceDisplayValueOutputReference), fullyQualifiedName: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoiceDisplayValueOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AccessPackageAssignmentPolicyQuestionChoiceDisplayValueOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AccessPackageAssignmentPolicyQuestionChoiceDisplayValueOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AccessPackageAssignmentPolicyQuestionChoiceDisplayValueOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AccessPackageAssignmentPolicyQuestionChoiceDisplayValueOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoiceDisplayValueLocalizedText" />)[]</param>
        [JsiiMethod(name: "putLocalizedText", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoiceDisplayValueLocalizedText\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLocalizedText(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoiceDisplayValueLocalizedText[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoiceDisplayValueLocalizedText).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoiceDisplayValueLocalizedText).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLocalizedText")]
        public virtual void ResetLocalizedText()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "localizedText", typeJson: "{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoiceDisplayValueLocalizedTextList\"}")]
        public virtual azuread.AccessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoiceDisplayValueLocalizedTextList LocalizedText
        {
            get => GetInstanceProperty<azuread.AccessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoiceDisplayValueLocalizedTextList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultTextInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultTextInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoiceDisplayValueLocalizedText" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "localizedTextInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoiceDisplayValueLocalizedText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LocalizedTextInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "defaultText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultText
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoiceDisplayValue\"}", isOptional: true)]
        public virtual azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoiceDisplayValue? InternalValue
        {
            get => GetInstanceProperty<azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoiceDisplayValue?>();
            set => SetInstanceProperty(value);
        }
    }
}
