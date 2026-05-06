using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciAdmRemediationRecipes
{
    [JsiiClass(nativeType: typeof(oci.DataOciAdmRemediationRecipes.DataOciAdmRemediationRecipesRemediationRecipeCollectionItemsScmConfigurationOutputReference), fullyQualifiedName: "oci.dataOciAdmRemediationRecipes.DataOciAdmRemediationRecipesRemediationRecipeCollectionItemsScmConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciAdmRemediationRecipesRemediationRecipeCollectionItemsScmConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciAdmRemediationRecipesRemediationRecipeCollectionItemsScmConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciAdmRemediationRecipesRemediationRecipeCollectionItemsScmConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAdmRemediationRecipesRemediationRecipeCollectionItemsScmConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Branch
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "buildFileLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildFileLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalScmType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalScmType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAutomergeEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutomergeEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ociCodeRepositoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciCodeRepositoryId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scmType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScmType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Username
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciAdmRemediationRecipes.DataOciAdmRemediationRecipesRemediationRecipeCollectionItemsScmConfiguration\"}", isOptional: true)]
        public virtual oci.DataOciAdmRemediationRecipes.IDataOciAdmRemediationRecipesRemediationRecipeCollectionItemsScmConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciAdmRemediationRecipes.IDataOciAdmRemediationRecipesRemediationRecipeCollectionItemsScmConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
