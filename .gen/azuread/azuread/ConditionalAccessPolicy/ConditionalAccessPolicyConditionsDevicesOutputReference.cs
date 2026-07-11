using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    [JsiiClass(nativeType: typeof(azuread.ConditionalAccessPolicy.ConditionalAccessPolicyConditionsDevicesOutputReference), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsDevicesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ConditionalAccessPolicyConditionsDevicesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ConditionalAccessPolicyConditionsDevicesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ConditionalAccessPolicyConditionsDevicesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConditionalAccessPolicyConditionsDevicesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsDevicesFilter\"}}]")]
        public virtual void PutFilter(azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsDevicesFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsDevicesFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsDevicesFilterOutputReference\"}")]
        public virtual azuread.ConditionalAccessPolicy.ConditionalAccessPolicyConditionsDevicesFilterOutputReference Filter
        {
            get => GetInstanceProperty<azuread.ConditionalAccessPolicy.ConditionalAccessPolicyConditionsDevicesFilterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsDevicesFilter\"}", isOptional: true)]
        public virtual azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsDevicesFilter? FilterInput
        {
            get => GetInstanceProperty<azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsDevicesFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsDevices\"}", isOptional: true)]
        public virtual azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsDevices? InternalValue
        {
            get => GetInstanceProperty<azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsDevices?>();
            set => SetInstanceProperty(value);
        }
    }
}
