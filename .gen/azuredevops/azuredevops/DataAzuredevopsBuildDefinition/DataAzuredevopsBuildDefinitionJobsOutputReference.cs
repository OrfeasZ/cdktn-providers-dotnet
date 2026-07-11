using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsBuildDefinition
{
    [JsiiClass(nativeType: typeof(azuredevops.DataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionJobsOutputReference), fullyQualifiedName: "azuredevops.dataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionJobsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzuredevopsBuildDefinitionJobsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzuredevopsBuildDefinitionJobsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzuredevopsBuildDefinitionJobsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzuredevopsBuildDefinitionJobsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowScriptsAuthAccessOption", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AllowScriptsAuthAccessOption
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Condition
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dependencies", typeJson: "{\"fqn\":\"azuredevops.dataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionJobsDependenciesList\"}")]
        public virtual azuredevops.DataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionJobsDependenciesList Dependencies
        {
            get => GetInstanceProperty<azuredevops.DataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionJobsDependenciesList>()!;
        }

        [JsiiProperty(name: "jobAuthorizationScope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobAuthorizationScope
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobCancelTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double JobCancelTimeoutInMinutes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "jobTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double JobTimeoutInMinutes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"azuredevops.dataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionJobsTargetList\"}")]
        public virtual azuredevops.DataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionJobsTargetList Target
        {
            get => GetInstanceProperty<azuredevops.DataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionJobsTargetList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuredevops.dataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionJobs\"}", isOptional: true)]
        public virtual azuredevops.DataAzuredevopsBuildDefinition.IDataAzuredevopsBuildDefinitionJobs? InternalValue
        {
            get => GetInstanceProperty<azuredevops.DataAzuredevopsBuildDefinition.IDataAzuredevopsBuildDefinitionJobs?>();
            set => SetInstanceProperty(value);
        }
    }
}
