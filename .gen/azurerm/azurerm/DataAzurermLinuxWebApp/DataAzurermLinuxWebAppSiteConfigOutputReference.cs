using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLinuxWebApp
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigOutputReference), fullyQualifiedName: "azurerm.dataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermLinuxWebAppSiteConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermLinuxWebAppSiteConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermLinuxWebAppSiteConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermLinuxWebAppSiteConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "alwaysOn", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AlwaysOn
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "apiDefinitionUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiDefinitionUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "apiManagementApiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiManagementApiId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "appCommandLine", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppCommandLine
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "applicationStack", typeJson: "{\"fqn\":\"azurerm.dataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigApplicationStackList\"}")]
        public virtual azurerm.DataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigApplicationStackList ApplicationStack
        {
            get => GetInstanceProperty<azurerm.DataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigApplicationStackList>()!;
        }

        [JsiiProperty(name: "autoHealSetting", typeJson: "{\"fqn\":\"azurerm.dataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigAutoHealSettingList\"}")]
        public virtual azurerm.DataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigAutoHealSettingList AutoHealSetting
        {
            get => GetInstanceProperty<azurerm.DataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigAutoHealSettingList>()!;
        }

        [JsiiProperty(name: "containerRegistryManagedIdentityClientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerRegistryManagedIdentityClientId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "containerRegistryUseManagedIdentity", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ContainerRegistryUseManagedIdentity
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"azurerm.dataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigCorsList\"}")]
        public virtual azurerm.DataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigCorsList Cors
        {
            get => GetInstanceProperty<azurerm.DataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigCorsList>()!;
        }

        [JsiiProperty(name: "defaultDocuments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DefaultDocuments
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "detailedErrorLoggingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DetailedErrorLoggingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ftpsState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FtpsState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "healthCheckEvictionTimeInMin", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthCheckEvictionTimeInMin
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "healthCheckPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "http2Enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Http2Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ipRestriction", typeJson: "{\"fqn\":\"azurerm.dataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigIpRestrictionList\"}")]
        public virtual azurerm.DataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigIpRestrictionList IpRestriction
        {
            get => GetInstanceProperty<azurerm.DataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigIpRestrictionList>()!;
        }

        [JsiiProperty(name: "ipRestrictionDefaultAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpRestrictionDefaultAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "linuxFxVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LinuxFxVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loadBalancingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancingMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "localMysqlEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable LocalMysqlEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "managedPipelineMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedPipelineMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "minimumTlsCipherSuite", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinimumTlsCipherSuite
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "minimumTlsVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinimumTlsVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "remoteDebuggingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RemoteDebuggingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "remoteDebuggingVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemoteDebuggingVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scmIpRestriction", typeJson: "{\"fqn\":\"azurerm.dataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigScmIpRestrictionList\"}")]
        public virtual azurerm.DataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigScmIpRestrictionList ScmIpRestriction
        {
            get => GetInstanceProperty<azurerm.DataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfigScmIpRestrictionList>()!;
        }

        [JsiiProperty(name: "scmIpRestrictionDefaultAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScmIpRestrictionDefaultAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scmMinimumTlsVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScmMinimumTlsVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scmType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScmType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scmUseMainIpRestriction", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ScmUseMainIpRestriction
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "use32BitWorker", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Use32BitWorker
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "vnetRouteAllEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable VnetRouteAllEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "websocketsEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable WebsocketsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "workerCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WorkerCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermLinuxWebApp.DataAzurermLinuxWebAppSiteConfig\"}", isOptional: true)]
        public virtual azurerm.DataAzurermLinuxWebApp.IDataAzurermLinuxWebAppSiteConfig? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermLinuxWebApp.IDataAzurermLinuxWebAppSiteConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
