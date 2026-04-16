using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiClass(nativeType: typeof(cloudflare.PagesProject.PagesProjectCanonicalDeploymentOutputReference), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectCanonicalDeploymentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PagesProjectCanonicalDeploymentOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PagesProjectCanonicalDeploymentOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PagesProjectCanonicalDeploymentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PagesProjectCanonicalDeploymentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "aliases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Aliases
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "buildConfig", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectCanonicalDeploymentBuildConfigOutputReference\"}")]
        public virtual cloudflare.PagesProject.PagesProjectCanonicalDeploymentBuildConfigOutputReference BuildConfig
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectCanonicalDeploymentBuildConfigOutputReference>()!;
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deploymentTrigger", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectCanonicalDeploymentDeploymentTriggerOutputReference\"}")]
        public virtual cloudflare.PagesProject.PagesProjectCanonicalDeploymentDeploymentTriggerOutputReference DeploymentTrigger
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectCanonicalDeploymentDeploymentTriggerOutputReference>()!;
        }

        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Environment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "envVars", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectCanonicalDeploymentEnvVarsMap\"}")]
        public virtual cloudflare.PagesProject.PagesProjectCanonicalDeploymentEnvVarsMap EnvVars
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectCanonicalDeploymentEnvVarsMap>()!;
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

        [JsiiProperty(name: "latestStage", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectCanonicalDeploymentLatestStageOutputReference\"}")]
        public virtual cloudflare.PagesProject.PagesProjectCanonicalDeploymentLatestStageOutputReference LatestStage
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectCanonicalDeploymentLatestStageOutputReference>()!;
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

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectCanonicalDeploymentSourceOutputReference\"}")]
        public virtual cloudflare.PagesProject.PagesProjectCanonicalDeploymentSourceOutputReference Source
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectCanonicalDeploymentSourceOutputReference>()!;
        }

        [JsiiProperty(name: "stages", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectCanonicalDeploymentStagesList\"}")]
        public virtual cloudflare.PagesProject.PagesProjectCanonicalDeploymentStagesList Stages
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectCanonicalDeploymentStagesList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectCanonicalDeployment\"}", isOptional: true)]
        public virtual cloudflare.PagesProject.IPagesProjectCanonicalDeployment? InternalValue
        {
            get => GetInstanceProperty<cloudflare.PagesProject.IPagesProjectCanonicalDeployment?>();
            set => SetInstanceProperty(value);
        }
    }
}
