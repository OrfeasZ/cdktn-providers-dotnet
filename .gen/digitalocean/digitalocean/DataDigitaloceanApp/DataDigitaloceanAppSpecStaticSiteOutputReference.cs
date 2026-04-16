using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanApp
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanAppSpecStaticSiteOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanAppSpecStaticSiteOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanAppSpecStaticSiteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanAppSpecStaticSiteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteBitbucketList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteBitbucketList Bitbucket
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteBitbucketList>()!;
        }

        [JsiiProperty(name: "buildCommand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildCommand
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "catchallDocument", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CatchallDocument
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteCorsList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteCorsList Cors
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteCorsList>()!;
        }

        [JsiiProperty(name: "dockerfilePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DockerfilePath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteEnvList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteEnvList Env
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteEnvList>()!;
        }

        [JsiiProperty(name: "environmentSlug", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnvironmentSlug
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorDocument", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorDocument
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "git", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteGitList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteGitList Git
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteGitList>()!;
        }

        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteGithubList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteGithubList Github
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteGithubList>()!;
        }

        [JsiiProperty(name: "gitlab", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteGitlabList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteGitlabList Gitlab
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteGitlabList>()!;
        }

        [JsiiProperty(name: "indexDocument", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IndexDocument
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outputDir", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputDir
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routes", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteRoutesList\"}")]
        public virtual digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteRoutesList Routes
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.DataDigitaloceanAppSpecStaticSiteRoutesList>()!;
        }

        [JsiiProperty(name: "sourceDir", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDir
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanApp.DataDigitaloceanAppSpecStaticSite\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanApp.IDataDigitaloceanAppSpecStaticSite? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanApp.IDataDigitaloceanAppSpecStaticSite?>();
            set => SetInstanceProperty(value);
        }
    }
}
