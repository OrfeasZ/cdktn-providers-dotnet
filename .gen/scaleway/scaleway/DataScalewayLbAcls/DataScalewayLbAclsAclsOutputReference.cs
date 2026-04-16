using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayLbAcls
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayLbAcls.DataScalewayLbAclsAclsOutputReference), fullyQualifiedName: "scaleway.dataScalewayLbAcls.DataScalewayLbAclsAclsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataScalewayLbAclsAclsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataScalewayLbAclsAclsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataScalewayLbAclsAclsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayLbAclsAclsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"scaleway.dataScalewayLbAcls.DataScalewayLbAclsAclsActionList\"}")]
        public virtual scaleway.DataScalewayLbAcls.DataScalewayLbAclsAclsActionList Action
        {
            get => GetInstanceProperty<scaleway.DataScalewayLbAcls.DataScalewayLbAclsAclsActionList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "frontendId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FrontendId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Index
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"scaleway.dataScalewayLbAcls.DataScalewayLbAclsAclsMatchList\"}")]
        public virtual scaleway.DataScalewayLbAcls.DataScalewayLbAclsAclsMatchList Match
        {
            get => GetInstanceProperty<scaleway.DataScalewayLbAcls.DataScalewayLbAclsAclsMatchList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updateAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayLbAcls.DataScalewayLbAclsAcls\"}", isOptional: true)]
        public virtual scaleway.DataScalewayLbAcls.IDataScalewayLbAclsAcls? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayLbAcls.IDataScalewayLbAclsAcls?>();
            set => SetInstanceProperty(value);
        }
    }
}
