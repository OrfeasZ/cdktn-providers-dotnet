using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadApplication
{
    [JsiiClass(nativeType: typeof(azuread.DataAzureadApplication.DataAzureadApplicationWebOutputReference), fullyQualifiedName: "azuread.dataAzureadApplication.DataAzureadApplicationWebOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzureadApplicationWebOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzureadApplicationWebOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzureadApplicationWebOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzureadApplicationWebOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "homepageUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HomepageUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "implicitGrant", typeJson: "{\"fqn\":\"azuread.dataAzureadApplication.DataAzureadApplicationWebImplicitGrantList\"}")]
        public virtual azuread.DataAzureadApplication.DataAzureadApplicationWebImplicitGrantList ImplicitGrant
        {
            get => GetInstanceProperty<azuread.DataAzureadApplication.DataAzureadApplicationWebImplicitGrantList>()!;
        }

        [JsiiProperty(name: "logoutUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoutUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RedirectUris
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuread.dataAzureadApplication.DataAzureadApplicationWeb\"}", isOptional: true)]
        public virtual azuread.DataAzureadApplication.IDataAzureadApplicationWeb? InternalValue
        {
            get => GetInstanceProperty<azuread.DataAzureadApplication.IDataAzureadApplicationWeb?>();
            set => SetInstanceProperty(value);
        }
    }
}
