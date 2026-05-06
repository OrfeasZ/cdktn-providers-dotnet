using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsApps
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accountFormVisible", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AccountFormVisible
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "adminConsentGranted", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AdminConsentGranted
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "bundleConfigurationProperties", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundleConfigurationPropertiesList\"}")]
        public virtual oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundleConfigurationPropertiesList BundleConfigurationProperties
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundleConfigurationPropertiesList>()!;
        }

        [JsiiProperty(name: "bundlePoolConfiguration", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfigurationList\"}")]
        public virtual oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfigurationList BundlePoolConfiguration
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppBundlePoolConfigurationList>()!;
        }

        [JsiiProperty(name: "canBeAuthoritative", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CanBeAuthoritative
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "connected", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Connected
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "connectorBundle", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppConnectorBundleList\"}")]
        public virtual oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppConnectorBundleList ConnectorBundle
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppConnectorBundleList>()!;
        }

        [JsiiProperty(name: "enableAuthSyncNewUserNotification", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableAuthSyncNewUserNotification
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enableSync", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableSync
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enableSyncSummaryReportNotification", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableSyncSummaryReportNotification
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "flatFileBundleConfigurationProperties", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileBundleConfigurationPropertiesList\"}")]
        public virtual oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileBundleConfigurationPropertiesList FlatFileBundleConfigurationProperties
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileBundleConfigurationPropertiesList>()!;
        }

        [JsiiProperty(name: "flatFileConnectorBundle", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileConnectorBundleList\"}")]
        public virtual oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileConnectorBundleList FlatFileConnectorBundle
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileConnectorBundleList>()!;
        }

        [JsiiProperty(name: "identityBridges", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppIdentityBridgesList\"}")]
        public virtual oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppIdentityBridgesList IdentityBridges
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppIdentityBridgesList>()!;
        }

        [JsiiProperty(name: "isAuthoritative", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAuthoritative
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDirectory", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDirectory
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isOnPremiseApp", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsOnPremiseApp
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSchemaCustomizationSupported", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSchemaCustomizationSupported
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSchemaDiscoverySupported", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSchemaDiscoverySupported
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isThreeLeggedOauthEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsThreeLeggedOauthEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isTwoLeggedOauthEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsTwoLeggedOauthEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "objectClasses", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppObjectClassesList\"}")]
        public virtual oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppObjectClassesList ObjectClasses
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppObjectClassesList>()!;
        }

        [JsiiProperty(name: "syncConfigLastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SyncConfigLastModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "threeLeggedOauthCredential", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredentialList\"}")]
        public virtual oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredentialList ThreeLeggedOauthCredential
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredentialList>()!;
        }

        [JsiiProperty(name: "threeLeggedOauthProviderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ThreeLeggedOauthProviderName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappApp\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsApps.IDataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappApp? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApps.IDataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionmanagedappApp?>();
            set => SetInstanceProperty(value);
        }
    }
}
