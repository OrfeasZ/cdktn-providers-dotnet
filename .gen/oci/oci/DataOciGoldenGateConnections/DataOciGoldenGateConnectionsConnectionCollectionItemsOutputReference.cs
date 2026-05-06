using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciGoldenGateConnections
{
    [JsiiClass(nativeType: typeof(oci.DataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciGoldenGateConnectionsConnectionCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciGoldenGateConnectionsConnectionCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciGoldenGateConnectionsConnectionCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGoldenGateConnectionsConnectionCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountKeySecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountKeySecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "additionalAttributes", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsAdditionalAttributesList\"}")]
        public virtual oci.DataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsAdditionalAttributesList AdditionalAttributes
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsAdditionalAttributesList>()!;
        }

        [JsiiProperty(name: "authenticationMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "azureAuthorityHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzureAuthorityHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "azureTenantId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzureTenantId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapServers", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsBootstrapServersList\"}")]
        public virtual oci.DataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsBootstrapServersList BootstrapServers
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsBootstrapServersList>()!;
        }

        [JsiiProperty(name: "catalog", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsCatalogList\"}")]
        public virtual oci.DataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsCatalogList Catalog
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsCatalogList>()!;
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientSecret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientSecretSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientSecretSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterPlacementGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionFactory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionFactory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "consumerProperties", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsumerProperties
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "coreSiteXml", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CoreSiteXml
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbSystemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "doesUseSecretIds", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DoesUseSecretIds
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fingerprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Host
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ingressIps", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsIngressIpsList\"}")]
        public virtual oci.DataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsIngressIpsList IngressIps
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsIngressIpsList>()!;
        }

        [JsiiProperty(name: "isLockOverride", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLockOverride
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "jndiConnectionFactory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JndiConnectionFactory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jndiInitialContextFactory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JndiInitialContextFactory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jndiProviderUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JndiProviderUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jndiSecurityCredentials", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JndiSecurityCredentials
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jndiSecurityCredentialsSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JndiSecurityCredentialsSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jndiSecurityPrincipal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JndiSecurityPrincipal
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyStore", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyStore
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyStorePassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyStorePassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyStorePasswordSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyStorePasswordSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyStoreSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyStoreSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locks", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsLocksList\"}")]
        public virtual oci.DataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsLocksList Locks
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsLocksList>()!;
        }

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateKeyFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateKeyFile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateKeyFileSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateKeyFileSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateKeyPassphrase", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateKeyPassphrase
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateKeyPassphraseSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateKeyPassphraseSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "producerProperties", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProducerProperties
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicKeyFingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicKeyFingerprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "redisClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedisClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routingMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sasToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SasToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sasTokenSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SasTokenSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secretAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretAccessKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secretAccessKeySecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretAccessKeySecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityAttributes", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SecurityAttributes
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "securityProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityProtocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "servers", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Servers
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceAccountKeyFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccountKeyFile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceAccountKeyFileSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccountKeyFileSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sessionMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SessionMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shouldUseJndi", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShouldUseJndi
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "shouldUseResourcePrincipal", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShouldUseResourcePrincipal
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "shouldValidateServerCertificate", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShouldValidateServerCertificate
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "sslCa", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslCa
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslCert", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslCert
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslClientKeystash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslClientKeystash
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslClientKeystashSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslClientKeystashSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslClientKeystoredb", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslClientKeystoredb
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslClientKeystoredbSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslClientKeystoredbSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslCrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslCrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslKeyPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslKeyPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslKeyPasswordSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslKeyPasswordSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslKeySecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslKeySecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslServerCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslServerCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storage", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsStorageList\"}")]
        public virtual oci.DataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsStorageList Storage
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItemsStorageList>()!;
        }

        [JsiiProperty(name: "storageCredentialName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageCredentialName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streamPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamPoolId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "technologyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TechnologyType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenancyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenantId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tlsCaFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TlsCaFile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tlsCertificateKeyFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TlsCertificateKeyFile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tlsCertificateKeyFilePassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TlsCertificateKeyFilePassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tlsCertificateKeyFilePasswordSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TlsCertificateKeyFilePasswordSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tlsCertificateKeyFileSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TlsCertificateKeyFileSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "triggerRefresh", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable TriggerRefresh
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "trustStore", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrustStore
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trustStorePassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrustStorePassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trustStorePasswordSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrustStorePasswordSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trustStoreSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrustStoreSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Username
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "wallet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Wallet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "walletSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WalletSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateConnections.DataOciGoldenGateConnectionsConnectionCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciGoldenGateConnections.IDataOciGoldenGateConnectionsConnectionCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateConnections.IDataOciGoldenGateConnectionsConnectionCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
