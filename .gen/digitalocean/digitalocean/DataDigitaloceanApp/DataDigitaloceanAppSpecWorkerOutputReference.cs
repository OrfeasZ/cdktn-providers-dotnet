using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanApp
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecWorkerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanAppSpecWorkerOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanAppSpecWorkerOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanAppSpecWorkerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanAppSpecWorkerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "alert", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecWorkerAlertList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerAlertList Alert
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerAlertList>()!;
        }

        [JsiiProperty(name: "autoscaling", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecWorkerAutoscalingList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerAutoscalingList Autoscaling
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerAutoscalingList>()!;
        }

        [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecWorkerBitbucketList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerBitbucketList Bitbucket
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerBitbucketList>()!;
        }

        [JsiiProperty(name: "buildCommand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildCommand
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dockerfilePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DockerfilePath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecWorkerEnvList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerEnvList Env
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerEnvList>()!;
        }

        [JsiiProperty(name: "environmentSlug", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnvironmentSlug
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "git", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecWorkerGitList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerGitList Git
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerGitList>()!;
        }

        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecWorkerGithubList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerGithubList Github
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerGithubList>()!;
        }

        [JsiiProperty(name: "gitlab", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecWorkerGitlabList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerGitlabList Gitlab
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerGitlabList>()!;
        }

        [JsiiProperty(name: "image", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecWorkerImageList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerImageList Image
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerImageList>()!;
        }

        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "instanceSizeSlug", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceSizeSlug
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logDestination", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecWorkerLogDestinationList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerLogDestinationList LogDestination
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerLogDestinationList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runCommand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RunCommand
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceDir", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDir
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "termination", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecWorkerTerminationList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerTerminationList Termination
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecWorkerTerminationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecWorker\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanApp.IDataDigitaloceanAppSpecWorker? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.IDataDigitaloceanAppSpecWorker?>();
            set => SetInstanceProperty(value);
        }
    }
}
