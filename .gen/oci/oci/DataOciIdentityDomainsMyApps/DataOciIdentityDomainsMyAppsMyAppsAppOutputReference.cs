using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsMyApps
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsAppOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsAppOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsMyAppsMyAppsAppOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsMyAppsMyAppsAppOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsMyAppsMyAppsAppOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsMyAppsMyAppsAppOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "active", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Active
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "appIcon", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppIcon
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "appThumbnail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppThumbnail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "display", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Display
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAliasApp", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAliasApp
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isLoginTarget", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLoginTarget
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isOpcService", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsOpcService
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "loginMechanism", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoginMechanism
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ref", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ref
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceTypeUrn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceTypeUrn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "showInMyApps", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShowInMyApps
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Value
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsApp\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsMyApps.IDataOciIdentityDomainsMyAppsMyAppsApp? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyApps.IDataOciIdentityDomainsMyAppsMyAppsApp?>();
            set => SetInstanceProperty(value);
        }
    }
}
