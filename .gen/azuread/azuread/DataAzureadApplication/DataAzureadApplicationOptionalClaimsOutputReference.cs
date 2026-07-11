using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadApplication
{
    [JsiiClass(nativeType: typeof(azuread.DataAzureadApplication.DataAzureadApplicationOptionalClaimsOutputReference), fullyQualifiedName: "azuread.dataAzureadApplication.DataAzureadApplicationOptionalClaimsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzureadApplicationOptionalClaimsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzureadApplicationOptionalClaimsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzureadApplicationOptionalClaimsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzureadApplicationOptionalClaimsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessToken", typeJson: "{\"fqn\":\"azuread.dataAzureadApplication.DataAzureadApplicationOptionalClaimsAccessTokenList\"}")]
        public virtual azuread.DataAzureadApplication.DataAzureadApplicationOptionalClaimsAccessTokenList AccessToken
        {
            get => GetInstanceProperty<azuread.DataAzureadApplication.DataAzureadApplicationOptionalClaimsAccessTokenList>()!;
        }

        [JsiiProperty(name: "idToken", typeJson: "{\"fqn\":\"azuread.dataAzureadApplication.DataAzureadApplicationOptionalClaimsIdTokenList\"}")]
        public virtual azuread.DataAzureadApplication.DataAzureadApplicationOptionalClaimsIdTokenList IdToken
        {
            get => GetInstanceProperty<azuread.DataAzureadApplication.DataAzureadApplicationOptionalClaimsIdTokenList>()!;
        }

        [JsiiProperty(name: "saml2Token", typeJson: "{\"fqn\":\"azuread.dataAzureadApplication.DataAzureadApplicationOptionalClaimsSaml2TokenList\"}")]
        public virtual azuread.DataAzureadApplication.DataAzureadApplicationOptionalClaimsSaml2TokenList Saml2Token
        {
            get => GetInstanceProperty<azuread.DataAzureadApplication.DataAzureadApplicationOptionalClaimsSaml2TokenList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuread.dataAzureadApplication.DataAzureadApplicationOptionalClaims\"}", isOptional: true)]
        public virtual azuread.DataAzureadApplication.IDataAzureadApplicationOptionalClaims? InternalValue
        {
            get => GetInstanceProperty<azuread.DataAzureadApplication.IDataAzureadApplicationOptionalClaims?>();
            set => SetInstanceProperty(value);
        }
    }
}
