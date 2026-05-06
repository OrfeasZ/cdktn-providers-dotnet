using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePagesProjects
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultLatestDeploymentDeploymentTriggerMetadataOutputReference), fullyQualifiedName: "cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultLatestDeploymentDeploymentTriggerMetadataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflarePagesProjectsResultLatestDeploymentDeploymentTriggerMetadataOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflarePagesProjectsResultLatestDeploymentDeploymentTriggerMetadataOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflarePagesProjectsResultLatestDeploymentDeploymentTriggerMetadataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePagesProjectsResultLatestDeploymentDeploymentTriggerMetadataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Branch
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "commitDirty", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CommitDirty
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "commitHash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CommitHash
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "commitMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CommitMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultLatestDeploymentDeploymentTriggerMetadata\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflarePagesProjects.IDataCloudflarePagesProjectsResultLatestDeploymentDeploymentTriggerMetadata? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProjects.IDataCloudflarePagesProjectsResultLatestDeploymentDeploymentTriggerMetadata?>();
            set => SetInstanceProperty(value);
        }
    }
}
