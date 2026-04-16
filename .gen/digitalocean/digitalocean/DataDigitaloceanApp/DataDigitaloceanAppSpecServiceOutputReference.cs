using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanApp
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecServiceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanAppSpecServiceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanAppSpecServiceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanAppSpecServiceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanAppSpecServiceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "alert", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecServiceAlertList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceAlertList Alert
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceAlertList>()!;
        }

        [JsiiProperty(name: "autoscaling", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecServiceAutoscalingList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceAutoscalingList Autoscaling
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceAutoscalingList>()!;
        }

        [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecServiceBitbucketList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceBitbucketList Bitbucket
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceBitbucketList>()!;
        }

        [JsiiProperty(name: "buildCommand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildCommand
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecServiceCorsList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceCorsList Cors
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceCorsList>()!;
        }

        [JsiiProperty(name: "dockerfilePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DockerfilePath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecServiceEnvList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceEnvList Env
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceEnvList>()!;
        }

        [JsiiProperty(name: "environmentSlug", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnvironmentSlug
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "git", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecServiceGitList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceGitList Git
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceGitList>()!;
        }

        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecServiceGithubList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceGithubList Github
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceGithubList>()!;
        }

        [JsiiProperty(name: "gitlab", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecServiceGitlabList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceGitlabList Gitlab
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceGitlabList>()!;
        }

        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecServiceHealthCheckList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceHealthCheckList HealthCheck
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceHealthCheckList>()!;
        }

        [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "image", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecServiceImageList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceImageList Image
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceImageList>()!;
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

        [JsiiProperty(name: "internalPorts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] InternalPorts
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "logDestination", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecServiceLogDestinationList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceLogDestinationList LogDestination
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceLogDestinationList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routes", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecServiceRoutesList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceRoutesList Routes
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceRoutesList>()!;
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

        [JsiiProperty(name: "termination", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecServiceTerminationList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceTerminationList Termination
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecServiceTerminationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecService\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanApp.IDataDigitaloceanAppSpecService? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.IDataDigitaloceanAppSpecService?>();
            set => SetInstanceProperty(value);
        }
    }
}
