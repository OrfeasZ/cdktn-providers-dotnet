using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    [JsiiClass(nativeType: typeof(azuread.ConditionalAccessPolicy.ConditionalAccessPolicyConditionsApplicationsOutputReference), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsApplicationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ConditionalAccessPolicyConditionsApplicationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ConditionalAccessPolicyConditionsApplicationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ConditionalAccessPolicyConditionsApplicationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConditionalAccessPolicyConditionsApplicationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsApplicationsFilter\"}}]")]
        public virtual void PutFilter(azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplicationsFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplicationsFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExcludedApplications")]
        public virtual void ResetExcludedApplications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludedApplications")]
        public virtual void ResetIncludedApplications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludedUserActions")]
        public virtual void ResetIncludedUserActions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsApplicationsFilterOutputReference\"}")]
        public virtual azuread.ConditionalAccessPolicy.ConditionalAccessPolicyConditionsApplicationsFilterOutputReference Filter
        {
            get => GetInstanceProperty<azuread.ConditionalAccessPolicy.ConditionalAccessPolicyConditionsApplicationsFilterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludedApplicationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ExcludedApplicationsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsApplicationsFilter\"}", isOptional: true)]
        public virtual azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplicationsFilter? FilterInput
        {
            get => GetInstanceProperty<azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplicationsFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includedApplicationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IncludedApplicationsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includedUserActionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IncludedUserActionsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "excludedApplications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExcludedApplications
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "includedApplications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IncludedApplications
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "includedUserActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IncludedUserActions
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsApplications\"}", isOptional: true)]
        public virtual azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplications? InternalValue
        {
            get => GetInstanceProperty<azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplications?>();
            set => SetInstanceProperty(value);
        }
    }
}
