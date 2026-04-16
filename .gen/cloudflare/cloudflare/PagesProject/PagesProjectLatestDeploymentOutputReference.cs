using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiClass(nativeType: typeof(cloudflare.PagesProject.PagesProjectLatestDeploymentOutputReference), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectLatestDeploymentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PagesProjectLatestDeploymentOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PagesProjectLatestDeploymentOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PagesProjectLatestDeploymentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PagesProjectLatestDeploymentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "aliases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Aliases
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "buildConfig", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectLatestDeploymentBuildConfigOutputReference\"}")]
        public virtual cloudflare.PagesProject.PagesProjectLatestDeploymentBuildConfigOutputReference BuildConfig
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectLatestDeploymentBuildConfigOutputReference>()!;
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deploymentTrigger", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectLatestDeploymentDeploymentTriggerOutputReference\"}")]
        public virtual cloudflare.PagesProject.PagesProjectLatestDeploymentDeploymentTriggerOutputReference DeploymentTrigger
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectLatestDeploymentDeploymentTriggerOutputReference>()!;
        }

        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Environment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "envVars", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectLatestDeploymentEnvVarsMap\"}")]
        public virtual cloudflare.PagesProject.PagesProjectLatestDeploymentEnvVarsMap EnvVars
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectLatestDeploymentEnvVarsMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isSkipped", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSkipped
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "latestStage", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectLatestDeploymentLatestStageOutputReference\"}")]
        public virtual cloudflare.PagesProject.PagesProjectLatestDeploymentLatestStageOutputReference LatestStage
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectLatestDeploymentLatestStageOutputReference>()!;
        }

        [JsiiProperty(name: "modifiedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "projectName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shortId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShortId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectLatestDeploymentSourceOutputReference\"}")]
        public virtual cloudflare.PagesProject.PagesProjectLatestDeploymentSourceOutputReference Source
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectLatestDeploymentSourceOutputReference>()!;
        }

        [JsiiProperty(name: "stages", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectLatestDeploymentStagesList\"}")]
        public virtual cloudflare.PagesProject.PagesProjectLatestDeploymentStagesList Stages
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectLatestDeploymentStagesList>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "usesFunctions", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UsesFunctions
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectLatestDeployment\"}", isOptional: true)]
        public virtual cloudflare.PagesProject.IPagesProjectLatestDeployment? InternalValue
        {
            get => GetInstanceProperty<cloudflare.PagesProject.IPagesProjectLatestDeployment?>();
            set => SetInstanceProperty(value);
        }
    }
}
