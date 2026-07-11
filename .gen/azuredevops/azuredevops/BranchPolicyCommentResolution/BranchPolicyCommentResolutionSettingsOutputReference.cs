using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyCommentResolution
{
    [JsiiClass(nativeType: typeof(azuredevops.BranchPolicyCommentResolution.BranchPolicyCommentResolutionSettingsOutputReference), fullyQualifiedName: "azuredevops.branchPolicyCommentResolution.BranchPolicyCommentResolutionSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BranchPolicyCommentResolutionSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BranchPolicyCommentResolutionSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BranchPolicyCommentResolutionSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BranchPolicyCommentResolutionSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BranchPolicyCommentResolution.IBranchPolicyCommentResolutionSettingsScope" />)[]</param>
        [JsiiMethod(name: "putScope", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyCommentResolution.BranchPolicyCommentResolutionSettingsScope\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutScope(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azuredevops.BranchPolicyCommentResolution.IBranchPolicyCommentResolutionSettingsScope[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuredevops.BranchPolicyCommentResolution.IBranchPolicyCommentResolutionSettingsScope).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuredevops.BranchPolicyCommentResolution.IBranchPolicyCommentResolutionSettingsScope).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "scope", typeJson: "{\"fqn\":\"azuredevops.branchPolicyCommentResolution.BranchPolicyCommentResolutionSettingsScopeList\"}")]
        public virtual azuredevops.BranchPolicyCommentResolution.BranchPolicyCommentResolutionSettingsScopeList Scope
        {
            get => GetInstanceProperty<azuredevops.BranchPolicyCommentResolution.BranchPolicyCommentResolutionSettingsScopeList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BranchPolicyCommentResolution.IBranchPolicyCommentResolutionSettingsScope" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scopeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyCommentResolution.BranchPolicyCommentResolutionSettingsScope\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ScopeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuredevops.branchPolicyCommentResolution.BranchPolicyCommentResolutionSettings\"}", isOptional: true)]
        public virtual azuredevops.BranchPolicyCommentResolution.IBranchPolicyCommentResolutionSettings? InternalValue
        {
            get => GetInstanceProperty<azuredevops.BranchPolicyCommentResolution.IBranchPolicyCommentResolutionSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
