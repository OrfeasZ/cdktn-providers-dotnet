using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDevopsDeployArtifact
{
    [JsiiClass(nativeType: typeof(oci.DataOciDevopsDeployArtifact.DataOciDevopsDeployArtifactDeployArtifactSourceOutputReference), fullyQualifiedName: "oci.dataOciDevopsDeployArtifact.DataOciDevopsDeployArtifactDeployArtifactSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDevopsDeployArtifactDeployArtifactSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDevopsDeployArtifactDeployArtifactSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDevopsDeployArtifactDeployArtifactSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDevopsDeployArtifactDeployArtifactSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "base64EncodedContent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Base64EncodedContent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "chartUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChartUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deployArtifactPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployArtifactPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deployArtifactSourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployArtifactSourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deployArtifactVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployArtifactVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "helmArtifactSourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HelmArtifactSourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "helmVerificationKeySource", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployArtifact.DataOciDevopsDeployArtifactDeployArtifactSourceHelmVerificationKeySourceList\"}")]
        public virtual oci.DataOciDevopsDeployArtifact.DataOciDevopsDeployArtifactDeployArtifactSourceHelmVerificationKeySourceList HelmVerificationKeySource
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployArtifact.DataOciDevopsDeployArtifactDeployArtifactSourceHelmVerificationKeySourceList>()!;
        }

        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageDigest
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployArtifact.DataOciDevopsDeployArtifactDeployArtifactSource\"}", isOptional: true)]
        public virtual oci.DataOciDevopsDeployArtifact.IDataOciDevopsDeployArtifactDeployArtifactSource? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployArtifact.IDataOciDevopsDeployArtifactDeployArtifactSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
