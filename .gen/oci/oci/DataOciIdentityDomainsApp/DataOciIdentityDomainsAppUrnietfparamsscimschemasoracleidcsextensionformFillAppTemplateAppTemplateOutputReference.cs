using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsApp
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "configuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Configuration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "formCredentialSharingGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FormCredentialSharingGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "formCredMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FormCredMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "formFillUrlMatch", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateFormFillUrlMatchList\"}")]
        public virtual oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateFormFillUrlMatchList FormFillUrlMatch
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateFormFillUrlMatchList>()!;
        }

        [JsiiProperty(name: "formType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FormType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "revealPasswordOnForm", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RevealPasswordOnForm
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "syncFromTemplate", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SyncFromTemplate
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "userNameFormExpression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserNameFormExpression
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userNameFormTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserNameFormTemplate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApp.DataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsApp.IDataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApp.IDataOciIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate?>();
            set => SetInstanceProperty(value);
        }
    }
}
