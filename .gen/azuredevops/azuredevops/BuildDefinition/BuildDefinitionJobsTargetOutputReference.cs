using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    [JsiiClass(nativeType: typeof(azuredevops.BuildDefinition.BuildDefinitionJobsTargetOutputReference), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionJobsTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BuildDefinitionJobsTargetOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BuildDefinitionJobsTargetOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BuildDefinitionJobsTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BuildDefinitionJobsTargetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExecutionOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionJobsTargetExecutionOptions\"}}]")]
        public virtual void PutExecutionOptions(azuredevops.BuildDefinition.IBuildDefinitionJobsTargetExecutionOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.BuildDefinition.IBuildDefinitionJobsTargetExecutionOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDemands")]
        public virtual void ResetDemands()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "executionOptions", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionJobsTargetExecutionOptionsOutputReference\"}")]
        public virtual azuredevops.BuildDefinition.BuildDefinitionJobsTargetExecutionOptionsOutputReference ExecutionOptions
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.BuildDefinitionJobsTargetExecutionOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "demandsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DemandsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionOptionsInput", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionJobsTargetExecutionOptions\"}", isOptional: true)]
        public virtual azuredevops.BuildDefinition.IBuildDefinitionJobsTargetExecutionOptions? ExecutionOptionsInput
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionJobsTargetExecutionOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "demands", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Demands
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionJobsTarget\"}", isOptional: true)]
        public virtual azuredevops.BuildDefinition.IBuildDefinitionJobsTarget? InternalValue
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionJobsTarget?>();
            set => SetInstanceProperty(value);
        }
    }
}
